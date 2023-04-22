using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;
using LibraryManagement.Desktop.AddOrUpdateForms;
using MongoDB.Bson;
using MongoDB.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Desktop
{
    public partial class IssuedBooksControl : UserControl
    {
        private readonly IMongoDBData _db;

        public IssuedBooksControl(IMongoDBData db)
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
            reserveDateDataGridViewTextBoxColumn.DefaultCellStyle.Format = "MM-dd-yyyy";
            dueDateDataGridViewTextBoxColumn.DefaultCellStyle.Format = "MM-dd-yyyy";

            IssuedBooksDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            IssuedBooksDataGridView.Columns.Add(updateButtonColoumn);
            IssuedBooksDataGridView.Columns.Add(removeButtonColoumn);

            IssuedBooksDataGridView.CellFormatting += IssuedBooksDataGridView_CellFormatting;
            IssuedBooksDataGridView.CellContentClick += IssuedBooksDataGridView_CellContentClick;

            IssuedBooksDataGridView.DataSource = await _db.LoadRecordsAsync<IssueBookModel>("IssueBooks");
        }

        private void IssuedBooksDataGridView_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (IssuedBooksDataGridView.Columns[e.ColumnIndex].Name == "UpdateButtonColumn" && e.RowIndex >= 0)
            {
                var cell = IssuedBooksDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                cell.FlatStyle = FlatStyle.Flat;
                cell.Style.BackColor = Color.DarkGreen;
                cell.Style.ForeColor = Color.White;
                cell.Style.SelectionForeColor = Color.White;
                cell.Style.SelectionBackColor = Color.DarkGreen;
                cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (IssuedBooksDataGridView.Columns[e.ColumnIndex].Name == "RemoveButtonColumn" && e.RowIndex >= 0)
            {
                var cell = IssuedBooksDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                cell.FlatStyle = FlatStyle.Flat;
                cell.Style.BackColor = Color.DarkRed;
                cell.Style.ForeColor = Color.White;
                cell.Style.SelectionForeColor = Color.White;
                cell.Style.SelectionBackColor = Color.DarkRed;
                cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

        }
        private async void IssuedBooksDataGridView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {

            var idCellValue = IssuedBooksDataGridView.Rows[e.RowIndex].Cells["idColumn"].Value.ToString();
            var id = ObjectId.Parse(idCellValue);

            if (e.ColumnIndex == IssuedBooksDataGridView.Columns["UpdateButtonColumn"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Do you want to update issued book",
                                                     "Update Confirmation",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        AddOrUpdateIssuedBook updateIssuedBook = new AddOrUpdateIssuedBook(_db, IssuedBooksDataGridView, id);
                        updateIssuedBook.ShowDialog();
                    }
                    catch (Exception)
                    {
                        throw new Exception();
                    }

                }
            }
            if (e.ColumnIndex == IssuedBooksDataGridView.Columns["RemoveButtonColumn"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Do you want to remove issued book",
                                                    "Remove Confirmation",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        await _db.DeleteRecordAsync<IssueBookModel>("IssueBooks", id);

                        IssuedBooksDataGridView.DataSource = null;
                        IssuedBooksDataGridView.DataSource = await _db.LoadRecordsAsync<IssueBookModel>("IssueBooks");

                        MessageBox.Show("Issued Book removed successfully ",
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


        private void AddIssuedBookButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to issue a book",
                                                 "Issue Book Confirmation",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                try
                {
                    ObjectId id = ObjectId.Empty;
                    AddOrUpdateIssuedBook addIssuedBook = new AddOrUpdateIssuedBook(_db, IssuedBooksDataGridView, id);
                    addIssuedBook.ShowDialog();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private async void RefreshButton_Click(object sender, EventArgs e)
        {
            serachTextBox.Text = "";
            IssuedBooksDataGridView.DataSource = await _db.LoadRecordsAsync<IssueBookModel>("IssueBooks");
        }

        private async void SearchBookButton_Click(object sender, EventArgs e)
        {

            string ISBN = serachTextBox.Text;
            if (string.IsNullOrWhiteSpace(ISBN))
            {
                MessageBox.Show("Please Enter ISBN", "Empty Feild", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                serachTextBox.Text = "";
            }
            else
            {
                try
                {
                    IssuedBooksDataGridView.DataSource = await _db.SearchAsync<IssueBookModel>("IssueBooks", "ISBN", ISBN);
                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }
        }
    }
}
