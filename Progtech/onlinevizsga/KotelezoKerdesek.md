#### Objektumorientált tervezési alapelvek

1. **Single Responsibility Principle (SRP):** Egy osztálynak csak egy okból kell változnia, azaz egyetlen felelőssége van .

2. **GOF1 (Gang of Four) - Programozz felületre implementáció helyett**:
   - A kódot úgy kell tervezni, hogy az interfészekre vagy absztrakt osztályokra hivatkozzon, nem pedig konkrét implementációkra. Ezáltal a rendszer rugalmasabb lesz, és könnyebben bővíthető vagy módosítható lesz.

3. **GOF2 - Használj objektum-összetételt öröklés helyett, ha csak lehet**:
   - Az objektumok közötti kapcsolatokat inkább összetétellel (kompozícióval) alakítsuk ki, mint örökléssel. Az összetétel rugalmasabb, mivel az objektumok viselkedése dinamikusan változtatható.

4. **HP (Hollywood Principle) - Ne hívj, majd mi hívunk**:
   - Az objektumok ne hívják közvetlenül más objektumok metódusait, hanem egy központi vezérlő mechanizmus segítségével hívják meg a szükséges metódusokat. Ez növeli a kód modularitását és karbantarthatóságát.

5. **OCP (Open-Closed Principle) - Az osztályok legyenek nyitottak a bővítésre, de zártak a módosításra**:
   - Az osztályokat úgy kell tervezni, hogy azok könnyen bővíthetőek legyenek új funkciókkal, anélkül, hogy a meglévő kódot módosítani kellene. Ezáltal a rendszer stabilabb és robusztusabb lesz.

6. **LSP (Liskov Substitution Principle) - Az alosztály legyen egyben altípus is**:
   - Az alosztályoknak olyan módon kell viselkedniük, hogy bármilyen helyen, ahol az alaposztály használható, az alosztály is használható legyen anélkül, hogy a program működése megváltozna.

7. **Interface Segregation Principle (ISP):** A klienseknek nem szabad olyan interfészeket implementálniuk, amelyeket nem használnak .

8. **DIP (Dependency Inversion Principle) - Absztrakciótól függj, ne függj konkrét osztályoktól**:
   - A magas szintű modulok ne függjenek alacsony szintű moduloktól, mindkettőnek absztrakcióktól kell függenie. Ezáltal a kód rugalmasabb és könnyebben tesztelhető lesz.
---
#### Tervezési alapelvek

1. **KISS (Keep It Simple, Stupid)**:
   - A kód legyen egyszerű és érthető. Az egyszerűség nem azt jelenti, hogy a kód primitív, hanem azt, hogy a szükséges funkcionalitást a lehető legkevesebb bonyolultsággal valósítja meg. Az egyszerű kód könnyebben olvasható, karbantartható és tesztelhető.

2. **YAGNI (You Aren't Gonna Need It)**:
   - Ne fejlesszünk le olyan funkciókat, amelyekre jelenleg nincs szükség, és amelyekre valószínűleg a jövőben sem lesz szükség. Ez segít elkerülni a felesleges bonyolultságot és a fejlesztési idő pazarlását.

3. **DRY (Don't Repeat Yourself)**:
   - Ne ismételjük meg ugyanazt a kódot több helyen. Az ismétlődő kódot különítsük el közös metódusokba vagy osztályokba, hogy a változtatásokat csak egy helyen kelljen elvégezni. Ez csökkenti a hibák esélyét és megkönnyíti a kód karbantartását.
---
#### Objektumorientált programozás alapelvei

1. **Egységbezárás (Encapsulation)**:
   - Az egységbezárás elv szerint az adatokat és a hozzájuk tartozó metódusokat egy osztályban kell összekapcsolni, és az osztály belső állapotát el kell rejteni a külső hozzáférés elől. Ezáltal az osztály belső állapota csak az osztály metódusain keresztül módosítható, ami növeli a biztonságot és a modularitást.

2. **Öröklődés (Inheritance)**:
   - Az öröklődés lehetővé teszi új osztályok létrehozását meglévő osztályok alapján, azokat kiterjesztve és új funkciókkal bővítve. Az öröklődés segít a kód újrafelhasználásában és a hierarchikus struktúrák kialakításában.

3. **Többalakúság (Polymorphism)**:
   - A többalakúság lehetővé teszi, hogy különböző objektumokat azonos interfészen keresztül kezeljünk, és az objektumok különböző módon reagáljanak ugyanarra a metódushívásra. Ezáltal a kód rugalmasabb és bővíthetőbb lesz.
---

#### SOLID Elvek
- **Single Responsibility Principle (SRP):**
  - Egy osztálynak csak egy okból kell változnia, azaz egyetlen felelőssége van.
- **Open/Closed Principle (OCP):**
  - A szoftver entitások nyitottak a bővítésre, de zártak a módosításra.
- **Liskov Substitution Principle (LSP):**
  - A származtatott osztályok helyettesíthetők az alaposztályukkal anélkül, hogy a program működése megváltozna.
- **Interface Segregation Principle (ISP):**
  - A klienseknek nem szabad olyan interfészeket implementálniuk, amelyeket nem használnak.
- **Dependency Inversion Principle (DIP):**
  - A magas szintű moduloknak nem szabad függeniük az alacsony szintű moduloktól, mindkettőnek az absztrakcióktól kell függenie.
---

#### Absztrakt alapelvek

1. **A program kódja állandóan változik**:
   - A szoftverfejlesztés során a kód folyamatosan módosul az új igények, a változó környezet, a hibajavítás és az optimalizálás miatt. Ezért fontos, hogy a kód jól strukturált, könnyen érthető és karbantartható legyen, hogy a későbbi változtatások könnyen végrehajthatóak legyenek.

2. **Separation of Concerns (Ügyek szétválasztása)**:
   - Az ügyek szétválasztása elv szerint a különböző funkcionális részeket külön modulokban, osztályokban vagy metódusokban kell kezelni. Ezáltal a rendszer egyes részei könnyebben érthetőek, tesztelhetőek és karbantarthatóak lesznek.

3. **A szoftver is csak egy termék**:
   - A szoftverfejlesztés során figyelembe kell venni a termék árával, gyártásával, forgalmazásával, minőségével, szabványaival és törvényi előírásaival kapcsolatos tényezőket. A szoftver is egy termék, amelynek előállítása és karbantartása költségekkel jár, és amelynek minősége meghatározza a felhasználói elégedettséget.

4. **Nincs Szent Grál**:
   - Nincs egyetlen, minden problémára alkalmazható megoldás a minőségi és olcsó szoftverfejlesztésre. Több különböző módszer és technika kombinációja szükséges a hatékony fejlesztéshez. Fontos a folyamatos tanulás és alkalmazkodás az új módszerekhez és technológiákhoz.

5. **Cserkészszabály:** Mindig hagyjuk a kódot tisztábban, mint ahogy találtuk .

6. **Rothadó kód:** A kód, amelyet már nem mernek módosítani a programozók, mert félnek, hogy egy javítás újabb hibát okoz .
---

#### Joel on Software inspirációk

1. **Szivárgó absztrakciók**:
   - Az absztrakciók célja, hogy elrejtsék a komplexitást, de bizonyos esetekben a részletek "szivárognak", és ezek a részletek befolyásolhatják a működést. Ezért fontos, hogy az absztrakciókat gondosan tervezzük meg, és figyeljünk arra, hogy valóban elrejtsék a komplexitást.

2. **80/20 elv**:
   - A fejlesztési folyamat során az idő 20%-ában valósul meg a végeredmény 80%-a. Ezért érdemes a fejlesztési időt hatékonyan beosztani, és a legfontosabb funkciókra koncentrálni.
---
#### Új elvek

1. **Tapadás (Cohesion)**:
   - Az osztály belső elemeinek (metódusok, attribútumok) együttműködési képessége. A magas kohézió azt jelenti, hogy az osztály elemei szorosan együttműködnek, és egy jól definiált feladatot látnak el. Ez növeli az osztály érthetőségét és karbantarthatóságát.

2. **Kapcsoltság (Coupling)**:
   - Az osztályok közötti kapcsolatok erőssége. A laza kapcsoltság azt jelenti, hogy az osztályok minimális függőséggel rendelkeznek egymás felé, ami növeli a rendszer modularitását és rugalmasságát.

3. **Állapot- és állapottér modellezése**:
   - Az objektumok belső állapotainak és az ezek közötti átmeneteknek a kezelése. Fontos, hogy az objektumok állapotváltozásait jól definiált szabályok szerint kezeljük, hogy a rendszer viselkedése kiszámítható legyen.

4. **Eseményvezérelt programozás**:
   - Az események alapján történő vezérlés azt jelenti, hogy a rendszer bizonyos események bekövetkezésekor hajt végre műveleteket. Ez a megközelítés növeli a rendszer rugalmasságát és reagáló képességét.
---
#### Módszerek

- **Test Driven Development (TDD):** Először írjuk meg a teszteket, majd a hozzájuk tartozó kódot. A TDD ciklusa: piros teszt, zöld teszt, refaktorálás .

- **Folyamatos integráció (Continuous Integration):** A nap végén az összes változtatást integráljuk és teszteljük, hogy kiderüljön, azok képesek-e együttműködni .

- **Kódszépítés (Refactoring):** A már működő kód szerkezetének javítása anélkül, hogy a funkcionalitása megváltozna .

---
### Létrehozási Tervezési Minták

#### Egyke – Singleton
- **Cél:**
  - Biztosítja, hogy egy osztályból csak egyetlen példány létezzen.
  - Globális hozzáférési pontot biztosít.
- **Megvalósítás:**
  - Privát konstruktor.
  - Statikus metódus a példány eléréséhez.
  - Statikus változó a példány tárolására.

#### Prototípus – Prototype
- **Cél:**
  - Új objektumok létrehozása meglévő objektumok másolásával (klónozás).
- **Megvalósítás:**
  - Clone metódus implementálása az objektumok klónozásához.
  - Sekély klónozás: Csak az objektum legfelső szintjének másolása.
  - Mély klónozás: Az összes beágyazott objektum másolása.

#### Gyártómetódus – Factory Method
- **Cél:**
  - Objektumok létrehozásának delegálása származtatott osztályokra.
- **Megvalósítás:**
  - Absztrakt metódus, amit a származtatott osztályok valósítanak meg.
  - Létrehozott objektum típusának későbbi meghatározása.

#### Absztrakt gyár – Abstract Factory
- **Cél:**
  - Kapcsolódó objektumok családjainak létrehozása.
- **Megvalósítás:**
  - Absztrakt osztály vagy interfész gyár metódusokkal.
  - Konkrét gyárak, amelyek különböző típusú objektumokat hoznak létre.

### Szerkezeti Tervezési Minták

#### Illesztő – Adapter
- **Cél:**
  - Meglévő osztály interfészének átalakítása az elvárt interfésszé.
- **Megvalósítás:**
  - Adapter osztály, amely implementálja a célintefészt és meghívja az adaptálandó osztály metódusait.

#### Díszítő – Decorator
- **Cél:**
  - Új funkcionalitás dinamikus hozzáadása objektumokhoz.
- **Megvalósítás:**
  - Alapkomponens és díszítő komponensek, amelyek ugyanazt az interfészt valósítják meg.
  - Díszítők, amelyek további viselkedést adnak az alapkomponenshez.

#### Helyettes – Proxy
- **Cél:**
  - Hozzáférés ellenőrzése és módosítása egy másik objektumhoz.
- **Megvalósítás:**
  - Proxy osztály, amely az eredeti objektummal azonos interfészt valósít meg.
  - Az eredeti objektumhoz való hozzáférés előtt további műveleteket végez.

### Viselkedési Tervezési Minták

#### Állapot – State
- **Cél:**
  - Objektum viselkedésének dinamikus változtatása állapottól függően.
- **Megvalósítás:**
  - Állapot interfész és konkrét állapot osztályok.
  - Kontextus osztály, amely az állapotok közötti váltást kezeli.

#### Megfigyelő – Observer
- **Cél:**
  - Egy objektum értesíti a megfigyelőket állapotváltozásáról.
- **Megvalósítás:**
  - Alany (subject) osztály, amely megfigyelők listáját kezeli.
  - Megfigyelő interfész, amely tartalmazza az értesítési metódust.

#### Sablonmetódus – Template Method
- **Cél:**
  - Általános algoritmus meghatározása, amelynek lépéseit a gyermekosztályok határozzák meg.
- **Megvalósítás:**
  - Absztrakt osztály, amely definiálja az algoritmus lépéseit.
  - Gyermekosztályok, amelyek implementálják az egyes lépéseket.
---

#### Objektumorientált tervezési minták

1. **Factory Method (Gyártó metódus)**:
   - Ez a minta egy metódust definiál, amely visszatér egy új objektummal, de nem specifikálja az objektum konkrét osztályát. Ez lehetővé teszi az objektumok dinamikus létrehozását, anélkül, hogy a kód függene a konkrét osztályoktól.

2. **Singleton (Egyke)**:
   - Az egyke minta biztosítja, hogy egy osztálynak csak egy példánya létezik, és ez az egy példány globálisan elérhető. Ez hasznos lehet például konfigurációs beállítások vagy erőforráskezelők esetében.

3. **Observer (Megfigyelő)**:
   - Ez a minta lehetővé teszi, hogy egy objektum (megfigyelt) értesítse a hozzá kapcsolódó objektumokat (megfigyelők) az állapotváltozásairól. Ezáltal a megfigyelők automatikusan reagálhatnak a megfigyelt objektum változásaira.

4. **Strategy (Stratégia)**:
   - A stratégia minta lehetővé teszi, hogy egy osztály viselkedését különböző stratégiákra bontsuk, és ezeket a stratégiákat dinamikusan váltsuk. Ezáltal a kód rugalmasabb és bővíthetőbb lesz.

5. **Decorator (Díszítő)**:
   - A díszítő minta lehetővé teszi, hogy dinamikusan új funkciókat adjunk egy objektumhoz anélkül, hogy megváltoztatnánk annak osztályát. Ez hasznos lehet például a felhasználói felület elemeinek testreszabásánál vagy a meglévő objektumok viselkedésének bővítésénél.
---

#### Tervezési minták és leírásaik:

**Abstract Factory (Absztrakt gyár):**
- **Leírás:** Az Abstract Factory minta egy interfészt biztosít a kapcsolódó vagy függő objektumok családjának létrehozásához anélkül, hogy megnevezné a konkrét osztályokat. Ez a minta lehetővé teszi, hogy az alkalmazás rugalmasan váltson különböző objektumcsaládok között.
- **Példa:** GUI könyvtárak, ahol különböző ablakkezelő rendszerekhez (pl. Windows, macOS) különböző UI elemeket kell létrehozni.
- **Előnyök:** Elősegíti a kapcsolódó objektumok következetes használatát, segíti a kód újrafelhasználhatóságát és karbantarthatóságát.
- **Hátrányok:** Bonyolultságot ad a kódhoz és növeli a tervezési időt.

**Builder (Építő):**
- **Leírás:** Az építő minta lehetővé teszi összetett objektumok létrehozásának eljárását különválasztva az objektum reprezentációjától. Ugyanaz a létrehozási folyamat különböző reprezentációkat eredményezhet.
- **Példa:** Egy éttermi rendelési rendszer, ahol különböző típusú menüket lehet összeállítani (pl. vegetáriánus menü, húsimádó menü).
- **Előnyök:** Egyszerűsíti az összetett objektumok létrehozását, lehetővé teszi az objektumok lépésenkénti létrehozását.
- **Hátrányok:** Megnöveli a kód méretét és bonyolultságát.

**Chain of Responsibility (Felelősségi lánc):**
- **Leírás:** Ez a minta lehetővé teszi, hogy egy kérés több objektum által kezelhető legyen. A kérés egy objektumláncon halad, amíg meg nem találja a felelős objektumot.
- **Példa:** Ügyfélszolgálati rendszer, ahol a kérdéseket különböző szintek kezelik (pl. első szintű támogatás, második szintű támogatás).
- **Előnyök:** Csökkenti a kapcsoltságot a kérés küldője és fogadója között, könnyen bővíthető új kezelőkkel.
- **Hátrányok:** Nehéz lehet követni a láncban történő kéréskezelést, a lánc hossza befolyásolhatja a teljesítményt.

**Command (Parancs):**
- **Leírás:** A Command minta egy műveletet objektummal reprezentál, lehetővé téve a műveletek paraméterezését, sorba állítását és visszavonását.
- **Példa:** Undo-redo rendszerek, ahol a műveletek visszavonhatók vagy újra végrehajthatók.
- **Előnyök:** Lehetővé teszi a műveletek visszavonását és újra végrehajtását, növeli a kód rugalmasságát.
- **Hátrányok:** Megnöveli a kód bonyolultságát és a műveleti osztályok számát.

**Composite (Kompozit):**
- **Leírás:** Ez a minta lehetővé teszi, hogy az objektumokat fákat alkotva hierarchiába rendezzük, ahol az egyes objektumok és az összetett objektumok egyaránt egyformán kezelhetők.
- **Példa:** Grafikus felhasználói felületek, ahol egy konténer tartalmazhat más konténereket és elemeket.
- **Előnyök:** Egyszerűsíti a hierarchikus adatszerkezetek kezelését, egységes interfészt biztosít.
- **Hátrányok:** Bonyolult lehet az összetett struktúrák létrehozása és kezelése.

**Facade (Homlokzat):**
- **Leírás:** A Facade minta egyszerűsített interfészt biztosít egy komplex alrendszerhez, csökkentve a külső osztályok közötti kapcsoltságot.
- **Példa:** Egy könyvtár használata, ahol a homlokzat egy egyszerű interfészt biztosít a könyvtár funkcióihoz.
- **Előnyök:** Csökkenti a kód összetettségét és növeli az olvashatóságot.
- **Hátrányok:** Eltakarhatja a komplexitást, ami a homlokzat mögött van, nehéz lehet a homlokzat fenntartása.

**Flyweight (Könnyűsúlyú):**
- **Leírás:** A Flyweight minta egy nagy számú finomszemcsés objektum hatékony kezelését teszi lehetővé a közös részek megosztásával.
- **Példa:** Karakterek megjelenítése szövegszerkesztőkben, ahol minden karakterhez egyetlen objektum tartozik.
- **Előnyök:** Csökkenti a memóriahasználatot és növeli a teljesítményt.
- **Hátrányok:** Bonyolult lehet az állapotkezelés és a szinkronizáció.

**Interpreter (Értelmező):**
- **Leírás:** Az Interpreter minta egy nyelv interpretálásának módját biztosítja, ahol a nyelv grammatikaelemeit osztályok reprezentálják.
- **Példa:** Egy matematikai kifejezés értelmezése és kiértékelése.
- **Előnyök:** Egyszerűsíti a nyelvek tervezését és implementálását.
- **Hátrányok:** Lassú lehet nagy és komplex nyelvek esetén.

**Iterator (Iterátor):**
- **Leírás:** Az Iterator minta egyszerű és egységes módot biztosít egy gyűjteményen történő iterációhoz anélkül, hogy a gyűjtemény belső struktúráját ismernünk kellene.
- **Példa:** Lista vagy tömb elemeinek bejárása.
- **Előnyök:** Egyszerűsíti a gyűjtemények bejárását, elrejti a belső implementációs részleteket.
- **Hátrányok:** Nem minden gyűjtemény esetén optimális teljesítményű.

**Mediator (Közvetítő):**
- **Leírás:** A Mediator minta egy objektum biztosítja a kommunikációt más objektumok között, csökkentve az osztályok közötti közvetlen kapcsolódásokat.
- **Példa:** GUI vezérlők kommunikációja egy központi vezérlő objektumon keresztül.
- **Előnyök:** Csökkenti a kapcsoltságot és a komplexitást, könnyebben karbantartható kódot eredményez.
- **Hátrányok:** A közvetítő maga válhat egy bonyolult, nehezen kezelhető objektummá.

**Memento (Emlék):**
- **Leírás:** A Memento minta lehetővé teszi egy objektum belső állapotának rögzítését anélkül, hogy a belső részletek feltárása szükséges lenne, így később az állapot visszaállítható.
- **Példa:** Szövegszerkesztők undo-redo funkciója.
- **Előnyök:** Elválasztja az állapot rögzítését és visszaállítását az objektum implementációjától.
- **Hátrányok:** Növeli a memóriahasználatot, bonyolult lehet az állapotok kezelése.

**Prototype (Prototípus):**
- **Leírás:** Az új objektumok létrehozása egy meglévő objektum másolásával, elkerülve a költséges és komplex inicializálást.
- **Példa:** Egy űrlapmező alapértelmezett értékekkel való másolása.
- **Előnyök:** Gyorsabb objektumlétrehozás, elkerülhető az összetett inicializáció.
- **Hátrányok:** Az objektumok klónozása bonyolult lehet, különösen, ha az objektumok mély másolatokat igényelnek.

**Visitor (Látogató):**
- **Leírás:** A Visitor minta lehetővé teszi, hogy új műveleteket definiáljunk egy objektumstruktúrára anélkül, hogy megváltoztatnánk az osztályokat, amelyeken a műveleteket végzik.
- **Példa:** Egy fájlrendszer elemzése különböző műveletekkel (pl. méret kiszámítása, fájlok listázása).
- **Előnyök:** Lehetővé teszi új műveletek hozzáadását anélkül, hogy megváltoztatnánk az objektumstruktúrát.
- **Hátrányok:** Nehézkes lehet új objektumtípusok hozzáadása.

**Decorator (Díszítő):**
- **Leírás:** A Decorator minta új funkciókat adhat egy objektumhoz anélkül, hogy megváltoztatná annak osztályát.
- **Példa:** Egy grafikus objektumhoz különböző dekorációk hozzáadása (pl. keret, árnyék).
- **Előnyök:** Rugalmas módot biztosít az objektumok kiterjesztésére, összetett objektumokat hozhat létre a kis, egyszerű dekorátorok kombinálásával.
- **Hátrányok:** Bonyolulttá válhat, ha sok dekorátort használnak.

**Template Method (Sablonmetódus):**
- **Leírás:** A Template Method minta általános algoritmus meghatározását teszi lehetővé, amelynek lépéseit a gyermekosztályok határozzák meg.
- **Példa:** Egy adatsor feldolgozásának lépései, ahol az egyes lépések specifikus megvalósításait a gyermekosztályok határozzák meg.
- **Előnyök:** Lehetővé teszi az algoritmus részleteinek újrahasznosítását és testreszabását.
- **Hátrányok:** A kód bonyolulttá válhat, ha sok specifikus implementáció van.

**Adapter (Illesztő):**
- **Leírás:** Az Adapter minta meglévő osztály interfészének átalakítása az elvárt interfésszé.
- **Példa:** Egy régi rendszer illesztése egy új rendszerhez.
- **Előnyök:** Lehetővé teszi a régi és új rendszerek együttműködését anélkül, hogy a meglévő kódot módosítani kellene.
- **Hátrányok:** További réteget ad a kódhoz, ami bonyolultságot és teljesítménycsökkenést okozhat.

**Proxy (Helyettes):**
- **Leírás:** A Proxy minta hozzáférést biztosít egy másik objektumhoz, ellenőrizve vagy módosítva annak működését.
- **Példa:** Távvezérelt objektumok vagy védett erőforrások elérése.
- **Előnyök:** Biztonsági és teljesítményjavításokat kínál, lehetővé teszi a hozzáférés vezérlését és optimalizálását.
- **Hátrányok:** Megnöveli a komplexitást, lassíthatja a teljesítményt a további réteg miatt.

**State (Állapot):**
- **Leírás:** Az State minta lehetővé teszi egy objektum viselkedésének dinamikus változtatását az aktuális állapotától függően.
- **Példa:** Egy automatában lévő állapotok (pl. érme behelyezése, áru kiválasztása).
- **Előnyök:** Egyszerűsíti a kódot, amely különböző állapotokat kezel, és elősegíti a karbantarthatóságot.
- **Hátrányok:** Megnöveli az osztályok számát és a kód bonyolultságát.