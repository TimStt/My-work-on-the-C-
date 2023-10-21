using EgoldsUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace yt_DesignUI.Forms
{
    public partial class CustomDialog : Form
    {

        public CustomDialog()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // запретить изменение размера формы
            this.MaximizeBox = false;
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }
       
     

        public string Message
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
       
           

        private void CustomDialog_Load(object sender, EventArgs e)
        {
            

            if (yt_DesignUI.Properties.Settings.Default.checkBox == true)
            {
                this.BackColor = FlatColors.MidnightBlue;
                label1.ForeColor = Color.White;
            }
            else
            {
                this.BackColor =  Color.White;
                label1.ForeColor = Color.Black;
            }
            
        }
       
        // Обработчик события для кнопки "Да
        private void yt_Button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void yt_Button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CustomDialog_Resize(object sender, EventArgs e)
        {
            
        }

        // Метод для вывода диалогового окна и возвращения результата
        public static DialogResult Show(string message)
        {
            using (var dialog = new CustomDialog())
            {
                dialog.Message = message;
                return dialog.ShowDialog();
            }
        }

        private void CustomDialog_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
