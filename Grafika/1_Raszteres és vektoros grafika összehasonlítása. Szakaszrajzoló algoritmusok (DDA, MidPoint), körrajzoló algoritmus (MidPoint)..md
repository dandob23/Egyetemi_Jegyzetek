Rendben, a jegyzetek matematikai egyenleteit mostantól $ jelek közé vagy $$ jelek közé írom, hogy markdown formátumban helyesen jelenjenek meg. Itt van az első tétel frissített változata:

---

### **1. Raszteres és vektoros grafika összehasonlítása**

#### **Raszteres grafika**
- **Definíció**: A kép egy képpontok (pixelek) rácsából áll.
- **Tárolás**: Minden pixel színértéke tárolva van (pl. RGB).
- **Előnyök**:
  - Kiváló fotórealisztikus képekhez (pl. fényképek).
  - Könnyen szerkeszthető (pl. Photoshop).
- **Hátrányok**:
  - Méretnöveléskor romlik a minőség (pixelesedik).
  - Nagy fájlméret részletes képeknél.
- **Felhasználás**: Fényképek, webes grafikák, játékok textúrái.
- **Formátumok**: PNG, JPEG, BMP, GIF.

#### **Vektoros grafika**
- **Definíció**: A képet matematikai objektumok (pl. vonalak, görbék, sokszögek) határozzák meg.
- **Tárolás**: A formák matematikai leírása van eltárolva (koordináták, paraméterek).
- **Előnyök**:
  - Méretezhető minőségromlás nélkül.
  - Kis fájlméret komplex geometriai formák esetén.
- **Hátrányok**:
  - Nem ideális részletgazdag, fotórealisztikus képekhez.
  - Több számítási erőforrást igényel rendereléskor.
- **Felhasználás**: Logók, ikonok, térképek, illusztrációk.
- **Formátumok**: SVG, AI, EPS, PDF.

#### **Összehasonlítás táblázatosan**

| **Jellemző**           | **Raszteres grafika**                     | **Vektoros grafika**                  |
|-------------------------|-------------------------------------------|---------------------------------------|
| **Tárolási forma**      | Pixelek                                   | Matematikai objektumok               |
| **Méretezés**           | Minőségromlás (pixelesedés)               | Minőségromlás nélkül                 |
| **Fájlméret**           | Nagy komplex képeknél                     | Kis méret geometriai formáknál       |
| **Alkalmazás**          | Fényképek, textúrák                       | Logók, illusztrációk, térképek       |

---

### **2. Szakaszrajzoló algoritmusok**

#### **DDA (Digital Differential Analyzer) algoritmus**
- **Működés**:
  - A vonal egyenletét $y = mx + b$ használja, és lépésenként kiszámítja a következő pontot.
  - Lépésenként egyenlő távolságokat tesz a tengelyeken.
- **Előnyök**:
  - Könnyen implementálható.
  - Jó pontosságú.
- **Hátrányok**:
  - Lassabb, mivel lebegőpontos műveleteket végez.
- **Lépések**:
  1. Számold ki a vonal meredekségét $m = \frac{\Delta y}{\Delta x}$.
  2. Indulj ki az első pontból, és haladj végig az $x$ vagy $y$ irányban kis lépésekben.
  3. Rajzolj minden kiszámított pontnál.

#### **MidPoint szakaszrajzoló algoritmus**
- **Működés**:
  - Egész számokat használ, hogy hatékonyabban számolja ki a pixelek helyzetét.
  - A középponti (MidPoint) döntési kritériumot alkalmazza, hogy eldöntse, melyik pixel legyen a következő.
- **Előnyök**:
  - Gyorsabb, mint a DDA, mivel nincs lebegőpontos számítás.
  - Egész értékekkel dolgozik.
- **Lépések**:
  1. Kezdd a kezdőponttal.
  2. Számold ki a döntési változót ($d$), ami meghatározza, hogy a vonal következő pontja az alsó vagy a felső pixel legyen.
  3. Frissítsd $d$-t minden lépésnél, a döntés alapján.

---

### **3. Körrajzoló algoritmus (MidPoint)**

- **Működés**:
  - Használja a kör egyenletét $x^2 + y^2 = r^2$ és a középponti döntési kritériumot.
  - Szimmetriát alkalmaz, hogy csak a kör egy nyolcadát számolja ki, majd tükrözéssel rajzolja meg a többit.
- **Lépések**:
  1. Indulj a kör felső középponti pontjától ($x = 0, y = r$).
  2. Számold ki a kezdő döntési változót: $d = 1 - r$.
  3. Minden iterációnál:
     - Ha $d < 0$: Maradj a kör peremén ($x+1, y$).
     - Ha $d \geq 0$: Lépj átlós irányba ($x+1, y-1$).
  4. Frissítsd a döntési változót ($d$) a választás alapján.
  5. Tükrözd az aktuális pontot a kör 8 szimmetria-tengelye mentén.

---

Van további kérdésed ezekkel kapcsolatban, vagy menjünk tovább a következő tételre? 😊