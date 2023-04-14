using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;
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
    public partial class LogIn : Form
    {
        private readonly IMongoDBData _db;

        public LogIn(IMongoDBData db)
        {
            InitializeComponent();
            _db = db;
            DateTimeLable.Text = DateTime.Now.ToString("yyyy-MM-dd");
            UserNameTextBox.Focus();
        }

        private async void LogInButton_Click(object sender, EventArgs e)
        {
            string userName = UserNameTextBox.Text;
            string password = PasswordTextBox.Text;

            var users = await _db.LoadRecordsAsync<UserModel>("Users");
            var user = users.FirstOrDefault(u => u.UserName == userName && u.Password == password);

            if (user == null)
            {
                MessageBox.Show("Invalid username or password. Please try again.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

            }
            else
            {
                switch (user.Role.ToLower())
                {
                    case "admin":
                        MessageBox.Show("Welcome, Admin!",
                                        "Login Successful",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        this.Hide();
                        Staff staff = new Staff(_db, user);
                        staff.ShowDialog();
                        break;

                    case "reader":
                        MessageBox.Show("Welcome, Reader!",
                                        "Login Successful",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        this.Hide();
                        Reader reader = new Reader(_db, user);
                        reader.ShowDialog();
                        break;

                    default:
                        MessageBox.Show("Invalid role. Please contact the system administrator.",
                                        "Login Failed",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        break;
                }
            }

        }
    }

}
