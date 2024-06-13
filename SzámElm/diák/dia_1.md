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
