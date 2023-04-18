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
    public partial class ReadersControl : UserControl
    {
        private readonly IMongoDBData _db;

        public ReadersControl(IMongoDBData db)
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

            ReadersDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            ReadersDataGridView.Columns.Add(updateButtonColoumn);
            ReadersDataGridView.Columns.Add(removeButtonColoumn);

            ReadersDataGridView.CellFormatting += ReadersDataGridView_CellFormatting;
            ReadersDataGridView.CellContentClick += ReadersDataGridView_CellContentClick;
            ReadersDataGridView.DataSource = await _db.LoadRecordsAsync<ReaderModel>("Readers");
        }

        private async void ReadersDataGridView_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (ReadersDataGridView.Columns[e.ColumnIndex].Name == "UpdateButtonColumn" && e.RowIndex >= 0)
            {
                var cell = ReadersDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                cell.FlatStyle = FlatStyle.Flat;
                cell.Style.BackColor = Color.DarkGreen;
                cell.Style.ForeColor = Color.White;
                cell.Style.SelectionForeColor = Color.White;
                cell.Style.SelectionBackColor = Color.DarkGreen;
                cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (ReadersDataGridView.Columns[e.ColumnIndex].Name == "RemoveButtonColumn" && e.RowIndex >= 0)
            {
                var cell = ReadersDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                cell.FlatStyle = FlatStyle.Flat;
                cell.Style.BackColor = Color.DarkRed;
                cell.Style.ForeColor = Color.White;
                cell.Style.SelectionForeColor = Color.White;
                cell.Style.SelectionBackColor = Color.DarkRed;
                cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private async void ReadersDataGridView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            var idCellValue = ReadersDataGridView.Rows[e.RowIndex].Cells["idColumn"].Value.ToString();
            var id = ObjectId.Parse(idCellValue);

            if (e.ColumnIndex == ReadersDataGridView.Columns["UpdateButtonColumn"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Do you want to update reader",
                                                     "Update Confirmation",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        AddOrUpdateReader updateBook = new AddOrUpdateReader(_db, ReadersDataGridView, id);
                        updateBook.ShowDialog();
                    }
                    catch (Exception)
                    {
                        throw new Exception();
                    }

                }
            }
            if (e.ColumnIndex == ReadersDataGridView.Columns["RemoveButtonColumn"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Do you want to remove reader",
                                                    "Remove Confirmation",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        await _db.DeleteRecordAsync<ReaderModel>("Readers", id);

                        ReadersDataGridView.DataSource = null;
                        ReadersDataGridView.DataSource = await _db.LoadRecordsAsync<ReaderModel>("Readers");

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



        private async void AddReaderButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to add a reader",
                                                            "New Reader Confirmation",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                try
                {
                    ObjectId id = ObjectId.Empty;
                    AddOrUpdateReader addBook = new AddOrUpdateReader(_db, ReadersDataGridView, id);
                    addBook.ShowDialog();
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
            ReadersDataGridView.DataSource = await _db.LoadRecordsAsync<ReaderModel>("Readers");
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
                    ReadersDataGridView.DataSource = await _db.SearchAsync<ReaderModel>("Readers", "Title", name);
                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }
        }





    }
}
