CREATE TABLE [dbo].[Inventory] (
    [InventoryId]          INT             IDENTITY (1, 1) NOT NULL,
    [InventoryName]        NVARCHAR (MAX)  NOT NULL,
    [InventoryDescription] NVARCHAR (MAX)  NULL,
    [InventoryPic]         NVARCHAR (MAX)  NOT NULL,
    [InventoryPrice]       DECIMAL (18, 2) NULL,
    CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED ([InventoryId] ASC)
);

