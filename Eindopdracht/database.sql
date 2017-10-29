USE [Entities]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 25-10-2017 19:57:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] NOT NULL IDENTITY(1,1),
	[Name] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON
GO
/****** Object:  Table [dbo].[Equipment]    Script Date: 25-10-2017 19:57:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Equipment](
	[Id] [int] NOT NULL IDENTITY(1,1),
	[Category] [int] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Price] [int] NOT NULL,
	[Agility] [int] NOT NULL,
	[Strenght] [int] NOT NULL,
	[Intelligence] [int] NOT NULL,
 CONSTRAINT [PK_Equipment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON
GO
/****** Object:  Table [dbo].[Ninja]    Script Date: 25-10-2017 19:57:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ninja](
	[Id] [int] NOT NULL IDENTITY(1,1),
	[Name] [varchar](255) NOT NULL,
	[Currency] [int] NOT NULL,
	[InventoryID] [int] NOT NULL,
 CONSTRAINT [PK_Ninja] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON
GO


/****** Object:  Table [dbo].[Inventory]    Script Date: 25-10-2017 19:57:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inventory](
	[Id] [int] NOT NULL IDENTITY(1,1),
	[NinjaID] [int] NOT NULL,
	[EquipmentID] [int] NOT NULL,
 CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON
GO

USE [Entities]
GO

INSERT INTO [dbo].[Category]
           ([Name])
     VALUES
           ('Helm')

		   INSERT INTO [dbo].[Category]
           ([Name])
     VALUES
           ('Shoulders')

		   INSERT INTO [dbo].[Category]
           ([Name])
     VALUES
           ('Chest')

		   INSERT INTO [dbo].[Category]
           ([Name])
     VALUES
           ('Belt')

		   INSERT INTO [dbo].[Category]
           ([Name])
     VALUES
           ('Legs')

		   INSERT INTO [dbo].[Category]
           ([Name])
     VALUES
           ('Boots')

GO

USE [Entities]
GO

INSERT INTO [dbo].[Ninja]
           ([Name]
           ,[Currency]
		   ,[InventoryID])
     VALUES
           ('Rob', 9000, 1)

		   INSERT INTO [dbo].[Ninja]
           ([Name]
           ,[Currency]
		   ,[InventoryID])
     VALUES
           ('Daan', 9000, 2)

		   INSERT INTO [dbo].[Ninja]
           ([Name]
           ,[Currency]
		   ,[InventoryID])
     VALUES
           ('Piet', 9000, 3)

		   INSERT INTO [dbo].[Ninja]
           ([Name]
           ,[Currency]
		   ,[InventoryID])
     VALUES
           ('Ethiopie', 9000 ,4)
GO

USE [Entities]
GO

		INSERT INTO [dbo].[Equipment] ([Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (1,'Bronze',200,1,1,1)
	 	INSERT INTO [dbo].[Equipment] ([Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (1,'Iron',800,2,2,2)
	 	INSERT INTO [dbo].[Equipment] ([Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (1,'Gold',1200,3,3,3)
	 	INSERT INTO [dbo].[Equipment] ([Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (1,'Platinum',1400,4,4,4)

	 		INSERT INTO [dbo].[Equipment] ([Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (2,'Bronze',200,1,1,1)
	 	INSERT INTO [dbo].[Equipment] ([Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (2,'Iron',800,2,2,2)
	 	INSERT INTO [dbo].[Equipment] ([Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (2,'Gold',1200,3,3,3)
	 	INSERT INTO [dbo].[Equipment] ([Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (2,'Platinum',1400,4,4,4)

	 		INSERT INTO [dbo].[Equipment] ([Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (3,'Bronze',200,1,1,1)
	 	INSERT INTO [dbo].[Equipment] ([Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (3,'Iron',800,2,2,2)
	 	INSERT INTO [dbo].[Equipment] ([Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (3,'Gold',1200,3,3,3)
	 	INSERT INTO [dbo].[Equipment] ([Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (3,'Platinum',1400,4,4,4)

	 		INSERT INTO [dbo].[Equipment] ([Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (4,'Bronze',200,1,1,1)
	 	INSERT INTO [dbo].[Equipment] ([Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (4,'Iron',800,2,2,2)
	 	INSERT INTO [dbo].[Equipment] ([Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (4,'Gold',1200,3,3,3)
	 	INSERT INTO [dbo].[Equipment] ([Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (4,'Platinum',1400,4,4,4)

	 		INSERT INTO [dbo].[Equipment] ([Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (5,'Bronze',200,1,1,1)
	 	INSERT INTO [dbo].[Equipment] ([Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (5,'Iron',800,2,2,2)
	 	INSERT INTO [dbo].[Equipment] ([Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (5,'Gold',1200,3,3,3)
	 	INSERT INTO [dbo].[Equipment] ([Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (5,'Platinum',1400,4,4,4)

	 		INSERT INTO [dbo].[Equipment] ([Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (6,'Bronze',200,1,1,1)
	 	INSERT INTO [dbo].[Equipment] ([Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (6,'Iron',800,2,2,2)
	 	INSERT INTO [dbo].[Equipment] ([Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (6,'Gold',1200,3,3,3)
	 	INSERT INTO [dbo].[Equipment] ([Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (6,'Platinum',1400,4,4,4)

GO




