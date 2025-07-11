### **4. Görbék megadási módjai, paraméteres görbék rajzolása, illeszkedési problémák**

---

## **1. Görbék megadási módjai**

A görbék különböző módokon írhatók le matematikailag és grafikailag, attól függően, hogy milyen feladatot oldanak meg. Az alábbiakban áttekintjük a leggyakoribb módszereket.

### **1.1 Explicit megadás**
- **Egyenlet**: $y = f(x)$
- **Jellemzői**:
  - Az $y$ értéke közvetlenül számítható $x$-ből.
  - Egyszerű és könnyen kiszámítható.
- **Korlátai**:
  - Nem tudja leírni az olyan görbéket, ahol több $y$ érték tartozik egy $x$-hez (pl. körök, zárt görbék).
- **Példa**: Egyenes egyenlete $y = mx + c$.

### **1.2 Implicit megadás**
- **Egyenlet**: $f(x, y) = 0$
- **Jellemzői**:
  - A görbét az $x$ és $y$ közötti kapcsolat határozza meg.
  - Bonyolultabb számításokat igényel.
- **Példa**: Kör egyenlete $x^2 + y^2 - r^2 = 0$.

### **1.3 Paraméteres megadás**
- **Egyenletek**: 
  - $x = x(t)$
  - $y = y(t)$
  - (3D-ben $z = z(t)$)
- **Jellemzői**:
  - Egy paraméter ($t$) segítségével mind az $x$, mind az $y$ koordináták meghatározhatók.
  - Ideális komplex görbék (pl. spirálok, zárt görbék) leírására.
- **Példa**: Kör paraméteres formája:
  
$$x(t) = r \cos(t), \quad y(t) = r \sin(t), \quad t \in [0, 2\pi]$$
---

## **2. Paraméteres görbék rajzolása 2D-ben és 3D-ben**

A paraméteres görbék rajzolása több lépésből áll, a dimenziók függvényében.

---

### **2.1 2D-ben (kétdimenziós térben)**

#### **Lépések**:
1. **Görbe egyenleteinek megadása**:
   - Példa: $x(t) = \cos(t), \, y(t) = \sin(t)$ (egységkör).
2. **Paramétertartomány kiválasztása**:
   - Pl. $t \in [0, 2\pi]$.
3. **Példapontok számítása**:
   - A $t$-t kis lépésekben növelve ($\Delta t$), minden pont $x(t), y(t)$ koordinátáját kiszámítjuk.
4. **Pontok összekötése**:
   - Az így kapott pontokat grafikusan összekötjük.

#### **Alkalmazások**:
- Körök, ellipszisek, spirálok és más síkbeli görbék rajzolása.

---

### **2.2 3D-ben (háromdimenziós térben)**

#### **Lépések**:
1. **Görbe egyenleteinek megadása**:
   - Példa: Spirál $x(t) = r \cos(t), \, y(t) = r \sin(t), \, z(t) = kt$.
2. **Paramétertartomány kiválasztása**:
   - Pl. $t \in [0, 10]$ (egy spirálhurokhoz).
3. **Példapontok számítása**:
   - Számítsd ki minden pontot $x(t), y(t), z(t)$ .
4. **Pontok megjelenítése**:
   - Használj 3D-s grafikai rendszert (pl. OpenGL, WebGL, Blender), hogy a pontokat térben jelenítsd meg.

#### **Alkalmazások**:
- Csavarvonalak, spirálok, mozgáspályák szimulálása.

---

## **3. Illeszkedési problémák**

Az illeszkedési problémák arra keresnek megoldást, hogy hogyan **rajzolunk meg egy görbét** úgy, hogy az egy adott **ponthalmazhoz illeszkedjen**.

---

### **3.1 Interpoláció**
- A görbe **pontosan átmegy** az összes megadott ponton.
- **Példa**: Polinominterpoláció.
  - Ha $n$ pont adott, akkor egy $n-1$-ed fokú polinomot lehet illeszteni:
    
    $$P(x) = a_0 + a_1x + a_2x^2 + \dots + a_{n-1}x^{n-1}.$$
    
- **Hátrány**:
  - Magasabb fokú polinomok esetén "oszcillációs" problémák léphetnek fel (Runge-jelenség).

---

### **3.2 Közelítő illesztés**
- A görbe **közelíti** a megadott pontokat, de nem feltétlenül halad át mindegyiken.
- **Példa**:
  - **Legkisebb négyzetek módszere**:
    - Az eltérések négyzetösszegét minimalizálja:
      
      $\min \sum_{i=1}^n \left( y_i - f(x_i) \right)^2$.
      
- **Előny**:
  - Stabilabb, mint az interpoláció magasabb számú pont esetén.

---

### **3.3 Görbék típusai illeszkedési problémákban**

#### **Bezier-görbék**:
- Egy adott kontrollpont-készlet alapján rajzolódik.
- A görbe sosem tér el a kontrollpontok konvex burkán kívülre.
- **Görbe egyenlete**:
  
  $$P(t) = \sum_{i=0}^n B_i^n(t) P_i$$
  
  ahol $B_i^n(t)$ a Bernstein-polinom.

#### **B-spline görbék**:
- Egyesíti az egyszerűség és rugalmasság előnyeit.
- Lokális kontrollt biztosít: egy pont mozgatása csak a görbe közeli részeit változtatja.

#### **Hermite-görbék**:
- A pontokon kívül azok **érintővektorait** is figyelembe veszi.
- **Használat**: Simább görbék előállításához.

#### **NURBS (Non-Uniform Rational B-Splines)**:
- Rendkívül rugalmas, súlyokat is alkalmaz a pontok befolyásolására.
- **Felhasználás**: CAD rendszerek, animációk.

---

### **Összefoglaló**

| **Feladat**                 | **Technika**                | **Példa**                                 |
|-----------------------------|-----------------------------|------------------------------------------|
| Görbék megadása              | Paraméteres, explicit, implicit | Kör ($x = r\cos(t), y = r\sin(t)$)      |
| 2D és 3D rajzolás            | Paraméteres formák          | Kör, spirál, parabola                    |
| Illeszkedés pontokra         | Interpoláció, közelítés     | Polinom, Bezier-görbe                   |

Van kérdésed, vagy lépjünk a következő témára? 😊
