using System;
using System.Net;
using System.Collections.Generic;
using System.Text;
using WebServiceTest.Entities;
using Newtonsoft.Json;

namespace WebServiceTest.Services
{
    class BookingService
    {
        public string Url { get; set; }

        public List<Booking> GetAllData()
        {
            if (!string.IsNullOrWhiteSpace(Url))
            {
                using (var client = new WebClient())
                {
                    string json = client.DownloadString(Url);
                    List<Booking> bookings = JsonConvert.DeserializeObject<List<Booking>>(json);
                    return bookings;
                } 
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
        
        public Booking GetBooking(int id)
        {
            string json = "";
            using (WebClient client = new WebClient())
            {
                json = client.DownloadString(Url+"/"+id);
            }
            Booking booking = JsonConvert.DeserializeObject<Booking>(json);

            return booking;
        }
    }
}
