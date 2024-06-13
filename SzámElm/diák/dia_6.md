### Nem-determinisztikus Turing-gépek és bonyolultsági osztályok

#### Nem-determinisztikus Turing-gép definíciója

\[ T = \langle \Sigma, Q, q_0, F, \delta \rangle \]
- \(\Sigma\): szalagjelek (betűk) halmaza, \(\triangleright, \sqcup \in \Sigma\)
- \( Q \): állapotok halmaza, \( Q \neq \emptyset \)
- \( q_0 \): kezdőállapot, \( q_0 \in Q \)
- \( F \): elfogadó állapotok halmaza, \( F \subseteq Q \)
- \(\delta\): (állapot)átmenetfüggvény, \(\delta: Q \times \Sigma \rightarrow P(Q \times \Sigma \times \{ \leftarrow, - , \rightarrow \})\)

\[ \delta(q, \sigma) = (q', \sigma', m) \]
- Ha \(\sigma = \triangleright\), akkor \(\sigma' = \triangleright\) és \(m = \rightarrow\)

#### Input feldolgozása

Input: \( x \in (\Sigma \setminus \{\triangleright, \sqcup\})^* \)

- Ha van olyan ága a számítási fának, mely elfogadó konfigurációban végződik, akkor \( T \) elfogadja \( x \)-et.
- Ha nincs ilyen ága, akkor \( T \) elutasítja \( x \)-et.

Ha van olyan \( (q, \triangleright u, v) \) megállási konfiguráció, hogy
\[ (q_0, \triangleright, x) \overset{T^t}{\rightarrow} (q, \triangleright u, v) \]

- Ha \( q \notin F \), akkor \( T \) elutasítja \( x \)-et.
- Ha \( q \in F \), akkor \( T \) elfogadja \( x \)-et és az output \( uv \).

\( T \) időigénye az \( x \) inputon: \( t \)

- Ha nincs ilyen konfiguráció, \( T \) elutasítja \( x \)-et.

#### Időkorlát

\( T \) \( f(n) \) időkorlátos:
- Minden \( x \) input és
- Minden \( (q, u, v) \) konfiguráció esetén
\[ \text{ha } (q_0, \triangleright, x) \overset{T^t}{\rightarrow} (q, u, v), \text{ akkor } t \leq f(|x|). \]

#### Szimuláció

Tétel: Bármely \( f(n) \) időkorlátos nem-determinisztikus \( T \) Turing-gép szimulálható \( O(d^{f(n)}) \) időkorlátos determinisztikus Turing-géppel, ahol \( d > 1 \) a \( T \)-től függő konstans.

- \( d \): egy csúcsból induló élek maximális száma
- Számítási sorozat = 0,1, ..., d-1 intervallumba eső számok sorozata

### Bonyolultsági osztályok

#### NTIME(𝑓(𝑛)) osztály

\[ L \in NTIME(f(n)) \]

Ha van olyan \( O(f(n)) \) időkorlátos (nem-determinisztikus) Turing-gép, mely eldönti \( L \)-t.

#### NSPACE(𝑓(𝑛)) osztály

\[ L \in NSPACE(f(n)) \]

Ha van olyan \( O(f(n)) \) tárkorlátos (nem-determinisztikus) Turing-gép, mely eldönti \( L \)-t.

### NP osztály

Polinom időkorlátos nem-determinisztikus Turing-géppel eldönthető nyelvek osztálya:
\[ NP = \bigcup_{k \geq 1} NTIME(n^k) \]

Gráfelméleti nyelvek, számelméleti problémák, egyenletek megoldásai, utazóügynök probléma stb.

### NEXPTIME osztály

Exponenciális időkorlátos nem-determinisztikus Turing-géppel eldönthető nyelvek osztálya:
\[ NEXPTIME = \bigcup_{k \ge 1} NTIME(c^{n^k}) \]

### NL osztály

Logaritmikus tárkorlátos nem-determinisztikus Turing-géppel eldönthető nyelvek osztálya:
\[ NL = NSPACE(\log_c n) \]

### Hiányzó osztályok

- Miért nincs \( NPSPACE \)?
- Miért nincs \( NEXPSPACE \)?

Később fogjuk tanulni és bizonyítani, hogy miért nem.