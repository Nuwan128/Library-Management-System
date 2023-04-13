namespace LibraryManagement.Desktop
{
    partial class IssuedBooksControl
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
            IssuedBookDetailsGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            SuspendLayout();
            // 
            // IssuedBookDetailsGroupBox
            // 
            IssuedBookDetailsGroupBox.CustomizableEdges = customizableEdges1;
            IssuedBookDetailsGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IssuedBookDetailsGroupBox.ForeColor = SystemColors.ControlText;
            IssuedBookDetailsGroupBox.Location = new Point(14, 13);
            IssuedBookDetailsGroupBox.MaximumSize = new Size(932, 464);
            IssuedBookDetailsGroupBox.MinimumSize = new Size(932, 464);
            IssuedBookDetailsGroupBox.Name = "IssuedBookDetailsGroupBox";
            IssuedBookDetailsGroupBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            IssuedBookDetailsGroupBox.Size = new Size(932, 464);
            IssuedBookDetailsGroupBox.TabIndex = 1;
            IssuedBookDetailsGroupBox.Text = "Issued Book Detail";
            // 
            // IssuedBooksControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(IssuedBookDetailsGroupBox);
            MaximumSize = new Size(958, 491);
            MinimumSize = new Size(958, 491);
            Name = "IssuedBooksControl";
            Size = new Size(958, 491);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox IssuedBookDetailsGroupBox;
    }
}
