using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using PraticandoCrud.Data;
using PraticandoCrud.View;
using PraticandoCrud.View.MasterDatail;

namespace PraticandoCrud
{
    public partial class App : Application
    {

        static DatabaseQuery database;



        public static DatabaseQuery Database
        {
            get
            {
                if (database == null)
                {
                    database = new DatabaseQuery(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DBname.db"));
                }
                return database;
            }
        }


        ///public App()
        ///{



        ///InitializeComponent();

        /// MainPage = new NavigationPage(new Registro());
        ///MainPage = new NavigationPage(new MasterDetailPage());  ////CAMBIAR ESTA LINEA
        /// }

           public App()
         {



         InitializeComponent();

          MainPage = new NavigationPage(new LoginPage());
        }
         
        



        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
