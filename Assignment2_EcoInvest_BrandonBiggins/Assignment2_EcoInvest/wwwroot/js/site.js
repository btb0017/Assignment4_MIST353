// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//Function to get Company Details
// Ensure this function is defined outside of any other function

async function getCompanyDetails(companyId) {
    try {
        console.log('Fetching details for companyID: ${companyId}');
        const response = await fetch(`http://localhost:7233/api/Company/${companyId}`);
        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }

        const data = await response.json();

        // Assuming data[0] contains the correct company information
        document.getElementById('companyName').innerHTML = data[0].companyName;

        document.getElementById('companyAddress').innerHTML = `${data[0].companyStreet}, ${data[0].companyCity}, ${data[0].companyState}, ${data[0].companyCountry}, ${data[0].companyZip}`;

        document.getElementById('companyEmail').innerHTML = data[0].companyEmail;

        const websiteElement = document.getElementById('companyWebsite');
        websiteElement.href = data[0].companyWebsite;
        websiteElement.innerHTML = data[0].companyWebsite;

        document.getElementById('companyClimateRating').innerHTML = data[0].climateRating;
    } catch (error) {
        console.error('Fetch error:', error);
    }
}

async function fetchStockData() {
    const companyId = document.getElementById('companyInfo').getAttribute('data-company-id');
    const startDate = document.getElementById('startDate').value;
    const endDate = document.getElementById('endDate').value;

    if (!startDate || !endDate) {
        alert('Please enter both start and end dates.');
        return;
    }

    try {
        const response = await fetch(`http://localhost:7233/api/StockData/${companyId}?startDate=${startDate}&endDate=${endDate}`);
        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }
        const stockData = await response.json();

        let innerHtml = `<h3>Stock Data</h3><table class="table" style="width:100%;">
                             <tr>
                               <th>Company Name</th>
                               <th>Date</th>
                               <th>Opening Price</th>
                               <th>Closing Price</th>
                               <th>High</th>
                               <th>Low</th>
                               <th>Volume</th>
                             </tr>`;

        for (let i = 0; i < stockData.length; i++) {
            innerHtml += `<tr>
                            <td>${stockData[i].companyName}</td>
                            <td>${stockData[i].dateValue.split('T')[0]}</td>
                            <td>${stockData[i].openingPrice}</td>
                            <td>${stockData[i].closingPrice}</td>
                            <td>${stockData[i].high}</td>
                            <td>${stockData[i].low}</td>
                            <td>${stockData[i].volume}</td>
                          </tr>`;
        }
        innerHtml += "</table>";
        const tableElement = document.getElementById('stockDataTable');
        tableElement.innerHTML = innerHtml;
        tableElement.style.display = 'block'; // Change from 'none' to make visible
    } catch (error) {
        console.error('Fetch error:', error);
        alert('Failed to fetch stock data.');
    }
}
