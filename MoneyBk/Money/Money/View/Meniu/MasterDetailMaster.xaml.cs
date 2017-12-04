using Money.View.DetailView;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Money.View.Meniu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailMaster : ContentPage
    {
        public ListView ListView;

        public MasterDetailMaster()
        {
            InitializeComponent();

            BindingContext = new MasterDetailMasterViewModel();
            ListView = MenuItemsListView;
        }
        //Aceasta clasa este creata pentru meniul principal,
        class MasterDetailMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailMenuItem> MenuItems { get; set; }

            public MasterDetailMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailMenuItem>(new[]
                {
                    new MasterDetailMenuItem("Home", "home.png", Color.Azure, typeof(InfoScreen2)),
                     new MasterDetailMenuItem("Records", "records.png", Color.Azure, typeof(InfoScreen1)),
                    new MasterDetailMenuItem("Account", "account.png", Color.Azure, typeof(InfoScreen2)),
                     new MasterDetailMenuItem("Settings", "records.png", Color.Azure, typeof(RegisterUser))
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}