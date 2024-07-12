CREATE DATABASE MyDataHub;
USE MyDataHub;

-- สร้างตาราง Users
CREATE TABLE Users (
    UserID INT PRIMARY KEY,
    IDCardNumber VARCHAR(13),
    Title VARCHAR(20) COLLATE Thai_CI_AS,
    FirstName VARCHAR(50) COLLATE Thai_CI_AS,
    LastName VARCHAR(50) COLLATE Thai_CI_AS,
    AddressNo VARCHAR(20),
    Moo VARCHAR(20),
    Subdistrict VARCHAR(50) COLLATE Thai_CI_AS,
    District VARCHAR(50) COLLATE Thai_CI_AS,
    Province VARCHAR(50) COLLATE Thai_CI_AS,
    PostalCode VARCHAR(10),
    DocumentImage VARCHAR(255)
);

-- สร้างตาราง WaterUsage
CREATE TABLE WaterUsage (
    WaterUsageID INT PRIMARY KEY,
    UserID INT,
    Month INT,
    Year INT,
    UsageUnit DECIMAL(10, 2),
    Status VARCHAR(20) COLLATE Thai_CI_AS,
    ReceiptImage VARCHAR(255),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

-- สร้างตาราง Garbage
CREATE TABLE Garbage (
    GarbageID INT PRIMARY KEY,
    UserID INT,
    Month INT,
    Year INT,
    GarbageFee DECIMAL(10, 2),
    Status VARCHAR(20) COLLATE Thai_CI_AS,
    ReceiptImage VARCHAR(255),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);
USE MyDataHub;

-- แทรกข้อมูลในตาราง Users
INSERT INTO Users (UserID, IDCardNumber, Title, FirstName, LastName, AddressNo, Moo, Subdistrict, District, Province, PostalCode, DocumentImage)
VALUES
    (1, '1234567890123', N'นาย', N'สมชาย', N'ใจดี', N'123 หมู่ 4', N'ตรอกสุขภาพ', N'แขวงสะพานสูง', N'เขตสะพานสูง', N'กรุงเทพมหานคร', N'10240', '/images/documents/1.jpg'),
    (2, '9876543210987', N'นางสาว', N'สมรส', N'รักสันต์', N'456 หมู่ 6', N'ตรอกสุขสันต์', N'แขวงสะพานนคราม', N'เขตบางซื่อ', N'กรุงเทพมหานคร', N'10500', '/images/documents/2.jpg');

-- แทรกข้อมูลในตาราง WaterUsage
INSERT INTO WaterUsage (WaterUsageID, UserID, Month, Year, UsageUnit, Status, ReceiptImage)
VALUES
    (1, 1, 10, 2022, 25.5, N'ใช้งานอยู่', '/images/receipts/water_1.jpg'),
    (2, 1, 11, 2022, 30.2, N'ใช้งานอยู่', '/images/receipts/water_2.jpg'),
    (3, 2, 10, 2022, 18.7, N'ใช้งานอยู่', '/images/receipts/water_3.jpg');

-- แทรกข้อมูลในตาราง Garbage
INSERT INTO Garbage (GarbageID, UserID, Month, Year, GarbageFee, Status, ReceiptImage)
VALUES
    (1, 1, 10, 2022, 100.50, N'ใช้งานอยู่', '/images/receipts/garbage_1.jpg'),
    (2, 1, 11, 2022, 120.75, N'ใช้งานอยู่', '/images/receipts/garbage_2.jpg'),
    (3, 2, 10, 2022, 90.25, N'ใช้งานอยู่', '/images/receipts/garbage_3.jpg');

select * from users;