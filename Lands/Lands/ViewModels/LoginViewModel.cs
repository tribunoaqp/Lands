﻿

namespace Lands.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using Lands.Views;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class LoginViewModel:BaseViewModel
    {
        #region Attributes
        private string email;
        private string password;
        private bool isRunning;
        private bool isEnabled;
        #endregion
        #region Properties
        public string Email {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }
        public string Password {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }
        public bool IsRunning {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }
        public bool IsRemembered { get; set; }
        public bool IsEnabled {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }

        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get { return new RelayCommand(Login); }
        }

        

        public async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter an email",
                    "Accept");
                return;
            }
            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter an password",
                    "Accept");
                return;
            }

            this.IsRunning = true;
            this.IsEnabled = false;

            if(this.Email != "moscco@gmail.com" || this.Password != "12345")
            {
                this.IsRunning = false;
                this.IsEnabled = true;

                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Email or password incorrect.",
                    "Accept");
                this.Password = string.Empty;
                return;
            }

            this.IsRunning = false;
            this.IsEnabled = true;

            this.Email = string.Empty;
            this.Password = string.Empty;

            MainViewModel.GetInstance().Lands=new LandsViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new LandsPage());

        }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.IsRemembered = true;
            this.IsEnabled = true;

            this.Email = "moscco@gmail.com";
            this.Password = "12345";
        }
        #endregion
    }
}
