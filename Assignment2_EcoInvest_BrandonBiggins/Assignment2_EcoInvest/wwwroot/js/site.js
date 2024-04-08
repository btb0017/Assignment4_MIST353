// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//Function to get Company Details
// Ensure this function is defined outside of any other function
document.addEventListener("DOMContentLoaded", function () {
    const companyIdElement = document.getElementById('companyInfo'); // Assuming you have this element with a data attribute
    const companyId = companyIdElement ? companyIdElement.getAttribute('data-company-id') : null;
    if (companyId) {
        getCompanyDetails(companyId);
    }
});

async function getCompanyDetails(companyId) {
    console.log('Fetching details for companyID: ${companyId}');
    const response = await fetch(`http://localhost:7233/api/Company/${companyId}`);
    const data = await response.json();

    // Assuming data[0] contains the correct company information
    document.getElementById('companyName').innerHTML = data[0].companyName;

    document.getElementById('companyAddress').innerHTML = `${data[0].companyStreet}, ${data[0].companyCity}, ${data[0].companyState}, ${data[0].companyCountry}, ${data[0].companyZip}`;

    document.getElementById('companyEmail').innerHTML = data[0].companyEmail;

    const websiteElement = document.getElementById('companyWebsite');
    websiteElement.href = data[0].companyWebsite; 
    websiteElement.innerHTML = data[0].companyWebsite;

    document.getElementById('companyClimateRating').innerHTML = data[0].climateRating;
}