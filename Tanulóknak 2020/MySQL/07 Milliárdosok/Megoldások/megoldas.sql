-- hetvenesek
SELECT nev,(2013-ev) AS kor  
FROM adatok 
WHERE kor BETWEEN 70 and 79 
ORDER BY nev;
--usa
SELECT helyezes AS Helyezés,nev AS Név,vagyon*280 AS Vagyon
FROM adatok 
WHERE orszag='USA';
--1950 előtti átlag
SELECT avg(vagyon) AS Átlag 
FROM adatok 
WHERE ev<1950;
--darab országonként
SELECT orszag,count(*) AS Darab 
FROM adatok 
GROUP BY orszag 
ORDER BY Darab DESC;