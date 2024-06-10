### Fogalmak és Definíciók

#### Generatív Nyelvtan
- **N**: Nemterminális jelek – a nyelvtan szimbólumai, amelyek további szimbólumokra bonthatók.
- **T**: Terminális jelek – a nyelv legkisebb egységei, amelyeket nem lehet tovább bontani.
- **P**: Szabályok halmaza – azok a szabályok, amelyek meghatározzák, hogyan alakulnak át a nemterminális jelek.
- **S**: Kezdő szimbólum – a nyelvtan kiindulási pontja, amiből a mondatok generálhatók.
- **Zárt szóhalmaz**: Az összes szóból és az üres szóból álló halmaz.
- **Üresszó lemma**: Az állítás, miszerint egy környezetfüggetlen nyelv csak akkor tartalmazza az üres szót, ha a kezdő szimbólum levezeti az üres szót.

#### Chomsky Hierarchia
- **0. típus**: Mondatszerkezetű nyelvtanok – minden szabályra igaz, hogy bármelyik szimbólum helyettesíthető.
- **1. típus**: Monoton és környezetfüggő nyelvek – a szabályok jobboldala hosszabb vagy egyenlő hosszúságú, mint a baloldala.
- **2. típus**: Környezetfüggetlen nyelvek – szabályok alakja: `A -> u`, ahol `A` eleme `N`, `u` eleme `(T ∪ N)*`.
  - `megjegyzés (T ∪ N)* = Az összes létező terminális és nem terminális jelek + üres szavak halmaza`
- **3. típus**: Reguláris nyelvek – szabályok alakja: `A -> aB` vagy `A -> a` (jobblineáris) és `A -> Ba` vagy `A -> a` (ballineáris).
#### Típusok
- **0. típus**: Turing gép – minden számítható feladat megoldására képes, determinisztikus és nemdeterminista változata is van.
  - `megjegyzés: determinisztikus = minden állapotban egyértelműen meghatározott, hogy mi lesz a következő állapot a jelenlegi állapot és a bemeneti érték alapján.`
  - `megjegyzés: nemdeterminista = egy adott állapot és bemenet esetén több lehetséges következő állapot is létezhet, és nem egyértelmű, hogy melyik lesz a következő állapot.`
- **1. típus**: Lineárisan korlátozott automata – egy Turing gép, amelynek szalagja csak egy előre meghatározott hosszúságú lehet.
- **2. típus**: Veremautomata – olyan automata, amely egy veremet használ, determinisztikus és nemdeterminista változata is van.
  - **Egyszer forduló veremautomata**: Kétfejű véges automata, amely csak egyszer mehet végig a veremen.
  - `megjegyzés: verem = egy adatstruktúra, amely az elemeket LIFO (Last In, First Out - utolsóként be, elsőként ki) sorrendben kezeli, vagyis az utoljára betett elem kerül először kivételre. (Pl: szövegszerkesztő visszavonás funkció)`
- **3. típus**: Véges automaták – állapotok és átmenetek véges halmazával dolgoznak, determinisztikus és nemdeterminista változata is van.
  - **2 fejű véges automaták**: Olyan véges automaták, amelyek két olvasó fejjel rendelkeznek.

### Normálformák

- #### Reguláris nyelvek
  - **Gyenge normálforma:**
    - **Szabályok**: `A -> aB` vagy `A -> a`.
    - minden szabály legfeljebb **egy nemterminális** és **egy terminális** szimbólumból állhat.
  - **Erős normálforma:**
    - **Szabályok**: `A -> BC` vagy `A -> a`.
    - minden szabály **vagy két nemterminális szimbólumra bontja a bal oldali nemterminálist**, vagy **egy terminális** szimbólumra cseréli.

- #### Lineáris nyelvek
  - **Lineáris nyelvek:**
    - **Szabályok**: `A -> uBv` vagy `A -> u`.
    - **terminális szimbólumok közbeiktatása** : **egy nemterminális** szimbólumot **egy terminális szimbólumokból álló sorozatra** és **egy másik nemterminális** szimbólumra bontsunk.

- #### Környezetfüggetlen nyelvek
  - **Chomsky-féle normálforma:**
    - **Szabályok**: `A -> BC` vagy `A -> a`.
    - vagy **két nemterminális szimbólum** kombinációjává alakítja **a bal oldali nemterminálist**, vagy **egy terminális** szimbólumra cseréli.
  - **Greibach-féle normálforma:**
    - **Szabályok**: `A -> aα`.
    - **egy terminális szimbólummal kezdődnek**, amelyet **egy** *(esetleg üres)* **nemterminális szimbólumsorozat** követ.

- #### Környezetfüggő nyelvek
  - **Kuroda normálforma:**
    - **Szabályok**: Az összes környezetfüggő nyelvtan átalakítható erre a formára.
    - **minden környezetfüggő nyelvtant** egy egységesített formára alakítsunk át
    - megkönnyíti a nyelvtanok **elemzését** és **feldolgozását**.
  - **Penttonen-féle normálforma:**
    - **Szabályok**: `AB -> AC`, `A -> a`.
    - **két nemterminális szimbólumot** **egy nemterminális** és **egy másik nemterminális** szimbólumra cserélnek, vagy **egy nemterminális szimbólumot egy terminális szimbólumra**.
  - **Geffert-normálformák:**
    - **Szabályok**: Speciális környezetfüggő nyelvtan normálformák.
    - **speciális környezetfüggő** nyelvtanokat egyszerűsítenek
    - megkönnyítik a nyelvtan **szerkezetének** és **viselkedésének elemzését**.
  

### Egyéb Normálformák
#### Révész-féle trükk
- `AB → CD`.
- Egy **egyszerűsítési módszer** a nyelvtanokban.
- lehetővé teszi, hogy a nyelvtanokat **egyoldalú szabályokra bontsuk**
- segít **átalakítani és egyszerűsíteni** a nyelvtani szabályokat.
- Például egy összetett szabály, mint `AB → CD`, több egyszerűbb szabályra bontható.

#### Révész-féle egyoldali normálforma
- `A → aB vagy A → a`.
- **minden szabály egy terminális szimbólummal kezdődik**.
- biztosítja, hogy a nyelvtan szabályai **egyszerűek és egyoldalúak** legyenek
- megkönnyíti a nyelvtanok **feldolgozását és elemzését**.
  
### Reguláris kifejezések ekvivalenciái
#### Asszociatív
- `(a + b) + c = a + (b + c)`.
- **a kifejezések csoportosítása nem befolyásolja az eredményt**. 
- Ez hasznos a reguláris kifejezések **egyszerűsítés**énél.

#### Kommutatív
- `a + b = b + a`.
- **a kifejezések sorrendje nem számít** az unió műveletnél. 
- Ez lehetővé teszi a reguláris kifejezések **rugalmasabb** használatát.

#### Unió normálforma
- **Szabály:** Egy speciális forma, amelyben unió műveletek szerepelnek.
- **Példa:** `a(b + c)d`
- olyan reguláris kifejezések speciális formája, amelyben az **unió műveletek vannak kiemelve**. 
- Az ilyen formák segítenek a kifejezések **strukturáltabb elemzés**ében.

#### Uniómentes nyelvek
- **Szabály:** Nyelvek, amelyek nem használnak unió műveleteket.
- **Példa:** `ab^c`
- nem tartalmaznak alternatívákat a reguláris kifejezésekben. 
- Ezek a nyelvek **egyszerűbb struktúrával rendelkeznek**, mivel **nem használnak uniót**.

---

### Speciális Automaták

#### Determinista veremautomata
- **Példa**: Egy veremautomata, amely **minden konfigurációban legfeljebb egy** átmenetet engedélyez.
- **minden adott állapotban** és veremkonfigurációban **legfeljebb egy lehetséges átmenetet engedélyeznek**
- az automata **működése** teljesen **meghatározott**.
- Nyelvi feldolgozásnál és szintaktikai elemzésnél, ahol egyértelműségre van szükség.

#### Számlálónyelvek
- **Példa**: Veremben **csak egyféle** veremszimbólum van.
- a veremben **csak egy** típusú szimbólumot használunk
- lehetővé teszi a verem **aktuális tartalmának egyszerű számlálását**.
- Egyszerűbb nyelvek modellezésére használjuk, ahol **a verem csak a szimbólumok számát** tartja nyilván.

#### Egyszer fordulós veremautomata
- `A → aB vagy A → a` 
- **egy input szó** feldolgozása során **csak egyszer** használhatja a verem tartalmát.
- **Lineáris nyelvek** elfogadására használjuk, ahol **a veremhasználat korlátozott**, és **az automata egyszerűsíthető**.

#### Fraktál automata
- **Példa**: Egy speciális véges automata, amely **komplex mintázatokat** képes előállítani.
- **komplex, önhasonló struktúrákat képes generálni**
- **Komplex mintázatok és struktúrák modellezésére és generálására**, például a számítógépes grafikában és a mintafelismerésben.
- `megjegyzés: önhasonló = egy objektum vagy alakzat részei hasonlóak az egészhez / az alakzat kisebb méretű másolatai megtalálhatók az eredeti alakzaton belül / minden kisebb része hasonlít az egész alakzatra.`

--- 

#### Egyéb Definíciók
- **Cayley táblázat**: Véges csoportok műveleteinek ábrázolására szolgál.
- **S(delta) függvény**: Az átmenetfüggvény speciális formája.


### Algoritmusok és Szintaxis


### Algoritmusok működése
#### CYK (Cocke-Younger-Kasami) Algoritmus
-   A  **Chomsky normálformájú környezetfüggetlen nyelvekben, a szavak felismerésére használt algoritmus**.
-   **dinamikus programozást**  használ a szó  **minden lehetséges szakaszának ellenőrzésére**, hogy megfelel-e a Chomsky normálformában definiált szabályoknak.
- **Működés**:
  - **Tábla inicializálása**: **háromszög alakú táblázat**, ahol **a cellák jelölik a szótöredékeket**.
  - **Alap esetek kitöltése**: **a szó minden egyes betűjének azonosítása** a szabályok alapján, **első sor celláinak kitöltése**.
  - **Rekurzív kitöltés**: **táblázaton** való **végig haladás**, minden cellánál **a két alsó cellából generálható kombinációk megnézése** a nyelvtan szabályai alapján
  - **Elfogadás ellenőrzése**: Ha **a kezdő szimbólum** a legfelső cellában **megtalálható**, a szó **elfogadható**.
- **Példa**: Az `"aabb"` szó felismerésekor a táblázat kitöltése során az `S -> AB`, `A -> a`, és `B -> b` szabályokat használjuk.

#### Early Algoritmus
-  **Környezetfüggetlen nyelvek elemzésére használjuk**
-  **Nincs szükség Chomsky normálformára átalakításra**.
- **Működés**:
  - **Kezdőállapot inicializálása**: **kezdő szimbólum hozzáadása a kezdő állapothoz**, **üres tábla létrehozása** a szóra
  - **Szabályok alkalmazása**: a nyelvtan **szabályainak alkalmazása minden állapotban**, új **nemterminális szimbólumok generálása**
  - **Predikció és visszalépés**: további **szabályok prediktálása** a nemterminális szimbólumok alapján, **szükség esetén visszalép** az előző állapotra
  - **Elfogadás ellenőrzése**: a szó **elfogadható**, ha **a teljes szót bejárta**, a kezdő szimbólum **visszajut a kiinduló állapotba**
- **Példa**: Az `"aabb"` szó elemzésekor a szabályok közvetlen alkalmazásával és predikcióval vizsgálja, hogy a szó megfelel-e a nyelvtannak anélkül, hogy előzetesen Chomsky normálformára alakítaná.

#### Szintaxis Gráf
- Az automata **állapotainak** és **átmeneteinek ábrázolása gráfként**.
- **Példa**: Egy **véges** automata állapotainak és az állapotok közötti átmenetek grafikus ábrázolása.
- **vizuálisan jeleníti meg** az automata **működését**
- **segíti** a nyelvtan és az automata közötti kapcsolat **megértését**.

#### Lemma
- **Bizonyítja**, hogy **egy adott nyelv** a szabályai szerint **generálható**.
- **Példa**: A *Pumping lemma* bizonyítja, hogy **egy reguláris nyelv** esetén minden **elég** hosszú szó **felbontható három részre** úgy, hogy **a középső rész ismétlésével** **a szó továbbra is a nyelv része marad**.
- **formális eszközként szolgál** a nyelv **tulajdonságainak igazolására**
- segít az adott nyelv **kategorizálásában**.


### Fordítóprogramok

#### Felépítés
- **Forráskód -> Source handler -> Lista**
  - **Compiler**
  - **Code handler -> Tárgynyelvű program**
- **Compiler Komponensei**
  - **Lexikális elemző**: Szimbólumsorozatok felismerése.
  - **Szintaktikai elemző**: Szimbólumok helyes szintaxis szerint.
  - **Szemantikai elemző**: Értelmezhetőség vizsgálata, például azonosítók összeadása.

### Egyéb Témakörök
- **Formula vezérlésű gép**: Hardverek és szoftverek kombinációja magas szintű nyelvek értelmezésére.
- **Interpreter**: Program, amely egy magas szintű nyelv utasításait közvetlenül végrehajtja.
- **Hazug paradoxon**: Logikai paradoxon, amely egy állítás önellentmondását fogalmazza meg.
- **Halting-probléma**: Az a kérdés, hogy egy adott program megáll-e véges időn belül egy adott bemenetre.


## Definíciók és Tételek!!!

- ***TÉTEL*** | **Gyenge normálforma**  : &emsp; &nbsp; Minden reguláris nyelv generálható gyenge normálformájú reguláris nyelvtannal is.
- ***TÉTEL*** | **Erős normálforma**  : &emsp; &emsp;&nbsp;&nbsp;&nbsp;&nbsp; Minden reguláris nyelvtanhoz van vele gyengén ekvivalens erős normálformájú reguláris nyelvtan is.
- ***DEFINÍCIÓ*** | **Erős normálforma**  :  &emsp; Két nyelvtan gyengén ekvivalens, ha csak az üres szóban térnek el.

---

- ***TÉTEL*** | **Lineáris nyelvtanok** : &emsp;Minden lineáris nyelv generálható gyenge normálformával is.
- ***TÉTEL*** | **Erős normálforma** : &emsp;&emsp;Minden lineáris nyelvtanhoz van vele gyengén ekvivalens erős normálforma is.

---
- **Üresszó lemma** : &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;Minden környezetfüggetlen nyelv generálható környezetfüggő nyelvtannal is.
- ***TÉTEL*** | **Környezetfüggelten nyelvtanok** : &emsp;Minden környezetfüggetlen nyelvtanhoz van vele gyengén ekvivalens Chomsky normálformájú nyelvtan is.
- ***TÉTEL*** | **Greibach-féle normálforma** : &emsp;&emsp;&emsp;&emsp;Minden környezetfüggetlen nyelvtanhoz van vele ekvivalens Greibach normál formájú nyelvtan.
- ***DEFINÍCIÓ*** | **Greibach-féle normálforma** : &emsp;&nbsp;Egy környezetfüggetlen nyelvtan Greibach-normálformában van, ha minden szabályára igaz, hogy `A -> ar` alakú, ahol `A eleme N`, `a eleme T`, `r eleme N*`.

---

- ***TÉTEL*** | **Környezetfüggő nyelvek normálformái** : &emsp;Minden monoton nyelvtanhoz van vele ekvivalens Kuroda normál alakú nyelvtan is.
- ***TÉTEL*** | **2 fejű véges automaták** : &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;A 2 fejű véges automaták éppen a lineáris nyelveket fogadják el.
