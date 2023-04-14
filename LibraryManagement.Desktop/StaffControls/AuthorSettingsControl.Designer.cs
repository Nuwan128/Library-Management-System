namespace LibraryManagement.Desktop.StaffControls
{
    partial class AuthorSettingsControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            AuthorDetailsGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            RefreshButton = new Guna.UI2.WinForms.Guna2Button();
            AuthorsDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            authorModelBindingSource = new BindingSource(components);
            serachTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            SearchBookButton = new Guna.UI2.WinForms.Guna2Button();
            AddBookButton = new Guna.UI2.WinForms.Guna2Button();
            idColumn = new DataGridViewTextBoxColumn();
            nameColumn = new DataGridViewTextBoxColumn();
            AuthorDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AuthorsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)authorModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // AuthorDetailsGroupBox
            // 
            AuthorDetailsGroupBox.Controls.Add(RefreshButton);
            AuthorDetailsGroupBox.Controls.Add(AuthorsDataGridView);
            AuthorDetailsGroupBox.Controls.Add(serachTextBox);
            AuthorDetailsGroupBox.Controls.Add(SearchBookButton);
            AuthorDetailsGroupBox.Controls.Add(AddBookButton);
            AuthorDetailsGroupBox.CustomizableEdges = customizableEdges9;
            AuthorDetailsGroupBox.FillColor = SystemColors.ButtonFace;
            AuthorDetailsGroupBox.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            AuthorDetailsGroupBox.ForeColor = Color.Black;
            AuthorDetailsGroupBox.Location = new Point(12, 11);
            AuthorDetailsGroupBox.Name = "AuthorDetailsGroupBox";
            AuthorDetailsGroupBox.ShadowDecoration.CustomizableEdges = customizableEdges10;
            AuthorDetailsGroupBox.Size = new Size(935, 466);
            AuthorDetailsGroupBox.TabIndex = 1;
            AuthorDetailsGroupBox.Text = "Author Details";
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = Color.FromArgb(45, 175, 219);
            RefreshButton.BackgroundImage = Properties.Resources.refresh;
            RefreshButton.BackgroundImageLayout = ImageLayout.Stretch;
            RefreshButton.CustomizableEdges = customizableEdges1;
            RefreshButton.DisabledState.BorderColor = Color.DarkGray;
            RefreshButton.DisabledState.CustomBorderColor = Color.DarkGray;
            RefreshButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            RefreshButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            RefreshButton.FillColor = Color.Transparent;
            RefreshButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RefreshButton.ForeColor = Color.White;
            RefreshButton.Location = new Point(412, 55);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            RefreshButton.Size = new Size(35, 26);
            RefreshButton.TabIndex = 6;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // AuthorsDataGridView
            // 
            AuthorsDataGridView.AllowUserToAddRows = false;
            AuthorsDataGridView.AllowUserToDeleteRows = false;
            AuthorsDataGridView.AllowUserToOrderColumns = true;
            AuthorsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(231, 241, 250);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(45, 175, 219);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            AuthorsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            AuthorsDataGridView.AutoGenerateColumns = false;
            AuthorsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(43, 132, 180);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(43, 132, 180);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AuthorsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AuthorsDataGridView.ColumnHeadersHeight = 40;
            AuthorsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            AuthorsDataGridView.Columns.AddRange(new DataGridViewColumn[] { idColumn, nameColumn });
            AuthorsDataGridView.DataSource = authorModelBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(213, 218, 223);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(45, 175, 219);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            AuthorsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            AuthorsDataGridView.GridColor = Color.FromArgb(50, 56, 62);
            AuthorsDataGridView.Location = new Point(28, 100);
            AuthorsDataGridView.Name = "AuthorsDataGridView";
            AuthorsDataGridView.ReadOnly = true;
            AuthorsDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(213, 218, 223);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(213, 218, 223);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            AuthorsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            AuthorsDataGridView.RowHeadersVisible = false;
            AuthorsDataGridView.RowTemplate.Height = 30;
            AuthorsDataGridView.Size = new Size(876, 350);
            AuthorsDataGridView.TabIndex = 5;
            AuthorsDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            AuthorsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(231, 241, 250);
            AuthorsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AuthorsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Black;
            AuthorsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(45, 175, 219);
            AuthorsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.White;
            AuthorsDataGridView.ThemeStyle.BackColor = Color.White;
            AuthorsDataGridView.ThemeStyle.GridColor = Color.FromArgb(50, 56, 62);
            AuthorsDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(43, 132, 180);
            AuthorsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            AuthorsDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AuthorsDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            AuthorsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            AuthorsDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            AuthorsDataGridView.ThemeStyle.ReadOnly = true;
            AuthorsDataGridView.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(213, 218, 223);
            AuthorsDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.Single;
            AuthorsDataGridView.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AuthorsDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            AuthorsDataGridView.ThemeStyle.RowsStyle.Height = 30;
            AuthorsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(45, 175, 219);
            AuthorsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // authorModelBindingSource
            // 
            authorModelBindingSource.DataSource = typeof(DataAccessLibrary.Models.AuthorModel);
            // 
            // serachTextBox
            // 
            serachTextBox.CustomizableEdges = customizableEdges3;
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
            serachTextBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            serachTextBox.Size = new Size(232, 26);
            serachTextBox.TabIndex = 4;
            // 
            // SearchBookButton
            // 
            SearchBookButton.BorderColor = Color.WhiteSmoke;
            SearchBookButton.CustomizableEdges = customizableEdges5;
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
            SearchBookButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            SearchBookButton.Size = new Size(118, 26);
            SearchBookButton.TabIndex = 2;
            SearchBookButton.Text = "Serach";
            SearchBookButton.Click += SearchBookButton_Click;
            // 
            // AddBookButton
            // 
            AddBookButton.BorderColor = Color.WhiteSmoke;
            AddBookButton.CustomizableEdges = customizableEdges7;
            AddBookButton.DisabledState.BorderColor = Color.DarkGray;
            AddBookButton.DisabledState.CustomBorderColor = Color.DarkGray;
            AddBookButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AddBookButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AddBookButton.FillColor = Color.FromArgb(45, 175, 219);
            AddBookButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddBookButton.ForeColor = Color.White;
            AddBookButton.HoverState.FillColor = Color.FromArgb(43, 132, 180);
            AddBookButton.HoverState.ForeColor = Color.White;
            AddBookButton.Location = new Point(808, 55);
            AddBookButton.Name = "AddBookButton";
            AddBookButton.Padding = new Padding(2);
            AddBookButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            AddBookButton.Size = new Size(96, 26);
            AddBookButton.TabIndex = 2;
            AddBookButton.Text = "Add";
            AddBookButton.Click += AddBookButton_Click;
            // 
            // idColumn
            // 
            idColumn.DataPropertyName = "Id";
            idColumn.HeaderText = "Id";
            idColumn.Name = "idColumn";
            idColumn.ReadOnly = true;
            // 
            // nameColumn
            // 
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Name";
            nameColumn.Name = "nameColumn";
            nameColumn.ReadOnly = true;
            // 
            // AuthorSettingsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(AuthorDetailsGroupBox);
            MaximumSize = new Size(958, 491);
            MinimumSize = new Size(958, 491);
            Name = "AuthorSettingsControl";
            Size = new Size(958, 491);
            AuthorDetailsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AuthorsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)authorModelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox AuthorDetailsGroupBox;
        private Guna.UI2.WinForms.Guna2DataGridView AuthorsDataGridView;
        private BindingSource authorModelBindingSource;
        private Guna.UI2.WinForms.Guna2TextBox serachTextBox;
        private Guna.UI2.WinForms.Guna2Button SearchBookButton;
        private Guna.UI2.WinForms.Guna2Button AddBookButton;
        private DataGridViewTextBoxColumn Id;
        private Guna.UI2.WinForms.Guna2Button RefreshButton;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn nameColumn;
    }
}
