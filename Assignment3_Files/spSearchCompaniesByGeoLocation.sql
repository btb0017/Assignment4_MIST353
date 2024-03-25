USE EcoInvest_DB;
GO

Create or alter Procedure spSearchCompaniesByGeoLocation
	@CompanyLatitude NVARCHAR(MAX),
	@CompanyLongitude NVARCHAR(MAX)
	
AS
Begin
	SELECT CompanyName
	CompanyWebsite, 
	CompanyClimateRating,
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

EXEC spSearchCompaniesByGeoLocation 
    @CompanyLatitude = '37.3349', 
    @CompanyLongitude = '-122.0090';
GO

