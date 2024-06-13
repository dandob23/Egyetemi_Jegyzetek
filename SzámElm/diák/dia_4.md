### Időbonyolultsági osztályok

A nyelveket (számítási problémákat) időbonyolultsági osztályokba soroljuk:

- **Melyik nyelvet lehet gyorsan eldönteni?**
- **Melyik nyelv esetén esélytelen az eldöntés?**

A nyelveket eldöntő Turing-gépek időkorlátja alapján.

A többszalagos Turing-gépet vesszük alapul, mivel bebizonyítjuk, hogy bármely többszalagos Turing-gép "szimulálható" egyszalagossal.

#### TIME(𝑓(𝑛)) osztály

\[ L \in TIME(f(n)) \]

ha van olyan \( O(f(n)) \) időkorlátos (többszalagos) Turing-gép, mely eldönti \( L \)-t.

**Kérdés**: Van-e jogosultsági alapja az \( O \) jelölésnek?  
**Válasz**: Igen! ("Lineáris felgyorsítás")

### Polinomiális időkorlátos Turing-géppel eldönthető nyelvek osztálya

\[ P = \bigcup_{k \geq 1} TIME(n^k) \]

### Exponenciális időkorlátos Turing-géppel eldönthető nyelvek osztálya

\[ EXPTIME = \bigcup_{k \geq 1} TIME(c^{n^k}) \]

### Szimuláció

Egy \( T' \) Turing-gép szimulál egy \( T \) Turing-gépet, ha minden \( x \) input esetén:

- Ha \( T \) nem áll meg \( x \)-en, akkor \( T' \) sem áll meg \( x \)-en.
- Ha \( T \) elutasítja \( x \)-et, akkor \( T' \) is elutasítja \( x \)-et.
- Ha \( T \) elfogadja \( x \)-et és az \( y \) kimenetet állítja elő, akkor \( T' \) is elfogadja \( x \)-et és az \( y \) kimenetet állítja elő.

#### Tétel

Bármely \( f(n) \) időkorlátos \( T \) Turing-gép szimulálható \( O(f^2(n)) \) időkorlátos egyszalagos \( T' \) Turing-géppel.

\[ T = \langle k, \Sigma, Q, q_0, F, \delta \rangle \]

\[ T' = \langle \Sigma', Q', q_0, F, \delta' \rangle \]

### Kódolás

- \( x \) minden \( \sigma \) betűjére:  
  \( \sigma \rightarrow (\sigma, \sqcup, \sqcup, \ldots, \sqcup, \sqcup) \)
- Kezdőszimbólumra:  
  \( \triangleright \rightarrow (\triangleright, \underscore, \triangleright, \underscore, \ldots, \triangleright, \underscore) \)

**Kódolás lépésszáma**: \( O(|x|) \)

### Turing-gép szimulációja

**Egyetlen lépés szimulálása**:

- Balról jobbra haladva a \(\underscore\) alatti betűk eltárolása.
  **Lépésszám**: \( O(f(|x|)) \)
- Jobbról balra haladva a \( (q, \sigma_1, \ldots, \sigma_k) \) állapot alapján a \(\delta\) által meghatározott változtatások elvégzése.
  **Lépésszám**: \( O(f(|x|)) \)

**T összes, azaz \( f(|x|) \) lépésének szimulálása**:
  **Lépésszám**: \( O(f^2(|x|)) \)

### Dekódolás

- \( T' \) szalagjának minden \( (\sigma_1, h_1, \ldots, \sigma_k, h_k) \) betűjére:  
  \( (\sigma_1, h_1, \ldots, \sigma_k, h_k) \rightarrow \sigma_k \)

**Lépésszám**: \( O(f(|x|)) \)

### Lépésszám összesítve

\[ O(|x|) + O(f^2(|x|)) + O(f(|x|)) = O(f^2(|x|)) \]

**Tfh.**: \( f(n) \geq n \)

#### Tétel

Legyen \( L \) eldönthető \( f(n) \) időkorlátos Turing-géppel.  
Minden \( c > 0 \) valós számra: \( L \) eldönthető \( c \cdot f(n) + n + 2 \) időkorlátos Turing-géppel is.

**Következmény**: A multiplikatív és additív konstansok elhanyagolhatóak az időbonyolultságban.

### Példa

Legyen adott (egy később meghatározandó) \( m \geq 1 \) csak \( c \)-től függő egész szám.

**Tfh.**: \( f(n) \geq n \)

**Lépésszám összesen**:

\[ |x| + 2 + \lceil |x| / m \rceil + 6 \cdot \lceil f(|x|) / m \rceil \leq |x| + 2 + 7 \cdot \lceil f(|x|) / m \rceil \]

Eredeti állításban: \( c \cdot f(|x|) + |x| + 2 \)

\[ m := \lceil 7 / c \rceil \]