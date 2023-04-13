namespace LibraryManagement.Desktop.StaffControls
{
    partial class PublisherSettingsControl
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
            PublisherDetailsGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            SuspendLayout();
            // 
            // PublisherDetailsGroupBox
            // 
            PublisherDetailsGroupBox.CustomizableEdges = customizableEdges1;
            PublisherDetailsGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PublisherDetailsGroupBox.ForeColor = SystemColors.ControlText;
            PublisherDetailsGroupBox.Location = new Point(14, 13);
            PublisherDetailsGroupBox.Name = "PublisherDetailsGroupBox";
            PublisherDetailsGroupBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PublisherDetailsGroupBox.Size = new Size(932, 464);
            PublisherDetailsGroupBox.TabIndex = 1;
            PublisherDetailsGroupBox.Text = "Publisher Detail";
            // 
            // PublisherSettingsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PublisherDetailsGroupBox);
            MaximumSize = new Size(958, 491);
            MinimumSize = new Size(958, 491);
            Name = "PublisherSettingsControl";
            Size = new Size(958, 491);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox PublisherDetailsGroupBox;
    }
}
