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
    public partial class Reader : Form
    {
        private readonly IMongoDBData _db;
        private readonly UserModel _user;

        public Reader(IMongoDBData db,UserModel user)
        {
            InitializeComponent();
            _db = db;
            _user = user;
        }
    }
}
