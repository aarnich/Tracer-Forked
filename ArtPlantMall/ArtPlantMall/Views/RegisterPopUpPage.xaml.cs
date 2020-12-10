using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Auth;
using Newtonsoft.Json;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArtPlantMall.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPopUpPage
    {
        public RegisterPopUpPage()
        {
            InitializeComponent();
        }

        private async void Register(object sender, EventArgs e)
        {
            var email = TxtEmail.Text;
            var password = TxtPWord.Text;
            var confirmPassword = TxtConPWord.Text;

            if (email != string.Empty && password != string.Empty && confirmPassword != string.Empty &&
                password == confirmPassword)
            {
                try
                {
                    var authProvider = new FirebaseAuthProvider(new FirebaseConfig(StartAppView.WebApi));
                    var auth = await authProvider.CreateUserWithEmailAndPasswordAsync(email, password);
                    var refreshToken = await auth.GetFreshAuthAsync();
                    var serializedContent = JsonConvert.SerializeObject(refreshToken);
                    Preferences.Set("MyFirebaseRefreshToken", serializedContent);
                    await PopupNavigation.Instance.PopAsync();
                    await Navigation.PushAsync(new InputUserDetailsPage());
                }
                catch
                {
                    await DisplayAlert("Log In Failed", "Invalid Email or Password", "Ok");
                }
            }
        }
    }
}