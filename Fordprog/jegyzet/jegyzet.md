### Fogalmak és Definíciók

#### Generatív Nyelvtan
- **N**: Nemterminális jelek – a nyelvtan szimbólumai, amelyek további szimbólumokra bonthatók.
- **T**: Terminális jelek – a nyelv legkisebb egységei, amelyeket nem lehet tovább bontani.
- **P**: Szabályok halmaza – azok a szabályok, amelyek meghatározzák, hogyan alakulnak át a nemterminális jelek.
- **S**: Kezdő szimbólum – a nyelvtan kiindulási pontja, amiből a mondatok generálhatók.
- **Zárt szóhalmaz**: Az összes szóból és az üres szóból álló halmaz.
- **Üresszó lemma**: Az állítás, miszerint egy környezetfüggetlen nyelv csak akkor tartalmazza az üres szót, ha a kezdő szimbólum levezeti az üres szót.
---
### Chomsky Hierarchia és Automatatípusok
#### 0. típus: Mondatszerkezetű nyelvtanok
- **Nyelvtan**: Minden szabályra igaz, hogy bármelyik szimbólum helyettesíthető.
- **Automata**: Turing-gép (Determinisztikus és nemdeterminista)
  - **Magyarázat**: Minden számítható feladat megoldására képes, determinisztikus és nemdeterminista változata is van.
#### 1. típus: Kontextusfüggő nyelvtanok
- **Nyelvtan**: A szabályok jobboldala hosszabb vagy egyenlő hosszúságú, mint a baloldala.
- **Automata**: Lineárisan korlátolt automata (Árnyékveremautomata)
  - **Magyarázat**: Egy Turing-gép, amelynek szalagja csak egy előre meghatározott hosszúságú lehet.
#### 2. típus: Környezetfüggetlen nyelvtanok
- **Nyelvtan**: Szabályok alakja: `A -> u`, ahol `A` eleme `N`, `u` eleme `(T ∪ N)*`.
- **Automata**: Veremautomata (Fraktálautomata, végtelenállapotú automata)
  - **Magyarázat**: Olyan automata, amely egy veremet használ, determinisztikus és nemdeterminista változata is van.
#### 2.5 típus: Lineáris nyelvtanok
- **Nyelvtan**: Speciális eset a környezetfüggetlen nyelvtanok között.
- **Automata**: Egyszer forduló veremautomata (Kétfejű véges automata)
  - **Magyarázat**: Kétfejű véges automata, amely csak egyszer mehet végig a veremen.
#### 3. típus: Reguláris nyelvtanok
- **Nyelvtan**: Szabályok alakja: `A -> aB` vagy `A -> a` (jobblineáris) és `A -> Ba` vagy `A -> a` (ballineáris).
- **Automata**: Véges automaták (Determinisztikus és nemdeterminista)
  - **Magyarázat**: Állapotok és átmenetek véges halmazával dolgoznak, determinisztikus és nemdeterminista változata is van.
---
#### Chomsky Hierarchia
- **0. típus**: Mondatszerkezetű nyelvtanok – minden szabályra igaz, hogy bármelyik szimbólum helyettesíthető.
- **1. típus**: Monoton és környezetfüggő nyelvtanok – a szabályok jobboldala hosszabb vagy egyenlő hosszúságú, mint a baloldala.
- **2. típus**: Környezetfüggetlen nyelvtanok – szabályok alakja: `A -> u`, ahol `A` eleme `N`, `u` eleme `(T ∪ N)*`.
  - **2.5 típus**: Lineáris nyelvtanok 
  - `megjegyzés (T ∪ N)* = Az összes létező terminális és nem terminális jelek + üres szavak halmaza`
- **3. típus**: Reguláris nyeltanok – szabályok alakja: `A -> aB` vagy `A -> a` (jobblineáris) és `A -> Ba` vagy `A -> a` (ballineáris).
#### Típusok
- **0. típus**: Turing gép (Determ, nemdeterm) – minden számítható feladat megoldására képes, determinisztikus és nemdeterminista változata is van.
  - `megjegyzés: determinisztikus = minden állapotban egyértelműen meghatározott, hogy mi lesz a következő állapot a jelenlegi állapot és a bemeneti érték alapján.`
  - `megjegyzés: nemdeterminista = egy adott állapot és bemenet esetén több lehetséges következő állapot is létezhet, és nem egyértelmű, hogy melyik lesz a következő állapot.`
- **1. típus**: Lineárisan korlátolt automata (Árnyékveremautomata) – egy Turing gép, amelynek szalagja csak egy előre meghatározott hosszúságú lehet.
- **2. típus**: Veremautomata (Fraktálautomata, végtelenállapotú automata) – olyan automata, amely egy veremet használ, determinisztikus és nemdeterminista változata is van.
  - **2.5 típus** Egyszer forduló veremautomata (2 fejű véges nemdeterm. automata) - Kétfejű véges automata, amely csak egyszer mehet végig a veremen.
  - `megjegyzés: verem = egy adatstruktúra, amely az elemeket LIFO (Last In, First Out - utolsóként be, elsőként ki) sorrendben kezeli, vagyis az utoljára betett elem kerül először kivételre. (Pl: szövegszerkesztő visszavonás funkció)`
- **3. típus**: Véges automaták (Determ, nemdeterm) – állapotok és átmenetek véges halmazával dolgoznak, determinisztikus és nemdeterminista változata is van.

### Normálformák

- #### Reguláris nyelvek
  - **Gyenge normálforma:**
    - **Szabályok**: `A -> aB` vagy `A -> a`.
    - minden szabály legfeljebb **egy nemterminális** és **egy terminális** szimbólumból állhat.
    - ***TÉTEL*** | **Gyenge normálforma**  : &emsp; &nbsp; Minden reguláris nyelv generálható gyenge normálformájú reguláris nyelvtannal is.
  - **Erős normálforma:**
    - **Szabályok**: `A -> BC` vagy `A -> a`.
    - minden szabály **vagy két nemterminális szimbólumra bontja a bal oldali nemterminálist**, vagy **egy terminális** szimbólumra cseréli.
    - ***TÉTEL*** | **Erős normálforma**  : &emsp; &emsp;&nbsp;&nbsp;&nbsp;&nbsp; Minden reguláris nyelvtanhoz van vele gyengén ekvivalens erős normálformájú reguláris nyelvtan is.
    - ***DEFINÍCIÓ*** | **Erős normálforma**  :  &emsp; Két nyelvtan gyengén ekvivalens, ha csak az üres szóban térnek el.
    - ***TÉTEL*** | **Erős normálforma** : &emsp;&emsp;Minden lineáris nyelvtanhoz van vele gyengén ekvivalens erős normálforma is.
      
- #### Lineáris nyelvek
  - **Lineáris nyelvek:**
    - **Szabályok**: `A -> uBv` vagy `A -> u`.
    - **terminális szimbólumok közbeiktatása** : **egy terminális szimbólumokból álló sorozatra** és **egy másik nemterminális** szimbólumra bontsunk.
    - ***TÉTEL*** | **Lineáris nyelvtanok** : &emsp;Minden lineáris nyelv generálható gyenge normálformával is.
    - ***TÉTEL*** | **2 fejű véges automaták** : &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;A 2 fejű véges automaták éppen a lineáris nyelveket fogadják el.

- #### Környezetfüggetlen nyelvek
  - ***TÉTEL*** | **Környezetfüggelten nyelvtanok** : &emsp;Minden környezetfüggetlen nyelvtanhoz van vele gyengén ekvivalens Chomsky normálformájú nyelvtan is.
  - **Üresszó lemma** : &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;Minden környezetfüggetlen nyelv generálható környezetfüggő nyelvtannal is.
  - **Chomsky-féle normálforma:**
    - **Szabályok**: `A -> BC` vagy `A -> a`.
    - vagy **két nemterminális szimbólum** kombinációjává alakítja **a bal oldali nemterminálist**, vagy **egy terminális** szimbólumra cseréli.
  - **Greibach-féle normálforma:**
    - **Szabályok**: `A -> aα`.
    - **egy terminális szimbólummal kezdődnek**, amelyet **egy** *(esetleg üres)* **nemterminális szimbólumsorozat** követ.
    - ***TÉTEL*** | **Greibach-féle normálforma** : &emsp;&emsp;&emsp;&emsp;Minden környezetfüggetlen nyelvtanhoz van vele ekvivalens Greibach normál formájú nyelvtan.
    - ***DEFINÍCIÓ*** | **Greibach-féle normálforma** : &emsp;&nbsp;Egy környezetfüggetlen nyelvtan Greibach-normálformában van, ha minden szabályára igaz, hogy `A -> ar` alakú, ahol `A eleme N`, `a eleme T`, `r eleme N*`.

- #### Környezetfüggő nyelvek
  - ***TÉTEL*** | **Környezetfüggő nyelvek normálformái** : &emsp;Minden monoton nyelvtanhoz van vele ekvivalens Kuroda normál alakú nyelvtan is.
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
#### Kleene-csillag
- (r*): Lehetővé teszi egy kifejezés tetszőleges számú **ismétlését** *(iteráció)*.

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
  
#### Konkatenáció
- **Szabály**: Két reguláris kifejezés egymás után írása.
- **Példa**: `ab` elfogadja a `c` és `d` kifejezéseket `cd` formában.
- **két reguláris kifejezést egyetlen kifejezésként kezelünk**, ahol **az egyik** kifejezés **követi a másikat**.

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
-   a szó  **minden lehetséges szakaszát ellenőrzi**, hogy megfelel-e a Chomsky normálformában definiált szabályoknak.
- **Működés**:
  - **háromszög alakú táblázat**, ahol maguk **a cellák jelölik a szótöredékeket**.
  - **a szó minden egyes betűjét** a szabályok alapján leírjuk az **első sor celláiba**.
  - **végig haladunk a táblázaton**, úgy, hogy **a két alsó cellából generálható kombinációt megnézzük** a nyelvtan szabályai alapján
  - Ha **a kezdő szimbólum** a legfelső cellában **megtalálható**, a szó **elfogadható**.
- **Példa**: Az `"aabb"` szó felismerésekor a táblázat kitöltése során az `S -> AB`, `A -> a`, és `B -> b` szabályokat használjuk.

#### Early Algoritmus
-  **Környezetfüggetlen nyelvek elemzésére használjuk**
-  **Nincs szükség Chomsky normálformára átalakításra**.
- **Működés**:
  - **a kezdő szimbólumot hozzáadjuk a kezdő állapothoz**, a szóra létrehoznuk egy üres táblát
  - új nemterminális szimbólumokat generálunk a nyelvtan szabályai alapján
  - további **szabályokat prediktál a nemterminális szimbólumok alapján**, ha kell visszalép az előző állapotra
  - a szó **elfogadható**, ha **az algoritmus bejárta a teljes szót**, a kezdő szimbólum pedig **visszajut a kiinduló állapotba**
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

![fordito](https://github.com/dandob23/jegyzetek/blob/main/Fordprog/jegyzet/ForditoProgramFelepitese.png)

#### Felépítés

### Komponensek és Szerepük

- **Forráskód**: A programozó által írt **eredeti program**.
- **Source Handler**: A modul, amely **kezeli** **a forráskód beolvasását** és **előkészíti** azt **a fordításhoz**.
- **Lista**: A forráskódból generált **szimbólumok listája**, amelyet **a fordítóprogram további feldolgozásra használ**.
- **Compiler**: A program, amely **a forráskódot gépi kódra vagy köztes kódra fordítja**, hogy a program végrehajtható legyen.
- **Code Handler**: A modul, amely **a fordított kódot kezeli**, **optimalizálja és előkészíti a tárgynyelvű program létrehozására**.
- **Tárgynyelvű program**: **A végleges**, gép által végrehajtható **kód**.
  

### Compiler Komponensei

#### Lexikális Elemző (tokenizáló)
- az **input karaktersorozatot szimbólumsorozattá** (tokenekké) alakítja.
- **Feladata**: 
  - **Kiszedi a kommenteket, és a felesleges szóközöket**.
  - A **lehető leghosszabb karaktersorozatokból** építi fel a szimbólumokat *(pl. "kiskutya" egy 8 betűs szimbólum = 1 egység / 1 jel)*.
  - **Kulcsszavak felismerése** regex-szel vagy **kulcsszavakat tartalmazó táblázat** alapján.
  - **Hibajelzéseket ad**, ha a bemenet nem felel meg a nyelv szabályainak.
- **Példa**: A `"kiskutya"` szövegben az elemző felismeri a `"kiskutya"` szót, és tokenként adja meg.

#### Szintaktikai Elemző
- **ellenőrzi**, hogy **a szimbólumok helyes szintaktikai szerkezetet** alkotnak-e, és létrehozza a **szintaxisfát**.
- **Feladata**:
  - Ellenőrzi, hogy **a szimbólumok megfelelnek-e a nyelvtani szabályoknak**.
  - **Konvertálja a szimbólumsorozatot** egy szintaxisfává.
  - Elemző módszerek:
    - **LL(k), LL(1)**: Felülről lefelé elemzés.
    - **LR(k), LR(1)**: Alulról felfelé elemzés.
- **Példa**: Az `if (x > 0) { x = x - 1; }` kódból a szintaktikai elemző **szintaxisfát épít**, amely **ábrázolja az if-et és a ciklust**.

#### Szemantikai Elemző
- **ellenőrzi a program jelentését és logikai összefüggéseit**.
- **Feladata**:
  - Értelmezhetőség vizsgálata, például **az azonosítók típusainak ellenőrzése**.
  - **Biztosítja**, hogy az azonosítók és a műveletek **logikailag összhangban** vannak.
  - például két azonosító **összeférhetőségének vizsgálata, típusellenőrzés**.
- **Példa**: Az `int x = 5; x = x + 1.5;` kódban a szemantikai elemző **hibát jelez**, mivel **egy int és egy float** típusú érték összeadása **nem megengedett**.

### Egyéb Témakörök
- **Formula vezérlésű gép**: Hardver útján értelmezi a magasszintű nyelvet.
- **Interpreter**: Szoftver útján értelmezi a magasszintű nyelvet.
- **Hazug paradoxon**: Nem lehet sem igaz, sem hamis.
- **Halting-probléma**: Az a kérdés, hogy egy adott program megáll-e véges időn belül egy adott bemenetre.
