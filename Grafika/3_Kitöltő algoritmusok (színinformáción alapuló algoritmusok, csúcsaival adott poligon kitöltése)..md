### **3. Kitöltő algoritmusok**

A kitöltő algoritmusok célja az, hogy egy poligon vagy egy másik zárt alakzat belsejét kitöltsék egy adott színnel vagy mintázattal. A kitöltés lehet:

- **Színinformáción alapuló**, ha egy már meglévő színtől függ.
- **Geometriai**, ha egy poligon csúcsaiból számítják ki az alakzat belsejét.

---

## **1. Színinformáción alapuló algoritmusok**

Ezek az algoritmusok egy adott referencia-szín alapján határozzák meg, hogy mely pixeleket kell kitölteni.

### **Flood Fill (árasztásos kitöltés)**

#### **Célja**:
- Egy pontból indulva minden szomszédos pixelt kitölt egy adott színnel, amíg el nem ér egy határt (pl. más színű pixeleket).

#### **Típusai**:
1. **Szomszédsági viszony alapján**:
   - **4-szomszédos**: Csak a közvetlenül szomszédos (fent, lent, balra, jobbra) pixeleket tölti ki.
   - **8-szomszédos**: A közvetlen és az átlós szomszédokat is kitölti.

2. **Módszer alapján**:
   - **Rekurzív**:
     - A kezdőpontból kiindulva rekurzióval (önmagát hívó függvényekkel) tölti ki a szomszédos pixeleket.
     - **Hátrány**: Nagy képeknél a mély rekurzió miatt túlcsordulhat a memóriában (stack overflow).
   - **Iteratív**:
     - Verem (stack) vagy sor (queue) adatstruktúrát használ, hogy elkerülje a rekurzió mélységének problémáit.

#### **Lépések**:
1. Indulj egy kezdőpontból ($x, y$).
2. Ellenőrizd, hogy a pont színe megegyezik-e a referencia-színnel (amit ki kell tölteni).
3. Ha igen, színezd át a pontot a kitöltő színre.
4. Lépj tovább a szomszédos pixelekre, és ismételd meg az eljárást.

---

### **Boundary Fill (határkitöltés)**

#### **Célja**:
- Egy kezdőponttól indulva minden szomszédos pixelt kitölt egy adott színnel, **amíg el nem éri a határ színét**.

#### **Működés**:
- Hasonló a Flood Fill-hez, de itt nem egy referencia-színt keresünk, hanem megállunk egy előre meghatározott határszínnél.

#### **Lépések**:
1. Indulj egy kezdőpontból ($x, y$).
2. Ha a pixel színe nem a határszín és nem a kitöltő szín, színezd át.
3. Haladj tovább a szomszédos pixelekre (4- vagy 8-szomszédosság szerint).

---

## **2. Csúcsaival adott poligon kitöltése (Scanline Fill)**

A **Scanline Fill** algoritmus a poligon geometriáján alapul, nem pedig egy referencia-színen. Ez az algoritmus különösen hatékony csúcsaival adott poligonok kitöltésére.

#### **Alapötlet**:
- Vízszintes vonalakkal (szkenelési vonalakkal) járjuk be a poligont.
- Minden egyes szkenelési vonalnál meghatározzuk, hol lép be és hol lép ki a vonal a poligon belsejéből.
- A vonalak közötti pixeleket kitöltjük.

#### **Lépések**:
1. **Élek feldolgozása**:
   - Minden poligonélt szakaszokra bontunk.
   - Kiszámítjuk, mely vízszintes vonalak metszik az egyes éleket (edge table).
2. **Aktív éllista (Active Edge List, AEL)**:
   - Egy lista, amely tartalmazza az éppen aktuális szkenelési vonalat metsző éleket.
   - Az élek mentén a belépési és kilépési pontokat frissítjük.
3. **Pixelek kitöltése**:
   - Az aktuális szkenelési vonal belső szakaszait kitöltjük.
   - A következő szkenelési vonalra lépve frissítjük az AEL-t.

#### **Előnyök**:
- Geometriai alapú, így pontos és gyors.
- Egyenesen kezel bármilyen konvex vagy konkáv poligont (kivéve önátmetsző poligonokat).

---

### **Összehasonlítás a két megközelítés között**

| **Tulajdonság**           | **Színinformáción alapuló algoritmusok** | **Geometriai kitöltés (Scanline)**       |
|----------------------------|------------------------------------------|------------------------------------------|
| **Alkalmazási terület**    | Általános képek, színezés               | Poligonok, vektoros ábrák                |
| **Példák**                | Flood Fill, Boundary Fill               | Scanline Fill                            |
| **Hatékonyság**            | Lassabb komplex alakzatoknál            | Gyors és pontos                          |
| **Geometriai adatok igénye** | Nem szükséges                          | Poligon csúcsai és élei szükségesek      |

---

### **Gyakorlati példa a Scanline Fill algoritmusra**:
1. Adott egy háromszög csúcsai:
   - $A(2, 2)$, $B(6, 10)$, $C(8, 2)$.
2. **Éltáblázat készítése**:
   - Az $AB$, $BC$, és $CA$ élek metszési pontjait számítjuk ki a szkenelési vonalakkal.
3. **Aktív éllista frissítése**:
   - Az $AB$ és $CA$ élek aktívak a $y = 2$-től a $y = 10$-ig terjedő vonalaknál.
4. **Kitöltés**:
   - Az $x$-értékek közötti pixeleket kitöltjük minden sorban.

---

### **Összefoglaló**

- A **Flood Fill** és a **Boundary Fill** egyszerű és színalapú, de nem geometriai pontosságú algoritmusok.
- A **Scanline Fill** hatékony geometriai algoritmus poligonok kitöltésére.
- A választás az adott alkalmazás igényeitől függ: ha csúcsok adottak, geometriai kitöltés a jobb választás; színalapú problémáknál a Flood vagy Boundary Fill az optimális.