using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtPlantMall.Models;
using ArtPlantMall.Views;
using Firebase.Database;
using Firebase.Database.Query;

namespace ArtPlantMall.Services
{
    class FirebaseService
    {
        private FirebaseClient _firebase;

        public FirebaseService()
        {
            _firebase = new FirebaseClient("https://traceblazer.firebaseio.com/");
        }

        public async Task AddPerson(string username, string email, string firstName, string lastName, string address, string occupation,
            string dateOfBirth)
        {
            await _firebase.Child("userdetails").PostAsync(new UserDetails()
            {
                Username = username,
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                Occupation = occupation,
                DateOfBirth = dateOfBirth,
                Email = email
            });
        }

        public async Task AddActivity(string content, string email, string time, string location)
        {
            await _firebase.Child("activitydetails").PostAsync(new Activity()
            {
                Content = content,
                UserId = email,
                Time = time,
                Location = location,
                Icon = "sebastian.png"
            });
        }

        public async Task<List<Activity>> GetAllCurrentUserActivity()
        {
            var listActivity = (await _firebase.Child("activitydetails").OnceAsync<Activity>()).Select(item =>
                new Activity
                {
                    ActivityId = item.Key,
                    Content = item.Object.Content,
                    UserId = item.Object.UserId,
                    Date = item.Object.Date,
                    Time = item.Object.Time,
                    Location = item.Object.Location,
                    Icon = item.Object.Icon
                });
            return listActivity.Where(item => item.UserId == StartAppView.Email).ToList();
        }

        public async Task DeleteActivity(string activityId)
        {
            var deleteActivity = (await _firebase.Child("activitydetails").OnceAsync<Activity>()).FirstOrDefault(a => a.Key == activityId);
            await _firebase.Child("activitydetails").Child(deleteActivity.Key).DeleteAsync();
        }
    }
}
