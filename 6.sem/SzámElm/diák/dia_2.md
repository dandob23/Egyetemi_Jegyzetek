### Algoritmus modellek és Turing-gép

**Mi az az algoritmus?**  
**Mik az elemi lépések?**  
**Mi az idő- és tárbonyolultság?**

### Algoritmus modellek

**Szükségünk van egy univerzális algoritmus modellre!**  

**Algoritmus modellek**:  
- Turing-gép  
- Rekurzív függvények  
- Lambda-kalkulus  
- Markov algoritmus  
- stb.

### Turing-gép

**Rekurzív függvények – Kleene (1936)**  
- Alapfüggvények + rekurzió  
- Való életben: funkcionális programozási nyelvek (pl. LISP)  

**Lambda-kalkulus – Church (1941)**  
- Absztrakt függvények és azok alkalmazása  
- Való életben: lambda kifejezések (pl. C#-ban)  

**Markov algoritmus – Markov (1961)**  
- Formális nyelvi megközelítés  
- Inputon behelyettesítési szabályokat végzünk  

**A fenti 4 algoritmus modell ekvivalens egymással.**  
**Válasszuk a Turing-gépet!**

### Church-Turing tézis és tétel

**1950-es évek lelkesedése**  
**Minden problémára van megoldó algoritmus?**

**Church-Turing tézis**:  
- A Turing-gép képes minden kiszámítható függvényt kiszámítani  

**Church-Turing tétel**:  
- Vannak Turing-géppel ki nem számítható függvények  

### Turing-gép

**Két fő alkatrész**:
- **Vezérlő**:
  - Egyetlen információ: aktuálisan melyik lehetséges állapotában van?
  - Lehetséges belső állapotainak halmaza: \( Q \)

- **Szalag**:
  - Cellákból áll, végtelen
  - Az író-olvasó fej aktuálisan az egyik cella felett áll
  - Betűk (=szalagjelek) halmaza: \( \Sigma \)
  - Van 2 kötelező speciális betű: \( \triangleright \), \( \sqcup \)

### Turing-gép formális definíciója

**Definíció**:  
\[ T = \langle \Sigma, Q, q_0, F, \delta \rangle \]

- \( \Sigma \): szalagjelek (betűk) halmaza, \( \triangleright, \sqcup \in \Sigma \)
- \( Q \): állapotok halmaza, \( Q \ne \emptyset \)
- \( q_0 \): kezdőállapot, \( q_0 \in Q \)
- \( F \): elfogadó állapotok halmaza, \( F \subseteq Q \)
- \( \delta \): (állapot)átmenetfüggvény

**Átmenetfüggvény**:  
- Aktuális állapot: \( q \in Q \)
- Aktuálisan olvasott betű: \( \sigma \in \Sigma \)

**Visszaadott értékek**:
- Következő állapot: \( q' \in Q \)
- A cellára visszaírandó betű: \( \sigma' \in \Sigma \)
- Merre mozduljon a fej: \( m \in \{ \leftarrow, -, \rightarrow \} \)

\[ \delta(q, \sigma) = (q', \sigma', m) \]

**Értelmezési tartomány és értékkészlet**:  
\[ \delta: \Sigma \times Q \rightarrow \Sigma \times Q \times \{ \leftarrow, -, \rightarrow \} \]

### Különleges szabályok

**A \( \triangleright \) betűvel kapcsolatos feltételek**:  
- Nem szabad átírni és mindig jobbra kell "pattannia".

### Példa Turing-gép konfigurációra

**Feladat**: Van-e a megadott input szóban 'x' betű?  
\[ \Sigma = \{a, b, c, \ldots, z, \triangleright, \sqcup \} \]  
\[ Q = \{q_0, f\} \]  
\[ F = \{f\} \]

### Turing-gép konfiguráció

**Szükséges leírás**:
- Milyen állapotban van a vezérlője?
- Milyen betűk vannak a szalagján? (összesen!)
- Melyik cellán áll az író-olvasó fej?

**Konfiguráció**:  
\[ (q, u, v), \text{ ahol } q \in Q \text{ és } u, v \in \Sigma^* \]

### Input és kezdőkonfiguráció

**Input**:  
- Egy \( x \) szó, amiben nincsenek speciális betűk (\( \triangleright, \sqcup \)).
\[ x \in (\Sigma \setminus \{ \triangleright, \sqcup \})^* \]

**Kezdőkonfiguráció**:
- Kezdőállapotban van a vezérlő
- Az író-olvasó fej a kezdőbetűn (\( \triangleright \)) van
- Az \( x \) input a kezdőbetűtől jobbra indul, és minden más cella üres
\[ (q_0, \triangleright, x) \]

### Megállási konfiguráció

**Olyan konfiguráció, ahonnan a Turing-gép nem tud továbblépni**:
\[ (q, u\sigma, v), \text{ ahol } \delta(q, \sigma) \text{ nincs értelmezve} \]

### Rákövetkezés

**Konfigurációból lépésben elérhető a konfiguráció**:
\[ (q, u, v) \rightarrow (q', u', v') \]

### Turing-gép megállásának vizsgálata

**Megáll-e a Turing-gép?**  
Adott \( x \) inputon a kezdőkonfigurációból megállási konfigurációba jutunk-e?  
Ha nem, akkor \( x \)-en végtelen ciklusba kerülünk.

**Elfogadás és elutasítás**:
- Ha van olyan \( (q, \triangleright u, v) \) megállási konfiguráció, hogy
\[ (q_0, \triangleright, x) \rightarrow (q, \triangleright u, v) \]

  - Ha \( q \notin F \), akkor \( T \) elutasítja \( x \)-et
  - Ha \( q \in F \), akkor \( T \) elfogadja \( x \)-et és az output \( uv \).

### Időigény és időkorlát

**Időigény**:  
Egy konkrét \( x \) inputon a megállásig megtett lépések pontos száma (\( t \)).

**Időkorlát**:  
Minden lehetséges inputon egy felső korlát az időigényre.  
Függvény formájában adjuk meg:
\[ f(n), \text{ ahol } n \text{ az input hossza} \]

**Számítási problémákat, mint nyelveket (azaz szavak halmazait) reprezentáljuk.**  
A Turing-gép milyen eredményt ad az \( L \) nyelv \( x \in L \) szavain, mint inputokon?

**Legyen \( L \subseteq (\Sigma \setminus \{ \triangleright, \sqcup \})^* \) nyelv.**  
- \( T \) eldönti \( L \)-t, ha minden \( x \in (\Sigma \setminus \{ \triangleright, \sqcup \})^* \) inputra:
  - ha \( x \in L \), akkor \( T \) elfogadja \( x \)-et
  - ha \( x \notin L \), akkor \( T \) elutasítja \( x \)-et

- \( T \) felismeri \( L \)-t, ha minden \( x \in (\Sigma \setminus \{ \triangleright, \sqcup \})^* \) inputra:
  - ha \( x \in L \), akkor \( T \) elfogadja \( x \)-et
  - ha \( x \notin L \), akkor \( T \) nem áll meg