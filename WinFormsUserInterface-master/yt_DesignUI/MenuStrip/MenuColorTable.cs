using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using EgoldsUI;

namespace yt_DesignUI
{
     public class MenuColorTable:ProfessionalColorTable
    {
        // поля для цветов внешнего вида
        private Color backColor;
        private Color leftColumnColor;
        private Color borderColor;
        private Color menuItemBorderColor;
        private Color menuItemSelectedColor;

        // конструктор 
        public MenuColorTable (bool isMainMenu, Color primaryColor)
        {
            if (isMainMenu)
            {
                backColor = FlatColors.MidnightBlue;
                leftColumnColor = FlatColors.Blue;
                borderColor = FlatColors.Blue;
                menuItemBorderColor = primaryColor;
                menuItemSelectedColor = primaryColor;
            }
            else
            {
                backColor = Color.White;
                leftColumnColor = Color.LightGray;
                borderColor = Color.LightGray;
                menuItemBorderColor = primaryColor;
                menuItemSelectedColor = primaryColor;
            }
        }
        // переопределим
        public override Color ToolStripDropDownBackground
        {
            get
            {
                return backColor;
            }
        }
        public override Color MenuBorder
        {
            get
            {
                return borderColor;
            }
        }
        public override Color MenuItemBorder
        {
            get
            {
                return menuItemBorderColor;
            }
        }
        public override Color MenuItemSelected
        {
            get
            {
                return menuItemSelectedColor;
            }
        }
        public override Color ImageMarginGradientBegin 
        {
            get
            {
                return leftColumnColor;
            }
        }
        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return leftColumnColor;
            }
        }
        public override Color ImageMarginGradientEnd
        {
            get
            {
                return leftColumnColor;
            }
        }
    }
}
