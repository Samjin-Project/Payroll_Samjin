-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 06, 2020 at 09:43 AM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.2.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `payroll_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `aktivittas_proses`
--

CREATE TABLE `aktivittas_proses` (
  `no` int(11) NOT NULL,
  `nama_proses` varchar(20) NOT NULL,
  `nama_user` varchar(30) NOT NULL,
  `status_proses` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `aktivittas_proses`
--

INSERT INTO `aktivittas_proses` (`no`, `nama_proses`, `nama_user`, `status_proses`) VALUES
(1, 'up_master', '', 0),
(2, 'create_daily', '', 0),
(3, 'up_finger', '', 0),
(4, 'ex_nocheck', '', 0),
(5, 'ex_viewdaily', '', 0),
(6, 'ex_payroll', '', 0),
(7, 'create_payroll', '', 0);

-- --------------------------------------------------------

--
-- Table structure for table `approval_vacation`
--

CREATE TABLE `approval_vacation` (
  `No` int(11) NOT NULL,
  `NIK` varchar(7) NOT NULL,
  `Status_Approval` varchar(3) NOT NULL,
  `Approver` varchar(35) NOT NULL,
  `Nama_Karyawan` varchar(35) NOT NULL,
  `Vacation_Code` varchar(15) NOT NULL,
  `StartVacation_Date` date NOT NULL,
  `EndVacation_Date` date NOT NULL,
  `ReqVacation_Date` date NOT NULL,
  `Department` varchar(20) NOT NULL,
  `Telp` varchar(15) NOT NULL,
  `Reason` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `finger_employer`
--

CREATE TABLE `finger_employer` (
  `NO` int(11) NOT NULL,
  `Time_Upload` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `AC_Nomor` int(11) NOT NULL,
  `NIK` varchar(8) NOT NULL,
  `Nama_Karyawan` varchar(35) NOT NULL,
  `Date_Finger` date NOT NULL,
  `Shift_Finger` varchar(10) NOT NULL,
  `On_Duty` varchar(5) NOT NULL,
  `Off_Duty` varchar(5) NOT NULL,
  `Check_In` varchar(5) NOT NULL,
  `Check_Out` varchar(5) NOT NULL,
  `Departement` varchar(30) NOT NULL,
  `Finger Status` int(1) DEFAULT NULL,
  `RecFinIN` varchar(8) NOT NULL,
  `RecFinOut` varchar(8) NOT NULL,
  `Modified` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `hari_kerja`
--

CREATE TABLE `hari_kerja` (
  `No` int(11) NOT NULL,
  `Jenis_Hari_Kerja` varchar(30) NOT NULL,
  `Hari` varchar(3) NOT NULL,
  `Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `master employer`
--

CREATE TABLE `master employer` (
  `No` int(11) NOT NULL,
  `AC_Nomor` int(11) NOT NULL,
  `NIK` varchar(8) NOT NULL,
  `Nama_Karyawan` varchar(30) NOT NULL,
  `Posisi_Karyawan` varchar(15) NOT NULL,
  `Department` varchar(25) NOT NULL,
  `Tempat_Lahir` varchar(25) NOT NULL,
  `Tanggal_Lahir` varchar(10) NOT NULL,
  `Jenis_Kelamin` varchar(10) NOT NULL,
  `Pendidikan_Karyawan` varchar(5) NOT NULL,
  `Tanggal_Masuk` varchar(10) NOT NULL,
  `Tanggal_Keluar` date NOT NULL,
  `Status_karyawan` varchar(10) NOT NULL,
  `Salary` float NOT NULL,
  `StatusBpjs` tinyint(1) NOT NULL,
  `StatusAktive` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tabel_basic_payroll`
--

CREATE TABLE `tabel_basic_payroll` (
  `No` int(11) NOT NULL,
  `Nama` varchar(35) NOT NULL,
  `Upah_Lembur` float NOT NULL,
  `Jamsost` float NOT NULL,
  `bpjs` float NOT NULL,
  `manag_fee` float NOT NULL,
  `makan_puasa` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tabel_basic_payroll`
--

INSERT INTO `tabel_basic_payroll` (`No`, `Nama`, `Upah_Lembur`, `Jamsost`, `bpjs`, `manag_fee`, `makan_puasa`) VALUES
(1, 'set1', 20000, 0.0119, 51000, 0.08, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tabel_bulanan_karyawan`
--

CREATE TABLE `tabel_bulanan_karyawan` (
  `No` int(11) NOT NULL,
  `NIK` varchar(12) NOT NULL,
  `Name` varchar(20) CHARACTER SET utf8mb4 NOT NULL,
  `DateMonth` date NOT NULL,
  `Department` varchar(20) CHARACTER SET utf8mb4 NOT NULL,
  `Transport` varchar(10) CHARACTER SET utf8mb4 NOT NULL,
  `Transport_Amount` varchar(10) CHARACTER SET utf8mb4 NOT NULL,
  `Shift` varchar(3) CHARACTER SET utf8mb4 NOT NULL,
  `Shift_Amount` varchar(10) CHARACTER SET utf8mb4 NOT NULL,
  `Meal` varchar(10) CHARACTER SET utf8mb4 NOT NULL,
  `Meal Amount` varchar(10) CHARACTER SET utf8mb4 NOT NULL,
  `attendance` varchar(10) CHARACTER SET utf8mb4 NOT NULL,
  `1` varchar(2) NOT NULL,
  `2` varchar(2) NOT NULL,
  `3` varchar(2) NOT NULL,
  `4` varchar(2) NOT NULL,
  `5` varchar(2) NOT NULL,
  `6` varchar(2) NOT NULL,
  `7` varchar(2) NOT NULL,
  `8` varchar(2) NOT NULL,
  `9` varchar(2) NOT NULL,
  `10` varchar(2) NOT NULL,
  `11` varchar(2) NOT NULL,
  `12` varchar(2) NOT NULL,
  `13` varchar(2) NOT NULL,
  `14` varchar(2) NOT NULL,
  `15` varchar(2) NOT NULL,
  `16` varchar(2) NOT NULL,
  `17` varchar(2) NOT NULL,
  `18` varchar(2) NOT NULL,
  `19` varchar(2) NOT NULL,
  `20` varchar(2) NOT NULL,
  `21` varchar(2) NOT NULL,
  `22` varchar(2) NOT NULL,
  `23` varchar(2) NOT NULL,
  `24` varchar(2) NOT NULL,
  `25` varchar(2) NOT NULL,
  `26` varchar(2) NOT NULL,
  `27` varchar(2) NOT NULL,
  `28` varchar(2) NOT NULL,
  `29` varchar(2) NOT NULL,
  `30` varchar(2) NOT NULL,
  `31` varchar(2) NOT NULL,
  `Total_OT` varchar(4) NOT NULL,
  `Kehadiran` varchar(4) NOT NULL,
  `BasicSalary` int(11) NOT NULL,
  `Ot_wages` float NOT NULL,
  `jamsostek` float NOT NULL,
  `Gross_Salary` float NOT NULL,
  `managFee_salary` float NOT NULL,
  `payFromSamjin` float NOT NULL,
  `bpjs` float NOT NULL,
  `deduction` float NOT NULL,
  `takeHomePay` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tabel_harian_karyawan1`
--

CREATE TABLE `tabel_harian_karyawan1` (
  `No` int(11) NOT NULL,
  `NIK` varchar(8) NOT NULL,
  `Name` varchar(25) CHARACTER SET utf8mb4 NOT NULL,
  `Type` varchar(20) CHARACTER SET utf8mb4 NOT NULL,
  `Date` date NOT NULL,
  `Day` varchar(8) CHARACTER SET utf8mb4 NOT NULL,
  `Shift` varchar(8) CHARACTER SET utf8mb4 NOT NULL,
  `Check In` varchar(5) NOT NULL,
  `Check Out` varchar(5) NOT NULL,
  `Check Out Date` date DEFAULT NULL,
  `Lateness` varchar(8) CHARACTER SET utf8mb4 NOT NULL,
  `Early Check Out` varchar(8) CHARACTER SET utf8mb4 NOT NULL,
  `Basic Time` int(4) NOT NULL DEFAULT 8,
  `Over Time` int(4) NOT NULL,
  `Department` varchar(25) CHARACTER SET utf8mb4 NOT NULL,
  `Absen_Paid` varchar(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tabel_izin`
--

CREATE TABLE `tabel_izin` (
  `No` int(11) NOT NULL,
  `NIK` varchar(20) NOT NULL,
  `Status Approval` varchar(20) CHARACTER SET utf8mb4 NOT NULL,
  `Approver` varchar(20) CHARACTER SET utf8mb4 NOT NULL DEFAULT 'Putri',
  `Nama Karyawan` varchar(20) CHARACTER SET utf8mb4 NOT NULL,
  `Vacation Code` int(2) NOT NULL,
  `Start Vacation Date` date NOT NULL,
  `End Vacation Date` date NOT NULL,
  `Req Vacation Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `user_admin`
--

CREATE TABLE `user_admin` (
  `No` int(4) NOT NULL,
  `NIK` varchar(8) NOT NULL,
  `Nama` varchar(20) CHARACTER SET utf8mb4 NOT NULL,
  `Status` varchar(10) CHARACTER SET utf8mb4 NOT NULL,
  `Department` varchar(15) CHARACTER SET utf8mb4 NOT NULL,
  `Username` varchar(15) CHARACTER SET utf8mb4 NOT NULL,
  `Password` varchar(15) CHARACTER SET utf8mb4 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user_admin`
--

INSERT INTO `user_admin` (`No`, `NIK`, `Nama`, `Status`, `Department`, `Username`, `Password`) VALUES
(1, '12345', 'RIKI TARDIANSYAH', 'SUPER USER', '-', 'admin', 'admin123'),
(2, '123456', 'admin1', 'admin', 'PCBA', 'admin1', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `aktivittas_proses`
--
ALTER TABLE `aktivittas_proses`
  ADD PRIMARY KEY (`no`);

--
-- Indexes for table `approval_vacation`
--
ALTER TABLE `approval_vacation`
  ADD PRIMARY KEY (`No`);

--
-- Indexes for table `finger_employer`
--
ALTER TABLE `finger_employer`
  ADD PRIMARY KEY (`NO`);

--
-- Indexes for table `hari_kerja`
--
ALTER TABLE `hari_kerja`
  ADD PRIMARY KEY (`Jenis_Hari_Kerja`),
  ADD UNIQUE KEY `No` (`No`),
  ADD UNIQUE KEY `Date` (`Date`);

--
-- Indexes for table `master employer`
--
ALTER TABLE `master employer`
  ADD PRIMARY KEY (`NIK`),
  ADD UNIQUE KEY `No` (`No`);

--
-- Indexes for table `tabel_basic_payroll`
--
ALTER TABLE `tabel_basic_payroll`
  ADD PRIMARY KEY (`No`);

--
-- Indexes for table `tabel_bulanan_karyawan`
--
ALTER TABLE `tabel_bulanan_karyawan`
  ADD PRIMARY KEY (`No`) USING BTREE;

--
-- Indexes for table `tabel_harian_karyawan1`
--
ALTER TABLE `tabel_harian_karyawan1`
  ADD PRIMARY KEY (`No`) USING BTREE;

--
-- Indexes for table `tabel_izin`
--
ALTER TABLE `tabel_izin`
  ADD PRIMARY KEY (`No`) USING BTREE;

--
-- Indexes for table `user_admin`
--
ALTER TABLE `user_admin`
  ADD PRIMARY KEY (`No`),
  ADD UNIQUE KEY `Username` (`Username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `aktivittas_proses`
--
ALTER TABLE `aktivittas_proses`
  MODIFY `no` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `approval_vacation`
--
ALTER TABLE `approval_vacation`
  MODIFY `No` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `finger_employer`
--
ALTER TABLE `finger_employer`
  MODIFY `NO` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `hari_kerja`
--
ALTER TABLE `hari_kerja`
  MODIFY `No` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `master employer`
--
ALTER TABLE `master employer`
  MODIFY `No` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tabel_basic_payroll`
--
ALTER TABLE `tabel_basic_payroll`
  MODIFY `No` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tabel_bulanan_karyawan`
--
ALTER TABLE `tabel_bulanan_karyawan`
  MODIFY `No` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tabel_harian_karyawan1`
--
ALTER TABLE `tabel_harian_karyawan1`
  MODIFY `No` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tabel_izin`
--
ALTER TABLE `tabel_izin`
  MODIFY `No` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `user_admin`
--
ALTER TABLE `user_admin`
  MODIFY `No` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
