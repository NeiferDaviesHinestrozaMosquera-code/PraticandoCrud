﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PraticandoCrud.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PraticandoCrud.View;

namespace PraticandoCrud.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }

        private void IngresarRegistro_Cliked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registro());
        }
    }
}