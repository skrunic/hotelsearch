using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_HotelSearch.Models
{
    public class Hotel
    {
        public Guid ID { get; set; } // Unique ID for each hotel
        public string Name { get; set; }
        public double Price { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Address { get; set; } // Physical address
        public string Email { get; set; } // Contact email
    }
}
