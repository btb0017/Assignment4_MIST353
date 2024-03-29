USE EcoInvest_DB;
GO

CREATE OR ALTER PROCEDURE spGetCompanyClimateRating
    @CompanyID INT
AS
BEGIN
    SELECT CompanyID, CompanyName, CompanyClimateRating
    FROM Company
    WHERE CompanyID = @CompanyID;
END;
GO

EXEC spGetCompanyClimateRating @CompanyID = 2;
GO

