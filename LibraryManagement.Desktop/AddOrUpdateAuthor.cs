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
        private readonly ObjectId _id;

        public AddOrUpdateAuthor(IMongoDBData db,DataGridView AuthorsDataGridView,ObjectId id)
        {
            InitializeComponent();
            _db = db;
            _authorsDataGridView = AuthorsDataGridView;
            _id = id;
        }

        private async void SaveAuthorButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(AutherNameTextBox.Text))
            {
                MessageBox.Show("Please enter the author name", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                var author = new AuthorModel
                {
                    Name = AutherNameTextBox.Text
                };
                try
                {
                    
                        await _db.InsertRecordAsync<AuthorModel>("Authors", author);
                        MessageBox.Show("Author added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                    
                        //await _db.UpsertRecordAsync<AuthorModel>("Authors",, author);
                    



                    this.Hide();
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
