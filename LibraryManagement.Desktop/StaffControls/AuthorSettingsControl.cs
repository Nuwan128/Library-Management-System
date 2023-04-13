using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;
using MongoDB.Bson;
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

        private async void AuthorsDataGridView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            var idCellValue = AuthorsDataGridView.Rows[e.RowIndex].Cells["idColumn"].Value.ToString();
            var id = ObjectId.Parse(idCellValue);

            //var name = AuthorsDataGridView.Rows[e.RowIndex].Cells["Name"].Value.ToString();

            //List<string> columnNames = new List<string>();

            //foreach (DataGridViewColumn column in AuthorsDataGridView.Columns)
            //{
            //    columnNames.Add(column.Name);
            //}



            if (e.ColumnIndex == AuthorsDataGridView.Columns["UpdateButtonColumn"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Do you want to update author",
                                                     "Update Confirmation",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        AddOrUpdateAuthor updateAuthor = new AddOrUpdateAuthor(_db, AuthorsDataGridView, id);
                        updateAuthor.ShowDialog();
                    }
                    catch (Exception)
                    {
                        throw new Exception();
                    }

                }
            }
            if (e.ColumnIndex == AuthorsDataGridView.Columns["RemoveButtonColumn"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Do you want to remove author",
                                                    "Remove Confirmation",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        await _db.DeleteRecordAsync<AuthorModel>("Authors", id);

                        AuthorsDataGridView.DataSource = null;
                        AuthorsDataGridView.DataSource = await _db.LoadRecordsAsync<AuthorModel>("Authors");

                        MessageBox.Show("Author removed successfully ",
                                                 "Success",
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Information);

                    }
                    catch (Exception)
                    {
                        throw new Exception();
                    }

                }
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
            DialogResult result = MessageBox.Show("Do you want to add a author",
                                                   "New Author Confirmation",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                try
                {
                    ObjectId id = ObjectId.Empty;
                    AddOrUpdateAuthor updateAuthor = new AddOrUpdateAuthor(_db, AuthorsDataGridView, id);
                    updateAuthor.ShowDialog();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private async void SearchBookButton_Click(object sender, EventArgs e)
        {
            string name = serachTextBox.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please Enter Title", "Empty Feild", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                serachTextBox.Text = "";
                

            }
            else
            {
                try
                {
                    AuthorsDataGridView.DataSource = await _db.SearchAsync<AuthorModel>("Authors", "nameColumn", name);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private async void RefreshButton_Click(object sender, EventArgs e)
        {
            serachTextBox.Text = "";
            AuthorsDataGridView.DataSource = await _db.LoadRecordsAsync<AuthorModel>("Authors");
        }
    }
}
