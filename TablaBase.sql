-- CREATE DATABASE Sistem_Fact;
-- USE Sistem_Fact;

-- -- Tabla Rol
-- CREATE TABLE Rol (
--   id INT PRIMARY KEY AUTO_INCREMENT,
--   description VARCHAR(255),
--   isActive BOOLEAN,
--   name VARCHAR(50)
-- );

-- Tabla Vista
CREATE TABLE Vista (
  id INT PRIMARY KEY AUTO_INCREMENT,
  nombre VARCHAR(50)
);

-- Tabla Rol_Vista (relación muchos-a-muchos entre Rol y Vista)
CREATE TABLE Rol_Vista (
  rol_id INT,
  vista_id INT,
  PRIMARY KEY (rol_id, vista_id),
  FOREIGN KEY (rol_id) REFERENCES Rol(id),
  FOREIGN KEY (vista_id) REFERENCES Vista(id)
);

-- Tabla Inventario
CREATE TABLE Inventario (
  id INT PRIMARY KEY AUTO_INCREMENT,
  codigo VARCHAR(10),
  nombre VARCHAR(225),
  precio DECIMAL(10, 2),
  cantidad INT,
  descripcion TEXT,
  fecha DATE
);

-- Tabla Usuario
CREATE TABLE Usuario (
  id INT PRIMARY KEY AUTO_INCREMENT,
  cedula VARCHAR(10),
  avatar VARCHAR(255),
  nombre VARCHAR(225),
  rol_id INT,
  correo VARCHAR(255),
  contrasena VARCHAR(255),
  activo BOOLEAN,
  FOREIGN KEY (rol_id) REFERENCES Rol(id)
);

-- Tabla Empresa
CREATE TABLE Empresa (
  id INT PRIMARY KEY AUTO_INCREMENT,
  address VARCHAR(255),
  email VARCHAR(255),
  logo VARCHAR(255),
  name VARCHAR(100),
  phone_code VARCHAR(5),
  phone_country VARCHAR(100),
  phone_flag VARCHAR(255),
  phone_full VARCHAR(20),
  phone_iso VARCHAR(3)
);

-- Tabla Ventas
CREATE TABLE Ventas (
  id INT PRIMARY KEY AUTO_INCREMENT,
  cantidad INT,
  fecha DATE,
  forma_pago VARCHAR(50),
  nombre_cliente VARCHAR(225),
  producto VARCHAR(100),
  total DECIMAL(10,2),
  producto_id INT,
  usuario_id INT,
  FOREIGN KEY (producto_id) REFERENCES Inventario(id),
  FOREIGN KEY (usuario_id) REFERENCES Usuario(id)
);

-- Tabla Notificaciones
CREATE TABLE Notificaciones (
  id INT PRIMARY KEY AUTO_INCREMENT,
  fecha DATETIME,
  details TEXT,
  title VARCHAR(100),
  type VARCHAR(50),
  producto_id INT,
  FOREIGN KEY (producto_id) REFERENCES Inventario(id)
);