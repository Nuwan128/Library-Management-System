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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagement.Desktop
{
    public partial class AddOrUpdateBook : Form
    {
        private readonly IMongoDBData _db;
        private readonly DataGridView _bookDataGridView;
        private readonly ObjectId _id;
        private BookModel _book;

        public AddOrUpdateBook(IMongoDBData db, DataGridView bookDataGridView, ObjectId id)
        {
            _db = db;
            _id = id;
            _bookDataGridView = bookDataGridView;
            InitializeComponent();
            DisplayData();
            _book = new BookModel();
            if (!(id == ObjectId.Empty))
            {
                HeadingName.Text = "Update Book";
                SaveBookButton.Text = "Update";
            }
        }

        private async void DisplayData()
        {
            var catergories = await _db.LoadRecordsAsync<CategoryModel>("Categories");
            foreach (var category in catergories)
            {
                CatergoriescomboBox.Items.Add(category.Category);
            }

            var authors = await _db.LoadRecordsAsync<AuthorModel>("Authors");
            foreach (var author in authors)
            {
                AuthorscomboBox.Items.Add(author.Name);
            }
            var publishers = await _db.LoadRecordsAsync<PublisherModel>("Publishers");
            foreach (var publisher in publishers)
            {
                PublisherscomboBox.Items.Add(publisher.PublisherName);
            }

            CatergoriescomboBox.SelectedIndexChanged += CatergoriescomboBox_SelectedIndexChanged;
            AuthorscomboBox.SelectedIndexChanged += AuthorscomboBox_SelectedIndexChanged;
            PublisherscomboBox.SelectedIndexChanged += PublisherscomboBox_SelectedIndexChanged;
        }

        private async void PublisherscomboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string publisherName = PublisherscomboBox.SelectedItem.ToString();
            try
            {
                var publisher = await _db.SearchOneAsync<PublisherModel>("Publishers", "PublisherName", publisherName);
                _book.PublisherId = publisher.Id;

            }
            catch (Exception)
            {

                throw new Exception();
            }

        }

        private async void AuthorscomboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string authorName = AuthorscomboBox.SelectedItem.ToString();
            try
            {
                var author = await _db.SearchOneAsync<AuthorModel>("Authors", "Name", authorName);
                _book.AuthorId = author.Id;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private async void CatergoriescomboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string catergoryName = CatergoriescomboBox.SelectedItem.ToString();
            try
            {
                var category = await _db.SearchOneAsync<CategoryModel>("Categories", "Category", catergoryName);
                _book.CategoryId = category.Id;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void SaveBookButton_Click(object sender, EventArgs e)
        {
            List<string> emptyFields = new List<string>();
            if (string.IsNullOrWhiteSpace(ISBNTextBox.Text))
            {
                emptyFields.Add("ISBN Number");
                ISBNTextBox.Focus();
            }
            if (string.IsNullOrWhiteSpace(TitleTextBox.Text))
            {
                emptyFields.Add("Title");
                TitleTextBox.Focus();
            }
            if (EditionNumericUpDown.Value == 0)
            {
                emptyFields.Add("Edition");
                EditionNumericUpDown.Focus();
            }
            if (CountNumericUpDown.Value == 0)
            {
                emptyFields.Add("Count");
                CountNumericUpDown.Focus();
            }
            if (CatergoriescomboBox.SelectedIndex == -1)
            {
                emptyFields.Add("Catergory");
                CatergoriescomboBox.Focus();
            }
            if (AuthorscomboBox.SelectedIndex == -1)
            {
                emptyFields.Add("Auther");
                AuthorscomboBox.Focus();
            }
            if (PublisherscomboBox.SelectedIndex == -1)
            {
                emptyFields.Add("Publisher");
                PublisherscomboBox.Focus();
            }

            if (emptyFields.Count > 0)
            {
                string message = "Please enter the following fields:\n\n";
                message += string.Join("\n", emptyFields);
                MessageBox.Show(message, "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _book.ISBN = ISBNTextBox.Text;
            _book.Title = TitleTextBox.Text;
            _book.Edition = Convert.ToInt32(EditionNumericUpDown.Value);
            _book.Count = Convert.ToInt32(EditionNumericUpDown.Value);
            _book.CategoryId = _book.CategoryId;
            _book.AuthorId = _book.AuthorId;
            _book.PublisherId = _book.PublisherId;


            try
            {

                await _db.InsertRecordAsync<BookModel>("Books", _book);
                this.Hide();
                MessageBox.Show("Author added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _bookDataGridView.DataSource = await _db.LoadRecordsAsync<BookModel>("Books");
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }
    }
}
