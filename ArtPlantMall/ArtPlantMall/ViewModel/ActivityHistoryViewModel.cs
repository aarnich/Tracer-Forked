using ArtPlantMall.Models;
using ArtPlantMall.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Essentials;

namespace ArtPlantMall.ViewModel
{
    public class ActivityHistoryViewModel
    {
        public ObservableCollection<ActivityHistoryItem> history { get; set; }
        public ActivityHistoryViewModel()
        {
            history = new ObservableCollection<ActivityHistoryItem>
            {
                new ActivityHistoryItem
                {
                    Content = "I walked down onto WalterMart and masturbated all day",
                    Date = "November 19, 2002",
                    Time = "08:30 AM",
                    LocationSafety = new List<LocationSafety>
                    {
                        new LocationSafety
                        {
                            Name = "Unsafe",
                            BGColor = ColorConverters.FromHex("#f0fbf3"),
                            TxColor = ColorConverters.FromHex("#74d884")
                        }
                    }
                },
                new ActivityHistoryItem
                {
                    Content = "I walked down onto WalterMart and masturbated all day",
                    Date = "November 19, 2002",
                    Time = "08:30 AM",
                    LocationSafety = new List<LocationSafety>
                    {
                        new LocationSafety
                        {
                            Name = "Dangerous",
                            BGColor = ColorConverters.FromHex("#fefbec"),
                            TxColor = ColorConverters.FromHex("#fcd058")
                        }
                    }
                },
                new ActivityHistoryItem
                {
                    Content = "I walked down onto WalterMart and masturbated all day",
                    Date = "November 19, 2002",
                    Time = "08:30 AM",
                    LocationSafety = new List<LocationSafety>
                    {
                        new LocationSafety
                        {
                            Name = "Safe",
                            BGColor = ColorConverters.FromHex("#fceeeb"),
                            TxColor = ColorConverters.FromHex("#fe4134")
                        }
                    }
                },
                new ActivityHistoryItem
                {
                    Content = "I walked down onto WalterMart and masturbated all day",
                    Date = "November 19, 2002",
                    Time = "08:30 AM",
                    LocationSafety = new List<LocationSafety>
                    {
                        new LocationSafety
                        {
                            Name = "Unknown",
                            BGColor = ColorConverters.FromHex("#fefbec"),
                            TxColor = ColorConverters.FromHex("#fcd058")
                        }
                    }
                },
                new ActivityHistoryItem
                {
                    Content = "I walked down onto WalterMart and masturbated all day",
                    Date = "November 19, 2002",
                    Time = "08:30 AM",
                    LocationSafety = new List<LocationSafety>
                    {
                        new LocationSafety
                        {
                            Name = "Safe",
                            BGColor = ColorConverters.FromHex("#fceeeb"),
                            TxColor = ColorConverters.FromHex("#fe4134")
                        }
                    }
                }

            };

        }
    }
}
