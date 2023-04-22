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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            MangeUserDetailsGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            RefreshButton = new Guna.UI2.WinForms.Guna2Button();
            UsersDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            serachTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            SearchBookButton = new Guna.UI2.WinForms.Guna2Button();
            AddUserButton = new Guna.UI2.WinForms.Guna2Button();
            userModelBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            profilePictureDataGridViewImageColumn = new DataGridViewImageColumn();
            MangeUserDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsersDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // MangeUserDetailsGroupBox
            // 
            MangeUserDetailsGroupBox.Controls.Add(RefreshButton);
            MangeUserDetailsGroupBox.Controls.Add(UsersDataGridView);
            MangeUserDetailsGroupBox.Controls.Add(serachTextBox);
            MangeUserDetailsGroupBox.Controls.Add(SearchBookButton);
            MangeUserDetailsGroupBox.Controls.Add(AddUserButton);
            MangeUserDetailsGroupBox.CustomizableEdges = customizableEdges19;
            MangeUserDetailsGroupBox.FillColor = SystemColors.ButtonFace;
            MangeUserDetailsGroupBox.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            MangeUserDetailsGroupBox.ForeColor = SystemColors.ControlText;
            MangeUserDetailsGroupBox.Location = new Point(12, 11);
            MangeUserDetailsGroupBox.Name = "MangeUserDetailsGroupBox";
            MangeUserDetailsGroupBox.ShadowDecoration.CustomizableEdges = customizableEdges20;
            MangeUserDetailsGroupBox.Size = new Size(935, 466);
            MangeUserDetailsGroupBox.TabIndex = 2;
            MangeUserDetailsGroupBox.Text = "Manage User Details";
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = Color.FromArgb(45, 175, 219);
            RefreshButton.BackgroundImage = Properties.Resources.refresh;
            RefreshButton.BackgroundImageLayout = ImageLayout.Stretch;
            RefreshButton.CustomizableEdges = customizableEdges11;
            RefreshButton.DisabledState.BorderColor = Color.DarkGray;
            RefreshButton.DisabledState.CustomBorderColor = Color.DarkGray;
            RefreshButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            RefreshButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            RefreshButton.FillColor = Color.Transparent;
            RefreshButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RefreshButton.ForeColor = Color.White;
            RefreshButton.Location = new Point(412, 55);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.ShadowDecoration.CustomizableEdges = customizableEdges12;
            RefreshButton.Size = new Size(35, 26);
            RefreshButton.TabIndex = 11;
            // 
            // UsersDataGridView
            // 
            UsersDataGridView.AllowUserToAddRows = false;
            UsersDataGridView.AllowUserToDeleteRows = false;
            UsersDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(231, 241, 250);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(45, 175, 219);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            UsersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            UsersDataGridView.AutoGenerateColumns = false;
            UsersDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(43, 132, 180);
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(43, 132, 180);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            UsersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            UsersDataGridView.ColumnHeadersHeight = 40;
            UsersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            UsersDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, userNameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn, profilePictureDataGridViewImageColumn });
            UsersDataGridView.DataSource = userModelBindingSource;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(213, 218, 223);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(45, 175, 219);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            UsersDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            UsersDataGridView.GridColor = Color.FromArgb(50, 56, 62);
            UsersDataGridView.Location = new Point(28, 100);
            UsersDataGridView.Name = "UsersDataGridView";
            UsersDataGridView.ReadOnly = true;
            UsersDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(213, 218, 223);
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(213, 218, 223);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            UsersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            UsersDataGridView.RowHeadersVisible = false;
            UsersDataGridView.RowTemplate.Height = 30;
            UsersDataGridView.Size = new Size(876, 350);
            UsersDataGridView.TabIndex = 10;
            UsersDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            UsersDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(231, 241, 250);
            UsersDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UsersDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Black;
            UsersDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(45, 175, 219);
            UsersDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.White;
            UsersDataGridView.ThemeStyle.BackColor = Color.White;
            UsersDataGridView.ThemeStyle.GridColor = Color.FromArgb(50, 56, 62);
            UsersDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(43, 132, 180);
            UsersDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            UsersDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            UsersDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            UsersDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            UsersDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            UsersDataGridView.ThemeStyle.ReadOnly = true;
            UsersDataGridView.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(213, 218, 223);
            UsersDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.Single;
            UsersDataGridView.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UsersDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            UsersDataGridView.ThemeStyle.RowsStyle.Height = 30;
            UsersDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(45, 175, 219);
            UsersDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // serachTextBox
            // 
            serachTextBox.CustomizableEdges = customizableEdges13;
            serachTextBox.DefaultText = "";
            serachTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            serachTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            serachTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            serachTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            serachTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            serachTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            serachTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            serachTextBox.Location = new Point(28, 55);
            serachTextBox.Name = "serachTextBox";
            serachTextBox.PasswordChar = '\0';
            serachTextBox.PlaceholderText = "";
            serachTextBox.SelectedText = "";
            serachTextBox.ShadowDecoration.CustomizableEdges = customizableEdges14;
            serachTextBox.Size = new Size(232, 26);
            serachTextBox.TabIndex = 9;
            // 
            // SearchBookButton
            // 
            SearchBookButton.BorderColor = Color.WhiteSmoke;
            SearchBookButton.CustomizableEdges = customizableEdges15;
            SearchBookButton.DisabledState.BorderColor = Color.DarkGray;
            SearchBookButton.DisabledState.CustomBorderColor = Color.DarkGray;
            SearchBookButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SearchBookButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SearchBookButton.FillColor = Color.FromArgb(45, 175, 219);
            SearchBookButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchBookButton.ForeColor = Color.White;
            SearchBookButton.HoverState.FillColor = Color.FromArgb(43, 132, 180);
            SearchBookButton.HoverState.ForeColor = Color.White;
            SearchBookButton.Location = new Point(277, 55);
            SearchBookButton.Name = "SearchBookButton";
            SearchBookButton.Padding = new Padding(2);
            SearchBookButton.ShadowDecoration.CustomizableEdges = customizableEdges16;
            SearchBookButton.Size = new Size(118, 26);
            SearchBookButton.TabIndex = 7;
            SearchBookButton.Text = "Serach";
            // 
            // AddUserButton
            // 
            AddUserButton.BorderColor = Color.WhiteSmoke;
            AddUserButton.CustomizableEdges = customizableEdges17;
            AddUserButton.DisabledState.BorderColor = Color.DarkGray;
            AddUserButton.DisabledState.CustomBorderColor = Color.DarkGray;
            AddUserButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AddUserButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AddUserButton.FillColor = Color.FromArgb(45, 175, 219);
            AddUserButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddUserButton.ForeColor = Color.White;
            AddUserButton.HoverState.FillColor = Color.FromArgb(43, 132, 180);
            AddUserButton.HoverState.ForeColor = Color.White;
            AddUserButton.Location = new Point(808, 55);
            AddUserButton.Name = "AddUserButton";
            AddUserButton.Padding = new Padding(2);
            AddUserButton.ShadowDecoration.CustomizableEdges = customizableEdges18;
            AddUserButton.Size = new Size(96, 26);
            AddUserButton.TabIndex = 8;
            AddUserButton.Text = "Add";
            // 
            // userModelBindingSource
            // 
            userModelBindingSource.DataSource = typeof(DataAccessLibrary.Models.UserModel);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            roleDataGridViewTextBoxColumn.HeaderText = "Role";
            roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profilePictureDataGridViewImageColumn
            // 
            profilePictureDataGridViewImageColumn.DataPropertyName = "ProfilePicture";
            profilePictureDataGridViewImageColumn.HeaderText = "ProfilePicture";
            profilePictureDataGridViewImageColumn.Name = "profilePictureDataGridViewImageColumn";
            profilePictureDataGridViewImageColumn.ReadOnly = true;
            // 
            // ManageUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(MangeUserDetailsGroupBox);
            MaximumSize = new Size(958, 491);
            MinimumSize = new Size(958, 491);
            Name = "ManageUserControl";
            Size = new Size(958, 491);
            MangeUserDetailsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UsersDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)userModelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox MangeUserDetailsGroupBox;
        private Guna.UI2.WinForms.Guna2Button RefreshButton;
        private Guna.UI2.WinForms.Guna2DataGridView UsersDataGridView;
        private Guna.UI2.WinForms.Guna2TextBox serachTextBox;
        private Guna.UI2.WinForms.Guna2Button SearchBookButton;
        private Guna.UI2.WinForms.Guna2Button AddUserButton;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private DataGridViewImageColumn profilePictureDataGridViewImageColumn;
        private BindingSource userModelBindingSource;
    }
}
