namespace LibraryManagement.Desktop
{
    partial class ReadersControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ReaderDetailsGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            SuspendLayout();
            // 
            // ReaderDetailsGroupBox
            // 
            ReaderDetailsGroupBox.CustomizableEdges = customizableEdges1;
            ReaderDetailsGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ReaderDetailsGroupBox.ForeColor = SystemColors.ControlText;
            ReaderDetailsGroupBox.Location = new Point(14, 14);
            ReaderDetailsGroupBox.MaximumSize = new Size(932, 464);
            ReaderDetailsGroupBox.MinimumSize = new Size(932, 464);
            ReaderDetailsGroupBox.Name = "ReaderDetailsGroupBox";
            ReaderDetailsGroupBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ReaderDetailsGroupBox.Size = new Size(932, 464);
            ReaderDetailsGroupBox.TabIndex = 1;
            ReaderDetailsGroupBox.Text = "Reader Detail";
            // 
            // ReadersControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(ReaderDetailsGroupBox);
            MaximumSize = new Size(958, 491);
            MinimumSize = new Size(958, 491);
            Name = "ReadersControl";
            Size = new Size(958, 491);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox ReaderDetailsGroupBox;
    }
}
