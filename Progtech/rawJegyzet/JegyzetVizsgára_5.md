# 5. fejezet: Practices: Jól bevált módszerek

## Jól bevált módszerek forrásai

A jól bevált módszerek (best practices) fő forrása az extrém programozás (eXtreme Programming, XP) nevű agilis módszertan. Az XP akkor alkalmazható sikeresen, ha a megrendelő és a szoftverfejlesztő cég akár napi szinten, vagy még sűrűbben tud egyeztetni. Ez jellemzően akkor fordul elő, ha egy cégen belül egy osztály megrendel a cég saját informatikai osztályától egy belső fejlesztést. Ennek eredményeként maga az extrém programozás nem terjedt el széles körben, de módszerei, mint jól bevált módszerek, igen.

Az extrém programozás attól extrém, hogy ha valamit csinálunk, akkor extrém mód jól csináljuk, illetve ha valamit nem csinálunk, akkor azt extrém mód nem csináljuk. Például az XP előírja, hogy csináljunk tesztelést, így ezt extrém jól csináljuk, úgynevezett Tesztvezérelt fejlesztést (Test Driven Development, TDD) alkalmazunk. Mivel a sokéves tapasztalat szerint ez a legjobb tesztelési módszer, ezért érdemes más környezetben is alkalmazni. Így terjedtek el az XP módszerei, és lettek jól bevált módszerek.

Nem minden XP módszer terjedt el. Például a páros programozás az XP egyik módszere, amely sok dicséretet kapott, de mégsem terjedt el széles körben a szoftvercégek gyakorlatában.

## Az XP jól bevált módszerei

### Páros programozás (pair programming)
Két programozó ír egy kódot, pontosabban az egyik írja, a másik figyeli. Ha a figyelő hibát lát vagy nem érti a kódot, azonnal szól. A két programozó folyamatosan megbeszéli, hogyan érdemes megoldani az adott problémát.

### Tesztvezérelt fejlesztés (test driven development)
Már a metódus elkészítése előtt megírjuk a hozzá tartozó egységteszteket, vagy más néven unit-teszteket. Ezt néha "először a teszt" (test-first) megközelítésnek is nevezik.

### Forráskód átnézése (code review)
Az elkészült nagyobb modulokat, például osztályokat, egy vezető fejlesztő átnézi hibák, nem érthető, vagy nem dokumentált részek miatt. A modul fejlesztői elmagyarázzák, mit és miért csináltak, a vezető fejlesztő pedig elmondja, hogyan lehet ezt jobban, szebben csinálni.

### Folyamatos integráció (continuous integration)
A nap (vagy a hét) végén, a verziókövető rendszerbe bekerült kódokat integrációs teszt alá vetjük, hogy kiderüljön, azok képesek-e együttműködni. Így nagyon korán kiszűrhető a programozók közti félreértés.

### Kódszépítés (refactoring)
A már letesztelt, működő kódot lehet szépíteni, az esetleg lassú, rugalmatlan, vagy csúnya részeket. A kódszépítés előfeltétele, hogy legyen sok egységteszt. A szépítés során nem szabad megváltoztatni a kód funkcionalitását, de a szerkezet szabadon változtatható. A szépítés után minden egységtesztet le kell futtatni, hogy lássuk, a változások okoztak-e hibát.

## Tiszta kód

### Tiszta kód ismérvei
A tiszta kód egyik legfontosabb ismérve, hogy könnyen olvasható. Ez azért fontos, mert a forráskódot más programozók fogják továbbfejleszteni. A kód olvasása közben nem kell ide-oda ugrálnunk a forráskódban. A tiszta kód nem tartalmaz megjegyzéseket, kivéve a szerződéseket rögzítő öndokumentáló megjegyzéseket (pl. LSP).

### Metódusok mérete és paraméterlista
Egy metódus legyen 5-6 soros, csak 1-2 if utasítást és egy ciklust tartalmazzon. Kerüljük a mellékhatásokat. A paraméterlista legyen rövid; egy vagy két paraméter elfogadható, három már soknak számít. Ne használjunk logikai és kimeneti paramétereket.

### Cserkészszabály
Mindig hagyjuk a kódot tisztábban, mint ahogy találtuk. Ez azt jelenti, hogy ha módosítjuk a kódot, akkor javítsuk is, hogy egyre tisztább és jobb legyen.

### Rothadó kód
A rothadó kód olyan kód, amelyet már nem mernek módosítani a programozók, mert félnek, hogy egy javítás újabb hibát okoz. A rothadó kód lelassítja a fejlesztést. Ezt megelőzik a kódszagok, mint például túl nagy metódusok, túl nagy osztályok, vagy burjánzó if-else szerkezetek.

### Rossz szagok
A rossz szagok komoly figyelmeztetést jelentenek a kód számára:
- Merevség: Nehéz megváltoztatni a rendszert.
- Törékenység: Érzékeny a változásokra.
- Mozdulatlanság: Nehéz újra felhasználni részeit.
- Viszkozitás: Körülményes változtatásokat igényel.
- Szükségtelen komplexitás: Túl bonyolult megoldások.
- Homályosság: Nehezen olvasható kód.

## Egységteszt

### Bevezetés
Az egységteszt a metódusok tesztje. Egy egységtesztben rögzítjük a metódus paramétereit és elvárt kimenetét, majd összehasonlítjuk az aktuális visszatérési értékkel. Ha ugyanaz, a teszt zöld lesz, ha nem, akkor piros.

### Egységteszt készítése JUnit5 és Maven használata esetén
JUnit5 használatához a Maven építés-automatizálási segédeszközt használjuk. A pom.xml állományba kell felsorolni a külső függőségeket. Az egységteszt során összehasonlítjuk az elvárt és az aktuális értéket.

### Egységteszt készítése Visual Studio 2013 vagy újabb esetén
A Visual Studio használatával egységteszt projektet kell hozzáadni az aktuális Solution-höz, és referenciákat kell beállítani a tesztelendő projekthez. A UnitTest1.cs fájlba írjuk az egységtesztet.

### Példa egységtesztek
Példák egységtesztek írására Javában és C#-ban, amelyek a metódusok helyes működését ellenőrzik különböző bemeneti paraméterekkel és elvárt kimenetekkel.

## Tesztvezérelt fejlesztés (TDD)

### Bevezetés
A TDD egy jól bevált módszer, amely előírja, hogy először tesztet írunk, majd csak ezután írunk üzemi kódot. A metódusból csak annyit írunk meg, hogy épp átmenjen a teszten, majd újabb tesztet írunk, és így tovább.

### TDD lépései
- Egységtesztet írunk először, csak utána metódust.
- Minden egységteszt az eddig nem tesztelt lehető legegyszerűbb esetet írja le.
- A metódusból csak annyit írunk meg, hogy épp átmenjen az összes egységteszten.

### TDD és tiszta kód kapcsolata
A TDD elősegíti a tiszta kód írását, mert a sok egységteszt bátorságot ad a kód refaktorálásához. A tiszta kód célja könnyen olvasható, karbantartható forráskód írása.

### Piros – Zöld – Piros
A TDD gyakran nevezik Piros – Zöld – Piros

 módszernek, ahol először piros tesztet írunk, majd zöldre változtatjuk, végül újra piros tesztet írunk.

### TDD előnyei és hátrányai
A TDD előnyei közé tartozik a kevesebb hiba, gyorsabb fejlesztés és kevesebb idegeskedés. Hátrányai közé tartozik, hogy nem mindenre jó, például aszinkron feldolgozásra.

### Tesztelési stratégiák és módszerek
- Fehér doboz tesztelés: A kód szerkezetének ismeretében végezzük.
- Fekete doboz tesztelés: A bemenet és kimenet vizsgálata.
- Szürke doboz tesztelés: A rendszer ismeretében végezzük a tesztelést.

A tiszta kód és jól bevált módszerek követése elengedhetetlen a magas minőségű, karbantartható és megbízható szoftverek fejlesztéséhez.