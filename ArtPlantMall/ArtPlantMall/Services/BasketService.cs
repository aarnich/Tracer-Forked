using ArtPlantMall.Models;
using System;
using System.Collections.Generic;

namespace ArtPlantMall.Services
{
    public class BasketService
    {
        public static BasketService _instance;

        public static BasketService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BasketService();

                return _instance;
            }
        }

        public List<BasketItem> GetActualBasket()
        {
            return new List<BasketItem>
            {
                new BasketItem { BasketItemType = BasketItemType.Plant, Content = "Today I marched down the hallway and spotted Josh naked. I masturbated to his fat fucking ass", Icon = "sebastian.png", Time= DateTime.Now.ToString("h tt")},
                new BasketItem { BasketItemType = BasketItemType.Plant, Content = "Today I jerked off to my teachers. This one particular teacher was extremely thicc, maybe even, too thicc", Icon = "sebastian.png", Time= DateTime.Now.ToString("h tt")},
            };
        }
    }
}