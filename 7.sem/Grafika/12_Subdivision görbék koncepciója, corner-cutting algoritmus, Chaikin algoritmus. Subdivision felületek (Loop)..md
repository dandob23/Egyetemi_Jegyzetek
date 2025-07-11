### **12. Subdivision görbék és felületek**

A subdivision (osztódási) technikák alapvető eszközök a sima görbék és felületek generálásában. Az alábbiakban bemutatom a subdivision görbék alapját, a corner-cutting és Chaikin algoritmust, valamint a subdivision felületek (pl. Loop-algoritmus) koncepcióját.

---

## **1. Subdivision görbék koncepciója**

### **Definíció**:
- A subdivision algoritmusok iteratív módon osztják fel a meglévő kontrollpontokat és generálnak új pontokat, hogy simább görbét hozzanak létre.
- Az eredmény:
  - **Végül a görbe folytonos és sima lesz**.
  - **Limitgörbét** közelít, amely a végtelen iteráció során jönne létre.

### **Lépések**:
1. **Kontrollpontok felosztása**:
   - Új pontokat generálunk az eredeti pontok közé.
2. **Simítás**:
   - Az új és meglévő pontok pozícióját módosítjuk, hogy a görbe simább legyen.
3. **Ismétlés**:
   - Az előző lépéseket többször megismételjük a finomabb eredmény érdekében.

### **Felhasználási területek**:
- **Görbék**: Sima ívek generálása (pl. Chaikin-algoritmus).
- **Felületek**: Sima 3D felületek létrehozása (pl. Loop-algoritmus).

---

## **2. Corner-cutting algoritmusok**

### **Definíció**:
- A corner-cutting algoritmusok az eredeti görbe éleit „levágják” és új pontokat generálnak, hogy a görbe simább legyen.

---

## **3. Chaikin-algoritmus**

### **Definíció**:
- A Chaikin-algoritmus a corner-cutting egy speciális változata, amely iteratívan generál új pontokat az eredeti kontrollpontokból.

### **Működés**:
1. **Kiindulás**:
   - Adott egy kontrollpont-sorozat $\{P_0, P_1, \dots, P_n\}$.
2. **Új pontok generálása**:
   - Minden szomszédos $P_i$ és $P_{i+1}$ pont között két új pontot generálunk:
     - **Első pont**: $(1-q)P_i + qP_{i+1}$,
     - **Második pont**: $qP_i + (1-q)P_{i+1}$,
     - ahol gyakran $q = \frac{1}{4}$, hogy a görbe sima legyen.
3. **Ismétlés**:
   - Az új pontokat új kontrollpontként használjuk a következő iterációban.
4. **Limitgörbe**:
   - A folyamatot többször ismételve a görbe egy sima B-Spline görbéhez tart konvergálni.

### **Tulajdonságok**:
- Egyszerű és gyors algoritmus.
- A görbe mindig a kontrollpontok konvex burkán belül marad.

---

## **4. Subdivision felületek**

### **Definíció**:
- A subdivision felületek a subdivision görbék általánosításai 3D felületekre.
- A felület osztódással és simítással jön létre, hasonlóan a görbékhez.

---

### **4.1 Loop-algoritmus**

#### **Definíció**:
- A Loop-algoritmus egy subdivision technika háromszögekből álló hálók (poligonhálók) simítására.
- **Cél**:
  - Sima felület generálása egy durva háromszöghálóból.

#### **Működés**:
1. **Új csúcsok generálása**:
   - Új pontokat generálunk minden él közepére, az adott él szomszédságában lévő háromszögek figyelembevételével.
   - Új pont ($P_\text{new}$):
     
$$P_\text{new} = \frac{3}{8}(P_1 + P_2) + \frac{1}{8}(P_3 + P_4),$$
    
  ahol $P_1, P_2$ az él végpontjai, $P_3, P_4$ a szomszédos csúcsok.
2. **Eredeti csúcsok simítása**:
   - A meglévő pontok új helyzetét a szomszédos pontok súlyozott átlagával számoljuk ki.
3. **Háromszögek osztása**:
   - Az új és meglévő pontokat használva minden háromszöget négy kisebb háromszögre bontunk.
4. **Ismétlés**:
   - A folyamatot iteratívan ismételjük, amíg a kívánt simaságot elérjük.

#### **Tulajdonságok**:
- A Loop-algoritmus $C^2$-folytonosságot biztosít a felület belsejében (kivéve a határoknál).
- Ideális karakterek és más organikus objektumok modellezésére.

---

## **5. Összehasonlítás: Chaikin vs. Loop-algoritmus**

| **Tulajdonság**             | **Chaikin-algoritmus**                   | **Loop-algoritmus**                          |
|-----------------------------|-----------------------------------------|---------------------------------------------|
| **Alkalmazás**              | 2D görbék simítása                     | 3D háromszöghálók simítása                  |
| **Módszer**                 | Corner-cutting elven alapul            | Háromszögeken iteratív osztás és simítás    |
| **Kimenet**                 | Sima B-Spline görbe                    | Sima háromszögháló, $C^2$-folytonosság    |
| **Felhasználási terület**   | Illusztráció, görbék generálása         | Organikus modellezés, karakterek animációja |

---

### **Összefoglaló táblázat**

| **Fogalom**                    | **Leírás**                                                                                  |
|--------------------------------|--------------------------------------------------------------------------------------------|
| **Subdivision görbék**         | Iteratív eljárások sima görbék generálására.                                                |
| **Corner-cutting algoritmus**  | Görbék simítása az élek „levágásával”.                                                      |
| **Chaikin-algoritmus**         | Két új pont generálása minden él mentén, iteratív simítás.                                  |
| **Subdivision felületek**      | Sima 3D felületek létrehozása iteratív osztás és simítás segítségével.                      |
| **Loop-algoritmus**            | Subdivision technika háromszöghálók simítására, organikus modellezéshez ideális.            |

---

Ha szeretnél részletes példát egy Chaikin- vagy Loop-algoritmus kiszámítására, jelezd bátran! 😊
