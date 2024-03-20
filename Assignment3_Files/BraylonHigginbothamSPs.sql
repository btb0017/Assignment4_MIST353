USE EcoInvest_DB;
GO

Create or alter Procedure spSearchCompaniesByGeoLocation
	@CompanyLatitude NVARCHAR(MAX),
	@CompanyLongitude NVARCHAR(MAX)
	
AS
Begin
	SELECT CompanyName
	CompanyWebsite, 
	CompanyClimateRating
	CompanyStreet,
	CompanyCity,
	CompanyState,
	CompanyCountry,
	CompanyZip, 
	CompanyEmail
	FROM Company
    WHERE CompanyLatitude = @CompanyLatitude
    AND CompanyLongitude = @CompanyLongitude
END;
GO
/*
EXEC spSearchCompaniesByGeoLocation '25.7617', '-80.1918'
GO
*/
USE ECOInvest_DB;
GO

 Create OR ALTER PROCEDURE AddClimateAndStockData 

    @CompanyID INT,
    @DateValue DATE,
    @Temperature FLOAT,
    @Humidity FLOAT,
    @CO2Levels FLOAT,
    @OpeningPrice FLOAT,
    @ClosingPrice FLOAT,
    @High FLOAT,
    @Low FLOAT,
    @Volume INT
AS
BEGIN
    DECLARE @DateID INT

    SELECT @CompanyID = CompanyID 
	FROM Company 

	IF NOT EXISTS (SELECT 1 FROM Date WHERE DateValue = @DateValue)
    BEGIN
        INSERT INTO Date (DateValue) VALUES (@DateValue);
    END

    SELECT @DateID = DateID FROM Date WHERE DateValue = @DateValue;

    INSERT INTO ClimateData (CompanyID, DateID, Temperature, Humidity, CO2Levels)
    VALUES (@CompanyID, @DateID, @Temperature, @Humidity, @CO2Levels)

  
    INSERT INTO StockData (CompanyID, DateID, OpeningPrice, ClosingPrice, High, Low, Volume)
    VALUES (@CompanyID, @DateID, @OpeningPrice, @ClosingPrice, @High, @Low, @Volume)

  END;
  GO
  /*
  EXEC AddClimateAndStockData
	@CompanyID = 1,
    @DateValue = "2023-01-20",
    @Temperature = 79.44,
    @Humidity = 54.02,
    @CO2Levels = 405,
    @OpeningPrice = 120.06,
    @ClosingPrice = 115.22,
    @High = 125.57,
    @Low = 102.94,
    @Volume = 6000;
GO
*/