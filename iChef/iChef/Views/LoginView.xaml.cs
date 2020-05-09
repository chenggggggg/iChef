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
        public LoginView()
        {
            InitializeComponent();
            Init();

        }

        void Init()
        {
            App.InitializeInternetConnectionCheck(noInternetLabel, this);

            LoginViewModel loginViewModel = new LoginViewModel();
            this.BindingContext = loginViewModel;
            MessagingCenter.Subscribe<LoginViewModel, string>(this, "LoginAlert", (sender, username) =>
            {
                DisplayAlert("Title", username, "Ok");
            });

            usernameEntry.Completed += (object sender, EventArgs e) =>
            {
                passwordEntry.Focus();
            };

            passwordEntry.Completed += (object sender, EventArgs e) =>
            {
                LogIn(sender, e);
            };
        }

        async void LogIn(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            if (userService.VerifyUserCredentials(usernameEntry.Text, passwordEntry.Text))
            {
                User user = new User(usernameEntry.Text, passwordEntry.Text);
                var result = await App.RestService.Login(user);
                if (result.UserId > 0)
                {
                    await Navigation.PushAsync(new HomeView());
                }
            }
            else
            {
                await DisplayAlert("Login", "Username or password is empty", "Ok");
            }
        }
    }
}