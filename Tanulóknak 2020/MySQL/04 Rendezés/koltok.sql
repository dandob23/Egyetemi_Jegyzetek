-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2019. Aug 18. 14:14
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
-- Adatbázis: `koltok`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `evek`
--

CREATE TABLE `evek` (
  `az` int(11) NOT NULL,
  `nev` varchar(40) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `szuletett` int(11) DEFAULT NULL,
  `meghalt` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `evek`
--

INSERT INTO `evek` (`az`, `nev`, `szuletett`, `meghalt`) VALUES
(1, 'Ady Endre', 1877, 1919),
(2, 'Arany János', 1817, 1882),
(3, 'Babits Mihály', 1883, 1941),
(4, 'Csokonai Vitéz Mihály', 1773, 1805),
(5, 'Illyés Gyula', 1902, 1983),
(6, 'József Attila', 1905, 1937),
(7, 'Kölcsey Ferenc', 1790, 1838),
(8, 'Petőfi Sándor', 1823, 1849),
(9, 'Radnóti Miklós', 1909, 1944),
(10, 'Tóth Árpád', 1886, 1928),
(11, 'Juhász Gyula', 1883, 1937);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `evek`
--
ALTER TABLE `evek`
  ADD PRIMARY KEY (`az`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `evek`
--
ALTER TABLE `evek`
  MODIFY `az` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
