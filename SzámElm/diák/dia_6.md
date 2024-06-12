Itt található a PowerPoint prezentáció alapján készült felsorolásos jegyzet a nemdeterminisztikus Turing-gépről:

### Nemdeterminisztikus Turing-gép

#### Általános fogalmak

- Nemdeterminisztikus számítások alapfogalmai.

#### Nemdeterminisztikus Turing-gép definíciója

- \(\Sigma\): szalagjelek (betűk) halmaza
- \( Q \): állapotok halmaza
- \( q_0 \): kezdőállapot
- \( F \): elfogadó állapotok halmaza
- \(\delta\): (állapot)átmenetfüggvény
  - \( \delta(q, a) = \{(q', b, m)\} \)

#### Konfiguráció

- **Konfiguráció:** \( (q, \alpha a \beta) \), ahol \(\alpha\) és \(\beta\) a szalag bal és jobb oldala, \( a \) pedig az aktuálisan olvasott betű
- **Megállási konfiguráció:** \( (q, \alpha a \beta) \), ahol \(\delta(q, a)\) nincs értelmezve vagy \( q \in F \)

#### Közvetlen rákövetkezés

- Ha \( \delta(q, a) = (q', b, m) \), akkor a következő állapot \( q' \), a szalagra visszaírandó betű \( b \), és a fej mozgásának iránya \( m \)

#### Rákövetkezés

- Léteznek \(C_1, C_2, ..., C_k\) konfigurációk, hogy \( C_1 \rightarrow C_2 \rightarrow ... \rightarrow C_k \)

#### Elfogadás és elutasítás

- **Input:** \( w \)
- Ha van olyan ága a számítási fának, amely elfogadó konfigurációban végződik, akkor elfogadja \( w \)-t.
- Ha nincs ilyen ága, akkor elutasítja \( w \)-t.

#### Időkorlát

- \( M \) időkorlátos:
  - Minden \( x \) input és minden \( t \) konfiguráció esetén, ha \( C_1 \rightarrow C_2 \rightarrow ... \rightarrow C_t \), akkor \( t \leq f(|x|) \).

#### Eldöntött / Felismert nyelv

- Legyen \( L \) nyelv.
- \( M \) eldönti \( L \)-t, ha minden \( w \) inputra:
  - Ha \( w \in L \), akkor \( M \) elfogadja \( w \)-t.
  - Ha \( w \notin L \), akkor \( M \) elutasítja \( w \)-t.
- \( M \) felismeri \( L \)-t, ha minden \( w \) inputra:
  - Ha \( w \in L \), akkor \( M \) elfogadja \( w \)-t.
  - Ha \( w \notin L \), akkor \( M \) nem áll meg.

#### Nemdeterminisztikus Turing-gép szimulációja

- **Tétel:** Bármely \( t(n) \) időkorlátos nemdeterminisztikus \( M \) Turing-gép szimulálható \( 2^{O(t(n))} \) időkorlátos determinisztikus Turing-géppel, ahol \( c \) a \( M \)-től függő konstans.
- **Működés:**
  - 1. szalag: változatlan input
  - 2. szalag: \( t(n) \) számsor \( \{0,1\} \)
  - 3. szalag: a \( M \) egyetlen szalagja
  - \( S \) működése:
    - 2. szalagra \( t \) kiírása.
    - 3. szalagon \( M \) szimulálása determinisztikusan a 2. szalagon levő számsor alapján.
    - Ha \( M \) elfogadja az inputot, akkor \( S \) is.
    - Ha nem, akkor törli a 3. szalagot, növeli a 2. szalagon levő számot (k-alapú számrendszer).

#### Nemdeterminisztikus bonyolultsági osztályok

- **\( NTIME(t(n)) \) osztály:**
  - Ha van olyan \( t(n) \) időkorlátos (nemdeterminisztikus) Turing-gép, amely eldönti \( L \)-t.
- **\( NSPACE(s(n)) \) osztály:**
  - Ha van olyan \( s(n) \) tárkorlátos (nemdeterminisztikus) Turing-gép, amely eldönti \( L \)-t.
- **\( NP \) osztály:**
  - Polinom időkorlátos nemdeterminisztikus Turing-géppel eldönthető nyelvek osztálya.
- **\( NEXP \) osztály:**
  - Exponenciális időkorlátos nemdeterminisztikus Turing-géppel eldönthető nyelvek osztálya.
- **\( NL \) osztály:**
  - Logaritmikus tárkorlátos nemdeterminisztikus Turing-géppel eldönthető nyelvek osztálya.

#### Hiányzó nyelvosztályok

- Miért nincs \( NP =? P \)?
- Miért nincs \( NSPACE =? PSPACE \)?
- Később fogjuk tanulni és bizonyítani, hogy miért nem.

Ez a jegyzet segít áttekinteni a nemdeterminisztikus Turing-gépekkel és a hozzájuk kapcsolódó fogalmakkal kapcsolatos ismereteket.