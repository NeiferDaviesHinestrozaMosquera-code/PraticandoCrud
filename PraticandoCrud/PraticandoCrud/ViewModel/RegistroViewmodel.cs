using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using PraticandoCrud.ViewModel;
using System.Windows.Input;
using PraticandoCrud.Model;
using GalaSoft.MvvmLight.Command;
using Xamarin.Forms;
using PraticandoCrud.View;

namespace PraticandoCrud.ViewModel
{
    public class RegistroViewmodel : BaseViewModel
    {

        #region atributes

        public string userName;

        public string password;

        public string email;

        public string phoneNumber;


        #endregion

        #region Propertie
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



        public string EmailTxt
        {
            get { return this.email; } 

            set { SetValue(ref this.email, value); }
        }


        public string PhoneNumberTxt
        {
            get { return this.phoneNumber; }

            set { SetValue(ref this.phoneNumber, value); }
        }
        #endregion


        #region Command
        public ICommand RegisterCommand
        {


            get
            {
                return new RelayCommand(RegisterMethod);
            }


        }
        #endregion

        #region Metodos
        public async void RegisterMethod()
        {


            var user = new User
            {
                UserName = UserNameTxt.ToLower(),
                Password = PasswordTxt.ToLower(),
                Email = EmailTxt.ToLower(),
                PhoneNumber = PhoneNumberTxt.ToLower()


            };

            await App.Database.SaveUserAsync(user);
            await Application.Current.MainPage.DisplayAlert("Datos guardados", "Bienvenido" + userName.ToString(), "Acectar");
            await Application.Current.MainPage.Navigation.PushAsync(new LoginPage());

            #endregion

        }
    }
}
