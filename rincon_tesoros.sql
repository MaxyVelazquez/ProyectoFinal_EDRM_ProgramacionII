-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 14-12-2024 a las 19:37:06
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `rincon_tesoros`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `juguetes`
--

CREATE TABLE `juguetes` (
  `Nombre` varchar(50) NOT NULL,
  `Id` int(11) NOT NULL,
  `Precio` float NOT NULL,
  `Existencia` int(11) DEFAULT NULL,
  `Promocion` tinyint(1) NOT NULL,
  `imagen` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `juguetes`
--

INSERT INTO `juguetes` (`Nombre`, `Id`, `Precio`, `Existencia`, `Promocion`, `imagen`) VALUES
('Batmovil', 13, 1349, 10, 0, 'batiAutomovil.png'),
('Chucky', 19, 14999, 1, 0, 'chuckyDeCocobongo.png'),
('Disney´s Wall-E', 21, 599, 9, 0, 'walle.png'),
('Fire Bike', 9, 1899, 5, 1, 'bici.png'),
('Golden Power Ranger', 10, 499, 4, 0, 'powerRanger.png'),
('Max Steel', 2, 749, 10, 0, 'maxSteel.png'),
('Miles Morales', 11, 599, 10, 1, 'spider-Man.png'),
('Nerf Strike', 3, 899, 10, 1, 'pistolita.png'),
('Star Wars Sable de Luz Verde', 4, 1249, 10, 1, 'sable-StarWrs.png'),
('Terreneitor', 18, 1299, 6, 0, 'terreneitor.png');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `User` varchar(50) NOT NULL,
  `Contraseña` varchar(50) NOT NULL,
  `id` int(11) DEFAULT NULL,
  `Nombre` varchar(60) NOT NULL,
  `monto` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`User`, `Contraseña`, `id`, `Nombre`, `monto`) VALUES
('Admin', 'RinconTesoros1234', 0, 'Admin', 0),
('DiegoDelgado', 'RachelMcAdams', 300435, 'DiegoAbrahamDelgadoRodriguez', 0),
('EmilioAvila', 'PanTostado', 301246, 'JorgeEmilioAvilaValadez', 0),
('MaxyVelazquez', 'ConitoFresa', 301026, 'MaxyEmilianoVelazquezCuellar', 0),
('ReyPicazo', 'Tupulainas', 300388, 'ReyEmmanuelPicazoPerez', 0);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `juguetes`
--
ALTER TABLE `juguetes`
  ADD PRIMARY KEY (`Nombre`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`User`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
