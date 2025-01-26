INSERT INTO dbo.Suppliers (CreatedDate, UpdatedDate, Name, LegalName, TaxIdentification, Phone, Email, Website, Address, Country, AnnualBilling)
VALUES 
-- Datos basados en el CSV
(GETDATE(), GETDATE(), 'VIVA ATLANTIC', 'VIVA ATLANTIC LIMITED', '20123456789', '+2348001234567', 'info@vivaatlantic.com', 'https://vivaatlantic.com', '12 LIBREVILLE STREET, WUSE 2, ABUJA', 'Nigeria', 50000.00),
(GETDATE(), GETDATE(), 'TECH HOUSE', 'TECHNOLOGY HOUSE LIMITED', '20123456790', '+2348002345678', 'info@techhouse.com', 'https://techhouse.com', '12 LIBREVILE STREET, WUSE 2, ABUJA', 'Nigeria', 75000.00),
(GETDATE(), GETDATE(), 'NORMAN DIDAM', 'MR.NORMAN BWURUK DIDAM', '20123456791', '+2348003456789', 'contact@normandidam.com', 'https://normandidam.com', '12 LIBREVILE STREET, WUSE 2, ABUJA', 'Nigeria', 42000.00),
(GETDATE(), GETDATE(), 'CNN CAUCASIA', 'CNN CAUCASIA LLC', '20123456792', '+995599123456', 'contact@cnncaucasia.com', 'https://cnncaucasia.com', 'POTI FREE INDUSTRIAL ZONE, PLOT NO 545 CODE 04', 'Georgia', 68000.00),
(GETDATE(), GETDATE(), 'RUFAT MAJIDOV', 'MR. RUFAT MAJIDOV', '20123456793', '+994552345678', 'info@rufatmaji.com', 'https://rufatmaji.com', 'BINAGADI HIGHWAY, MADAN STREET 4 AZ1053, BAKU', 'Azerbaijan', 47000.00),

-- Datos random
(GETDATE(), GETDATE(), 'Global Solutions', 'Global Solutions Inc.', '20123456794', '+11234567890', 'info@globalsolutions.com', 'https://globalsolutions.com', '123 Main Street, New York, NY', 'United States', 100000.00),
(GETDATE(), GETDATE(), 'Tech Innovators', 'Tech Innovators Ltd.', '20123456795', '+11234567891', 'contact@techinnovators.com', 'https://techinnovators.com', '456 Silicon Valley, San Francisco, CA', 'United States', 150000.00),
(GETDATE(), GETDATE(), 'EcoFriendly Supplies', 'EcoFriendly Supplies LLC', '20123456796', '+442071234567', 'sales@ecofriendly.com', 'https://ecofriendly.com', '78 Greenway Road, London', 'United Kingdom', 80000.00),
(GETDATE(), GETDATE(), 'Sustain Tech', 'Sustainability Tech Ltd.', '20123456797', '+442071234568', 'info@sustaintech.com', 'https://sustaintech.com', '99 Innovation Way, Manchester', 'United Kingdom', 92000.00),
(GETDATE(), GETDATE(), 'Alpha Industries', 'Alpha Industries Pvt. Ltd.', '20123456798', '+911234567890', 'support@alphaindustries.com', 'https://alphaindustries.com', '1 Alpha Street, New Delhi', 'India', 120000.00),

(GETDATE(), GETDATE(), 'Beta Solutions', 'Beta Solutions Ltd.', '20123456799', '+911234567891', 'info@betasolutions.com', 'https://betasolutions.com', '2 Beta Road, Bangalore', 'India', 98000.00),
(GETDATE(), GETDATE(), 'Smart Tech Co.', 'Smart Technologies Corporation', '20123456800', '+8613123456789', 'contact@smarttech.com', 'https://smarttech.com', '88 High-Tech Zone, Shenzhen', 'China', 200000.00),
(GETDATE(), GETDATE(), 'Green Energy', 'Green Energy Ltd.', '20123456801', '+8613123456790', 'info@greenenergy.com', 'https://greenenergy.com', '123 Solar Way, Shanghai', 'China', 175000.00),
(GETDATE(), GETDATE(), 'Future Innovations', 'Future Innovations Inc.', '20123456802', '+81312345678', 'sales@futureinnovations.com', 'https://futureinnovations.com', '456 Tech Park, Tokyo', 'Japan', 210000.00),
(GETDATE(), GETDATE(), 'Neo Supplies', 'Neo Supplies LLC', '20123456803', '+61312345678', 'info@neosupplies.com', 'https://neosupplies.com', '789 Business Lane, Sydney', 'Australia', 95000.00),

(GETDATE(), GETDATE(), 'Oceanic Traders', 'Oceanic Traders Ltd.', '20123456804', '+61312345679', 'support@oceanictraders.com', 'https://oceanictraders.com', '123 Marina Road, Melbourne', 'Australia', 85000.00),
(GETDATE(), GETDATE(), 'Atlantic Corp', 'Atlantic Corporation', '20123456805', '+5511987654321', 'info@atlanticcorp.com', 'https://atlanticcorp.com', '123 Business District, São Paulo', 'Brazil', 112000.00),
(GETDATE(), GETDATE(), 'Pacific Ventures', 'Pacific Ventures Inc.', '20123456806', '+5521987654321', 'contact@pacificventures.com', 'https://pacificventures.com', '456 Corporate Lane, Rio de Janeiro', 'Brazil', 97000.00),
(GETDATE(), GETDATE(), 'Nordic Supplies', 'Nordic Supplies AB', '20123456807', '+46709876543', 'sales@nordicsupplies.com', 'https://nordicsupplies.com', '789 Northern Lane, Stockholm', 'Sweden', 89000.00),
(GETDATE(), GETDATE(), 'Arctic Logistics', 'Arctic Logistics AS', '20123456808', '+47987654321', 'info@arcticlogistics.com', 'https://arcticlogistics.com', '123 Frost Road, Oslo', 'Norway', 105000.00);
