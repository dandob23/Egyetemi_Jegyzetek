Itt található a PowerPoint prezentáció alapján készült felsorolásos jegyzet:

### Algoritmusok bonyolultsága

**Előadó: Kovásznai Gergely, Eszterházy Károly Egyetem**

#### Bonyolultságelmélet (Complexity Theory)

- **Algoritmusok bonyolultsága**
  - Időbonyolultság: elemi lépések száma
  - Tárbonyolultság: memóriaigény

- **Legrosszabb eset ("Worst-case complexity")**
  - Keresési algoritmusok időbonyolultsága:
    - Lineáris keresés: legrosszabb esetben \(O(n)\)
    - Bináris keresés: legrosszabb esetben \(O(\log n)\)

#### "Ordó" jelölés

- \(O\) jelölés: függvény növekedésének mértékét jelöli
- Bonyolultsági függvények:
  - Logaritmikus: \(O(\log n)\)
  - Lineáris: \(O(n)\)
  - Polinomiális: \(O(n^k)\)
  - Négyzetes: \(O(n^2)\)
  - Köbös: \(O(n^3)\)
  - Exponenciális: \(O(2^n)\)
  - Faktoriális: \(O(n!)\)
  - Dupla exponenciális: \(O(2^{2^n})\)

#### Rendezési algoritmusok időbonyolultsága

- **Probléma**: Rendezni egy \(n\) elemű tömböt növekvő sorrendbe.
- Elemi lépések: összehasonlítások és elemcserék

- **Algoritmusok**:
  - Buborék rendezés (Bubble Sort):
    - Időbonyolultság: \(O(n^2)\)
  - Beszúrásos rendezés (Insertion Sort):
    - Lineáris kereséssel: \(O(n^2)\)
    - Bináris kereséssel: \(O(n \log n)\)
  - Összefésüléses rendezés (Merge Sort):
    - Időbonyolultság: \(O(n \log n)\)

#### Gráfok

- Gráf: \(G = (V, E)\)
  - \(V\): csúcsok (vertices) halmaza
  - \(E\): élek (edges) halmaza
  - Élekhez költség (\(c\)): \(c: E \rightarrow \mathbb{R}\)

- **Elérhetőség problémája**:
  - Mélységi keresés (DFS)
  - Szélességi keresés (BFS)
  - Dijsktra algoritmus: legolcsóbb út egy csúcsból az összes többibe
  - Floyd-Warshall algoritmus: bármely két csúcs között

#### Hamilton-kör probléma

- Több mint 100 éve tanulmányozzák
- "Naív" algoritmus: csúcsok permutációja kör-e?
- Időbonyolultság: \(O(n!)\)
- Polinomiális algoritmus keresése

#### Gráfszínezési probléma

- Gráf színezése: csúcsok beszínezése úgy, hogy szomszédos csúcsok különböző színűek legyenek.
- Nem ismert polinomiális algoritmus

### Közlekedési lámpák

- Konfliktusok ábrázolása gráffal:
  - Csúcsok: lámpák
  - Élek: konfliktusos kapcsolatok

Ez a jegyzet segíthet a számításelmélet vizsgára való felkészüléshez, különös tekintettel az algoritmusok bonyolultságára és a hozzá kapcsolódó témakörökre.