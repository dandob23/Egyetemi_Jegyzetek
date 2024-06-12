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