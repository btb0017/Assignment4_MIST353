USE EcoInvest_DB;
GO

CREATE OR ALTER PROCEDURE spViewCompanyDataByDateRange
    @CompanyID INT,
    @StartDate DATE,
    @EndDate DATE
AS
BEGIN
    -- Updated to include new columns from ClimateData
    SELECT c.CompanyName, cd.DateValue, 
           cd.HighTemperature, cd.LowTemperature, cd.AvgTemperature, cd.Precipitation
    FROM Company c
    JOIN ClimateData cd ON c.CompanyID = cd.CompanyID
    WHERE c.CompanyID = @CompanyID
    AND cd.DateValue BETWEEN @StartDate AND @EndDate;

    -- StockData query remains the same as DateValue is directly used
    SELECT c.CompanyName, sd.DateValue, 
           sd.OpeningPrice, sd.ClosingPrice, sd.High, sd.Low, sd.Volume
    FROM Company c
    JOIN StockData sd ON c.CompanyID = sd.CompanyID
    WHERE c.CompanyID = @CompanyID
    AND sd.DateValue BETWEEN @StartDate AND @EndDate;
END;
GO

-- Example execution of the stored procedure
EXEC spViewCompanyDataByDateRange 
    @CompanyID = 1, 
    @StartDate = '2024-01-01', 
    @EndDate = '2024-01-31';
GO
