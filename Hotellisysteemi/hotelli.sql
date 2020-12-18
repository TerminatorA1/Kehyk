-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 18, 2020 at 11:04 AM
-- Server version: 10.4.13-MariaDB
-- PHP Version: 7.4.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotelli`
--

-- --------------------------------------------------------

--
-- Table structure for table `asiakkaat`
--

CREATE TABLE `asiakkaat` (
  `asiakasID` int(11) NOT NULL,
  `email` varchar(30) NOT NULL,
  `salasana` varchar(30) NOT NULL,
  `etunimi` varchar(30) NOT NULL,
  `sukunimi` varchar(50) NOT NULL,
  `postiosoite` varchar(50) NOT NULL,
  `postinumero` varchar(20) NOT NULL,
  `postitoimipaikka` varchar(50) NOT NULL,
  `maa` varchar(50) NOT NULL,
  `lisatiedot` varchar(1000) NOT NULL,
  `username` varchar(50) NOT NULL,
  `puhelin` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `asiakkaat`
--

INSERT INTO `asiakkaat` (`asiakasID`, `email`, `salasana`, `etunimi`, `sukunimi`, `postiosoite`, `postinumero`, `postitoimipaikka`, `maa`, `lisatiedot`, `username`, `puhelin`) VALUES
(1, 'atte.vanhatalo@edu.keuda.fi', 'Keuda', 'Atte', 'Vanhatalo', 'Keskuskatu 3', '04200', 'Kerava', 'Suomi', 'test', '', '0108410720'),
(2, 'admin', 'admin', '', '', '', '', '', '', '', 'admin', ''),
(8, 'test3@test3.com', 'test3@test3.com', 'Test3', 'Tester3', 'koekatu 3', '00300', 'Helsinki', 'Suomi', '', '', '3333'),
(10, '123', '2222', 'kokeilu3', 'sss3', 'sdf', '1234', 'mmmm', 'ert', '', '', '1234'),
(11, 'turo', '1234', 'ee4', 'ei4', 'ees4', 'eer4', 'eet4', 'eesti4', '', '', '44444'),
(12, 'aaafff', 'aaafff', 'wwww', 'ttttt', 'wwtwet', 'rwt', '44444', 'tttt', '', '', '2222'),
(13, 'test13', 'pekka', 'Pekka', 'Pouta', 'Ratakatu 1', '00100', 'Helsinki', 'Suomi', '', '', '123456'),
(14, 'qqq', '1234', 'qqq', 'qqq', 'qqq', 'qqqq', 'qqq', 'qqq', '', '', '1234'),
(15, 'asd', '1111', 'Tester', 'TesterS', 'ttt', '0000', 'Lohja', 'Suomi', '', '', '1111');

-- --------------------------------------------------------

--
-- Table structure for table `huoneet`
--

CREATE TABLE `huoneet` (
  `huoneID` int(11) NOT NULL,
  `hnumero` int(11) NOT NULL,
  `htyyppi` int(11) NOT NULL,
  `hpuhelin` varchar(100) NOT NULL,
  `hvapaa` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `huoneet`
--

INSERT INTO `huoneet` (`huoneID`, `hnumero`, `htyyppi`, `hpuhelin`, `hvapaa`) VALUES
(2, 201, 2, '201', 'Kyllä'),
(3, 301, 3, '301', 'Kyllä'),
(4, 401, 1, '4011235', 'Ei'),
(8, 501, 4, '5011', 'Kyllä');

-- --------------------------------------------------------

--
-- Table structure for table `huonetyyppi`
--

CREATE TABLE `huonetyyppi` (
  `huonetyyppiID` int(11) NOT NULL,
  `huonetyypit` varchar(100) NOT NULL,
  `hinta` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `huonetyyppi`
--

INSERT INTO `huonetyyppi` (`huonetyyppiID`, `huonetyypit`, `hinta`) VALUES
(1, 'Yhden hengen huone', '100'),
(2, 'Kahden hengen huone', '150'),
(3, 'Perhehuone', '200'),
(4, 'Sviitti', '300');

-- --------------------------------------------------------

--
-- Table structure for table `varaukset`
--

CREATE TABLE `varaukset` (
  `varausID` int(11) NOT NULL,
  `huoneN` int(11) NOT NULL,
  `asiakasN` int(1) NOT NULL,
  `paivaIn` date NOT NULL,
  `paivaOut` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `varaukset`
--

INSERT INTO `varaukset` (`varausID`, `huoneN`, `asiakasN`, `paivaIn`, `paivaOut`) VALUES
(2, 401, 2, '2020-12-24', '2020-12-25');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `asiakkaat`
--
ALTER TABLE `asiakkaat`
  ADD PRIMARY KEY (`asiakasID`);

--
-- Indexes for table `huoneet`
--
ALTER TABLE `huoneet`
  ADD PRIMARY KEY (`huoneID`);

--
-- Indexes for table `huonetyyppi`
--
ALTER TABLE `huonetyyppi`
  ADD PRIMARY KEY (`huonetyyppiID`);

--
-- Indexes for table `varaukset`
--
ALTER TABLE `varaukset`
  ADD PRIMARY KEY (`varausID`),
  ADD KEY `fk_client_id` (`asiakasN`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `asiakkaat`
--
ALTER TABLE `asiakkaat`
  MODIFY `asiakasID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `huoneet`
--
ALTER TABLE `huoneet`
  MODIFY `huoneID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `huonetyyppi`
--
ALTER TABLE `huonetyyppi`
  MODIFY `huonetyyppiID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `varaukset`
--
ALTER TABLE `varaukset`
  MODIFY `varausID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `varaukset`
--
ALTER TABLE `varaukset`
  ADD CONSTRAINT `fk_client_id` FOREIGN KEY (`asiakasN`) REFERENCES `asiakkaat` (`asiakasID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
