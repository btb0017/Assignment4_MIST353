/* Stored Procedure #2: Add a company. Used to add company details to track information.*/
USE EcoInvest_DB;

GO

CREATE OR ALTER PROCEDURE spCompanyAdd
	@CompanyID int,
	@CompanyName nvarchar(50),
	@CompanyStreet nvarchar(50),
	@CompanyCity nvarchar(MAX),
	@CompanyState nvarchar(MAX),
	@CompanyCountry nvarchar(50),
	@CompanyZip nvarchar(10) = null,
	@CompanyEmail nvarchar(MAX) = null,
	@CompanyLatitude nvarchar(MAX) = null,
	@CompanyLongitude nvarchar(MAX) = null,
	@CompanyWebsite nvarchar(MAX) = null,
	@CompanyClimateRating int = null
		AS
		BEGIN
		INSERT INTO Company(CompanyID, CompanyName, CompanyStreet, CompanyCity, CompanyState, CompanyCountry, 
			CompanyZip, CompanyEmail, CompanyLatitude,CompanyLongitude,CompanyWebsite, CompanyClimateRating) 
		VALUES (@CompanyID, @CompanyName, @CompanyStreet, @CompanyCity, @CompanyState, @CompanyCountry, 
			@CompanyZip, @CompanyEmail, @CompanyLatitude, @CompanyLongitude, @CompanyWebsite, @CompanyClimateRating);
END;
GO
/* EXEC spCompanyAdd
	@CompanyID = 1,
	@CompanyName ="EcoTech", 
	@CompanyStreet ="123 Green Way", 
	@CompanyCity="EcoCity", 
	@CompanyState="EC", 
	@CompanyCountry="Utopia", 
	@CompanyZip="12345", 
	@CompanyEmail="contact@ecotech.com", 
	@CompanyLatitude="47.6062", 
	@CompanyLongitude ="-122.3321", 
	@CompanyWebsite="http://www.ecotech.com",
	@CompanyClimateRating = 8;
GO
*/
