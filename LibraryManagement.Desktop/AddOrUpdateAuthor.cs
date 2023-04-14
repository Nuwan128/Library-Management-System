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
    public partial class AddOrUpdateAuthor : Form
    {
        private readonly IMongoDBData _db;
        private readonly DataGridView _authorsDataGridView;
        private readonly ObjectId _id = ObjectId.Empty;

        public AddOrUpdateAuthor(IMongoDBData db, DataGridView AuthorsDataGridView, ObjectId id)
        {
            _db = db;
            _id = id;
            _authorsDataGridView = AuthorsDataGridView;
            InitializeComponent();
        }

        private async void SaveAuthorButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(AutherNameTextBox.Text))
            {
                MessageBox.Show("Please enter the author name", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AutherNameTextBox.Focus();
            }
            else
            {
                var author = new AuthorModel
                {
                    Name = AutherNameTextBox.Text
                };
                try
                {
                    if (_id == ObjectId.Empty)
                    {

                        await _db.InsertRecordAsync<AuthorModel>("Authors", author);
                        this.Hide();
                        MessageBox.Show("Author added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        author.Id = _id;
                        await _db.UpsertRecordAsync<AuthorModel>("Authors", author.Id, author);
                        this.Hide();
                        MessageBox.Show("Author updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    _authorsDataGridView.DataSource = null;
                    _authorsDataGridView.DataSource = await _db.LoadRecordsAsync<AuthorModel>("Authors");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
            }



        }
    }
}
