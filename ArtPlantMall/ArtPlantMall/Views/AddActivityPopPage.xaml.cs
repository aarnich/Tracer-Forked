using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtPlantMall.Services;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArtPlantMall.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddActivityPopPage
    {
        public AddActivityPopPage()
        {
            InitializeComponent();
            CmbLocations.ItemsSource = _locationsList;
            CmbLocations.SelectedIndex = 0;
        }
        
        private FirebaseService _firebase = new FirebaseService();
        private readonly List<string> _locationsList = new List<string>(){"Makati", "BGC", "Glorietta"};

        private async void AddToDatabase(object sender, EventArgs e)
        {
            var content = TxtContent.Text;
            var date = DprDoa.Date.ToString("d");
            var time = TprToa.Time.ToString();
            var location = CmbLocations.SelectedItem.ToString();

            await _firebase.AddActivity(content, StartAppView.Email, date, time, location);
            await PopupNavigation.Instance.PopAsync();
            await App.InitNavigation();
        }
    }
}