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