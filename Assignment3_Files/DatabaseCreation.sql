CREATE DATABASE EcoInvest_DB;
GO

USE EcoInvest_DB;
GO

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

CREATE TABLE Date (
    DateValue DATE PRIMARY KEY NOT NULL
);
GO


-- Adjusted ClimateData table
CREATE TABLE ClimateData (
    ClimateDataID INT PRIMARY KEY IDENTITY(1,1),
    CompanyID INT NOT NULL,
    DateValue DATE NOT NULL,
    HighTemperature FLOAT NOT NULL,
    LowTemperature FLOAT NOT NULL,
    AvgTemperature FLOAT NOT NULL,
    Precipitation FLOAT NOT NULL,
    FOREIGN KEY (CompanyID) REFERENCES Company(CompanyID),
    FOREIGN KEY (DateValue) REFERENCES Date(DateValue)
);
GO

CREATE TABLE StockData (
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