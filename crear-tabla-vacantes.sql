-- 1. Crear la base de datos 
CREATE DATABASE RoiSoftwareDb;
GO

-- 2. Decirle a SQL que use esta nueva base de datos
USE RoiSoftwareDb;
GO

-- 3. Crear la tabla 'Vacantes' con el tipo decimal para finanzas
CREATE TABLE Vacantes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Titulo VARCHAR(250) NOT NULL,
    Empresa VARCHAR(150) NOT NULL,
    Plataforma VARCHAR(50) NOT NULL, -- LinkedIn, Indeed, etc.
    
    -- Variables econométricas con precisión decimal (18 dígitos, 2 decimales)
    SueldoMaximo DECIMAL(18,2) NOT NULL,
    SueldoMinimo DECIMAL(18,2) NOT NULL,
    NivelIngles VARCHAR(50) NOT NULL, -- Inicial, Intermedio, Avanzado
    
    TecnologiasRequeridas VARCHAR(MAX) NOT NULL, -- Lista de tecnologías
    FechaExtraccion DATETIME DEFAULT GETDATE() NOT NULL
);
GO
