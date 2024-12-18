### **6. Bézier-görbe, De Casteljau-algoritmus, Bernstein-polinomok**

A Bézier-görbék alapvető fontosságúak a számítógépi grafikában, különösen a vektoros grafikák, animációk és modellezés területén. Az alábbiakban részletesen bemutatjuk őket.

---

## **1. Bézier-görbe**

### **Definíció**:
- A Bézier-görbe egy paraméteres görbe, amelyet **kontrollpontok** definiálnak. A görbe alakját ezek a pontok és a hozzájuk tartozó **Bernstein-polinomok** határozzák meg.
- **Görbe egyenlete**:
  
$$B(t) = \sum_{i=0}^n B_i^n(t) P_i, \quad t \in [0, 1]$$

ahol:
- $P_i$: Kontrollpontok ($i = 0, 1, \dots, n$),
- $B_i^n(t)$: Bernstein-polinomok,
- $t$: Paraméter (0 és 1 között mozog, a görbén való helyzetet határozza meg).

---

## **2. Bernstein-polinomok**

### **Definíció**:
- A Bernstein-polinomok olyan súlyfüggvények, amelyek meghatározzák, hogy a Bézier-görbe adott $t$ értékénél mennyire befolyásolja a görbét egy adott kontrollpont.

### **Bernstein-polinom képlete**:

$$B_i^n(t) = \binom{n}{i} t^i (1 - t)^{n-i}$$

ahol:
- $n$: A görbe fokszáma (kontrollpontok száma - 1),
- $i$: Az aktuális kontrollpont indexe,
- $\binom{n}{i}$: Binomiális együttható:
  
$$\binom{n}{i} = \frac{n!}{i!(n-i)!}$$

### **Tulajdonságok**:
1. **Nem-negativitás**: $B_i^n(t) \geq 0$, minden $t$ és $i$ esetén.
2. **Összegük 1**: A polinomok összege mindig 1:
   
$$\sum_{i=0}^n B_i^n(t) = 1$$

3. **Lokális kontroll**: Az egyes kontrollpontok csak a saját Bernstein-polinomjukon keresztül hatnak a görbére.

---

## **3. De Casteljau-algoritmus**

### **Cél**:
- A Bézier-görbe pontjainak **iteratív** számítása $t$-hez tartozóan, anélkül, hogy explicit Bernstein-polinomokat használnánk.

### **Működés**:
1. **Bemenet**:
   - Kontrollpontok: $P_0, P_1, \dots, P_n$,
   - Paraméter: $t \in [0, 1]$.
2. **Iterációk**:
   - Minden lépésben egy új pontkészletet generálunk, a kontrollpontok interpolációjával:
     
$$P_{i,j} = (1 - t)P_{i,j-1} + tP_{i+1,j-1}, \quad (i = 0, \dots, n-j)$$

   - Itt $P_{i,j}$ az $i$-edik pont a $j$-edik iterációban.
3. **Végső pont**:
   - Az utolsó iterációban kapott egyetlen pont a Bézier-görbe azon pontja, amely a $t$ paraméterhez tartozik.

### **Előnyök**:
- Egyszerű, numerikusan stabil algoritmus.
- Nem igényli a Bernstein-polinomok explicit számítását.

---

## **4. Bézier-görbék tulajdonságai**

### **Általános tulajdonságok**:
1. **Kontrollpontok konvex burka**:
   - A Bézier-görbe mindig a kontrollpontok konvex burkán belül helyezkedik el.
2. **Kezdő- és végpont**:
   - A görbe pontosan a kontrollpontok első ($P_0$) és utolsó ($P_n$) pontján halad át.
3. **Érintők a végpontoknál**:
   - A görbe érintője a $t = 0$ és $t = 1$ pontoknál a kontrollpontok első és utolsó szegmensének irányába mutat.
4. **Szimmetria**:
   - Ha a kontrollpontok sorrendjét megfordítjuk, ugyanazt a görbét kapjuk.
5. **Részgörbék**:
   - A görbe bármely része új Bézier-görbeként kezelhető (a De Casteljau-algoritmussal meghatározható).

### **Előnyök**:
- Egyszerű implementáció.
- Kiváló sima görbék rajzolására.
- Lokális kontroll: egy kontrollpont módosítása csak a görbe egy részére van hatással.

---

## **5. Bézier-görbék típusai**

### **Lineáris Bézier-görbe**:
- Két kontrollpont ($P_0, P_1$).
- Egy egyenes szakaszt ad:
  
$$B(t) = (1 - t)P_0 + tP_1$$

### **Kvadratikus Bézier-görbe**:
- Három kontrollpont ($P_0, P_1, P_2$).
- Egy parabolaív jön létre:
  
$$B(t) = (1 - t)^2P_0 + 2t(1 - t)P_1 + t^2P_2$$

### **Kubikus Bézier-görbe**:
- Négy kontrollpont ($P_0, P_1, P_2, P_3$).
- A legismertebb típus, grafikában gyakran használt
  
$$B(t) = (1 - t)^3P_0 + 3t(1 - t)^2P_1 + 3t^2(1 - t)P_2 + t^3P_3$$

---

## **6. Bézier-görbék felhasználása**

- **Vektoros grafikák**: Illustrator, Inkscape.
- **Animációk**: Mozgás- és pályatervezés.
- **Betűtípusok**: TrueType és PostScript fontok.
- **CAD rendszerek**: Precíz geometriai modellezés.

---

### **Összefoglaló táblázat**

| **Fogalom**               | **Magyarázat**                                                                                     |
|---------------------------|---------------------------------------------------------------------------------------------------|
| **Bézier-görbe**           | Kontrollpontok alapján meghatározott paraméteres görbe.                                           |
| **Bernstein-polinomok**    | A Bézier-görbék alapfüggvényei, súlyozzák a kontrollpontokat.                                     |
| **De Casteljau-algoritmus** | Iteratív módszer a Bézier-görbe pontjainak kiszámítására $t$-hez tartozóan.                     |
| **Tulajdonságok**          | Konvex burkon belüli elhelyezkedés, érintők a végpontoknál, szimmetria, lokális kontroll.         |

---

Van kérdésed, vagy folytassuk a következő témával? 😊
