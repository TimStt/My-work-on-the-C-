
namespace yt_DesignUI.Forms
{
    partial class History_2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_Control1_search = new Zanetki_design.Controls.Textbox_Control();
            this.yt_Button2 = new Zanetki_design.yt_Button();
            this.yt_Button1 = new Zanetki_design.yt_Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1126, 623);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textbox_Control1_search);
            this.panel1.Controls.Add(this.yt_Button2);
            this.panel1.Controls.Add(this.yt_Button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 623);
            this.panel1.TabIndex = 34;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 49;
            this.iconPictureBox1.Location = new System.Drawing.Point(243, 37);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(59, 49);
            this.iconPictureBox1.TabIndex = 40;
            this.iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 36);
            this.label1.TabIndex = 39;
            this.label1.Text = "Поиск";
            // 
            // textbox_Control1_search
            // 
            this.textbox_Control1_search.AcceptsReturns = false;
            this.textbox_Control1_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_Control1_search.BackColor = System.Drawing.SystemColors.Window;
            this.textbox_Control1_search.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textbox_Control1_search.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.textbox_Control1_search.BorderSize = 2;
            this.textbox_Control1_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Control1_search.ForeColor = System.Drawing.Color.White;
            this.textbox_Control1_search.Liness = new string[] {
        "Название столбца: значение"};
            this.textbox_Control1_search.Location = new System.Drawing.Point(308, 31);
            this.textbox_Control1_search.MaxChars = 1000;
            this.textbox_Control1_search.MaxLengths = 32767;
            this.textbox_Control1_search.MultiLine = true;
            this.textbox_Control1_search.Name = "textbox_Control1_search";
            this.textbox_Control1_search.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textbox_Control1_search.PasswordChar = false;
            this.textbox_Control1_search.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_Control1_search.PlaceholderText = "Название столбца: значение";
            this.textbox_Control1_search.SelectionLength = 0;
            this.textbox_Control1_search.SelectionStart = 0;
            this.textbox_Control1_search.ShowScrollbar = false;
            this.textbox_Control1_search.Size = new System.Drawing.Size(516, 56);
            this.textbox_Control1_search.TabIndex = 38;
            this.textbox_Control1_search.Texts = "";
            this.textbox_Control1_search.UnderlinesStyle = true;
            this.textbox_Control1_search._TextChanged += new System.EventHandler(this.textbox_Control1_search__TextChanged);
            // 
            // yt_Button2
            // 
            this.yt_Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.yt_Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(116)))), ((int)(((byte)(174)))));
            this.yt_Button2.BackColorAdditional = System.Drawing.Color.Gray;
            this.yt_Button2.BackColorGradientEnabled = false;
            this.yt_Button2.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.yt_Button2.BackgroundImage = global::yt_DesignUI.Properties.Resources.free_icon_diskette_747439__2_;
            this.yt_Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.yt_Button2.BorderColor = System.Drawing.Color.Tomato;
            this.yt_Button2.BorderColorEnabled = false;
            this.yt_Button2.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.yt_Button2.BorderColorOnHoverEnabled = false;
            this.yt_Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yt_Button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yt_Button2.ForeColor = System.Drawing.Color.White;
            this.yt_Button2.Location = new System.Drawing.Point(930, 500);
            this.yt_Button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yt_Button2.Name = "yt_Button2";
            this.yt_Button2.RippleColor = System.Drawing.Color.Black;
            this.yt_Button2.RoundingEnable = false;
            this.yt_Button2.Size = new System.Drawing.Size(170, 63);
            this.yt_Button2.TabIndex = 35;
            this.yt_Button2.Text = "Удалить";
            this.yt_Button2.TextHover = null;
            this.yt_Button2.UseDownPressEffectOnClick = false;
            this.yt_Button2.UseRippleEffect = true;
            this.yt_Button2.UseVisualStyleBackColor = false;
            this.yt_Button2.UseZoomEffectOnHover = false;
            this.yt_Button2.Click += new System.EventHandler(this.yt_Button2_Click);
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
            this.yt_Button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yt_Button1.ForeColor = System.Drawing.Color.White;
            this.yt_Button1.Location = new System.Drawing.Point(932, 391);
            this.yt_Button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yt_Button1.Name = "yt_Button1";
            this.yt_Button1.RippleColor = System.Drawing.Color.Black;
            this.yt_Button1.RoundingEnable = false;
            this.yt_Button1.Size = new System.Drawing.Size(168, 63);
            this.yt_Button1.TabIndex = 34;
            this.yt_Button1.Text = "Изменить";
            this.yt_Button1.TextHover = null;
            this.yt_Button1.UseDownPressEffectOnClick = false;
            this.yt_Button1.UseRippleEffect = true;
            this.yt_Button1.UseVisualStyleBackColor = false;
            this.yt_Button1.UseZoomEffectOnHover = false;
            this.yt_Button1.Click += new System.EventHandler(this.yt_Button1_Click);
            // 
            // History_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 623);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "History_2";
            this.Text = "История заметок";
            this.Load += new System.EventHandler(this.History_2_Load);
            this.SizeChanged += new System.EventHandler(this.History_2_SizeChanged_1);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.History_2_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private Zanetki_design.yt_Button yt_Button1;
        private Zanetki_design.yt_Button yt_Button2;
        private Zanetki_design.Controls.Textbox_Control textbox_Control1_search;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}