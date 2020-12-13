using ArtPlantMall.Models;
using ArtPlantMall.Services;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ArtPlantMall.Views.Templates
{
	public partial class ExpandedBasketItemTemplate : ContentView
	{
		public ExpandedBasketItemTemplate()
		{
			InitializeComponent();
			var ActivityID = ID.Text;

		}
		private async Task DeleteActivity(object sender, EventArgs e)
		{
			Activity act = (Activity)sender;
			var ID = act.ActivityId;
			FirebaseService _firebase = new FirebaseService();
            await _firebase.DeleteActivity(ID);
		}
	}
}
