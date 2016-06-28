using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace iconeBox_manager
{
    public partial class BoxManager : Form
    {
        List<Area> areaBox = new List<Area>();
        List<Area> dropZone = new List<Area>();
        Point apercuMouseLocation;
        Point apercuMouseDownLocation;
        private Box boxClickedDown;
        public bool isApercuClickDown = false;
        bool apercuMouseMove = false;

        delegate void workOnBox(Box b);
        ColorDialog colorBGDialog = new ColorDialog();
        ColorDialog colorTitleDialog = new ColorDialog();

        FolderBrowserDialog boxPathDialog = new FolderBrowserDialog();
        static Config conf = new Config();
        FolderBrowserDialog confIniPath;
        public static string defaultboxName = "new box";
        char I = '\\';

        public BoxManager()
        {
            InitializeComponent();
            displayButtonimage();
            getPathServ();

            dialogIni();

            initData();
            showOption();

            addEvent();

            
        }

        private void addEvent()
        {
            //clickup
            GlobalMouseHandler globalClick = new GlobalMouseHandler(this);
            Application.AddMessageFilter(globalClick);

            //update
            this.buttonUpdate.MouseEnter += this.ButtonUpdate_MouseHover;
            this.buttonUpdate.MouseLeave += this.ButtonUpdate_MouseLeave;
            this.buttonUpdate.MouseDown += ButtonUpdate_MouseDown;
            this.buttonUpdate.MouseUp += this.ButtonUpdate_MouseUp;

            //apercu
            this.apercu.MouseMove += Apercu_MouseMove;
            this.apercu.MouseDown += Apercu_MouseDown;
            //apercu.MouseClick += Apercu_MouseClick;

            //dl
            dl.MouseEnter += Dl_MouseHover;
            dl.MouseDown += Dl_MouseClick;
            dl.MouseUp += Dl_MouseUp;
            dl.MouseLeave += Dl_MouseLeave;

            //annuler
            annuler.MouseEnter += Annuler_MouseEnter;
            annuler.MouseLeave += Annuler_MouseLeave;
            annuler.MouseDown += Annuler_MouseDown;
            annuler.MouseUp += Annuler_MouseUp;
        }

        private void dialogIni()
        {
            confIniPath = new FolderBrowserDialog();
            confIniPath.SelectedPath = AppDomain.CurrentDomain.BaseDirectory;
        }

        void showOption()
        {
            isSelectedItem();

            if (listBox.Items.Count == 0)
                groupOptionDesDossier.Visible = false;
            else
            {
                groupOptionDesDossier.Visible = true;
                listBox.SetSelected(0, true);
            }
        }

        private void getPathServ()
        {
            try
            {
                pathConfIni.Text = File.ReadAllText("groupe.txt");
            }
            catch { }
        }

        private void initData()
        {
            //get confinit.txt
            string confFile;
            string[] confInit;
            StreamReader file = null;
            try
            {
                if(!pathConfIni.Text.Equals(""))
                    file = new StreamReader(pathConfIni.Text+I+"conf_init.txt");
            }
            catch
            {
                Debug.WriteLine("conf_init.txt introuvable");
            }

            if (file != null)//si conf présent on import les données
            {
                confFile = file.ReadToEnd();
                confInit = confFile.Split('|');

                //conf init
                if (!confInit[0].Equals(""))
                    conf = JsonConvert.DeserializeObject<Config>(confInit[0]);
                else
                    conf = new Config();


                //parse conf BOX
                if (!confInit[1].Equals(""))
                {
                    Box[] b;
                    b = JsonConvert.DeserializeObject<Box[]>(confInit[1]);
                    foreach (Box bb in b)
                        listBox.Items.Add(bb);

                    //init apercu
                    if(b.Length > 0)
                    {
                        boxClickedDown = (Box)listBox.Items[0];
                    }
                }
                file.Close();
            }
            else//si pas de fichier
            {
                conf = new Config();
            }

            //on remplis les champs
            nbColonne.Value = conf.colone;
            pass.Text = conf.pass;
            enable.Checked = conf.enable;
        }

        private void buttonBGColor_Click(object sender, EventArgs e)
        {
            if(colorBGDialog.ShowDialog() == DialogResult.OK)
            {
                ((Button)sender).BackColor = colorBGDialog.Color;
                setSelectedBox(delegate (Box b) { b.setColorBg(colorBGDialog.Color);});
            }
        }

        private void dialogConfPath_Click(object sender, EventArgs e)
        {
            if (confIniPath.ShowDialog() == DialogResult.OK)
            {
                pathConfIni.Text = confIniPath.SelectedPath;
                File.WriteAllText("path_conf.txt", confIniPath.SelectedPath);
            }
        }

        private void nbColonne_ValueChanged(object sender, EventArgs e)
        {
            conf.colone = (int)nbColonne.Value;
            updateApercu();
        }

        public void updateApercu()
        {
            apercu.Invalidate();
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            conf.pass = pass.Text;
        }

        private void listBox_SelectedIndexChangedDoNothin(object sender, EventArgs e)
        {

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //si rien n'est selectioner
            if (isSelectedItem())
            {
                setFormulaire(getBox(listBox.SelectedIndex));
            }
            updateApercu();
        }

        //dislay content according to selected item
        bool isSelectedItem()
        {
            bool rez = true;
            if (listBox.SelectedItems.Count == 0)//si rien de selectionner
            {
                groupOptionDesDossier.Visible = false;
                sup.Visible = false;
                up.Visible = false;
                down.Visible = false;
                rez = false;
            }
            else
            {
                if (listBox.SelectedItems.Count > 1)//si plus d'une box est selectioné
                {
                    groupDossier.Visible = false;
                    up.Visible = false;
                    down.Visible = false;
                }
                else
                {
                    if (!groupDossier.Visible || !up.Visible || !down.Visible)
                    {
                        groupDossier.Visible = true;
                        up.Visible = true;
                        down.Visible = true;
                    }
                }

                if (listBox.Items.Count < 2)//si il y a moins de 2 item
                {
                    up.Visible = false;
                    down.Visible = false;
                }
                else
                {
                    if(!up.Visible || !down.Visible)
                    up.Visible = true;
                    down.Visible = true;
                }
                if (!(sup.Visible && groupOptionDesDossier.Visible)) {
                    sup.Visible = true;
                    groupOptionDesDossier.Visible = true;
                }
            }
            return rez;
        }

        private void setFormulaire(Box box)
        {
            boxName.Text = box.titleBox;
            boxPath.Text = box.folderPath;
            coefX.Value = box.getCoefX();
            coefY.Value = box.getCoefY();
            slidX.Value = box.getCoefX();
            slidY.Value = box.getCoefY();
            buttonBGColor.BackColor = box.getColorBg();
            titleColor.BackColor = box.getColorTitle();
            borderWidth.Value = box.borderThickness;
            radius.Value = box.radiusBorder;
            if (boxPath.Text.Equals(""))
                boxPath.BackColor = Color.Red;
            else
                boxPath.BackColor = Color.White;
        }

        private void openPath_Click(object sender, EventArgs e)
        {
            if(boxPathDialog.ShowDialog() == DialogResult.OK)
            {
                boxPath.Text = boxPathDialog.SelectedPath;
            }
        }

        private void boxPath_TextChanged(object sender, EventArgs e)
        {
            string p = boxPath.Text;

            //modifier le nom si c'est le nom par default ou si il est vide
            ((Box)(listBox.SelectedItem)).folderPath = p;
            string nom = p.Substring(p.LastIndexOf('\\') + 1);

            if(!nom.Equals(""))
                 boxName.Text = nom;

            //if path empty alert user
            if (boxPath.Text.Equals(""))
                boxPath.BackColor = Color.Red;
            else
                boxPath.BackColor = Color.White;
        }

        Box getBox(int i)
        {
            return (Box)listBox.Items[i];
        }



        private void boxName_TextChanged(object sender, EventArgs e)
        {
            listBox.SelectedIndexChanged -= listBox_SelectedIndexChanged;
            ((Box)(listBox.SelectedItem)).titleBox = boxName.Text;
            listBox.Items[listBox.SelectedIndex] = new Box((Box)listBox.SelectedItem);
            updateApercu();
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
        }

        private void add_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (listBox.Items.Count != 0)//si la liste n'est pas vide
            {
                Box b = new Box(getBox(i));
                b.titleBox = "new box";
                b.folderPath = "";
                b.setNew(true);//signal qu'il faudra importer le dossir
                i = listBox.SelectedIndex+1;
                listBox.Items.Insert(i, b);
            }
            else
            {
                Box b = new Box();
                b.setNew(true);//signal qu'il faudra importer le dossir
                listBox.Items.Insert(i, b);
            }
            //listBox.SelectedIndexChanged -= listBox_SelectedIndexChanged;
            clearListBox();
            //listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;

            listBox.SetSelected(i, true);
            boxClickedDown = (Box)listBox.Items[i];
        }

        private void sup_Click(object sender, EventArgs e)
        {
            int firstSelectedIndex = listBox.SelectedIndex;
            IEnumerable<Box> lb = listBox.SelectedItems.Cast<Box>();
            
            int j = lb.Count<Box>();
            //avoid blinking
            bool handelerRemoved = false;
            if (listBox.Items.Count > j)
            {
                listBox.SelectedIndexChanged -= listBox_SelectedIndexChanged;
                handelerRemoved = true;
            }

            for (int i = 0; i < j; i++) 
            {
                R.boxToRemove.Add(lb.ElementAt<Box>(0));
                listBox.Items.Remove(lb.ElementAt<Box>(0));
            }

            //avoid blink
            if(handelerRemoved)
                listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;

            if (listBox.Items.Count != 0)
                if(listBox.Items.Count > firstSelectedIndex)
                    listBox.SetSelected(firstSelectedIndex, true);
                else
                    listBox.SetSelected(listBox.Items.Count-1, true);
        }

        void setSelectedBox(workOnBox work)
        {
            for(int i = 0; i < listBox.Items.Count; i++)
            {
                if (listBox.GetSelected(i))
                {
                    work(getBox(i));
                }
            }
            updateApercu();
        }

        private void up_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex > 0)
            {
                listBox.SelectedIndexChanged -= listBox_SelectedIndexChanged;
                int i = listBox.SelectedIndex;
                Box b = new Box((Box)listBox.SelectedItem);

                listBox.Items.Remove(listBox.SelectedItem);
                listBox.Items.Insert(i-1, b);
                listBox.SetSelected(i - 1, true);
                listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            }
        }

        private void coefX_ValueChanged(object sender, EventArgs e)
        {
            setSelectedBox(delegate(Box b){ b.setCoefX((int)coefX.Value); });
            slidX.Value = (int)coefX.Value;
        }

        private void coefY_ValueChanged(object sender, EventArgs e)
        {
            setSelectedBox(delegate (Box b) { b.setCoefY((int)coefY.Value); });
            slidY.Value = (int)coefY.Value;
        }

        private void titleColor_Click(object sender, EventArgs e)
        {
            if(colorTitleDialog.ShowDialog() == DialogResult.OK)
            {
                titleColor.BackColor = colorTitleDialog.Color;
                setSelectedBox(delegate (Box b) { b.setColorTitle(colorTitleDialog.Color); });
            }
        }

        private void borderWidth_ValueChanged(object sender, EventArgs e)
        {
            setSelectedBox(delegate (Box b) { b.borderThickness = ((int)borderWidth.Value); });
        }

        private void radius_ValueChanged(object sender, EventArgs e)
        {
            setSelectedBox(delegate (Box b) { b.radiusBorder = ((int)radius.Value); });
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string groupe = pathConfIni.Text;

            if (!groupe.Equals("") && !isPathsEmpty())
            {
                String configString = JsonConvert.SerializeObject(conf);

                //suprimer box deleted
                foreach (Box b in R.boxToRemove)
                {
                    try
                    {
                        if (!b.isNew() && b.folderPath.LastIndexOf('\\') == -1)
                            Directory.Delete(groupe + I + b.folderPath, true);
                    }
                    catch { }
                }

                if (!Directory.Exists(groupe))//si groupe n'existe pas on le créé
                {
                    Directory.CreateDirectory(groupe);
                }

                Box[] tabBox = new Box[listBox.Items.Count];
                for (int i = 0; i < listBox.Items.Count; i++)
                {
                    Box b = (Box)listBox.Items[i];

                    if (b.isNew())//si box nouvelle on l'importe
                    {
                        R.cpd(b.folderPath, R.ici + groupe);
                    }

                    //copier dossier
                    b.folderPath = b.folderPath.Substring(b.folderPath.LastIndexOf('\\')+1);
                    tabBox[i] = b;
                }
                string boxString = JsonConvert.SerializeObject(tabBox);
                File.WriteAllText("conf_init.txt", configString + "|" + boxString);
                R.cp(R.ici+"conf_init.txt", R.ici+groupe);
                File.Delete("conf_init.txt");
                File.WriteAllText("groupe.txt", groupe);
                MessageBox.Show("la Configuration a bien été envoyée!", "Envoi effectué");
            }
            else
            {
                MessageBox.Show("Le champ Groupe doit etre remplit");
            }
            
        }

        private bool isPathsEmpty()
        {
            bool rez = false;
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                Box b = (Box)listBox.Items[i];
                if (b.folderPath.Equals(""))
                {
                    rez = true;
                    MessageBox.Show(b.titleBox+" doit avoir un chemin");
                    break;
                }
            }
            return rez;
        }

        private void down_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex < listBox.Items.Count-1)
            {
                listBox.SelectedIndexChanged -= listBox_SelectedIndexChanged;
                int i = listBox.SelectedIndex;
                Box b = new Box((Box)listBox.SelectedItem);

                listBox.Items.Remove(listBox.SelectedItem);
                listBox.Items.Insert(i + 1, b);
                listBox.SetSelected(i + 1, true);
                listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            }
        }

        //-------------------------------------------------------------------------------------------
        //-------------------------------------PAINT-------------------------------------------------
        //-------------------------------------------------------------------------------------------
        private void apercu_Paint(object sender, PaintEventArgs e)
        {
            if (listBox.Items.Count > 0)
            {
                Graphics g = e.Graphics;

                int nbBox = listBox.Items.Count;
                int nbColonne = conf.colone;

                int nbLine = (nbBox % conf.colone == 0) ? (int)nbBox / conf.colone : (int)nbBox / conf.colone + 1;//definie le nb de line
                Rectangle screen = new Rectangle(new Point(0, 0), apercu.Size);
                Size zonne = new Size((int)(screen.Width / nbColonne), (int)(screen.Height / nbLine));
                int currentLine = 0;
                int currentColonne = 0;

                //font noire
               // g.FillRectangle(Brushes.Black, screen);

                //clear area
                areaBox.Clear();
                dropZone.Clear();


                for (int i = 0; i < nbBox; i++)
                {
                    if (currentColonne >= nbColonne)
                    {
                        currentColonne = 0;
                        currentLine++;
                    }

                    Box b = (Box)listBox.Items[i];

                    int widthBox = (int)(zonne.Width * b.coefX);
                    int heightBox = (int)(zonne.Height * b.coefY);
                    int leftBox = (int)(currentColonne * zonne.Width) + ((int)(zonne.Width / 2) - (int)(widthBox / 2));
                    int topBox = (currentLine * zonne.Height) + ((zonne.Height / 2) - (heightBox / 2));

                    //area drop
                    dropZone.Add(new Area(b, new Rectangle(currentColonne * zonne.Width, currentLine * zonne.Height, zonne.Width, zonne.Height)));
                    if (boxClickedDown.Equals(b) && apercuMouseMove)//si c'est la box selectioner
                    {
                        leftBox = apercuMouseLocation.X - widthBox / 2;
                        topBox = apercuMouseLocation.Y - heightBox / 2;
                    }

                    currentColonne++;

                    SolidBrush myBrush = new SolidBrush(b.getColorBg());
                    //bg
                    Rectangle recBox = new Rectangle(leftBox, topBox, widthBox, heightBox);
                    g.FillRectangle(myBrush, recBox);

                    //bord
                    Pen titlePen = new Pen(b.getColorTitle());
                    if (isSelected(b))
                    {
                        titlePen.Width = 3;
                    }

                    g.DrawRectangle(titlePen, recBox);

                    //separator
                    g.DrawLine(titlePen, leftBox, b.titleHeight / 4 + topBox, leftBox + widthBox, b.titleHeight / 4 + topBox);

                    //draw titre
                    Font drawFont = new Font("arial", 10f);
                    myBrush.Color = b.getColorTitle();
                    StringFormat drawFormat = new StringFormat();
                    Size s = TextRenderer.MeasureText(b.titleBox, drawFont);
                    g.DrawString(b.titleBox, drawFont, myBrush, new PointF(leftBox + widthBox / 2 - s.Width / 2, topBox + heightBox / 2 - s.Height / 2));
                    //make area clicable
                    areaBox.Add(new Area(b, recBox));
                }
            }
            else
            {
                Graphics g = e.Graphics;
                g.FillRectangle(Brushes.Black, new Rectangle(new Point(0, 0), apercu.Size));
            }
        }
        //-----------------------------------------------------------------------------------------------------------
        bool isSelected(Box b)
        {
            return listBox.GetSelected(listBox.Items.IndexOf(b));
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            coefX.Value = slidX.Value;
        }

        private void slidY_Scroll(object sender, EventArgs e)
        {
            coefY.Value = slidY.Value;
        }

        private void enable_CheckedChanged(object sender, EventArgs e)
        {
            conf.enable = enable.Checked;
        }
    }
}
