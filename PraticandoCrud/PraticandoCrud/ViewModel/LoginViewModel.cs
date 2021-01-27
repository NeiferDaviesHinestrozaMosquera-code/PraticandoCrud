using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using PraticandoCrud.Model;
using PraticandoCrud.ViewModel;
using Xamarin.Forms;

namespace PraticandoCrud.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        #region atributes

        public string userName;

        public string password;

        #endregion


        #region Propiedades

        public string UserNameTxt
        {
            get { return this.userName; }

            set { SetValue(ref this.userName, value); }
        }



        public string PasswordTxt
        {
            get { return this.password; }

            set { SetValue(ref this.password, value); }
        }


        #endregion



        #region Commands

        public ICommand LoginCommand
        {

            get
            {
                return new RelayCommand(LoginMethod);

            }

            set { }
        }
        #endregion

        #region Methods
        public async void LoginMethod()
        {
            List<User> e = App.Database.GetUsersValidate(userName, password).Result;






            if (e.Count == 0)
            {

                await Application.Current.MainPage.DisplayAlert("Error", "User o password incorrecta", "Accept");



            }
            else if (e.Count > 0)
            {
                await Application.Current.MainPage.Navigation.PushAsync(new View.Registro());
                await Application.Current.MainPage.DisplayAlert("Listo", "Logeo Exitoso ", "Accept");



                #endregion
            }
        }

    }
}

