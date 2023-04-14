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
    public partial class PublisherSettingsControl : UserControl
    {
        private readonly IMongoDBData _db;

        public PublisherSettingsControl(IMongoDBData db)
        {
            _db = db;
            InitializeComponent();
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


            PublisherDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            PublisherDataGridView.Columns.Add(updateButtonColoumn);
            PublisherDataGridView.Columns.Add(removeButtonColoumn);

            PublisherDataGridView.CellFormatting += PublisherDataGridView_CellFormatting;
            PublisherDataGridView.CellContentClick += PublisherDataGridView_CellContentClick;
            PublisherDataGridView.DataSource = await _db.LoadRecordsAsync<PublisherModel>("Publishers");
        }

        private async void PublisherDataGridView_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {

            if (PublisherDataGridView.Columns[e.ColumnIndex].Name == "UpdateButtonColumn" && e.RowIndex >= 0)
            {
                var cell = PublisherDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                cell.FlatStyle = FlatStyle.Flat;
                cell.Style.BackColor = Color.DarkGreen;
                cell.Style.ForeColor = Color.White;
                cell.Style.SelectionForeColor = Color.White;
                cell.Style.SelectionBackColor = Color.DarkGreen;
                cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (PublisherDataGridView.Columns[e.ColumnIndex].Name == "RemoveButtonColumn" && e.RowIndex >= 0)
            {
                var cell = PublisherDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                cell.FlatStyle = FlatStyle.Flat;
                cell.Style.BackColor = Color.DarkRed;
                cell.Style.ForeColor = Color.White;
                cell.Style.SelectionForeColor = Color.White;
                cell.Style.SelectionBackColor = Color.DarkRed;
                cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private async void PublisherDataGridView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            var idCellValue = PublisherDataGridView.Rows[e.RowIndex].Cells["idColumn"].Value.ToString();
            var id = ObjectId.Parse(idCellValue);

            if (e.ColumnIndex == PublisherDataGridView.Columns["UpdateButtonColumn"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Do you want to update publisher",
                                                     "Update Confirmation",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        AddOrUpdatePublisher updatePublisher = new AddOrUpdatePublisher(_db, PublisherDataGridView, id);
                        updatePublisher.ShowDialog();
                    }
                    catch (Exception)
                    {
                        throw new Exception();
                    }

                }
            }
            if (e.ColumnIndex == PublisherDataGridView.Columns["RemoveButtonColumn"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Do you want to remove publisher",
                                                    "Remove Confirmation",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        await _db.DeleteRecordAsync<PublisherModel>("Publishers", id);

                        PublisherDataGridView.DataSource = null;
                        PublisherDataGridView.DataSource = await _db.LoadRecordsAsync<PublisherModel>("Publishers");

                        MessageBox.Show("Publisher removed successfully ",
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

        private void AddPublisherButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to add a publisher",
                                                   "New Publisher Confirmation",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                try
                {
                    ObjectId id = ObjectId.Empty;
                    AddOrUpdatePublisher addPublisher = new AddOrUpdatePublisher(_db, PublisherDataGridView, id);
                    addPublisher.ShowDialog();
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
            PublisherDataGridView.DataSource = await _db.LoadRecordsAsync<PublisherModel>("Publishers");
        }

        private async void SearchPublisherButton_Click(object sender, EventArgs e)
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
                    PublisherDataGridView.DataSource = await _db.SearchAsync<PublisherModel>("Publishers", "PublisherName", name);
                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }


        }
    }
}
