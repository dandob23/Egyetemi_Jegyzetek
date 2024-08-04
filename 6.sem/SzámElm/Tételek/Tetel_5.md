### 5. Nemdeterminisztikus Turing-gép működése és definíciója, hozzájuk kapcsolódó fogalmak. Szimulációja determinisztikus Turing-géppel. Nemdeterminisztikus bonyolultsági osztályok.

#### Nemdeterminisztikus Turing-gép működése és definíciója

- **Nemdeterminisztikus Turing-gép elemei:**
  - **Szalag (\(\Sigma\))**: Végtelen hosszúságú, cellákra osztott szalag, amelyre jelek (betűk) írhatók.
  - **Fej**: A szalag egy celláját olvassa vagy írja, és mozoghat balra vagy jobbra.
  - **Állapotok halmaza (\(Q\))**: A gép belső állapotainak véges halmaza.
  - **Kezdőállapot (\(q_0\))**: A Turing-gép kezdeti állapota.
  - **Elfogadó állapotok halmaza (\(F\))**: Azok az állapotok, amelyekben a gép elfogad egy bemenetet.
  - **Állapotátmenet függvény (\(\delta\))**: Meghatározza, hogyan változik az állapot, a szalagra írandó jel és a fej mozgásának iránya egy adott állapot és szalagjel alapján.
    - **Nemdeterminisztikus esetben**: \(\delta: Q \times \Sigma \rightarrow \mathcal{P}(Q \times \Sigma \times \{L, R\})\)

- **Nemdeterminisztikus Turing-gép definíciója:**
  - \( \Sigma \): Szalagjelek halmaza
  - \( Q \): Állapotok halmaza
  - \( q_0 \): Kezdőállapot
  - \( F \): Elfogadó állapotok halmaza
  - \( \delta \): Állapotátmenetfüggvény: \( \delta(q, a) = \{(q', b, m)\} \)
    - Ahol \(\delta\) több lehetséges kimenetet adhat egy adott állapot és szalagjel kombinációra.

#### Kapcsolódó fogalmak

- **Konfiguráció:**
  - A Turing-gép aktuális állapota, a szalag tartalma és a fej pozíciója.
  - Jelölése: \( (q, \alpha a \beta) \), ahol \( q \) az aktuális állapot, \( \alpha \) és \( \beta \) a szalag bal és jobb oldala, \( a \) pedig az aktuálisan olvasott betű.
  
- **Megállási konfiguráció:**
  - Olyan konfiguráció, amelyben a Turing-gép nem tud továbblépni.
  - Az állapotátmenetfüggvény nincs értelmezve az aktuális állapoton és szalagon lévő jelnél, vagy az aktuális állapot az elfogadó állapotok halmazában van.

- **Elfogadás/elutasítás:**
  - **Elfogadás:** Ha a Turing-gép eljut egy elfogadó állapotba, akkor elfogadja a bemenetet.
  - **Elutasítás:** Ha a Turing-gép megállás nélkül fut, vagy elutasító állapotba kerül, akkor elutasítja a bemenetet.

- **Időkorlát:**
  - Az a maximális lépésszám, amelyet a Turing-gép végrehajt egy adott bemeneten.
  - Időbonyolultság: Az adott bemenetre a Turing-gép által végrehajtott lépések száma.
  - Időkorlátos Turing-gép: Olyan Turing-gép, amely egy polinom időbonyolultsági korlátot nem lép túl.

#### Szimulációja determinisztikus Turing-géppel

- **Szimuláció lépései:**
  - A nemdeterminisztikus Turing-gép minden lehetséges futási ága egy determinisztikus Turing-gép által szimulálható.
  - A determinisztikus Turing-gép egy számítási fát generál, amelyben minden ágon végigfut.
  - Az összes lehetséges konfigurációt és állapotot bejárja, amíg el nem ér egy elfogadó konfigurációt vagy az összes ágat végig nem futja.

- **Tétel:** Bármely \( t(n) \) időkorlátos nemdeterminisztikus Turing-gép szimulálható \( 2^{O(t(n))} \) időkorlátos determinisztikus Turing-géppel.

- **Példa:**
  - A nemdeterminisztikus Turing-gép egy \( t(n) \) lépéses futási ideje során legfeljebb \( t(n) \) hosszúságú számítási ággal rendelkezik.
  - A determinisztikus Turing-gép szimulációja ennek megfelelően exponenciális időben fut le.

#### Nemdeterminisztikus bonyolultsági osztályok

- **Nemdeterminisztikus időbonyolultsági osztályok:**
  - **\(NTIME(t(n))\):** Azok a nyelvek, amelyek eldönthetők egy \( t(n) \) időkorlátos nemdeterminisztikus Turing-géppel.
  - **\(NP\):** Azok a nyelvek, amelyek eldönthetők polinomiális időkorlátos nemdeterminisztikus Turing-géppel. \( NP = \bigcup_{k \in \mathbb{N}} NTIME(n^k) \)
  - **\(NEXP\):** Azok a nyelvek, amelyek eldönthetők exponenciális időkorlátos nemdeterminisztikus Turing-géppel. \( NEXP = \bigcup_{k \in \mathbb{N}} NTIME(2^{n^k}) \)

- **Nemdeterminisztikus tárbonyolultsági osztályok:**
  - **\(NSPACE(s(n))\):** Azok a nyelvek, amelyek eldönthetők egy \( s(n) \) tárkorlátos nemdeterminisztikus Turing-géppel.
  - **\(NPSPACE\):** Azok a nyelvek, amelyek eldönthetők polinomiális tárkorlátos nemdeterminisztikus Turing-géppel. \( NPSPACE = \bigcup_{k \in \mathbb{N}} NSPACE(n^k) \)

#### Összefoglalás

- A nemdeterminisztikus Turing-gépek lehetővé teszik a problémák hatékonyabb megoldását bizonyos esetekben, mivel egyszerre több lehetséges utat is bejárhatnak.
- A nemdeterminisztikus Turing-gépek determinisztikus Turing-gépekkel történő szimulálása fontos eszköz a nemdeterminisztikus és determinisztikus bonyolultsági osztályok közötti kapcsolat megértéséhez.
- Az NP és NPSPACE osztályok közötti összefüggések fontosak a számításelmélet központi kérdéseinek megértéséhez.

Ezek az alapvető fogalmak és definíciók segítenek megérteni a nemdeterminisztikus Turing-gépek működését és a kapcsolódó számításelméleti koncepciókat.