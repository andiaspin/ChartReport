-- phpMyAdmin SQL Dump
-- version 2.10.3
-- http://www.phpmyadmin.net
-- 
-- Host: localhost
-- Generation Time: Dec 23, 2017 at 02:29 AM
-- Server version: 5.0.51
-- PHP Version: 5.2.6

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";

-- 
-- Database: `test`
-- 

-- --------------------------------------------------------

-- 
-- Table structure for table `penjualan`
-- 

CREATE TABLE `penjualan` (
  `KODE` varchar(10) NOT NULL,
  `NAMA` varchar(20) NOT NULL,
  `HARGA_BELI` int(10) NOT NULL,
  `HARGA_JUAL` int(10) NOT NULL,
  `JUMLAH` int(10) NOT NULL,
  `TOTAL` int(10) NOT NULL,
  `TANGGAL` date NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table `penjualan`
-- 

INSERT INTO `penjualan` VALUES ('BRG01', 'SHAMPO', 5000, 6000, 2, 12000, '2017-12-04');
INSERT INTO `penjualan` VALUES ('BRG02', 'SABUN', 3000, 5000, 10, 50000, '2017-12-04');
INSERT INTO `penjualan` VALUES ('BRG03', 'MINYAK', 8000, 9000, 2, 18000, '2018-03-15');
INSERT INTO `penjualan` VALUES ('BRG04', 'TEPUNG', 10000, 12000, 4, 48000, '2018-05-10');
INSERT INTO `penjualan` VALUES ('BRG05', 'SUSU', 4500, 5000, 5, 25000, '2017-12-04');
INSERT INTO `penjualan` VALUES ('BRG06', 'KOPI', 7000, 9000, 3, 27000, '2017-12-04');
INSERT INTO `penjualan` VALUES ('BRG07', 'KERUPUK', 4000, 6000, 2, 12000, '2017-12-31');
INSERT INTO `penjualan` VALUES ('BRG08', 'ICE CREAM', 7000, 9000, 4, 36000, '2017-12-31');
