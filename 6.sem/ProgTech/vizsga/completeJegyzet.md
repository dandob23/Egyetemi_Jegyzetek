Mivel a PDF közvetlen kivonása problémás, manuálisan fogom átnézni az első fejezetet és ellenőrzöm, hogy van-e bármi fontos részlet, amit kihagytam. Elnézést a kellemetlenségért.

### 1. Fejezet: Bevezetés

#### Fogalmak
- **Mesterséges Intelligencia (MI):** Olyan technológiai megoldás, amely képes programozni és segíteni a programozók munkáját.
- **LLM (Large Language Model):** Nagy nyelvi modellek, amelyek programozási feladatokat is képesek ellátni.
- **AGI (Artificial General Intelligence):** Általános mesterséges intelligenciák, amelyekkel bármiről lehet beszélgetni, programozásról is.
- **ANI (Artificial Narrow Intelligence):** Szűk MI, amely kifejezetten a programozók munkáját segíti.
- **Junior Tervező:** Olyan új szakma, amely a tervezési ismereteket és kompetenciákat helyezi előtérbe a programozási ismeretekkel szemben.

#### Fontos részletek
- **AI megoldások:** Jelenleg legismertebb AGI megoldások a ChatGPT, Google PaLM és Gemini, ANTHROPI/C Claude 3, Meta LLaMA.
- **Prompt Engineering:** Célirányosan kérdező szakemberek képzése, hogy az MI segítségét hatékonyan ki tudják használni.
- **Medior Programozók képzése:** Az oktatásnak lehetővé kell tennie a hallgatók specializálódását és piacképes medior programozók képzését.
- **Junior Tervezők képzése:** Az oktatásban elmélyült tervezési ismereteket kell nyújtani a felsőoktatásban.
- **Soft Skill-ek fejlesztése:** A csapatmunka készségeinek fejlesztése elengedhetetlen a programozó képzésben.
- **Üzleti Elemző:** A megrendelő üzleti folyamatait megérti és javítási javaslatokat tesz.
- **Rendszerelemző:** A rendszertervet elkészíti és a fejlesztési folyamatot irányítja.
- **Folyamatelemző:** Az üzleti folyamatokat javítja és automatizálja.
- **Szakmai kihívás:** A MI fejlődése átveheti a junior programozók munkáját, ezért a képzésnek reagálnia kell.
- **Tervezői szakmák:** Üzleti elemző, rendszerelemző, folyamatelemző, követelményelemző, adatelemző, változáselemző.
- **Rendszerterv és backlog:** A rendszerterv a tervezési folyamat eredménye, a backlog pedig a feladatok folyamatosan bővülő listája.
- **Szoftverkrízis:** A szoftverfejlesztési projektek gyakori sikertelenségének okai és válaszok rájuk, például a tervezési alapelvek és minták bevezetése.
- **Használati eset alapú tervezés:** A használati esetek (use cases) alapján történő tervezés, amely segít a rugalmas és bővíthető architektúra kialakításában.

Ezek a legfontosabb pontok és fogalmak, amelyeket az első fejezet alapján érdemes kiemelni. Ha szükséges, további részletekkel is kiegészíthetem. Kérlek, jelezd, ha folytassam a következő fejezettel!

### 2.1 Fejezet: Információs rendszerek életciklusa

#### Fogalmak
- **Szoftverfejlesztés életciklusa (SDLC):** A szoftver életének állomásait írja le az igény megszületésétől az átadásig és továbbfejlesztéséig.
- **Követelményspecifikáció (Requirement Analysis):** Az igények és követelmények elemzése és meghatározása.
- **Funkcionális specifikáció (Functional Analysis):** A rendszerjavaslat kidolgozása, beleértve az ütemtervet és szerződéskötést.
- **Rendszerspecifikáció (Analysis & Design):** A megvalósíthatósági tanulmány és a nagyvonalú rendszerterv elkészítése.
- **Logikai és fizikai rendszerterv (Analysis & Design):** A rendszer logikai és fizikai tervének elkészítése.
- **Implementáció (Implementation):** A szoftver megvalósítása.
- **Tesztelés (Testing & Validation):** Teszttervek, tesztesetek, tesztnaplók készítése és a szoftver validálása.
- **Rendszerátadás és bevezetés (Delivery & Deployment):** A felhasználói dokumentáció elkészítése és a rendszer átadása.
- **Üzemeltetés és karbantartás (Operating & Maintenance):** A rendszeres mentések és karbantartási feladatok ellátása.
- **Hagyaték rendszer (Legacy System):** Kiöregedett információs rendszer, amely elavult programozási nyelvet vagy hardvert használ.

#### Fontos részletek
- **Ciklikusság:** A szoftver életciklusa ciklikus, mivel az új igények újabb fejlesztéseket indítanak el.
- **Elöregedés:** Gyakorlati szempontból a szoftver és környezete elöregszik, és előbb-utóbb már nem lesz programozó, aki ismerné a programozási nyelvet, amin íródott.
- **SDLC lépései:**
  1. **Új igény felmerülése**
  2. **Igények elemzése és meghatározása**
  3. **Rendszerjavaslat kidolgozása**
  4. **Rendszerspecifikáció**
  5. **Logikai és fizikai tervezés**
  6. **Implementáció**
  7. **Tesztelés**
  8. **Rendszerátadás és bevezetés**
  9. **Üzemeltetés és karbantartás**
  10. **Új igény felmerülése**

#### Kép
![Szoftverfejlesztés életciklusa](https://github.com/dandob23/jegyzetek/blob/main/Progtech/1abra.PNG)

Ezzel a jegyzettel teljesítettük a 2.1 fejezet összefoglalását. Ha minden rendben, folytassuk a következő fejezettel!


### Az objektumorientált tervezés alapelvei

#### Absztrakt alapelvek

1. **A program kódja állandóan változik**:
   - A szoftverfejlesztés során a kód folyamatosan módosul az új igények, a változó környezet, a hibajavítás és az optimalizálás miatt. Ezért fontos, hogy a kód jól strukturált, könnyen érthető és karbantartható legyen, hogy a későbbi változtatások könnyen végrehajthatóak legyenek.

2. **Separation of Concerns (Ügyek szétválasztása)**:
   - Az ügyek szétválasztása elv szerint a különböző funkcionális részeket külön modulokban, osztályokban vagy metódusokban kell kezelni. Ezáltal a rendszer egyes részei könnyebben érthetőek, tesztelhetőek és karbantarthatóak lesznek.

3. **A szoftver is csak egy termék**:
   - A szoftverfejlesztés során figyelembe kell venni a termék árával, gyártásával, forgalmazásával, minőségével, szabványaival és törvényi előírásaival kapcsolatos tényezőket. A szoftver is egy termék, amelynek előállítása és karbantartása költségekkel jár, és amelynek minősége meghatározza a felhasználói elégedettséget.

4. **Nincs Szent Grál**:
   - Nincs egyetlen, minden problémára alkalmazható megoldás a minőségi és olcsó szoftverfejlesztésre. Több különböző módszer és technika kombinációja szükséges a hatékony fejlesztéshez. Fontos a folyamatos tanulás és alkalmazkodás az új módszerekhez és technológiákhoz.

#### Tervezési alapelvek

1. **KISS (Keep It Simple, Stupid)**:
   - A kód legyen egyszerű és érthető. Az egyszerűség nem azt jelenti, hogy a kód primitív, hanem azt, hogy a szükséges funkcionalitást a lehető legkevesebb bonyolultsággal valósítja meg. Az egyszerű kód könnyebben olvasható, karbantartható és tesztelhető.

2. **YAGNI (You Aren't Gonna Need It)**:
   - Ne fejlesszünk le olyan funkciókat, amelyekre jelenleg nincs szükség, és amelyekre valószínűleg a jövőben sem lesz szükség. Ez segít elkerülni a felesleges bonyolultságot és a fejlesztési idő pazarlását.

3. **DRY (Don't Repeat Yourself)**:
   - Ne ismételjük meg ugyanazt a kódot több helyen. Az ismétlődő kódot különítsük el közös metódusokba vagy osztályokba, hogy a változtatásokat csak egy helyen kelljen elvégezni. Ez csökkenti a hibák esélyét és megkönnyíti a kód karbantartását.

#### Objektumorientált programozás alapelvei

1. **Egységbezárás (Encapsulation)**:
   - Az egységbezárás elv szerint az adatokat és a hozzájuk tartozó metódusokat egy osztályban kell összekapcsolni, és az osztály belső állapotát el kell rejteni a külső hozzáférés elől. Ezáltal az osztály belső állapota csak az osztály metódusain keresztül módosítható, ami növeli a biztonságot és a modularitást.

2. **Öröklődés (Inheritance)**:
   - Az öröklődés lehetővé teszi új osztályok létrehozását meglévő osztályok alapján, azokat kiterjesztve és új funkciókkal bővítve. Az öröklődés segít a kód újrafelhasználásában és a hierarchikus struktúrák kialakításában.

3. **Többalakúság (Polymorphism)**:
   - A többalakúság lehetővé teszi, hogy különböző objektumokat azonos interfészen keresztül kezeljünk, és az objektumok különböző módon reagáljanak ugyanarra a metódushívásra. Ezáltal a kód rugalmasabb és bővíthetőbb lesz.

#### Objektumorientált tervezési alapelvek

1. **GOF1 (Gang of Four) - Programozz felületre implementáció helyett**:
   - A kódot úgy kell tervezni, hogy az interfészekre vagy absztrakt osztályokra hivatkozzon, nem pedig konkrét implementációkra. Ezáltal a rendszer rugalmasabb lesz, és könnyebben bővíthető vagy módosítható lesz.

2. **GOF2 - Használj objektum-összetételt öröklés helyett, ha csak lehet**:
   - Az objektumok közötti kapcsolatokat inkább összetétellel (kompozícióval) alakítsuk ki, mint örökléssel. Az összetétel rugalmasabb, mivel az objektumok viselkedése dinamikusan változtatható.

3. **HP (Hollywood Principle) - Ne hívj, majd mi hívunk**:
   - Az objektumok ne hívják közvetlenül más objektumok metódusait, hanem egy központi vezérlő mechanizmus segítségével hívják meg a szükséges metódusokat. Ez növeli a kód modularitását és karbantarthatóságát.

4. **OCP (Open-Closed Principle) - Az osztályok legyenek nyitottak a bővítésre, de zártak a módosításra**:
   - Az osztályokat úgy kell tervezni, hogy azok könnyen bővíthetőek legyenek új funkciókkal, anélkül, hogy a meglévő kódot módosítani kellene. Ezáltal a rendszer stabilabb és robusztusabb lesz.

5. **LSP (Liskov Substitution Principle) - Az alosztály legyen egyben altípus is**:
   - Az alosztályoknak olyan módon kell viselkedniük, hogy bármilyen helyen, ahol az alaposztály használható, az alosztály is használható legyen anélkül, hogy a program működése megváltozna.

6. **DIP (Dependency Inversion Principle) - Absztrakciótól függj, ne függj konkrét osztályoktól**:
   - A magas szintű modulok ne függjenek alacsony szintű moduloktól, mindkettőnek absztrakcióktól kell függenie. Ezáltal a kód rugalmasabb és könnyebben tesztelhető lesz.



#### Joel on Software inspirációk

1. **Szivárgó absztrakciók**:
   - Az absztrakciók célja, hogy elrejtsék a komplexitást, de bizonyos esetekben a részletek "szivárognak", és ezek a részletek befolyásolhatják a működést. Ezért fontos, hogy az absztrakciókat gondosan tervezzük meg, és figyeljünk arra, hogy valóban elrejtsék a komplexitást.

2. **80/20 elv**:
   - A fejlesztési folyamat során az idő 20%-ában valósul meg a végeredmény 80%-a. Ezért érdemes a fejlesztési időt hatékonyan beosztani, és a legfontosabb funkciókra koncentrálni.

#### Új elvek

1. **Tapadás (Cohesion)**:
   - Az osztály belső elemeinek (metódusok, attribútumok) együttműködési képessége. A magas kohézió azt jelenti, hogy az osztály elemei szorosan együttműködnek, és egy jól definiált feladatot látnak el. Ez növeli az osztály érthetőségét és karbantarthatóságát.

2. **Kapcsoltság (Coupling)**:
   - Az osztályok közötti kapcsolatok erőssége. A laza kapcsoltság azt jelenti, hogy az osztályok minimális függőséggel rendelkeznek egymás felé, ami növeli a rendszer modularitását és rugalmasságát.

3. **Állapot- és állapottér modellezése**:
   - Az objektumok belső állapotainak és az ezek közötti átmeneteknek a kezelése. Fontos, hogy az objektumok állapotváltozásait jól definiált szabályok szerint kezeljük, hogy a rendszer viselkedése kiszámítható legyen.

4. **Eseményvezérelt programozás**:
   - Az események alapján történő vezérlés azt jelenti, hogy a rendszer bizonyos események bekövetkezésekor hajt végre műveleteket. Ez a megközelítés növeli a rendszer rugalmasságát és reagáló képességét.


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

Ezek az alapelvek és tervezési minták segítenek a szoftverfejlesztőknek hatékonyabb és karbantarthatóbb rendszereket építeni, amelyek jobban alkalmazkodnak a változó igényekhez és környezethez.


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
