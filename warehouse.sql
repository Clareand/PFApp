-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 17, 2018 at 05:52 AM
-- Server version: 10.1.21-MariaDB
-- PHP Version: 7.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `warehouse`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `id_admin` int(10) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`id_admin`, `username`, `password`) VALUES
(1, 'admin', 'admin1');

-- --------------------------------------------------------

--
-- Table structure for table `alternatif`
--

CREATE TABLE `alternatif` (
  `id_alternatif` int(10) NOT NULL,
  `alt_part_number` varchar(20) NOT NULL,
  `alt_brand` varchar(20) NOT NULL,
  `alt_stock` int(10) NOT NULL,
  `alt_um` varchar(20) NOT NULL,
  `alt_type` varchar(20) NOT NULL,
  `alt_location` varchar(50) NOT NULL,
  `alt_remark` longtext
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `alternatif`
--

INSERT INTO `alternatif` (`id_alternatif`, `alt_part_number`, `alt_brand`, `alt_stock`, `alt_um`, `alt_type`, `alt_location`, `alt_remark`) VALUES
(10001, 'AA123', 'Apple', 10, 'pcs', 'internal', 'Jakarta', NULL),
(10002, 'AAA123', 'Apple', 10, 'pcs', 'internal', 'Tangeran', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `alternatif_list`
--

CREATE TABLE `alternatif_list` (
  `id_alternatif_list` int(10) NOT NULL,
  `PKid_material` int(10) NOT NULL,
  `PKid_alternatif` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `alternatif_list`
--

INSERT INTO `alternatif_list` (`id_alternatif_list`, `PKid_material`, `PKid_alternatif`) VALUES
(1, 1000001, 10001),
(2, 1000002, 10002);

-- --------------------------------------------------------

--
-- Table structure for table `equipment`
--

CREATE TABLE `equipment` (
  `id_equipment` int(10) NOT NULL,
  `equipment_name` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `equipment`
--

INSERT INTO `equipment` (`id_equipment`, `equipment_name`) VALUES
(1, 'ACU-AIR COMPRESSOR U'),
(2, 'ASE-AUTOMATIC SERVIC'),
(3, 'ASU-AIR STATER UNIT/'),
(4, 'ATN-AIRCRAFT TOWING '),
(5, 'ATW-AIRCRAFT TOWING '),
(6, 'AWP-AERIAL WORK PLAT'),
(7, 'AWT-AIRCRAFT WASHING'),
(8, 'BTT-BAGGAGE TOWING T'),
(9, 'CUT-CRANE UNIT TRUCK'),
(10, 'FFT-FIRE FIGHTER TRU'),
(11, 'FLT-FORK LIFT'),
(12, 'FST-FUEL SERVICE TRU'),
(13, 'GPU-GROUND POWER UNI'),
(14, 'HPL-HAND PALLET LIFT'),
(15, 'HTC-HYDRAULIC TEST C'),
(16, 'LBT-LOAD BANK TEST'),
(17, 'LST-LAVATORY SERVICE'),
(18, 'MWT-MAINTENANCE WORK'),
(19, 'SPSL-SCISSOR PALLET '),
(20, 'SUC-SWEEPER UNIT CAR'),
(21, 'TUT-TRAILER UNIT TRU'),
(22, 'WPF-WORK PLATFORM'),
(23, 'WST-WATER SERVICE TR'),
(24, 'WUT-WELDING UNIT TRU'),
(25, 'OTHER');

-- --------------------------------------------------------

--
-- Table structure for table `equipment_list`
--

CREATE TABLE `equipment_list` (
  `id_equipment_list` int(10) NOT NULL,
  `PKid_material` int(10) NOT NULL,
  `PKid_equipment` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `equipment_list`
--

INSERT INTO `equipment_list` (`id_equipment_list`, `PKid_material`, `PKid_equipment`) VALUES
(1, 1000001, 1),
(2, 1000001, 2),
(3, 1000002, 3),
(4, 1000002, 4);

-- --------------------------------------------------------

--
-- Table structure for table `material`
--

CREATE TABLE `material` (
  `id_material` int(10) NOT NULL,
  `mat_part_number` varchar(20) NOT NULL,
  `mat_desc` varchar(50) DEFAULT NULL,
  `mat_brand` varchar(20) NOT NULL,
  `mat_stock` int(10) NOT NULL,
  `mat_um` varchar(20) NOT NULL,
  `mat_type` varchar(20) NOT NULL,
  `mat_location` varchar(50) NOT NULL,
  `mat_remark` longtext
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `material`
--

INSERT INTO `material` (`id_material`, `mat_part_number`, `mat_desc`, `mat_brand`, `mat_stock`, `mat_um`, `mat_type`, `mat_location`, `mat_remark`) VALUES
(1000001, 'AA111', 'desc1', 'brand1', 1, 'um1', 'type1', 'loc1', NULL),
(1000002, 'AA222', 'desc2', 'brand2', 2, 'um2', 'type2', 'loc2', NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id_admin`);

--
-- Indexes for table `alternatif`
--
ALTER TABLE `alternatif`
  ADD PRIMARY KEY (`id_alternatif`);

--
-- Indexes for table `alternatif_list`
--
ALTER TABLE `alternatif_list`
  ADD PRIMARY KEY (`id_alternatif_list`),
  ADD KEY `alterTOmat` (`PKid_material`),
  ADD KEY `alterToalter` (`PKid_alternatif`);

--
-- Indexes for table `equipment`
--
ALTER TABLE `equipment`
  ADD PRIMARY KEY (`id_equipment`);

--
-- Indexes for table `equipment_list`
--
ALTER TABLE `equipment_list`
  ADD PRIMARY KEY (`id_equipment_list`),
  ADD KEY `equToMat` (`PKid_material`),
  ADD KEY `PKid_equipment` (`PKid_equipment`);

--
-- Indexes for table `material`
--
ALTER TABLE `material`
  ADD PRIMARY KEY (`id_material`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `id_admin` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `alternatif`
--
ALTER TABLE `alternatif`
  MODIFY `id_alternatif` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10003;
--
-- AUTO_INCREMENT for table `alternatif_list`
--
ALTER TABLE `alternatif_list`
  MODIFY `id_alternatif_list` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `equipment`
--
ALTER TABLE `equipment`
  MODIFY `id_equipment` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;
--
-- AUTO_INCREMENT for table `equipment_list`
--
ALTER TABLE `equipment_list`
  MODIFY `id_equipment_list` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `material`
--
ALTER TABLE `material`
  MODIFY `id_material` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1000003;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `alternatif_list`
--
ALTER TABLE `alternatif_list`
  ADD CONSTRAINT `alterTOmat` FOREIGN KEY (`PKid_material`) REFERENCES `material` (`id_material`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `alterToalter` FOREIGN KEY (`PKid_alternatif`) REFERENCES `alternatif` (`id_alternatif`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `equipment_list`
--
ALTER TABLE `equipment_list`
  ADD CONSTRAINT `equToMat` FOREIGN KEY (`PKid_material`) REFERENCES `material` (`id_material`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `equipment_list_ibfk_1` FOREIGN KEY (`PKid_equipment`) REFERENCES `equipment` (`id_equipment`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
