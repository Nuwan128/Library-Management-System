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
using System.Xml.Linq;

namespace LibraryManagement.Desktop.StaffControls
{
    public partial class CatergorySettingsControl : UserControl
    {
        private readonly IMongoDBData _db;

        public CatergorySettingsControl(IMongoDBData db)
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


            CatergoryDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            CatergoryDataGridView.Columns.Add(updateButtonColoumn);
            CatergoryDataGridView.Columns.Add(removeButtonColoumn);

            CatergoryDataGridView.CellFormatting += CatergoryDataGridView_CellFormatting;
            CatergoryDataGridView.CellContentClick += CatergoryDataGridView_CellContentClick;
            CatergoryDataGridView.DataSource = await _db.LoadRecordsAsync<CategoryModel>("Categories");
        }

        private async void CatergoryDataGridView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            var idCellValue = CatergoryDataGridView.Rows[e.RowIndex].Cells["idColumn"].Value.ToString();
            var id = ObjectId.Parse(idCellValue);

            if (e.ColumnIndex == CatergoryDataGridView.Columns["UpdateButtonColumn"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Do you want to update category",
                                                     "Update Confirmation",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        AddOrUpdateCatergory updateCatergory = new AddOrUpdateCatergory(_db, CatergoryDataGridView, id);
                        updateCatergory.ShowDialog();
                    }
                    catch (Exception)
                    {
                        throw new Exception();
                    }

                }
            }
            if (e.ColumnIndex == CatergoryDataGridView.Columns["RemoveButtonColumn"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Do you want to remove catergory",
                                                    "Remove Confirmation",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        await _db.DeleteRecordAsync<CategoryModel>("Categories", id);

                        CatergoryDataGridView.DataSource = null;
                        CatergoryDataGridView.DataSource = await _db.LoadRecordsAsync<CategoryModel>("Categories");

                        MessageBox.Show("Catergory removed successfully ",
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

        private void CatergoryDataGridView_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (CatergoryDataGridView.Columns[e.ColumnIndex].Name == "UpdateButtonColumn" && e.RowIndex >= 0)
            {
                var cell = CatergoryDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                cell.FlatStyle = FlatStyle.Flat;
                cell.Style.BackColor = Color.DarkGreen;
                cell.Style.ForeColor = Color.White;
                cell.Style.SelectionForeColor = Color.White;
                cell.Style.SelectionBackColor = Color.DarkGreen;
                cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (CatergoryDataGridView.Columns[e.ColumnIndex].Name == "RemoveButtonColumn" && e.RowIndex >= 0)
            {
                var cell = CatergoryDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                cell.FlatStyle = FlatStyle.Flat;
                cell.Style.BackColor = Color.DarkRed;
                cell.Style.ForeColor = Color.White;
                cell.Style.SelectionForeColor = Color.White;
                cell.Style.SelectionBackColor = Color.DarkRed;
                cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void AddCatergoryButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to add a category",
                                                 "New Author Confirmation",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                try
                {
                    ObjectId id = ObjectId.Empty;
                    AddOrUpdateCatergory addCatergory = new AddOrUpdateCatergory(_db, CatergoryDataGridView, id);
                    addCatergory.ShowDialog();
                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }
        }

        private async void SearchCatergoryButton_Click(object sender, EventArgs e)
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
                    CatergoryDataGridView.DataSource = await _db.SearchAsync<CategoryModel>("Categories", "Category", name);
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
            CatergoryDataGridView.DataSource = await _db.LoadRecordsAsync<CategoryModel>("Categories");

        }
    }
}
