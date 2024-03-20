USE EcoInvest_DB;
GO


INSERT INTO Company (CompanyID, CompanyName, CompanyStreet, CompanyCity, CompanyState, CompanyCountry, CompanyZip, CompanyEmail, CompanyLatitude, CompanyLongitude, CompanyWebsite, CompanyClimateRating)
VALUES
(1, 'EcoTech', '123 Green Way', 'EcoCity', 'EC', 'Utopia', '12345', 'contact@ecotech.com', '47.6062', '-122.3321', 'http://www.ecotech.com', 8),
(2, 'BioRenew', '456 Renewable Rd', 'Sustainville', 'SR', 'Gaia', '67890', 'info@biorenew.com', '37.7749', '-122.4194', 'http://www.biorenew.com', 9),
(3, 'GreenPower', '789 Conservation St', 'GreenTown', 'GT', 'Eden', '10112', 'support@greenpower.com', '40.7128', '-74.0060', 'http://www.greenpower.com', 7),
(4, 'SolarSolutions', '321 Sunny Ave', 'SolCity', 'SC', 'Nirvana', '21314', 'hello@solarsolutions.com', '34.0522', '-118.2437', 'http://www.solarsolutions.com', 10),
(5, 'WindWave', '654 Breeze Blvd', 'WindVille', 'WV', 'Avalon', '45678', 'contactus@windwave.com', '25.7617', '-80.1918', 'http://www.windwave.com', 6);

GO


INSERT INTO Date (DateValue) VALUES
('2023-01-01'),
('2023-01-02'),
('2023-01-03'),
('2023-01-04'),
('2023-01-05');

GO


INSERT INTO ClimateData (CompanyID, DateID, Temperature, Humidity, CO2Levels) VALUES
(1, 1, 25.0, 50, 415),
(1, 2, 26.5, 52, 418),
(1, 3, 27.0, 48, 420),
(1, 4, 24.0, 47, 410),
(1, 5, 23.5, 49, 405);

GO


INSERT INTO StockData (CompanyID, DateID, OpeningPrice, ClosingPrice, High, Low, Volume) VALUES
(1, 1, 100.50, 102.75, 103.20, 100.25, 5000),
(1, 2, 102.75, 103.50, 104.00, 102.50, 5500),
(1, 3, 103.50, 104.25, 105.00, 103.00, 6000),
(1, 4, 104.25, 103.00, 104.50, 102.75, 4500),
(1, 5, 103.00, 102.50, 103.75, 102.00, 4000);

GO