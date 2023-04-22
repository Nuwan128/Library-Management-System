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
            ReaderDetailsGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            RefreshButton = new Guna.UI2.WinForms.Guna2Button();
            ReadersDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            idColumn = new DataGridViewTextBoxColumn();
            readerNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            readerModelBindingSource = new BindingSource(components);
            serachTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            SearchBookButton = new Guna.UI2.WinForms.Guna2Button();
            AddReaderButton = new Guna.UI2.WinForms.Guna2Button();
            ReaderDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReadersDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)readerModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // ReaderDetailsGroupBox
            // 
            ReaderDetailsGroupBox.Controls.Add(RefreshButton);
            ReaderDetailsGroupBox.Controls.Add(ReadersDataGridView);
            ReaderDetailsGroupBox.Controls.Add(serachTextBox);
            ReaderDetailsGroupBox.Controls.Add(SearchBookButton);
            ReaderDetailsGroupBox.Controls.Add(AddReaderButton);
            ReaderDetailsGroupBox.CustomizableEdges = customizableEdges9;
            ReaderDetailsGroupBox.FillColor = SystemColors.ButtonFace;
            ReaderDetailsGroupBox.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ReaderDetailsGroupBox.ForeColor = SystemColors.ControlText;
            ReaderDetailsGroupBox.Location = new Point(12, 11);
            ReaderDetailsGroupBox.Name = "ReaderDetailsGroupBox";
            ReaderDetailsGroupBox.ShadowDecoration.CustomizableEdges = customizableEdges10;
            ReaderDetailsGroupBox.Size = new Size(935, 466);
            ReaderDetailsGroupBox.TabIndex = 1;
            ReaderDetailsGroupBox.Text = "Reader Details";
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
            // ReadersDataGridView
            // 
            ReadersDataGridView.AllowUserToAddRows = false;
            ReadersDataGridView.AllowUserToDeleteRows = false;
            ReadersDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(231, 241, 250);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(45, 175, 219);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            ReadersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ReadersDataGridView.AutoGenerateColumns = false;
            ReadersDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(43, 132, 180);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(43, 132, 180);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ReadersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ReadersDataGridView.ColumnHeadersHeight = 40;
            ReadersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ReadersDataGridView.Columns.AddRange(new DataGridViewColumn[] { idColumn, readerNoDataGridViewTextBoxColumn, userNameDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, userIdDataGridViewTextBoxColumn });
            ReadersDataGridView.DataSource = readerModelBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(213, 218, 223);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(45, 175, 219);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ReadersDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            ReadersDataGridView.GridColor = Color.FromArgb(50, 56, 62);
            ReadersDataGridView.Location = new Point(28, 100);
            ReadersDataGridView.Name = "ReadersDataGridView";
            ReadersDataGridView.ReadOnly = true;
            ReadersDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(213, 218, 223);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(213, 218, 223);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            ReadersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            ReadersDataGridView.RowHeadersVisible = false;
            ReadersDataGridView.RowTemplate.Height = 30;
            ReadersDataGridView.Size = new Size(876, 350);
            ReadersDataGridView.TabIndex = 10;
            ReadersDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            ReadersDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(231, 241, 250);
            ReadersDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ReadersDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Black;
            ReadersDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(45, 175, 219);
            ReadersDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.White;
            ReadersDataGridView.ThemeStyle.BackColor = Color.White;
            ReadersDataGridView.ThemeStyle.GridColor = Color.FromArgb(50, 56, 62);
            ReadersDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(43, 132, 180);
            ReadersDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ReadersDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ReadersDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ReadersDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ReadersDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            ReadersDataGridView.ThemeStyle.ReadOnly = true;
            ReadersDataGridView.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(213, 218, 223);
            ReadersDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.Single;
            ReadersDataGridView.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ReadersDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            ReadersDataGridView.ThemeStyle.RowsStyle.Height = 30;
            ReadersDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(45, 175, 219);
            ReadersDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // idColumn
            // 
            idColumn.DataPropertyName = "Id";
            idColumn.HeaderText = "Id";
            idColumn.Name = "idColumn";
            idColumn.ReadOnly = true;
            // 
            // readerNoDataGridViewTextBoxColumn
            // 
            readerNoDataGridViewTextBoxColumn.DataPropertyName = "ReaderNo";
            readerNoDataGridViewTextBoxColumn.HeaderText = "ReaderNo";
            readerNoDataGridViewTextBoxColumn.Name = "readerNoDataGridViewTextBoxColumn";
            readerNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // readerModelBindingSource
            // 
            readerModelBindingSource.DataSource = typeof(DataAccessLibrary.Models.ReaderModel);
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
            SearchBookButton.TabIndex = 7;
            SearchBookButton.Text = "Serach";
            SearchBookButton.Click += SearchBookButton_Click;
            // 
            // AddReaderButton
            // 
            AddReaderButton.BorderColor = Color.WhiteSmoke;
            AddReaderButton.CustomizableEdges = customizableEdges7;
            AddReaderButton.DisabledState.BorderColor = Color.DarkGray;
            AddReaderButton.DisabledState.CustomBorderColor = Color.DarkGray;
            AddReaderButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AddReaderButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AddReaderButton.FillColor = Color.FromArgb(45, 175, 219);
            AddReaderButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddReaderButton.ForeColor = Color.White;
            AddReaderButton.HoverState.FillColor = Color.FromArgb(43, 132, 180);
            AddReaderButton.HoverState.ForeColor = Color.White;
            AddReaderButton.Location = new Point(808, 55);
            AddReaderButton.Name = "AddReaderButton";
            AddReaderButton.Padding = new Padding(2);
            AddReaderButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            AddReaderButton.Size = new Size(96, 26);
            AddReaderButton.TabIndex = 8;
            AddReaderButton.Text = "Add";
            AddReaderButton.Click += AddReaderButton_Click;
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
            ReaderDetailsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ReadersDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)readerModelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox ReaderDetailsGroupBox;
        private Guna.UI2.WinForms.Guna2Button RefreshButton;
        private Guna.UI2.WinForms.Guna2DataGridView ReadersDataGridView;
        private BindingSource readerModelBindingSource;
        private Guna.UI2.WinForms.Guna2TextBox serachTextBox;
        private Guna.UI2.WinForms.Guna2Button SearchBookButton;
        private Guna.UI2.WinForms.Guna2Button AddReaderButton;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn readerNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
    }
}
