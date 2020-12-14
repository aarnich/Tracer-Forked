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
                    Content = "Today I started learning xamarin! It was really fun because Xamarin is all cute and cuddly uWu",
                    Date = "December 1, 2020",
                    Time = "09:30 AM",
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
                    Content = " Wow Xamarin is so much fun! I went to WalterMart today, it was super crowded uwu",
                    Date = "December 1, 2020",
                    Time = "03:36 PM",
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
                    Content = "My mom thought I was gay, I proved her wrong by buying 5 kilos of protein shake at SnR",
                    Date = "December 2, 2020",
                    Time = "11:27 AM",
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
                    Content = "Today, I’m deleting my Furry folder, it was truly outrageous how I kept this secret up for several years.",
                    Date = "December 02, 2020",
                    Time = "2:58 PM",
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
                    Content = "I visited my cousin in Taguig",
                    Date = "December 03, 2020",
                    Time = "10:22 AM",
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
                    Content = "Cousin said I got a bit taller, my build also got better, apparently >///<",
                    Date = "December 03, 2020",
                    Time = "11:34 AM",
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
                    Content = "This Xamarin thing really seems to hate me… Good thing I hate it too. I downloaded some more vore though.",
                    Date = "December 04, 2020",
                    Time = "1:03 PM",
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
                    Content = "Man, NuGET Packages are ASS, so I deleted all of them.",
                    Date = "December 04, 2020",
                    Time = "3:43 PM",
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
                    Content = "Went out to Walmart for eggs.",
                    Date = "December 04, 2020",
                    Time = "5:07 PM",
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
                    Content = "Cooked the eggs.",
                    Date = "December 04, 2020",
                    Time = "5:49 PM",
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
                    Content = "Went to Manila Bay for the view! The quarantine is a myth, CoVID is an even bigger one.",
                    Date = "December 05, 2020",
                    Time = "9:43 AM",
                    LocationSafety = new List<LocationSafety>
                    {
                        new LocationSafety
                        {
                            Name = "Dangerous",
                            BGColor = ColorConverters.FromHex("#fefbec"),
                            TxColor = ColorConverters.FromHex("#fcd058")
                        }
                    }
                }
            };

        }
    }
}
