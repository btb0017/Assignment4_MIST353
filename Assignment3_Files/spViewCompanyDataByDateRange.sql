USE EcoInvest_DB;
GO

CREATE OR ALTER PROCEDURE spViewCompanyDataByDateRange
    @CompanyID INT,
    @StartDate DATE,
    @EndDate DATE
AS
BEGIN
    SELECT c.CompanyName, d.DateValue, cd.Temperature, cd.Humidity, cd.CO2Levels
    FROM Company c
    JOIN ClimateData cd ON c.CompanyID = cd.CompanyID
    JOIN Date d ON cd.DateID = d.DateID
    WHERE c.CompanyID = @CompanyID
    AND d.DateValue BETWEEN @StartDate AND @EndDate;

    SELECT c.CompanyName, d.DateValue, sd.OpeningPrice, sd.ClosingPrice, sd.High, sd.Low, sd.Volume
    FROM Company c
    JOIN StockData sd ON c.CompanyID = sd.CompanyID
    JOIN Date d ON sd.DateID = d.DateID
    WHERE c.CompanyID = @CompanyID
    AND d.DateValue BETWEEN @StartDate AND @EndDate;
END;
GO

EXEC spViewCompanyDataByDateRange 
    @CompanyID = 1, 
    @StartDate = '2023-01-01', 
    @EndDate = '2023-01-31';
GO
