### Algoritmusok bonyolultságának mérése, bonyolultságok típusai. Bonyolultsági függvények, ordó jelölés. Keresési és rendezési algoritmusok, gráfalgoritmusok bonyolultsága.

#### 1. Algoritmusok bonyolultsága

**Időbonyolultság**: Az algoritmus végrehajtásához szükséges elemi lépések száma.  
**Tárbonyolultság**: Az algoritmus memóriaigénye.

#### 2. Bonyolultságelmélet

- **Minden lehetséges inputra?**
- **És ha végtelen sok input létezik?**
- **Legrosszabb esetre** ("Worst-case complexity")
- **Elemi lépés**: pl. összehasonlítás
- \( n \) adatelemre = \( n \) hosszúságú inputra

#### 3. Keresési algoritmusok időbonyolultsága

- **Lineáris keresés**:  
  - Legrosszabb esetben: \( n \) összehasonlítás  
  - Időbonyolultság: \( O(n) \)  

- **Bináris keresés**:  
  - Legrosszabb esetben: \( \lceil \log_2 (n+1) \rceil \) összehasonlítás  
  - Időbonyolultság: \( O(\log_2 (n)) \)  

#### 4. Ordó jelölés

\( O(f) \): \( f \) függvény növekedésének mértékét jelöli  

Adottak \( f \), \( g \): \( \mathbb{N} \mapsto \mathbb{N} \) függvények.  
\( f(n) = O(g(n)) \), ha  
\( \exists c > 0 \) és \( \exists n_0 > 0 \), hogy  
\( \forall n \ge n_0 \) esetén \( f(n) \le c \cdot g(n) \)

#### 5. Bonyolultsági függvények típusai

- **Logaritmikus**: \( O(\log_c(n)) \)  
- **Lineáris**: \( O(n) \)  
- **Polinomiális**: \( O(n^k) \)  
- **Négyzetes**: \( O(n^2) \)  
- **Köbös**: \( O(n^3) \)  
- **Exponenciális**: \( O(c^n) \)  
- **Faktoriális**: \( O(n!) \)  
- **Dupla exponenciális**: \( O(c^{(d^n)}) \)

#### 6. Rendezési algoritmusok időbonyolultsága

**Probléma**: Rendezzük egy \( n \) elemű tömb elemeit (növekvő) sorrendbe!

- **Elemi lépések**:
  - Összehasonlítások
  - Elemcserék

**Vizsgált algoritmusok**:
- **Buborék rendezés**
  - Kód:
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
  - **Időbonyolultság**: \( O(n^2) \)

- **Beszúrásos rendezés**
  - Kód:
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
    - **Időbonyolultság**: \( O(n^2) \)
  - **Bináris kereséssel**:
    - **Összehasonlítások száma**: legrosszabb esetben \( n \cdot \lceil \log_2 n \rceil \)
    - **Elemcserék száma**: legrosszabb esetben \( \frac{n \cdot (n-1)}{2} \)
    - **Időbonyolultság**: \( O(n^2) \)

- **Összefésüléses rendezés**
  - Kód:
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
  - **Időbonyolultság**: \( O(n \cdot \log_2 n) \)

**Rendezési algoritmusok összefoglalása**:
- Buborék rendezés: \( O(n^2) \)
- Beszúrásos rendezés (lineáris és bináris kereséssel): \( O(n^2) \)
- Összefésüléses rendezés: \( O(n \cdot \log_2 n) \)

#### 7. Gráfok és gráfalgoritmusok

**Definíció**: \( \langle V, E \rangle \)
- \( V \): csúcsok (vertices) halmaza, \( V \ne \emptyset \)
- \( E \): élek (edges) halmaza, \( E \subseteq V \times V \)

**Élekhez költség**: \( c: E \mapsto \mathbb{N}^{(+)} \)
- \( c(v, w) \), ahol \( (v, w) \in E \)

**Út**: \( v_1, v_2, \ldots, v_k \in V \)
- \( \forall i = 1, \ldots, k-1 \) esetén \( (v_i, v_{i+1}) \in E \)
- **Költsége**: \( \sum_{i=1}^{k-1} c(v_i, v_{i+1}) \)

**Elérhetőség problémája**
- **Van-e út két adott csúcs között?**
  - Mélységi keresés (DFS)
  - Szélességi keresés (BFS)

**Melyik a legolcsóbb út?**
- Két adott csúcs között?
- Egy adott csúcsból az összes többibe? (Dijkstra algoritmus)
- Bármely két csúcs között? (Floyd-Warshall algoritmus)

**Hamilton-kör probléma**
- Több mint 100 éve tanulmányozzák
- "Naív" algoritmus: csúcsok permutációja kör-e?
- **Időbonyolultság**: \( O(n!) \)
- **Van-e polinomiális algoritmus?**

#### 8. Közlekedési lámpák és gráfszínezési probléma

**Közlekedési lámpák konfliktuslehetőségei**:
- Tiltott
- Nem tiltott

**Gráffal ábrázolás**:
- Csúcsok: \( ac, ad, bc, bd, ec, ed \)
- Élek: két lámpa konfliktusos kapcsolata

**Gráfszínezési probléma**:
- A csúcsokat beszínezzük
- Ha két csúcs között él van, akkor azok színei különbözőek legyenek!
- **Nem ismert polinomiális algoritmus!**

Ez a vázlat tartalmazza az első tételhez szükséges információkat, és segít átlátni a bonyolultságok mérésének és a különböző algoritmusok idő- és tárbonyolultságának alapjait.

