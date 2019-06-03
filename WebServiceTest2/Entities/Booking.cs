using System;
using System.Collections.Generic;
using System.Text;

namespace WebServiceTest2.Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public int CourtNumber { get; set; }
        public DateTime BookingTime { get; set; }
        public string Booker { get; set; }
    }
}
