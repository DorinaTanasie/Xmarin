using Money.Data;
using Money.Modules;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Money.View.DetailView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterUser : ContentPage
    {

        public RegisterUser()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            lbl_username.TextColor = Constants.MainTextColor;
            lbl_passwoed.TextColor = Constants.MainTextColor;
            lbl_Email.TextColor = Constants.MainTextColor;
            lbl_ConfPassword.TextColor = Constants.MainTextColor;
            LogoIcon.HeightRequest = Constants.LogoIconHeights;
            btn_register.BackgroundColor = Constants.BtnBackgroundColor;
           
        }
        void SaveNewUser(object sender, EventArgs e)
        {
           

            try
            {
                SQLiteConnection database;
                database = DependencyService.Get<ISQLite>().GetConnection();
                database.CreateTable<Users>();
                string username = entry_Username.Text;
                string password = entry_Password.Text;
                string email = entry_Email.Text;
                string confirmPass = entry_ConfirmPassword.Text;
                Users user = new Users(username, password);
                database.Insert(user);
                DisplayAlert("Alert", "Record Added Succesfully", "OK");


            }
           catch(Exception ex)
            {
                DisplayAlert("Alert", "Error", "Close");
            }

        }
        }
}