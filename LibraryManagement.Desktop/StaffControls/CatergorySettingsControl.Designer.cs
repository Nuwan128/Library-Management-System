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
            CatergoryDetailsGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            RefreshButton = new Guna.UI2.WinForms.Guna2Button();
            CatergoryDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            idColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryModelBindingSource = new BindingSource(components);
            serachTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            SearchCatergoryButton = new Guna.UI2.WinForms.Guna2Button();
            AddCatergoryButton = new Guna.UI2.WinForms.Guna2Button();
            CatergoryDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CatergoryDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // CatergoryDetailsGroupBox
            // 
            CatergoryDetailsGroupBox.Controls.Add(RefreshButton);
            CatergoryDetailsGroupBox.Controls.Add(CatergoryDataGridView);
            CatergoryDetailsGroupBox.Controls.Add(serachTextBox);
            CatergoryDetailsGroupBox.Controls.Add(SearchCatergoryButton);
            CatergoryDetailsGroupBox.Controls.Add(AddCatergoryButton);
            CatergoryDetailsGroupBox.CustomizableEdges = customizableEdges19;
            CatergoryDetailsGroupBox.FillColor = SystemColors.ButtonFace;
            CatergoryDetailsGroupBox.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            CatergoryDetailsGroupBox.ForeColor = SystemColors.ControlText;
            CatergoryDetailsGroupBox.Location = new Point(12, 11);
            CatergoryDetailsGroupBox.MaximumSize = new Size(935, 466);
            CatergoryDetailsGroupBox.MinimumSize = new Size(935, 466);
            CatergoryDetailsGroupBox.Name = "CatergoryDetailsGroupBox";
            CatergoryDetailsGroupBox.ShadowDecoration.CustomizableEdges = customizableEdges20;
            CatergoryDetailsGroupBox.Size = new Size(935, 466);
            CatergoryDetailsGroupBox.TabIndex = 1;
            CatergoryDetailsGroupBox.Text = "Catergory Details";
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
            RefreshButton.Click += RefreshButton_Click;
            // 
            // CatergoryDataGridView
            // 
            CatergoryDataGridView.AllowUserToAddRows = false;
            CatergoryDataGridView.AllowUserToDeleteRows = false;
            CatergoryDataGridView.AllowUserToOrderColumns = true;
            CatergoryDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(231, 241, 250);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(45, 175, 219);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            CatergoryDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            CatergoryDataGridView.AutoGenerateColumns = false;
            CatergoryDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(43, 132, 180);
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(43, 132, 180);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            CatergoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            CatergoryDataGridView.ColumnHeadersHeight = 40;
            CatergoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            CatergoryDataGridView.Columns.AddRange(new DataGridViewColumn[] { idColumn, categoryDataGridViewTextBoxColumn });
            CatergoryDataGridView.DataSource = categoryModelBindingSource;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(213, 218, 223);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(45, 175, 219);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            CatergoryDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            CatergoryDataGridView.GridColor = Color.FromArgb(50, 56, 62);
            CatergoryDataGridView.Location = new Point(28, 100);
            CatergoryDataGridView.Name = "CatergoryDataGridView";
            CatergoryDataGridView.ReadOnly = true;
            CatergoryDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(213, 218, 223);
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(213, 218, 223);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            CatergoryDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            CatergoryDataGridView.RowHeadersVisible = false;
            CatergoryDataGridView.RowTemplate.Height = 30;
            CatergoryDataGridView.Size = new Size(876, 350);
            CatergoryDataGridView.TabIndex = 10;
            CatergoryDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            CatergoryDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(231, 241, 250);
            CatergoryDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CatergoryDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Black;
            CatergoryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(45, 175, 219);
            CatergoryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.White;
            CatergoryDataGridView.ThemeStyle.BackColor = Color.White;
            CatergoryDataGridView.ThemeStyle.GridColor = Color.FromArgb(50, 56, 62);
            CatergoryDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(43, 132, 180);
            CatergoryDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            CatergoryDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            CatergoryDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            CatergoryDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            CatergoryDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            CatergoryDataGridView.ThemeStyle.ReadOnly = true;
            CatergoryDataGridView.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(213, 218, 223);
            CatergoryDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.Single;
            CatergoryDataGridView.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CatergoryDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            CatergoryDataGridView.ThemeStyle.RowsStyle.Height = 30;
            CatergoryDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(45, 175, 219);
            CatergoryDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // idColumn
            // 
            idColumn.DataPropertyName = "Id";
            idColumn.HeaderText = "Id";
            idColumn.Name = "idColumn";
            idColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryModelBindingSource
            // 
            categoryModelBindingSource.DataSource = typeof(DataAccessLibrary.Models.CategoryModel);
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
            // SearchCatergoryButton
            // 
            SearchCatergoryButton.BorderColor = Color.WhiteSmoke;
            SearchCatergoryButton.CustomizableEdges = customizableEdges15;
            SearchCatergoryButton.DisabledState.BorderColor = Color.DarkGray;
            SearchCatergoryButton.DisabledState.CustomBorderColor = Color.DarkGray;
            SearchCatergoryButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SearchCatergoryButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SearchCatergoryButton.FillColor = Color.FromArgb(45, 175, 219);
            SearchCatergoryButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchCatergoryButton.ForeColor = Color.White;
            SearchCatergoryButton.HoverState.FillColor = Color.FromArgb(43, 132, 180);
            SearchCatergoryButton.HoverState.ForeColor = Color.White;
            SearchCatergoryButton.Location = new Point(277, 55);
            SearchCatergoryButton.Name = "SearchCatergoryButton";
            SearchCatergoryButton.Padding = new Padding(2);
            SearchCatergoryButton.ShadowDecoration.CustomizableEdges = customizableEdges16;
            SearchCatergoryButton.Size = new Size(118, 26);
            SearchCatergoryButton.TabIndex = 7;
            SearchCatergoryButton.Text = "Serach";
            SearchCatergoryButton.Click += SearchCatergoryButton_Click;
            // 
            // AddCatergoryButton
            // 
            AddCatergoryButton.BorderColor = Color.WhiteSmoke;
            AddCatergoryButton.CustomizableEdges = customizableEdges17;
            AddCatergoryButton.DisabledState.BorderColor = Color.DarkGray;
            AddCatergoryButton.DisabledState.CustomBorderColor = Color.DarkGray;
            AddCatergoryButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AddCatergoryButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AddCatergoryButton.FillColor = Color.FromArgb(45, 175, 219);
            AddCatergoryButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddCatergoryButton.ForeColor = Color.White;
            AddCatergoryButton.HoverState.FillColor = Color.FromArgb(43, 132, 180);
            AddCatergoryButton.HoverState.ForeColor = Color.White;
            AddCatergoryButton.Location = new Point(808, 55);
            AddCatergoryButton.Name = "AddCatergoryButton";
            AddCatergoryButton.Padding = new Padding(2);
            AddCatergoryButton.ShadowDecoration.CustomizableEdges = customizableEdges18;
            AddCatergoryButton.Size = new Size(96, 26);
            AddCatergoryButton.TabIndex = 8;
            AddCatergoryButton.Text = "Add";
            AddCatergoryButton.Click += AddCatergoryButton_Click;
            // 
            // CatergorySettingsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(CatergoryDetailsGroupBox);
            MaximumSize = new Size(958, 491);
            MinimumSize = new Size(958, 491);
            Name = "CatergorySettingsControl";
            Size = new Size(958, 491);
            CatergoryDetailsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CatergoryDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryModelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox CatergoryDetailsGroupBox;
        private Guna.UI2.WinForms.Guna2Button RefreshButton;
        private Guna.UI2.WinForms.Guna2DataGridView CatergoryDataGridView;
        private Guna.UI2.WinForms.Guna2TextBox serachTextBox;
        private Guna.UI2.WinForms.Guna2Button SearchCatergoryButton;
        private Guna.UI2.WinForms.Guna2Button AddCatergoryButton;
        private BindingSource categoryModelBindingSource;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
    }
}
