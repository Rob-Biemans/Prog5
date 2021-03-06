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
	[Id] [int] IDENTITY (1, 1) NOT NULL,
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
	[Id] [int] IDENTITY (1, 1) NOT NULL,
	[Category] [varchar](255) NOT NULL,
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
	[Id] [int] IDENTITY (1, 1) NOT NULL,
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
	[Id] [int] IDENTITY (1, 1) NOT NULL,
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

SET IDENTITY_INSERT [dbo].[Category] ON

INSERT INTO [dbo].[Category]
           ([Id]
           ,[Name])
     VALUES
           (1,'Helm')

		   INSERT INTO [dbo].[Category]
           ([Id]
           ,[Name])
     VALUES
           (2,'Shoulders')

		   INSERT INTO [dbo].[Category]
           ([Id]
           ,[Name])
     VALUES
           (3,'Chest')

		   INSERT INTO [dbo].[Category]
           ([Id]
           ,[Name])
     VALUES
           (4,'Belt')

		   INSERT INTO [dbo].[Category]
           ([Id]
           ,[Name])
     VALUES
           (5,'Legs')

		   INSERT INTO [dbo].[Category]
           ([Id]
           ,[Name])
     VALUES
           (6,'Boots')

GO

USE [Entities]
GO

SET IDENTITY_INSERT [dbo].[Ninja] ON

INSERT INTO [dbo].[Ninja]
           ([Id]
           ,[Name]
           ,[Currency]
		   ,[InventoryID])
     VALUES
           (1,'Rob', 9000, 1)

		   INSERT INTO [dbo].[Ninja]
           ([Id]
           ,[Name]
           ,[Currency]
		   ,[InventoryID])
     VALUES
           (2,'Daan', 9000, 2)

		   INSERT INTO [dbo].[Ninja]
           ([Id]
           ,[Name]
           ,[Currency]
		   ,[InventoryID])
     VALUES
           (3,'Piet', 9000, 3)

		   INSERT INTO [dbo].[Ninja]
           ([Id]
           ,[Name]
           ,[Currency]
		   ,[InventoryID])
     VALUES
           (4,'Ethiopie', 9000 ,4)

GO

USE [Entities]
GO

SET IDENTITY_INSERT [dbo].[Equipment] ON

		INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (1,'Helm','Bronze',200,1,1,1)
	 	INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (2,'Helm','Iron',800,2,2,2)
	 	INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (3,'Helm','Gold',1200,3,3,3)
	 	INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (4,'Helm','Platinum',1400,4,4,4)

	 		INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (5,'Shoulders','Bronze',200,1,1,1)
	 	INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (6,'Shoulders','Iron',800,2,2,2)
	 	INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (7,'Shoulders','Gold',1200,3,3,3)
	 	INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (8,'Shoulders','Platinum',1400,4,4,4)

	 		INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (9,'Chest','Bronze',200,1,1,1)
	 	INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (10,'Chest','Iron',800,2,2,2)
	 	INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (11,'Chest','Gold',1200,3,3,3)
	 	INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (12,'Chest','Platinum',1400,4,4,4)

	 		INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (13,'Belt','Bronze',200,1,1,1)
	 	INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (14,'Belt','Iron',800,2,2,2)
	 	INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (15,'Belt','Gold',1200,3,3,3)
	 	INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (16,'Belt','Platinum',1400,4,4,4)

	 		INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (17,'Legs','Bronze',200,1,1,1)
	 	INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (18,'Legs','Iron',800,2,2,2)
	 	INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (19,'Legs','Gold',1200,3,3,3)
	 	INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (20,'Legs','Platinum',1400,4,4,4)

	 		INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (21,'Boots','Bronze',200,1,1,1)
	 	INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (22,'Boots','Iron',800,2,2,2)
	 	INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (23,'Boots','Gold',1200,3,3,3)
	 	INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (24,'Boots','Platinum',1400,4,4,4)

GO




