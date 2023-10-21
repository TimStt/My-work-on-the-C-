using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Windows.Forms;

namespace yt_DesignUI.Controls
{
    public class CustomScrollBar : VScrollBar
    {
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            //Рисуем фон VScrollBar в заданный цвет
            using (SolidBrush brush = new SolidBrush(Color.Blue))
            {
                pevent.Graphics.FillRectangle(brush, ClientRectangle);
            }
        }

        
        

    }

}


