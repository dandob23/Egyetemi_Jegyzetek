### Egyke – Singleton

**Singleton (Egyke)**:
- lehetővé teszi, hogy egy osztályból csak egy példány létezzen
- az egyetlen példány globálisan elérhető
- osztály szintű metódusokat használ az egyetlen példány elérésére
- az osztálynak nincs publikus konstruktora, így az új példány létrehozása korlátozott
- az osztály szintű szerezPéldány (getInstance) metódus biztosítja az egyetlen példány elérését
- példányosítás a privát konstruktoron keresztül történik a szerezPéldány metódusban
- amikor alkalmazzuk:
    - ha biztosítani akarjuk, hogy csak egy példány legyen egy osztályból, például konfigurációs beállítások vagy naplózás esetén
- például egy adatbázis kapcsolat kezelése, ahol csak egy példány létezhet az erőforrások hatékony használata érdekében
- nem lehet publikus konstruktora az osztálynak, így nem sérti az OCP elvet
- működése:
    - az osztály tartalmaz egy privát statikus mezőt az egyetlen példány tárolására
    - a szerezPéldány metódus visszaadja ezt a példányt, létrehozva, ha még nem létezik
- előnyök:
    - biztosítja az egyetlen példány létét
    - globális hozzáférési pontot biztosít
- hátrányok:
    - nehéz tesztelni, mivel nehéz az állapotot tisztán tartani
    - néha túlzottan használt, ami nem mindig indokolt

### Prototípus – Prototype

**Prototype (Prototípus)**:
- létrehozási tervezési minta, amely egy prototípus klónozásával gyárt objektumokat
- klónok az eredeti prototípus pontos másolatai, de saját memóriacímmel rendelkeznek
- fő technika: klónozás (deep copy)
- sekély klónozás (shallow copy): az objektum referencia típusú mezőit csak másoljuk
- mély klónozás (deep copy): az objektum referencia típusú mezőit is klónozzuk, így az új klón teljesen független lesz az eredetitől
- amikor alkalmazzuk:
    - ha sok hasonló objektumot kell létrehozni, és az objektumok létrehozása költséges
- például: gépkocsigyártás, ahol egy általános gépkocsi osztályból különböző járműtípusokat lehet létrehozni
- működése:
    - az eredeti objektumot klónozzuk, így új objektumot hozunk létre, amely az eredetivel azonos belső állapotú
    - a klónozáshoz a MemberwiseClone() metódust használjuk
- előnyök:
    - gyorsabb létrehozás, mint a teljes példányosítás
    - kevesebb memóriahasználat
- hátrányok:
    - néha bonyolult lehet a klónozási folyamat implementálása
    - a mély klónozás nehézségei

### Gyártómetódus – Factory Method

**Factory Method (Gyártómetódus)**:
- létrehozási tervezési minta, amely kiváltja a hasonló new utasításokat a kódban
- az ősosztály tartalmazza a gyártás algoritmusát
- a gyermekosztályok döntik el, hogy pontosan mit kell gyártani
- az algoritmus háromféle lépést tartalmazhat:
    - gyártás közös lépései: konkrét metódusok az ősben
    - gyártás kötelező változó lépései: absztrakt metódusok az ősben
    - gyártás opcionális lépései: horog metódusok az ősben
- amikor alkalmazzuk:
    - ha a gyártás folyamata ritkán változik, de a gyártandó objektum gyakran változik
- például: Office csomag alkalmazásai, ahol az "Új" menüpont különböző típusú dokumentumokat hoz létre
- működése:
    - az ősosztály tartalmazza a gyártómetódust, amely absztrakt metódusokat hív
    - a gyermekosztályok implementálják az absztrakt metódusokat
- előnyök:
    - könnyen bővíthető új termékekkel
    - az OCP elv betartása
- hátrányok:
    - növeli az osztályok számát és a kód komplexitását

### Absztrakt gyár – Abstract Factory

**Abstract Factory (Absztrakt gyár)**:
- létrehozási tervezési minta, amely több, egymással együttműködő objektumot gyárt
- több létrehozásra alkalmas metódust tartalmaz
- amikor alkalmazzuk:
    - ha egyszerre több dolgot gyártunk, amelyeknek összeépíthetőnek kell lenniük
- például: operációs rendszerhez (Windows, Mac, Linux) tartozó gombok és ablakok gyártása
- működése:
    - az absztrakt gyár tartalmazza a gyártásra szolgáló metódusokat
    - a konkrét gyárak implementálják ezeket a metódusokat
- előnyök:
    - biztosítja az összefüggő objektumok létrehozását
    - könnyen bővíthető új termékcsaládokkal
- hátrányok:
    - növeli az osztályok számát és a kód komplexitását

### Illesztő – Adapter

**Adapter (Illesztő)**:
- szerkezeti tervezési minta, amely átalakítja a becsomagolt objektum felületét a kívánt felületre
- nem átlátszó becsomagolást használ
- célja, hogy egy meglévő osztály felületét hozzáigazítsuk az elvárásainkhoz
- amikor alkalmazzuk:
    - ha egy régebben megírt osztályt akarunk újrahasznosítani egy új osztályhierarchiában
- például: európai/angol/amerikai konnektor adapterek
- működése:
    - az illesztő becsomagolja az illesztendő objektumot
    - az illesztő objektum az új felületet biztosítja
- előnyök:
    - lehetővé teszi a meglévő osztályok újrahasznosítását
    - könnyen integrálható a meglévő kódhoz
- hátrányok:
    - növeli a kód komplexitását
    - az illesztő és az illesztendő közötti kompozíció néha bonyolult lehet

### Díszítő – Decorator

**Decorator (Díszítő)**:
- szerkezeti tervezési minta, amely átlátszó becsomagolást használ
- lehetővé teszi az objektumok dinamikus bővítését anélkül, hogy megváltoztatnánk az eredeti osztályt
- az objektum-összetételben szereplő osztályok ugyanazon őstől származnak
- amikor alkalmazzuk:
    - ha új funkciókat akarunk hozzáadni egy osztályhoz anélkül, hogy megváltoztatnánk az eredeti kódot
- például: kávé bolt, ahol különböző kávék és extra kérések vannak
- működése:
    - egy absztrakt osztályból indul ki
    - az absztrakt osztály gyermekei lehetnek alaposztályok és díszítőosztályok
    - a díszítőosztályok kibővítik a becsomagolt példány funkcionalitását
- előnyök:
    - dinamikusan bővíthető funkcionalitás
    - az OCP elv betartása
- hátrányok:
    - növeli az osztályok számát és a kód komplexitását
    - a díszítők láncolása nehézségeket okozhat

### Helyettes – Proxy

**Proxy (Helyettes)**:
- szerkezeti tervezési minta, amely egy valamilyen szempontból érdekes példányt helyettesít
- a helyettes átlátszó módon csomagolja be az érdekes objektum

ot
- különböző típusai vannak, például virtuális proxy, távoli proxy, védelmi proxy
- amikor alkalmazzuk:
    - ha egy drága vagy távoli objektumot akarunk helyettesíteni
- például: egy proxyn keresztül megtudni, hogy mennyi az oldalszáma egy könyvnek
- működése:
    - a helyettes és az érdekes objektum közös őse van
    - a helyettes az érdekes objektum szolgáltatásait biztosítja
- előnyök:
    - csökkenti az erőforrások használatát
    - átlátszó módon biztosítja az objektum szolgáltatásait
- hátrányok:
    - növeli az osztályok számát és a kód komplexitását
    - néha nehéz kezelni a proxy és az eredeti objektum közötti kapcsolatot

### Állapot – State

**State (Állapot)**:
- viselkedési tervezési minta, amely lehetővé teszi egy objektum viselkedésének megváltoztatását az állapotának megfelelően
- egységbe zárja az állapotfüggő viselkedést
- amikor alkalmazzuk:
    - ha az objektum viselkedése függ az állapotától, és futás közben meg kell változtatnia a viselkedését
- például: egy fizetéshez kötött kapu nyitása és zárása
- működése:
    - az állapotokat külön osztályokba szervezzük
    - az objektum az aktuális állapotnak megfelelően delegálja a műveleteket az állapot osztályoknak
- előnyök:
    - könnyű új állapotok bevezetése
    - áttekinthetőbb kód
- hátrányok:
    - növeli az osztályok számát és a kód komplexitását

### Megfigyelő – Observer

**Observer (Megfigyelő)**:
- viselkedési tervezési minta, amely lehetővé teszi, hogy egy objektum megváltozása esetén értesíteni tudjon más objektumokat
- az alany tárolja a megfigyelőket és értesíti őket a változásokról
- két fajtája van: húzó (pull) és toló (push) megfigyelő
- amikor alkalmazzuk:
    - ha az objektumok közötti kapcsolat egy-sok kapcsolat, és a változások figyelésére van szükség
- például: hőmérséklet érzékelő, ami kiírja az adatokat a telefon és az ablak displayre
- működése:
    - az alany interfészt biztosít a megfigyelők be- és kiregisztrálására
    - a megfigyelők interfészt biztosítanak a frissítések fogadására
- előnyök:
    - laza kapcsolódás az alany és a megfigyelők között
    - könnyen bővíthető új megfigyelőkkel
- hátrányok:
    - nehéz lehet kezelni a sok megfigyelőt és a frissítési folyamatokat

### Sablonmetódus – Template Method

**Template Method (Sablonmetódus)**:
- viselkedési tervezési minta, amely egy általános receptet biztosít, amely alapján több hasonló dolog is gyártható
- a recept háromféle lépést tartalmazhat: kötelező és közös, kötelező, de nem közös, opcionális
- amikor alkalmazzuk:
    - ha van egy általános receptünk, amelyet több különböző kontextusban is használhatunk
- például: userhez kötött bejegyzések elmentése az adatbázisba
- működése:
    - az ősosztály tartalmazza a sablonmetódust
    - a gyermekosztályok implementálják a kötelező, de nem közös lépéseket
- előnyök:
    - a sablonmetódus közös lépései az ősosztályban vannak, így könnyen újrahasznosíthatók
    - az OCP elv betartása
- hátrányok:
    - növeli az osztályok számát és a kód komplexitását
    - az opcionális lépések felülírása nehézségeket okozhat

### Látogató – Visitor

**Visitor (Látogató)**:
- viselkedési tervezési minta, amely egy vagy több változékony metódust szervez ki egy másik osztály hierarchiába
- az adatszerkezetek feldolgozását különválasztja az adatszerkezettől
- amikor alkalmazzuk:
    - ha egy kiforrott adatszerkezetet akarunk feldolgozni, és könnyen bővíteni akarjuk az algoritmusok sorát
- például: egy bináris fa vagy lista feldolgozása különböző látogatók segítségével
- működése:
    - az adatszerkezet tartalmaz egy látogató fogadás metódust
    - a látogató implementálja a feldolgozó metódusokat
- előnyök:
    - könnyen bővíthető új látogatókkal
    - az adatszerkezet és a feldolgozó metódusok szétválasztása
- hátrányok:
    - ha megváltozik az adatszerkezet, az összes látogatót frissíteni kell
    - növeli az osztályok számát és a kód komplexitását