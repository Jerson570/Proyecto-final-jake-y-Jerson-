-- Script_Final.sql (completo)
CREATE DATABASE GreenCityDB;
GO
USE GreenCityDB;
GO

CREATE TABLE Ciudad (
    IdCiudad INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(80) NOT NULL,
    NivelSostenibilidad INT NOT NULL,
    Poblacion INT NOT NULL,
    Contaminacion INT NOT NULL
);

CREATE TABLE Recurso (
    IdRecurso INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    Unidad VARCHAR(20) NOT NULL
);

CREATE TABLE CiudadRecurso (
    IdCiudad INT NOT NULL,
    IdRecurso INT NOT NULL,
    CantidadActual INT NOT NULL,
    CantidadMaxima INT NOT NULL,
    CONSTRAINT PK_CiudadRecurso PRIMARY KEY (IdCiudad, IdRecurso),
    CONSTRAINT FK_CiudadRecurso_Ciudad FOREIGN KEY (IdCiudad) REFERENCES Ciudad(IdCiudad),
    CONSTRAINT FK_CiudadRecurso_Recurso FOREIGN KEY (IdRecurso) REFERENCES Recurso(IdRecurso)
);

CREATE TABLE TipoEdificio (
    IdTipoEdificio INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(60) NOT NULL,
    CostoBase INT NOT NULL,
    ImpactoEnergia INT NOT NULL,
    ImpactoAgua INT NOT NULL,
    ImpactoAlimentos INT NOT NULL,
    ImpactoContaminacion INT NOT NULL
);

CREATE TABLE Edificio (
    IdEdificio INT IDENTITY(1,1) PRIMARY KEY,
    IdCiudad INT NOT NULL,
    IdTipoEdificio INT NOT NULL,
    Nombre VARCHAR(80) NOT NULL,
    FechaConstruccion DATE NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_Edificio_Ciudad FOREIGN KEY (IdCiudad) REFERENCES Ciudad(IdCiudad),
    CONSTRAINT FK_Edificio_TipoEdificio FOREIGN KEY (IdTipoEdificio) REFERENCES TipoEdificio(IdTipoEdificio)
);

INSERT INTO Ciudad (Nombre, NivelSostenibilidad, Poblacion, Contaminacion)
VALUES ('Green City', 75, 50000, 40),
       ('Eco Valley', 60, 30000, 20);

INSERT INTO Recurso (Nombre, Unidad)
VALUES ('Agua', 'm3'),
       ('Energia', 'kWh'),
       ('Alimentos', 'kg'),
       ('Areas Verdes', 'm2');

INSERT INTO CiudadRecurso (IdCiudad, IdRecurso, CantidadActual, CantidadMaxima)
VALUES (1, 1, 800, 1000),
       (1, 2, 1200, 2000),
       (1, 3, 500, 1000),
       (1, 4, 400, 800),
       (2, 1, 400, 1000);

INSERT INTO TipoEdificio (Nombre, CostoBase, ImpactoEnergia, ImpactoAgua, ImpactoAlimentos, ImpactoContaminacion)
VALUES ('Residencial', 500, 50, 20, -10, 5),
       ('Industrial', 900, 150, 60, 0, 40),
       ('Verde', 600, -30, -10, 0, -30);

INSERT INTO Edificio (IdCiudad, IdTipoEdificio, Nombre)
VALUES (1, 1, 'Residencial A'),
       (1, 3, 'Parque Central');
