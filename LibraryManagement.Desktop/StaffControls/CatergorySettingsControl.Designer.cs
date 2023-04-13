namespace LibraryManagement.Desktop.StaffControls
{
    partial class CatergorySettingsControl
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
            CatergoryDetailsGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            SuspendLayout();
            // 
            // CatergoryDetailsGroupBox
            // 
            CatergoryDetailsGroupBox.CustomizableEdges = customizableEdges1;
            CatergoryDetailsGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CatergoryDetailsGroupBox.ForeColor = SystemColors.ControlText;
            CatergoryDetailsGroupBox.Location = new Point(13, 12);
            CatergoryDetailsGroupBox.Name = "CatergoryDetailsGroupBox";
            CatergoryDetailsGroupBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            CatergoryDetailsGroupBox.Size = new Size(932, 464);
            CatergoryDetailsGroupBox.TabIndex = 1;
            CatergoryDetailsGroupBox.Text = "Catergory Detail";
            // 
            // CatergorySettingsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CatergoryDetailsGroupBox);
            MaximumSize = new Size(958, 491);
            MinimumSize = new Size(958, 491);
            Name = "CatergorySettingsControl";
            Size = new Size(958, 491);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox CatergoryDetailsGroupBox;
    }
}
