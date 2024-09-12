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
                new Hotel { ID = Guid.NewGuid(), Name = "Grand Central Hotel", Price = 250, Latitude = 40.7549, Longitude = -73.9840, Address = "New York, USA", Email = "info@grandcentral.com" },
                new Hotel { ID = Guid.NewGuid(), Name = "Sunset Boulevard Inn", Price = 180, Latitude = 34.0983, Longitude = -118.3267, Address = "Los Angeles, USA", Email = "contact@sunsetinn.com" },
                new Hotel { ID = Guid.NewGuid(), Name = "Maple Leaf Lodge", Price = 220, Latitude = 43.6532, Longitude = -79.3832, Address = "Toronto, Canada", Email = "reservations@mapleleaflodge.ca" },
                new Hotel { ID = Guid.NewGuid(), Name = "Cabo Beach Resort", Price = 300, Latitude = 22.8905, Longitude = -109.9167, Address = "Cabo San Lucas, Mexico", Email = "info@cabobeach.com" },
                new Hotel { ID = Guid.NewGuid(), Name = "Havana Seaview Hotel", Price = 150, Latitude = 23.1136, Longitude = -82.3666, Address = "Havana, Cuba", Email = "contact@havanaseaview.com" },

                // South America
                new Hotel { ID = Guid.NewGuid(), Name = "Rio Luxury Suites", Price = 200, Latitude = -22.9068, Longitude = -43.1729, Address = "Rio de Janeiro, Brazil", Email = "info@rioluxurysuites.com" },
                new Hotel { ID = Guid.NewGuid(), Name = "Buenos Aires Plaza", Price = 180, Latitude = -34.6037, Longitude = -58.3816, Address = "Buenos Aires, Argentina", Email = "reservations@baplaza.com" },
                new Hotel { ID = Guid.NewGuid(), Name = "Lima Royal Hotel", Price = 160, Latitude = -12.0464, Longitude = -77.0428, Address = "Lima, Peru", Email = "info@limaroyalhotel.com" },
                new Hotel { ID = Guid.NewGuid(), Name = "Santiago Hillside Inn", Price = 170, Latitude = -33.4489, Longitude = -70.6693, Address = "Santiago, Chile", Email = "contact@santiagohillsideinn.com" },
                new Hotel { ID = Guid.NewGuid(), Name = "Bogotá Elite Hotel", Price = 150, Latitude = 4.7110, Longitude = -74.0721, Address = "Bogotá, Colombia", Email = "elite@bogota.com" },

                // Europe
                new Hotel { ID = Guid.NewGuid(), Name = "London Bridge Suites", Price = 300, Latitude = 51.5074, Longitude = -0.1278, Address = "London, UK", Email = "info@londonbridgesuites.co.uk" },
                new Hotel { ID = Guid.NewGuid(), Name = "Parisian Elegance Hotel", Price = 280, Latitude = 48.8566, Longitude = 2.3522, Address = "Paris, France", Email = "contact@parisianelegance.fr" },
                new Hotel { ID = Guid.NewGuid(), Name = "Berlin Central Inn", Price = 200, Latitude = 52.5200, Longitude = 13.4050, Address = "Berlin, Germany", Email = "reservations@berlinncentralinn.de" },
                new Hotel { ID = Guid.NewGuid(), Name = "Rome Imperial Hotel", Price = 220, Latitude = 41.9028, Longitude = 12.4964, Address = "Rome, Italy", Email = "info@romeimperial.it" },
                new Hotel { ID = Guid.NewGuid(), Name = "Athens Acropolis Hotel", Price = 180, Latitude = 37.9838, Longitude = 23.7275, Address = "Athens, Greece", Email = "contact@acropolishotel.gr" },

                // Africa
                new Hotel { ID = Guid.NewGuid(), Name = "Cape Town Bay Resort", Price = 250, Latitude = -33.9249, Longitude = 18.4241, Address = "Cape Town, South Africa", Email = "info@capetownbay.co.za" },
                new Hotel { ID = Guid.NewGuid(), Name = "Cairo Grand Hotel", Price = 170, Latitude = 30.0444, Longitude = 31.2357, Address = "Cairo, Egypt", Email = "reservations@cairogrand.com" },
                new Hotel { ID = Guid.NewGuid(), Name = "Marrakech Oasis Inn", Price = 140, Latitude = 31.6295, Longitude = -7.9811, Address = "Marrakech, Morocco", Email = "info@marrakechoasis.com" },
                new Hotel { ID = Guid.NewGuid(), Name = "Nairobi Safari Lodge", Price = 160, Latitude = -1.2921, Longitude = 36.8219, Address = "Nairobi, Kenya", Email = "contact@safarilodge.co.ke" },
                new Hotel { ID = Guid.NewGuid(), Name = "Accra Seaside Hotel", Price = 130, Latitude = 5.6037, Longitude = -0.1870, Address = "Accra, Ghana", Email = "reservations@accraseaside.com" },

                // Asia
                new Hotel { ID = Guid.NewGuid(), Name = "Tokyo Skyline Hotel", Price = 300, Latitude = 35.6762, Longitude = 139.6503, Address = "Tokyo, Japan", Email = "info@tokyoskyline.jp" },
                new Hotel { ID = Guid.NewGuid(), Name = "Shanghai Luxury Suites", Price = 280, Latitude = 31.2304, Longitude = 121.4737, Address = "Shanghai, China", Email = "luxury@shanghaisuites.cn" },
                new Hotel { ID = Guid.NewGuid(), Name = "Bangkok Riverside Inn", Price = 160, Latitude = 13.7563, Longitude = 100.5018, Address = "Bangkok, Thailand", Email = "riverside@bangkokinn.co.th" },
                new Hotel { ID = Guid.NewGuid(), Name = "Mumbai Bay Resort", Price = 200, Latitude = 19.0760, Longitude = 72.8777, Address = "Mumbai, India", Email = "info@mumbaibayresort.in" },
                new Hotel { ID = Guid.NewGuid(), Name = "Seoul Sky Hotel", Price = 240, Latitude = 37.5665, Longitude = 126.9780, Address = "Seoul, South Korea", Email = "reservations@seoulskyhotel.kr" },

                // Australia/Oceania
                new Hotel { ID = Guid.NewGuid(), Name = "Sydney Harbour Hotel", Price = 320, Latitude = -33.8688, Longitude = 151.2093, Address = "Sydney, Australia", Email = "info@sydneyharbour.com.au" },
                new Hotel { ID = Guid.NewGuid(), Name = "Auckland Bay Suites", Price = 260, Latitude = -36.8485, Longitude = 174.7633, Address = "Auckland, New Zealand", Email = "reservations@aucklandbay.co.nz" },
                new Hotel { ID = Guid.NewGuid(), Name = "Suva Island Resort", Price = 180, Latitude = -18.1248, Longitude = 178.4501, Address = "Suva, Fiji", Email = "contact@suvaisland.com" },
                new Hotel { ID = Guid.NewGuid(), Name = "Port Moresby Hotel", Price = 140, Latitude = -9.4438, Longitude = 147.1803, Address = "Port Moresby, Papua New Guinea", Email = "info@portmoresbyhotel.pg" },
                new Hotel { ID = Guid.NewGuid(), Name = "Nadi Beachfront Lodge", Price = 190, Latitude = -17.7764, Longitude = 177.4350, Address = "Nadi, Fiji", Email = "info@nadibeachfront.com" },

                // Iceland
                new Hotel { ID = Guid.NewGuid(), Name = "Reykjavik Northern Lights Hotel", Price = 320, Latitude = 64.1466, Longitude = -21.9426, Address = "Reykjavik, Iceland", Email = "info@northernlights.is" },
                new Hotel { ID = Guid.NewGuid(), Name = "Blue Lagoon Spa Resort", Price = 450, Latitude = 63.8804, Longitude = -22.4495, Address = "Blue Lagoon, Iceland", Email = "contact@bluelagoon.is" },
                new Hotel { ID = Guid.NewGuid(), Name = "Golden Circle Cabin", Price = 200, Latitude = 64.2559, Longitude = -20.8083, Address = "Golden Circle, Iceland", Email = "reservations@goldencircle.is" },

            };
        }
    }
}
