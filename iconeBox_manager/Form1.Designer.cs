using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace iconeBox_manager
{
    partial class BoxManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoxManager));
            this.optionGlobal = new System.Windows.Forms.GroupBox();
            this.enable = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nbColonne = new System.Windows.Forms.NumericUpDown();
            this.labelNbColone = new System.Windows.Forms.Label();
            this.dialogConfPath = new System.Windows.Forms.Button();
            this.pathConfIni = new System.Windows.Forms.TextBox();
            this.labelConfig = new System.Windows.Forms.Label();
            this.sup = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.down = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.groupOptionDesDossier = new System.Windows.Forms.GroupBox();
            this.groupBordure = new System.Windows.Forms.GroupBox();
            this.radius = new System.Windows.Forms.NumericUpDown();
            this.borderWidth = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupCouleur = new System.Windows.Forms.GroupBox();
            this.titleColor = new System.Windows.Forms.Button();
            this.buttonBGColor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grouptaille = new System.Windows.Forms.GroupBox();
            this.slidY = new System.Windows.Forms.TrackBar();
            this.slidX = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.coefY = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.coefX = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupDossier = new System.Windows.Forms.GroupBox();
            this.openPath = new System.Windows.Forms.Button();
            this.boxPath = new System.Windows.Forms.TextBox();
            this.boxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.PictureBox();
            this.ecranImage = new System.Windows.Forms.PictureBox();
            this.groupApercu = new System.Windows.Forms.GroupBox();
            this.dl = new System.Windows.Forms.PictureBox();
            this.annuler = new System.Windows.Forms.PictureBox();
            this.apercu = new iconeBox_manager.Apercu();
            this.optionGlobal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbColonne)).BeginInit();
            this.groupBox.SuspendLayout();
            this.groupOptionDesDossier.SuspendLayout();
            this.groupBordure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderWidth)).BeginInit();
            this.groupCouleur.SuspendLayout();
            this.grouptaille.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slidY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slidX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefX)).BeginInit();
            this.groupDossier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecranImage)).BeginInit();
            this.groupApercu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.annuler)).BeginInit();
            this.SuspendLayout();
            // 
            // optionGlobal
            // 
            this.optionGlobal.Controls.Add(this.enable);
            this.optionGlobal.Controls.Add(this.label12);
            this.optionGlobal.Controls.Add(this.pass);
            this.optionGlobal.Controls.Add(this.label11);
            this.optionGlobal.Controls.Add(this.nbColonne);
            this.optionGlobal.Controls.Add(this.labelNbColone);
            this.optionGlobal.Controls.Add(this.dialogConfPath);
            this.optionGlobal.Controls.Add(this.pathConfIni);
            this.optionGlobal.Controls.Add(this.labelConfig);
            this.optionGlobal.ForeColor = System.Drawing.SystemColors.InfoText;
            this.optionGlobal.Location = new System.Drawing.Point(12, 12);
            this.optionGlobal.Name = "optionGlobal";
            this.optionGlobal.Size = new System.Drawing.Size(236, 134);
            this.optionGlobal.TabIndex = 0;
            this.optionGlobal.TabStop = false;
            this.optionGlobal.Text = "option générale";
            // 
            // enable
            // 
            this.enable.AutoSize = true;
            this.enable.Location = new System.Drawing.Point(79, 105);
            this.enable.Name = "enable";
            this.enable.Size = new System.Drawing.Size(15, 14);
            this.enable.TabIndex = 10;
            this.enable.UseVisualStyleBackColor = true;
            this.enable.CheckedChanged += new System.EventHandler(this.enable_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Activer";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(79, 74);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(151, 20);
            this.pass.TabIndex = 8;
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "mot de passe";
            // 
            // nbColonne
            // 
            this.nbColonne.Location = new System.Drawing.Point(79, 48);
            this.nbColonne.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbColonne.Name = "nbColonne";
            this.nbColonne.Size = new System.Drawing.Size(151, 20);
            this.nbColonne.TabIndex = 6;
            this.nbColonne.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbColonne.ValueChanged += new System.EventHandler(this.nbColonne_ValueChanged);
            // 
            // labelNbColone
            // 
            this.labelNbColone.AutoSize = true;
            this.labelNbColone.Location = new System.Drawing.Point(6, 50);
            this.labelNbColone.Name = "labelNbColone";
            this.labelNbColone.Size = new System.Drawing.Size(45, 13);
            this.labelNbColone.TabIndex = 5;
            this.labelNbColone.Text = "colonne";
            // 
            // dialogConfPath
            // 
            this.dialogConfPath.Location = new System.Drawing.Point(209, 19);
            this.dialogConfPath.Name = "dialogConfPath";
            this.dialogConfPath.Size = new System.Drawing.Size(21, 20);
            this.dialogConfPath.TabIndex = 4;
            this.dialogConfPath.Text = "+";
            this.dialogConfPath.UseVisualStyleBackColor = true;
            this.dialogConfPath.Click += new System.EventHandler(this.dialogConfPath_Click);
            // 
            // pathConfIni
            // 
            this.pathConfIni.Location = new System.Drawing.Point(79, 19);
            this.pathConfIni.Name = "pathConfIni";
            this.pathConfIni.Size = new System.Drawing.Size(124, 20);
            this.pathConfIni.TabIndex = 3;
            // 
            // labelConfig
            // 
            this.labelConfig.AutoSize = true;
            this.labelConfig.Location = new System.Drawing.Point(6, 20);
            this.labelConfig.Name = "labelConfig";
            this.labelConfig.Size = new System.Drawing.Size(60, 13);
            this.labelConfig.TabIndex = 2;
            this.labelConfig.Text = "Déstination";
            // 
            // sup
            // 
            this.sup.Location = new System.Drawing.Point(121, 19);
            this.sup.Name = "sup";
            this.sup.Size = new System.Drawing.Size(102, 22);
            this.sup.TabIndex = 1;
            this.sup.Text = "Supprimer";
            this.sup.UseVisualStyleBackColor = true;
            this.sup.Click += new System.EventHandler(this.sup_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(9, 19);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(106, 22);
            this.add.TabIndex = 0;
            this.add.Text = "Ajout";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(9, 47);
            this.listBox.Name = "listBox";
            this.listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox.Size = new System.Drawing.Size(214, 134);
            this.listBox.TabIndex = 1;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.down);
            this.groupBox.Controls.Add(this.up);
            this.groupBox.Controls.Add(this.listBox);
            this.groupBox.Controls.Add(this.sup);
            this.groupBox.Controls.Add(this.add);
            this.groupBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox.Location = new System.Drawing.Point(12, 152);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(236, 225);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Dossier";
            // 
            // down
            // 
            this.down.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.down.Location = new System.Drawing.Point(121, 187);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(102, 31);
            this.down.TabIndex = 3;
            this.down.Text = "↓";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // up
            // 
            this.up.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up.Location = new System.Drawing.Point(9, 187);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(106, 31);
            this.up.TabIndex = 2;
            this.up.Text = "↑";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // groupOptionDesDossier
            // 
            this.groupOptionDesDossier.BackColor = System.Drawing.SystemColors.Control;
            this.groupOptionDesDossier.Controls.Add(this.groupBordure);
            this.groupOptionDesDossier.Controls.Add(this.groupCouleur);
            this.groupOptionDesDossier.Controls.Add(this.grouptaille);
            this.groupOptionDesDossier.Controls.Add(this.groupDossier);
            this.groupOptionDesDossier.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupOptionDesDossier.Location = new System.Drawing.Point(269, 12);
            this.groupOptionDesDossier.Name = "groupOptionDesDossier";
            this.groupOptionDesDossier.Size = new System.Drawing.Size(253, 365);
            this.groupOptionDesDossier.TabIndex = 3;
            this.groupOptionDesDossier.TabStop = false;
            this.groupOptionDesDossier.Text = "Options des dossiers";
            // 
            // groupBordure
            // 
            this.groupBordure.BackColor = System.Drawing.SystemColors.Control;
            this.groupBordure.Controls.Add(this.radius);
            this.groupBordure.Controls.Add(this.borderWidth);
            this.groupBordure.Controls.Add(this.label8);
            this.groupBordure.Controls.Add(this.label7);
            this.groupBordure.Location = new System.Drawing.Point(6, 277);
            this.groupBordure.Name = "groupBordure";
            this.groupBordure.Size = new System.Drawing.Size(241, 80);
            this.groupBordure.TabIndex = 3;
            this.groupBordure.TabStop = false;
            this.groupBordure.Text = "Bordure";
            // 
            // radius
            // 
            this.radius.Location = new System.Drawing.Point(72, 48);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(37, 20);
            this.radius.TabIndex = 3;
            this.radius.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.radius.ValueChanged += new System.EventHandler(this.radius_ValueChanged);
            // 
            // borderWidth
            // 
            this.borderWidth.Location = new System.Drawing.Point(72, 23);
            this.borderWidth.Name = "borderWidth";
            this.borderWidth.Size = new System.Drawing.Size(37, 20);
            this.borderWidth.TabIndex = 2;
            this.borderWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.borderWidth.ValueChanged += new System.EventHandler(this.borderWidth_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "radius";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "épaisseur";
            // 
            // groupCouleur
            // 
            this.groupCouleur.Controls.Add(this.titleColor);
            this.groupCouleur.Controls.Add(this.buttonBGColor);
            this.groupCouleur.Controls.Add(this.label6);
            this.groupCouleur.Controls.Add(this.label1);
            this.groupCouleur.Location = new System.Drawing.Point(6, 191);
            this.groupCouleur.Name = "groupCouleur";
            this.groupCouleur.Size = new System.Drawing.Size(241, 80);
            this.groupCouleur.TabIndex = 2;
            this.groupCouleur.TabStop = false;
            this.groupCouleur.Text = "Couleur";
            // 
            // titleColor
            // 
            this.titleColor.BackColor = System.Drawing.Color.Gainsboro;
            this.titleColor.Location = new System.Drawing.Point(72, 49);
            this.titleColor.Name = "titleColor";
            this.titleColor.Size = new System.Drawing.Size(163, 22);
            this.titleColor.TabIndex = 3;
            this.titleColor.UseVisualStyleBackColor = false;
            this.titleColor.Click += new System.EventHandler(this.titleColor_Click);
            // 
            // buttonBGColor
            // 
            this.buttonBGColor.BackColor = System.Drawing.Color.DimGray;
            this.buttonBGColor.Location = new System.Drawing.Point(72, 21);
            this.buttonBGColor.Name = "buttonBGColor";
            this.buttonBGColor.Size = new System.Drawing.Size(163, 22);
            this.buttonBGColor.TabIndex = 1;
            this.buttonBGColor.UseVisualStyleBackColor = false;
            this.buttonBGColor.Click += new System.EventHandler(this.buttonBGColor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "couleur titre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arrière plan";
            // 
            // grouptaille
            // 
            this.grouptaille.Controls.Add(this.slidY);
            this.grouptaille.Controls.Add(this.slidX);
            this.grouptaille.Controls.Add(this.label10);
            this.grouptaille.Controls.Add(this.coefY);
            this.grouptaille.Controls.Add(this.label9);
            this.grouptaille.Controls.Add(this.coefX);
            this.grouptaille.Controls.Add(this.label5);
            this.grouptaille.Controls.Add(this.label4);
            this.grouptaille.Location = new System.Drawing.Point(6, 105);
            this.grouptaille.Name = "grouptaille";
            this.grouptaille.Size = new System.Drawing.Size(241, 80);
            this.grouptaille.TabIndex = 1;
            this.grouptaille.TabStop = false;
            this.grouptaille.Text = "Taille";
            // 
            // slidY
            // 
            this.slidY.Location = new System.Drawing.Point(131, 48);
            this.slidY.Maximum = 100;
            this.slidY.Minimum = 10;
            this.slidY.Name = "slidY";
            this.slidY.Size = new System.Drawing.Size(104, 45);
            this.slidY.TabIndex = 7;
            this.slidY.TickFrequency = 10;
            this.slidY.Value = 10;
            this.slidY.Scroll += new System.EventHandler(this.slidY_Scroll);
            // 
            // slidX
            // 
            this.slidX.BackColor = System.Drawing.SystemColors.Control;
            this.slidX.Location = new System.Drawing.Point(131, 19);
            this.slidX.Margin = new System.Windows.Forms.Padding(0);
            this.slidX.Maximum = 100;
            this.slidX.Minimum = 10;
            this.slidX.Name = "slidX";
            this.slidX.Size = new System.Drawing.Size(104, 45);
            this.slidX.TabIndex = 6;
            this.slidX.TickFrequency = 10;
            this.slidX.Value = 10;
            this.slidX.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(112, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 18);
            this.label10.TabIndex = 5;
            this.label10.Text = "%";
            // 
            // coefY
            // 
            this.coefY.Location = new System.Drawing.Point(72, 51);
            this.coefY.Name = "coefY";
            this.coefY.Size = new System.Drawing.Size(37, 20);
            this.coefY.TabIndex = 4;
            this.coefY.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.coefY.ValueChanged += new System.EventHandler(this.coefY_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(112, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "%";
            // 
            // coefX
            // 
            this.coefX.Location = new System.Drawing.Point(72, 25);
            this.coefX.Name = "coefX";
            this.coefX.Size = new System.Drawing.Size(37, 20);
            this.coefX.TabIndex = 2;
            this.coefX.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.coefX.ValueChanged += new System.EventHandler(this.coefX_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "hauteur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "largeur";
            // 
            // groupDossier
            // 
            this.groupDossier.Controls.Add(this.openPath);
            this.groupDossier.Controls.Add(this.boxPath);
            this.groupDossier.Controls.Add(this.boxName);
            this.groupDossier.Controls.Add(this.label3);
            this.groupDossier.Controls.Add(this.label2);
            this.groupDossier.Location = new System.Drawing.Point(6, 19);
            this.groupDossier.Name = "groupDossier";
            this.groupDossier.Size = new System.Drawing.Size(241, 80);
            this.groupDossier.TabIndex = 0;
            this.groupDossier.TabStop = false;
            this.groupDossier.Text = "dossier";
            // 
            // openPath
            // 
            this.openPath.Location = new System.Drawing.Point(215, 48);
            this.openPath.Name = "openPath";
            this.openPath.Size = new System.Drawing.Size(20, 20);
            this.openPath.TabIndex = 4;
            this.openPath.Text = "+";
            this.openPath.UseVisualStyleBackColor = true;
            this.openPath.Click += new System.EventHandler(this.openPath_Click);
            // 
            // boxPath
            // 
            this.boxPath.Location = new System.Drawing.Point(72, 48);
            this.boxPath.Name = "boxPath";
            this.boxPath.Size = new System.Drawing.Size(137, 20);
            this.boxPath.TabIndex = 3;
            this.boxPath.TextChanged += new System.EventHandler(this.boxPath_TextChanged);
            // 
            // boxName
            // 
            this.boxName.BackColor = System.Drawing.SystemColors.Window;
            this.boxName.Location = new System.Drawing.Point(72, 22);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(163, 20);
            this.boxName.TabIndex = 2;
            this.boxName.TextChanged += new System.EventHandler(this.boxName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "chemin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "titre";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.InitialImage = null;
            this.buttonUpdate.Location = new System.Drawing.Point(12, 389);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(510, 42);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.TabStop = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // ecranImage
            // 
            this.ecranImage.Location = new System.Drawing.Point(10, 29);
            this.ecranImage.Name = "ecranImage";
            this.ecranImage.Size = new System.Drawing.Size(385, 319);
            this.ecranImage.TabIndex = 6;
            this.ecranImage.TabStop = false;
            // 
            // groupApercu
            // 
            this.groupApercu.Controls.Add(this.apercu);
            this.groupApercu.Controls.Add(this.ecranImage);
            this.groupApercu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupApercu.Location = new System.Drawing.Point(533, 12);
            this.groupApercu.Name = "groupApercu";
            this.groupApercu.Size = new System.Drawing.Size(407, 365);
            this.groupApercu.TabIndex = 8;
            this.groupApercu.TabStop = false;
            this.groupApercu.Text = "Aperçu";
            // 
            // dl
            // 
            this.dl.InitialImage = null;
            this.dl.Location = new System.Drawing.Point(666, 390);
            this.dl.Name = "dl";
            this.dl.Size = new System.Drawing.Size(274, 40);
            this.dl.TabIndex = 9;
            this.dl.TabStop = false;
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(533, 389);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(126, 43);
            this.annuler.TabIndex = 10;
            this.annuler.TabStop = false;
            // 
            // apercu
            // 
            this.apercu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(172)))), ((int)(((byte)(247)))));
            this.apercu.Location = new System.Drawing.Point(22, 41);
            this.apercu.Name = "apercu";
            this.apercu.Size = new System.Drawing.Size(360, 225);
            this.apercu.TabIndex = 5;
            this.apercu.Paint += new System.Windows.Forms.PaintEventHandler(this.apercu_Paint);
            // 
            // BoxManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 443);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.dl);
            this.Controls.Add(this.groupApercu);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.groupOptionDesDossier);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.optionGlobal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BoxManager";
            this.Text = "Icon Box manager";
            this.optionGlobal.ResumeLayout(false);
            this.optionGlobal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbColonne)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupOptionDesDossier.ResumeLayout(false);
            this.groupBordure.ResumeLayout(false);
            this.groupBordure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderWidth)).EndInit();
            this.groupCouleur.ResumeLayout(false);
            this.groupCouleur.PerformLayout();
            this.grouptaille.ResumeLayout(false);
            this.grouptaille.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slidY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slidX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefX)).EndInit();
            this.groupDossier.ResumeLayout(false);
            this.groupDossier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecranImage)).EndInit();
            this.groupApercu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.annuler)).EndInit();
            this.ResumeLayout(false);

        }

        //clear without blink
        void clearListBox()
        {
            listBox.SelectedIndexChanged -= listBox_SelectedIndexChanged;
            listBox.ClearSelected();
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
        }

        //----------------------------------------Apercu mouse Event---------------------------------------------------

        private void Apercu_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (Area a in areaBox)
            {
                if ((a.area.Contains(e.Location))) //si click down sur une box dans apercu
                {
                    //On la selectionne dans la liste
                    if ((ModifierKeys & Keys.Control) != Keys.Control)
                    {
                        clearListBox();
                    }
                    listBox.SetSelected(listBox.Items.IndexOf(a.box), true);

                    updateApercu();
                    break;
                }
            }
        }


        private void Apercu_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Area a in areaBox)
            {
                if ((a.area.Contains(e.Location))) //si click down sur une box dans apercu
                {
                    //on signale qu'elle est clicker
                    boxClickedDown = a.box;
                    isApercuClickDown = true;
                    apercuMouseDownLocation = e.Location;

                    //On la selectionne dans la liste
                    if ((ModifierKeys & Keys.Control) != Keys.Control)
                        clearListBox();
                    listBox.SetSelected(listBox.Items.IndexOf(a.box), true);
                    updateApercu();
                    break;
                }
            }
        }

       
        
        private void Apercu_MouseMove(object sender, MouseEventArgs e)
        {
            foreach(Area a in areaBox)
            {
                if ((a.area.Contains(e.Location)))//si la souris est au dessus d'une box
                {
                    Cursor.Current = Cursors.Hand;
                    apercuMouseLocation = e.Location;
                    if (isApercuClickDown && !apercuMouseDownLocation.Equals(apercuMouseLocation)) //si le clic est enfoncer et que la box a bouger
                    {
                        apercuMouseMove = true;
                        updateApercu();

                        foreach (Area zone in dropZone)
                        {
                            if (zone.box != a.box && (zone.area.Contains(e.Location)))//si la souris est dans une air de drop
                            {
                                permutate(a.box, zone.box);
                            }
                        }

                    }
                    else
                        apercuMouseMove = false;
                }
            } 
        }

        private void permutate(Box box1, Box box2)
        {
            int i1 = listBox.Items.IndexOf(box1);
            int i2 = listBox.Items.IndexOf(box2);

            Box b1 = new Box(box1);
            Box b2 = new Box(box2);

            Debug.WriteLine(i1 + " " + i2);
            listBox.SelectedIndexChanged -= listBox_SelectedIndexChanged;

            listBox.Items.RemoveAt(i1);//on suprime b1
            listBox.Items.Insert(i1 , b2);//on met b2 a la palce

            listBox.Items.RemoveAt(i2);//on suprime b2
            listBox.Items.Insert(i2, b1);//on met b1 a la palce

            //listBox.Items[i2] = box1;
            //listBox.Items[i1] = box2;
            boxClickedDown = b1;
            listBox.SetSelected(i2, true);
            listBox.SetSelected(i1, false);
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
        }

        private void ButtonUpdate_MouseLeave(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream imageStream = assembly.GetManifestResourceStream("iconeBox_manager.update.png");
            this.buttonUpdate.Image = Image.FromStream(imageStream);
        }

        private void displayButtonimage()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream imageStream = assembly.GetManifestResourceStream("iconeBox_manager.update.png");
            this.buttonUpdate.Image = Image.FromStream(imageStream);

            imageStream = assembly.GetManifestResourceStream("iconeBox_manager.Resources.ecran.png");
            ecranImage.Image = Image.FromStream(imageStream);

            //DL button
            imageStream = assembly.GetManifestResourceStream("iconeBox_manager.Resources.dl2.png");
            dl.Image = Image.FromStream(imageStream);

            //annuler button
            imageStream = assembly.GetManifestResourceStream("iconeBox_manager.Resources.annuler.png");
            annuler.Image = Image.FromStream(imageStream);
        }

        private void Annuler_MouseUp(object sender, MouseEventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream imageStream = assembly.GetManifestResourceStream("iconeBox_manager.Resources.annuler.png");
            annuler.Image = Image.FromStream(imageStream);

            listBox.Items.Clear();
            initData();
            showOption();

        }

        private void Annuler_MouseDown(object sender, MouseEventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream imageStream = assembly.GetManifestResourceStream("iconeBox_manager.Resources.annulerA.png");
            annuler.Image = Image.FromStream(imageStream);
        }

        private void Annuler_MouseLeave(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream imageStream = assembly.GetManifestResourceStream("iconeBox_manager.Resources.annuler.png");
            annuler.Image = Image.FromStream(imageStream);
            annuler.Cursor = Cursors.Default;
        }

        private void Annuler_MouseEnter(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream imageStream = assembly.GetManifestResourceStream("iconeBox_manager.Resources.annulerO.png");
            annuler.Image = Image.FromStream(imageStream);
            annuler.Cursor = Cursors.Hand;
        }

        private void Dl_MouseLeave(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream imageStream = assembly.GetManifestResourceStream("iconeBox_manager.Resources.dl2.png");
            this.dl.Image = Image.FromStream(imageStream);
            dl.Cursor = Cursors.Default;
        }

        private void Dl_MouseUp(object sender, MouseEventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream imageStream = assembly.GetManifestResourceStream("iconeBox_manager.Resources.dl2O.png");
            this.dl.Image = Image.FromStream(imageStream);

            if (MessageBox.Show("En important une nouvelle configuration, vous predrez les reglages actuels.\nVoulez-vous contunier?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dlconf();
            }
        }

        private void dlconf()
        {
            R.cp(pathConfIni.Text+ "\\conf_init.txt", ".");
            listBox.Items.Clear();
            initData();
            showOption();
        }

        private void Dl_MouseClick(object sender, MouseEventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream imageStream = assembly.GetManifestResourceStream("iconeBox_manager.Resources.dl2A.png");
            this.dl.Image = Image.FromStream(imageStream);
        }

        private void Dl_MouseHover(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream imageStream = assembly.GetManifestResourceStream("iconeBox_manager.Resources.dl2O.png");
            this.dl.Image = Image.FromStream(imageStream);
            dl.Cursor = Cursors.Hand;
        }

        private void ButtonUpdate_MouseUp(object sender, MouseEventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream imageStream = assembly.GetManifestResourceStream("iconeBox_manager.update.png");
            this.buttonUpdate.Image = Image.FromStream(imageStream);
        }

        private void ButtonUpdate_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream imageStream = assembly.GetManifestResourceStream("iconeBox_manager.updateActive.png");
            this.buttonUpdate.Image = Image.FromStream(imageStream);
        }

        private void ButtonUpdate_MouseHover(object sender, System.EventArgs e)
        {
            buttonUpdate.Cursor = Cursors.Hand;
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream imageStream = assembly.GetManifestResourceStream("iconeBox_manager.updateHover.png");
            this.buttonUpdate.Image = Image.FromStream(imageStream);
        }

        #endregion

        private System.Windows.Forms.GroupBox optionGlobal;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sup;
        private System.Windows.Forms.Label labelConfig;
        private System.Windows.Forms.NumericUpDown nbColonne;
        private System.Windows.Forms.Label labelNbColone;
        private System.Windows.Forms.Button dialogConfPath;
        private System.Windows.Forms.TextBox pathConfIni;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.GroupBox groupOptionDesDossier;
        private System.Windows.Forms.GroupBox groupBordure;
        private System.Windows.Forms.GroupBox groupCouleur;
        private System.Windows.Forms.Button buttonBGColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grouptaille;
        private System.Windows.Forms.GroupBox groupDossier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown coefY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown coefX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxPath;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.NumericUpDown radius;
        private System.Windows.Forms.NumericUpDown borderWidth;
        private System.Windows.Forms.Button titleColor;
        private System.Windows.Forms.PictureBox buttonUpdate;
        private TextBox pass;
        private Label label11;
        private Button openPath;
        private Apercu apercu;
        private PictureBox ecranImage;
        private GroupBox groupApercu;
        private TrackBar slidX;
        private TrackBar slidY;
        private PictureBox dl;
        private Label label12;
        private CheckBox enable;
        private PictureBox annuler;
    }
}

