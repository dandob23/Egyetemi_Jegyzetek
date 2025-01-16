### **1. Szakasz vágása téglalapra: Cohen-Sutherland algoritmus**

#### **Célja**:
- Egy szakaszt (pl. egy vonalat) **levágni** úgy, hogy csak a megadott téglalap (ablak) belsejében lévő része maradjon meg.

#### **Működési elve**:
- A szakasz két végpontjához bináris **kódszavakat** rendel, amelyek meghatározzák, hogy a pont az ablakon **belül vagy kívül** helyezkedik el.
- A kódok alapján dönt arról, hogy:
  1. A szakasz teljesen **belül** van (nincs vágás).
  2. A szakasz teljesen **kívül** van (eldobható).
  3. A szakasz **metszi** az ablakot (vágni kell).

#### **Régiókódok**:
- A képernyő (ablak) 9 régióra oszlik:
  - Középen az ablak ($0000$ kód).
  - Fölötte, alatt, jobbra és balra régiók külön kódokkal.
- A régiókódot 4 bit határozza meg:
  - **1. bit (fölötte)**: Ha a pont az ablak fölött van.
  - **2. bit (alatta)**: Ha a pont az ablak alatt van.
  - **3. bit (balra)**: Ha a pont az ablak bal oldalán van.
  - **4. bit (jobbra)**: Ha a pont az ablak jobb oldalán van.

#### **Algoritmus lépései**:
1. **Kódolás**: A szakasz kezdő- és végpontjának kiszámítjuk a régiókódját.
2. **Gyors ellenőrzés**:
   - Ha mindkét pont kódja $0000$, a szakasz teljesen belül van (nincs vágás).
   - Ha a két kód **logikai ÉS-e** nem nulla ($\neq 0$), a szakasz teljesen kívül van (eldobható).
3. **Metszés**:
   - Ha egyik gyorsellenőrzés sem érvényes, vágni kell.
   - A vágás kezdődik a szakasz azon végpontjával, amely az ablakon kívül van.
   - A régiókód alapján kiszámítjuk a szakasz metszéspontját az ablak szélével.
   - A metszéspont új végpontként szolgál.
4. **Ismétlés**: A folyamatot addig ismételjük, amíg a szakasz teljesen belülre kerül, vagy teljesen eldobhatóvá válik.

#### **Előnyök**:
- Egyszerű és hatékony 2D térben.
- Csak akkor számol metszéspontokat, ha szükséges.

---

### **2. Szakasz vágása konvex poligonra**

#### **Konvex poligon jellemzői**:
- Egy poligon konvex, ha bármely két pontját összekötő szakasz teljes egészében a poligon belsejében van.
- Példa: hatszög, háromszög, négyzet.

#### **Algoritmus (Sutherland-Hodgman poligon vágás)**:
- Alapvetően poligonra tervezték, de működik szakasz vágására is.
- A poligon éleit használja **vágósíkokként**.
  
1. **Bemenet**: Egy szakasz és egy konvex poligon élei.
2. **Metszéspontok**:
   - A szakasz pontjait (végpontjait) egyenként ellenőrzi az élekhez képest.
   - Ha egy pont a poligonon kívül van, kiszámítja a metszéspontot az éllel.
3. **Pontok frissítése**:
   - Csak azokat a pontokat tartja meg, amelyek a poligon belsejében vannak, vagy metszéspontok.
4. **Eredmény**:
   - Az algoritmus végén megkapjuk a szakasz azon részét, amely a poligon belsejében található.

#### **Előnyök**:
- Könnyen általánosítható több élű konvex poligonokra.
- Hatékony, mivel lineáris a poligon éleinek számában.

---

### **3. Szakasz vágása konkáv poligonra**

#### **Kihívás a konkáv poligonokkal**:
- A konkáv poligonoknál egy szakasz **több részre** is vágható, mert a poligon belseje nem folyamatos.
- Példa: Csillag alak, L-alak.

#### **Algoritmusok**:
1. **Több lépéses megközelítés**:
   - **Trianguláció**: A konkáv poligont felbontják **konvex részekre** (háromszögekre).
   - Ezután minden részen alkalmazzák a konvex poligon vágó algoritmust.
2. **Weiler-Atherton algoritmus**:
   - Speciálisan konkáv poligonokhoz készült.
   - Külön kezeli a poligon belső és külső pontjait.
   - Metszéspontokat számol, majd nyomon követi a belső/külső átmeneteket.

#### **Lépések (általánosan)**:
1. **Metszéspontok keresése**:
   - A szakasz és a poligon minden élét vizsgálja.
   - Kiszámítja a metszéspontokat, ahol a szakasz belép vagy kilép a poligonból.
2. **Részek kiválasztása**:
   - Csak a szakasz belső (poligonon belüli) részeit tartja meg.
   - Ha a szakasz több részre bomlik, mindegyik belső rész külön kezelhető.

---

### **Összefoglaló**
| **Feladat**                  | **Algoritmus neve**          | **Alkalmazási terület**                                |
|------------------------------|-----------------------------|------------------------------------------------------|
| Szakasz vágása téglalapra     | Cohen-Sutherland           | Egyszerű ablakos vágás 2D-ben.                       |
| Szakasz vágása konvex poligonra | Sutherland-Hodgman         | Hatékony konvex poligonokhoz.                        |
| Szakasz vágása konkáv poligonra | Trianguláció, Weiler-Atherton | Több részből álló konkáv poligonoknál alkalmazható. |

---

Kérlek jelezd, ha további pontosításokra vagy kiegészítésekre van szükség! 😊