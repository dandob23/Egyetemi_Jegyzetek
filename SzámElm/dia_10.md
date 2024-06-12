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