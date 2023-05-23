using EgoldsUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yt_DesignUI.Forms
{
    public partial class Help_3 : Form
    {
        public Help_3()
        {
            InitializeComponent();
        }
        

        private void Help_3_Load(object sender, EventArgs e)
        {
            if (yt_DesignUI.Properties.Settings.Default.checkBox == true)
            {
                this.BackColor = FlatColors.MidnightBlue;

                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                return;
            }
                
        }

       

        private void textbox_Control1_zametka__TextChange(object sender, EventArgs e)
        {
           
        }
    }
    
}
