using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using yt_DesignUI;
using Zanetki_design.Controls;
using FontAwesome.Sharp;
using EgoldsUI;
using System.Runtime.InteropServices;
using yt_DesignUI.Forms;
using yt_DesignUI.Controls;
using System.IO;

namespace Zanetki_design
{

    public partial class F_Zametka : ShadowedForm
    {
        // поля
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private int BorderSize = 2;
        private Size formSize;
        internal static bool areYouOKAY = false;
        SelfMakling_1 selfMakling_1 = new SelfMakling_1();
        private bool isText = false;

        // хранение текста
        static class Container
        {
            public static List<string> LogList = (new string[] { "Как создать новую заметку? - Нажмите на кнопку в виде трех полосок |  новая заметка | --> введите все нужные данные и сохраните ее ", "Создали заметку, но не можете найти ее? - Нажмите на кнопку | история заметок | --> и увидите список всех ваших заметок " }).ToList();
        }

        public F_Zametka()
        {
            InitializeComponent();
            CollapseMenu();
            //label2.Parent = pictureBox1;
            //label2.BackColor = Color.Transparent;
            iconPictureBox1_home.BackColor = Color.Transparent;
            iconPictureBox1_home.Parent = panel1;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 99);
            this.Padding = new Padding(BorderSize);
            this.BackColor = Color.FromArgb(109, 116, 174);//Border color
            
            if (this.panel1_menu.Width < 200)
                foreach (Button menuButton in panel1_menu.Controls.OfType<Button>())
                {
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                }

            

            panel1_menu.Controls.Add(leftBorderBtn);
         
            Animator.Start();

        }

        //активация кнопки
        private void ActivateButton(object senderBtn,Color color)
        {
            if (senderBtn != null)
            {
                if (this.panel1_menu.Width < 200)
                    foreach (Button menuButton in panel1_menu.Controls.OfType<Button>())
                    {
                        menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    }
                 DisableButton();
                 // настройка кнопки 
                 currentBtn = (IconButton)senderBtn;
                 currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                 currentBtn.ForeColor = color;
                 currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                 currentBtn.IconColor = color;
                 if (this.panel1_menu.Width < 200)
                    foreach (Button menuButton in panel1_menu.Controls.OfType<Button>())
                    {
                        menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    }
                 else
                    {
                        currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                        currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                    }
                 // слева от края кнопки
                 leftBorderBtn.BackColor = color;
                 leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                 leftBorderBtn.Visible = true;
                 leftBorderBtn.BringToFront();

                 iconPictureBox1_home.IconChar = currentBtn.IconChar;
                 if (flag == true)
                   {
                     iconPictureBox1_home.IconColor = Color.Black;
                   }
                 else
                   {
                     iconPictureBox1_home.IconColor = color;
                   }            
            }
        }

        private static bool flag = false;
        private static bool flag2 = false;
        // отключение подсветки кнопки 
        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(109, 116, 174);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            
        }

        Animation buttonAnim = new Animation();
        int BtnWidthTarget = 150;
        int BtnWidthBase = 75;


        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                if (!CheckTextFields())
                {
                    isText = true;
                    return;
                    
                }
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private bool CheckTextFields()
        {
            if (currentChildForm == null)
            {
                return true;
            }

            bool allFieldsAreEmpty = true;

            // Проверяем все текстовые поля на заполненность
            foreach (Control control in currentChildForm.Controls)
            {
                if (control is Textbox_Control textBox)
                {
                    if (!string.IsNullOrEmpty(textBox.Texts))
                    {
                        allFieldsAreEmpty = false;
                        break;
                    }
                }
            }

            if (!allFieldsAreEmpty)
            {
                var result = MessageBox.Show("Вы действительно хотите закрыть форму без сохранения данных?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return false;
                }
            }

            return true;
        }


        private void button1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }

        private void contextExitBtn(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

  

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }


        private void yt_Button4_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void F_Zametka_Load(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
            egoldsToggleSwitch1.Checked = yt_DesignUI.Properties.Settings.Default.checkBox;

           // selfMakling_1.FormClosing += SelfMakling_1_FormClosing; // добавляем обработчик события
        }

        private void egoldsCard1_MouseEnter(object sender, EventArgs e)
        {
            Random r = new Random();
            egoldsCard1.TextDescrition= Container.LogList[r.Next(0, Container.LogList.Count)]; 
        }

        private void egoldsCard1_Click(object sender, EventArgs e)
        {

        }

        private void F_Zametka_MouseLeave(object sender, EventArgs e)
        {

        }

        private void yt_Button6_Click(object sender, EventArgs e)
        {
            DataManager.SetDataChanged();
            Hide();
            SelfMakling_1 form2 = new SelfMakling_1();
            form2.Show();
        }

        private void yt_Button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            Form1 form3 = new Form1();
            form3.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            flag = true;
            if (currentChildForm != null)
            {
                if (!CheckTextFields())
                {
                    isText = false;
                    return;
                }
                else
                {
                    currentChildForm.Close();
                    currentChildForm = null;
                    ActivateButton(sender, FlatColors.BlueDark);
                }
            }
            if (this.panel1_menu.Width < 200)
            {
                foreach (Button menuButton in panel1_menu.Controls.OfType<Button>())
                {
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;

                }
            }
            else
            {
                
                Reset();
                
            }
            ActivateButton(sender, FlatColors.BlueDark);


        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            flag = false;
            OpenChildForm(new SelfMakling_1());
            if (isText == true)
            {
                isText = false; // Сбрасываем флаг, чтобы он не мешал при следующих вызовах метода
                return;
            }
            ActivateButton(sender, FlatColors.GreenSeaDark);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            flag = false;
            OpenChildForm(new History_2());
            if (isText == true)
            {
                isText = false; // Сбрасываем флаг, чтобы он не мешал при следующих вызовах метода
                return;
            }
            ActivateButton(sender, FlatColors.Turquoise);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconPictureBox1_home.IconChar = IconChar.Home;
            iconPictureBox1_home.IconColor = Color.Black;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Help_3());
            if (isText == true)
            {
                isText = false; // Сбрасываем флаг, чтобы он не мешал при следующих вызовах метода
                return;
            }
            ActivateButton(sender, FlatColors.PinkLight);
        }
        // Перетаскивание формы
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam,int lParam); 
        private void panel1_menu_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                this.Size = formSize;
            }
            else
                WindowState = FormWindowState.Normal;


        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            if (!CheckTextFields())
            {
                return;
            }
            else
            {
                Application.Exit();
                
            }
                
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Size = formSize;
        }

        private void panel1_menu_Paint(object sender, PaintEventArgs e)
        {

        }
    
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Удаляем шапку формы
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Стандартная строка заголовка - окно привязки
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Минимизация формы (До)
            const int SC_RESTORE = 0xF120; //Восстановление формы (До)
            const int WM_NCHITTEST = 0x0084;//Win32, Уведомление о вводе мыши: Определяет, какая часть окна соответствует точке, позволяет изменять размер формы.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Удалите границу и сохраните окно с защелкой
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Сохраняйте размер формы при ее сворачивании и восстановлении. При изменении размера формы учитывается размер строки заголовка и границ.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //После
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Восстановленная форма (До)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

        private void F_Zametka_Resize(object sender, EventArgs e)
        {
            AbjastForm();
        }

        private void AbjastForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if(this.Padding.Top != BorderSize)
                        this.Padding = new Padding(BorderSize);
                    break;
            }
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        // разворачивание и сворачивание меню
        private void CollapseMenu()
        {  
            if (this.panel1_menu.Width > 200) //Свернуть меню
                {
                    flag2 = true;
                    panel1_menu.Width = 100;
                    pictureBox2.Visible = false;
                    iconButton5.Dock = DockStyle.Top;
                    foreach (Button menuButton in panel1_menu.Controls.OfType<Button>())
                    {
                        menuButton.Text = "";
                        menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                        menuButton.Padding = new Padding(0);
                    }
                }
               else
               { //----Развернуть меню----
                    panel1_menu .Width = 266;
                    pictureBox2.Visible = true;
                    iconButton5.Dock = DockStyle.None;
                    foreach (Button menuButton in panel1_menu.Controls.OfType<Button>())
                    {
                        menuButton.Text = "   " + menuButton.Tag.ToString();
                        menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                        menuButton.Padding = new Padding(10, 0, 0, 0);
                    }
               }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            flag = false;
            ActivateButton(sender, FlatColors.RedWhite);
            Application.Exit();
        }
     

// проверяем в каком положении находится кнопка смены темы
        private void egoldsToggleSwitch1_CheckedChanged(object sender)
        {
            if (egoldsToggleSwitch1.Checked == true)
            {
                panel1.BackColor = FlatColors.MidnightBlue;
                panel3.BackColor = FlatColors.MidnightBlue;
                label2.ForeColor = Color.White;
                egoldsToggleSwitch1.ForeColor = Color.White;
                egoldsCard1.BackColor = FlatColors.MidnightBlue;
                egoldsCard1.ForeColor = Color.White;
                egoldsCard1.ForeColorDescrition = Color.White;
            }
            else
            {
                panel1.BackColor = Color.White;
                panel3.BackColor = Color.White;
                label2.ForeColor = Color.Black;
                egoldsToggleSwitch1.ForeColor = Color.Black;
                egoldsCard1.BackColor = Color.White;
                egoldsCard1.BackColorCurtain = Color.FromArgb(109, 116, 174);
                egoldsCard1.ForeColor = Color.Black;
                egoldsCard1.ForeColorDescrition = Color.Black;
            }

            yt_DesignUI.Properties.Settings.Default.checkBox = egoldsToggleSwitch1.Checked;
            yt_DesignUI.Properties.Settings.Default.Save();
        }
        private void F_Zametka_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void iconPictureBox1_home_Click(object sender, EventArgs e)
        {

        }

        private void egoldsCard1_Click_1(object sender, EventArgs e)
        {

        }

        private void egoldsCard1_MouseDown(object sender, MouseEventArgs e)
        {
       
        }

        private void egoldsToggleSwitch1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void egoldsCard1_MouseEnter_1(object sender, EventArgs e)
        {
            Random r = new Random();
            string textDesc = Container.LogList[r.Next(0, Container.LogList.Count)];

            egoldsCard1.TextDescrition = textDesc;
        }
    }
    
}   
    

