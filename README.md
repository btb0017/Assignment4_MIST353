# Assignment4_MIST353

## Six Pages

### Information.cshtml

For the Information webpage, we will be implementing a search bar that utilizes one of our SP APIs. A user will be able to search for a specific company on this page and see that specific company with some information on the company. The user can then click on the company name and get access to a more detailed page for that company and see more information for climate and stock data.

### AppleInfo.cshtml

For this page, we plan to implement multiple SP APIs. We plan to have a way for the user to selected a date or date range and get stock and climate data for the company for the specified range. We also plan to use another SP API to generate the company information at the top of the webpage when the user first clicks on the link to the page. We plan to put the data into tables and potentially graphs if we have enough time to implement this. Also we might add an interactive map that shows a heatmap of temperature over the time period if we have enough time to implement this.

### AmazonInfo.cshtml

For this page, we plan to implement multiple SP APIs. We plan to have a way for the user to selected a date or date range and get stock and climate data for the company for the specified range. We also plan to use another SP API to generate the company information at the top of the webpage when the user first clicks on the link to the page. We plan to put the data into tables and potentially graphs if we have enough time to implement this. Also we might add an interactive map that shows a heatmap of temperature over the time period if we have enough time to implement this.

### GoogleInfo.cshtml

For this page, we plan to implement multiple SP APIs. We plan to have a way for the user to selected a date or date range and get stock and climate data for the company for the specified range. We also plan to use another SP API to generate the company information at the top of the webpage when the user first clicks on the link to the page. We plan to put the data into tables and potentially graphs if we have enough time to implement this. Also we might add an interactive map that shows a heatmap of temperature over the time period if we have enough time to implement this.

### NvidiaInfo.cshtml

For this page, we plan to implement multiple SP APIs. We plan to have a way for the user to selected a date or date range and get stock and climate data for the company for the specified range. We also plan to use another SP API to generate the company information at the top of the webpage when the user first clicks on the link to the page. We plan to put the data into tables and potentially graphs if we have enough time to implement this. Also we might add an interactive map that shows a heatmap of temperature over the time period if we have enough time to implement this.

### TeslaInfo.cshtml

For this page, we plan to implement multiple SP APIs. We plan to have a way for the user to selected a date or date range and get stock and climate data for the company for the specified range. We also plan to use another SP API to generate the company information at the top of the webpage when the user first clicks on the link to the page. We plan to put the data into tables and potentially graphs if we have enough time to implement this. Also we might add an interactive map that shows a heatmap of temperature over the time period if we have enough time to implement this.


## Stored Procedure APIs

### GetCompanyDetails (Brandon Biggins)
This API will get all company details for a specific company when the user enters the companyID.  
Input: CompanyID: ex 1 through 5  
Output: All details for the company in the company table

### AddCompany (Ryan Bankert)

This API will let an Admin add a new company to the database.

### GetCompanyClimateRating (Ryan Bankert)

This API will fetch the climate rating for a specified company.

### SearchCompaniesByGeoLocation (Braylon Higginbotham)

This API will get a list of companies based off of the entered lat and long.

### ViewCompanyDataByDateRange (Brandon Biggins)

This API will take in a date range and display the stock and climate data for the selected company for the date range.

### AddClimateAndStockData (Braylon Higginbotham)

This API will let an Admin add climate and stock data for a specific company.

## Climate API

We plan to incorporate the NOAA API so that the user can click a button on the Home page and get the current temperature for their location.

We also plan to pull and store data locally so that we can work with the data more easily for putting the data into tables. 

## Stock API

(Brandon Biggins)
I have pulled stock data for 5 companies and stored the sql files in the NewDataFiles. If you do not want to run these that is fine. I have a years worth of data pulled for each company. Otherwise, you can run these if you want to add the data to the DB.

