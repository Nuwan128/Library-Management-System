using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;
using LibraryManagement.Desktop.StaffControls;
using MongoDB.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace LibraryManagement.Desktop
{
    public partial class Staff : Form
    {
        private readonly IMongoDBData _db;
        private readonly UserModel _user;
        private readonly BooksControl _booksControl;
        private readonly ReadersControl _readersControl;
        private readonly IssuedBooksControl _issuedBooksControl;
        private readonly OverdueBooksControl _overdueBooksControl;
        private readonly ReturnBooksControl _returnBooksControl;
        private readonly AuthorSettingsControl _authorSettingsControl;
        private readonly PublisherSettingsControl _publisherSettingsControl;
        private readonly CatergorySettingsControl _catergorySettingsControl;




        public Staff(IMongoDBData db, UserModel user)
        {
            _db = db;
            _user = user;

            _authorSettingsControl = new AuthorSettingsControl(_db);
            _catergorySettingsControl = new CatergorySettingsControl(_db);
            _publisherSettingsControl = new PublisherSettingsControl(_db);
            _booksControl = new BooksControl(_db);
            _issuedBooksControl = new IssuedBooksControl(_db);
            _readersControl = new ReadersControl(_db);
            //_overdueBooksControl = new OverdueBooksControl(_db);
            //_returnBooksControl = new ReturnBooksControl(_db);
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            try
            {
                if (_user.ProfilePicture != null)
                {
                    using (var memoryStream = new MemoryStream(_user.ProfilePicture))
                    {
                        ProfilePictureBox.Image = Image.FromStream(memoryStream);
                    }
                }
            }
            catch (ArgumentException ex)
            {

                MessageBox.Show("Error loading profile picture: " + ex.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error loading profile picture: " + ex.Message);
            }

            NameLable.Text = _user.UserName.ToUpper();
            RoleValueLable.Text = _user.Role.ToUpper();



            SettingsDropDown.Items.Add("Authors");
            SettingsDropDown.Items.Add("Publishers");
            SettingsDropDown.Items.Add("Catergories");
            SettingsDropDown.Height = 36;

        }
        private void BooksButton_Click(object sender, EventArgs e)
        {

            MainPanel.Controls.Add(_booksControl);
            _booksControl.Dock = DockStyle.Fill;
            _booksControl.BringToFront();

        }
        private void Staff_Load(object sender, EventArgs e)
        {
            MainPanel.Controls.Add(_booksControl);
            _booksControl.Dock = DockStyle.Fill;
            _booksControl.BringToFront();

        }
        private void ReadersButton_Click(object sender, EventArgs e)
        {

            MainPanel.Controls.Add(_readersControl);
            _readersControl.Dock = DockStyle.Fill;
            _readersControl.BringToFront();

        }
        private void IssueBooksButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Add(_issuedBooksControl);
            _issuedBooksControl.Dock = DockStyle.Fill;
            _issuedBooksControl.BringToFront();
        }
        private void ReturnBooksButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Add(_returnBooksControl);
            _returnBooksControl.Dock = DockStyle.Fill;
            _returnBooksControl.BringToFront();
        }
        private void OverDueBooksButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Add(_overdueBooksControl);
            _overdueBooksControl.Dock = DockStyle.Fill;
            _overdueBooksControl.BringToFront();
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?",
                                                   "Logout",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                LogIn logIn = new LogIn(_db);
                logIn.ShowDialog();
            }

        }
        private void ManageUserButton_Click(object sender, EventArgs e)
        {
            VerifyUser verifyUser = new VerifyUser(_user, MainPanel);
            verifyUser.ShowDialog();
        }
        private void SettingsDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SettingsDropDown.SelectedItem.ToString())
            {
                case "Authors":
                    MainPanel.Controls.Add(_authorSettingsControl);
                    _authorSettingsControl.Dock = DockStyle.Fill;
                    _authorSettingsControl.BringToFront();
                    break;
                case "Publishers":
                    MainPanel.Controls.Add(_publisherSettingsControl);
                    _publisherSettingsControl.Dock = DockStyle.Fill;
                    _publisherSettingsControl.BringToFront();
                    break;
                case "Catergories":
                    MainPanel.Controls.Add(_catergorySettingsControl);
                    _catergorySettingsControl.Dock = DockStyle.Fill;
                    _catergorySettingsControl.BringToFront();
                    break;
                default:
                    break;
            }
        }



        //private async void CreatUserButton_Click(object sender, EventArgs e)
        //{
        //    UserModel user = new UserModel
        //    {
        //        UserName = UserNameTextBox.Text,
        //        Password = PasswordTextBox.Text,
        //        Role = RoleTextBox.Text
        //    };

        //    try
        //    {
        //        await _db.InsertRecordAsync("Users", user);

        //        UserNameTextBox.Text = "";
        //        PasswordTextBox.Text = "";
        //        RoleTextBox.Text = "";
        //        MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred while adding the user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }


        //}
    }
}
