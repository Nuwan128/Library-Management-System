using DataAccessLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Desktop
{
    public partial class Splash : Form
    {
        private readonly IMongoDBData _db;

        public Splash(IMongoDBData db)
        {
            _db = db;
            InitializeComponent();
        }


        private async void Splash_Load(object sender, EventArgs e)
        {

            ProgressBar.Value = 0;

            var stopwatch = new Stopwatch();
            stopwatch.Start();


            var dbNames = await _db.ConnectToDbTimeAsync();

            stopwatch.Stop();

            var elapsedTime = stopwatch.Elapsed;


            var interval = (double)elapsedTime.TotalMilliseconds / 100;


            for (int i = 0; i <= 100; i++)
            {
                ProgressBar.Value = i;
                await Task.Delay((int)interval);
            }

            this.Hide();
            LogIn login = new LogIn(_db);
            login.ShowDialog();
        }



        //private void PbTimer_Tick(object sender, EventArgs e)
        //{
        //    startPoint += 1;
        //    ProgressBar.Value = startPoint;
        //    if (ProgressBar.Value == 100)
        //    {
        //        ProgressBar.Value = 0;
        //        PbTimer.Stop();
        //        
        //    }
        //}
    }
}
