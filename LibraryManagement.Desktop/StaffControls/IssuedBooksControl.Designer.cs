namespace LibraryManagement.Desktop
{
    partial class IssuedBooksControl
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
            IssuedBookDetailsGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            RefreshButton = new Guna.UI2.WinForms.Guna2Button();
            IssuedBooksDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            serachTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            SearchBookButton = new Guna.UI2.WinForms.Guna2Button();
            AddIssuedBookButton = new Guna.UI2.WinForms.Guna2Button();
            issueBookModelBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iSBNDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            readerNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reserveDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dueDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            IssuedBookDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IssuedBooksDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)issueBookModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // IssuedBookDetailsGroupBox
            // 
            IssuedBookDetailsGroupBox.Controls.Add(RefreshButton);
            IssuedBookDetailsGroupBox.Controls.Add(IssuedBooksDataGridView);
            IssuedBookDetailsGroupBox.Controls.Add(serachTextBox);
            IssuedBookDetailsGroupBox.Controls.Add(SearchBookButton);
            IssuedBookDetailsGroupBox.Controls.Add(AddIssuedBookButton);
            IssuedBookDetailsGroupBox.CustomizableEdges = customizableEdges9;
            IssuedBookDetailsGroupBox.FillColor = SystemColors.ButtonFace;
            IssuedBookDetailsGroupBox.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            IssuedBookDetailsGroupBox.ForeColor = SystemColors.ControlText;
            IssuedBookDetailsGroupBox.Location = new Point(12, 11);
            IssuedBookDetailsGroupBox.Name = "IssuedBookDetailsGroupBox";
            IssuedBookDetailsGroupBox.ShadowDecoration.CustomizableEdges = customizableEdges10;
            IssuedBookDetailsGroupBox.Size = new Size(935, 466);
            IssuedBookDetailsGroupBox.TabIndex = 1;
            IssuedBookDetailsGroupBox.Text = "Issued Books Details";
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
            // IssuedBooksDataGridView
            // 
            IssuedBooksDataGridView.AllowUserToAddRows = false;
            IssuedBooksDataGridView.AllowUserToDeleteRows = false;
            IssuedBooksDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(231, 241, 250);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(45, 175, 219);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            IssuedBooksDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            IssuedBooksDataGridView.AutoGenerateColumns = false;
            IssuedBooksDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(43, 132, 180);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(43, 132, 180);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            IssuedBooksDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            IssuedBooksDataGridView.ColumnHeadersHeight = 40;
            IssuedBooksDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            IssuedBooksDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, iSBNDataGridViewTextBoxColumn, readerNoDataGridViewTextBoxColumn, reserveDateDataGridViewTextBoxColumn, dueDateDataGridViewTextBoxColumn });
            IssuedBooksDataGridView.DataSource = issueBookModelBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(213, 218, 223);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(45, 175, 219);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            IssuedBooksDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            IssuedBooksDataGridView.GridColor = Color.FromArgb(50, 56, 62);
            IssuedBooksDataGridView.Location = new Point(28, 100);
            IssuedBooksDataGridView.Name = "IssuedBooksDataGridView";
            IssuedBooksDataGridView.ReadOnly = true;
            IssuedBooksDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(213, 218, 223);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(213, 218, 223);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            IssuedBooksDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            IssuedBooksDataGridView.RowHeadersVisible = false;
            IssuedBooksDataGridView.RowTemplate.Height = 30;
            IssuedBooksDataGridView.Size = new Size(876, 350);
            IssuedBooksDataGridView.TabIndex = 10;
            IssuedBooksDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            IssuedBooksDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(231, 241, 250);
            IssuedBooksDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IssuedBooksDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Black;
            IssuedBooksDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(45, 175, 219);
            IssuedBooksDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.White;
            IssuedBooksDataGridView.ThemeStyle.BackColor = Color.White;
            IssuedBooksDataGridView.ThemeStyle.GridColor = Color.FromArgb(50, 56, 62);
            IssuedBooksDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(43, 132, 180);
            IssuedBooksDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            IssuedBooksDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            IssuedBooksDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            IssuedBooksDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            IssuedBooksDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            IssuedBooksDataGridView.ThemeStyle.ReadOnly = true;
            IssuedBooksDataGridView.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(213, 218, 223);
            IssuedBooksDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.Single;
            IssuedBooksDataGridView.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IssuedBooksDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            IssuedBooksDataGridView.ThemeStyle.RowsStyle.Height = 30;
            IssuedBooksDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(45, 175, 219);
            IssuedBooksDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
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
            // AddIssuedBookButton
            // 
            AddIssuedBookButton.BorderColor = Color.WhiteSmoke;
            AddIssuedBookButton.CustomizableEdges = customizableEdges7;
            AddIssuedBookButton.DisabledState.BorderColor = Color.DarkGray;
            AddIssuedBookButton.DisabledState.CustomBorderColor = Color.DarkGray;
            AddIssuedBookButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AddIssuedBookButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AddIssuedBookButton.FillColor = Color.FromArgb(45, 175, 219);
            AddIssuedBookButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddIssuedBookButton.ForeColor = Color.White;
            AddIssuedBookButton.HoverState.FillColor = Color.FromArgb(43, 132, 180);
            AddIssuedBookButton.HoverState.ForeColor = Color.White;
            AddIssuedBookButton.Location = new Point(808, 55);
            AddIssuedBookButton.Name = "AddIssuedBookButton";
            AddIssuedBookButton.Padding = new Padding(2);
            AddIssuedBookButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            AddIssuedBookButton.Size = new Size(96, 26);
            AddIssuedBookButton.TabIndex = 8;
            AddIssuedBookButton.Text = "Add";
            AddIssuedBookButton.Click += AddIssuedBookButton_Click;
            // 
            // issueBookModelBindingSource
            // 
            issueBookModelBindingSource.DataSource = typeof(DataAccessLibrary.Models.IssueBookModel);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            iSBNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // readerNoDataGridViewTextBoxColumn
            // 
            readerNoDataGridViewTextBoxColumn.DataPropertyName = "ReaderNo";
            readerNoDataGridViewTextBoxColumn.HeaderText = "ReaderNo";
            readerNoDataGridViewTextBoxColumn.Name = "readerNoDataGridViewTextBoxColumn";
            readerNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reserveDateDataGridViewTextBoxColumn
            // 
            reserveDateDataGridViewTextBoxColumn.DataPropertyName = "ReserveDate";
            reserveDateDataGridViewTextBoxColumn.HeaderText = "ReserveDate";
            reserveDateDataGridViewTextBoxColumn.Name = "reserveDateDataGridViewTextBoxColumn";
            reserveDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            dueDateDataGridViewTextBoxColumn.HeaderText = "DueDate";
            dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            dueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IssuedBooksControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(IssuedBookDetailsGroupBox);
            MaximumSize = new Size(958, 491);
            MinimumSize = new Size(958, 491);
            Name = "IssuedBooksControl";
            Size = new Size(958, 491);
            IssuedBookDetailsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IssuedBooksDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)issueBookModelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox IssuedBookDetailsGroupBox;
        private Guna.UI2.WinForms.Guna2Button RefreshButton;
        private Guna.UI2.WinForms.Guna2DataGridView IssuedBooksDataGridView;
        private Guna.UI2.WinForms.Guna2TextBox serachTextBox;
        private Guna.UI2.WinForms.Guna2Button SearchBookButton;
        private Guna.UI2.WinForms.Guna2Button AddIssuedBookButton;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn readerNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reserveDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private BindingSource issueBookModelBindingSource;
    }
}
