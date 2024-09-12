using Demo_HotelSearch.Data;
using Demo_HotelSearch.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_HotelSearch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private List<Hotel> hotels = MockData.GetHotels();

        [HttpGet]
        public IActionResult GetAllHotels()
        {
            return Ok(hotels);
        }

        [HttpPost]
        public IActionResult AddHotel([FromBody] Hotel hotel)
        {
            hotels.Add(hotel);
            return Ok(hotel);
        }

        [HttpGet("search")]
        public IActionResult SearchHotels(double latitude, double longitude, int page = 1, int pageSize = 10)
        {
            var hotelsWithDistance = hotels.Select(h => new
            {
                Hotel = h,
                Distance = GetDistance(latitude, longitude, h.Latitude, h.Longitude)
            })
            .OrderBy(h => h.Distance).ThenBy(h => h.Hotel.Price)
            .Skip((page - 1) * pageSize).Take(pageSize).ToList();

            return Ok(hotelsWithDistance);
        }

        private double GetDistance(double lat1, double lon1, double lat2, double lon2)
        {
            // Haversine formula to calculate distance between two lat/long points
            var R = 6371; // Radius of Earth in km
            var dLat = (lat2 - lat1) * (System.Math.PI / 180);
            var dLon = (lon2 - lon1) * (System.Math.PI / 180);
            var a =
                System.Math.Sin(dLat / 2) * System.Math.Sin(dLat / 2) +
                System.Math.Cos(lat1 * (System.Math.PI / 180)) * System.Math.Cos(lat2 * (System.Math.PI / 180)) *
                System.Math.Sin(dLon / 2) * System.Math.Sin(dLon / 2);
            var c = 2 * System.Math.Atan2(System.Math.Sqrt(a), System.Math.Sqrt(1 - a));
            return R * c;
        }
    }
}
