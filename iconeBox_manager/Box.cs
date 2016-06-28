using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iconeBox_manager
{
    class Box
    {
        public string folderPath = "";
        public string titleBox = BoxManager.defaultboxName;
        public double coefX = 0.8;
        public double coefY = 0.8;
        public string colorTitleText = "#ffffff";
        public string backgroundTitleText = "#202020";
        public string titleFontText = "arial";
        public int titleFontSize = 16;
        public string backgroundBoxText = "#202020";
        public int radiusBorder = 10;
        public int borderThickness = 1;
        public int separatorWidth = 1;
        public string borderColorText = "#ffffff";
        public int titleHeight = 30;

        public Box(string title)
        {
            titleBox = title;
        }

        public Box(Box b)
        {
            folderPath = b.folderPath;
            titleBox = b.titleBox;
            coefX = b.coefX;
            coefY = b.coefY;
            colorTitleText = b.colorTitleText;
            backgroundTitleText = b.backgroundTitleText;
            titleFontText = b.titleFontText;
            titleFontSize = b.titleFontSize;
            backgroundBoxText = b.backgroundBoxText;
            radiusBorder = b.radiusBorder;
            borderThickness = b.borderThickness;
            separatorWidth = b.separatorWidth;
            borderColorText = b.borderColorText;
            titleHeight = b.titleHeight;
    }

        public Box()
        {
        }

        //int entre 0 et 100
        public void setCoefX(int coef)
        {
            coefX = (double)coef / 100;
        }

        public int getCoefX()
        {
            return  (int)(coefX * 100);
        }

        public void setCoefY(int coef)
        {
            coefY = (double)coef / 100;
        }

        public int getCoefY()
        {
            return (int)(coefY * 100);
        }

        //color title
        //set border color separator color et titre color
        public void setColorTitle(Color c){
            string htmlC = ColorTranslator.ToHtml(c);
            colorTitleText = htmlC;
            borderColorText = htmlC;
        }

        public Color getColorTitle()
        {
            return ColorTranslator.FromHtml(colorTitleText);
        }

        public void setColorBg(Color c)
        {
            string htmlC = ColorTranslator.ToHtml(c);
            backgroundBoxText = htmlC;
            backgroundTitleText = htmlC;
        }

        public Color getColorBg()
        {
            return ColorTranslator.FromHtml(backgroundBoxText);
        }

        public override string ToString()
        {
            return this.titleBox;
        }

    }
}
