
namespace yt_DesignUI.Forms
{
    partial class CustomDialog2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomDialog2));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.yt_Button1 = new Zanetki_design.yt_Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(68, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 31);
            this.label1.TabIndex = 37;
            this.label1.Text = "Выберите заметку!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
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
            this.yt_Button1.Location = new System.Drawing.Point(187, 391);
            this.yt_Button1.Name = "yt_Button1";
            this.yt_Button1.RippleColor = System.Drawing.Color.Black;
            this.yt_Button1.RoundingEnable = false;
            this.yt_Button1.Size = new System.Drawing.Size(128, 52);
            this.yt_Button1.TabIndex = 38;
            this.yt_Button1.Text = "Ок";
            this.yt_Button1.TextHover = null;
            this.yt_Button1.UseDownPressEffectOnClick = false;
            this.yt_Button1.UseRippleEffect = true;
            this.yt_Button1.UseVisualStyleBackColor = false;
            this.yt_Button1.UseZoomEffectOnHover = false;
            this.yt_Button1.Click += new System.EventHandler(this.yt_Button1_Click_1);
            // 
            // CustomDialog2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 493);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.yt_Button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomDialog2";
            this.Text = "Внимание";
            this.Load += new System.EventHandler(this.CustomDialog2_Load);
            this.Resize += new System.EventHandler(this.CustomDialog2_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Zanetki_design.yt_Button yt_Button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}