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

namespace LibraryManagement.Desktop.AddOrUpdateForms;

public partial class AddOrUpdateReader : Form
{
    private readonly IMongoDBData _db;
    private readonly DataGridView _readerDataGridView;
    private readonly ObjectId _id;
    private readonly ReaderModel _reader;

    public AddOrUpdateReader(IMongoDBData db, DataGridView readerDataGridView, ObjectId id)
    {
        _db = db;
        _readerDataGridView = readerDataGridView;
        _id = id;
        InitializeComponent();
        _reader = new ReaderModel();
        if (!(id == ObjectId.Empty))
        {
            HeadingName.Text = "Update Reader";
            SaveReaderButton.Text = "Update";
        }
    }

    private async void SaveReaderButton_Click(object sender, EventArgs e)
    {
        List<string> emptyFields = new List<string>();
        if (string.IsNullOrWhiteSpace(ReaderNOTextBox.Text))
        {
            emptyFields.Add("Reader Number");
            ReaderNOTextBox.Focus();
        }
        if (string.IsNullOrWhiteSpace(UserNameTextBox.Text))
        {
            emptyFields.Add("User Name");
            UserNameTextBox.Focus();
        }
        if (string.IsNullOrWhiteSpace(AddressRichTextBox.Text))
        {
            emptyFields.Add("Address");
            AddressRichTextBox.Focus();
        }
        if (string.IsNullOrWhiteSpace(PhoneNumber_01TextBox.Text))
        {
            emptyFields.Add("Phone Number");
            PhoneNumber_01TextBox.Focus();
        }
        if (string.IsNullOrWhiteSpace(UserIdTextBox.Text))
        {
            emptyFields.Add("User Id");
            UserIdTextBox.Focus();
        }


        if (emptyFields.Count > 0)
        {
            string message = "Please enter the following fields:\n\n";
            message += string.Join("\n", emptyFields);
            MessageBox.Show(message, "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }


        _reader.ReaderNo = int.Parse(ReaderNOTextBox.Text);
        _reader.UserName = UserNameTextBox.Text;
        _reader.Address = AddressRichTextBox.Text;
        _reader.UserId = ObjectId.Parse(UserIdTextBox.Text);
        _reader.PhoneNumbers.Add(PhoneNumber_01TextBox.Text);

        if (!string.IsNullOrWhiteSpace(PhoneNumber_02TextBox.Text))
        {
            _reader.PhoneNumbers.Add(PhoneNumber_02TextBox.Text);

        }

        try
        {
            await _db.InsertRecordAsync<ReaderModel>("Readers", _reader);
            this.Hide();
            MessageBox.Show("Reader added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _readerDataGridView.DataSource = await _db.LoadRecordsAsync<ReaderModel>("Readers");
        }
        catch (Exception ex)
        {

            throw ex;
        }

    }


}
