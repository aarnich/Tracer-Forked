using ArtPlantMall.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArtPlantMall.Views
{
    public partial class ActivityHistoryView
    {
        public ActivityHistoryView()
        {
            BindingContext = new ActivityHistoryViewModel();
            InitializeComponent();
        }
    }
}