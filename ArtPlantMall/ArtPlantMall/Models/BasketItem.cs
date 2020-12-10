namespace ArtPlantMall.Models
{
    public enum BasketItemType
    {
        Plant,
        Delivery
    }

    public class BasketItem
    {
        public BasketItemType BasketItemType { get; set; }
        public int Counter { get; set; }
        public string Content { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Location { get; set; }
        public string Icon { get; set; }
        public string UserID { get; set; }
    }
}