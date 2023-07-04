using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;
using LibraryManagement.Desktop.AddOrUpdateForms;
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
    public partial class ManageUserControl : UserControl
    {
        private readonly IMongoDBData _db;

        public ManageUserControl(IMongoDBData db)
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

            UsersDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            UsersDataGridView.Columns.Add(updateButtonColoumn);
            UsersDataGridView.Columns.Add(removeButtonColoumn);

            UsersDataGridView.CellFormatting += UsersDataGridView_CellFormatting;
            UsersDataGridView.CellContentClick += UsersDataGridView_CellContentClick;
            UsersDataGridView.DataSource = await _db.LoadRecordsAsync<UserModel>("Users");
        }

        private async void UsersDataGridView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            var idCellValue = UsersDataGridView.Rows[e.RowIndex].Cells["idColumn"].Value.ToString();
            var id = ObjectId.Parse(idCellValue);

            if (e.ColumnIndex == UsersDataGridView.Columns["UpdateButtonColumn"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Do you want to update user",
                                                     "Update Confirmation",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        AddOrUpdateUser updateUser = new AddOrUpdateUser(_db, UsersDataGridView, id);
                        updateUser.ShowDialog();
                    }
                    catch (Exception)
                    {
                        throw new Exception();
                    }

                }
            }
            if (e.ColumnIndex == UsersDataGridView.Columns["RemoveButtonColumn"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Do you want to remove user",
                                                    "Remove Confirmation",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        await _db.DeleteRecordAsync<UserModel>("Users", id);

                        UsersDataGridView.DataSource = null;
                        UsersDataGridView.DataSource = await _db.LoadRecordsAsync<UserModel>("Users");

                        MessageBox.Show("User removed successfully ",
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

        private void UsersDataGridView_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (UsersDataGridView.Columns[e.ColumnIndex].Name == "UpdateButtonColumn" && e.RowIndex >= 0)
            {
                var cell = UsersDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                cell.FlatStyle = FlatStyle.Flat;
                cell.Style.BackColor = Color.DarkGreen;
                cell.Style.ForeColor = Color.White;
                cell.Style.SelectionForeColor = Color.White;
                cell.Style.SelectionBackColor = Color.DarkGreen;
                cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (UsersDataGridView.Columns[e.ColumnIndex].Name == "RemoveButtonColumn" && e.RowIndex >= 0)
            {
                var cell = UsersDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                cell.FlatStyle = FlatStyle.Flat;
                cell.Style.BackColor = Color.DarkRed;
                cell.Style.ForeColor = Color.White;
                cell.Style.SelectionForeColor = Color.White;
                cell.Style.SelectionBackColor = Color.DarkRed;
                cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
                    UsersDataGridView.DataSource = await _db.SearchAsync<UserModel>("Users", "UserName", name);
                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {

        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to add a user",
                                                "New User Confirmation",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                try
                {
                    ObjectId id = ObjectId.Empty;
                    AddOrUpdateUser addUser = new AddOrUpdateUser(_db, UsersDataGridView, id);
                    addUser.ShowDialog();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
