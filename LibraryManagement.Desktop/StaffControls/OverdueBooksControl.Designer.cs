namespace LibraryManagement.Desktop
{
    partial class OverdueBooksControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            OverdueBookDetailsGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            SuspendLayout();
            // 
            // OverdueBookDetailsGroupBox
            // 
            OverdueBookDetailsGroupBox.CustomizableEdges = customizableEdges3;
            OverdueBookDetailsGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OverdueBookDetailsGroupBox.ForeColor = SystemColors.ControlText;
            OverdueBookDetailsGroupBox.Location = new Point(14, 13);
            OverdueBookDetailsGroupBox.MaximumSize = new Size(932, 464);
            OverdueBookDetailsGroupBox.MinimumSize = new Size(932, 464);
            OverdueBookDetailsGroupBox.Name = "OverdueBookDetailsGroupBox";
            OverdueBookDetailsGroupBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            OverdueBookDetailsGroupBox.Size = new Size(932, 464);
            OverdueBookDetailsGroupBox.TabIndex = 1;
            OverdueBookDetailsGroupBox.Text = "Overdue Book Detail";
            // 
            // OverdueBooksControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(OverdueBookDetailsGroupBox);
            MaximumSize = new Size(958, 491);
            MinimumSize = new Size(958, 491);
            Name = "OverdueBooksControl";
            Size = new Size(958, 491);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox OverdueBookDetailsGroupBox;
    }
}
