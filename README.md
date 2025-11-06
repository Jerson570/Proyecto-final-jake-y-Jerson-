# GreenCity Builder

## Descripcion
En GreenCity Builder, el usuario se convierte en el planificador principal de una ciudad con el reto de construirla de forma sostenible. A lo largo del juego se va tomando decisiones clave, cómo gestionar los recursos disponibles como energía, agua, alimentos y áreas verdes, y cómo responder a situaciones imprevistas. El objetivo no solo es ampliar la ciudad, sino hacerlo cuidando el equilibrio entre el desarrollo económico. Cada acción que se toma tiene repercusiones tanto positivas como negativas, por lo que el desafío consiste en encontrar la mejor manera de mantener la ciudad en balance y asegurar su crecimiento responsable.

## Objetivo
Completar un flujo UI → Lógica → BD usando patrones de diseño (Singleton, Repository, Factory) y una base de datos en SQL Server.

## Reglas de Negocio 
-	No se puede construir un nuevo edificio sin suficientes recursos disponibles.
- Cada edificio impacta positiva o negativamente uno o más recursos.
-	La población necesita un mínimo nivel de energía, agua y alimentos para crecer.
-	Si el nivel de contaminación supera el 70%, se bloquea la construcción de fábricas.
-	Si el nivel de contaminación supera el 70%, se bloquea la construcción de fábricas.
-	Si el nivel de contaminación supera el 70%, se bloquea la construcción de fábricas.
-	Si el nivel de contaminación supera el 70%, se bloquea la construcción de fábricas.
-	Si el nivel de contaminación supera el 70%, se bloquea la construcción de fábricas.
-	Si el nivel de contaminación supera el 70%, se bloquea la construcción de fábricas.
-	Si el nivel de contaminación supera el 70%, se bloquea la construcción de fábricas.

## Funcionalidades 
-	Si el nivel de contaminación supera el 70%, se bloquea la construcción de fábricas.
-	Visualizar el estado actual de la ciudad y los recursos mediante gráficos simples y mensajes de retroalimentación.

## Ejecución
1. Abrir la solución en Visual Studio
2. Revisar en "DbConnectionSingleton.cs" la cadena de conexión
3. Ejecutar el proyecto
4. Desde el formulario principal navegar a **Ciudades**, **Edificios** y **Recursos**
5. Probar los 3 casos de prueba
6. Verificar que los datos están en SQL Server

## Controles usados
- "DataGridView" – listado de ciudades
- "TextBox" – nombre de ciudad y edificio
- "ComboBox" – selección de ciudad y tipo de edificio
- "NumericUpDown" – población, sostenibilidad, contaminación, costo
- "Button" – acciones de guardar/crear
- "MessageBox.Show" – retroalimentación

## Arquitectura
- Capa de presentación: Windows Forms (.NET Framework)
- Capa de dominio: entidades (Ciudad, Recurso, CiudadRecurso, EdificioBase, EdificioResidencial, EdificioIndustrial, EdificioVerde, Evento)
- Capa de datos: Repositorios + Singleton de conexión
- Patrones: Singleton (conexión), Repository (3 repos), Factory (creación de edificios)

## Script SQL

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

--(relación N:N entre Ciudad y Recurso)
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
VALUES
('Green City', 75, 50000, 40),
('Eco Valley', 60, 30000, 20);

INSERT INTO Recurso (Nombre, Unidad)
VALUES
('Agua', 'm3'),
('Energia', 'kWh'),
('Alimentos', 'kg'),
('Areas Verdes', 'm2');

INSERT INTO CiudadRecurso (IdCiudad, IdRecurso, CantidadActual, CantidadMaxima)
VALUES
(1, 1, 800, 1000),
(1, 2, 1200, 2000),
(1, 3, 500, 1000),
(1, 4, 400, 800),
(2, 1, 400, 1000);

INSERT INTO TipoEdificio (Nombre, CostoBase, ImpactoEnergia, ImpactoAgua, ImpactoAlimentos, ImpactoContaminacion)
VALUES
('Residencial', 500, 50, 20, -10, 5),
('Industrial', 900, 150, 60, 0, 40),
('Verde', 600, -30, -10, 0, -30);

INSERT INTO Edificio (IdCiudad, IdTipoEdificio, Nombre)
VALUES
(1, 1, 'Residencial A'),
(1, 3, 'Parque Central');

## Capturas 

- Principal:


<img width="1184" height="821" alt="image" src="https://github.com/user-attachments/assets/97ca56bd-ef03-4740-9d44-16155049f5bc" />


- Crear Ciudad:


<img width="1146" height="806" alt="image" src="https://github.com/user-attachments/assets/198544df-4887-47b9-9ead-639f62ee31e0" />


- Crear Edificios:


<img width="1536" height="918" alt="image" src="https://github.com/user-attachments/assets/acea017b-2406-413f-9b57-892a5224a70e" />


-Ver Recursos:


<img width="1530" height="819" alt="image" src="https://github.com/user-attachments/assets/f76622cb-990b-40b6-a9e0-c34ac83fa3ea" />



## Integrantes
- Jakeline Rios Acevedo – Lógica de negocio, formularios y documentación.
- Jerson Mateo Mendoza – Modelo de datos, repositorios y pruebas.
- Docente: Msc. Alexandra Guerrero Bocanegra
- Programa: Ingeniería de Software – Institución Universitaria Pascual Bravo


