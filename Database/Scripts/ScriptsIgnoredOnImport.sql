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

SET IDENTITY_INSERT [dbo].[Category] OFF
GO

USE [Entities]
GO

SET IDENTITY_INSERT [dbo].[Ninja] ON
GO

INSERT INTO [dbo].[Ninja]
           ([Id]
           ,[Name]
           ,[Currency])
     VALUES
           (1,'Rob', 9000)
GO

INSERT INTO [dbo].[Ninja]
           ([Id]
           ,[Name]
           ,[Currency])
     VALUES
           (2,'Daan', 9000)
GO

INSERT INTO [dbo].[Ninja]
           ([Id]
           ,[Name]
           ,[Currency])
     VALUES
           (3,'Piet', 9000)
GO

INSERT INTO [dbo].[Ninja]
           ([Id]
           ,[Name]
           ,[Currency])
     VALUES
           (4,'Ethiopie', 9000)
GO

SET IDENTITY_INSERT [dbo].[Ninja] OFF
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

SET IDENTITY_INSERT [dbo].[Category] OFF
GO

USE [Entities]
GO

SET IDENTITY_INSERT [dbo].[Equipment] ON
GO


INSERT INTO [dbo].[Equipment] ([Id],[CategoryID],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (1,1,'Bronze',200,1,1,1)
GO

INSERT INTO [dbo].[Equipment] ([Id],[CategoryID],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (2,1,'Iron',800,2,2,2)
GO

INSERT INTO [dbo].[Equipment] ([Id],[CategoryID],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (3,1,'Gold',1200,3,3,3)
GO

INSERT INTO [dbo].[Equipment] ([Id],[CategoryID],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (4,1,'Platinum',1400,4,4,4)
GO

INSERT INTO [dbo].[Equipment] ([Id],[CategoryID],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (5,2,'Bronze',200,1,1,1)
GO

INSERT INTO [dbo].[Equipment] ([Id],[CategoryID],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (6,2,'Iron',800,2,2,2)
GO

INSERT INTO [dbo].[Equipment] ([Id],[CategoryID],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (7,2,'Gold',1200,3,3,3)
GO

INSERT INTO [dbo].[Equipment] ([Id],[CategoryID],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (8,2,'Platinum',1400,4,4,4)
GO

INSERT INTO [dbo].[Equipment] ([Id],[CategoryID],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (9,3,'Bronze',200,1,1,1)
GO

INSERT INTO [dbo].[Equipment] ([Id],[CategoryID],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (10,3,'Iron',800,2,2,2)
GO

INSERT INTO [dbo].[Equipment] ([Id],[CategoryID],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (11,3,'Gold',1200,3,3,3)
GO

INSERT INTO [dbo].[Equipment] ([Id],[CategoryID],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (12,3,'Platinum',1400,4,4,4)
GO

INSERT INTO [dbo].[Equipment] ([Id],[CategoryID],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (13,4,'Bronze',200,1,1,1)
GO

INSERT INTO [dbo].[Equipment] ([Id],[CategoryID],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (14,4,'Iron',800,2,2,2)
GO

INSERT INTO [dbo].[Equipment] ([Id],[CategoryID],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (15,4,'Gold',1200,3,3,3)
GO

INSERT INTO [dbo].[Equipment] ([Id],[CategoryID],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (16,4,'Platinum',1400,4,4,4)
GO

INSERT INTO [dbo].[Equipment] ([Id],[CategoryID],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (17,5,'Bronze',200,1,1,1)
GO

INSERT INTO [dbo].[Equipment] ([Id],[CategoryID],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (18,5,'Iron',800,2,2,2)
GO

INSERT INTO [dbo].[Equipment] ([Id],[CategoryID],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (19,5,'Gold',1200,3,3,3)
GO

INSERT INTO [dbo].[Equipment] ([Id],[CategoryID],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (20,5,'Platinum',1400,4,4,4)
GO

INSERT INTO [dbo].[Equipment] ([Id],[CategoryID],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (21,6,'Bronze',200,1,1,1)
GO

INSERT INTO [dbo].[Equipment] ([Id],[CategoryID],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (22,6,'Iron',800,2,2,2)
GO

INSERT INTO [dbo].[Equipment] ([Id],[CategoryID],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (23,6,'Gold',1200,3,3,3)
GO

INSERT INTO [dbo].[Equipment] ([Id],[CategoryID],[Name],[Price],[Agility],[Strenght],[Intelligence])
     VALUES (24,6,'Platinum',1400,4,4,4)
GO

SET IDENTITY_INSERT [dbo].[Equipment] OFF
GO
