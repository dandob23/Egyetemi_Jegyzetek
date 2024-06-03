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
