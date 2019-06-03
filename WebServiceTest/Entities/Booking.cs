using System;
using System.Collections.Generic;
using System.Text;

namespace WebServiceTest.Entities
{
    class Booking
    {
        public int BookingId { get; set; }
        public DateTime BookingTime { get; set; }
        public int CourtNumber { get; set; }
        public string Booker { get; set; }

        public override string ToString()
        {
            return $"Bane {CourtNumber} booket d. {BookingTime.ToShortDateString()} kl. {BookingTime.Hour} af {Booker}";
        }
    }
}
