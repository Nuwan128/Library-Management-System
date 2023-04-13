using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Desktop.StaffControls
{
    public partial class AuthorSettingsControl : UserControl
    {
        private readonly IMongoDBData _db;

        public AuthorSettingsControl(IMongoDBData db)
        {
            InitializeComponent();
            _db = db;
            DisplayData();
        }

        private async void DisplayData()
        {

            var updateButtonColoumn = new DataGridViewButtonColumn
            {
                HeaderText = "Update",
                Name = "UpdateButtonColumn",
                Text = "Update",
                ToolTipText = "Update this record",
                UseColumnTextForButtonValue = true,



            };
            var removeButtonColoumn = new DataGridViewButtonColumn
            {
                HeaderText = "Remove",
                Name = "RemoveButtonColumn",
                Text = "Remove",
                ToolTipText = "Remove this record",
                UseColumnTextForButtonValue = true,


            };


            AuthorsDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            AuthorsDataGridView.Columns.Add(updateButtonColoumn);
            AuthorsDataGridView.Columns.Add(removeButtonColoumn);

            AuthorsDataGridView.CellFormatting += AuthorsDataGridView_CellFormatting;
            AuthorsDataGridView.CellContentClick += AuthorsDataGridView_CellContentClick;
            AuthorsDataGridView.DataSource = await _db.LoadRecordsAsync<AuthorModel>("Authors");
        }

        private void AuthorsDataGridView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == AuthorsDataGridView.Columns["UpdateButtonColumn"].Index && e.RowIndex >= 0)
            {
                MessageBox.Show("hello update");
            }
            else if (e.ColumnIndex == AuthorsDataGridView.Columns["RemoveButtonColumn"].Index && e.RowIndex >= 0)
            {
                MessageBox.Show("hello remove");
            }
        }

        private void AuthorsDataGridView_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {

            if (AuthorsDataGridView.Columns[e.ColumnIndex].Name == "UpdateButtonColumn" && e.RowIndex >= 0)
            {
                var cell = AuthorsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                cell.FlatStyle = FlatStyle.Flat;
                cell.Style.BackColor = Color.DarkGreen;
                cell.Style.ForeColor = Color.White;
                cell.Style.SelectionForeColor = Color.White;
                cell.Style.SelectionBackColor = Color.DarkGreen;
                cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (AuthorsDataGridView.Columns[e.ColumnIndex].Name == "RemoveButtonColumn" && e.RowIndex >= 0)
            {
                var cell = AuthorsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                cell.FlatStyle = FlatStyle.Flat;
                cell.Style.BackColor = Color.DarkRed;
                cell.Style.ForeColor = Color.White;
                cell.Style.SelectionForeColor = Color.White;
                cell.Style.SelectionBackColor = Color.DarkRed;
                cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {

        }
    }
}
