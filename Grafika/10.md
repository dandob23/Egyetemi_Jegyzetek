### **10. Poligonhálók, hátsó lapok eltávolítása, árnyalási technikák és Z-buffer algoritmus**

---

## **1. Poligonhálók (B-Rep és Winged Edge)**

A poligonhálók a 3D objektumok modellezésének egyik alapvető struktúrája. A poligonok (sokszögek) általában háromszög vagy négyszög formában vannak definiálva.

---

### **1.1 Boundary Representation (B-Rep)**
- A **B-Rep** (Boundary Representation, határoló reprezentáció) a 3D objektumokat a határfelületeik segítségével definiálja.
- **Felépítés**:
  - **Csúcsok (vertices)**: A poligonok sarkai.
  - **Élek (edges)**: A csúcsok közötti vonalak.
  - **Lapok (faces)**: A poligonok síkbeli határfelületei.
- **Előnyök**:
  - Pontos geometriai leírás komplex modellekhez.
  - Könnyen használható topológiai műveletekhez (pl. boolean műveletek).
- **Hátrányok**:
  - Tárolása és feldolgozása bonyolult nagy modellek esetén.

---

### **1.2 Winged Edge adatstruktúra**
- Egy speciális B-Rep típus, amely hatékonyan kezeli a topológiai műveleteket az élek szomszédságainak nyilvántartásával.
- **Struktúra**:
  - **Élek (edges)**: A fő adatstruktúra, amely tartalmazza az élekhez kapcsolódó információkat:
    - Két végpont (csúcsok),
    - Szomszédos lapok (bal és jobb oldal),
    - Szomszédos élek (mindkét végpontnál).
- **Előnyök**:
  - Gyors keresés szomszédos lapok, élek vagy csúcsok között.
  - Ideális topológiai műveletekhez (pl. felületek összekapcsolása).
- **Hátrányok**:
  - Nagy memóriaigény komplex modellek esetén.

---

## **2. Hátsó lapok eltávolítása**

### **Cél**:
- A hátsó lapok eltávolítása csökkenti a renderelési költségeket azzal, hogy azokat a lapokat, amelyek nem látszanak a kamerából, nem rajzoljuk meg.

### **Algoritmus**:
1. **Normálvektor számítása**:
   - A lap normálvektora:
     
$$\mathbf{N} = (\mathbf{v}_2 - \mathbf{v}_1) \times (\mathbf{v}_3 - \mathbf{v}_1),$$

ahol $\mathbf{v}_1, \mathbf{v}_2, \mathbf{v}_3$ a lap csúcsai.
2. **Nézőirány vektora**:
   - A nézőpontból a lapra mutató vektor:
     
$$\mathbf{V} = \mathbf{C} - \mathbf{P},$$

ahol $\mathbf{C}$ a kamera pozíciója, $\mathbf{P}$ pedig a lap egy pontja.
3. **Szögvizsgálat**:
   - A hátsó lap akkor fordul el a kamerától, ha a normálvektor és a nézőirány vektor skaláris szorzata negatív:

$$\mathbf{N} \cdot \mathbf{V} < 0.$$

---

## **3. Árnyalási technikák**

Az árnyalási technikák határozzák meg, hogyan számítjuk ki a fényt és színeket a poligonok felületén.

---

### **3.1 Flat árnyalás**
- **Lényeg**:
  - Egyetlen színt használ egy poligonhoz.
- **Működés**:
  - A fényt egyetlen pontban (általában a poligon normáljával számolva) számítják ki, és az eredmény minden pontra azonos.
- **Előny**:
  - Gyors és egyszerű.
- **Hátrány**:
  - Durva, lapos megjelenést ad.

---

### **3.2 Gouraud árnyalás**
- **Lényeg**:
  - Az árnyalást a csúcsokban számítjuk ki, és a poligon belsejében interpoláljuk.
- **Működés**:
  1. Számítsuk ki a fényt minden csúcsnál.
  2. Interpoláljuk a színeket a poligonon belül.
- **Előny**:
  - Sima árnyalást biztosít a poligonok között.
- **Hátrány**:
  - Nem kezeli jól a finom fényeffektusokat (pl. csillogás).

---

### **3.3 Phong árnyalás**
- **Lényeg**:
  - Az árnyalást minden képpontnál kiszámítjuk.
- **Működés**:
  1. Interpoláljuk a normálvektorokat a poligonon belül.
  2. Számítsuk ki a fényt minden képpontnál az interpolált normálok alapján.
- **Előny**:
  - Nagyon sima és részletes megjelenést biztosít.
- **Hátrány**:
  - Számításigényes.

---

## **4. Z-buffer algoritmus**

### **Cél**:
- Meghatározza, hogy melyik poligon (vagy képpont) látható, amikor több objektum takarja egymást.

### **Működés**:
1. **Z-buffer inicializálása**:
   - Készíts egy ugyanolyan méretű táblát, mint a képernyő, és állítsd minden elemét $\infty$-re (kezdetben minden távolság végtelen).
2. **Pixelek feldolgozása**:
   - Minden képpontnál számítsd ki a $z$-értéket (mélységet).
   - Ha az aktuális $z$-érték kisebb, mint a Z-bufferben tárolt érték, frissítsd:
$$
Z[x, y] = z.
$$
Ezzel a pixel a legközelebbi lesz.
3. **Színezés**:
   - Csak a legközelebbi pixelek színét rajzoljuk ki.

### **Előnyök**:
- Egyszerű és hatékony.
- Kezeli az átfedéseket és a mélységi sorrendet.

### **Hátrányok**:
- Nagy memóriaigény nagy felbontásnál.
- Átlátszó objektumok kezelése bonyolultabb.

---

### **Összefoglaló táblázat**

| **Fogalom**                   | **Lényeg**                                                                 |
|-------------------------------|---------------------------------------------------------------------------|
| **B-Rep**                     | Határoló reprezentáció csúcsokkal, élekkel, lapokkal.                     |
| **Winged Edge**               | Élek szomszédságának hatékony kezelése a topológiai műveletekhez.          |
| **Hátsó lapok eltávolítása**   | Azok a lapok, amelyek nem látszanak a kamerából, nem kerülnek renderelésre.|
| **Flat árnyalás**              | Egyszerű, de durva árnyalási technika.                                    |
| **Gouraud árnyalás**           | Csúcsszín-interpolációval simább megjelenítést biztosít.                  |
| **Phong árnyalás**             | Pontonkénti számítás, részletes és sima árnyalást ad.                     |
| **Z-buffer algoritmus**        | Mélységi sorrendet kezel, csak a legközelebbi pixelek látszanak.          |

---

Ha szeretnél részletes példát valamelyik fogalomra (pl. árnyalási technikák számítása vagy Z-buffer implementáció), jelezd bátran! 😊
