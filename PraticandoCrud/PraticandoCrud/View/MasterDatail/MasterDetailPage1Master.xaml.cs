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
using PraticandoCrud.View.Tabbed;

namespace PraticandoCrud.View.MasterDatail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1Master : ContentPage
    {
        public ListView ListView;

        public MasterDetailPage1Master()
        {
            InitializeComponent();

            BindingContext = new MasterDetailPage1MasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetailPage1MasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailPage1MasterMenuItem> MenuItems { get; set; }

            public MasterDetailPage1MasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailPage1MasterMenuItem>(new[]
                {
                    new MasterDetailPage1MasterMenuItem { Id = 0, Title = "Modulo 1" , TargetType = typeof(Page1), Icon = "casa.png"},
                    new MasterDetailPage1MasterMenuItem { Id = 1, Title = "Modulo 2" , TargetType = typeof(Page2), Icon = "sol.png"},
                    new MasterDetailPage1MasterMenuItem { Id = 2, Title = "Modulo 3" , TargetType = typeof(Page2), Icon = "cabeza.png"},
                    //new MasterDetailPage1MasterMenuItem { Id = 3, Title = "Page 4" },
                    //new MasterDetailPage1MasterMenuItem { Id = 4, Title = "Page 5" },
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