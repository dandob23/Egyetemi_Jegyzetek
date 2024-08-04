-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2019. Aug 19. 14:45
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
-- Adatbázis: `filmek`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `top10`
--

CREATE TABLE `top10` (
  `cim` varchar(50) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `mufaj` varchar(20) COLLATE utf8mb4_hungarian_ci DEFAULT NULL,
  `nemzet` varchar(30) COLLATE utf8mb4_hungarian_ci DEFAULT NULL,
  `hossz` int(11) DEFAULT NULL,
  `kezdet` date DEFAULT NULL,
  `nezo` int(11) DEFAULT NULL,
  `bevetel` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `top10`
--

INSERT INTO `top10` (`cim`, `mufaj`, `nemzet`, `hossz`, `kezdet`, `nezo`, `bevetel`) VALUES
('007 Spectre - A fantom visszatér', 'akció', 'amerikai-angol', 150, '2015-11-05', 6198, 361001590),
('A kis herceg', 'animációs', 'francia', 108, '2015-11-05', 4769, 82807852),
('A tenger szívében', 'kaland', 'amerikai', 121, '2015-12-10', 11578, 16988425),
('Az éhezők viadala - A kiválasztott', 'sci-fi', 'amerikai', 137, '2015-11-19', 15514, 332902339),
('Dínó tesó', 'animációs', 'amerikai', 100, '2015-12-03', 15421, 29112095),
('Hotel Transylvania 2.', 'animációs', 'amerikai', 90, '2015-10-08', 3763, 368634982),
('Káosz karácsonyra', 'vígjáték', 'amerikai', 107, '2015-12-10', 41562, 55319590),
('Kémek hídja', 'thriller', 'amerikai', 135, '2015-11-26', 16647, 116585665),
('Krampusz', 'horror-vígjáték', 'amerikai', 98, '2015-12-03', 18063, 53805445),
('Szemekbe zárt titkok', 'thriller', 'amerikai', 111, '2015-12-03', 12033, 45020855);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `top10`
--
ALTER TABLE `top10`
  ADD PRIMARY KEY (`cim`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
