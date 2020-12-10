using ArtPlantMall.Models;
using ArtPlantMall.Services;
using ArtPlantMall.ViewModel.Base;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace ArtPlantMall.ViewModel
{
    public class PlantMallViewModel : ViewModelBase
    {
        private ObservableCollection<Plant> _plants;
        private Plant _selectedPlant;
        private FirebaseService _firebase = new FirebaseService();
        public ObservableCollection<Activity> _basket;
        public decimal _total;

        public PlantMallViewModel()
        {
            LoadPlants();
        }

        public ObservableCollection<Plant> Plants
        {
            get { return _plants; }
            set
            {
                _plants = value;
                OnPropertyChanged();
            }
        }

        public Plant SelectedPlant
        {
            get { return _selectedPlant; }
            set
            {
                _selectedPlant = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Activity> Basket
        {
            get { return _basket; }
            set
            {
                _basket = value;
                OnPropertyChanged();
            }
        }

        public decimal Total
        {
            get { return _total; }
            set
            {
                _total = value;
                OnPropertyChanged();
            }
        }

        public ICommand SelectCommand => new Command(NavigateToPlantDetail);

        private async void LoadPlants()
        {
            Plants = new ObservableCollection<Plant>(PlantsService.Instance.GetPlants());
            var actualBasket = await BasketService.Instance.GetActualBasket();
            Basket = new ObservableCollection<Activity>(actualBasket);
        }

        private void NavigateToPlantDetail()
        {
            NavigationService.Instance.NavigateToAsync<PlantDetailViewModel>(SelectedPlant);
        }
    }
}