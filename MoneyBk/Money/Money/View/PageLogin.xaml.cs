using Money.Data;
using Money.Modules;
using Money.View.DetailView;
using Money.View.Meniu;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Money.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageLogin : ContentPage
    {
        public PageLogin()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            BackgroundColor = Constants.BackgroundColor; // we will overwritten
            lbl_username.TextColor = Constants.MainTextColor;
            lbl_pasword.TextColor = Constants.MainTextColor;
            //because we won't to se our activity spiner on we entry username or pasword
            ActivitySpiner.IsVisible = false;
            LogoIcon.HeightRequest = Constants.LogoIconHeights;
            entry_username.Completed += (s, e) => entry_pasword.Focus();//when the username is enterd and the user pres the return key, keybord will be hidden the focus will be seted on the password
            entry_pasword.Completed += (s, e) => SingInProcedure(s, e); // this function will be automatic called



        }
        async void SingInProcedure(object sender, EventArgs e)
        {
            // folosim async si await pentru a crea  threed-uri, rulam mai multe task-uri in paralel
            Users user = new Users(entry_username.Text, entry_pasword.Text);// now that we have user object we can make an functionality
            if (user.CheckInformation())
            {
                try { 
                SQLiteConnection database;
                database = DependencyService.Get<ISQLite>().GetConnection();
                var callTabel = database.Table<Users>(); //Call Table  
                var takeInfoFromTabel = callTabel.Where(x => x.username == entry_username.Text && x.pasword== entry_pasword.Text).FirstOrDefault(); //Linq Query  
                if (takeInfoFromTabel != null)
                {
                    await DisplayAlert("Login", OutputText.SuccesLogin, "Oke");

                        if (Device.RuntimePlatform == Device.Android)
                        {
                            Application.Current.MainPage = new MasterDetail();
                           
                        }
                    }
                else
                {
                    await DisplayAlert("Login", OutputText.NotMember, "Oke");
                    //  ActivitySpiner.IsVisible = false;
                }
                }
                catch(Exception ex)
                {
                    await DisplayAlert("Login", ex.ToString(), "Oke");
                }
                //  App.UserDatabase.SaveUser(user); // we cen save any user in our local database 
                // dupa ce ne-am logat si intram in pagina principala vrem ca atunci cand apasam butonul de "back"
                // sa nu intram inapoi in pagina de logare de aceea este nevoie sa suprascriem aceasta pagina cu cea noua
                // acest lucru se face diferit pentru androd si pt IOS
               


            }
            else
            {
                await DisplayAlert("Login", OutputText.error_PwOrUsr_empty, "Oke");
              //  ActivitySpiner.IsVisible = false;
            }
        }
        void NewUser(object sender, EventArgs e)
        {
            Application.Current.MainPage = new RegisterUser();
        }
    }
}