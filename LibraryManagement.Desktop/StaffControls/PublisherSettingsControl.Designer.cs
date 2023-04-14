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
            PublisherDetailsGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            RefreshButton = new Guna.UI2.WinForms.Guna2Button();
            PublisherDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            publisherModelBindingSource = new BindingSource(components);
            serachTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            SearchPublisherButton = new Guna.UI2.WinForms.Guna2Button();
            AddPublisherButton = new Guna.UI2.WinForms.Guna2Button();
            idColumn = new DataGridViewTextBoxColumn();
            yearOfPublicationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            publisherNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            PublisherDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PublisherDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)publisherModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // PublisherDetailsGroupBox
            // 
            PublisherDetailsGroupBox.Controls.Add(RefreshButton);
            PublisherDetailsGroupBox.Controls.Add(PublisherDataGridView);
            PublisherDetailsGroupBox.Controls.Add(serachTextBox);
            PublisherDetailsGroupBox.Controls.Add(SearchPublisherButton);
            PublisherDetailsGroupBox.Controls.Add(AddPublisherButton);
            PublisherDetailsGroupBox.CustomizableEdges = customizableEdges9;
            PublisherDetailsGroupBox.FillColor = SystemColors.ButtonFace;
            PublisherDetailsGroupBox.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            PublisherDetailsGroupBox.ForeColor = SystemColors.ControlText;
            PublisherDetailsGroupBox.Location = new Point(12, 11);
            PublisherDetailsGroupBox.MaximumSize = new Size(935, 466);
            PublisherDetailsGroupBox.MinimumSize = new Size(935, 466);
            PublisherDetailsGroupBox.Name = "PublisherDetailsGroupBox";
            PublisherDetailsGroupBox.ShadowDecoration.CustomizableEdges = customizableEdges10;
            PublisherDetailsGroupBox.Size = new Size(935, 466);
            PublisherDetailsGroupBox.TabIndex = 1;
            PublisherDetailsGroupBox.Text = "Publisher Details";
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
            RefreshButton.TabIndex = 11;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // PublisherDataGridView
            // 
            PublisherDataGridView.AllowUserToAddRows = false;
            PublisherDataGridView.AllowUserToDeleteRows = false;
            PublisherDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(231, 241, 250);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(45, 175, 219);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            PublisherDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            PublisherDataGridView.AutoGenerateColumns = false;
            PublisherDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(43, 132, 180);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(43, 132, 180);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            PublisherDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            PublisherDataGridView.ColumnHeadersHeight = 40;
            PublisherDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            PublisherDataGridView.Columns.AddRange(new DataGridViewColumn[] { idColumn, yearOfPublicationDataGridViewTextBoxColumn, publisherNameDataGridViewTextBoxColumn });
            PublisherDataGridView.DataSource = publisherModelBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(213, 218, 223);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(45, 175, 219);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            PublisherDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            PublisherDataGridView.GridColor = Color.FromArgb(50, 56, 62);
            PublisherDataGridView.Location = new Point(28, 100);
            PublisherDataGridView.Name = "PublisherDataGridView";
            PublisherDataGridView.ReadOnly = true;
            PublisherDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(213, 218, 223);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(213, 218, 223);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            PublisherDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            PublisherDataGridView.RowHeadersVisible = false;
            PublisherDataGridView.RowTemplate.Height = 30;
            PublisherDataGridView.Size = new Size(876, 350);
            PublisherDataGridView.TabIndex = 10;
            PublisherDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            PublisherDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(231, 241, 250);
            PublisherDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PublisherDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Black;
            PublisherDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(45, 175, 219);
            PublisherDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.White;
            PublisherDataGridView.ThemeStyle.BackColor = Color.White;
            PublisherDataGridView.ThemeStyle.GridColor = Color.FromArgb(50, 56, 62);
            PublisherDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(43, 132, 180);
            PublisherDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            PublisherDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            PublisherDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            PublisherDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            PublisherDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            PublisherDataGridView.ThemeStyle.ReadOnly = true;
            PublisherDataGridView.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(213, 218, 223);
            PublisherDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.Single;
            PublisherDataGridView.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PublisherDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            PublisherDataGridView.ThemeStyle.RowsStyle.Height = 30;
            PublisherDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(45, 175, 219);
            PublisherDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // publisherModelBindingSource
            // 
            publisherModelBindingSource.DataSource = typeof(DataAccessLibrary.Models.PublisherModel);
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
            serachTextBox.TabIndex = 9;
            // 
            // SearchPublisherButton
            // 
            SearchPublisherButton.BorderColor = Color.WhiteSmoke;
            SearchPublisherButton.CustomizableEdges = customizableEdges5;
            SearchPublisherButton.DisabledState.BorderColor = Color.DarkGray;
            SearchPublisherButton.DisabledState.CustomBorderColor = Color.DarkGray;
            SearchPublisherButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SearchPublisherButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SearchPublisherButton.FillColor = Color.FromArgb(45, 175, 219);
            SearchPublisherButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchPublisherButton.ForeColor = Color.White;
            SearchPublisherButton.HoverState.FillColor = Color.FromArgb(43, 132, 180);
            SearchPublisherButton.HoverState.ForeColor = Color.White;
            SearchPublisherButton.Location = new Point(277, 55);
            SearchPublisherButton.Name = "SearchPublisherButton";
            SearchPublisherButton.Padding = new Padding(2);
            SearchPublisherButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            SearchPublisherButton.Size = new Size(118, 26);
            SearchPublisherButton.TabIndex = 7;
            SearchPublisherButton.Text = "Serach";
            SearchPublisherButton.Click += SearchPublisherButton_Click;
            // 
            // AddPublisherButton
            // 
            AddPublisherButton.BorderColor = Color.WhiteSmoke;
            AddPublisherButton.CustomizableEdges = customizableEdges7;
            AddPublisherButton.DisabledState.BorderColor = Color.DarkGray;
            AddPublisherButton.DisabledState.CustomBorderColor = Color.DarkGray;
            AddPublisherButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AddPublisherButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AddPublisherButton.FillColor = Color.FromArgb(45, 175, 219);
            AddPublisherButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddPublisherButton.ForeColor = Color.White;
            AddPublisherButton.HoverState.FillColor = Color.FromArgb(43, 132, 180);
            AddPublisherButton.HoverState.ForeColor = Color.White;
            AddPublisherButton.Location = new Point(808, 55);
            AddPublisherButton.Name = "AddPublisherButton";
            AddPublisherButton.Padding = new Padding(2);
            AddPublisherButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            AddPublisherButton.Size = new Size(96, 26);
            AddPublisherButton.TabIndex = 8;
            AddPublisherButton.Text = "Add";
            AddPublisherButton.Click += AddPublisherButton_Click;
            // 
            // idColumn
            // 
            idColumn.DataPropertyName = "Id";
            idColumn.FillWeight = 45.68528F;
            idColumn.HeaderText = "Id";
            idColumn.Name = "idColumn";
            idColumn.ReadOnly = true;
            // 
            // yearOfPublicationDataGridViewTextBoxColumn
            // 
            yearOfPublicationDataGridViewTextBoxColumn.DataPropertyName = "YearOfPublication";
            yearOfPublicationDataGridViewTextBoxColumn.FillWeight = 143.291122F;
            yearOfPublicationDataGridViewTextBoxColumn.HeaderText = "YearOfPublication";
            yearOfPublicationDataGridViewTextBoxColumn.Name = "yearOfPublicationDataGridViewTextBoxColumn";
            yearOfPublicationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publisherNameDataGridViewTextBoxColumn
            // 
            publisherNameDataGridViewTextBoxColumn.DataPropertyName = "PublisherName";
            publisherNameDataGridViewTextBoxColumn.FillWeight = 111.023613F;
            publisherNameDataGridViewTextBoxColumn.HeaderText = "PublisherName";
            publisherNameDataGridViewTextBoxColumn.Name = "publisherNameDataGridViewTextBoxColumn";
            publisherNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PublisherSettingsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(PublisherDetailsGroupBox);
            MaximumSize = new Size(958, 491);
            MinimumSize = new Size(958, 491);
            Name = "PublisherSettingsControl";
            Size = new Size(958, 491);
            PublisherDetailsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PublisherDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)publisherModelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox PublisherDetailsGroupBox;
        private Guna.UI2.WinForms.Guna2Button RefreshButton;
        private Guna.UI2.WinForms.Guna2DataGridView PublisherDataGridView;
        private Guna.UI2.WinForms.Guna2TextBox serachTextBox;
        private Guna.UI2.WinForms.Guna2Button SearchPublisherButton;
        private Guna.UI2.WinForms.Guna2Button AddPublisherButton;
        private BindingSource publisherModelBindingSource;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn yearOfPublicationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn publisherNameDataGridViewTextBoxColumn;
    }
}
