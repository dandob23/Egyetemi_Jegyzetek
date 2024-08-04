1. dia:

### Algoritmusok bonyolultsága

**Időbonyolultság**: elemi lépések száma  
**Tárbonyolultság**: memóriaigény  

### Bonyolultságelmélet

**Minden lehetséges inputra?**  
**És ha végtelen sok input létezik?**  
**Legrosszabb esetre** ("Worst-case complexity")  
Példa: lineáris keresés, bináris keresés  

**Legrosszabb esetben hány elemi lépés?**  

**Elemi lépés** = összehasonlítás  
\( n \) adatelemre = \( n \) hosszúságú inputra  

### Keresési algoritmusok időbonyolultsága

**Lineáris keresés**:  
- Legrosszabb esetben: \( n \) összehasonlítás  
- Időbonyolultság: \( O(n) \)  

**Bináris keresés**:  
- Legrosszabb esetben: \( \lceil \log_2 (n+1) \rceil \) összehasonlítás  
- Időbonyolultság: \( O(\log_2 (n)) \)  

### Ordó jelölés

\( O(f) \): \( f \) függvény növekedésének mértékét jelöli  

Adottak \( f \), \( g \): \( \mathbb{N} \mapsto \mathbb{N} \) függvények.  
\( f(n) = O(g(n)) \)  
\( \exists c > 0 \) és \( \exists n_0 > 0 \), hogy  
\( \forall n \ge n_0 \) esetén \( f(n) \le c \cdot g(n) \)  

### Bonyolultsági függvények

**Logaritmikus**: \( O(\log_c(n)) \)  
**Lineáris**: \( O(n) \)  
**Polinomiális**: \( O(n^k) \)  
**Négyzetes**: \( O(n^2) \)  
**Köbös**: \( O(n^3) \)  
**Exponenciális**: \( O(c^n) \)  
**Faktoriális**: \( O(n!) \)  
**Dupla exponenciális**: \( O(c^{(d^n)}) \)  

### Rendezési algoritmusok időbonyolultsága

**Probléma**: Rendezzük egy \( n \) elemű tömb elemeit (növekvő) sorrendbe!

**Legrosszabb esetben hány elemi lépés?**

**Elemi lépések**:  
- Összehasonlítások  
- Elemcserék  

### Rendezési algoritmusok

**Vizsgált algoritmusok**:  
- Buborék rendezés  
- Beszúrásos rendezés
  - Lineáris kereséssel
  - Bináris kereséssel  
- Összefésüléses rendezés  

### Buborék rendezés

**Kód**:
```cpp
for (i = n-1; i > 0; i--){
    for (j = 0; j < i; j++){
        if (T[j+1] < T[j]){
            swap(T[j+1], T[j]);
        }
    }
}
```

- **Összehasonlítások száma**: minden esetben \( \frac{n \cdot (n-1)}{2} \)  
- **Elemcserék száma**: legrosszabb esetben \( \frac{n \cdot (n-1)}{2} \)  
- **Összesen**: legrosszabb esetben \( n \cdot (n-1) \)  

**Időbonyolultság**: \( O(n^2) \)  

### Beszúrásos rendezés

**Kód**:
```cpp
for (i = 1; i < n; i++){
    x = T[i];
    j = search_place(T, i-1, x);
    shift_right(T, j, i-1);
    T[j] = x;
}
```

- **Lineáris kereséssel**:
  - **Összehasonlítások száma**: legrosszabb esetben \( \frac{n \cdot (n-1)}{2} \)
  - **Elemcserék száma**: legrosszabb esetben \( \frac{n \cdot (n-1)}{2} \)
  - **Összesen**: legrosszabb esetben \( n \cdot (n-1) = O(n^2) \)

- **Bináris kereséssel**:
  - **Összehasonlítások száma**: legrosszabb esetben \( \lceil \log_2 2 \rceil + \lceil \log_2 3 \rceil + \ldots + \lceil \log_2 n \rceil \le n \cdot \lceil \log_2 n \rceil \)
  - **Elemcserék száma**: legrosszabb esetben \( \frac{n \cdot (n-1)}{2} \)
  - **Összesen**: legrosszabb esetben \( \frac{n \cdot (n-1)}{2} + n \lceil \log_2 n \rceil = O(n^2) \)

### Összefésüléses rendezés

**Kód**:
```cpp
sort(T, imin, m) {
    if (m == 1) return T;

    A = sort(T, imin, m/2);
    B = sort(T, m/2+1, m);

    return merge(A, B);
}
```

- **Összehasonlítások száma**: legrosszabb esetben \( n \cdot \lceil \log_2 n \rceil \)
- **Elemcserék száma**: legrosszabb esetben \( n \cdot \lceil \log_2 n \rceil \)
- **Összesen**: legrosszabb esetben \( 2n \cdot \lceil \log_2 n \rceil = O(n \cdot \log_2 n) \)

### Rendezési algoritmusok összefoglalása

- **Buborék rendezés**: \( O(n^2) \)
- **Beszúrásos rendezés**:
  - Lineáris kereséssel: \( O(n^2) \)
  - Bináris kereséssel: \( O(n^2) \)
- **Összefésüléses rendezés**: \( O(n \cdot \log_2 n) \)

### Gráfok

**Definíció**: \( \langle V, E \rangle \)  
- \( V \): csúcsok (vertices) halmaza, \( V \ne \emptyset \)  
- \( E \): élek (edges) halmaza, \( E \subseteq V \times V \)  

**Élekhez költség**: \( c: E \mapsto \mathbb{N}^{(+)} \)  
- \( c(v, w) \), ahol \( (v, w) \in E \)  

**Út**: \( v_1, v_2, \ldots, v_k \in V \)  
- \( \forall i = 1, \ldots, k-1 \) esetén \( (v_i, v_{i+1}) \in E \)  
- **Költsége**: \( \sum_{i=1}^{k-1} c(v_i, v_{i+1}) \)  

### Elérhetőség problémája

**Van-e út két adott csúcs között?**  
- Mélységi keresés (DFS)  
- Szélességi keresés (BFS)  

**Melyik a legolcsóbb út?**  
- Két adott csúcs között?  
- Egy adott csúcsból az összes többibe? (Dijkstra algoritmus)  
- Bármely két csúcs között? (Floyd-Warshall algoritmus)  

### Hamilton-kör probléma

- **Több mint 100 éve tanulmányozzák**  
- "Naív" algoritmus: csúcsok permutációja kör-e?  
- **Időbonyolultság**: \( O(n!) \)  
- **Van-e polinomiális algoritmus?**

### Bonyolultsági függvények ismétlése

- **Logaritmikus**: \( O(\log_c(n)) \)
- **Lineáris**: \( O(n) \)
- **Polinomiális**: \( O(n^k) \)
- **Négyzetes**: \( O(n^2) \)
- **Köbös**:

 \( O(n^3) \)
- **Exponenciális**: \( O(c^n) \)
- **Faktoriális**: \( O(n!) \)
- **Dupla exponenciális**: \( O(c^{(d^n)}) \)

### Közlekedési lámpák

- **Konfliktuslehetőségek**:  
  - Tiltott
  - Nem tiltott

- **Gráffal ábrázolás**:
  - Csúcsok: \( ac, ad, bc, bd, ec, ed \)
  - Élek: két lámpa konfliktusos kapcsolata

### Gráfszínezési probléma

**Gráf színezése**:
- A csúcsokat beszínezzük
- Ha két csúcs között él van, akkor azok színei különbözőek legyenek!
- **Nem ismert polinomiális algoritmus!**


2. dia:
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

3.dia:
### Többszalagos Turing-gép

**Formális definíció**:  
\[ T = \langle k, \Sigma, Q, q_0, F, \delta \rangle \]

- \( k \): szalagok száma, \( k \geq 1 \)
- \( \Sigma \): szalagjelek (betűk) halmaza, \( \triangleright, \sqcup \in \Sigma \)
- \( Q \): állapotok halmaza, \( Q \ne \emptyset \)
- \( q_0 \): kezdőállapot, \( q_0 \in Q \)
- \( F \): elfogadó állapotok halmaza, \( F \subseteq Q \)
- \( \delta \): (állapot)átmenetfüggvény

**Átmenetfüggvény**:  
Milyen paraméterekkel és milyen függvényértékkel?

- 1 db. vezérlő, azaz 1 db. állapot
- \( k \) db. szalag van, ezért:
  - \( k \) db. betűt olvas: \( \sigma_1, \ldots, \sigma_k \)
  - \( k \) db. betűt ír: \( \sigma_1', \ldots, \sigma_k' \)
  - \( k \) db. mozgást végez: \( m_1, \ldots, m_k \)

\[ \delta(q, \sigma_1, \ldots, \sigma_k) = (q', \sigma_1', m_1, \ldots, \sigma_k', m_k) \]

### Többszalagos Turing-gép használata

\[ T = \langle k, \Sigma, Q, q_0, F, \delta \rangle \]

- \( k \): szalagok száma, \( k \geq 1 \)
- \( \Sigma \): szalagjelek (betűk) halmaza, \( \triangleright, \sqcup \in \Sigma \)
- \( Q \): állapotok halmaza, \( Q \ne \emptyset \)
- \( q_0 \): kezdőállapot, \( q_0 \in Q \)
- \( F \): elfogadó állapotok halmaza, \( F \subseteq Q \)
- \( \delta \): (állapot)átmenetfüggvény,
  \[ \delta: Q \times \Sigma^k \rightarrow Q \times \Sigma^k \times \{ \leftarrow, -, \rightarrow \}^k \]
  
\[ \delta(q, \sigma_1, \ldots, \sigma_k) = (q', \sigma_1', m_1, \ldots, \sigma_k', m_k) \]

**Feltétel**:  
Ha \( \sigma_i = \triangleright \), akkor \( \sigma_i' = \triangleright \) és \( m_i = \rightarrow \).

### Konfigurációk

**Egyszalagos Turing-gép esetén**:  
\[ (q, u, v) \]
ahol \( q \in Q \) és \( u, v \in \Sigma^* \)

**Többszalagos Turing-gép esetén**:  
\[ (q, u_1, v_1, \ldots, u_k, v_k) \]
ahol \( q \in Q \) és \( u_i, v_i \in \Sigma^* \)

### Szalagok funkciói

1. szalag = inputszalag  
Az input szó induláskor ide helyezzük.

\( k \)-dik szalag = outputszalag  
Megálláskor az output szót innen olvashatjuk ki.

**Többi szalag**: munkaszalagok  
A futtatás során átmeneti adatok tárolására.

### Kezdő- és megállási konfigurációk

**Kezdőkonfiguráció**:
- Az \( x \) input az 1. szalagon
- Többi szalag „üres”

\[ (q_0, \triangleright, x, \triangleright, \epsilon, \ldots, \triangleright, \epsilon) \]

**Megállási konfiguráció**:
\[ (q, u_1 \sigma_1, v_1, \ldots, u_k \sigma_k, v_k) \]
ahol \( \delta(q, \sigma_1, \ldots, \sigma_k) \) nincs értelmezve

### Output meghatározása

**Ha van olyan megállási konfiguráció**:  
\[ (q, \triangleright u_1, v_1, \ldots, \triangleright u_k, v_k) \]
hogy
\[ (q_0, \triangleright, x, \triangleright, \epsilon, \ldots, \triangleright, \epsilon) \rightarrow^t (q, \triangleright u_1, v_1, \ldots, \triangleright u_k, v_k) \]

- Ha \( q \notin F \), akkor \( T \) elutasítja \( x \)-et
- Ha \( q \in F \), akkor \( T \) elfogadja \( x \)-et és az output \( u_k v_k \).

### Örökölt fogalmak

**Időkorlát**  
**Eldöntött nyelv**  
**Felismert nyelv**

4. dia:

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

5. dia:

### Tárbonyolultság és Turing-gép architektúrája

Az időbonyolultságon kívül más bonyolultság-fogalmak is vizsgálhatók:

- A Turing-gép számítása során felhasznált szalagcellák száma

**Kérdés**: Milyen Turing-gép architektúrát vegyünk alapul?  
**Válasz**: Legyen \( T \) k-szalagos Turing-gép, és \( x \) ennek egy inputja.

Legyen \( (q, u_1, v_1, \ldots, u_k, v_k) \) egy megállási konfigurációja, melyre:
\[ (q_0, \triangleright, x, \triangleright, \epsilon, \ldots, \triangleright, \epsilon) \overset{T^t}{\rightarrow} (q, \triangleright u_1, v_1, \ldots, \triangleright u_k, v_k) \]

- Az inputot nem kellene a tárigénybe beleszámítani.
  - Ha beleszámítanánk, sohasem tudnánk lineáris tárbonyolultság alá menni.
- Ne számítsuk a tárigénybe se az inputot, se az outputot!
- Ne lehessen az input- és outputszalagokon tényleges számítási lépéseket végezni!
  - Inputszalag: csak olvasható.
  - Outputszalag: csak írható.

Logaritmikus tárbonyolultsági osztályokat is tudunk majd definiálni.

### Többszalagos Turing-gép

\[ T = \langle k, \Sigma, Q, q_0, F, \delta \rangle \]
- \( k \): szalagok száma, \( k \geq 2 \)
- \(\Sigma\): szalagjelek (betűk) halmaza, \(\triangleright, \sqcup \in \Sigma\)
- \( Q \): állapotok halmaza, \( Q \neq \emptyset \)
- \( q_0 \): kezdőállapot, \( q_0 \in Q \)
- \( F \): elfogadó állapotok halmaza, \( F \subseteq Q \)
- \(\delta\): (állapot)átmenetfüggvény, \(\delta: Q \times \Sigma^k \rightarrow Q \times \Sigma^k \times \{ \leftarrow, - , \rightarrow \}^k\)

\[ \delta(q, \sigma_1, \ldots, \sigma_k) = (q', \sigma_1', m_1, \ldots, \sigma_k', m_k) \]
- Ha \(\sigma_i = \triangleright\), akkor \(\sigma_i' = \triangleright\) és \( m_i = \rightarrow \)

### Lyukszalagos Turing-gép

Legyen \( T \) k-szalagos lyukszalagos Turing-gép, és \( x \) ennek egy inputja.

Legyen \( (q, u_1, v_1, \ldots, u_k, v_k) \) egy megállási konfigurációja, melyre:
\[ (q_0, \triangleright, x, \triangleright, \epsilon, \ldots, \triangleright, \epsilon) \overset{T^t}{\rightarrow} (q, \triangleright u_1, v_1, \ldots, \triangleright u_k, v_k) \]

### Tárigény

\( T \) tárigénye az x inputon: \(\sum_{i=2}^{k-1} |u_i v_i|\)

### Tárkorlát

\[ T \] f(n) tárkorlátos:

- \( T \) tárigénye minden \( x \) inputon legfeljebb \( f(|x|) \).

### Tárbonyolultsági osztályok

Az eldönthető nyelvek további osztályozása:

- A nyelveket eldöntő Turing-gépek tárkorlátja alapján
- A lyukszalagos Turing-gépet vesszük alapul 

### SPACE(𝑓(𝑛)) osztály

\[ L \in SPACE(f(n)) \]

ha van olyan \( O(f(n)) \) tárkorlátos lyukszalagos Turing-gép, mely eldönti \( L \)-t.

### Polinomiális tárkorlátos Turing-géppel eldönthető nyelvek osztálya

\[ PSPACE = \bigcup_{k \geq 1} SPACE(n^k) \]

### Exponenciális tárkorlátos Turing-géppel eldönthető nyelvek osztálya

\[ EXPSPACE = \bigcup_{k \geq 1} SPACE(c^{n^k}) \]

### Logaritmikus tárkorlátos Turing-géppel eldönthető nyelvek osztálya

\[ L = SPACE(\log_c n) \]

6. dia

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

7. dia:

### NP-be Tartozás Bizonyítéka

#### NP Osztályba Tartozó Nyelvek Példái

Gráfelméleti nyelvek, számelméleti problémák, egyenletek megoldásai, utazóügynök probléma stb.

#### NP-be Tartozás Bizonyítéka

A nyelvet eldöntő polinom időkorlátos nem-determinisztikus Turing-gép.

Ehelyett: egy egyszerűbb módszer, mely visszavezetést ad a determinisztikus eldöntésre.
Garantálni kell: a számítási fa polinom mélységű. Hogyan?

#### Tanú és Polinom Mélység

1. **A tanú legyen polinom hosszúságú!**
   - Ez garantálja, hogy a szaggatott vonal feletti részfa polinom mélységű.

2. **A tanút alkalmazó számítás legyen polinom időbonyolultságú!**
   - Ez garantálja, hogy a szaggatott vonal alatti minden egyes ág polinom hosszúságú.

#### Példa: Hamilton-kör

Egy gráf köre Hamilton-kör, ha azon a gráf minden csúcsa pontosan egyszer szerepel.
Hamilton-körrel rendelkező gráfok nyelve: "HAM"
"HAM" ∈ NP

1. **Tanú**: Egy \( x \) gráf tanúja a csúcsainak egy permutációja lesz.
   - \( y \) permutáció hossza polinomiális \( x \)-hez képest, mivel \(|y| \leq |x|\).

2. **Permutáció Ellenőrzése**:
   - Egymás utáni csúcsait él köti-e össze?
   - (Polinom időkorlátos determinisztikus Turing-géppel eldönthető)

#### Tanú Kritériumai

1. **Polinom Hosszúságú Tanú**:
   - \(|y|\) az \(|x|\)-nek legyen polinomja!
   - \(|y| \leq |x| \cdot c\)
   - \(|y| \leq |x|^c\)
   - \(|y| \leq c^{|x|}\)

2. **Determinista Polinom Időbonyolultságú Számítás**:
   - Inputja: \( (x, y) \)
   - Determinisztikus
   - Polinom időbonyolultságú

#### Tétel

Legyen \( L \) egy nyelv.
\[ L \in NP \]
ha és csak ha
\[ \exists c > 0 \text{ és } \exists L' \in P, \text{ hogy } \forall x \text{ szó esetén: } x \in L \iff \exists y \text{ szó, hogy } |y| \leq |x|^c \text{ és } (x, y) \in L' \]

#### Példa: Gráf Színezése

Egy gráf csúcsai \( k \geq 1 \) színnel színezhetőek-e úgy, hogy minden éle két különböző színű csúcsot köt össze?
\( k \)-színnel színezhető gráfok nyelve: \( k\)-SZIN
3-SZIN ∈ NP

1. **Tanú**: Egy \( x \) gráf tanúja a gráf egy színezése lesz.
   - Egy ilyen színezés leírható max. \( 2 \cdot |x| \) db. bináris számjeggyel, azaz \(|y| \leq 2 \cdot |x|\).

2. **Színezés Ellenőrzése**:
   - Minden él különböző színű csúcsokat köt-e össze?
   - (Polinom időkorlátos determinisztikus Turing-géppel eldönthető)

#### Példa: Egész Faktorizáció

Kriptográfiai protokollok biztonságossága alapszik ezen a nehéz problémán.
Pl. RSA: 232-jegyű számok egész faktorizációja.

Adott egy \( x \) egész szám és egy másik \( m \) egész szám úgy, hogy \( 1 < m < x \).

Vajon létezik olyan \( y \) szám, hogy \( 1 < y \leq m \) és \( y \) osztja \( x \)-et?

1. **Tanú**: Egy \( x \) egész szám tanúja egy \( y \) egész szám lesz.
   - Mivel \( 1 < m < x \) és \( 1 < y \leq m \), így \( y < x \).
   - Ezért \(|y| \leq |x|\).

2. **Ellenőrzés**:
   - \( y \) osztja-e \( x \)-et?
   - (Akár az általános iskolában tanult algoritmussal)
   - (Polinom időkorlátos determinisztikus Turing-géppel eldönthető)

8. dia:

### Eldönthetetlen Problémák

#### Van olyan probléma, mely algoritmussal nem megoldható?

- **Azaz van olyan nyelv, mely Turing-géppel nem eldönthető?**
  - Igen. (sajnos)

- **Van-e olyan 𝑈 Turing-gép, hogy:**
  - ∀𝑇 Turing-gép és ∀𝑥 input esetén:
    - 𝑈 megkapja a 𝑇 „programját” és az 𝑥 inputot, és megmondja, hogy 𝑇 megállna-e az 𝑥 inputon?
  - Nincs ilyen Turing-gép, ezért a megállási probléma eldönthetetlen.

### Post Megfeleltetési Problémája

- **Adott egy min. 2 elemű ábécé:** 𝐴
- **Adott 2 véges sorozat 𝐴 szavaiból:**
  - 𝛼_1, 𝛼_2, …, 𝛼_𝑁 és 𝛽_1, 𝛽_2, …, 𝛽_𝑁
- **Kérdés:** Összefűzhetőek a két sorozat szavai úgy (ismétlődésekkel), hogy összeolvasva ugyanazt a szót kapjuk?
  - 𝛼_(𝑖_1), 𝛼_(𝑖_2), …, 𝛼_(𝑖_𝑘) = 𝛽_(𝑖_1), 𝛽_(𝑖_2), …, 𝛽_(𝑖_𝑘), ahol 1 ≤ 𝑖_𝑗 ≤ 𝑁
  - Ez a probléma eldönthetetlen.

### Bonyolultsági Osztályok Összefüggései

#### Idő- és Tárbonyolultsági Osztályok

- **Az eldönthető nyelveket idő- és tárbonyolultsági osztályokba soroltuk.**
  - 𝐓𝐈𝐌𝐄(𝑓(𝑛)) ⊆ 𝐍𝐓𝐈𝐌𝐄(𝑓(𝑛))
  - 𝐒𝐏𝐀𝐂𝐄(𝑓(𝑛)) ⊆ 𝐍𝐒𝐏𝐀𝐂𝐄(𝑓(𝑛))

- **Egy Turing-gép 𝑘 lépésben max. 𝑘 szalagcellát használ.**
  - 𝐓𝐈𝐌𝐄(𝑓(𝑛)) ⊆ 𝐒𝐏𝐀𝐂𝐄(𝑓(𝑛))
  - 𝐍𝐓𝐈𝐌𝐄(𝑓(𝑛)) ⊆ 𝐍𝐒𝐏𝐀𝐂𝐄(𝑓(𝑛))

#### Szimuláció Nemdeterminisztikus Turing-géppel

- **Egy 𝑂(𝑓(𝑛)) időkorlátos nemdeterminisztikus 𝑇 Turing-gépet szimuláljunk egy 𝑇’ determinisztikussal!**
  - A 𝑇 számítási fájának egy ágát 𝑇’ végigszámolja: 𝑂(𝑓(𝑛)) lépés, max. 𝑂(𝑓(𝑛)) cella.
  - Visszalép a fa gyökerébe.
  - Másik ággal teszi ugyanezt.
  - Közben ugyanazt a szalagot használja (újra).
  - Mindvégig 𝑂(𝑓(𝑛)) cellát használ.
  - 𝐍𝐓𝐈𝐌𝐄(𝑓(𝑛)) ⊆ 𝐒𝐏𝐀𝐂𝐄(𝑓(𝑛))

#### Tár-idő Tétel

- **Tétel:** 𝐍𝐒𝐏𝐀𝐂𝐄(𝑓(𝑛)) ⊆ 𝐓𝐈𝐌𝐄(𝑐^𝑓(𝑛))

### Bonyolultsági Osztályok Definíciói

- 𝐏 = ⋃_(𝑘≥1) 𝐓𝐈𝐌𝐄(𝑛^𝑘)
- 𝐍𝐏 = ⋃_(𝑘≥1) 𝐍𝐓𝐈𝐌𝐄(𝑛^𝑘)
- 𝐄𝐗𝐏𝐓𝐈𝐌𝐄 = ⋃_(𝑘≥1) 𝐓𝐈𝐌𝐄(𝑐^(𝑛^𝑘))
- 𝐍𝐄𝐗𝐏𝐓𝐈𝐌𝐄 = ⋃_(𝑘≥1) 𝐍𝐓𝐈𝐌𝐄(𝑐^(𝑛^𝑘))
- 𝐋 = 𝐒𝐏𝐀𝐂𝐄(log_𝑐⁡𝑛)
- 𝐍𝐋 = 𝐍𝐒𝐏𝐀𝐂𝐄(log_𝑐⁡𝑛)
- 𝐏𝐒𝐏𝐀𝐂𝐄 = ⋃_(𝑘≥1) 𝐒𝐏𝐀𝐂𝐄(𝑛^𝑘)
- 𝐄𝐗𝐏𝐒𝐏𝐀𝐂𝐄 = ⋃_(𝑘≥1) 𝐒𝐏𝐀𝐂𝐄(𝑐^(𝑛^𝑘))

### Tartalmazási Viszonyok

- **Mivel 𝐒𝐏𝐀𝐂𝐄(𝑓(𝑛)) ⊆ 𝐍𝐒𝐏𝐀𝐂𝐄(𝑓(𝑛)):**
  - 𝐋 ⊆ 𝐍𝐋

- **Tár-idő tétel:** 𝐍𝐒𝐏𝐀𝐂𝐄(𝑓(𝑛)) ⊆ 𝐓𝐈𝐌𝐄(𝑐^𝑓(𝑛))
  - 𝐍𝐋 ⊆ 𝐏

- **Mivel 𝐓𝐈𝐌𝐄(𝑓(𝑛)) ⊆ 𝐍𝐓𝐈𝐌𝐄(𝑓(𝑛)):**
  - 𝐏 ⊆ 𝐍𝐏

- **Mivel 𝐍𝐓𝐈𝐌𝐄(𝑓(𝑛)) ⊆ 𝐒𝐏𝐀𝐂𝐄(𝑓(𝑛)):**
  - 𝐍𝐏 ⊆ 𝐏𝐒𝐏𝐀𝐂𝐄

- **Minden 𝑂(𝑓(𝑛)) tárkorlátos nemdeterminisztikus Turing-gép szimulálható 𝑂(𝑓^2 (𝑛)) tárkorlátos determinisztikus Turing-géppel.**
  - Azaz: 𝐍𝐒𝐏𝐀𝐂𝐄(𝑓(𝑛)) ⊆ 𝐒𝐏𝐀𝐂𝐄(𝑓^2 (𝑛))
  - Ezért: 𝐏𝐒𝐏𝐀𝐂𝐄 = 𝐍𝐏𝐒𝐏𝐀𝐂𝐄
  - És 𝐄𝐗𝐏𝐒𝐏𝐀𝐂𝐄 = 𝐍𝐄𝐗𝐏𝐒𝐏𝐀𝐂𝐄 stb.

#### Tár-idő Tétel Következményei

- 𝐏𝐒𝐏𝐀𝐂𝐄 ⊆ 𝐄𝐗𝐏𝐓𝐈𝐌𝐄

9. dia:

### Teljes Nyelvek Nyelvosztályokra Nézve

#### Adott 𝐶 nyelvosztályra nézve teljes nyelvek
- **Magukban hordozzák a 𝐶-be tartozó összes nyelv eldöntésének nehézségét.**
- **Pontosabban be lehet „lőni” az adott nyelv eldöntésének bonyolultságát.**
- **Segítségükkel könnyű bizonyítani, ha két osztály egybeesik.**

### Visszavezetés (Karp-redukció)

- **Az 𝐿_1 ⊆ 𝐼^∗ nyelv visszavezethető az 𝐿_2 ⊆ 𝐼^∗ nyelvre:**
  - ∃𝑓: 𝐼^∗ ↦ 𝐼^∗ polinom időkorlátos determinisztikus Turing-géppel kiszámítható (szó)függvény, hogy:
    - ∀𝑥 ∈ 𝐼^∗ szóra:
      - 𝑥 ∈ 𝐿_1 ⇔ 𝑓(𝑥) ∈ 𝐿_2
  - **Jelölés:** 𝐿_1 ≺ 𝐿_2

- **Visszavezetés tranzitivitása:**
  - ha 𝐿_1 ≺ 𝐿_2 és 𝐿_2 ≺ 𝐿_3, akkor 𝐿_1 ≺ 𝐿_3.

- **𝐏, 𝐍𝐏, 𝐏𝐒𝐏𝐀𝐂𝐄, 𝐄𝐗𝐏𝐓𝐈𝐌𝐄, 𝐍𝐄𝐗𝐏𝐓𝐈𝐌𝐄, 𝐄𝐗𝐏𝐒𝐏𝐀𝐂𝐄 zártak a visszavezetésre.**
  - Pl. ha 𝐿_1 ≺ 𝐿_2 és 𝐿_2 ∈ 𝐍𝐏, akkor 𝐿_1 ∈ 𝐍𝐏.

### Nyelvosztályok és Nehézségük

- **Legyen 𝐶 egy nyelvosztály és 𝐿 egy nyelv.**
  - Ha 𝐿 ∈ 𝐶, akkor ez 𝐿 eldöntésének bonyolultságára felső korlátot ad.
  - Ha 𝐿 „magában hordja” az összes 𝐿′ ∈ 𝐶 eldöntésének bonyolultságát:
    - Az 𝐿 nyelv 𝐶-nehéz, ha:
      - ∀𝐿′ ∈ 𝐶 esetén 𝐿′ ≺ 𝐿.
    - Ha 𝐿 𝐶-nehéz, akkor ez 𝐿 eldöntésének bonyolultságára alsó korlátot ad.
    - Az 𝐿 nyelv 𝐶-teljes, ha 𝐿 ∈ 𝐶 és 𝐿 𝐶-nehéz.
      - Eldöntésének bonyolultsága pontosan 𝐶.

### Több 𝐶-teljes Nyelv Keresése

- **Ha találunk egy 𝐶-teljes nyelvet, hogyan kereshetünk több 𝐶-teljes nyelvet?**
  - Ha:
    - 𝐿_1 𝐶-teljes → 𝐿_2 𝐶-nehéz → 𝐿_2 𝐶-teljes
    - 𝐿_1 ≺ 𝐿_2 → 𝐿_2 𝐶-nehéz → 𝐿_2 𝐶-teljes
    - 𝐿_2 ∈ 𝐶 → 𝐿_2 𝐶-teljes

### Példa: 𝐍𝐏-teljes Nyelvek

- **Találni kell egy 𝐍𝐏-teljes nyelvet (pl. SAT).**
  - Egy 𝐿 nyelv 𝐍𝐏-teljessége belátható:
    - 𝐿 ∈ 𝐍𝐏 ???: Tanú-tétel segítségével
    - 𝑆𝐴𝑇 ≺ 𝐿 ???: Visszavezetés konstruálásával

### Központi Kérdés a Számításelméletben

- **Ha egy 𝐍𝐏-teljes nyelvről sikerülne belátni, hogy 𝐏-ben van:**
  - 𝐏 = 𝐍𝐏
  - Ez a számításelmélet központi kérdése!


10. dia:

### Példa 𝐍𝐏-teljes nyelvekre: Hamilton-kör probléma

Van a gráfnak olyan köre, mely minden csúcsot pontosan egyszer érint?

---

### Példa 𝐍𝐏-teljes nyelvekre: Utazóügynök probléma

Adottak városok, ill. költségek a városok közti utakhoz rendelve. Melyik a legolcsóbb körút, mely minden várost pontosan egyszer érint?

#### Naív algoritmus időbonyolultsága
- \(𝑂(n!)\)

#### Létezik ilyen determinisztikus algoritmus
- \(𝑂(n^2 2^n)\)

#### Létezik polinom időbonyolultságú determinisztikus algoritmus?
- Egyelőre nem ismert.

---

### Példa 𝐍𝐏-teljes nyelvekre: Hátizsák probléma

Adott kapacitású hátizsákba hogyan pakoljuk a lehető legnagyobb értékű cuccot?

---

### 𝐍𝐏-teljes Nyelv Találása

#### Találni kell egy 𝐍𝐏-teljes nyelvet (pl. 𝑆𝐴𝑇).

Egy 𝐿 nyelv 𝐍𝐏-teljessége belátható:
- 𝐿∈𝐍𝐏 ???: Tanú-tétel segítségével
- 𝑆𝐴𝑇≺𝐿 ???: Visszavezetés konstruálásával

---

### 𝑆𝐴𝑇: A kielégíthető Boole-formulák nyelve

#### Boole-formula építőelemei:
- Ítéletváltozók: \(𝑥_1,𝑥_2,\dots\)
- Logikai operátorok: negáció, konjunkció, diszjunkció

#### Példa formula
- kielégíthető?
\[
(𝑥_1 \vee 𝑥_3) \wedge (\neg 𝑥_2 \vee (𝑥_3 \wedge \neg 𝑥_1) \vee \neg 𝑥_3)
\]

---

### 𝑆𝐴𝑇∈𝐍𝐏
- Könnyű bizonyítani a Tanú-tétellel.
- A tanú a Boole-formula változóinak egy kiértékelése.

### 𝑆𝐴𝑇 𝐍𝐏-nehéz
- Nehéz bizonyítani.
- Bármely nemdeterminisztikus, polinom időkorlátos Turing-gép működését felírhatjuk egy (hatalmas) Boole-formula alakjában.

#### Szükséges ítéletváltozók:
- \(𝐶_{𝑖,𝑗}^𝜎\): Az \(𝑖\). lépésben a \(𝑗\). cellában \(𝜎\) van.
- \(𝐹_{𝑖,𝑗}\): Az \(𝑖\). lépésben a \(𝑗\). cellán áll a fej.
- \(𝑄_𝑖^𝑞\): Az \(𝑖\). lépésben a \(𝑞\) állapotban van.
- Minden \(𝜎 ∈ Σ, 𝑞 ∈ 𝑄\) és \(𝑖,𝑗 = 0, \dots, 𝑛^𝑑\) esetén.

#### Turing-gép működésének leírása, pl.:
- Kezdetben \(𝑞_0\) állapotban van: \(𝑄_0^{𝑞_0}\)
- Kezdetben a fej a 0. pozícióban van: \(𝐹_{0,0}\)
- A szalag kezdeti tartalma pl. 0100 input esetén:
  \[
  𝐶_{0,0}^{⊳} ∧ 𝐶_{0,1}^{0} ∧ 𝐶_{0,2}^{1} ∧ 𝐶_{0,3}^{0} ∧ 𝐶_{0,4}^{0} ∧ 𝐶_{0,5}^{⊔} ∧ \dots ∧ 𝐶_{0,𝑛^𝑑}^{⊔}
  \]

---

### Konjunktív normálforma (KNF)

\[
(𝑥_1 \vee 𝑥_3) \wedge (\neg 𝑥_2 \vee 𝑥_3 \vee 𝑥_1 \vee \neg 𝑥_4) \wedge (\neg 𝑥_1 \vee 𝑥_4)
\]

### 3-KNF

Minden klóz 3-elemű:
\[
(𝑥_1 \vee 𝑥_3 \vee 𝑥_3) \wedge (\neg 𝑥_2 \vee 𝑥_3 \vee \neg 𝑥_4) \wedge (\neg 𝑥_1 \vee 𝑥_4 \vee 𝑥_2)
\]

### 3−𝑆𝐴𝑇

Kielégíthető 3-KNF-ben levő Boole-formulák nyelve.
- Minden Boole-formula átírható 3-KNF-re.
- Ezért van a 𝑆𝐴𝑇-nak visszavezetése 3−𝑆𝐴𝑇-ra:
  \[
  𝑆𝐴𝑇 ≺ 3−𝑆𝐴𝑇
  \]
- Ezért 3−𝑆𝐴𝑇 egy 𝐍𝐏-nehéz nyelv.
- Mivel 3−𝑆𝐴𝑇 ∈ 𝐍𝐏 is teljesül, így 3−𝑆𝐴𝑇 𝐍𝐏-teljes.

---

### 3 színnel színezhető gráfok nyelve

Korábban beláttuk, hogy 3−𝑆𝑍𝐼𝑁 ∈ 𝐍𝐏

#### Vajon 𝐍𝐏-nehéz is?
- Ha igen, akkor 3−𝑆𝑍𝐼𝑁 𝐍𝐏-teljes.
- Bármely 𝜙 3−𝐾𝑁𝐹 Boole formulához meg lehet adni egy 𝐺 gráfot úgy, hogy:
  \[
  𝜙 ∈ 3−𝑆𝐴𝑇 \Leftrightarrow 𝐺 ∈ 3−𝑆𝑍𝐼𝑁
  \]
- Ezért:
  \[
  3−𝑆𝐴𝑇 ≺ 3−𝑆𝑍𝐼𝑁
  \]

---

### További 𝐍𝐏-teljes nyelvek

- Hamilton-kört tartalmazó gráfok nyelve
- Utazóügynök-probléma
- Maximális klikk probléma gráfokban
- Maximális független csúcshalmaz keresése gráfokban
- Minimális/maximális feszítőfa keresése gráfokban
- Sávszélesség maximalizálásának problémája
- Számok faktorizációja, azaz szorzótényezőkre bontása




11. dia:

### Példa 𝐍𝐋-teljes nyelvekre: Elérhetőség gráfokban

**Kérdés:** Létezik-e út két adott csúcs között?

- Nemdeterminisztikusan bejárjuk a gráfot az egyik csúcsból indulva.
- Elég csak az aktuális csúcsot (annak sorszámát) tárolni.
- A sorszámot 2-es, 3-as, … vagy 10-es, stb. számként ábrázoljuk.
- Logaritmikus számkódolás: \(\log n\)

### Példa 𝐍𝐋-teljes nyelvekre: 2−𝑆𝐴𝑇

**Kérdés:** A \((𝑙_1 \vee 𝑙_2)\) klózokból álló KNF kielégíthető-e?

- Alacsonyabb bonyolultság, mint 3−𝑆𝐴𝑇 és 𝑆𝐴𝑇 esetén (𝐍𝐏-teljes).

### Példa 𝐏-teljes nyelvekre: Hálózat-kiértékelés

**Kérdés:** Logikai áramkör outputja 0 vagy 1-e?

- Logikai kapuk: pl. AND, OR, NOT, XOR.
- Adott input bitek esetén.

### Példa 𝐏-teljes nyelvekre: Lineáris programozás

**Optimalizációs probléma:**

- Feltételek, mint lineáris egyenlőtlenségek: \(𝐴𝐱≤𝐛\)
- Célfüggvényt maximalizálni: \(\max: 𝐜^𝑇 𝐱\)
- …ahol \(𝐱≥0\).

**Ismert algoritmus:** szimplex módszer.

### Példa 𝐏𝐒𝐏𝐀𝐂𝐄-teljes nyelvekre: 𝑄𝐵𝐅

**Kérdés:** \(𝑆𝐴𝑇\) probléma kvantorokkal.

\[
∃𝑥_1∀𝑥_2 ((𝑥_1 \vee 𝑥_2 )∧(¬𝑥_1 \vee 𝑥_2 ))
\]

- Nagyobb bonyolultságú, mint a \(𝑆𝐴𝑇\) (𝐍𝐏-teljes).

### Példa 𝐏𝐒𝐏𝐀𝐂𝐄-teljes nyelvekre

- **Reversi/Othello**
- **Mahjong solitaire**

### Példa 𝐄𝐗𝐏𝐓𝐈𝐌𝐄-teljes nyelvekre

- **Sakk**
- **Go**

---
