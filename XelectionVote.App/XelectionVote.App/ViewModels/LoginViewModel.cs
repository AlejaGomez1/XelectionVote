using GalaSoft.MvvmLight.Command;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace XelectionVote.App.ViewModels
{
    public class LoginViewModel
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public ICommand LoginCommand => new RelayCommand(Login);

        public LoginViewModel()
        {
            this.Email = "malejalgomez@gmail.com";
            this.Password = "123456";
        }

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must type an email",
                    "Accept");
                return;
            }
            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must type an password",
                    "Accept");
                return;
            }

            if(!this.Email.Equals("malejalgomez@gmail.com") || !this.Password.Equals("123456"))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "User or password wrong",
                    "Accept");
                return;
            }
           
                await Application.Current.MainPage.DisplayAlert(
                    "Ok",
                    "Fuck yeah",
                    "Accept");
        }
    }
}
