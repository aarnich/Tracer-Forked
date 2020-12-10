using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtPlantMall.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArtPlantMall.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InputUserDetailsPage : ContentPage
    {
        public InputUserDetailsPage()
        {
            InitializeComponent();
        }

        private async void AddUserDetails(object sender, EventArgs e)
        {
            var username = TxtUName.Text;
            var email = StartAppView.Email;
            var firstName = TxtFName.Text;
            var lastName = TxtLName.Text;
            var address = TxtAddress.Text;
            var occupation = TxtOccupation.Text;
            var dateOfBirth = DprBirthDate.Date.ToString("d");
            var firebase = new FirebaseService();
            await firebase.AddPerson(username, email, firstName, lastName, address, occupation, dateOfBirth);
            Application.Current.MainPage = new NavigationPage(new PlantMallView());
            await App.InitNavigation();
        }
    }
}