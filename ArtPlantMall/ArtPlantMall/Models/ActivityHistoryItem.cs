using System.Collections.Generic;

namespace ArtPlantMall.Models
{

    public class ActivityHistoryItem
    {
        public string Content { get; set; } = "";
        public string Date { get; set; } = "";
        public string Time { get; set; } = "";
        public List<LocationSafety> LocationSafety { get; set; }

    }
}