-- Actividad 4.8 - Persistencia transaccional de pedidos (relación 1:N)
--   Equipo #2
--   NUÑEZ Martinez Marco Antonio
--   SUÑIGA Maciel Joule Alexander
--   VILLA Olivares Ariel
-- =============================================================
SET NAMES utf8mb4;

USE Intercambio_libros;

-- El UNO: encabezado del pedido. IdPedido lo genera el servidor (AUTO_INCREMENT)
-- y la app lo recupera con SELECT LAST_INSERT_ID().
CREATE TABLE IF NOT EXISTS Pedidos
(
    IdPedido  INT           NOT NULL AUTO_INCREMENT,
    Fecha     DATETIME      NOT NULL DEFAULT CURRENT_TIMESTAMP,
    IdUsuario INT           NULL,
    Cliente   VARCHAR(121)  NOT NULL,
    Total     DECIMAL(12,2) NOT NULL,

    CONSTRAINT PK_Pedidos         PRIMARY KEY (IdPedido),
    CONSTRAINT FK_Pedidos_Usuario FOREIGN KEY (IdUsuario) REFERENCES Usuario (IdUsuario),
    CONSTRAINT CK_Pedidos_Cliente CHECK (CHAR_LENGTH(TRIM(Cliente)) > 0),
    CONSTRAINT CK_Pedidos_Total   CHECK (Total >= 0)
) ENGINE = InnoDB;

-- Los MUCHOS: una fila por línea del carrito.
CREATE TABLE IF NOT EXISTS Detalles_Pedidos
(
    IdDetalle      INT           NOT NULL AUTO_INCREMENT,
    IdPedido       INT           NOT NULL,
    IdLibro        INT           NOT NULL,
    Condicion      VARCHAR(10)   NOT NULL DEFAULT '',
    Cantidad       INT           NOT NULL,
    PrecioUnitario DECIMAL(10,2) NOT NULL,

    CONSTRAINT PK_Detalles_Pedidos        PRIMARY KEY (IdDetalle),
    CONSTRAINT FK_Detalles_Pedidos_Pedido FOREIGN KEY (IdPedido) REFERENCES Pedidos (IdPedido),
    CONSTRAINT FK_Detalles_Pedidos_Libro  FOREIGN KEY (IdLibro)  REFERENCES Libro (IdLibro),
    CONSTRAINT CK_Detalles_Pedidos_Cant   CHECK (Cantidad > 0),
    CONSTRAINT CK_Detalles_Pedidos_Precio CHECK (PrecioUnitario >= 0)
) ENGINE = InnoDB;

SELECT 'Tablas Pedidos y Detalles_Pedidos listas.' AS Resultado;
