### Architekturális Minták

#### MVC – Model-View-Controller
- **Model (modell):**
  - Feladata az adatok tárolása, kezelése és az üzleti logika megvalósítása.
  - Interakció az adatbázissal vagy egyéb adatforrásokkal.
  - Tartalmazza az adatokat, állapotokat és az azokon végzett műveleteket.
- **View (nézet):**
  - Feladata a felhasználói felület megjelenítése.
  - Visszajelzések kezelése a felhasználótól.
  - A modelltől kapott adatokat jeleníti meg.
- **Controller (vezérlő):**
  - Kezeli a felhasználói bemeneteket és vezérli a modellt.
  - Értesíti a nézetet az adatok frissítéseiről.
  - Üzleti logika és adatfolyamatok koordinálása.

#### MVVM – Model-View-ViewModel
- **Model (modell):** Az adatok kezelése és üzleti logika.
- **View (nézet):** Felhasználói felület megjelenítése és interakciók kezelése.
- **ViewModel (nézetmodell):**
  - Közvetítő a modell és a nézet között.
  - Üzleti logika nézethez kötött részének megvalósítása.
  - Kétirányú adatbinding támogatása, így a nézet automatikusan frissül az adatok változásakor.

#### Többrétegű Architektúra
- **Felhasználói felület:**
  - Grafikus felület a felhasználói interakcióhoz.
  - Interfész a rendszer funkcióinak eléréséhez.
- **Üzleti logika:**
  - Az alkalmazás fő logikai folyamatainak megvalósítása.
  - Adatfeldolgozás és üzleti szabályok implementálása.
- **Adatbázis:**
  - Adatok tárolása és visszaolvasása.
  - Adatbázis-műveletek végrehajtása.

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

### Tervezési Szabályok

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

#### DRY – Don’t Repeat Yourself
- Minimalizálja a kódduplikációt a kód újrafelhasználhatóságának növelése érdekében.

#### KISS – Keep It Simple, Stupid
- A kódnak egyszerűnek és könnyen érthetőnek kell lennie.

#### YAGNI – You Aren't Gonna Need It
- Csak a jelenlegi igényeket kielégítő funkcionalitás fejlesztése, elkerülve a felesleges bonyolítást.

A tervezési minták és szabályok alkalmazása segít abban, hogy a szoftver könnyen karbantartható, bővíthető és olvasható legyen, valamint hogy a fejlesztési folyamat hatékonyabbá váljon.