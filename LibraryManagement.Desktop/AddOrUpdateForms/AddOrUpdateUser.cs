using DataAccessLibrary.DataAccess;
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

namespace LibraryManagement.Desktop.AddOrUpdateForms
{
    public partial class AddOrUpdateUser : Form
    {
        private readonly IMongoDBData _db;
        private readonly DataGridView _usersDataGridView;
        private readonly ObjectId _id;

        public AddOrUpdateUser(IMongoDBData db,DataGridView usersDataGridView,ObjectId id)
        {
            InitializeComponent();
            _db = db;
            _usersDataGridView = usersDataGridView;
            _id = id;


            if (!(id == ObjectId.Empty))
            {
                //HeadingName.Text = "Update Book";
                //SaveBookButton.Text = "Update";
            }
        }
    }
}
