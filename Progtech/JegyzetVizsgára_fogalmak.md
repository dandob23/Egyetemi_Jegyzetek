### Fontos szabályok, módszerek, tervezési minták és egyéb fogalmak:

**Szabályok és elvek:**
- **Single Responsibility Principle (SRP):** Egy osztálynak csak egy okból kell változnia, azaz egyetlen felelőssége van .
- **Open/Closed Principle (OCP):** A szoftver entitások nyitottak a bővítésre, de zártak a módosításra .
- **Liskov Substitution Principle (LSP):** A származtatott osztályok helyettesíthetők az alaposztályukkal anélkül, hogy a program működése megváltozna .
- **Interface Segregation Principle (ISP):** A klienseknek nem szabad olyan interfészeket implementálniuk, amelyeket nem használnak .
- **Dependency Inversion Principle (DIP):** A magas szintű moduloknak nem szabad függeniük az alacsony szintű moduloktól, mindkettőnek az absztrakcióktól kell függenie .
- **DRY (Don't Repeat Yourself):** Minimalizálja a kódduplikációt a kód újrafelhasználhatóságának növelése érdekében .
- **KISS (Keep It Simple, Stupid):** A kód legyen egyszerű és könnyen érthető .
- **YAGNI (You Aren't Gonna Need It):** Csak a jelenlegi igényeket kielégítő funkcionalitás fejlesztése, elkerülve a felesleges bonyolítást .
- **Cserkészszabály:** Mindig hagyjuk a kódot tisztábban, mint ahogy találtuk .
- **Rothadó kód:** A kód, amelyet már nem mernek módosítani a programozók, mert félnek, hogy egy javítás újabb hibát okoz .

**Módszerek:**
- **Test Driven Development (TDD):** Először írjuk meg a teszteket, majd a hozzájuk tartozó kódot. A TDD ciklusa: piros teszt, zöld teszt, refaktorálás .
- **Folyamatos integráció (Continuous Integration):** A nap végén az összes változtatást integráljuk és teszteljük, hogy kiderüljön, azok képesek-e együttműködni .
- **Kódszépítés (Refactoring):** A már működő kód szerkezetének javítása anélkül, hogy a funkcionalitása megváltozna .
### Tervezési minták és leírásaik:

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
 **Példa:** Egy fájlrendszer elemzése különböző műveletekkel (pl. méret kiszámítása, fájlok listázása).
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

**Egyéb fontos fogalmak:**
- **Egységbezárás (Encapsulation):** Az adatokat és a hozzájuk tartozó metódusokat egy osztályban kell összekapcsolni, és az osztály belső állapotát el kell rejteni a külső hozzáférés elől .
- **Öröklődés (Inheritance):** Az öröklődés lehetővé teszi új osztályok létrehozását meglévő osztályok alapján .
- **Többalakúság (Polymorphism):** Lehetővé teszi, hogy különböző objektumokat azonos interfészen keresztül kezeljünk .
- **Szivárgó absztrakciók:** Az absztrakciók célja, hogy elrejtsék a komplexitást, de bizonyos esetekben a részletek "szivárognak" .
- **80/20 elv:** A fejlesztési folyamat során az idő 20%-ában valósul meg a végeredmény 80%-a .
- **Tapadás (Cohesion):** Az osztály belső elemeinek együttműködési képessége .
- **Kapcsoltság (Coupling):** Az osztályok közötti kapcsolatok erőssége .
