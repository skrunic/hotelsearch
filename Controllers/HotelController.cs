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
        public IActionResult AddHotel([FromBody] Hotel newHotel)
        {
            var hotels = MockData.GetHotels();

            // Check if the hotel already exists (by name and address)
            var existingHotel = hotels.FirstOrDefault(h => h.Name == newHotel.Name && h.Address == newHotel.Address);
            if (existingHotel != null)
            {
                return BadRequest("A hotel with the same name and address already exists.");
            }

            // Assign a new unique ID to the hotel
            newHotel.ID = Guid.NewGuid();
            hotels.Add(newHotel);

            return Ok(newHotel);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateHotel(Guid id, [FromBody] Hotel updatedHotel)
        {
            var hotels = MockData.GetHotels();
            var hotel = hotels.FirstOrDefault(h => h.ID == id);

            if (hotel == null)
            {
                return NotFound("Hotel not found.");
            }

            // Update hotel properties
            hotel.Name = updatedHotel.Name;
            hotel.Price = updatedHotel.Price;
            hotel.Latitude = updatedHotel.Latitude;
            hotel.Longitude = updatedHotel.Longitude;
            hotel.Address = updatedHotel.Address;
            hotel.Email = updatedHotel.Email;

            return Ok(hotel);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteHotel(Guid id)
        {
            var hotels = MockData.GetHotels();
            var hotel = hotels.FirstOrDefault(h => h.ID == id);

            if (hotel == null)
            {
                return NotFound("Hotel not found.");
            }

            hotels.Remove(hotel);
            return NoContent();
        }


        [HttpGet("{id}")]
        public IActionResult GetHotelById(Guid id)
        {
            var hotel = MockData.GetHotels().FirstOrDefault(h => h.ID == id);
            if (hotel == null)
            {
                return NotFound("Hotel not found.");
            }
            return Ok(hotel);
        }


        [HttpGet("search")]
        public IActionResult SearchHotels(string query, double latitude, double longitude, int page = 1, int pageSize = 5)
        {
            var filteredHotels = hotels
                .Where(h => string.IsNullOrEmpty(query) || h.Name.Contains(query, StringComparison.OrdinalIgnoreCase)) // Filter by hotel name
                .Select(h => new
                {
                    Hotel = h,
                    Distance = GetDistance(latitude, longitude, h.Latitude, h.Longitude)
                })
                .OrderBy(h => h.Distance)
                .ThenBy(h => h.Hotel.Price);

            var totalResults = filteredHotels.Count();
            var totalPages = (int)Math.Ceiling((double)totalResults / pageSize);

            var pagedHotels = filteredHotels
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var response = new
            {
                Hotels = pagedHotels,
                TotalPages = totalPages
            };

            return Ok(response);
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
