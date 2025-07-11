### **9. Paraméteres felületek leírása, megjelenítése, Coons-felület és tenzori szorzat felületek**

---

## **1. Paraméteres felületek**

### **Definíció**:
- A **paraméteres felület** egy matematikailag leírt felület, amelyet két paraméter ($u$ és $v$) definiál egy 3D térben.
- **Matematikai megadás**:

$$\mathbf{S}(u, v) = (x(u, v), y(u, v), z(u, v)),$$

ahol $u, v$ a felület paraméterei, és $x, y, z$ a felület egy-egy pontjának koordinátái a térben.

### **Fontos tulajdonságok**:
1. **Paramétertartomány**:
   - A felületet a $u$- és $v$-értékek tartománya határozza meg (pl. $u \in [0, 1], v \in [0, 1]$).
2. **Sima átmenet**:
   - A paraméterek folytonos változása folyamatos átmenetet eredményez a felületen.
3. **Kontrollált generálás**:
   - A felület formája a paraméterfüggvények (pl. polinomok, trigonometrikus függvények) alapján alakítható.

---

### **Példa: Gömb paraméteres megadása*:

$$\mathbf{S}(u, v) = (r \cos(u) \sin(v), r \sin(u) \sin(v), r \cos(v)),$$

ahol:
- $u \in [0, 2\pi]$: hosszúsági szög,
- $v \in [0, \pi]$: szélességi szög.

---

## **2. Paraméteres felületek megjelenítése**

### **Pontok kiszámítása**:
- A paraméterek ($u, v$) rácspontjait használjuk a felület pontjainak kiszámítására.
- Például oszd fel a $[0, 1]$-t $n$ lépésre mindkét paraméter irányában, majd minden rácspontnál számítsd ki a $\mathbf{S}(u, v)$ koordinátákat.

### **Háló (grid) rajzolása**:
- Az így kapott pontokból 3D rácshálót rajzolunk.
- **Példa**: Egyenes vonalakkal összekapcsoljuk az egymást követő rácspontokat.

### **Felület renderelése**:
- A rácspontokból háromszögeket (vagy négyszögeket) generálunk, amelyeket kitöltünk (shading technikák használatával, pl. Phong-árnyékolás).

---

## **3. Coons-felület**

### **Definíció**:
- A Coons-felület egy paraméteres felület, amely négy **határoló görbéből** interpolál.
- **Határoló görbék**:
  - Két függőleges ($u$-irányú): $\mathbf{C}_0(v), \mathbf{C}_1(v)$,
  - Két vízszintes ($v$-irányú): $\mathbf{D}_0(u), \mathbf{D}_1(u)$.

### **Matematikai megadás**:
- A Coons-felület pontjait az alábbi módon számítjuk:
  
$$\mathbf{S}(u, v) = (1-v)\mathbf{D}_0(u) + v\mathbf{D}_1(u) + (1-u)\mathbf{C}_0(v) + u\mathbf{C}_1(v) - \mathbf{B}(u, v),$$

ahol $\mathbf{B}(u, v)$ a négy sarokpont interpolációjából adódó bilineáris korrekció:

$$\mathbf{B}(u, v)=(1-u)(1-v)\mathbf{P}_{00}+u(1-v)\mathbf{P}_{10}+(1-u)v\mathbf{P}_{01}+uv\mathbf{P}_{11}$$

- $\mathbf{P}_{ij}$: a négy sarokpont ($i, j \in \{0, 1\}$).

### **Tulajdonságok**:
1. A felület pontosan illeszkedik a négy határoló görbéhez.
2. Sima átmeneteket biztosít a határoló görbék között.
3. Egyszerűen implementálható és gyorsan számítható.

---

## **4. Tenzori szorzat felületek**

### **Definíció**:
- A tenzori szorzat felületek a **spline görbék** általánosításai 2D felületekre.
- Az $u$- és $v$-irányú spline görbék szorzataként definiálhatók.

### **Matematikai megadás**:
- Egy $m \times n$ kontrollpontból álló rácsháló alapján:
  
$$\mathbf{S}(u, v) = \sum_{i=0}^m \sum_{j=0}^n N_i^k(u) N_j^l(v) \mathbf{P}_{ij},$$

ahol:
- $N_i^k(u)$: az $i$-edik $k$-adik fokú bázisfüggvény $u$-irányban,
- $N_j^l(v)$: a $j$-edik $l$-edik fokú bázisfüggvény $v$-irányban,
- $\mathbf{P}_{ij}$: a kontrollpontok.

### **Példa: B-Spline felület**:
- A B-Spline görbe bázisfüggvényeit alkalmazzuk $u$- és $v$-irányban.

---

## **5. Coons-felület vs. Tenzori szorzat felület**

| **Tulajdonság**            | **Coons-felület**                                                | **Tenzori szorzat felület**                                     |
|----------------------------|-----------------------------------------------------------------|---------------------------------------------------------------|
| **Határoló adatok**         | Négy határoló görbé és sarokpontok                             | Kontrollpontok rácshálója                                     |
| **Interpoláció**            | Határoló görbéken interpolál                                   | Kontrollpontokon közelít vagy interpolál                      |
| **Bonyolultság**            | Egyszerűbb, gyorsabban számítható                             | Komplexebb, nagyobb rugalmasság                               |
| **Fő alkalmazás**           | Határolt felületek gyors generálása                           | Rugalmas felületi modellezés CAD és animációk terén           |

---

## **6. Alkalmazások**

### **Coons-felületek**:
- Zárt felületek gyors interpolálása.
- Műszaki rajzok és egyszerű modellezési feladatok.

### **Tenzori szorzat felületek**:
- **B-Spline felületek**:
  - CAD rendszerekben felületek pontos modellezésére.
  - Animációkban deformálható felületek létrehozására.
- **NURBS felületek**:
  - Szabálytalan alakzatok nagy pontosságú modellezésére.

---

### **Összefoglaló táblázat**

| **Fogalom**                  | **Definíció és alkalmazás**                                                                                     |
|------------------------------|---------------------------------------------------------------------------------------------------------------|
| **Paraméteres felület**       | $\mathbf{S}(u, v) = (x(u, v), y(u, v), z(u, v))$: Pontok $u, v$ paraméterek alapján definiáltak.               |
| **Coons-felület**             | Négy határoló görbé interpolációjából generált felület.                                                        |
| **Tenzori szorzat felület**   | Kontrollpont-rácsból generált felület spline bázisfüggvényekkel.                                               |
| **B-Spline felület**          | Tenzori szorzat felület B-Spline bázisfüggvényekkel; rugalmas és precíz.                                       |
| **Felület megjelenítése**     | Rácspontok és háló generálása, renderelése árnyékolással.                                                     |

---

Ha szeretnél konkrét példát egy paraméteres felület kiszámítására, vagy további részleteket bármelyik fogalomról, szólj bátran! 😊
