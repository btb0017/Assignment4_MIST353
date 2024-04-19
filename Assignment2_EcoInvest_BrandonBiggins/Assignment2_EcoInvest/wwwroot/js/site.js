// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//Function to get Company Details
// Ensure this function is defined outside of any other function

async function getCompanyDetails(companyId) {
    try {
        const response = await fetch(`https://localhost:7233/api/Company/${companyId}`);
        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }
        const data = await response.json();

        if (data.length > 0) {
            const companyInfo = data[0];
            document.getElementById('companyName').textContent = companyInfo.companyName;
            document.getElementById('companyAddress').textContent = `${companyInfo.companyStreet}, ${companyInfo.companyCity}, ${companyInfo.companyState}, ${companyInfo.companyCountry}, ${companyInfo.companyZip}`;
            document.getElementById('companyEmail').textContent = companyInfo.companyEmail;
            const websiteElement = document.getElementById('companyWebsite');
            websiteElement.href = companyInfo.companyWebsite;
            websiteElement.textContent = companyInfo.companyWebsite;
            document.getElementById('companyClimateRating').textContent = companyInfo.companyClimateRating;
        }
    } catch (error) {
        console.error('Fetch error:', error);
        alert('Failed to load company details.');
    }
}

async function fetchStockData(companyId, startDate, endDate) {

    if (!companyIdElement || !startDate || !endDate) {
        //alert('Please enter all required fields correctly.');
        return;
    }

    const companyIdElement = companyIdElement.textContent;
    const response = await fetch(`https://localhost:7233/api/StockData/${companyId}?startDate=${startDate}&endDate=${endDate}`);
    const stockData = await response.json();
    let innerHtml = '<h3>Stock Data</h3><table class="table"><tr><th>Company Name</th><th>Date</th><th>Opening Price</th><th>Closing Price</th><th>High</th><th>Low</th><th>Volume</th></tr>';
    for (let i = 0; i < stockData.length; i++) {
        innerHtml += `<tr><td>${stockData[i].companyName}</td><td>${stockData[i].dateValue.split('T')[0]}</td><td>${stockData[i].openingPrice}</td><td>${stockData[i].closingPrice}</td><td>${stockData[i].high}</td><td>${stockData[i].low}</td><td>${stockData[i].volume}</td></tr>`;
    }
    innerHtml += "</table>";
    document.getElementById('stockDataTable').innerHTML = innerHtml;
    document.getElementById('stockDataTable').style.display = 'block';
}

