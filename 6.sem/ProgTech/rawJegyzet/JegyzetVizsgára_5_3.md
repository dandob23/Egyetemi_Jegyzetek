## Tesztvezérelt fejlesztés – Test Driven Development (TDD)

### Bevezetés

A tesztvezérelt fejlesztés (Test Driven Development, TDD) egy jól bevált módszer (best practice), amely az agilis módszerekkel és a tiszta kód elveivel együtt terjedt el. A TDD első hallásra szokatlannak tűnhet: ne a metódust írjuk meg, majd utána a hozzá tartozó egységtesztet, hanem fordítva, először írjuk meg az egységtesztet. Ezután írjuk meg a metódust, hogy az éppen átmenjen a teszten.

### TDD alapelvei

Robert C. Martin (Uncle Bob) három pontban foglalta össze a TDD lényegét:
1. **„Write no production code except to pass a failing test.”** Azaz: Ne írj üzemi kódot, kivéve, hogy egy hibás tesztet kielégíts.
2. **„Write only enough of a test to demonstrate a failure.”** Azaz: Csak annyi tesztet írj, amely elegendő egy hiba demonstrálására.
3. **„Write only enough production code to pass the test.”** Azaz: Csak annyi üzemi kódot írj, hogy kielégítsd a tesztet.

### Piros – Zöld – Piros

A TDD ciklusa a következő lépésekből áll:
1. Írjunk egy egységtesztet, amely kezdetben piros, mert a metódus még nem létezik.
2. Írjunk annyi üzemi kódot, hogy a teszt zöldre váltson.
3. Ismételjük meg a folyamatot, amíg minden eset le nem fedett tesztesettel és kóddal.

### Piros – Zöld – Kék – Piros

A TDD egy továbbfejlesztett verziója a Piros – Zöld – Kék – Piros ciklus:
1. Írjunk egy egységtesztet (piros).
2. Írjunk üzemi kódot, hogy a teszt zöldre váltson.
3. Refaktoráljuk a kódot (kék).
4. Írjunk egy újabb tesztet (piros).

### TDD és a tiszta kód kapcsolata

A TDD és a tiszta kód között szoros kapcsolat van, amely alapvető fontosságú a hatékony és fenntartható szoftverfejlesztéshez. A TDD gyakorlása során a tesztek meghatározzák a kód kívánt funkcionalitását és elvárt viselkedését, irányítva ezzel a kód implementációját. Ez a folyamat arra ösztönzi a fejlesztőket, hogy csak a szükséges kódot írják meg, minimalizálva a fölösleges kód mennyiségét és javítva a kód olvashatóságát.

### A TDD előnyei

1. **Tesztelés prioritása:** Nem felejtünk el teszteket írni, így sok-sok tesztesetünk lesz.
2. **Tesztelői szemlélet:** Először tesztelő fejünkkel gondolkodunk, biztosítva a kód tesztelhetőségét.
3. **Kódbátorság:** Könnyen merünk hozzányúlni a kódhoz, mert a regressziós tesztek biztosítják, hogy a változások hibáit észrevesszük.
4. **Kódminőség:** A tesztek lefedik a kód nagy részét, biztosítva a program magas minőségét.
5. **Időmegtakarítás:** Kevesebb időt kell hibakereséssel és nyomkövetéssel tölteni.
6. **Dokumentáció:** Az egységtesztek a legjobb dokumentációt nyújtják a programozóknak.

### A TDD és a kettős könyvelés

A TDD a szoftverfejlesztés "kettős könyvelése". Minden üzleti logikai részletet egységtesztekkel és üzemi kóddal is lefedünk. Ha bármelyik oldalon hibázunk, azonnal észrevesszük.
