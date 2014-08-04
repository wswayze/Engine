CREATE TABLE [dbo].[TrackingData]
(
    [Symbol] NVARCHAR(10) NOT NULL, 
    [TransactionDate] DATETIME NOT NULL, 
    [Volume] INT NOT NULL, 
    [OpenPrice] DECIMAL(18, 6) NOT NULL, 
    [HighPrice] DECIMAL(18, 6) NOT NULL, 
    [LowPrice] DECIMAL(18, 6) NOT NULL, 
    [ClosePrice] DECIMAL(18, 6) NOT NULL 
)
