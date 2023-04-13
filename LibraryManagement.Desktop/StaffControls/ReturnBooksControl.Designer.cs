namespace LibraryManagement.Desktop
{
    partial class ReturnBooksControl
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
            ReturnBookDetailsGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            SuspendLayout();
            // 
            // ReturnBookDetailsGroupBox
            // 
            ReturnBookDetailsGroupBox.CustomizableEdges = customizableEdges1;
            ReturnBookDetailsGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ReturnBookDetailsGroupBox.ForeColor = SystemColors.ControlText;
            ReturnBookDetailsGroupBox.Location = new Point(14, 13);
            ReturnBookDetailsGroupBox.MaximumSize = new Size(888, 464);
            ReturnBookDetailsGroupBox.MinimumSize = new Size(888, 464);
            ReturnBookDetailsGroupBox.Name = "ReturnBookDetailsGroupBox";
            ReturnBookDetailsGroupBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ReturnBookDetailsGroupBox.Size = new Size(888, 464);
            ReturnBookDetailsGroupBox.TabIndex = 1;
            ReturnBookDetailsGroupBox.Text = "Return Book Detail";
            // 
            // ReturnBooksControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(ReturnBookDetailsGroupBox);
            MaximumSize = new Size(958, 491);
            MinimumSize = new Size(958, 491);
            Name = "ReturnBooksControl";
            Size = new Size(958, 491);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox ReturnBookDetailsGroupBox;
    }
}
