namespace LibraryManagement.Desktop.StaffControls
{
    partial class ManageUserControl
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
            ManageUserGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            SuspendLayout();
            // 
            // ManageUserGroupBox
            // 
            ManageUserGroupBox.CustomizableEdges = customizableEdges1;
            ManageUserGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ManageUserGroupBox.ForeColor = SystemColors.ControlText;
            ManageUserGroupBox.Location = new Point(14, 13);
            ManageUserGroupBox.MaximumSize = new Size(932, 464);
            ManageUserGroupBox.MinimumSize = new Size(932, 464);
            ManageUserGroupBox.Name = "ManageUserGroupBox";
            ManageUserGroupBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ManageUserGroupBox.Size = new Size(932, 464);
            ManageUserGroupBox.TabIndex = 2;
            ManageUserGroupBox.Text = "Manage User Detail";
            // 
            // ManageUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(ManageUserGroupBox);
            MaximumSize = new Size(958, 491);
            MinimumSize = new Size(958, 491);
            Name = "ManageUserControl";
            Size = new Size(958, 491);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox ManageUserGroupBox;
    }
}
