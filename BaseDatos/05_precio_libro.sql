SET NAMES utf8mb4;

USE Intercambio_libros;

ALTER TABLE Libro
    ADD COLUMN IF NOT EXISTS Precio DECIMAL(10,2) NOT NULL DEFAULT 0 AFTER PuntoEntrega;
UPDATE Libro
SET    Precio = 120 + (IdLibro MOD 7) * 30
WHERE  Precio = 0;

SELECT IdLibro, Titulo, Precio FROM Libro ORDER BY IdLibro;
