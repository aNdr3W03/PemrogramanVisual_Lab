-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 11, 2022 at 02:53 PM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `interstellar`
--

-- --------------------------------------------------------

--
-- Table structure for table `explore`
--

CREATE TABLE `explore` (
  `id` int(11) NOT NULL,
  `explore_id` varchar(10) NOT NULL,
  `star` varchar(64) NOT NULL,
  `object` varchar(64) NOT NULL,
  `mass` float DEFAULT NULL,
  `radius` float DEFAULT NULL,
  `period` float DEFAULT NULL,
  `distance` float DEFAULT NULL,
  `travel_time` float DEFAULT NULL,
  `price` int(16) DEFAULT NULL,
  `image` varchar(128) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `explore`
--

INSERT INTO `explore` (`id`, `explore_id`, `star`, `object`, `mass`, `radius`, `period`, `distance`, `travel_time`, `price`, `image`) VALUES
(1, 'TRAPPIST1d', 'TRAPPIST-1', 'TRAPPIST-1d', 0.3, 0.78, 4.05, 39, 78, 195000000, '2095TRAPPIST-1d.png'),
(2, 'PRXMCNTRIb', 'Proxima Centauri', 'Proxima Centauri b', 1.27, 0, 11.186, 4.25, 8.5, 195000000, '5192Proxima Centauri b.jpg'),
(3, 'KEPLR1649c', 'Kepler-1649', 'Kepler-1649c', 0, 1.06, 19.5, 301, 602, 853000000, '5701Kepler-1649c.png'),
(4, 'pltTOI700d', 'TOI 700', 'TOI 700 d', 1.72, 1.14, 37.4, 101, 202, 412000000, '7262TOI 700 d.jpg'),
(5, 'plROSS128b', 'Ross 128', 'Ross 128 b', 1.4, 0, 9.87, 11.03, 22.06, 354000000, '9627Ross 128 b.jpg'),
(6, 'plOUREARTH', 'Sun', 'Earth', 1, 1, 365, 0, 0, 50000000, '9995Earth.png');

-- --------------------------------------------------------

--
-- Table structure for table `ticket_booking`
--

CREATE TABLE `ticket_booking` (
  `id` int(11) NOT NULL,
  `ticket_id` varchar(20) NOT NULL,
  `user_id` bigint(20) NOT NULL,
  `from_id` varchar(10) NOT NULL,
  `to_id` varchar(10) NOT NULL,
  `date` date NOT NULL,
  `boarding` time NOT NULL,
  `class` enum('X','S','A','B','C') NOT NULL,
  `launch_gate` varchar(3) NOT NULL,
  `seat` varchar(3) NOT NULL,
  `price` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ticket_booking`
--

INSERT INTO `ticket_booking` (`id`, `ticket_id`, `user_id`, `from_id`, `to_id`, `date`, `boarding`, `class`, `launch_gate`, `seat`, `price`) VALUES
(1, '1f8wq69f461wqfwq88d', 1204201320, 'plOUREARTH', 'PRXMCNTRIb', '2075-12-04', '10:00:00', 'X', 'X01', 'A08', 195000000),
(2, '1f8wq69f461wqfwq88e', 1204201320, 'plOUREARTH', 'PRXMCNTRIb', '2075-12-04', '10:00:00', 'X', 'X01', 'A09', 195000000),
(3, 'fwq65f4wqhet54h6tep', 1435571948, 'pltTOI700d', 'plOUREARTH', '2081-08-17', '20:15:00', 'A', 'G12', 'C24', 50000000),
(4, 'fwq65f4wqhet54h6teq', 1435571948, 'pltTOI700d', 'plOUREARTH', '2081-08-17', '20:15:00', 'A', 'G12', 'C23', 50000000);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `user_id` bigint(20) NOT NULL,
  `full_name` varchar(128) NOT NULL,
  `email` varchar(64) NOT NULL,
  `username` varchar(32) NOT NULL,
  `password` varchar(32) NOT NULL,
  `date` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `user_id`, `full_name`, `email`, `username`, `password`, `date`) VALUES
(1, 1, 'admin1', 'admin1@interxtellar.com', 'admin1', 'e00cf25ad42683b3df678c61f42c6bda', '2021-06-18 06:41:15'),
(2, 2, 'admin2', 'admin2@interxtellar.com', 'admin2', 'c84258e9c39059a89ab77d846ddab909', '2021-06-18 06:42:02'),
(3, 3, 'admin3', 'admin3@interxtellar.com', 'admin3', '32cacb2f994f6b42183a1300d9a3e8d6', '2021-06-18 06:42:47'),
(4, 1204201320, 'Andrew Benedictus Jamesie', 'andrewbjamesie@yahoo.com', 'andrew123', '94598da44ba28d41ff947e6636678534', '2022-05-08 12:39:34'),
(12, 1435571948, 'Ariel Matius Surbakti', 'arielmatiussurbakti@gmail.com', 'ariel789', '4310c803740f4622bf66e2e222a5439c', '2022-05-08 12:39:37');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `explore`
--
ALTER TABLE `explore`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `ticket_booking`
--
ALTER TABLE `ticket_booking`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `explore`
--
ALTER TABLE `explore`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `ticket_booking`
--
ALTER TABLE `ticket_booking`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
