using Demo_HotelSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_HotelSearch.Data
{
    public static class MockData
    {
        public static List<Hotel> GetHotels()
        {
            return new List<Hotel>
            {
                new Hotel { Name = "Hotel 1", Price = 150, Latitude = 45.8150, Longitude = 15.9819 },
                new Hotel { Name = "Hotel 2", Price = 120, Latitude = 45.8151, Longitude = 15.9820 },
                new Hotel { Name = "Hotel 3", Price = 200, Latitude = 45.8152, Longitude = 15.9830 }
            };
        }
    }
}
