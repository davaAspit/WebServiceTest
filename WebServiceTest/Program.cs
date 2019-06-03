using System;
using System.Net;
using WebServiceTest.Entities;
using WebServiceTest.Services;

namespace WebServiceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BookingService bService = new BookingService()
            {
                Url = "https://api.aspitcloud.dk/bookings"
            };
            var data = bService.GetAllData();

            foreach (var b in data)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("Hent en booking:");
            Booking booking = bService.GetBooking(4);
            Console.WriteLine(booking);
        }
    }
}
