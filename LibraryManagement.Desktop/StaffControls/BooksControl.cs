using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;
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
    public partial class BooksControl : UserControl
    {
        private readonly IMongoDBData _db;

        public BooksControl(IMongoDBData db)
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

            BooksDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            BooksDataGridView.Columns.Add(updateButtonColoumn);
            BooksDataGridView.Columns.Add(removeButtonColoumn);

            BooksDataGridView.CellFormatting += BooksDataGridView_CellFormatting;
            BooksDataGridView.CellContentClick += BooksDataGridView_CellContentClick;
            BooksDataGridView.DataSource = await _db.LoadRecordsAsync<BookModel>("Books");
        }

        private async void BooksDataGridView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            var idCellValue = BooksDataGridView.Rows[e.RowIndex].Cells["idColumn"].Value.ToString();
            var id = ObjectId.Parse(idCellValue);

            if (e.ColumnIndex == BooksDataGridView.Columns["UpdateButtonColumn"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Do you want to update book",
                                                     "Update Confirmation",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        AddOrUpdateBook updateBook = new AddOrUpdateBook(_db, BooksDataGridView, id);
                        updateBook.ShowDialog();
                    }
                    catch (Exception)
                    {
                        throw new Exception();
                    }

                }
            }
            if (e.ColumnIndex == BooksDataGridView.Columns["RemoveButtonColumn"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Do you want to remove book",
                                                    "Remove Confirmation",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        await _db.DeleteRecordAsync<BookModel>("Books", id);

                        BooksDataGridView.DataSource = null;
                        BooksDataGridView.DataSource = await _db.LoadRecordsAsync<BookModel>("Books");

                        MessageBox.Show("Book removed successfully ",
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

        private void BooksDataGridView_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {

            if (BooksDataGridView.Columns[e.ColumnIndex].Name == "UpdateButtonColumn" && e.RowIndex >= 0)
            {
                var cell = BooksDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                cell.FlatStyle = FlatStyle.Flat;
                cell.Style.BackColor = Color.DarkGreen;
                cell.Style.ForeColor = Color.White;
                cell.Style.SelectionForeColor = Color.White;
                cell.Style.SelectionBackColor = Color.DarkGreen;
                cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (BooksDataGridView.Columns[e.ColumnIndex].Name == "RemoveButtonColumn" && e.RowIndex >= 0)
            {
                var cell = BooksDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
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
            DialogResult result = MessageBox.Show("Do you want to add a book",
                                                  "New Book Confirmation",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                try
                {
                    ObjectId id = ObjectId.Empty;
                    AddOrUpdateBook addBook = new AddOrUpdateBook(_db, BooksDataGridView, id);
                    addBook.ShowDialog();
                }
                catch (Exception ex)
                {
                    throw ex;
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
                    BooksDataGridView.DataSource = await _db.SearchAsync<BookModel>("Books", "Title", name);
                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }
        }
        private async void RefreshButton_Click(object sender, EventArgs e)
        {
            serachTextBox.Text = "";
            BooksDataGridView.DataSource = await _db.LoadRecordsAsync<BookModel>("Books");
        }



    }
}
