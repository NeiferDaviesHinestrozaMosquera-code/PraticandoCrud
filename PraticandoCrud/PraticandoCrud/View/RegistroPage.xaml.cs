using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PraticandoCrud.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PraticandoCrud.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
            BindingContext = new RegistroViewmodel();
        }

        private void IngresarLogin_Cliked (object sender,EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
    }
}