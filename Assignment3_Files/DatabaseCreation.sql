CREATE DATABASE EcoInvest_DB;
GO

USE EcoInvest_DB;
GO

CREATE TABLE Company (
    CompanyID INT PRIMARY KEY IDENTITY,
    CompanyName NVARCHAR(50) not null,
    CompanyStreet NVARCHAR(50) not null,
    CompanyCity NVARCHAR(MAX) not null,
    CompanyState NVARCHAR(MAX) not null,
    CompanyCountry NVARCHAR(50) not null,
    CompanyZip NVARCHAR(10) not null,
    CompanyEmail NVARCHAR(MAX) not null,
    CompanyLatitude NVARCHAR(MAX) not null,
    CompanyLongitude NVARCHAR(MAX) not null,
    CompanyWebsite NVARCHAR(MAX) not null,
    CompanyClimateRating INT not null
);
GO

CREATE TABLE Date (
    DateID INT PRIMARY KEY IDENTITY(1,1),
    DateValue DATE UNIQUE not null
);
GO

CREATE TABLE ClimateData (
    ClimateDataID INT PRIMARY KEY IDENTITY(1,1),
    CompanyID INT not null,
    DateID INT not null,
    Temperature FLOAT not null,
    Humidity FLOAT not null,
    CO2Levels FLOAT not null,
    FOREIGN KEY (CompanyID) REFERENCES Company(CompanyID),
    FOREIGN KEY (DateID) REFERENCES Date(DateID)
);
GO

CREATE TABLE StockData (
    StockDataID INT PRIMARY KEY IDENTITY(1,1),
    CompanyID INT not null,
    DateID INT not null,
    OpeningPrice FLOAT not null,
    ClosingPrice FLOAT not null,
    High FLOAT not null,
    Low FLOAT not null,
    Volume INT not null,
    FOREIGN KEY (CompanyID) REFERENCES Company(CompanyID),
    FOREIGN KEY (DateID) REFERENCES Date(DateID)
);
GO