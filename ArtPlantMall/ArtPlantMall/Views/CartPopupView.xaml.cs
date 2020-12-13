using System;
using ArtPlantMall.Models;
using ArtPlantMall.Services;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace ArtPlantMall.Views
{
    public partial class CartPopupView : ContentView
    {
        public delegate void TapDelegate();

        public CartPopupView ()
		{
			InitializeComponent ();
            GoToState("Collapsed");
        }

        public int HeaderHeight { get; private set; } = 70;

        public TapDelegate OnExpandTapped { get; set; }
        public TapDelegate OnCollapseTapped { get; set; }

        private void ExpandTapped(object sender, EventArgs e)
        {
            GoToState("Expanded");
            OnExpandTapped?.Invoke();
        }

        private void CollapseTapped(object sender, EventArgs e)
        {
            GoToState("Collapsed");
            OnCollapseTapped?.Invoke();
        }
        private void GoToState(string visualState)
        {
            VisualStateManager.GoToState(BasketSummary, visualState);
            VisualStateManager.GoToState(CollapseButton, visualState);
            VisualStateManager.GoToState(ExpandButton, visualState);
        }

        private void ShowAddActivityPopUp(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new AddActivityPopPage());
        }

        private async void DeleteActivity(object sender, ItemTappedEventArgs e)
        {
            var activity = (Activity) e.Item;
            var activityId = activity.ActivityId;
            var firebase = new FirebaseService();
            await firebase.DeleteActivity(activityId);
            await App.InitNavigation();
        }
    }
}