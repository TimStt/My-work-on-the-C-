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
    public partial class CustomDialog2 : Form
    {
        public CustomDialog2()
        {
            InitializeComponent();
           StartPosition = FormStartPosition.CenterScreen;
        //  this.FormBorderStyle = FormBorderStyle.FixedSingle; // запретить изменение размера формы
          //  this.MaximizeBox = false;
           // label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
           // label1.AutoSize = false;
        }
        public string Message
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        private void CustomDialog2_Load(object sender, EventArgs e)
        {
            if (yt_DesignUI.Properties.Settings.Default.checkBox == true)
            {
                this.BackColor = FlatColors.MidnightBlue;
                label1.ForeColor = Color.White;
                this.ForeColor = FlatColors.MidnightBlue;
            }
            else
            {
                this.BackColor = Color.White;
                label1.ForeColor = Color.Black;
            }
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // запретить изменение размера формы
        }
        // Обработчик события для кнопки "Да
        private void yt_Button1_Click(object sender, EventArgs e)
        {

        }
        // Метод для вывода диалогового окна и возвращения результата
        public static DialogResult Show(string message)
        {
            using (var dialog = new CustomDialog2())
            {
                dialog.Message = message;
                return dialog.ShowDialog();
            }
        }
        

        private void CustomDialog2_Resize(object sender, EventArgs e)
        {
            
        }

        private void yt_Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
