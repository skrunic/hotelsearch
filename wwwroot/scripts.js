// Mock hotel data
const hotels = [
    // North America
    { name: 'Grand Central Hotel', price: 250, latitude: 40.7549, longitude: -73.9840 }, // New York, USA
    { name: 'Sunset Boulevard Inn', price: 180, latitude: 34.0983, longitude: -118.3267 }, // Los Angeles, USA
    { name: 'Maple Leaf Lodge', price: 220, latitude: 43.6532, longitude: -79.3832 }, // Toronto, Canada
    { name: 'Cabo Beach Resort', price: 300, latitude: 22.8905, longitude: -109.9167 }, // Cabo San Lucas, Mexico
    { name: 'Havana Seaview Hotel', price: 150, latitude: 23.1136, longitude: -82.3666 }, // Havana, Cuba

    // South America
    { name: 'Rio Luxury Suites', price: 200, latitude: -22.9068, longitude: -43.1729 }, // Rio de Janeiro, Brazil
    { name: 'Buenos Aires Plaza', price: 180, latitude: -34.6037, longitude: -58.3816 }, // Buenos Aires, Argentina
    { name: 'Lima Royal Hotel', price: 160, latitude: -12.0464, longitude: -77.0428 }, // Lima, Peru
    { name: 'Santiago Hillside Inn', price: 170, latitude: -33.4489, longitude: -70.6693 }, // Santiago, Chile
    { name: 'Bogotá Elite Hotel', price: 150, latitude: 4.7110, longitude: -74.0721 }, // Bogotá, Colombia

    // Europe
    { name: 'London Bridge Suites', price: 300, latitude: 51.5074, longitude: -0.1278 }, // London, UK
    { name: 'Parisian Elegance Hotel', price: 280, latitude: 48.8566, longitude: 2.3522 }, // Paris, France
    { name: 'Berlin Central Inn', price: 200, latitude: 52.5200, longitude: 13.4050 }, // Berlin, Germany
    { name: 'Rome Imperial Hotel', price: 220, latitude: 41.9028, longitude: 12.4964 }, // Rome, Italy
    { name: 'Athens Acropolis Hotel', price: 180, latitude: 37.9838, longitude: 23.7275 }, // Athens, Greece

    // Africa
    { name: 'Cape Town Bay Resort', price: 250, latitude: -33.9249, longitude: 18.4241 }, // Cape Town, South Africa
    { name: 'Cairo Grand Hotel', price: 170, latitude: 30.0444, longitude: 31.2357 }, // Cairo, Egypt
    { name: 'Marrakech Oasis Inn', price: 140, latitude: 31.6295, longitude: -7.9811 }, // Marrakech, Morocco
    { name: 'Nairobi Safari Lodge', price: 160, latitude: -1.2921, longitude: 36.8219 }, // Nairobi, Kenya
    { name: 'Accra Seaside Hotel', price: 130, latitude: 5.6037, longitude: -0.1870 }, // Accra, Ghana

    // Asia
    { name: 'Tokyo Skyline Hotel', price: 300, latitude: 35.6762, longitude: 139.6503 }, // Tokyo, Japan
    { name: 'Shanghai Luxury Suites', price: 280, latitude: 31.2304, longitude: 121.4737 }, // Shanghai, China
    { name: 'Bangkok Riverside Inn', price: 160, latitude: 13.7563, longitude: 100.5018 }, // Bangkok, Thailand
    { name: 'Mumbai Bay Resort', price: 200, latitude: 19.0760, longitude: 72.8777 }, // Mumbai, India
    { name: 'Seoul Sky Hotel', price: 240, latitude: 37.5665, longitude: 126.9780 }, // Seoul, South Korea

    // Australia/Oceania
    { name: 'Sydney Harbour Hotel', price: 320, latitude: -33.8688, longitude: 151.2093 }, // Sydney, Australia
    { name: 'Auckland Bay Suites', price: 260, latitude: -36.8485, longitude: 174.7633 }, // Auckland, New Zealand
    { name: 'Suva Island Resort', price: 180, latitude: -18.1248, longitude: 178.4501 }, // Suva, Fiji
    { name: 'Port Moresby Hotel', price: 140, latitude: -9.4438, longitude: 147.1803 }, // Port Moresby, Papua New Guinea
    { name: 'Nadi Beachfront Lodge', price: 190, latitude: -17.7764, longitude: 177.4350 }, // Nadi, Fiji

    // Iceland Hotels
    { name: 'Reykjavik Northern Lights Hotel', price: 320, latitude: 64.1466, longitude: -21.9426 }, // Reykjavik, Iceland
    { name: 'Blue Lagoon Spa Resort', price: 450, latitude: 63.8804, longitude: -22.4495 }, // Blue Lagoon, Iceland
    { name: 'Golden Circle Cabin', price: 200, latitude: 64.2559, longitude: -20.8083 }, // Golden Circle, Iceland
];

// Function to render hotels
function renderHotels(hotels) {
    const hotelList = document.getElementById('hotel-list');
    hotelList.innerHTML = ''; // Clear previous results

    if (hotels.length === 0) {
        hotelList.innerHTML = '<div class="alert alert-warning" role="alert">No hotels found to match the search string!</div>';
        return;
    }

    hotels.forEach(hotel => {
        const hotelItem = document.createElement('div');
        hotelItem.classList.add('hotel-item');
        hotelItem.innerHTML = `
            <div class="d-flex justify-content-between align-items-center">
                <span><i class="bi bi-house-fill"></i> ${hotel.name}</span>
                <span><i class="bi bi-cash-stack"></i> Price: $${hotel.price}</span>
                <span><i class="bi bi-geo-alt-fill"></i> Distance: ${hotel.latitude.toFixed(2)}°, ${hotel.longitude.toFixed(2)}°</span>
            </div>
        `;
        hotelList.appendChild(hotelItem);
    });
}

// Search functionality
document.getElementById('search-input').addEventListener('input', function () {
    const query = this.value.toLowerCase();
    const hotelList = document.getElementById('hotel-list');

    // Trigger search only when the input is at least 3 characters long
    if (query.length >= 3) {
        const filteredHotels = hotels.filter(hotel => hotel.name.toLowerCase().includes(query));
        renderHotels(filteredHotels);
        hotelList.style.display = 'block';  // Show hotel list
    } else {
        hotelList.style.display = 'none';  // Hide hotel list if less than 3 characters
    }
});

// Initially hide hotel list
document.getElementById('hotel-list').style.display = 'none';
