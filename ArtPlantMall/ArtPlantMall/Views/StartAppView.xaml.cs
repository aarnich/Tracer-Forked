using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Auth;
using Newtonsoft.Json;
using Rg.Plugins.Popup.Services;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArtPlantMall.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartAppView : ContentPage
    {
        public static string WebApi = "AIzaSyDWHdJo1jRj2Z2LQxaiMCy6NnZEg1WTQ84";
        public static string Email { get; set; }
        public StartAppView()
        {
            InitializeComponent();
        }

        private async void ShowRegisterPopUp(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new RegisterPopUpPage());
        }

        private async void LoggingIn(object sender, EventArgs e)
        {
            var email = TxtEmail.Text;
            Email = email;
            var password = TxtPassword.Text;
            try
            {
                var authProvider = new FirebaseAuthProvider(new FirebaseConfig(WebApi));
                var auth = await authProvider.SignInWithEmailAndPasswordAsync(email, password);
                var content = await auth.GetFreshAuthAsync();
                var serializedContent = JsonConvert.SerializeObject(content);
                Preferences.Set("MyFirebaseRefreshToken", serializedContent);
                Application.Current.MainPage = new NavigationPage(new PlantMallView());
                await App.InitNavigation();
            }
            catch
            {
                await DisplayAlert("Log In Failed", "Invalid Email or Password", "Ok");
            }
        }
    }
}