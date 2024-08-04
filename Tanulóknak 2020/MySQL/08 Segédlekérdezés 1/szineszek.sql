-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2017. Máj 01. 14:29
-- Kiszolgáló verziója: 5.7.14
-- PHP verzió: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `szineszek`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `table 1`
--

CREATE TABLE `szineszek` (
  `Nev` varchar(20) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `Nem` varchar(1) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `Szulido` date NOT NULL,
  `Szulhely` varchar(20) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `Szulorsz` varchar(15) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL,
  `Filmszam` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `szineszek`
--

INSERT INTO `szineszek` (`Nev`, `Nem`, `Szulido`, `Szulhely`, `Szulorsz`, `Filmszam`) VALUES
('Eastwood Clint', 'f', '1930-05-31', 'San Francisco', 'USA', 58),
('Funes Louis de', 'f', '1914-07-31', 'Courbevoie', 'Franciaország', 146),
('Davis Bette', 'n', '1908-04-05', 'Lowell', 'USA', 118),
('Ullmann Liv', 'n', '1938-12-16', 'Tokió', 'Japán', 52),
('Hepburn Audrey', 'n', '1929-05-04', 'Brüsszel', 'Belgium', 30),
('Kiss Manyi', 'n', '1911-03-12', 'Zágon', 'Magyarország', 94),
('Adjani Isabelle', 'n', '1955-06-27', 'Párizs', 'Franciaország', 33),
('Streisand Barbra', 'n', '1942-04-24', 'Brooklyn', 'USA', 25),
('Wood Natalie', 'n', '1938-07-20', 'San Francisco', 'USA', 67),
('Sharif Omar', 'f', '1932-04-10', 'Alexandria', 'Egyiptom', 107),
('Minelli Lisa', 'n', '1946-03-12', 'Los Angeles', 'USA', 27),
('Niro Robert de', 'f', '1943-08-17', 'New York', 'USA', 74),
('Belushi James', 'f', '1954-06-15', 'Chicago', 'USA', 101),
('Page Geraldine', 'n', '1924-11-22', 'Kirksville', 'USA', 66),
('Gózon Gyula', 'f', '1885-03-13', 'Érsekújvár', 'Magyarország', 78),
('Hayek Salma', 'n', '1966-09-02', 'Coatzacoalcos', 'Mexikó', 41),
('Ford Harrison', 'f', '1942-07-13', 'Chicago', 'USA', 48),
('Matthau Walter', 'f', '1920-10-01', 'New York', 'USA', 103),
('Nolte Nick', 'f', '1941-02-08', 'Omaha', 'USA', 70),
('Finney Albert', 'f', '1936-05-09', 'Salford', 'Anglia', 57),
('Montand Yves', 'f', '1921-10-13', 'Monsummano Terme', 'Olaszország', 60),
('Beatty Warren', 'f', '1937-03-30', 'Richmond', 'USA', 29),
('Sutherland Donald', 'f', '1935-07-17', 'Saint John', 'Kanada', 131),
('Burton Richard', 'f', '1925-11-10', 'Pontrhydyfen', 'Wales', 70),
('MacLaine Shirley', 'n', '1934-04-24', 'Richmond', 'USA', 59),
('Zellweger Renee', 'n', '1969-04-25', 'Katy', 'USA', 32),
('Andrews Julie', 'n', '1935-10-01', 'Walton-on-Thames', 'Anglia', 37),
('Bourvil', 'f', '1917-07-27', 'Petrot-Vicquemare', 'Franciaország', 62),
('Sellers Peter', 'f', '1925-09-08', 'Southsea', 'Anglia', 76),
('Gable Clark', 'f', '1901-02-01', 'Cadiz', 'USA', 78),
('Binoche Juliette', 'n', '1964-03-09', 'Párizs', 'Franciaország', 39),
('Curtis Jamie Lee', 'n', '1958-11-22', 'Los Angeles', 'USA', 60),
('Plummer Christopher', 'f', '1929-12-13', 'Toroto', 'Kanada', 138),
('Tolnay Klári', 'n', '1914-07-27', 'Budapest', 'Magyarország', 84),
('Crosby Bing', 'f', '1903-05-02', 'Tacoma', 'USA', 84),
('Peck Gregory', 'f', '1916-04-05', 'La Jolla', 'USA', 59),
('Hepburn Katharine', 'n', '1907-05-12', 'Hartford', 'USA', 53),
('York Michael', 'f', '1942-03-27', 'Fulmer', 'Anglia', 133),
('Kerr Deborah', 'n', '1921-09-30', 'Helensburgh', 'Skócia', 52),
('Szőke Szakáll', 'f', '1884-02-02', 'Budapest', 'Magyarország', 102),
('Berry Halle', 'n', '1966-08-14', 'Cleveland', 'USA', 38),
('Curtis Tony', 'f', '1925-06-03', 'Bronx', 'USA', 131),
('Csortos Gyula', 'f', '1883-03-03', 'Budapest', 'Magyarország', 57),
('Kinski Nastassja', 'n', '1959-01-24', 'Berlin', 'Németország', 64),
('Dietrich Marlene', 'n', '1901-12-27', 'Berlin', 'Németország', 55),
('Redford Robert', 'f', '1937-08-18', 'Santa Monica', 'USA', 63),
('Howard Leslie', 'f', '1893-04-03', 'Forest Hill', 'Anglia', 34),
('Tognazzi Ugo', 'f', '1922-03-23', 'Cremona', 'Olaszország', 150),
('Garbo Greta', 'n', '1905-09-18', 'Stockholm', 'Svédország', 31),
('Olivier Laurence', 'f', '1907-05-22', 'Dorking', 'Anglia', 86),
('Gassman Vittorio', 'f', '1922-09-01', 'Genova', 'Olaszország', 127),
('Quinn Anthony', 'f', '1915-04-21', 'Chihuahua', 'Mexikó', 167),
('Pécsi Sándor', 'f', '1922-03-18', 'Sajószentpéter', 'Magyarország', 62),
('Pacino Al', 'f', '1940-04-25', 'Bronx', 'USA', 42),
('Caine Michael', 'f', '1933-03-14', 'Rotherhithe', 'Anglia', 120),
('Gardner Ava', 'n', '1922-12-24', 'Brogden', 'USA', 65),
('DeVito Danny', 'f', '1944-11-17', 'Asbury Park', 'USA', 80),
('Hanks Tom', 'f', '1956-07-09', 'Concord', 'USA', 54),
('Páger Antal', 'f', '1899-01-29', 'Makó', 'Magyarország', 153),
('Fonda Peter', 'f', '1940-02-23', 'New York', 'USA', 72),
('Hopkins Anthony', 'f', '1937-12-31', 'Margam', 'Wales', 100),
('Bergman Ingrid', 'n', '1915-08-29', 'Stockholm', 'Svédország', 52),
('Moreau Jeanne', 'n', '1928-01-23', 'Párizs', 'Franciaország', 127),
('Basinger Kim', 'n', '1953-12-08', 'Athens', 'USA', 36),
('Winslet Kate', 'n', '1975-10-05', 'Reading', 'Anglia', 31),
('Latinovits Zoltán', 'f', '1931-09-09', 'Budapest', 'Magyarország', 53),
('Kline Kevin', 'f', '1947-10-24', 'St. Louis', 'USA', 42),
('Gobbi Hilda', 'n', '1913-06-05', 'Budapest', 'Magyarország', 107),
('Hawn Goldie', 'n', '1945-11-21', 'Washington', 'USA', 33),
('Deneuve Catherine', 'n', '1943-10-22', 'Párizs', 'Franciaország', 97),
('Garner James', 'f', '1928-04-07', 'Norman', 'USA', 94),
('Leigh Janet', 'n', '1927-07-06', 'Merced', 'USA', 63),
('Rooney Mickey', 'f', '1920-09-23', 'Brooklyn', 'USA', 300),
('Lemmon Jack', 'f', '1925-02-08', 'Newton', 'USA', 101),
('Newmann Paul', 'f', '1925-01-26', 'Shaker Heights', 'USA', 75),
('Delon Alain', 'f', '1935-11-08', 'Sceaux', 'Franciaország', 89),
('Shepherd Cybill', 'n', '1950-02-18', 'Memphis', 'USA', 46),
('Foster Jodie', 'n', '1962-11-19', 'Los Angeles', 'USA', 72),
('Savalas Telly', 'f', '1924-01-21', 'Garden City', 'USA', 121),
('Jávor Pál', 'f', '1902-01-31', 'Arad', 'Magyarország', 72),
('Kidman Nicole', 'n', '1967-06-20', 'Honolulu', 'USA', 50),
('Rossellini Isabella', 'n', '1952-06-18', 'Róma', 'Olaszország', 54),
('Washington Denzel', 'f', '1954-12-28', 'Mount Vernon', 'USA', 41),
('Lancaster Burt', 'f', '1913-11-02', 'New York', 'USA', 88),
('Kabos Gyula', 'f', '1884-03-19', 'Budapest', 'Magyarország', 45),
('Kelly Grace', 'n', '1929-11-12', 'Philadelphia', 'USA', 12),
('Brando Marlon', 'f', '1924-04-03', 'Omaha', 'USA', 42),
('Weaver Sigourney', 'n', '1949-10-08', 'New York', 'USA', 44),
('Bronson Charles', 'f', '1921-11-03', 'Ehrenfeld', 'USA', 98),
('Lange Jessica', 'n', '1949-04-20', 'Cloquet', 'USA', 36),
('Roberts Julia', 'n', '1967-10-28', 'Smyrna', 'USA', 41),
('Thompson Emma', 'n', '1959-04-15', 'Paddington', 'Anglia', 40),
('Nicholson Jack', 'f', '1937-04-22', 'Neptune', 'USA', 59),
('Bardot Brigitte', 'n', '1934-09-28', 'Párizs', 'Franciaország', 47),
('Latabár Kálmán', 'f', '1902-11-24', 'Kecskemét', 'Magyarország', 33),
('Ruttkai Éva', 'n', '1927-12-31', 'Budapest', 'Magyarország', 63),
('Douglas Kirk', 'f', '1916-12-09', 'Amsterdam', 'USA', 91),
('Young Sean', 'n', '1959-11-20', 'Louisville', 'USA', 70),
('Cruise Tom', 'f', '1962-07-03', 'Syracuse', 'USA', 33),
('Welles Orson', 'f', '1915-05-06', 'Kenosha', 'USA', 111),
('Taylor Elizabeth', 'n', '1932-02-27', 'Hampsteadt', 'Anglia', 70),
('Dean James', 'f', '1931-02-08', 'Marion', 'USA', 29),
('Signoret Simone', 'n', '1921-03-25', 'Wiesbaden', 'Németország', 71),
('Fernandel', 'f', '1903-05-08', 'Marseille', 'Franciaország', 149),
('Lennox Annie', 'n', '1954-12-25', 'Aberdeen', 'Skócia', 19),
('Mastroianni Marcello', 'f', '1924-09-28', 'Fontana Liri', 'Olaszország', 145),
('Lopez Jennifer', 'n', '1969-07-24', 'Bronx', 'USA', 30),
('Philipe Gérard', 'f', '1922-12-04', 'Cannes', 'Franciaország', 35),
('Murray Bill', 'f', '1950-09-21', 'Wilmette', 'USA', 46),
('Hackman Gene', 'f', '1930-01-30', 'San Bernardino', 'USA', 94),
('Básti Lajos', 'f', '1911-11-17', 'Keszthely', 'Magyarország', 45),
('Girardot Annie', 'n', '1931-10-25', 'Párizs', 'Franciaország', 154),
('Chaplin Charles', 'f', '1889-04-16', 'Walworth', 'Anglia', 86),
('Perkins Anthony', 'f', '1932-04-04', 'New York', 'USA', 58),
('Costner Kevin', 'f', '1955-01-18', 'Lynwood', 'USA', 39),
('Bessenyei Ferenc', 'f', '1919-02-10', 'Hódmezővásárhely', 'Magyarország', 75),
('Streep Meryl', 'n', '1949-06-22', 'Summit', 'USA', 57),
('Williams Robin', 'f', '1951-07-21', 'Chicago', 'USA', 80),
('Lollobrigida Gina', 'n', '1927-07-04', 'Subiaco', 'Olaszország', 72),
('Depardieu Gérard', 'f', '1948-12-27', 'Châteauroux', 'Franciaország', 155),
('Fonda Henry', 'f', '1905-05-16', 'Grand Island', 'USA', 106),
('Hoffmann Dustin', 'f', '1937-08-08', 'Los Angeles', 'USA', 64),
('Aykroyd Dan', 'f', '1952-07-01', 'Ottawa', 'Kanada', 79),
('Cooper Gary', 'f', '1901-05-07', 'Helena', 'USA', 106),
('Loren Sophia', 'n', '1934-09-20', 'Pozzuoli', 'Olaszország', 92),
('Szörényi Éva', 'n', '1917-05-26', 'Budapest', 'Magyarország', 29),
('Cage Nicolas', 'f', '1964-01-07', 'Long Beach', 'USA', 55),
('Dunaway Faye', 'n', '1941-01-14', 'Bascom', 'USA', 96),
('Redgrave Vanessa', 'n', '1937-01-30', 'London', 'Anglia', 97),
('Fonda Jane', 'n', '1937-12-21', 'New York', 'USA', 43),
('Tracy Spencer', 'f', '1900-04-05', 'Milwaukee', 'USA', 78),
('Grant Cary', 'f', '1904-01-18', 'Horfield', 'Anglia', 73),
('Sinkovits Imre', 'f', '1928-11-22', 'Budapest', 'Magyarország', 84),
('Crowe Russel', 'f', '1964-04-07', 'Wellington', 'Új-Zéland', 33),
('Belmondo Jean-Paul', 'f', '1933-04-09', 'Neuilly-sur-Seine', 'Franciaország', 81),
('Irons Jeremy', 'f', '1948-09-19', 'Cowes', 'Anglia', 66),
('Smith Will', 'f', '1968-09-25', 'Philadelphia', 'USA', 26),
('Garland Judy', 'n', '1922-06-10', 'Grand Rapids', 'USA', 33),
('Gréco Juliette', 'n', '1927-02-07', 'Montpellier', 'Franciaország', 33),
('Close Glenn', 'n', '1947-03-19', 'Greewich', 'USA', 60),
('Sarandon Susan', 'n', '1946-10-04', 'New York', 'USA', 84),
('Cardinale Claudia', 'n', '1938-04-15', 'Tunis', 'Tunézia', 103),
('Muti Ornella', 'n', '1955-03-09', 'Róma', 'Olaszország', 97),
('Bogart Humphrey', 'f', '1899-12-25', 'New York', 'USA', 74),
('Hitchcock Alfred', 'f', '1899-08-13', 'Leytonstone', 'Anglia', 35);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
