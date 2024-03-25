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

EXEC spSearchCompaniesByGeoLocation '25.7617', '-80.1918'
GO
