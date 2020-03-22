using iChef.Models;
using iChef.Services;
using iChef.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iChef.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage 
    {
        public LoginViewModel loginViewModel;

        public LoginView()
        {
            InitializeComponent();

            App.InitializeInternetConnectionCheck(noInternetLabel, this);

            this.loginViewModel = new LoginViewModel();
            MessagingCenter.Subscribe<LoginViewModel, string>(this, "LoginAlert", (sender, username) =>
            {
                DisplayAlert("Title", username, "Ok");
            });
            this.BindingContext = loginViewModel;

            usernameEntry.Completed += (object sender, EventArgs e) =>
            {
                passwordEntry.Focus();
            };

            passwordEntry.Completed += (object sender, EventArgs e) =>
            {
                loginViewModel.SubmitCommand.Execute(null);
            };
        }

        public async void LogIn(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            if (userService.VerifyUserCredentials(usernameEntry.Text, passwordEntry.Text))
            {
                User user = new User(usernameEntry.Text, passwordEntry.Text);
                await App.RestService.Login(user);
            }
            else
            {
                await DisplayAlert("Login", "Username or password is empty", "Ok");
            }
        }
    }
}