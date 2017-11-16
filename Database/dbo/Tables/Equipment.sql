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