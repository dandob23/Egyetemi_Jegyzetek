### 4. Időbonyolultsági osztályok. Lineáris felgyorsítás tétele. Lyukszalagos Turing-gépek, tárbonyolultsági osztályok.

#### Időbonyolultsági osztályok

- **Időbonyolultsági osztályok definíciói:**
  - **\(DTIME(t(n))\):** Azok a nyelvek, amelyek eldönthetők egy \(t(n)\) időkorlátos determinisztikus Turing-géppel.
  - **\(P\):** Azok a nyelvek, amelyek eldönthetők polinomiális időkorlátos Turing-géppel. \(P = \bigcup_{k \in \mathbb{N}} DTIME(n^k)\)
  - **\(EXPTIME\):** Azok a nyelvek, amelyek eldönthetők exponenciális időkorlátos Turing-géppel. \(EXPTIME = \bigcup_{k \in \mathbb{N}} DTIME(2^{n^k})\)

#### Lineáris felgyorsítás tétele

- **Lineáris felgyorsítás tétele:**
  - **Tétel:** Legyen \(L\) eldönthető egy \(t(n)\) időkorlátos Turing-géppel. Bármely \(c > 0\) valós számra, \(L\) eldönthető \(\frac{t(n)}{c}\) időkorlátos Turing-géppel is.
  - **Következmény:** A multiplikatív és additív konstansok elhanyagolhatóak az időbonyolultságban.

- **Lineáris felgyorsítás lépései:**
  - **Kódolás:**
    - Balról jobbra haladva a betűk letárolása, majd jobbról balra haladva az 1. szalagra írás.
    - Lépésszám: \(O(n)\).
  - **Szimuláció:**
    - \(k\) db. lépés szimulálása egyszerre: 6 lépésben.
    - Szomszédos cellák beolvasása és hatás érvényesítése.
    - Lépésszám: \(O(t(n)/c)\).

#### Lyukszalagos Turing-gépek

- **Lyukszalagos Turing-gépek motivációja:**
  - Az inputot nem kellene a tárigénybe beleszámítani.
  - Ha beleszámítanánk, sohasem tudnánk lineáris tárbonyolultság alá menni.
  - Az input és az output nem számít bele a tárigénybe.
  - Lehetővé teszi logaritmikus tárbonyolultsági osztályok definiálását.

- **Lyukszalagos Turing-gép definíciója:**
  - \( \Sigma \): Szalagjelek halmaza
  - \( Q \): Állapotok halmaza
  - \( q_0 \): Kezdőállapot
  - \( F \): Elfogadó állapotok halmaza
  - \( \delta \): Állapotátmenetfüggvény: \( \delta(q, a_1, a_2, ..., a_k) = (q', b_1, b_2, ..., b_k, m_1, m_2, ..., m_k) \)

#### Tárbonyolultsági osztályok

- **Tárbonyolultsági osztályok definíciói:**
  - **\(DSPACE(f(n))\):** Azok a nyelvek, amelyek eldönthetők egy \(f(n)\) tárkorlátos lyukszalagos Turing-géppel.
  - **\(PSPACE\):** Azok a nyelvek, amelyek eldönthetők polinomiális tárkorlátos Turing-géppel. \(PSPACE = \bigcup_{k \in \mathbb{N}} DSPACE(n^k)\)
  - **\(EXPSPACE\):** Azok a nyelvek, amelyek eldönthetők exponenciális tárkorlátos Turing-géppel. \(EXPSPACE = \bigcup_{k \in \mathbb{N}} DSPACE(2^{n^k})\)
  - **\(L\):** Azok a nyelvek, amelyek eldönthetők logaritmikus tárkorlátos Turing-géppel. \(L = DSPACE(\log n)\)

#### Összefoglalás

- Az időbonyolultsági osztályok segítségével a nyelvek eldönthetőségének hatékonyságát vizsgáljuk.
- A többszalagos Turing-gép szimulálása és a lineáris felgyorsítás tételének megértése alapvető fontosságú az időbonyolultsági osztályok elemzéséhez.
- A lyukszalagos Turing-gépek bevezetése lehetővé teszi a logaritmikus tárbonyolultsági osztályok vizsgálatát, amelyek fontos szerepet játszanak a számításelméletben.

Ezek az alapvető fogalmak és definíciók segítenek megérteni az idő- és tárbonyolultsági osztályok működését és a kapcsolódó számításelméleti koncepciókat.