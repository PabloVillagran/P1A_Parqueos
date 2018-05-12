-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 12, 2018 at 02:24 AM
-- Server version: 10.1.30-MariaDB
-- PHP Version: 7.2.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `estacionamiento`
--

-- --------------------------------------------------------

--
-- Table structure for table `estacionamiento`
--

CREATE TABLE `estacionamiento` (
  `id` int(11) NOT NULL,
  `direccion` varchar(255) DEFAULT NULL,
  `espacio` decimal(10,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `movimiento_transaccion`
--

CREATE TABLE `movimiento_transaccion` (
  `serie` int(11) NOT NULL,
  `folio` varchar(8) NOT NULL,
  `correlativo` int(11) NOT NULL,
  `hora` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `tipo` enum('entrada','salida') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tarifa`
--

CREATE TABLE `tarifa` (
  `id` int(11) NOT NULL,
  `id_tipo_vehiculo` int(11) NOT NULL,
  `id_tiempo_tarifa` int(11) NOT NULL,
  `id_estacionamiento` int(11) NOT NULL,
  `descripcion` varchar(512) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tiempo_tarifa`
--

CREATE TABLE `tiempo_tarifa` (
  `id` int(11) NOT NULL,
  `factor_tarifa` decimal(10,2) NOT NULL,
  `descripcion` varchar(512) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tipo_vehiculo`
--

CREATE TABLE `tipo_vehiculo` (
  `id` int(11) NOT NULL,
  `formato_placa` varchar(512) NOT NULL,
  `espacio` decimal(10,2) DEFAULT NULL,
  `factor_tarifa` decimal(10,2) NOT NULL,
  `descripcion` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tipo_vehiculo`
--

INSERT INTO `tipo_vehiculo` (`id`, `formato_placa`, `espacio`, `factor_tarifa`, `descripcion`) VALUES
(2, 'PBBB000', '7.00', '1.00', 'Sedán'),
(4, 'MBBB000', '2.00', '0.50', 'Motos'),
(6, 'asdf', '2.00', '2.00', 'asddf'),
(7, 'asdf', '2.00', '2.00', 'asddf'),
(8, 'asdf', '6.00', '5.00', 'test'),
(9, 'asdf', '52.00', '12.00', 'test3');

-- --------------------------------------------------------

--
-- Table structure for table `transaccion`
--

CREATE TABLE `transaccion` (
  `serie` int(11) NOT NULL,
  `folio` varchar(8) NOT NULL,
  `correlativo` int(11) NOT NULL,
  `id_tarifa` int(11) NOT NULL,
  `monto_total` double NOT NULL,
  `hist_tarifa_vehiculo` decimal(10,2) NOT NULL,
  `hist_tarifa_tiempo` decimal(10,2) NOT NULL,
  `u_estacionamiento` int(11) NOT NULL,
  `u_sector` varchar(16) NOT NULL,
  `u_numero` int(11) NOT NULL,
  `placa_vehiculo_cliente` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `ubicacion`
--

CREATE TABLE `ubicacion` (
  `id_estacionamiento` int(11) NOT NULL,
  `sector` varchar(16) NOT NULL,
  `numero` int(11) NOT NULL,
  `id_tipo_vehiculo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `vehiculo_cliente`
--

CREATE TABLE `vehiculo_cliente` (
  `placa` varchar(32) NOT NULL,
  `nit` varchar(32) NOT NULL,
  `nombre` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `estacionamiento`
--
ALTER TABLE `estacionamiento`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `movimiento_transaccion`
--
ALTER TABLE `movimiento_transaccion`
  ADD PRIMARY KEY (`serie`,`folio`,`correlativo`,`hora`);

--
-- Indexes for table `tarifa`
--
ALTER TABLE `tarifa`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_tiempo_tarifa` (`id_tiempo_tarifa`),
  ADD KEY `fk_tipo_vehiculo` (`id_tipo_vehiculo`),
  ADD KEY `fk_estacionamiento` (`id_estacionamiento`);

--
-- Indexes for table `tiempo_tarifa`
--
ALTER TABLE `tiempo_tarifa`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tipo_vehiculo`
--
ALTER TABLE `tipo_vehiculo`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `transaccion`
--
ALTER TABLE `transaccion`
  ADD PRIMARY KEY (`serie`,`folio`,`correlativo`),
  ADD KEY `id_tarifa` (`id_tarifa`),
  ADD KEY `placa_vehiculo_cliente` (`placa_vehiculo_cliente`),
  ADD KEY `u_estacionamiento` (`u_estacionamiento`,`u_sector`,`u_numero`);

--
-- Indexes for table `ubicacion`
--
ALTER TABLE `ubicacion`
  ADD PRIMARY KEY (`id_estacionamiento`,`sector`,`numero`),
  ADD KEY `id_tipo_vehiculo` (`id_tipo_vehiculo`);

--
-- Indexes for table `vehiculo_cliente`
--
ALTER TABLE `vehiculo_cliente`
  ADD PRIMARY KEY (`placa`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `estacionamiento`
--
ALTER TABLE `estacionamiento`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tarifa`
--
ALTER TABLE `tarifa`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tiempo_tarifa`
--
ALTER TABLE `tiempo_tarifa`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tipo_vehiculo`
--
ALTER TABLE `tipo_vehiculo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `movimiento_transaccion`
--
ALTER TABLE `movimiento_transaccion`
  ADD CONSTRAINT `movimiento_transaccion_ibfk_1` FOREIGN KEY (`serie`,`folio`,`correlativo`) REFERENCES `transaccion` (`serie`, `folio`, `correlativo`);

--
-- Constraints for table `tarifa`
--
ALTER TABLE `tarifa`
  ADD CONSTRAINT `fk_estacionamiento` FOREIGN KEY (`id_estacionamiento`) REFERENCES `estacionamiento` (`id`),
  ADD CONSTRAINT `fk_tiempo_tarifa` FOREIGN KEY (`id_tiempo_tarifa`) REFERENCES `tiempo_tarifa` (`id`),
  ADD CONSTRAINT `fk_tipo_vehiculo` FOREIGN KEY (`id_tipo_vehiculo`) REFERENCES `tipo_vehiculo` (`id`);

--
-- Constraints for table `transaccion`
--
ALTER TABLE `transaccion`
  ADD CONSTRAINT `transaccion_ibfk_1` FOREIGN KEY (`id_tarifa`) REFERENCES `tarifa` (`id`),
  ADD CONSTRAINT `transaccion_ibfk_2` FOREIGN KEY (`placa_vehiculo_cliente`) REFERENCES `vehiculo_cliente` (`placa`),
  ADD CONSTRAINT `transaccion_ibfk_3` FOREIGN KEY (`u_estacionamiento`,`u_sector`,`u_numero`) REFERENCES `ubicacion` (`id_estacionamiento`, `sector`, `numero`);

--
-- Constraints for table `ubicacion`
--
ALTER TABLE `ubicacion`
  ADD CONSTRAINT `ubicacion_ibfk_1` FOREIGN KEY (`id_estacionamiento`) REFERENCES `estacionamiento` (`id`),
  ADD CONSTRAINT `ubicacion_ibfk_2` FOREIGN KEY (`id_tipo_vehiculo`) REFERENCES `tipo_vehiculo` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
