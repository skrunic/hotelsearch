let currentPage = 1;
let totalPages = 1;
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
    }
}

// Function to render hotels
function renderHotels(hotels) {
    const hotelList = document.getElementById('hotel-list');
    hotelList.innerHTML = ''; // Clear previous results
    hotelList.style.display = 'block';

    if (hotels.length === 0) {
        hotelList.innerHTML = '<div class="alert alert-warning" role="alert">No hotels found to match the search string!</div>';
        return;
    }

    hotels.forEach(h => {
        const hotelItem = document.createElement('div');
        hotelItem.classList.add('hotel-item');
        hotelItem.innerHTML = `
            <div class="d-flex justify-content-between align-items-center">
                <span><i class="bi bi-house-fill"></i> ${h.hotel.name}</span>
                <span><i class="bi bi-cash-stack"></i> Price: $${h.hotel.price}</span>
                <span><i class="bi bi-geo-alt-fill"></i> Distance: ${h.distance.toFixed(2)} km</span>
            </div>
        `;
        hotelList.appendChild(hotelItem);
    });
}

// Function to render paging controls
function renderPagingControls() {
    const pagingControls = document.getElementById('paging-controls');
    pagingControls.innerHTML = ''; // Clear previous paging controls

    for (let i = 1; i <= totalPages; i++) {
        const pageItem = document.createElement('button');
        pageItem.classList.add('btn', 'btn-outline-primary', 'm-1');

        pageItem.textContent = i;

        if (i === currentPage) {
            pageItem.classList.remove('btn-outline-primary');
            pageItem.classList.add('btn-primary');
        }

        pageItem.addEventListener('click', function () {
            currentPage = i;
            fetchHotels(document.getElementById('search-input').value);
        });

        pagingControls.appendChild(pageItem);
    }
}


// Function to fetch hotels from the backend API
function fetchHotels(query) {
    // Make sure latitude and longitude are available
    if (userLatitude === null || userLongitude === null) {
        alert('Location data is not available.');
        return;
    }

    const apiUrl = `/api/hotel/search?query=${encodeURIComponent(query)}&latitude=${userLatitude}&longitude=${userLongitude}&page=${currentPage}&pageSize=5`;

    fetch(apiUrl)
        .then(response => response.json())
        .then(data => {
            renderHotels(data.hotels);
            totalPages = data.totalPages;
            renderPagingControls();
        })
        .catch(error => {
            console.error('Error fetching hotels:', error);
        });
}

// Search functionality
document.getElementById('search-input').addEventListener('input', function () {
    const query = this.value.toLowerCase();

    // Trigger search only when the input is at least 3 characters long
    if (query.length >= 3) {
        currentPage = 1; // Reset to page 1 whenever a new search is made
        fetchHotels(query);
    } else {
        document.getElementById('hotel-list').style.display = 'none';  // Hide hotel list if less than 3 characters
    }
});

// Call the function to get the location on page load
getLocation();
