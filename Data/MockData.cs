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
                // North America
                new Hotel { Name = "Grand Central Hotel", Price = 250, Latitude = 40.7549, Longitude = -73.9840 }, // New York, USA
                new Hotel { Name = "Sunset Boulevard Inn", Price = 180, Latitude = 34.0983, Longitude = -118.3267 }, // Los Angeles, USA
                new Hotel { Name = "Maple Leaf Lodge", Price = 220, Latitude = 43.6532, Longitude = -79.3832 }, // Toronto, Canada
                new Hotel { Name = "Cabo Beach Resort", Price = 300, Latitude = 22.8905, Longitude = -109.9167 }, // Cabo San Lucas, Mexico
                new Hotel { Name = "Havana Seaview Hotel", Price = 150, Latitude = 23.1136, Longitude = -82.3666 }, // Havana, Cuba

                // South America
                new Hotel { Name = "Rio Luxury Suites", Price = 200, Latitude = -22.9068, Longitude = -43.1729 }, // Rio de Janeiro, Brazil
                new Hotel { Name = "Buenos Aires Plaza", Price = 180, Latitude = -34.6037, Longitude = -58.3816 }, // Buenos Aires, Argentina
                new Hotel { Name = "Lima Royal Hotel", Price = 160, Latitude = -12.0464, Longitude = -77.0428 }, // Lima, Peru
                new Hotel { Name = "Santiago Hillside Inn", Price = 170, Latitude = -33.4489, Longitude = -70.6693 }, // Santiago, Chile
                new Hotel { Name = "Bogotá Elite Hotel", Price = 150, Latitude = 4.7110, Longitude = -74.0721 }, // Bogotá, Colombia

                // Europe
                new Hotel { Name = "London Bridge Suites", Price = 300, Latitude = 51.5074, Longitude = -0.1278 }, // London, UK
                new Hotel { Name = "Parisian Elegance Hotel", Price = 280, Latitude = 48.8566, Longitude = 2.3522 }, // Paris, France
                new Hotel { Name = "Berlin Central Inn", Price = 200, Latitude = 52.5200, Longitude = 13.4050 }, // Berlin, Germany
                new Hotel { Name = "Rome Imperial Hotel", Price = 220, Latitude = 41.9028, Longitude = 12.4964 }, // Rome, Italy
                new Hotel { Name = "Athens Acropolis Hotel", Price = 180, Latitude = 37.9838, Longitude = 23.7275 }, // Athens, Greece

                // Africa
                new Hotel { Name = "Cape Town Bay Resort", Price = 250, Latitude = -33.9249, Longitude = 18.4241 }, // Cape Town, South Africa
                new Hotel { Name = "Cairo Grand Hotel", Price = 170, Latitude = 30.0444, Longitude = 31.2357 }, // Cairo, Egypt
                new Hotel { Name = "Marrakech Oasis Inn", Price = 140, Latitude = 31.6295, Longitude = -7.9811 }, // Marrakech, Morocco
                new Hotel { Name = "Nairobi Safari Lodge", Price = 160, Latitude = -1.2921, Longitude = 36.8219 }, // Nairobi, Kenya
                new Hotel { Name = "Accra Seaside Hotel", Price = 130, Latitude = 5.6037, Longitude = -0.1870 }, // Accra, Ghana

                // Asia
                new Hotel { Name = "Tokyo Skyline Hotel", Price = 300, Latitude = 35.6762, Longitude = 139.6503 }, // Tokyo, Japan
                new Hotel { Name = "Shanghai Luxury Suites", Price = 280, Latitude = 31.2304, Longitude = 121.4737 }, // Shanghai, China
                new Hotel { Name = "Bangkok Riverside Inn", Price = 160, Latitude = 13.7563, Longitude = 100.5018 }, // Bangkok, Thailand
                new Hotel { Name = "Mumbai Bay Resort", Price = 200, Latitude = 19.0760, Longitude = 72.8777 }, // Mumbai, India
                new Hotel { Name = "Seoul Sky Hotel", Price = 240, Latitude = 37.5665, Longitude = 126.9780 }, // Seoul, South Korea

                // Australia/Oceania
                new Hotel { Name = "Sydney Harbour Hotel", Price = 320, Latitude = -33.8688, Longitude = 151.2093 }, // Sydney, Australia
                new Hotel { Name = "Auckland Bay Suites", Price = 260, Latitude = -36.8485, Longitude = 174.7633 }, // Auckland, New Zealand
                new Hotel { Name = "Suva Island Resort", Price = 180, Latitude = -18.1248, Longitude = 178.4501 }, // Suva, Fiji
                new Hotel { Name = "Port Moresby Hotel", Price = 140, Latitude = -9.4438, Longitude = 147.1803 }, // Port Moresby, Papua New Guinea
                new Hotel { Name = "Nadi Beachfront Lodge", Price = 190, Latitude = -17.7764, Longitude = 177.4350 }, // Nadi, Fiji

                // Iceland Hotels
                new Hotel { Name = "Reykjavik Northern Lights Hotel", Price = 320, Latitude = 64.1466, Longitude = -21.9426 }, // Reykjavik, Iceland
                new Hotel { Name = "Blue Lagoon Spa Resort", Price = 450, Latitude = 63.8804, Longitude = -22.4495 }, // Blue Lagoon, Iceland
                new Hotel { Name = "Golden Circle Cabin", Price = 200, Latitude = 64.2559, Longitude = -20.8083 }, // Golden Circle, Iceland
            };
        }
    }
}
