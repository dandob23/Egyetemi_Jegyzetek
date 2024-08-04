-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2019. Sze 14. 15:28
-- Kiszolgáló verziója: 10.4.6-MariaDB
-- PHP verzió: 7.3.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `milliardos`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `adatok`
--

CREATE TABLE `adatok` (
  `helyezes` int(11) NOT NULL,
  `nev` varchar(30) COLLATE utf8mb4_hungarian_ci DEFAULT NULL,
  `vagyon` double DEFAULT NULL,
  `ev` int(11) DEFAULT NULL,
  `ceg` varchar(30) COLLATE utf8mb4_hungarian_ci DEFAULT NULL,
  `orszag` varchar(20) COLLATE utf8mb4_hungarian_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `adatok`
--

INSERT INTO `adatok` (`helyezes`, `nev`, `vagyon`, `ev`, `ceg`, `orszag`) VALUES
(1, 'Carlos Slim Helu', 73, 1940, 'telecom', 'Mexikó'),
(2, 'Bill Gates', 67, 1956, 'Microsoft', 'USA'),
(3, 'Amancio Ortega', 57, 1936, 'Zara', 'Spanyolország'),
(4, 'Warren Buffett', 53.5, 1931, 'Berkshire Hathaway', 'USA'),
(5, 'Larry Ellison', 43, 1945, 'Oracle', 'USA');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `adatok`
--
ALTER TABLE `adatok`
  ADD PRIMARY KEY (`helyezes`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
