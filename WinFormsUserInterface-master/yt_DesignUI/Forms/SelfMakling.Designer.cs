
namespace yt_DesignUI
{
    partial class SelfMakling_1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.yt_Button1 = new Zanetki_design.yt_Button();
            this.dropdownMenu1 = new yt_DesignUI.MenuStrip.DropdownMenu(this.components);
            this.cjhfybnmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textbox_Control1_text = new Zanetki_design.Controls.Textbox_Control();
            this.textbox_Control1_name = new Zanetki_design.Controls.Textbox_Control();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.numberedToolStripButton = new FontAwesome.Sharp.IconButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dropdownMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // yt_Button1
            // 
            this.yt_Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.yt_Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(116)))), ((int)(((byte)(174)))));
            this.yt_Button1.BackColorAdditional = System.Drawing.Color.Gray;
            this.yt_Button1.BackColorGradientEnabled = false;
            this.yt_Button1.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.yt_Button1.BackgroundImage = global::yt_DesignUI.Properties.Resources.free_icon_diskette_747439__2_;
            this.yt_Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.yt_Button1.BorderColor = System.Drawing.Color.Tomato;
            this.yt_Button1.BorderColorEnabled = false;
            this.yt_Button1.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.yt_Button1.BorderColorOnHoverEnabled = false;
            this.yt_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yt_Button1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.yt_Button1.ForeColor = System.Drawing.Color.White;
            this.yt_Button1.Location = new System.Drawing.Point(1405, 940);
            this.yt_Button1.Name = "yt_Button1";
            this.yt_Button1.RippleColor = System.Drawing.Color.Black;
            this.yt_Button1.RoundingEnable = false;
            this.yt_Button1.Size = new System.Drawing.Size(213, 75);
            this.yt_Button1.TabIndex = 33;
            this.yt_Button1.Text = "Сохранить";
            this.yt_Button1.TextHover = null;
            this.yt_Button1.UseDownPressEffectOnClick = false;
            this.yt_Button1.UseRippleEffect = true;
            this.yt_Button1.UseVisualStyleBackColor = false;
            this.yt_Button1.UseZoomEffectOnHover = false;
            this.yt_Button1.Click += new System.EventHandler(this.yt_Button1_Click);
            // 
            // dropdownMenu1
            // 
            this.dropdownMenu1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.dropdownMenu1.IsMainMenu = false;
            this.dropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cjhfybnmToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.dropdownMenu1.MenuItemHeight = 25;
            this.dropdownMenu1.MenuItemTextColor = System.Drawing.Color.DimGray;
            this.dropdownMenu1.Name = "dropdownMenu1";
            this.dropdownMenu1.PrimaryColor = System.Drawing.Color.MediumSlateBlue;
            this.dropdownMenu1.Size = new System.Drawing.Size(273, 125);
            // 
            // cjhfybnmToolStripMenuItem
            // 
            this.cjhfybnmToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cjhfybnmToolStripMenuItem.Name = "cjhfybnmToolStripMenuItem";
            this.cjhfybnmToolStripMenuItem.Size = new System.Drawing.Size(272, 44);
            this.cjhfybnmToolStripMenuItem.Text = "Сохранить";
            this.cjhfybnmToolStripMenuItem.Click += new System.EventHandler(this.cjhfybnmToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(272, 44);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // textbox_Control1_text
            // 
            this.textbox_Control1_text.AcceptsReturns = false;
            this.textbox_Control1_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_Control1_text.BackColor = System.Drawing.SystemColors.Window;
            this.textbox_Control1_text.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textbox_Control1_text.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.textbox_Control1_text.BorderSize = 2;
            this.textbox_Control1_text.Font = new System.Drawing.Font("Onest Regular", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbox_Control1_text.ForeColor = System.Drawing.Color.Black;
            this.textbox_Control1_text.Lines = new string[] {
        "Введите текст заметки..."};
            this.textbox_Control1_text.Liness = new string[] {
        "Введите текст заметки..."};
            this.textbox_Control1_text.Location = new System.Drawing.Point(71, 198);
            this.textbox_Control1_text.Margin = new System.Windows.Forms.Padding(5);
            this.textbox_Control1_text.MaxChars = 20000;
            this.textbox_Control1_text.MaxLengths = 32767;
            this.textbox_Control1_text.MultiLine = true;
            this.textbox_Control1_text.Name = "textbox_Control1_text";
            this.textbox_Control1_text.Padding = new System.Windows.Forms.Padding(7);
            this.textbox_Control1_text.PasswordChar = false;
            this.textbox_Control1_text.PlaceholderColor = System.Drawing.Color.DimGray;
            this.textbox_Control1_text.PlaceholderText = "Введите текст заметки...";
            this.textbox_Control1_text.SelectedText = "";
            this.textbox_Control1_text.SelectionLength = 0;
            this.textbox_Control1_text.SelectionStart = 0;
            this.textbox_Control1_text.ShowScrollbar = true;
            this.textbox_Control1_text.Size = new System.Drawing.Size(1533, 631);
            this.textbox_Control1_text.TabIndex = 38;
            this.textbox_Control1_text.Texts = "";
            this.textbox_Control1_text.UnderlinesStyle = false;
            this.textbox_Control1_text._TextChanged += new System.EventHandler(this.textbox_Control1_name__TextChange);
            this.textbox_Control1_text.Enter += new System.EventHandler(this.textbox_Control1_text_Enter);
            this.textbox_Control1_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_Control1_text_KeyDown);
            this.textbox_Control1_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_Control1_text_KeyPress);
            this.textbox_Control1_text.Leave += new System.EventHandler(this.textbox_Control1_text_Leave);
            this.textbox_Control1_text.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textbox_Control1_text_MouseUp);
            // 
            // textbox_Control1_name
            // 
            this.textbox_Control1_name.AcceptsReturns = false;
            this.textbox_Control1_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_Control1_name.BackColor = System.Drawing.SystemColors.Window;
            this.textbox_Control1_name.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textbox_Control1_name.BorderFocusColor = System.Drawing.Color.Fuchsia;
            this.textbox_Control1_name.BorderSize = 2;
            this.textbox_Control1_name.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbox_Control1_name.ForeColor = System.Drawing.Color.Black;
            this.textbox_Control1_name.Lines = new string[] {
        "Введите название заметки..."};
            this.textbox_Control1_name.Liness = new string[] {
        "Введите название заметки..."};
            this.textbox_Control1_name.Location = new System.Drawing.Point(71, 54);
            this.textbox_Control1_name.Margin = new System.Windows.Forms.Padding(5);
            this.textbox_Control1_name.MaxChars = 30;
            this.textbox_Control1_name.MaxLengths = 32767;
            this.textbox_Control1_name.MultiLine = true;
            this.textbox_Control1_name.Name = "textbox_Control1_name";
            this.textbox_Control1_name.Padding = new System.Windows.Forms.Padding(7);
            this.textbox_Control1_name.PasswordChar = false;
            this.textbox_Control1_name.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_Control1_name.PlaceholderText = "Введите название заметки...";
            this.textbox_Control1_name.SelectedText = "";
            this.textbox_Control1_name.SelectionLength = 0;
            this.textbox_Control1_name.SelectionStart = 0;
            this.textbox_Control1_name.ShowScrollbar = false;
            this.textbox_Control1_name.Size = new System.Drawing.Size(1444, 105);
            this.textbox_Control1_name.TabIndex = 39;
            this.textbox_Control1_name.Texts = "";
            this.textbox_Control1_name.UnderlinesStyle = true;
            this.textbox_Control1_name._TextChanged += new System.EventHandler(this.textbox_Control1_name__TextChanged);
            this.textbox_Control1_name.Enter += new System.EventHandler(this.textbox_Control1_name_Enter);
            this.textbox_Control1_name.Leave += new System.EventHandler(this.textbox_Control1_name_Leave);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 78;
            this.iconPictureBox1.Location = new System.Drawing.Point(1539, 93);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(88, 78);
            this.iconPictureBox1.TabIndex = 40;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // numberedToolStripButton
            // 
            this.numberedToolStripButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numberedToolStripButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numberedToolStripButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numberedToolStripButton.IconChar = FontAwesome.Sharp.IconChar.ListOl;
            this.numberedToolStripButton.IconColor = System.Drawing.Color.Black;
            this.numberedToolStripButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.numberedToolStripButton.IconSize = 80;
            this.numberedToolStripButton.Location = new System.Drawing.Point(133, 922);
            this.numberedToolStripButton.Name = "numberedToolStripButton";
            this.numberedToolStripButton.Size = new System.Drawing.Size(161, 93);
            this.numberedToolStripButton.TabIndex = 41;
            this.numberedToolStripButton.Text = "\r\n";
            this.numberedToolStripButton.UseVisualStyleBackColor = true;
            this.numberedToolStripButton.Click += new System.EventHandler(this.numberedToolStripButton_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SelfMakling_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1689, 1061);
            this.Controls.Add(this.numberedToolStripButton);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.textbox_Control1_name);
            this.Controls.Add(this.textbox_Control1_text);
            this.Controls.Add(this.yt_Button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "SelfMakling_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новая заметка";
            this.Load += new System.EventHandler(this.SelfMakling_Load);
            this.dropdownMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Zanetki_design.yt_Button yt_Button1;
        private MenuStrip.DropdownMenu dropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem cjhfybnmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Zanetki_design.Controls.Textbox_Control textbox_Control1_text;
        private Zanetki_design.Controls.Textbox_Control textbox_Control1_name;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton numberedToolStripButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}