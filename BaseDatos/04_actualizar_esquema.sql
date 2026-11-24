SET NAMES utf8mb4;

USE Intercambio_libros;

ALTER TABLE Usuario
    ADD COLUMN IF NOT EXISTS RutaImagen VARCHAR(260) NOT NULL DEFAULT '' AFTER ContrasenaHash;

ALTER TABLE Libro
    ADD COLUMN IF NOT EXISTS IdPropietario INT NULL AFTER PuntoEntrega;

-- Revisión (solo lectura): ID universitario con más de 9 caracteres
SELECT IdUsuario, Email, IdUniversitario
FROM   Usuario
WHERE  CHAR_LENGTH(IdUniversitario) > 9;