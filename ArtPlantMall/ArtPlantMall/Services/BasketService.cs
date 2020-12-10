using ArtPlantMall.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ArtPlantMall.Services
{
    public class BasketService
    {
        private static BasketService _instance;
        private FirebaseService _firebase = new FirebaseService();

        public static BasketService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BasketService();

                return _instance;
            }
        }

        public async Task<List<Activity>> GetActualBasket()
        {
            return await _firebase.GetAllCurrentUserActivity();
        }
    }
}