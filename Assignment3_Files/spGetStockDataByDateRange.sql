USE ECOInvest_DB;
GO

CREATE OR ALTER PROCEDURE spGetStockDataByDateRange
	@CompanyID INT,
    @StartDate DATE,
    @EndDate DATE
AS
BEGIN
SELECT c.CompanyName, sd.DateValue, 
           sd.OpeningPrice, sd.ClosingPrice, sd.High, sd.Low, sd.Volume
    FROM Company c
    JOIN StockData sd ON c.CompanyID = sd.CompanyID
    WHERE c.CompanyID = @CompanyID
    AND sd.DateValue BETWEEN @StartDate AND @EndDate;
END;
GO
EXEC spGetStockDataByDateRange 
    @CompanyID = 1, 
    @StartDate = '2024-01-01', 
    @EndDate = '2024-01-31';
GO
