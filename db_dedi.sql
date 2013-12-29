-- phpMyAdmin SQL Dump
-- version 3.3.9
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Dec 29, 2013 at 01:52 PM
-- Server version: 5.5.8
-- PHP Version: 5.3.5

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `db_dedi`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_barang`
--

CREATE TABLE IF NOT EXISTS `tb_barang` (
  `kd_brg` varchar(15) NOT NULL,
  `nm_brg` varchar(50) NOT NULL,
  `satuan` varchar(15) NOT NULL,
  `jns_brg` varchar(15) NOT NULL,
  `model` varchar(15) NOT NULL,
  `warna` varchar(15) NOT NULL,
  PRIMARY KEY (`kd_brg`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_barang`
--

INSERT INTO `tb_barang` (`kd_brg`, `nm_brg`, `satuan`, `jns_brg`, `model`, `warna`) VALUES
('0001 00001', 'Jepitan Rambut', 'PCS', 'Asesories', 'Mno2', 'Merah'),
('0001 00002', 'Ikat Rambut', 'PCS', 'Asesories', 'Mnod', 'Merah'),
('0001 00003', 'Ikat Pinggang', 'PCS', 'Asesories', 'Mno', 'Merah'),
('0002 00001', 'Sepatu Karrimor', 'PCS', 'Sepatu', 'Cmj', 'Hitam'),
('0002 00002', 'Nike', 'PCS', 'Sepatu', 'Cn0e', 'Hijau Merah'),
('0002 00003', 'Ardiles', 'PCS', 'Sepatu', 'Arr53', 'Biru'),
('0003 00001', 'G-Shok', 'PCS', 'Arloji', 'Cn0e', 'Merah'),
('0003 00002', 'Nixon', 'PCS', 'Arloji', 'Xx9s', 'Silver'),
('0003 00003', 'Quick Silver', 'PCS', 'Arloji', 'Kmd', 'Merah'),
('0004 00001', 'Jaket Consina', 'PCS', 'Jaket', 'Xxxs', 'Merah'),
('0004 00002', 'Rai', 'PCS', 'Jaket', 'Rols', 'Biru'),
('0004 00003', 'The Nort Face', 'PCS', 'Jaket', 'Biasa', 'Merah'),
('0004 00004', 'Rai', 'PCS', 'Jaket', 'Re01', 'Merah');

-- --------------------------------------------------------

--
-- Table structure for table `tb_golongan`
--

CREATE TABLE IF NOT EXISTS `tb_golongan` (
  `kd_gol` varchar(3) NOT NULL,
  `golongan` varchar(25) NOT NULL,
  `Keterangan` varchar(50) NOT NULL,
  PRIMARY KEY (`kd_gol`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_golongan`
--


-- --------------------------------------------------------

--
-- Table structure for table `tb_harga`
--

CREATE TABLE IF NOT EXISTS `tb_harga` (
  `kd_brg` varchar(15) NOT NULL,
  `Stok` int(11) NOT NULL,
  `hrg_beli_satuan` decimal(11,0) NOT NULL,
  `hrg_jual_satuan` decimal(11,0) NOT NULL,
  `Diskon` int(11) NOT NULL,
  PRIMARY KEY (`kd_brg`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_harga`
--

INSERT INTO `tb_harga` (`kd_brg`, `Stok`, `hrg_beli_satuan`, `hrg_jual_satuan`, `Diskon`) VALUES
('0001 00002', 7, 7000, 8000, 0),
('0001 00003', 122, 10000, 20000, 0),
('0002 00001', 11, 250000, 300000, 10),
('0002 00002', 0, 0, 0, 0),
('0002 00003', -8, 20000, 25000, 0),
('0003 00001', 19, 10000, 20000, 0),
('0003 00002', 5, 0, 0, 0),
('0004 00004', 1, 200000, 300000, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tb_jns_brg`
--

CREATE TABLE IF NOT EXISTS `tb_jns_brg` (
  `kd_jns_brg` varchar(5) NOT NULL,
  `jns_brg` varchar(30) NOT NULL,
  PRIMARY KEY (`kd_jns_brg`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_jns_brg`
--

INSERT INTO `tb_jns_brg` (`kd_jns_brg`, `jns_brg`) VALUES
('0001', 'Asesories'),
('0002', 'Sepatu'),
('0003', 'Arloji'),
('0004', 'Jaket'),
('0005', 'Sandal');

-- --------------------------------------------------------

--
-- Table structure for table `tb_pembelian`
--

CREATE TABLE IF NOT EXISTS `tb_pembelian` (
  `no_pembelian` varchar(15) NOT NULL,
  `kd_suplier` varchar(15) NOT NULL,
  `tgl_beli` date NOT NULL,
  `user_id` varchar(10) NOT NULL,
  PRIMARY KEY (`no_pembelian`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_pembelian`
--

INSERT INTO `tb_pembelian` (`no_pembelian`, `kd_suplier`, `tgl_beli`, `user_id`) VALUES
('20131217-0001', 'Spl/0002', '2013-12-17', 'admin'),
('20131217-0002', 'Spl/0003', '2013-12-17', 'admin'),
('20131217-0003', 'Spl/0003', '2013-12-17', 'admin'),
('20131217-0004', 'Spl/0003', '2013-12-17', 'admin'),
('20131217-0005', 'Spl/0002', '2013-12-17', 'admin'),
('20131217-0006', 'Spl/0003', '2013-12-17', 'admin'),
('20131217-0007', 'Spl/0002', '2013-12-17', 'panca'),
('20131222-0008', 'Spl/0004', '2013-12-22', 'PANCA'),
('20131222-0009', 'Spl/0003', '2013-12-22', 'PANCA'),
('20131226-0010', 'Spl/0003', '2013-12-26', 'panca');

-- --------------------------------------------------------

--
-- Table structure for table `tb_pembelian_detail`
--

CREATE TABLE IF NOT EXISTS `tb_pembelian_detail` (
  `no_pembelian` varchar(15) NOT NULL,
  `kd_brg` varchar(10) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `hrg_beli` decimal(11,0) NOT NULL,
  `sub_total` decimal(11,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_pembelian_detail`
--

INSERT INTO `tb_pembelian_detail` (`no_pembelian`, `kd_brg`, `jumlah`, `hrg_beli`, `sub_total`) VALUES
('20131217-0001', '0001 00003', 10, 2000, 20000),
('20131217-0002', '0001 00003', 10, 20000, 200000),
('20131217-0003', '0003 00001', 20, 10000, 200000),
('20131217-0004', '0002 00001', 10, 20000, 200000),
('20131217-0004', '0001 00003', 20, 1200, 24000),
('20131217-0005', '0001 00003', 100, 10000, 1000000),
('20131217-0006', '0002 00003', 3, 20000, 60000),
('20131217-0006', '0002 00002', 1, 200000, 200000),
('20131217-0007', '0002 00001', 1, 400000, 400000),
('20131222-0008', '0003 00002', 5, 10000, 50000),
('20131222-0009', '0002 00002', 6, 10000, 60000),
('20131226-0010', '0004 00004', 1, 200000, 200000);

-- --------------------------------------------------------

--
-- Table structure for table `tb_penjualan`
--

CREATE TABLE IF NOT EXISTS `tb_penjualan` (
  `no_penjualan` varchar(15) NOT NULL,
  `tgl_jual` date NOT NULL,
  `user_id` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`no_penjualan`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_penjualan`
--

INSERT INTO `tb_penjualan` (`no_penjualan`, `tgl_jual`, `user_id`) VALUES
('201312130001', '2013-12-21', 'Panca'),
('201312170001', '2013-12-18', 'Kosong'),
('201312170002', '2013-12-19', 'Panca'),
('201312170003', '2013-12-19', 'Panca'),
('201312170004', '2013-12-17', ''),
('201312170005', '2013-12-17', ''),
('201312180001', '2013-12-18', ''),
('201312180002', '2013-12-18', ''),
('201312180003', '2013-12-18', ''),
('201312180004', '2013-12-18', ''),
('201312180005', '2013-12-18', ''),
('201312180006', '2013-12-18', ''),
('201312180007', '2013-12-18', ''),
('201312180008', '2013-12-18', ''),
('201312180009', '2013-12-18', ''),
('201312180010', '2013-12-18', ''),
('201312180011', '2013-12-18', ''),
('201312180012', '2013-12-18', ''),
('201312180014', '2013-12-18', ''),
('201312180015', '2013-12-18', ''),
('201312180016', '2013-12-18', ''),
('201312180017', '2013-12-18', ''),
('201312180018', '2013-12-18', ''),
('201312180019', '2013-12-18', ''),
('201312180020', '2013-12-18', ''),
('201312180021', '2013-12-18', ''),
('201312180022', '2013-12-18', ''),
('201312180023', '2013-12-18', ''),
('201312180024', '2013-12-20', 'Agus'),
('201312180025', '2013-12-20', 'Panca'),
('201312180026', '2013-12-20', 'Dedi'),
('201312180027', '2013-12-18', 'panca'),
('201312180028', '2013-12-18', 'panca'),
('201312180029', '2013-12-18', 'panca'),
('201312210001', '2013-12-21', 'Agus'),
('201312220001', '2013-12-22', 'panca'),
('201312230001', '2013-12-23', 'Agus'),
('201312230002', '2013-12-23', 'Panca'),
('201312230003', '2013-12-23', ''),
('201312230004', '2013-12-23', ''),
('201312240001', '2013-12-24', 'Panca'),
('201312240002', '2013-12-24', 'Agus'),
('201312240003', '2013-12-24', ''),
('201312260001', '2013-12-26', 'panca');

-- --------------------------------------------------------

--
-- Table structure for table `tb_penjualan_detail`
--

CREATE TABLE IF NOT EXISTS `tb_penjualan_detail` (
  `no_penjualan` varchar(15) NOT NULL,
  `kd_brg` varchar(15) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `hrg_jual` decimal(10,0) NOT NULL,
  `Diskon` int(11) NOT NULL,
  `sub_total` decimal(10,0) DEFAULT NULL,
  KEY `no_penjualan` (`no_penjualan`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_penjualan_detail`
--

INSERT INTO `tb_penjualan_detail` (`no_penjualan`, `kd_brg`, `jumlah`, `hrg_jual`, `Diskon`, `sub_total`) VALUES
('201312130001', '101', 1, 2000, 0, 2000),
('201312130001', '002', 1, 1500, 0, 1500),
('201312130001', '001', 1, 1300, 0, 1300),
('201312170002', '0001 00002', 2, 3000, 0, 6000),
('201312170003', '0001 00003', 1, 20000, 0, 20000),
('201312170005', '0002 00003', 1, 25000, 0, 25000),
('201312170005', '0001 00003', 1, 20000, 0, 20000),
('201312170005', '0002 00001', 1, 500000, 0, 500000),
('201312170005', '0002 00002', 1, 300000, 0, 300000),
('201312180001', '0002 00002', 1, 300000, 0, 300000),
('201312180001', '0002 00001', 1, 500000, 0, 500000),
('201312180001', '0001 00003', 2, 20000, 0, 40000),
('201312180004', '0001 00003', 1, 20000, 0, 20000),
('201312180005', '0001 00002', 1, 3000, 0, 3000),
('201312180005', '0003 00001', 0, 20000, 0, 0),
('201312180005', '0001 00003', 2, 20000, 0, 40000),
('201312180006', '0001 00003', 1, 20000, 0, 20000),
('201312180006', '0002 00001', 1, 500000, 0, 500000),
('201312180006', '0001 00002', 1, 3000, 0, 3000),
('201312180007', '0001 00003', 1, 20000, 0, 20000),
('201312180008', '0002 00003', 1, 25000, 0, 25000),
('201312180008', '0002 00002', 1, 300000, 0, 300000),
('201312180008', '0002 00001', 1, 500000, 0, 500000),
('201312180009', '0003 00001', 1, 20000, 0, 20000),
('201312180009', '0002 00003', 1, 25000, 0, 25000),
('201312180010', '0002 00001', 1, 500000, 0, 500000),
('201312180010', '0001 00002', 1, 3000, 0, 3000),
('201312180011', '0001 00002', 1, 3000, 0, 3000),
('201312180012', '0001 00003', 1, 20000, 0, 0),
('201312180013', '0001 00003', 1, 20000, 0, 0),
('201312180015', '0001 00003', 1, 20000, 0, 20000),
('201312180016', '0002 00003', 1, 25000, 0, 25000),
('201312180017', '0002 00002', 1, 300000, 0, 300000),
('', '0001 00002', 1, 3000, 0, 3000),
('201312180019', '0002 00002', 1, 300000, 0, 300000),
('201312180020', '0002 00001', 1, 500000, 0, 500000),
('201312180024', '0001 00003', 1, 20000, 0, 20000),
('201312180025', '0002 00002', 1, 300000, 0, 300000),
('201312180026', '0002 00001', 2, 500000, 0, 1000000),
('201312180026', '0001 00002', 1, 3000, 0, 3000),
('201312180027', '0002 00002', 1, 300000, 0, 300000),
('201312180027', '0001 00002', 1, 3000, 0, 3000),
('201312180028', '0002 00003', 1, 25000, 0, 25000),
('201312180029', '0001 00003', 1, 20000, 0, 20000),
('201312210001', '0002 00001', 1, 500000, 0, 500000),
('201312210001', '0001 00002', 1, 3000, 0, 3000),
('201312220001', '0002 00003', 1, 25000, 0, 25000),
('201312220001', '0002 00002', 1, 300000, 0, 300000),
('201312220001', '0002 00001', 1, 500000, 0, 500000),
('201312230001', '0001 00003', 1, 20000, 0, 20000),
('201312230002', '0002 00001', 1, 300000, 0, 300000),
('201312230003', '0002 00001', 1, 300000, 0, 270000),
('201312230004', '0001 00003', 2, 20000, 0, 40000),
('201312230004', '0002 00001', 1, 300000, 0, 270000),
('201312240002', '0002 00003', 1, 25000, 0, 25000),
('201312240002', '0002 00001', 1, 300000, 10, 270000),
('201312240002', '0001 00002', 1, 8000, 0, 8000),
('201312240003', '0001 00002', 1, 8000, 0, 8000),
('201312240003', '0002 00001', 1, 300000, 10, 270000),
('201312260001', '0002 00003', 1, 25000, 0, 25000),
('201312260001', '0002 00001', 1, 300000, 10, 270000),
('201312260001', '0001 00002', 1, 8000, 0, 8000);

-- --------------------------------------------------------

--
-- Table structure for table `tb_return`
--

CREATE TABLE IF NOT EXISTS `tb_return` (
  `no_return` varchar(10) NOT NULL,
  `no_pembelian` varchar(10) NOT NULL,
  `tgl_return` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_return`
--


-- --------------------------------------------------------

--
-- Table structure for table `tb_return_detail`
--

CREATE TABLE IF NOT EXISTS `tb_return_detail` (
  `no_return` varchar(10) NOT NULL,
  `kd_brg` varchar(15) NOT NULL,
  `jumlah` int(11) NOT NULL,
  PRIMARY KEY (`no_return`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_return_detail`
--


-- --------------------------------------------------------

--
-- Table structure for table `tb_suplier`
--

CREATE TABLE IF NOT EXISTS `tb_suplier` (
  `kd_suplier` varchar(15) NOT NULL,
  `nm_suplier` varchar(30) NOT NULL,
  `alamat` varchar(70) NOT NULL,
  `kota` varchar(30) NOT NULL,
  `telp` varchar(15) NOT NULL,
  `email` varchar(30) NOT NULL,
  PRIMARY KEY (`kd_suplier`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_suplier`
--

INSERT INTO `tb_suplier` (`kd_suplier`, `nm_suplier`, `alamat`, `kota`, `telp`, `email`) VALUES
('Spl/0002', 'Pak Jaya', 'Perum Nas 2 Tangerang\r\n', 'Tangerang', '021-0002039', ''),
('Spl/0003', 'Pd Jaya Abadi', 'Balaraja Tangerang\r\n', 'Tangerang', '080-83203-4242', ''),
('Spl/0004', 'Bima Suci', 'Cikupa Tangerang\r\n', 'Tangerang', '089-009-129-111', ''),
('Spl/0005', 'Sumariah', 'Jalan Raya No 23\r\n', 'Tangerang', '080-891-219-311', 'Pan@Yahoo.Com'),
('Spl/0006', 'Pt. Sumber Rejeki', 'Jalan Gaja Mada No 12\r\n', 'Jakarta', '021-0001222', 'Jak@Gmail.Com'),
('Spl/0007', 'Pt. Maju Makmur', 'Jalan Raya Serang Km 23\r\n', 'Serang', '023-9301-2833', 'Seang@Yahoo.Co.Id');

-- --------------------------------------------------------

--
-- Table structure for table `tb_user`
--

CREATE TABLE IF NOT EXISTS `tb_user` (
  `user_id` varchar(15) NOT NULL,
  `nm_user` varchar(40) NOT NULL,
  `pass` varchar(10) NOT NULL,
  `level1` varchar(15) NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_user`
--

INSERT INTO `tb_user` (`user_id`, `nm_user`, `pass`, `level1`) VALUES
('Agus', 'Setiyawan', '12345', 'Admin'),
('Dedi', 'Dedi Sodikin', '12345', 'Kasir'),
('Panca', 'Panca Agus S', '12345', 'Supervisor');
