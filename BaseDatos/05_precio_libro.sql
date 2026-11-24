-- A4.7 Carrito de compras: el catálogo necesitaba un precio por libro.
-- Equipo #2 | NUÑEZ Martinez Marco Antonio, SUÑIGA Maciel Joule Alexander, VILLA Olivares Ariel
-- Es seguro ejecutarlo varias veces: no borra nada.
SET NAMES utf8mb4;

USE Intercambio_libros;

ALTER TABLE Libro
    ADD COLUMN IF NOT EXISTS Precio DECIMAL(10,2) NOT NULL DEFAULT 0 AFTER PuntoEntrega;

-- Precios de ejemplo solo para los libros que todavía no tienen uno (entre 120 y 300).
UPDATE Libro
SET    Precio = 120 + (IdLibro MOD 7) * 30
WHERE  Precio = 0;

-- Revisión (solo lectura)
SELECT IdLibro, Titulo, Precio FROM Libro ORDER BY IdLibro;
