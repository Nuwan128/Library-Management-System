using DataAccessLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Desktop.StaffControls
{
    public partial class PublisherSettingsControl : UserControl
    {
        private readonly IMongoDBData _db;

        public PublisherSettingsControl(IMongoDBData db)
        {
            InitializeComponent();
            _db = db;
        }
    }
}
