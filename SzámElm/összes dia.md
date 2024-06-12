Itt található a PowerPoint prezentáció alapján készült felsorolásos jegyzet:

### Algoritmusok bonyolultsága

**Előadó: Kovásznai Gergely, Eszterházy Károly Egyetem**

#### Bonyolultságelmélet (Complexity Theory)

- **Algoritmusok bonyolultsága**
  - Időbonyolultság: elemi lépések száma
  - Tárbonyolultság: memóriaigény

- **Legrosszabb eset ("Worst-case complexity")**
  - Keresési algoritmusok időbonyolultsága:
    - Lineáris keresés: legrosszabb esetben \(O(n)\)
    - Bináris keresés: legrosszabb esetben \(O(\log n)\)

#### "Ordó" jelölés

- \(O\) jelölés: függvény növekedésének mértékét jelöli
- Bonyolultsági függvények:
  - Logaritmikus: \(O(\log n)\)
  - Lineáris: \(O(n)\)
  - Polinomiális: \(O(n^k)\)
  - Négyzetes: \(O(n^2)\)
  - Köbös: \(O(n^3)\)
  - Exponenciális: \(O(2^n)\)
  - Faktoriális: \(O(n!)\)
  - Dupla exponenciális: \(O(2^{2^n})\)

#### Rendezési algoritmusok időbonyolultsága

- **Probléma**: Rendezni egy \(n\) elemű tömböt növekvő sorrendbe.
- Elemi lépések: összehasonlítások és elemcserék

- **Algoritmusok**:
  - Buborék rendezés (Bubble Sort):
    - Időbonyolultság: \(O(n^2)\)
  - Beszúrásos rendezés (Insertion Sort):
    - Lineáris kereséssel: \(O(n^2)\)
    - Bináris kereséssel: \(O(n \log n)\)
  - Összefésüléses rendezés (Merge Sort):
    - Időbonyolultság: \(O(n \log n)\)

#### Gráfok

- Gráf: \(G = (V, E)\)
  - \(V\): csúcsok (vertices) halmaza
  - \(E\): élek (edges) halmaza
  - Élekhez költség (\(c\)): \(c: E \rightarrow \mathbb{R}\)

- **Elérhetőség problémája**:
  - Mélységi keresés (DFS)
  - Szélességi keresés (BFS)
  - Dijsktra algoritmus: legolcsóbb út egy csúcsból az összes többibe
  - Floyd-Warshall algoritmus: bármely két csúcs között

#### Hamilton-kör probléma

- Több mint 100 éve tanulmányozzák
- "Naív" algoritmus: csúcsok permutációja kör-e?
- Időbonyolultság: \(O(n!)\)
- Polinomiális algoritmus keresése

#### Gráfszínezési probléma

- Gráf színezése: csúcsok beszínezése úgy, hogy szomszédos csúcsok különböző színűek legyenek.
- Nem ismert polinomiális algoritmus

### Közlekedési lámpák

- Konfliktusok ábrázolása gráffal:
  - Csúcsok: lámpák
  - Élek: konfliktusos kapcsolatok

Ez a jegyzet segíthet a számításelmélet vizsgára való felkészüléshez, különös tekintettel az algoritmusok bonyolultságára és a hozzá kapcsolódó témakörökre.

Itt található a PowerPoint prezentáció alapján készült felsorolásos jegyzet:

### Algoritmus modellek és Turing-gép

#### Algoritmus-fogalom

- Mi az az algoritmus?
- Mik az elemi lépések?
- Mi az idő- és tárbonyolultság?

#### Algoritmus modellek

- Turing-gép
- Rekurzív függvények
- Lambda-kalkulus
- Markov algoritmus

#### Alan Turing (1912-1954)

- II. világháború alatt: Enigma feltörése
- 1945-től: Digitális számítógép – "Mark 1"
- 1948-tól: Mesterséges intelligencia – Turing-teszt
- 1952-től: hormonkezelés majd öngyilkosság

#### Algoritmikus problémák

- 1950-es évek lelkesedése
- Church-Turing tézis: a Turing-gép képes minden kiszámítható függvényt kiszámítani
- Church-Turing tétel: vannak Turing-géppel nem kiszámítható függvények

#### Turing-gép

- **2 fő alkatrész:**
  - Vezérlő: Lehetséges belső állapotainak halmaza
  - Szalag: Végtelen cellákból áll, író-olvasó fej aktuális pozíciója

- **Turing-gép elemei:**
  - \(\Sigma\): szalagjelek (betűk) halmaza
  - \(Q\): állapotok halmaza
  - \(q_0\): kezdőállapot
  - \(F\): elfogadó állapotok halmaza
  - \(\delta\): állapotátmenetfüggvény

- **Átmenetfüggvény (\(\delta\)):**
  - Bemenő paraméterei: aktuális állapot és aktuálisan olvasott betű
  - Visszaadott értékei: következő állapot, cellára visszaírandó betű, fej mozgásának iránya

#### Turing-gép definíciója

- \(\Sigma\): szalagjelek (betűk) halmaza
- \(Q\): állapotok halmaza
- \(q_0\): kezdőállapot
- \(F\): elfogadó állapotok halmaza
- \(\delta\): állapotátmenetfüggvény

#### Turing-gép - Példa

- Van-e a megadott input szóban ‘x’ betű?

#### Turing-gép - Konfiguráció

- **Szükséges leírás:**
  - Milyen állapotban van a vezérlő?
  - Milyen betűk vannak a szalagon?
  - Melyik cellán áll az író-olvasó fej?

#### Input és kezdőkonfiguráció

- Input: egy \(w\) szó speciális betűk nélkül
- Kezdőkonfiguráció: kezdőállapotban, fej a kezdőbetűn, input jobbra indul, minden más cella üres

#### Megállási konfiguráció

- Olyan konfiguráció, ahonnan a Turing-gép nem tud továbblépni (átmenetfüggvény nincs értelmezve az aktuális állapoton és az aktuálisan olvasott betűn)

#### Közvetlen rákövetkezés

- Ha \(\delta(q, a) = (q', b, R)\), akkor a következő állapot \(q'\), a szalagra visszaírandó betű \(b\), és a fej jobbra lép.

#### Rákövetkezés

- Léteznek \(C_1, C_2, ..., C_k\) konfigurációk, hogy \(C_1 \rightarrow C_2 \rightarrow ... \rightarrow C_k\)

#### Megállás és elfogadás/elutasítás

- Input: \(w\)
- Ha van olyan megállási konfiguráció, hogy \(q \in F\), akkor \(M\) elfogadja \(w\)-t, különben elutasítja.

#### Időigény vs időkorlát

- Időigény: konkrét \(w\) inputon a megállásig megtett lépések száma (\(t(w)\))
- Időkorlát: minden lehetséges inputra egy felső korlát az időigényre (függvény formájában: \(T(n)\), ahol \(n\) az input hossza)

#### Számítási probléma = Nyelv

- Számítási problémák nyelvekként (szavak halmazai) reprezentálva
- Turing-gép milyen eredményt ad az \(L\) nyelv \(w\) szavain mint inputokon?

#### Eldöntött / felismert nyelv

- \(L\) nyelv eldöntése: minden \(w\) inputra elfogadja vagy elutasítja
- \(L\) nyelv felismerése: minden \(w\) inputra elfogadja vagy nem áll meg

#### Rekurzív / rekurzíve felsorolható nyelvek

- Rekurzív nyelv (\(L\)): létezik Turing-gép, mely eldönti \(L\)-t
- Rekurzíve felsorolható nyelv (\(L\)): létezik Turing-gép, mely felismeri \(L\)-t
- Rekurzív nyelvek osztálya: \(REC\)
- Rekurzíve felsorolható nyelvek osztálya: \(RE\)

Ez a jegyzet segíthet a számításelmélet témakörében a Turing-gépekkel kapcsolatos ismeretek rendszerezésében és megértésében.

Itt található a PowerPoint prezentáció alapján készült felsorolásos jegyzet a többszalagos Turing-gépről:

### Többszalagos Turing-gép

#### Többszalagos Turing-gép definíciója

- **Elemei:**
  - \( k \): szalagok száma
  - \(\Sigma\): szalagjelek (betűk) halmaza
  - \( Q \): állapotok halmaza
  - \( q_0 \): kezdőállapot
  - \( F \): elfogadó állapotok halmaza
  - \(\delta\): állapotátmenetfüggvény

#### Átmenetfüggvény (\(\delta\))

- **Paraméterek:**
  - Aktuális állapot
  - Aktuálisan olvasott \( k \) db. betű: \( a_1, a_2, ..., a_k \)
- **Visszaadott értékek:**
  - Következő állapot
  - \( k \) db. betű, amit a szalagra írunk vissza: \( b_1, b_2, ..., b_k \)
  - \( k \) db. fejmozgás irány: \( m_1, m_2, ..., m_k \)

#### Konfigurációk

- **Egyszalagos Turing-gép esetén:**
  - \( (q, \alpha a \beta) \), ahol \(\alpha\) és \(\beta\) a szalag bal és jobb oldala, \( a \) pedig az aktuálisan olvasott betű
- **Többszalagos Turing-gép esetén:**
  - \( (q, \alpha_1 a_1 \beta_1, \alpha_2 a_2 \beta_2, ..., \alpha_k a_k \beta_k) \)

#### Szalagok típusa

- **Inputszalag:** Az input szó induláskor ide kerül
- **Outputszalag:** Megálláskor az output szót innen olvassuk ki
- **Munkaszalagok:** Átmeneti adatok tárolására szolgálnak a futtatás során

#### Kezdő- és megállási konfigurációk

- **Kezdőkonfiguráció:**
  - Az input az 1. szalagon, a többi szalag üres
- **Megállási konfiguráció:**
  - \( \delta(q, a_1, a_2, ..., a_k) \) nincs értelmezve

#### Közvetlen rákövetkezés

- Ha \( \delta(q, a_1, a_2, ..., a_k) = (q', b_1, b_2, ..., b_k, m_1, m_2, ..., m_k) \), akkor:
  - \( q \rightarrow q' \)
  - \( a_i \rightarrow b_i \) minden \( i \)-re
  - A fej \( m_i \) irányba mozdul el minden \( i \)-re

#### Elfogadás és elutasítás

- **Output meghatározása:**
  - Ha van olyan megállási konfiguráció, hogy \( q \in F \), akkor:
    - Ha \( q \in F \), elutasítja az inputot
    - Ha \( q \in F \), elfogadja az inputot és az output az 1. szalagon található

#### Örökölt fogalmak

- **Időkorlát**
- **Eldöntött nyelv**
- **Felismert nyelv**

Ez a jegyzet segíthet a többszalagos Turing-gépek működésének megértésében és a kapcsolódó fogalmak rendszerezésében.

Itt található a PowerPoint prezentáció alapján készült felsorolásos jegyzet az időbonyolultsági osztályokról:

### Időbonyolultsági osztályok

#### Általános fogalmak

- A nyelveket (számítási problémákat) időbonyolultsági osztályokba soroljuk.
- **Kérdések:**
  - Melyik nyelvet lehet gyorsan eldönteni?
  - Melyik nyelv esetén esélytelen az eldöntés?
- A nyelveket eldöntő Turing-gépek időkorlátja alapján osztályozzuk.
- Alapul a többszalagos Turing-gépet vesszük, amely szimulálható egyszalagos Turing-géppel.

#### Időbonyolultsági osztályok definíciói

- **\(DTIME(t(n))\) osztály:**
  - Ha van olyan \(t(n)\) időkorlátos (többszalagos) Turing-gép, amely eldönti \(L\)-t.
- **\(P\) osztály:**
  - Polinomiális időkorlátos Turing-géppel eldönthető nyelvek osztálya.
- **\(EXPTIME\) osztály:**
  - Exponenciális időkorlátos Turing-géppel eldönthető nyelvek osztálya.

#### Szimuláció

- Egy \(S\) Turing-gép szimulál egy \(T\) Turing-gépet, ha minden \(w\) input esetén:
  - Ha \(T\) nem áll meg \(w\)-n, akkor \(S\) sem áll meg \(w\)-n.
  - Ha \(T\) elutasítja \(w\)-t, akkor \(S\) is elutasítja \(w\)-t.
  - Ha \(T\) elfogadja \(w\)-t és \(x\) kimenetet állít elő, akkor \(S\) is elfogadja \(w\)-t és \(x\) kimenetet állít elő.

#### Többszalagos Turing-gép szimulációja

- **Tétel:** Bármely \(t(n)\) időkorlátos \(k\)-szalagos Turing-gép szimulálható \(t^2(n)\) időkorlátos egyszalagos Turing-géppel.

#### Többszalagos Turing-gép szimulációjának lépései

1. **Kódolás:**
   - Minden \(k\) betűjére: speciális kódolás.
   - Kódolás lépésszáma: \(O(n)\).
2. **Egyetlen lépés szimulálása:**
   - Balról jobbra haladva a betűk eltárolása, majd jobbról balra haladva a változtatások elvégzése.
   - Lépésszám: \(O(n)\).
3. **Dekódolás:**
   - Minden betű dekódolása.
   - Lépésszám: \(O(n)\).
4. **Lépésszám összesítve:**
   - Teljes lépésszám: \(O(t^2(n))\).

#### Lineáris felgyorsítás

- **Tétel:** Legyen \(L\) eldönthető \(t(n)\) időkorlátos Turing-géppel. Bármely \(c > 0\) valós számra, \(L\) eldönthető \(\frac{t(n)}{c}\) időkorlátos Turing-géppel is.
- Következmény: A multiplikatív és additív konstansok elhanyagolhatóak az időbonyolultságban.

#### Lineáris felgyorsítás lépései

1. **Kódolás:**
   - Balról jobbra haladva a betűk letárolása, majd jobbról balra haladva az 1. szalagra írás.
   - Lépésszám: \(O(n)\).
2. **Szimuláció:**
   - \(k\) db. lépés szimulálása egyszerre: 6 lépésben.
   - Szomszédos cellák beolvasása és hatás érvényesítése.
   - Lépésszám: \(O(t(n)/c)\).

#### Összefoglalás

- Az időbonyolultsági osztályok segítségével a nyelvek eldönthetőségének hatékonyságát vizsgáljuk.
- A többszalagos Turing-gép szimulálása és a lineáris felgyorsítás tételének megértése alapvető fontosságú az időbonyolultsági osztályok elemzéséhez.

Ez a jegyzet segít áttekinteni az időbonyolultsági osztályokat és a hozzájuk kapcsolódó fogalmakat.

Itt található a PowerPoint prezentáció alapján készült felsorolásos jegyzet a tárbonyolultsági osztályokról:

### Tárbonyolultsági osztályok

#### Általános fogalmak

- Az időbonyolultságon kívül más bonyolultság-fogalmak is vizsgálhatók.
- A Turing-gép számítása során felhasznált szalagcellák száma.
- **Kérdés:** Milyen Turing-gép architektúrát vegyünk alapul?

#### Tárigény

- Legyen \( M \) -szalagos Turing-gép és \( x \) ennek egy inputja.
- \( M \) megállási konfigurációja:
  - \( S_M(x) \): \( M \) tárigénye az \( x \) inputon.

#### Lyukszalagos Turing-gépek motivációja

- Az inputot nem kellene a tárigénybe beleszámítani.
  - Ha beleszámítanánk, sohasem tudnánk lineáris tárbonyolultság alá menni.
- Az input és az output nem számít bele a tárigénybe.
  - Inputszalag: csak olvasható.
  - Outputszalag: csak írható.
- Lehetővé teszi logaritmikus tárbonyolultsági osztályok definiálását.

#### Lyukszalagos Turing-gép definíciója

- \(\Sigma\): szalagjelek (betűk) halmaza
- \( Q \): állapotok halmaza
- \( q_0 \): kezdőállapot
- \( F \): elfogadó állapotok halmaza
- \(\delta\): állapotátmenetfüggvény
  - \( \delta(q, a_1, a_2, ..., a_k) = (q', b_1, b_2, ..., b_k, m_1, m_2, ..., m_k) \)

#### Tárigény

- Legyen \( M \) -szalagos lyukszalagos Turing-gép és \( x \) ennek egy inputja.
- \( M \) megállási konfigurációja:
  - \( S_M(x) \): \( M \) tárigénye az \( x \) inputon.

#### Tárkorlát

- \( M \) tárkorlátos:
  - \( S_M(x) \): \( M \) tárigénye minden \( x \) inputon legfeljebb \( f(|x|) \).

#### Tárbonyolultsági osztályok

- Az eldönthető nyelvek további osztályozása.
- A nyelveket eldöntő Turing-gépek tárkorlátja alapján.
- A lyukszalagos Turing-gépet vesszük alapul.

#### Tárbonyolultsági osztályok definíciói

- **\( DSPACE(f(n)) \) osztály:**
  - Ha van olyan \( f(n) \) tárkorlátos lyukszalagos Turing-gép, amely eldönti \( L \)-t.
- **\( PSPACE \) osztály:**
  - Polinomiális tárkorlátos Turing-géppel eldönthető nyelvek osztálya.
- **\( EXPSPACE \) osztály:**
  - Exponenciális tárkorlátos Turing-géppel eldönthető nyelvek osztálya.
- **\( L \) osztály:**
  - Logaritmikus tárkorlátos Turing-géppel eldönthető nyelvek osztálya.

Ez a jegyzet segít áttekinteni a tárbonyolultsági osztályokat és a hozzájuk kapcsolódó fogalmakat.

Itt található a PowerPoint prezentáció alapján készült felsorolásos jegyzet a nemdeterminisztikus Turing-gépről:

### Nemdeterminisztikus Turing-gép

#### Általános fogalmak

- Nemdeterminisztikus számítások alapfogalmai.

#### Nemdeterminisztikus Turing-gép definíciója

- \(\Sigma\): szalagjelek (betűk) halmaza
- \( Q \): állapotok halmaza
- \( q_0 \): kezdőállapot
- \( F \): elfogadó állapotok halmaza
- \(\delta\): (állapot)átmenetfüggvény
  - \( \delta(q, a) = \{(q', b, m)\} \)

#### Konfiguráció

- **Konfiguráció:** \( (q, \alpha a \beta) \), ahol \(\alpha\) és \(\beta\) a szalag bal és jobb oldala, \( a \) pedig az aktuálisan olvasott betű
- **Megállási konfiguráció:** \( (q, \alpha a \beta) \), ahol \(\delta(q, a)\) nincs értelmezve vagy \( q \in F \)

#### Közvetlen rákövetkezés

- Ha \( \delta(q, a) = (q', b, m) \), akkor a következő állapot \( q' \), a szalagra visszaírandó betű \( b \), és a fej mozgásának iránya \( m \)

#### Rákövetkezés

- Léteznek \(C_1, C_2, ..., C_k\) konfigurációk, hogy \( C_1 \rightarrow C_2 \rightarrow ... \rightarrow C_k \)

#### Elfogadás és elutasítás

- **Input:** \( w \)
- Ha van olyan ága a számítási fának, amely elfogadó konfigurációban végződik, akkor elfogadja \( w \)-t.
- Ha nincs ilyen ága, akkor elutasítja \( w \)-t.

#### Időkorlát

- \( M \) időkorlátos:
  - Minden \( x \) input és minden \( t \) konfiguráció esetén, ha \( C_1 \rightarrow C_2 \rightarrow ... \rightarrow C_t \), akkor \( t \leq f(|x|) \).

#### Eldöntött / Felismert nyelv

- Legyen \( L \) nyelv.
- \( M \) eldönti \( L \)-t, ha minden \( w \) inputra:
  - Ha \( w \in L \), akkor \( M \) elfogadja \( w \)-t.
  - Ha \( w \notin L \), akkor \( M \) elutasítja \( w \)-t.
- \( M \) felismeri \( L \)-t, ha minden \( w \) inputra:
  - Ha \( w \in L \), akkor \( M \) elfogadja \( w \)-t.
  - Ha \( w \notin L \), akkor \( M \) nem áll meg.

#### Nemdeterminisztikus Turing-gép szimulációja

- **Tétel:** Bármely \( t(n) \) időkorlátos nemdeterminisztikus \( M \) Turing-gép szimulálható \( 2^{O(t(n))} \) időkorlátos determinisztikus Turing-géppel, ahol \( c \) a \( M \)-től függő konstans.
- **Működés:**
  - 1. szalag: változatlan input
  - 2. szalag: \( t(n) \) számsor \( \{0,1\} \)
  - 3. szalag: a \( M \) egyetlen szalagja
  - \( S \) működése:
    - 2. szalagra \( t \) kiírása.
    - 3. szalagon \( M \) szimulálása determinisztikusan a 2. szalagon levő számsor alapján.
    - Ha \( M \) elfogadja az inputot, akkor \( S \) is.
    - Ha nem, akkor törli a 3. szalagot, növeli a 2. szalagon levő számot (k-alapú számrendszer).

#### Nemdeterminisztikus bonyolultsági osztályok

- **\( NTIME(t(n)) \) osztály:**
  - Ha van olyan \( t(n) \) időkorlátos (nemdeterminisztikus) Turing-gép, amely eldönti \( L \)-t.
- **\( NSPACE(s(n)) \) osztály:**
  - Ha van olyan \( s(n) \) tárkorlátos (nemdeterminisztikus) Turing-gép, amely eldönti \( L \)-t.
- **\( NP \) osztály:**
  - Polinom időkorlátos nemdeterminisztikus Turing-géppel eldönthető nyelvek osztálya.
- **\( NEXP \) osztály:**
  - Exponenciális időkorlátos nemdeterminisztikus Turing-géppel eldönthető nyelvek osztálya.
- **\( NL \) osztály:**
  - Logaritmikus tárkorlátos nemdeterminisztikus Turing-géppel eldönthető nyelvek osztálya.

#### Hiányzó nyelvosztályok

- Miért nincs \( NP =? P \)?
- Miért nincs \( NSPACE =? PSPACE \)?
- Később fogjuk tanulni és bizonyítani, hogy miért nem.

Ez a jegyzet segít áttekinteni a nemdeterminisztikus Turing-gépekkel és a hozzájuk kapcsolódó fogalmakkal kapcsolatos ismereteket.

Itt található a PowerPoint prezentáció alapján készült felsorolásos jegyzet az NP osztályról:

### NP osztály

#### Általános fogalmak

- **NP osztály:** Gráfelméleti nyelvek, számelméleti problémák, egyenletek megoldásai, utazóügynök probléma stb.
- Az NP-be tartozás bizonyítéka: A nyelvet eldöntő polinom időkorlátos nemdeterminisztikus Turing-gép.
- Alternatív módszer: Egy egyszerűbb módszer, amely visszavezetést ad a determinisztikus eldöntésre.

#### Tanú alkalmazása

- A nemdeterminisztikus eldöntési problémát kétfelé "hasítjuk":
  - A tanú legyen polinom hosszúságú.
  - A tanút alkalmazó számítás legyen polinom időbonyolultságú.

#### NP-beli nyelvek: Hamilton-kört tartalmazó gráfok

- **Hamilton-kör:** Egy gráf köre Hamilton-kör, ha a gráf minden csúcsa pontosan egyszer szerepel.
- **Nyelv:** Hamilton-körrel rendelkező gráfok nyelve.
- **Tanú:** A gráf csúcsainak egy permutációja.
- **Permutáció ellenőrzése:** Egymás utáni csúcsait él köti-e össze? (Polinom időkorlátos determinisztikus Turing-géppel eldönthető.)

#### Tanú-tétel összeállítása

- **1. kritérium:** A tanú legyen polinom hosszúságú.
  - \( t(n) \) egy polinomja.
- **2. kritérium:** A tanút alkalmazó számítás legyen determinisztikus és polinom időbonyolultságú.
  - Létezik olyan \( L \) nyelv, amely \( \{(x, y) | y \text{ tanú, hogy } M \text{ elfogadja } x\} \) szópárokból áll, és eldönthető determinisztikus polinom időkorlátos Turing-géppel.

#### Tanú-tétel

- **Tétel:** Legyen \( L \) egy nyelv.
  - \( L \in NP \), ha létezik olyan polinom \( p \) és determinisztikus Turing-gép \( M \), hogy:
    - \( x \in L \) esetén létezik olyan \( y \), hogy \( |y| \leq p(|x|) \) és \( M \) elfogadja \( (x, y) \)-t.
    - \( x \notin L \) esetén minden \( y \)-ra \( M \) elutasítja \( (x, y) \)-t.

#### NP-beli nyelvek példái

- **3 színnel színezhető gráfok:**
  - **Nyelv:** Egy gráf csúcsai 3 színnel színezhetőek-e úgy, hogy minden éle két különböző színű csúcsot köt össze?
  - **Tanú:** A gráf egy színezése.
  - **Ellenőrzés:** Minden él különböző színű csúcsokat köt-e össze? (Polinom időkorlátos determinisztikus Turing-géppel eldönthető.)

- **Egész faktorizáció:**
  - **Probléma:** Adott egy \( N \) egész szám és egy \( k \) egész szám úgy, hogy \( k < N \). Vajon létezik olyan \( m \) szám, hogy \( k \cdot m = N \)?
  - **Tanú:** Egy \( m \) egész szám.
  - **Ellenőrzés:** \( m \) osztja-e \( N \)-t? (Polinom időkorlátos determinisztikus Turing-géppel eldönthető.)

Ez a jegyzet segít áttekinteni az NP osztályba tartozó nyelveket és a hozzájuk kapcsolódó fogalmakat.

Itt található a PowerPoint prezentáció alapján készült felsorolásos jegyzet a bonyolultsági osztályok összefüggéseiről:

### Eldönthető nyelvek és bonyolultsági osztályok közötti összefüggések

#### Eldönthetőség

- **Kérdés:** Van olyan probléma, amely algoritmussal nem megoldható?
- Van olyan nyelv, amely Turing-géppel nem eldönthető?
  - **Válasz:** Igen, van.
- **Megállási probléma:**
  - Univerzális Turing-gép kérdése:
    - Van-e olyan Turing-gép, amely meg tudja mondani, hogy egy adott Turing-gép megáll-e egy adott inputon?
    - **Válasz:** Nincs ilyen Turing-gép, ezért a megállási probléma eldönthetetlen.

#### Post megfeleltetési problémája

- Adott egy min. 2 elemű ábécé: \( \Sigma \)
- Adott 2 véges sorozat \( \Sigma^* \) szavaiból: \( \alpha_1, \alpha_2, ..., \alpha_m \) és \( \beta_1, \beta_2, ..., \beta_n \)
- **Kérdés:** Összefűzhetőek-e a két sorozat szavai úgy, hogy összeolvasva ugyanazt a szót kapjuk? Azaz van-e olyan \( i_1, i_2, ..., i_k \) index sorozat, hogy \( \alpha_{i_1}\alpha_{i_2}...\alpha_{i_k} = \beta_{j_1}\beta_{j_2}...\beta_{j_k} \)?
  - **Válasz:** Ez a probléma eldönthetetlen.

#### Bonyolultsági osztályok összefüggései

- Az eldönthető nyelveket idő- és tárbonyolultsági osztályokba soroltuk.
- Egy Turing-gép \( t(n) \) lépésben max. \( t(n) \) szalagcellát használhat.

#### NP és P relációja

- Egy \( t(n) \) időkorlátos nemdeterminisztikus Turing-gépet szimuláljunk egy determinisztikus Turing-géppel.
  - Számítási fa egy ágának végigszámolása: \( t(n) \) lépés, max. \( t(n) \) cella.
  - Visszalép a fa gyökerébe, és ugyanazt a szalagot használja újra.
  - Mindvégig \( t(n) \) cellát használ.
- **Következmény:** \( NP \subseteq P \)

#### P és PSPACE relációja

- Tár-idő tétel: \( P \subseteq PSPACE \)

#### NP és EXPTIME relációja

- Mivel \( P \subseteq EXPTIME \), ezért \( NP \subseteq EXPTIME \).

#### NSPACE és PSPACE relációja

- Minden \( s(n) \) tárkorlátos nemdeterminisztikus Turing-gép szimulálható \( O(s^2(n)) \) tárkorlátos determinisztikus Turing-géppel.
  - **Következmény:** \( NSPACE(s(n)) \subseteq PSPACE(s(n)) \)
  - \( NPSPACE = PSPACE \)

#### Bonyolultsági osztályok „térképe”

- Vizualizálás a különböző bonyolultsági osztályok relációiról és összefüggéseiről.

Ez a jegyzet segít áttekinteni az eldönthetőség kérdését és a különböző bonyolultsági osztályok közötti összefüggéseket.

Itt található a PowerPoint prezentáció alapján készült felsorolásos jegyzet a teljességről:

### Teljesség

#### Teljes nyelvek

- Adott nyelvosztályra nézve teljes nyelvek.
- Magukban hordozzák az adott osztályba tartozó összes nyelv eldöntésének nehézségét.
- Pontosabban be lehet „lőni” az adott nyelv eldöntésének bonyolultságát.
- Segítségükkel könnyű bizonyítani, ha két osztály egybeesik.

#### Visszavezetés (Karp-redukció)

- **Definíció:** Az \( L_1 \) nyelv visszavezethető az \( L_2 \) nyelvre:
  - Létezik polinom időkorlátos determinisztikus Turing-géppel kiszámítható függvény \( f \), hogy minden \( x \) szóra:
    - \( x \in L_1 \iff f(x) \in L_2 \)
- **Jelölés:** \( L_1 \leq_p L_2 \)
- **Tranzitivitás:** Ha \( L_1 \leq_p L_2 \) és \( L_2 \leq_p L_3 \), akkor \( L_1 \leq_p L_3 \).

#### Tartalmazás = Felső korlát

- Legyen \( C \) egy nyelvosztály és \( L \) egy nyelv.
- Ha \( L \in C \), akkor ez \( L \) eldöntésének bonyolultságára felső korlátot ad.

#### Nehézség = Alsó korlát

- Az \( L \) nyelv \( C \)-nehéz, ha:
  - Minden \( L' \in C \) esetén \( L' \leq_p L \).

#### Teljesség = Pontos illeszkedés

- Az \( L \) nyelv \( C \)-teljes, ha:
  - \( L \in C \)
  - \( L \) \( C \)-nehéz.
- Eldöntésének bonyolultsága pontosan \( C \).

#### Nehézség és teljesség „öröklődése”

- Ha találunk egy \( C \)-teljes nyelvet, hogyan kereshetünk több \( C \)-teljes nyelvet?
  - Ha \( L_1 \) \( C \)-teljes és \( L_1 \leq_p L_2 \), akkor \( L_2 \) \( C \)-nehéz.
  - Ha \( L_2 \) \( C \)-nehéz és \( L_2 \in C \), akkor \( L_2 \) \( C \)-teljes.

#### \( NP \)-teljes nyelvek keresése

- Találni kell egy \( NP \)-teljes nyelvet (pl. SAT).
- Egy nyelv \( NP \)-teljessége belátható:
  - **\( NP \)-beliség:** Tanú-tétel segítségével.
  - **Nehézség:** Visszavezetés konstruálásával.

#### \( NP \)-teljes nyelvek fontossága

- Ha egy \( NP \)-teljes nyelvről sikerülne belátni, hogy \( P \)-ben van:
  - \( P = NP \)
  - Minden \( NP \)-beli nyelv polinom időben eldönthető.
  - Ez a számításelmélet központi kérdése!

Ez a jegyzet segít áttekinteni a teljesség fogalmát és annak jelentőségét a számításelméletben, különös tekintettel az \( NP \)-teljes nyelvekre és azok összefüggéseire.

Itt található a PowerPoint prezentáció alapján készült felsorolásos jegyzet az NP-teljes nyelvekről:

### NP-teljes nyelvek

#### Példák NP-teljes nyelvekre

- **Hamilton-kör probléma:**
  - Van a gráfnak olyan köre, amely minden csúcsot pontosan egyszer érint?
- **Utazóügynök probléma:**
  - Adottak városok és a városok közötti utakhoz rendelt költségek. Melyik a legolcsóbb körút, amely minden várost pontosan egyszer érint?
  - Naív algoritmus időbonyolultsága: \(O(n!)\)
  - Létezik determinisztikus algoritmus: \(O(2^n \cdot n^2)\)
  - Létezik polinom időbonyolultságú determinisztikus algoritmus?
- **Hátizsák probléma:**
  - Adott kapacitású hátizsákba hogyan pakoljuk a lehető legnagyobb értékű cuccot?

#### NP-teljes nyelvek bizonyítása

- Találni kell egy NP-teljes nyelvet (pl. SAT).
- Egy nyelv NP-teljessége belátható:
  - NP-beliség: Tanú-tétel segítségével.
  - Nehézség: Visszavezetés konstruálásával.

#### SAT - Az első NP-teljes nyelv

- **SAT:** A kielégíthető Boole-formulák nyelve.
  - **Boole-formula építőelemei:**
    - Ítéletváltozók: \(x_1, x_2, \ldots, x_n\)
    - Logikai operátorok: negáció, konjunkció, diszjunkció
  - **Példa:** \((x_1 \lor \neg x_2) \land (x_3 \lor x_4)\) kielégíthető?

#### SAT nehézségének bizonyítása

- **NP-beliség:** Könnyű bizonyítani a Tanú-tétellel. A tanú a Boole-formula változóinak egy kiértékelése.
- **NP-nehéz:** Nehéz bizonyítani. Bármely nemdeterminisztikus polinom időkorlátos Turing-gép működését felírhatjuk egy (hatalmas) Boole-formula alakjában.

#### Boole-formula és Turing-gép

- Szükséges ítéletváltozók:
  - \(B(i, j, a)\): Az \(i\) lépésben a \(j\) cellában \(a\) van.
  - \(H(i, j)\): Az \(i\) lépésben a fej a \(j\) cellán áll.
  - \(Q(i, q)\): Az \(i\) lépésben a gép \(q\) állapotban van.
- Kezdeti állapotok:
  - \(Q(0, q_0)\)
  - \(H(0, 0)\)
  - A szalag kezdeti tartalma, pl. 0100 input esetén.
- Technikai megkötések:
  - Minden pillanatban pontosan 1 állapotban vagyunk.
  - Minden cellán minden pillanatban pontosan 1 betű van.
  - A fej minden pillanatban pontosan 1 cellán áll.
  - Azok a cellák, melyek fölött nincs fej, megtartják az értéküket.
- Állapotátmenet-függvény leírása:
  - Példa: ha \((q_1, a) \rightarrow (q_2, b, R)\), akkor \(Q(i, q_1) \land H(i, j) \land B(i, j, a) \rightarrow Q(i+1, q_2) \land B(i+1, j, b) \land H(i+1, j+1)\)
- Elfogadással kapcsolatos megkötés:
  - Az elfogadási állapot elérése kielégíti a teljes formulát, ha a Turing-gép elfogadja az inputját.

#### Konjunktív normálforma (KNF)

- Minden Boole-formula átírható 3-KNF-re.
  - 3-KNF: Minden klóz 3-elemű.
- **3-SAT:** Kielégíthető 3-KNF-ben levő Boole-formulák nyelve.
  - Mivel minden Boole-formula átírható 3-KNF-re, a SAT visszavezethető 3-SAT-ra.
  - Ezért 3-SAT egy NP-nehéz nyelv.
  - Mivel 3-SAT NP-ben is van, ezért 3-SAT NP-teljes.

#### További NP-teljes nyelvek

- **Hamilton-kört tartalmazó gráfok nyelve.**
  - Korábban beláttuk, hogy NP-ben van.
  - NP-nehéz is? Ha igen, akkor NP-teljes.
  - Bármely 3-SAT Boole-formulához meg lehet adni egy G gráfot úgy, hogy a formula kielégíthető, ha és csak ha G Hamilton-kör tartalmaz.
- **Egyéb példák:**
  - Maximális klikk probléma gráfokban.
  - Maximális független csúcshalmaz keresése gráfokban.
  - Minimális/maximális feszítőfa keresése gráfokban.
  - Sávszélesség maximalizálásának problémája.
  - Számok faktorizációja (szorzótényezőkre bontása).

Ez a jegyzet segít áttekinteni az NP-teljes nyelvek fogalmát, példáit és azok bizonyítási módszereit.

Itt található a PowerPoint prezentáció alapján készült felsorolásos jegyzet az egyéb bonyolultsági osztályokra teljes nyelvekről:

### Egyéb bonyolultsági osztályokra teljes nyelvek

#### Bonyolultsági osztályok

#### Példa NL-teljes nyelvekre

- **Elérhetőség gráfokban:**
  - Kérdés: Létezik-e út két adott csúcs között?
  - Megoldás: Nemdeterminisztikusan bejárjuk a gráfot az egyik csúcsból indulva.
  - Tárolás: Elég csak az aktuális csúcsot (annak sorszámát) tárolni.
  - Logaritmikus számkódolás: \( O(\log n) \)

#### Példa P-teljes nyelvekre

- **3-KNF kielégíthetőség:**
  - Kérdés: \( k \) klózokból álló 3-KNF kielégíthető-e?
  - Megoldás: Alacsonyabb bonyolultság mint NP és PSPACE esetén (P-teljes).

- **Hálózat-kiértékelés:**
  - Kérdés: Logikai áramkör outputja 0 vagy 1-e?
  - Logikai kapuk: AND, OR, NOT, XOR
  - Adott input bitek esetén.

- **Lineáris programozás:**
  - Optimalizációs probléma.
  - Feltételek: Lineáris egyenlőtlenségek.
  - Célfüggvény maximalizálása: \( c^T x \), ahol \( c \) és \( x \) vektorok.
  - Ismert algoritmus: Szimplex módszer.

#### Példa PSPACE-teljes nyelvekre

- **QBF (Kvantifikált Boole-formula):**
  - Kérdés: \( \exists x_1 \forall x_2 \exists x_3 \ldots \varphi(x_1, x_2, x_3, \ldots) \)?
  - Nagyobb bonyolultságú mint NP (PSPACE-teljes).

#### Példa EXPTIME-teljes nyelvekre

- **Reversi/Othello:**
  - Kérdés: Melyik lépés visz legközelebb a nyerés esélyéhez?

- **Mahjong solitaire:**
  - Kérdés: Megoldható-e az adott játékállás?

- **Sokoban:**
  - Kérdés: Elérhető-e a célállapot?

- **Sakk:**
  - Kérdés: Melyik lépés visz legközelebb a nyerés esélyéhez?

- **Go:**
  - Japán szabályok szerint bizonyítottan EXPTIME-teljes.

Ez a jegyzet segít áttekinteni az egyéb bonyolultsági osztályokra teljes nyelveket és azok példáit különböző problémák esetében.