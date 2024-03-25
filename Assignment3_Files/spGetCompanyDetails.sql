USE EcoInvest_DB;
GO
/* Stored Procedure #1: Get all details for a company by companyID. Used to generate data for a company’s detailed information page.*/
CREATE OR ALTER PROCEDURE spCompanyDetails
	@CompanyID int
	AS
BEGIN
		SELECT * FROM Company WHERE CompanyID = @CompanyID;
END;
GO
/*
EXEC spCompanyDetails 
    @CompanyID = 1, 
GO
*/
