# Galactic Gadgets Inc. Project

Assignment 5 portion of the README will be first, then Assignment 4 is below.

# Assignment5_MIST353
(Brandon Biggins)  
I reworked one of my SPs and have it included in in GitHub repo under assignment 3 files. spGetStockDataByDateRange   
I also created a new api for the stored procedure. I have each of new files in a subfolder, each called NewRepo, Entity, Controller, etc...   

I implemented the getCompanyDetails API into the AppleInfo page.  
I attempted to integrate the StockData API as well, but still am getting errors.

I also edited the Information.cshtml page to add in search functionality for users to search by company name.


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
Input: CompanyID ex. 1 through 5, StartDate and EndDate (ranges from 2023-03-27 (I think) to 2024-03-27)
Output: Currently none. I get an error with this API and I think it might be because the stored procedure has 2 queries in it and EF can't handle both at the same time since they pull data from different tables.
### AddClimateAndStockData (Braylon Higginbotham)

This API will let an Admin add climate and stock data for a specific company.

## Climate API

We plan to incorporate the NOAA API so that the user can click a button on the Home page and get the current temperature for their location.

We also plan to pull and store data locally so that we can work with the data more easily for putting the data into tables. 
Currently, we still only have the mock data from ChatGPT for the climate data for right now.
## Stock API
(Brandon Biggins)
I have pulled stock data for 5 companies and stored the sql files in the NewDataFiles. If you do not want to run these that is fine. I have a years worth of data pulled for each company. Otherwise, you can run these if you want to add the data to the DB.

# ChatGPT Prompts
I am converting sqlserver stored procedures to apis in ASP.NET Core 8. I need to convert this table to a class. Give me the code:  

CREATE TABLE Company (  
    CompanyID INT PRIMARY KEY IDENTITY(1,1),  
    CompanyName NVARCHAR(50) NOT NULL,  
    CompanyStreet NVARCHAR(50) NOT NULL,  
    CompanyCity NVARCHAR(MAX) NOT NULL,  
    CompanyState NVARCHAR(MAX) NOT NULL,  
    CompanyCountry NVARCHAR(50) NOT NULL,  
    CompanyZip NVARCHAR(10) NOT NULL,  
    CompanyEmail NVARCHAR(MAX) NOT NULL,  
    CompanyLatitude NVARCHAR(MAX) NOT NULL,  
    CompanyLongitude NVARCHAR(MAX) NOT NULL,  
    CompanyWebsite NVARCHAR(MAX) NOT NULL,  
    CompanyClimateRating INT NOT NULL  
);  
GO    
now do this one: CREATE TABLE StockData (  
    StockDataID INT PRIMARY KEY IDENTITY(1,1),  
    CompanyID INT NOT NULL,  
    DateValue DATE NOT NULL,  
    OpeningPrice FLOAT NOT NULL,  
    ClosingPrice FLOAT NOT NULL,  
    High FLOAT NOT NULL,  
    Low FLOAT NOT NULL,  
    Volume INT NOT NULL,  
    FOREIGN KEY (CompanyID) REFERENCES Company(CompanyID),  
    FOREIGN KEY (DateValue) REFERENCES Date(DateValue)  
);  
GO    

now this one:  

CREATE TABLE ClimateData (  
    ClimateDataID INT PRIMARY KEY IDENTITY(1,1),  
    CompanyID INT NOT NULL,  
    DateValue DATE NOT NULL,  
    HighTemperature FLOAT NOT NULL,  
    LowTemperature FLOAT NOT NULL,  
    AvgTemperature FLOAT NOT NULL,  
    Precipitation FLOAT NOT NULL,    

What is wrong with this code:  

using EcoInvestAPI.Repositories;  
using Microsoft.AspNetCore.Mvc;  

namespace EcoInvestAPI.Controllers  
{  
    [Route("api/[controller]")]  
    [ApiController]  
    public class CompanyController : Controller  
    {  
        private readonly ICompanyService companyService;  
        public CompanyController(ICompanyService companyService)  
        {  
            this.companyService = companyService;  
        }  
        [HttpGet("{companyId}")]  
        public async Task<List<CompanyService>> GetCompanyDetails(int companyId)  
        {  
            var companyDetails = await companyService.GetCompanyDetails(companyId);  
            /*if (companyDetails == null)  
            {  
                return NotFound();  
            }*/  
            return companyDetails;  
        }  
    }  
}    
