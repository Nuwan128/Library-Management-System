namespace LibraryManagement.Desktop
{
    partial class BooksControl
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
            BookDetailsGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            RefreshButton = new Guna.UI2.WinForms.Guna2Button();
            BooksDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            idColumn = new DataGridViewTextBoxColumn();
            iSBNDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            serachTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            SearchBookButton = new Guna.UI2.WinForms.Guna2Button();
            AddBookButton = new Guna.UI2.WinForms.Guna2Button();
            bookModelBindingSource = new BindingSource(components);
            BookDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BooksDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // BookDetailsGroupBox
            // 
            BookDetailsGroupBox.Controls.Add(RefreshButton);
            BookDetailsGroupBox.Controls.Add(BooksDataGridView);
            BookDetailsGroupBox.Controls.Add(serachTextBox);
            BookDetailsGroupBox.Controls.Add(SearchBookButton);
            BookDetailsGroupBox.Controls.Add(AddBookButton);
            BookDetailsGroupBox.CustomizableEdges = customizableEdges9;
            BookDetailsGroupBox.FillColor = SystemColors.ButtonFace;
            BookDetailsGroupBox.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BookDetailsGroupBox.ForeColor = SystemColors.ControlText;
            BookDetailsGroupBox.Location = new Point(12, 11);
            BookDetailsGroupBox.Name = "BookDetailsGroupBox";
            BookDetailsGroupBox.ShadowDecoration.CustomizableEdges = customizableEdges10;
            BookDetailsGroupBox.Size = new Size(935, 466);
            BookDetailsGroupBox.TabIndex = 0;
            BookDetailsGroupBox.Text = "Book Details";
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
            // BooksDataGridView
            // 
            BooksDataGridView.AllowUserToAddRows = false;
            BooksDataGridView.AllowUserToDeleteRows = false;
            BooksDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(231, 241, 250);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(45, 175, 219);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            BooksDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            BooksDataGridView.AutoGenerateColumns = false;
            BooksDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(43, 132, 180);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(43, 132, 180);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            BooksDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            BooksDataGridView.ColumnHeadersHeight = 40;
            BooksDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            BooksDataGridView.Columns.AddRange(new DataGridViewColumn[] { idColumn, iSBNDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn });
            BooksDataGridView.DataSource = bookModelBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(213, 218, 223);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(45, 175, 219);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            BooksDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            BooksDataGridView.GridColor = Color.FromArgb(50, 56, 62);
            BooksDataGridView.Location = new Point(28, 100);
            BooksDataGridView.Name = "BooksDataGridView";
            BooksDataGridView.ReadOnly = true;
            BooksDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(213, 218, 223);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(213, 218, 223);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            BooksDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            BooksDataGridView.RowHeadersVisible = false;
            BooksDataGridView.RowTemplate.Height = 30;
            BooksDataGridView.Size = new Size(876, 350);
            BooksDataGridView.TabIndex = 10;
            BooksDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            BooksDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(231, 241, 250);
            BooksDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BooksDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Black;
            BooksDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(45, 175, 219);
            BooksDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.White;
            BooksDataGridView.ThemeStyle.BackColor = Color.White;
            BooksDataGridView.ThemeStyle.GridColor = Color.FromArgb(50, 56, 62);
            BooksDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(43, 132, 180);
            BooksDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            BooksDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BooksDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            BooksDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            BooksDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            BooksDataGridView.ThemeStyle.ReadOnly = true;
            BooksDataGridView.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(213, 218, 223);
            BooksDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.Single;
            BooksDataGridView.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BooksDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            BooksDataGridView.ThemeStyle.RowsStyle.Height = 30;
            BooksDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(45, 175, 219);
            BooksDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // idColumn
            // 
            idColumn.DataPropertyName = "Id";
            idColumn.HeaderText = "Id";
            idColumn.Name = "idColumn";
            idColumn.ReadOnly = true;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            iSBNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            countDataGridViewTextBoxColumn.HeaderText = "Count";
            countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            countDataGridViewTextBoxColumn.ReadOnly = true;
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
            AddBookButton.TabIndex = 8;
            AddBookButton.Text = "Add";
            AddBookButton.Click += AddBookButton_Click;
            // 
            // bookModelBindingSource
            // 
            bookModelBindingSource.DataSource = typeof(DataAccessLibrary.Models.BookModel);
            // 
            // BooksControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(BookDetailsGroupBox);
            MaximumSize = new Size(958, 491);
            MinimumSize = new Size(958, 491);
            Name = "BooksControl";
            Size = new Size(958, 491);
            BookDetailsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BooksDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookModelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox BookDetailsGroupBox;
        private Guna.UI2.WinForms.Guna2Button RefreshButton;
        private Guna.UI2.WinForms.Guna2DataGridView BooksDataGridView;
        private Guna.UI2.WinForms.Guna2TextBox serachTextBox;
        private Guna.UI2.WinForms.Guna2Button SearchBookButton;
        private Guna.UI2.WinForms.Guna2Button AddBookButton;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private BindingSource bookModelBindingSource;
    }
}
