CREATE TABLE BlockChain (
    ID INT IDENTITY(1,1) PRIMARY KEY,      -- Auto-incrementing primary key
    Hash VARCHAR(256) NOT NULL,            -- Hash value of the current block
    [Previous Hash] VARCHAR(256) NOT NULL,    -- Hash value of the previous block
    DateTime DATETIME NOT NULL,            -- Timestamp for when the block is created
    Data NVARCHAR(MAX) NOT NULL            -- Data stored in the block
);


delete  BlockChain