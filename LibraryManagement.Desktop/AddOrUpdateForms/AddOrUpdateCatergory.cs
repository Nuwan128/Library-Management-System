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

namespace LibraryManagement.Desktop
{
    public partial class AddOrUpdateCatergory : Form
    {
        private readonly IMongoDBData _db;
        private readonly DataGridView _catergoryDataGridView;
        private readonly ObjectId _id = ObjectId.Empty;

        public AddOrUpdateCatergory(IMongoDBData db, DataGridView CatergoryDataGridView, ObjectId id)
        {
            InitializeComponent();
            _db = db;
            _id = id;
            _catergoryDataGridView = CatergoryDataGridView;
            if (!(id == ObjectId.Empty))
            {
                HeadingName.Text = "Update Catergory";
                SaveCatergoryButton.Text = "Update";
            }
        }

        private async void SaveCatergoryButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CatergoryNameTextBox.Text))
            {
                MessageBox.Show("Please enter the category name", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CatergoryNameTextBox.Focus();
            }
            else
            {
                var category = new CategoryModel
                {
                    Category = CatergoryNameTextBox.Text
                };
                try
                {
                    if (_id == ObjectId.Empty)
                    {

                        await _db.InsertRecordAsync<CategoryModel>("Categories", category);
                        this.Hide();
                        MessageBox.Show("Category added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        category.Id = _id;
                        await _db.UpsertRecordAsync<CategoryModel>("Categories", category.Id, category);
                        this.Hide();
                        MessageBox.Show("Category updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    _catergoryDataGridView.DataSource = null;
                    _catergoryDataGridView.DataSource = await _db.LoadRecordsAsync<CategoryModel>("Categories");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
            }

        }
    }
}
