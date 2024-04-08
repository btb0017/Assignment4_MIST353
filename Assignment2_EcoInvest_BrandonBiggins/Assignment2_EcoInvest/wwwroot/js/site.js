// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//Function to get Company Details

async function getCompanyDetails(companyId) {
    const response = await fetch('http://localhost:7237/api/Company/${companyId}');
    const data = await response.json();

    //change the HTML and make visible
    document.getElementById('companyName').innerHTML = data[0].name;
    document.getElementById('companyName').style.visibility = 'visible';

    //document.getElementById('companyAddress').innerHTML = data[0].street + "," + data[0].city + "," + data[0].state + "," + data[0].country + "," + data[0].zip;
    document.getElementById('companyAddress').innerHTML = `${data[0].street}, ${data[0].city}, ${data[0].state}, ${data[0].country}, ${data[0].zip}`;
    document.getElementById('companyAddress').style.visibility = 'visible';

    document.getElementById('companyEmail').innerHTML = data[0].name;
    document.getElementById('companyEmail').style.visibility = 'visible';

    document.getElementById('companyWebsite').href = data[0].name;
    document.getElementById('companyWebsite').style.visibility = 'visible';

    document.getElementById('companyClimateRating').innerHTML = data[0].name;
    document.getElementById('companyClimateRating').style.visibility = 'visible';
}
