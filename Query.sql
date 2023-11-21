CREATE TABLE Datos (
  Id int NOT NULL IDENTITY,
  NombreMascota varchar(50) NOT NULL,
  ApellidoMascota varchar(50) NOT NULL,
  Raza varchar(50) NOT NULL,
  FechaNacimientoMascota date NOT NULL,
  NumeroContacto varchar(15) NOT NULL
);