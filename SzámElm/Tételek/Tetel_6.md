### 6. NP nyelvosztály. Tanú-tétel. Példa NP-beli nyelvekre és a tanú-tétel alkalmazására.

#### NP nyelvosztály

- **NP osztály (Nemdeterminisztikus Polinomiális idő):**
  - Az NP osztály azon nyelvek halmaza, amelyek eldönthetők egy polinomiális időkorlátos nemdeterminisztikus Turing-géppel.
  - Formálisan: \( NP = \bigcup_{k \in \mathbb{N}} NTIME(n^k) \)

#### Tanú-tétel

- **Tanú-tétel (Certificate Theorem):**
  - A tétel kimondja, hogy egy nyelv akkor és csak akkor van NP-ben, ha létezik egy polinom hosszúságú tanú, amely alapján egy determinisztikus Turing-gép polinomiális időben ellenőrizni tudja, hogy a bemenet a nyelv eleme-e.

- **Formális megfogalmazás:**
  - Egy \( L \) nyelv \( NP \)-beli, ha létezik olyan polinom \( p(n) \) és egy determinisztikus Turing-gép \( M \), hogy:
    - Ha \( x \in L \), akkor létezik egy \( y \) tanú, amelyre igaz, hogy \( |y| \leq p(|x|) \) és \( M \) elfogadja az \( (x, y) \) bemenetet.
    - Ha \( x \notin L \), akkor bármely \( y \) esetén \( M \) elutasítja az \( (x, y) \) bemenetet.

#### Példa NP-beli nyelvekre

1. **Hamilton-kör probléma:**
   - **Probléma:** Létezik-e a gráfban olyan kör, amely minden csúcsot pontosan egyszer érint?
   - **Tanú:** Egy csúcspermutáció, amely a Hamilton-kört képviseli.
   - **Ellenőrzés:** Polinomiális időben ellenőrizhető, hogy a permutáció valóban Hamilton-kör-e a gráfban.

2. **3-SAT probléma:**
   - **Probléma:** Létezik-e olyan változóértékelés, amely kielégíti a 3-KNF formájú Boole-formulát?
   - **Tanú:** Egy változóértékelés.
   - **Ellenőrzés:** Polinomiális időben ellenőrizhető, hogy a változóértékelés kielégíti-e a Boole-formulát.

3. **Utazóügynök probléma (Travelling Salesman Problem - TSP):**
   - **Probléma:** Van-e olyan körút a városok között, amely legfeljebb \( k \) hosszú és minden várost pontosan egyszer érint?
   - **Tanú:** Egy várospermutáció, amely a körutat képviseli.
   - **Ellenőrzés:** Polinomiális időben ellenőrizhető, hogy a permutáció valóban körút-e, és a hossz legfeljebb \( k \).

#### Tanú-tétel alkalmazása

- **Lépések:**
  - **1. lépés:** Azonosítsuk a nyelvhez tartozó tanút, amely alapján eldönthető, hogy egy adott bemenet a nyelv eleme-e.
  - **2. lépés:** Bizonyítsuk be, hogy a tanú hosszúsága polinom függvénye a bemenet hosszának.
  - **3. lépés:** Bizonyítsuk be, hogy a tanú alapján egy determinisztikus Turing-gép polinomiális időben ellenőrizni tudja a bemenet helyességét.

- **Példa alkalmazás - Hamilton-kör probléma:**
  - **Tanú:** Egy csúcspermutáció.
  - **Tanú hosszúsága:** A csúcsok száma, amely polinomiális a bemenet méretéhez képest.
  - **Ellenőrzés:** A permutáció minden szomszédos csúcsa között létezik él, és a permutáció visszatér a kezdőcsúcshoz.

Ezek az alapvető fogalmak és példák segítenek megérteni az NP nyelvosztályt és a tanú-tétel alkalmazását különböző problémák esetében.