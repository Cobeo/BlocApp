using System;
using Xamarin.Forms;
using BlocApp.Views;
using System.IO;

namespace BlocApp
{
    public partial class App : Application
    {
        #region DB
        public static bool IsDBModified = false;
        private static CotationDatabase _cotationDB;
        private static BlocDatabase _blocDB;

        public static CotationDatabase CotationDB
        {
            get
            {
                if(_cotationDB == null)
                {
                    _cotationDB = new CotationDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CotationSQLite.db3"));
                }
                return _cotationDB;
            }
        }
        public static BlocDatabase BlocDB
        {
            get
            {
                if (_blocDB == null)
                {
                    _blocDB = new BlocDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "BlocSQLite.db3"));
                }
                return _blocDB;
            }
        }
        #endregion DB

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
