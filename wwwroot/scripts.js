let userLatitude = null;
let userLongitude = null;

// Function to get the user's current location
function getLocation() {
    const latDisplay = document.getElementById('lat-display');
    const lonDisplay = document.getElementById('lon-display');

    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(success, error);
    } else {
        latDisplay.textContent = 'Geolocation is not supported by your browser.';
        lonDisplay.textContent = '';
    }

    function success(position) {
        userLatitude = position.coords.latitude;
        userLongitude = position.coords.longitude;

        latDisplay.textContent = `Current latitude: ${userLatitude.toFixed(4)}, ${userLongitude.toFixed(4)}`;
    }

    function error() {
        latDisplay.textContent = 'Unable to retrieve your location.';
        lonDisplay.textContent = '';
    }
}

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
