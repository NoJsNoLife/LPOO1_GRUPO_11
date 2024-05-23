CREATE TABLE [dbo].[Table]
(
	[Atl_ID] INT NOT NULL PRIMARY KEY, 
    [Atl_DNI] VARCHAR(50) NOT NULL, 
    [Atl_Apellido] VARCHAR(50) NOT NULL, 
    [Atl_Nombre] VARCHAR(50) NOT NULL, 
    [Atl_Nacionalidad] VARCHAR(50) NOT NULL, 
    [Atl_Entrenador] VARCHAR(50) NOT NULL, 
    [Atl_Genero] VARCHAR(50) NOT NULL, 
    [Atl_Altura] FLOAT NOT NULL, 
    [Atl_Peso] FLOAT NOT NULL, 
    [Atl_FechaNac] DATETIME NOT NULL, 
    [Atl_Direccion] VARCHAR(50) NOT NULL, 
    [Atl_Email] VARCHAR(50) NOT NULL
)
