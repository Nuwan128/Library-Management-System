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
    public partial class AddOrUpdatePublisher : Form
    {
        private readonly IMongoDBData _db;
        private readonly DataGridView _publisherDataGridView;
        private readonly ObjectId _id = ObjectId.Empty;

        public AddOrUpdatePublisher(IMongoDBData db, DataGridView PublisherDataGridView, ObjectId id)
        {
            _db = db;
            _id = id;
            _publisherDataGridView = PublisherDataGridView;
            InitializeComponent();
            if (!(id == ObjectId.Empty))
            {
                HeadingName.Text = "Update Publisher";
                SavePublisherButton.Text = "Update";
            }
        }

        private async void SavePublisherButton_Click(object sender, EventArgs e)
        {

            string yearString = YearOfPublicationTextBox.Text;
            bool isValidYear = int.TryParse(yearString, out int result);

            if (string.IsNullOrWhiteSpace(PublisherNameTextBox.Text))
            {
                MessageBox.Show("Please enter the publisher name", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PublisherNameTextBox.Focus();
            }
            else if (string.IsNullOrWhiteSpace(YearOfPublicationTextBox.Text))
            {
                MessageBox.Show("Please enter the year", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                YearOfPublicationTextBox.Focus();
            }
            else
            {
                if (isValidYear == false)
                {
                    MessageBox.Show("Please enter the valid year", "Number Requird Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    YearOfPublicationTextBox.Text = "";
                    YearOfPublicationTextBox.Focus();
                }
                else
                {
                    var publisher = new PublisherModel
                    {
                        PublisherName = PublisherNameTextBox.Text,
                        YearOfPublication = result
                    };
                    try
                    {
                        if (_id == ObjectId.Empty)
                        {
                            await _db.InsertRecordAsync("Publishers", publisher);
                            Hide();
                            MessageBox.Show("Publisher added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            publisher.Id = _id;
                            await _db.UpsertRecordAsync("Publishers", publisher.Id, publisher);
                            Hide();
                            MessageBox.Show("Publisher updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        _publisherDataGridView.DataSource = null;
                        _publisherDataGridView.DataSource = await _db.LoadRecordsAsync<PublisherModel>("Publishers");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex}");
                    }
                }

            }
        }
    }
}
