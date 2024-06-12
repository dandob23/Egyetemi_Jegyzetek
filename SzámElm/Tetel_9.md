### 9. A SAT nyelv teljessége (bizonyítása csak vázlatosan). A 3-SAT és 3-SZIN nyelvek NP-teljessége. Példák más osztályokra teljes nyelvekre.

#### A SAT nyelv teljessége (bizonyítás vázlatosan)

- **SAT probléma:**
  - **Probléma:** Létezik-e olyan változóértékelés, amely kielégíti a Boole-formulát?

- **Cook-Levin tétel (1971):**
  - **Tétel:** A SAT probléma NP-teljes.
  - **Bizonyítás vázlatosan:**
    1. **NP-ben levés:** A SAT probléma NP-ben van, mert egy nemdeterminisztikus Turing-gép polinomiális időben képes ellenőrizni egy adott változóértékelést.
    2. **NP-nehézség:** Minden \( L \in NP \) probléma polinomiális időben visszavezethető a SAT problémára. Azaz minden nemdeterminisztikus polinomiális időbonyolultságú Turing-gép számítási folyamatát le lehet írni egy Boole-formulaként, amely kielégíthető, ha és csak ha a Turing-gép elfogadja a bemenetet.

#### A 3-SAT nyelv NP-teljessége

- **3-SAT probléma:**
  - **Probléma:** Létezik-e olyan változóértékelés, amely kielégíti a 3-KNF formájú Boole-formulát?
  - **3-KNF:** Egy Boole-formula, amely konjunkciók (AND) diszjunkciók (OR) 3 literálból álló klózaiból.

- **NP-teljesség:**
  - **NP-ben levés:** A 3-SAT probléma NP-ben van, mert egy nemdeterminisztikus Turing-gép polinomiális időben képes ellenőrizni egy adott változóértékelést.
  - **NP-nehézség:** A SAT probléma polinomiális időben visszavezethető a 3-SAT problémára. Azaz minden SAT formula polinomiális időben átalakítható egy 3-KNF formulává, amely kielégíthető, ha és csak ha az eredeti SAT formula kielégíthető.

#### A 3-SZIN nyelv NP-teljessége

- **3-SZIN probléma:**
  - **Probléma:** Létezik-e olyan 3 színnel való színezése a gráfnak, hogy két szomszédos csúcs mindig különböző színű legyen?
  - **NP-ben levés:** A 3-SZIN probléma NP-ben van, mert egy nemdeterminisztikus Turing-gép polinomiális időben képes ellenőrizni egy adott csúcsszínezést.
  - **NP-nehézség:** A 3-SAT probléma polinomiális időben visszavezethető a 3-SZIN problémára. Azaz minden 3-SAT formula polinomiális időben átalakítható egy gráffá, amely 3 színezhető, ha és csak ha a 3-SAT formula kielégíthető.

#### Példák más osztályokra teljes nyelvekre

- **P-teljes nyelvek:**
  - **Példa:** Lineáris programozás.
  - **Probléma:** Megoldható-e egy lineáris egyenlőtlenségekből álló rendszer egy adott célfüggvény maximalizálásával?
  - **Teljesség:** Bármely P osztályba tartozó probléma polinomiális időben visszavezethető lineáris programozásra.

- **PSPACE-teljes nyelvek:**
  - **Példa:** Kvantifikált Boole-formula (QBF).
  - **Probléma:** Igaz-e egy kvantifikált Boole-formula (\(\exists x_1 \forall x_2 \exists x_3 ... \varphi(x_1, x_2, x_3, ...)\))?
  - **Teljesség:** Bármely PSPACE osztályba tartozó probléma polinomiális időben visszavezethető QBF-re.

- **EXPTIME-teljes nyelvek:**
  - **Példa:** Reversi/Othello játék döntési problémája.
  - **Probléma:** Melyik lépés visz legközelebb a nyerés esélyéhez?
  - **Teljesség:** Bármely EXPTIME osztályba tartozó probléma polinomiális időben visszavezethető Reversi/Othello játékra.

Ezek a példák és definíciók segítenek megérteni a különböző nyelvosztályok közötti kapcsolatokat, és hogyan lehet bizonyítani egy nyelv teljességét az adott osztályban. A SAT, 3-SAT és 3-SZIN nyelvek NP-teljessége különösen fontos a számításelmélet központi kérdéseinek megértésében.