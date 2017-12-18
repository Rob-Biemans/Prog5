
USE [Entities]
GO

/****** Object:  Table [dbo].[Category]    Script Date: 25-10-2017 19:57:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
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

SET ANSI_PADDING ON
GO

/****** Object:  Table [dbo].[Ninja]    Script Date: 25-10-2017 19:57:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
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

SET ANSI_PADDING ON
GO

USE [Entities]
GO

INSERT INTO [dbo].[Category]
           ([Id]
           ,[Name])
     VALUES
           (1,'Helm')
GO

INSERT INTO [dbo].[Category]
           ([Id]
           ,[Name])
     VALUES
           (2,'Shoulders')
GO

INSERT INTO [dbo].[Category]
           ([Id]
           ,[Name])
     VALUES
           (3,'Chest')
GO

INSERT INTO [dbo].[Category]
           ([Id]
           ,[Name])
     VALUES
           (4,'Belt')
GO

INSERT INTO [dbo].[Category]
           ([Id]
           ,[Name])
     VALUES
           (5,'Legs')
GO

INSERT INTO [dbo].[Category]
           ([Id]
           ,[Name])
     VALUES
           (6,'Boots')
GO

USE [Entities]
GO

INSERT INTO [dbo].[Ninja]
           ([Id]
           ,[Name]
           ,[Currency]
		   ,[InventoryID])
     VALUES
           (1,'Rob', 9000, 1)
GO

INSERT INTO [dbo].[Ninja]
           ([Id]
           ,[Name]
           ,[Currency]
		   ,[InventoryID])
     VALUES
           (2,'Daan', 9000, 2)
GO

INSERT INTO [dbo].[Ninja]
           ([Id]
           ,[Name]
           ,[Currency]
		   ,[InventoryID])
     VALUES
           (3,'Piet', 9000, 3)
GO

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

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (1,1,'Bronze',200,1,1,1)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (2,1,'Iron',800,2,2,2)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (3,1,'Gold',1200,3,3,3)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (4,1,'Platinum',1400,4,4,4)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (5,2,'Bronze',200,1,1,1)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (6,2,'Iron',800,2,2,2)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (7,2,'Gold',1200,3,3,3)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (8,2,'Platinum',1400,4,4,4)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (9,3,'Bronze',200,1,1,1)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (10,3,'Iron',800,2,2,2)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (11,3,'Gold',1200,3,3,3)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (12,3,'Platinum',1400,4,4,4)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (13,4,'Bronze',200,1,1,1)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (14,4,'Iron',800,2,2,2)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (15,4,'Gold',1200,3,3,3)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (16,4,'Platinum',1400,4,4,4)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (17,5,'Bronze',200,1,1,1)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (18,5,'Iron',800,2,2,2)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (19,5,'Gold',1200,3,3,3)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (20,5,'Platinum',1400,4,4,4)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (21,6,'Bronze',200,1,1,1)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (22,6,'Iron',800,2,2,2)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (23,6,'Gold',1200,3,3,3)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (24,6,'Platinum',1400,4,4,4)
GO

USE [Entities]
GO

/****** Object:  Table [dbo].[Category]    Script Date: 25-10-2017 19:57:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
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

SET ANSI_PADDING ON
GO

/****** Object:  Table [dbo].[Ninja]    Script Date: 25-10-2017 19:57:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
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

SET ANSI_PADDING ON
GO

USE [Entities]
GO

SET IDENTITY_INSERT [dbo].[Category] ON
GO

INSERT INTO [dbo].[Category]
           ([Id]
           ,[Name])
     VALUES
           (1,'Helm')
GO

INSERT INTO [dbo].[Category]
           ([Id]
           ,[Name])
     VALUES
           (2,'Shoulders')
GO

INSERT INTO [dbo].[Category]
           ([Id]
           ,[Name])
     VALUES
           (3,'Chest')
GO

INSERT INTO [dbo].[Category]
           ([Id]
           ,[Name])
     VALUES
           (4,'Belt')
GO

INSERT INTO [dbo].[Category]
           ([Id]
           ,[Name])
     VALUES
           (5,'Legs')
GO

INSERT INTO [dbo].[Category]
           ([Id]
           ,[Name])
     VALUES
           (6,'Boots')
GO

USE [Entities]
GO

SET IDENTITY_INSERT [dbo].[Ninja] ON
GO

INSERT INTO [dbo].[Ninja]
           ([Id]
           ,[Name]
           ,[Currency]
		   ,[InventoryID])
     VALUES
           (1,'Rob', 9000, 1)
GO

INSERT INTO [dbo].[Ninja]
           ([Id]
           ,[Name]
           ,[Currency]
		   ,[InventoryID])
     VALUES
           (2,'Daan', 9000, 2)
GO

INSERT INTO [dbo].[Ninja]
           ([Id]
           ,[Name]
           ,[Currency]
		   ,[InventoryID])
     VALUES
           (3,'Piet', 9000, 3)
GO

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
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (1,'Helm','Bronze',200,1,1,1)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (2,'Helm','Iron',800,2,2,2)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (3,'Helm','Gold',1200,3,3,3)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (4,'Helm','Platinum',1400,4,4,4)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (5,'Shoulders','Bronze',200,1,1,1)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (6,'Shoulders','Iron',800,2,2,2)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (7,'Shoulders','Gold',1200,3,3,3)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (8,'Shoulders','Platinum',1400,4,4,4)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (9,'Chest','Bronze',200,1,1,1)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (10,'Chest','Iron',800,2,2,2)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (11,'Chest','Gold',1200,3,3,3)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (12,'Chest','Platinum',1400,4,4,4)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (13,'Belt','Bronze',200,1,1,1)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (14,'Belt','Iron',800,2,2,2)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (15,'Belt','Gold',1200,3,3,3)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (16,'Belt','Platinum',1400,4,4,4)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (17,'Legs','Bronze',200,1,1,1)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (18,'Legs','Iron',800,2,2,2)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (19,'Legs','Gold',1200,3,3,3)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (20,'Legs','Platinum',1400,4,4,4)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (21,'Boots','Bronze',200,1,1,1)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (22,'Boots','Iron',800,2,2,2)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (23,'Boots','Gold',1200,3,3,3)
GO

INSERT INTO [dbo].[Equipment] ([Id],[Category],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (24,'Boots','Platinum',1400,4,4,4)
GO
