### 8. Visszavezetések. Nehézség és teljesség. Teljes nyelvek keresése. A számításelmélet központi kérdése és az NP-teljes nyelvek szerepe. Példák NP-teljes nyelvekre.

#### Visszavezetések

- **Visszavezetés (Reduction):**
  - Egy probléma \(A\) visszavezethető egy másik problémára \(B\) (jelölés: \(A \leq_p B\)), ha létezik egy polinomiális időben futó algoritmus, amely \(A\)-t \(B\)-re transzformálja úgy, hogy az \(A\)-ban való eldöntés \(B\)-ben való eldöntésre vezethető vissza.

- **Karp-féle visszavezetés (Karp Reduction):**
  - Egy probléma \(A\) Karp-féle visszavezetése egy másik problémára \(B\) polinomiális időben:
    - Létezik egy polinomiális időben futó függvény \(f\), hogy minden \(x\)-re: \(x \in A \iff f(x) \in B\).

#### Nehézség és teljesség

- **Nehézség:**
  - Egy probléma nehézsége azt jelenti, hogy bármely más probléma az adott osztályban polinomiális időben visszavezethető rá.
  - Ha egy probléma \(C\)-nehéz, akkor minden \(C\)-beli probléma visszavezethető rá.

- **Teljesség:**
  - Egy probléma teljes egy adott osztályban, ha nehéz és az osztályba tartozik.
  - \(C\)-teljes probléma: Az a probléma, amely \(C\)-nehéz és \(C\)-beli.

#### Teljes nyelvek keresése

- **Teljes nyelvek fontossága:**
  - Ha sikerül egy \(NP\)-teljes nyelvről belátni, hogy polinomiális időben eldönthető, akkor \(P = NP\).
  - A teljes nyelvek segítségével könnyebb bizonyítani más problémák nehézségét és teljességét.

- **NP-teljes nyelv keresése:**
  - Találni kell egy már ismert NP-teljes nyelvet.
  - Bizonyítani kell, hogy egy adott nyelv NP-ben van.
  - Meg kell találni a polinomiális időben visszavezetést a már ismert NP-teljes nyelvre.

#### A számításelmélet központi kérdése

- **\(P\) vs. \(NP\) kérdése:**
  - \(P\): Azon problémák halmaza, amelyek determinisztikus Turing-géppel polinomiális időben megoldhatók.
  - \(NP\): Azon problémák halmaza, amelyek nemdeterminisztikus Turing-géppel polinomiális időben megoldhatók.
  - Központi kérdés: \(P = NP\)?
    - Ha \(P = NP\), akkor minden nemdeterminisztikus polinomiális időben megoldható probléma determinisztikus polinomiális időben is megoldható.

#### NP-teljes nyelvek szerepe

- **NP-teljes problémák jelentősége:**
  - Az NP-teljes problémák a legnehezebb problémák az NP osztályban.
  - Ha egy NP-teljes probléma polinomiális időben megoldható, akkor minden NP-beli probléma polinomiális időben megoldható.
  - Az NP-teljes problémák tanulmányozása segít megérteni az NP osztály bonyolultsági struktúráját.

#### Példák NP-teljes nyelvekre

1. **SAT (Boole-kielégíthetőség) probléma:**
   - **Probléma:** Létezik-e olyan változóértékelés, amely kielégíti a Boole-formulát?
   - **Teljesség bizonyítása:** Cook-Levin tétel.

2. **3-SAT probléma:**
   - **Probléma:** Létezik-e olyan változóértékelés, amely kielégíti a 3-KNF formájú Boole-formulát?
   - **Visszavezetés:** SAT-ról polinomiális időben visszavezethető 3-SAT-ra.

3. **Hamilton-kör probléma:**
   - **Probléma:** Létezik-e a gráfban olyan kör, amely minden csúcsot pontosan egyszer érint?
   - **Visszavezetés:** Polinomiális időben visszavezethető 3-SAT-ra.

4. **Utazóügynök probléma (Travelling Salesman Problem - TSP):**
   - **Probléma:** Létezik-e olyan körút, amely legfeljebb \(k\) hosszú és minden várost pontosan egyszer érint?
   - **Visszavezetés:** Polinomiális időben visszavezethető Hamilton-kör problémára.

5. **Knapsack (Hátizsák) probléma:**
   - **Probléma:** Létezik-e olyan elemek kiválasztása, amely nem lépi túl a hátizsák kapacitását és maximális értéket ad?
   - **Visszavezetés:** Polinomiális időben visszavezethető 3-SAT-ra.

#### Összefoglalás

- A visszavezetések, nehézség és teljesség fogalmai alapvető fontosságúak a számításelméletben.
- Az NP-teljes problémák tanulmányozása segít megérteni az NP osztály bonyolultsági struktúráját és a \(P\) vs. \(NP\) kérdést.
- Az NP-teljes problémákra adott példák segítenek illusztrálni a teljesség és visszavezetések alkalmazását a számításelméletben.

Ezek az alapvető fogalmak és példák segítenek megérteni a visszavezetések, nehézség és teljesség jelentőségét a számításelméletben.