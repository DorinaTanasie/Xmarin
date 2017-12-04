using Money.Data;
using Money.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Money
{
    public partial class App : Application
    {
       
        static UserDatabaseControler userDatabase;
        public App()
        {
            InitializeComponent();

            MainPage = new PageLogin();
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
        // this functions will return the control 
        public static UserDatabaseControler UserDatabase
        {
            get
            {
                if (userDatabase == null)
                {
                    userDatabase = new UserDatabaseControler();

                }
                return userDatabase;
            }


        }

       
    }
   
}
