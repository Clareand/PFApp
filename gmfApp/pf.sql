-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 09, 2018 at 06:38 AM
-- Server version: 10.1.28-MariaDB
-- PHP Version: 7.1.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pf`
--

-- --------------------------------------------------------

--
-- Table structure for table `alternatif`
--

CREATE TABLE `alternatif` (
  `id_alt` int(20) NOT NULL,
  `id_material` int(20) NOT NULL,
  `alt_material` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `alternatif`
--

INSERT INTO `alternatif` (`id_alt`, `id_material`, `alt_material`) VALUES
(10001, 101, 'AX111'),
(10002, 101, 'AX112'),
(10004, 102, 'AC123'),
(10005, 103, 'AC124');

-- --------------------------------------------------------

--
-- Table structure for table `equipment`
--

CREATE TABLE `equipment` (
  `id_equipment` int(20) NOT NULL,
  `id_material` int(20) NOT NULL,
  `partNum_equipment` varchar(20) NOT NULL,
  `equipment_desc` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `equipment`
--

INSERT INTO `equipment` (`id_equipment`, `id_material`, `partNum_equipment`, `equipment_desc`) VALUES
(1001, 101, 'X452', NULL),
(1002, 101, 'X453', 'bla bla '),
(1004, 102, 'VT73', NULL),
(1005, 102, 'VX65', NULL),
(1006, 103, 'DX67', NULL),
(1007, 103, 'WX092', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `material`
--

CREATE TABLE `material` (
  `id_material` int(20) NOT NULL,
  `part_number` varchar(20) NOT NULL,
  `material_type` varchar(20) DEFAULT NULL,
  `material_desc` varchar(50) DEFAULT NULL,
  `material_remarks` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `material`
--

INSERT INTO `material` (`id_material`, `part_number`, `material_type`, `material_desc`, `material_remarks`) VALUES
(101, 'A', 'oil filter', 'inner filter', NULL),
(102, 'B', 'air filter', 'outer filter', NULL),
(103, 'C', 'other filter', 'inside fiter', NULL),
(104, 'A111', 'Oil Filter', 'inner filter', NULL),
(105, 'A112', 'Oil Filter', 'inner filter', NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `alternatif`
--
ALTER TABLE `alternatif`
  ADD PRIMARY KEY (`id_alt`),
  ADD KEY `alt_material` (`alt_material`),
  ADD KEY `alternatif_ibfk_1` (`id_material`);

--
-- Indexes for table `equipment`
--
ALTER TABLE `equipment`
  ADD PRIMARY KEY (`id_equipment`),
  ADD KEY `fk_equipment` (`id_material`);

--
-- Indexes for table `material`
--
ALTER TABLE `material`
  ADD PRIMARY KEY (`id_material`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `alternatif`
--
ALTER TABLE `alternatif`
  MODIFY `id_alt` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10006;

--
-- AUTO_INCREMENT for table `equipment`
--
ALTER TABLE `equipment`
  MODIFY `id_equipment` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1008;

--
-- AUTO_INCREMENT for table `material`
--
ALTER TABLE `material`
  MODIFY `id_material` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=106;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `alternatif`
--
ALTER TABLE `alternatif`
  ADD CONSTRAINT `alternatif_ibfk_1` FOREIGN KEY (`id_material`) REFERENCES `material` (`id_material`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `equipment`
--
ALTER TABLE `equipment`
  ADD CONSTRAINT `fk_equipment` FOREIGN KEY (`id_material`) REFERENCES `material` (`id_material`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
