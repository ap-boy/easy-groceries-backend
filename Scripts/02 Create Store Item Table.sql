CREATE TABLE StoreItem (
    Id INT IDENTITY(1,1) NOT NULL,
    Name VARCHAR(200) NULL,
    Price Decimal(10,2) NULL,
    Description VARCHAR(1200) NULL,
    CONSTRAINT PK_StoreItem PRIMARY KEY (Id)
)