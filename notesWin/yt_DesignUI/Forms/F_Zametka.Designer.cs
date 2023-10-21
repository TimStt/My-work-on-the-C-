namespace Zanetki_design
{
    partial class F_Zametka
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Zametka));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1_menu = new System.Windows.Forms.Panel();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.iconButton9 = new FontAwesome.Sharp.IconButton();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1_home = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.egoldsToggleSwitch1 = new Zanetki_design.EgoldsToggleSwitch();
            this.egoldsCard1 = new Zanetki_design.EgoldsCard();
            this.panel1_menu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1_home)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(236, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(971, 96);
            this.label2.TabIndex = 32;
            this.label2.Text = "Добро пожаловать в Note";
            // 
            // panel1_menu
            // 
            this.panel1_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(116)))), ((int)(((byte)(174)))));
            this.panel1_menu.Controls.Add(this.iconButton6);
            this.panel1_menu.Controls.Add(this.iconButton4);
            this.panel1_menu.Controls.Add(this.iconButton3);
            this.panel1_menu.Controls.Add(this.iconButton2);
            this.panel1_menu.Controls.Add(this.iconButton1);
            this.panel1_menu.Controls.Add(this.panel2);
            this.panel1_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1_menu.Location = new System.Drawing.Point(0, 0);
            this.panel1_menu.Name = "panel1_menu";
            this.panel1_menu.Size = new System.Drawing.Size(266, 959);
            this.panel1_menu.TabIndex = 35;
            this.panel1_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_menu_Paint);
            this.panel1_menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_menu_MouseDown);
            // 
            // iconButton6
            // 
            this.iconButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton6.ForeColor = System.Drawing.Color.White;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.iconButton6.IconColor = System.Drawing.Color.White;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 31;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(0, 860);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton6.Size = new System.Drawing.Size(266, 99);
            this.iconButton6.TabIndex = 38;
            this.iconButton6.Tag = "Выход";
            this.iconButton6.Text = " Выход";
            this.iconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = true;
            this.iconButton6.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 32;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 534);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton4.Size = new System.Drawing.Size(266, 99);
            this.iconButton4.TabIndex = 37;
            this.iconButton4.Tag = "Помощь";
            this.iconButton4.Text = " Помощь";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 32;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 435);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton3.Size = new System.Drawing.Size(266, 99);
            this.iconButton3.TabIndex = 36;
            this.iconButton3.Tag = "История";
            this.iconButton3.Text = " История";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.SquarePlus;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 32;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 336);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton2.Size = new System.Drawing.Size(266, 99);
            this.iconButton2.TabIndex = 35;
            this.iconButton2.Tag = "Новая заметка";
            this.iconButton2.Text = " Новая заметка";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 237);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(266, 99);
            this.iconButton1.TabIndex = 34;
            this.iconButton1.Tag = "Домой";
            this.iconButton1.Text = " Домой";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconButton5);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panel2.Size = new System.Drawing.Size(266, 237);
            this.panel2.TabIndex = 1;
            // 
            // iconButton5
            // 
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.Location = new System.Drawing.Point(169, 78);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(91, 72);
            this.iconButton5.TabIndex = 1;
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::yt_DesignUI.Properties.Resources.coollogo_com_97043997;
            this.pictureBox2.Location = new System.Drawing.Point(10, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 237);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.iconButton8);
            this.panel1.Controls.Add(this.iconButton9);
            this.panel1.Controls.Add(this.iconButton7);
            this.panel1.Controls.Add(this.iconPictureBox1_home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(266, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1423, 104);
            this.panel1.TabIndex = 39;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // iconButton8
            // 
            this.iconButton8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton8.BackColor = System.Drawing.Color.DodgerBlue;
            this.iconButton8.FlatAppearance.BorderSize = 0;
            this.iconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.iconButton8.IconColor = System.Drawing.Color.White;
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.IconSize = 21;
            this.iconButton8.Location = new System.Drawing.Point(1313, 0);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(57, 37);
            this.iconButton8.TabIndex = 39;
            this.iconButton8.UseVisualStyleBackColor = false;
            this.iconButton8.Click += new System.EventHandler(this.iconButton8_Click);
            // 
            // iconButton9
            // 
            this.iconButton9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(182)))), ((int)(((byte)(139)))));
            this.iconButton9.FlatAppearance.BorderSize = 0;
            this.iconButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton9.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButton9.IconColor = System.Drawing.Color.White;
            this.iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton9.IconSize = 20;
            this.iconButton9.Location = new System.Drawing.Point(1256, 0);
            this.iconButton9.Name = "iconButton9";
            this.iconButton9.Size = new System.Drawing.Size(60, 37);
            this.iconButton9.TabIndex = 40;
            this.iconButton9.UseVisualStyleBackColor = false;
            this.iconButton9.Click += new System.EventHandler(this.iconButton9_Click);
            // 
            // iconButton7
            // 
            this.iconButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.iconButton7.IconColor = System.Drawing.Color.White;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 25;
            this.iconButton7.Location = new System.Drawing.Point(1366, 0);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(57, 37);
            this.iconButton7.TabIndex = 2;
            this.iconButton7.UseVisualStyleBackColor = false;
            this.iconButton7.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // iconPictureBox1_home
            // 
            this.iconPictureBox1_home.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1_home.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox1_home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconPictureBox1_home.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox1_home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1_home.IconSize = 76;
            this.iconPictureBox1_home.Location = new System.Drawing.Point(33, 12);
            this.iconPictureBox1_home.Name = "iconPictureBox1_home";
            this.iconPictureBox1_home.Size = new System.Drawing.Size(76, 77);
            this.iconPictureBox1_home.TabIndex = 38;
            this.iconPictureBox1_home.TabStop = false;
            this.iconPictureBox1_home.Click += new System.EventHandler(this.iconPictureBox1_home_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.egoldsToggleSwitch1);
            this.panel3.Controls.Add(this.egoldsCard1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(266, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1423, 855);
            this.panel3.TabIndex = 40;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // egoldsToggleSwitch1
            // 
            this.egoldsToggleSwitch1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.egoldsToggleSwitch1.BackColor = System.Drawing.Color.White;
            this.egoldsToggleSwitch1.BackColorOFF = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.egoldsToggleSwitch1.BackColorON = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.egoldsToggleSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.egoldsToggleSwitch1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.egoldsToggleSwitch1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.egoldsToggleSwitch1.Location = new System.Drawing.Point(24, 818);
            this.egoldsToggleSwitch1.Name = "egoldsToggleSwitch1";
            this.egoldsToggleSwitch1.Size = new System.Drawing.Size(171, 15);
            this.egoldsToggleSwitch1.TabIndex = 38;
            this.egoldsToggleSwitch1.Text = "Темная тема";
            this.egoldsToggleSwitch1.TextOnChecked = "Светлая тема";
            this.egoldsToggleSwitch1.UseVisualStyleBackColor = false;
            this.egoldsToggleSwitch1.CheckedChanged += new Zanetki_design.EgoldsToggleSwitch.OnCheckedChangedHandler(this.egoldsToggleSwitch1_CheckedChanged);
            this.egoldsToggleSwitch1.MouseEnter += new System.EventHandler(this.egoldsToggleSwitch1_MouseEnter);
            // 
            // egoldsCard1
            // 
            this.egoldsCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.egoldsCard1.BackColor = System.Drawing.Color.White;
            this.egoldsCard1.BackColorCurtain = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(116)))), ((int)(((byte)(174)))));
            this.egoldsCard1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.egoldsCard1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.egoldsCard1.FontDescrition = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.egoldsCard1.FontHeader = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.egoldsCard1.ForeColorDescrition = System.Drawing.Color.Black;
            this.egoldsCard1.ForeColorHeader = System.Drawing.Color.White;
            this.egoldsCard1.Location = new System.Drawing.Point(1082, 589);
            this.egoldsCard1.Name = "egoldsCard1";
            this.egoldsCard1.Size = new System.Drawing.Size(338, 263);
            this.egoldsCard1.TabIndex = 41;
            this.egoldsCard1.TextDescrition = "";
            this.egoldsCard1.TextHeader = "Помощь";
            this.egoldsCard1.Click += new System.EventHandler(this.egoldsCard1_Click_1);
            this.egoldsCard1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.egoldsCard1_MouseDown);
            this.egoldsCard1.MouseEnter += new System.EventHandler(this.egoldsCard1_MouseEnter_1);
            // 
            // F_Zametka
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1689, 959);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel1_menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Zametka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Домой";
            this.Text = "Note";
            this.Load += new System.EventHandler(this.F_Zametka_Load);
            this.MouseLeave += new System.EventHandler(this.F_Zametka_MouseLeave);
            this.Resize += new System.EventHandler(this.F_Zametka_Resize);
            this.panel1_menu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1_home)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1_menu;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1_home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton9;
        private FontAwesome.Sharp.IconButton iconButton8;
        private EgoldsToggleSwitch egoldsToggleSwitch1;
        private EgoldsCard egoldsCard1;
    }
}

