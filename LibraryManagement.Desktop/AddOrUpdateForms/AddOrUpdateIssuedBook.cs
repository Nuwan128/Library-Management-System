using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace LibraryManagement.Desktop.AddOrUpdateForms
{
    public partial class AddOrUpdateIssuedBook : Form
    {
        private readonly IMongoDBData _db;
        private readonly DataGridView _issuedBooksDataGridView;
        private readonly ObjectId _id;
        private readonly IssueBookModel _issueBook;

        public AddOrUpdateIssuedBook(IMongoDBData db, DataGridView issuedBooksDataGridView, ObjectId id)
        {
            _db = db;
            _issuedBooksDataGridView = issuedBooksDataGridView;
            _id = id;
            _issueBook = new IssueBookModel();  
            InitializeComponent();
            if (!(id == ObjectId.Empty))
            {
                HeadingName.Text = "Update Issued Book";
                SaveIssuedBookButton.Text = "Update";
            }
        }

        private async void SaveIssuedBookButton_Click(object sender, EventArgs e)
        {
            List<string> emptyFields = new List<string>();
            if (string.IsNullOrWhiteSpace(ISBNTextBox.Text))
            {
                emptyFields.Add("ISBN Number");
                ISBNTextBox.Focus();
            }
            if (string.IsNullOrWhiteSpace(ReaderNoTextBox.Text))
            {
                emptyFields.Add("ISBN Number");
                ReaderNoTextBox.Focus();
            }
            if (emptyFields.Count > 0)
            {
                string message = "Please enter the following fields:\n\n";
                message += string.Join("\n", emptyFields);
                MessageBox.Show(message, "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _issueBook.ISBN = ISBNTextBox.Text;
            _issueBook.ReaderNo = Convert.ToInt32(ReaderNoTextBox.Text);
            _issueBook.ReserveDate = ReserveDateTimePicker.Value;
            _issueBook.DueDate = DueDateTimePicker.Value;

            try
            {

                if (_id == ObjectId.Empty)
                {
                    await _db.InsertRecordAsync<IssueBookModel>("IssueBooks", _issueBook);
                    this.Hide();
                    MessageBox.Show("Issued book added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _issueBook.Id = _id;
                    await _db.UpsertRecordAsync("IssueBooks", _issueBook.Id, _issueBook);
                    Hide();
                    MessageBox.Show("Issued book updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                _issuedBooksDataGridView.DataSource = null;
                _issuedBooksDataGridView.DataSource = await _db.LoadRecordsAsync<IssueBookModel>("IssueBooks");
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }
    }
}
