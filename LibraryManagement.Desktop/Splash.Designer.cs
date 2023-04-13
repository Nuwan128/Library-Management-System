namespace LibraryManagement.Desktop
{
    partial class Splash
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            PbTimer = new System.Windows.Forms.Timer(components);
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ProgressBar
            // 
            ProgressBar.BackColor = Color.Transparent;
            ProgressBar.BorderColor = Color.FromArgb(45, 175, 219);
            ProgressBar.BorderThickness = 2;
            ProgressBar.CustomizableEdges = customizableEdges1;
            ProgressBar.FillColor = Color.Transparent;
            ProgressBar.Location = new Point(450, 302);
            ProgressBar.Margin = new Padding(3, 2, 3, 2);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.ProgressColor = Color.FromArgb(45, 175, 219);
            ProgressBar.ProgressColor2 = Color.FromArgb(45, 175, 219);
            ProgressBar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ProgressBar.Size = new Size(314, 14);
            ProgressBar.TabIndex = 0;
            ProgressBar.Text = "guna2ProgressBar1";
            ProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.Transparent;
            guna2PictureBox1.CustomizableEdges = customizableEdges3;
            guna2PictureBox1.Image = Properties.Resources.public_library;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(411, 44);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2PictureBox1.Size = new Size(394, 337);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 6;
            guna2PictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(593, 274);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(55, 17);
            guna2HtmlLabel1.TabIndex = 7;
            guna2HtmlLabel1.Text = "Loading...";
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Base;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(814, 365);
            ControlBox = false;
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(ProgressBar);
            Controls.Add(guna2PictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(814, 365);
            MinimumSize = new Size(814, 365);
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash";
            Load += Splash_Load;
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ProgressBar ProgressBar;
        private System.Windows.Forms.Timer PbTimer;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}