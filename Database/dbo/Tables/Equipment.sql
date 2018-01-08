CREATE TABLE [dbo].[Equipment](
	[Id] [int] IDENTITY (1, 1) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Price] [int] NOT NULL,
	[Agility] [int] NOT NULL,
	[Strenght] [int] NOT NULL,
	[Intelligence] [int] NOT NULL,
	[CategoryID] INT NOT NULL,
	PRIMARY KEY (Id),
	CONSTRAINT [fk_equipment_category] FOREIGN KEY (CategoryID) REFERENCES Category(Id)
)