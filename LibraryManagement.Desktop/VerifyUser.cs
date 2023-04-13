using DataAccessLibrary.Models;
using Guna.UI2.WinForms;
using LibraryManagement.Desktop.StaffControls;
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
    public partial class VerifyUser : Form
    {
        private readonly UserModel _user;
        private readonly Guna2Panel _panel;
        private readonly ManageUserControl manageUserControl = new ManageUserControl();

        public VerifyUser(UserModel user, Guna2Panel panel)
        {
            InitializeComponent();
            _user = user;
            _panel = panel;
            name.Text = _user.UserName;
        }

        private void VerifyButton_Click(object sender, EventArgs e)
        {
            if (_user.Password == PasswordTextBox.Text)
            {
                this.Hide();

                _panel.Controls.Add(manageUserControl);
                manageUserControl.Dock = DockStyle.Fill;
                manageUserControl.BringToFront();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
