CREATE TABLE [dbo].[Weapon]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(30) NOT NULL, 
    [Price] INT NOT NULL, 
    [MinDamage] INT NOT NULL, 
    [MaxDamage] INT NOT NULL
)
