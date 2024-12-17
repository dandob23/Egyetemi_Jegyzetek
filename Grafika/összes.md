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


---


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

---


### **5. Hermite-ív, görbék csatlakozása és folytonosság**

A Hermite-ívek és általánosságban a görbék csatlakoztatása fontos szerepet játszik a számítógépi grafikában, mivel sima átmeneteket kell biztosítani különböző görbék között. Az alábbiakban részletesen kifejtjük a Hermite-ívek alapjait, tulajdonságait és a folytonossági fogalmakat.

---

## **1. Hermite-ív**

### **Definíció**:
A Hermite-ív egy olyan paraméteres görbe, amely két végpontjának pozícióját **és azok érintővektorait** használja a görbe meghatározásához.

### **Matematikai megadás**:
A Hermite-görbe paraméteres formában:


$$P(t) = h_1(t)P_0 + h_2(t)P_1 + h_3(t)T_0 + h_4(t)T_1$$


ahol:
- $P_0$: Kezdőpont,
- $P_1$: Végpont,
- $T_0$: Kezdő érintővektor,
- $T_1$: Vég érintővektor,
- $t \in [0, 1]$: Paraméter a görbe mentén.

### **Hermite-alapfüggvények** $h_1(t), h_2(t), h_3(t), h_4(t)$ :
Az alapfüggvények meghatározzák a görbe alakját:

$$h_1(t) = 2t^3 - 3t^2 + 1, \quad h_2(t) = -2t^3 + 3t^2$$

$$h_3(t) = t^3 - 2t^2 + t, \quad h_4(t) = t^3 - t^2$$

- $h_1(t)$ és $h_2(t)$: A végpontokhoz tartozó súlyfüggvények.
- $h_3(t)$ és $h_4(t)$: Az érintővektorokhoz tartozó súlyfüggvények.

### **Tulajdonságai**:
1. **Lokalitás**: Az egyes végpontok és érintővektorok csak a görbe egy részét befolyásolják.
2. **Rugalmasság**: A végpontok és érintővektorok szabadon állíthatók, így a görbe könnyen alakítható.
3. **Kontrollálhatóság**: Az érintővektorok hosszának és irányának módosítása megváltoztatja a görbe görbületét.

---

## **2. Görbék csatlakozása és folytonosság**

Amikor két görbét csatlakoztatunk, a folytonosság különböző szintjeit kell biztosítani a sima átmenet érdekében. A folytonosságot három szinten vizsgáljuk:

### **2.1 Geometriai folytonosság ($G^n$)**
- A görbék csatlakozása geometriailag sima.
- Példa:
  - $G^0$: A görbék végpontjai egybeesnek.
  - $G^1$: A végpontok érintővektorai azonos irányúak, de nem feltétlenül egyenlő hosszúak.
  - $G^2$: Az érintővektorok irányai és a görbületi sugarak is egyeznek.

### **2.2 Paraméteres folytonosság ($C^n$)**
- A görbék csatlakozása matematikailag folytonos.
- Példa:
  - $C^0$: A végpontok folytonosan érintkeznek ($P_0 = P_1$).
  - $C^1$: Az érintővektorok azonosak ($T_0 = T_1$).
  - $C^2$: A görbületi sugár is megegyezik a csatlakozási pontban.

#### **Különbség $G^n$ és $C^n$ között**:
- $G^n$: Csak az alakra vonatkozik, nem figyeli a paraméterezést.
- $C^n$: A pontos matematikai paraméterek egyezését is megköveteli.

---

## **3. Hermite-ívek csatlakoztatása**

### **Cél**:
A Hermite-ívek összekapcsolása olyan módon, hogy a folytonosságot biztosítsuk.

### **Lépések**:
1. **Pozíció folytonosság ($C^0$)**:
   - Az első Hermite-ív végpontja ($P_1$) azonos legyen a második Hermite-ív kezdőpontjával ($P_2$).
2. **Érintő folytonosság ($C^1$)**:
   - Az első Hermite-ív végérintője ($T_1$) azonos legyen a második Hermite-ív kezdőérintőjével ($T_2$).
3. **Görbületi folytonosság ($C^2$)** (opcionális):
   - Az érintővektor változási sebessége is legyen folytonos.

### **Gyakorlati példák**:
1. **Simulációban**:
   - Egy autó mozgáspályájának sima megtervezése.
2. **Animációban**:
   - Karakterek mozgásának folyamatos átmenete két mozgás között.

---

## **4. Hermite-ívek előnyei**

- **Egyszerűség**: Könnyen definiálhatók a végpontok és érintővektorok segítségével.
- **Kontrollálhatóság**: A görbe alakja közvetlenül változtatható az érintővektorok módosításával.
- **Folytonosság biztosítása**: Könnyen csatlakoztathatók más Hermite-ívekhez, miközben $C^0$, $C^1$ és akár $C^2$ folytonosságot is biztosítanak.

---

### **Összefoglaló táblázat**

| **Fogalom**                     | **Magyarázat**                                                                                   |
|---------------------------------|-----------------------------------------------------------------------------------------------|
| **Hermite-ív**                  | Paraméteres görbe, melyet végpontok és érintővektorok definiálnak.                              |
| **Geometriai folytonosság ($G^n$)** | A görbék kapcsolódása vizuálisan sima, de nem feltétlenül matematikailag pontos.               |
| **Paraméteres folytonosság ($C^n$)** | Matematikailag pontos kapcsolódás, figyelembe veszi az érintőket és görbületi változásokat.   |
| **Csatlakozás**                 | Hermite-ívek végpontjainak és érintővektorainak összehangolása folytonosság biztosításához.     |

---

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
### **7. Spline görbék és B-Spline görbék**

A spline görbék és különösen a B-Spline görbék fontos szerepet játszanak a számítógépi grafikában és geometriai modellezésben, mivel sima és rugalmas görbék definiálására alkalmasak.

---

## **1. Spline görbék koncepciója**

### **Spline görbe**:
- Egy olyan **összetett görbe**, amelyet több kisebb görbe (szakasz) egymáshoz kapcsolásával hozunk létre.
- A görbe szakaszai folytonosan csatlakoznak, és sima átmenetet biztosítanak.
- **Alkalmazás**: Sima pályák, görbült felületek és modellek létrehozása.

### **Fontos jellemzők**:
1. **Folytonosság**:
   - $C^n$: Az $n$-ed rendű deriváltak folytonossága a szakaszok között.
   - **Példa**: $C^2$-folytonosság a görbület simaságát garantálja.
2. **Kontrollálhatóság**:
   - A spline alakját kontrollpontok határozzák meg.
3. **Rugalmasság**:
   - Egyszerre követhető egy meghatározott pálya és érhető el sima átmenet.

### **Típusai**:
- **Interpoláló spline**: Áthalad a megadott pontokon.
- **Közelítő spline**: Nem feltétlenül halad át a pontokon, hanem közelíti azokat.

---

## **2. B-Spline görbe**

A **B-Spline** (Basis Spline) görbe egy speciális spline típus, amely hatékonyan kezeli a simaságot és a kontrollpontok befolyását.

### **B-Spline görbe definíciója**:
- A görbe egy paraméteres formában adott:
  
$$C(t) = \sum_{i=0}^n N_{i,k}(t) P_i$$

ahol:
- $P_i$: Kontrollpontok,
- $N_{i,k}(t)$: $k$-adik fokú **bázisfüggvények** (Basis functions),
- $t$: Paraméter ($t_{\min} \leq t \leq t_{\max}$).

### **Bázisfüggvények**:
- A bázisfüggvények rekurzív definícióval adhatók meg:
  - $k = 1$ (lineáris):
    
$$N_{i,1}(t) =\begin{cases} 1, & t_i \leq t < t_{i+1}, \\ 0, & \text{egyébként}.\end{cases}$$

  - $k > 1$:
    
$$N_{i,k}(t) = \frac{t - t_i}{t_{i+k-1} - t_i} N_{i,k-1}(t) + \frac{t_{i+k} - t}{t_{i+k} - t_{i+1}} N_{i+1,k-1}(t)$$

### **Csomópontvektor** ($t_i$):
- A csomópontvektor határozza meg, hogy a paraméter $t$ hogyan oszlik el a görbe mentén.
- **Típusai**:
  - **Egyenletes**: Az értékek egyenlő távolságra vannak.
  - **Nem egyenletes**: Az értékek közötti távolság változó.

---

## **3. Zárt és végpontokat interpoláló B-Spline görbe**

### **Zárt B-Spline görbe**:
- Az első és utolsó kontrollpont egyezik, így a görbe folyamatos, ciklikus alakot vesz fel.
- **Használat**: Hurok vagy gyűrű alakzatok rajzolásához.

### **Végpontokat interpoláló B-Spline görbe**:
- A görbe pontosan áthalad az első és az utolsó kontrollponton.
- **Hogyan érjük el?**
  - A csomópontvektor úgy módosítható, hogy a kontrollpontok súlya maximalizálódjon a végpontoknál.

---

## **4. A B-Spline görbe tulajdonságai**

### **Általános tulajdonságok**:
1. **Lokális kontroll**:
   - Egy kontrollpont csak a közeli görberészt befolyásolja ($k+1$ szakaszra van hatása).
2. **Sima átmenet**:
   - Az alapértelmezett $C^{k-1}$-folytonosság biztosítja a sima görbét.
3. **Kontrollpontok konvex burka**:
   - A görbe mindig a kontrollpontok konvex burkán belül marad.
4. **Skálázhatóság**:
   - Könnyen növelhető vagy csökkenthető a kontrollpontok száma.
5. **Csomópontvektor szerepe**:
   - Az egyenletes csomópontvektor egyenletes mozgást eredményez a görbén.
   - A nem egyenletes csomópontvektorral változtatható a görbe sűrűsége bizonyos helyeken.

### **Előnyök**:
- Nagyon sima és rugalmas görbék létrehozása.
- Hatékonyan kezeli a nagy számú kontrollpontot.
- Kiterjeszthető **NURBS** (Non-Uniform Rational B-Splines) görbékre, amelyek még nagyobb rugalmasságot nyújtanak.

---

### **Összefoglaló táblázat**

| **Fogalom**                         | **Magyarázat**                                                                                       |
|-------------------------------------|-----------------------------------------------------------------------------------------------------|
| **Spline görbe**                    | Sima görbe, több szakaszból áll, amelyeket kontrollpontokkal definiálnak.                            |
| **B-Spline görbe**                  | Speciális spline görbe, amely bázisfüggvényekkel és kontrollpontokkal van meghatározva.               |
| **Csomópontvektor**                 | Meghatározza a görbe paramétereloszlását. Egyenletes vagy nem egyenletes lehet.                      |
| **Zárt B-Spline görbe**             | A görbe ciklikus, az első és az utolsó kontrollpont megegyezik.                                      |
| **Végpontokat interpoláló B-Spline**| A görbe az első és utolsó kontrollponton áthalad.                                                   |
| **Tulajdonságok**                   | Lokális kontroll, konvex burkon belüli elhelyezkedés, $C^{k-1}$-folytonosság, skálázhatóság.         |

---
### **8. Vektorok, mátrixok, homogén koordináták és vetítések**

Az alábbiakban összefoglalom a vektorok és mátrixok alapjait, a homogén koordináták szerepét, valamint a transzformációkat és vetítéseket.

---

## **1. Vektorok és mátrixok**

### **1.1 Vektorok**
- Egy **vektor** egy irányított szakasz, amelynek van **irányítottsága** és **hossza**.
- **Definíció**:
  
$$\mathbf{v} = (x, y) \quad \text{(2D)}, \quad \mathbf{v} = (x, y, z) \quad \text{(3D)}$$

- **Műveletek**:
  1. **Összeadás**:
     
$$\mathbf{v} + \mathbf{u} = (v_x + u_x, v_y + u_y, v_z + u_z)$$

  2. **Skalárral szorzás**:

$$k \cdot \mathbf{v} = (k v_x, k v_y, k v_z)$$

  4. **Skaláris szorzat**:

$$\mathbf{v} \cdot \mathbf{u} = v_x u_x + v_y u_y + v_z u_z$$

  5. **Vektoriális szorzat** (3D-ben):

$$\mathbf{v} \times \mathbf{u} = \begin{vmatrix}\mathbf{i} & \mathbf{j} & \mathbf{k} \\ v_x & v_y & v_z \\ u_x & u_y & u_z \end{vmatrix}$$

### **1.2 Mátrixok**
- Egy **mátrix** egy számtábla, amely sorokból és oszlopokból áll. 
- **Definíció**:
  
$$A = \begin{bmatrix}a_{11} & a_{12} & \dots & a_{1n} \\ a_{21} & a_{22} & \dots & a_{2n} \\ \vdots & \vdots & \ddots & \vdots \\ a_{m1} & a_{m2} & \dots & a_{mn} \end{bmatrix}$$

- **Műveletek**:
  1. **Mátrix-vektor szorzás**:
     
$$\mathbf{A} \cdot \mathbf{v} = \begin{bmatrix}a_{11} & a_{12} & a_{13} \\ a_{21} & a_{22} & a_{23} \\ a_{31} & a_{32} & a_{33} \end{bmatrix} \begin{bmatrix} v_x \\ v_y \\ v_z \end{bmatrix} = \begin{bmatrix} a_{11}v_x + a_{12}v_y + a_{13}v_z \\ a_{21}v_x + a_{22}v_y + a_{23}v_z \\ a_{31}v_x + a_{32}v_y + a_{33}v_z \end{bmatrix}$$

---

## **2. Homogén koordináták**

### **Motiváció**:
- A homogén koordináták a transzformációk egységes kezelésére szolgálnak (pl. eltolás, forgatás, nyújtás).
- Hagyományos koordinátákkal az eltolás **nem kezelhető** mátrixművelettel, míg homogén koordinátákban igen.

### **Definíció**:
- Egy $(x, y)$ pont homogén koordinátája $(x, y, w)$, ahol $w \neq 0$.
- A visszavetítés:

$$(x, y, w) \to \left( \frac{x}{w}, \frac{y}{w} \right)$$

### **Homogén transzformációk mátrixa**:
- **Általános forma (3x3 2D-ben)**:

$$\mathbf{T} = \begin{bmatrix} a & b & tx \\ c & d & ty \\ 0 & 0 & 1 \end{bmatrix}$$

---

## **3. Vetítések**

A vetítés a 3D objektumok leképezése 2D síkra. Két fő típus:

### **3.1 Párhuzamos vetítés**
- Az objektumot párhuzamos vetítési sugarakkal vetítjük a síkra.
- **Ortografikus vetítés**:
  - A vetítés iránya merőleges a képsíkra.
  - **Példa**: Műszaki rajzok.
- **Axonometrikus vetítés**:
  - Nem feltétlenül merőleges, de a térbeli arányokat megtartja (pl. izometrikus vetítés).

### **3.2 Centrális (perspektivikus) vetítés**
- A vetítési sugarak egy közös pontból (a vetítési középpontból) indulnak ki.
- **Vetítési mátrix**:
  
$$P = \begin{bmatrix} 1 & 0 & 0 & 0 \\ 0 & 1 & 0 & 0 \\ 0 & 0 & 1 & 0 \\ 0 & 0 & \frac{1}{d} & 0 \end{bmatrix}$$

Ahol $d$ a vetítési távolság.

---

## **4. Ponttranszformációk**

### **4.1 Egybevágósági transzformációk**
- Megtartják az alakzat formáját és méretét.
- **Példák**:
  - **Eltolás**:
    
$$ \mathbf{T} = \begin{bmatrix} 1 & 0 & tx \\ 0 & 1 & ty \\ 0 & 0 & 1 \end{bmatrix}$$

  - **Forgatás** (2D-ben):

$$ \mathbf{R} = \begin{bmatrix} \cos\theta & -\sin\theta & 0 \\ \sin\theta & \cos\theta & 0 \\ 0 & 0 & 1 \end{bmatrix}$$

### **4.2 Hasonlósági transzformációk**
- Megtartják az arányokat, de méretezhetnek.
- **Példa**: Nyújtás (méretezés):

$$\mathbf{S} = \begin{bmatrix} sx & 0 & 0 \\ 0 & sy & 0 \\ 0 & 0 & 1 \end{bmatrix}$$

### **4.3 Affin transzformációk**
- Általános lineáris transzformációk, amelyek egy pontot a síkon belül másik pontba képeznek.
- **Mátrix**:
  
$$ \mathbf{A} = \begin{bmatrix} a & b & tx \\ c & d & ty \\ 0 & 0 & 1 \end{bmatrix}$$

---

## **5. Window-Viewport transzformáció**

### **Definíció**:
- Egy 2D képet (window) egy másik 2D területre (viewport) vetítünk, például átméretezéshez vagy nagyításhoz.

### **Lépések**:
1. **Window koordináták átváltása normál koordinátákra**:
   
$$ x' = \frac{x - x_\text{min}}{x_\text{max} - x_\text{min}}, \quad y' = \frac{y - y_\text{min}}{y_\text{max} - y_\text{min}}$$

2. **Normál koordináták átváltása viewport koordinátákra**:

$$ x_v = x_v^\text{min} + x'(x_v^\text{max} - x_v^\text{min}), \quad y_v = y_v^\text{min} + y'(y_v^\text{max} - y_v^\text{min})$$

---

### **Összefoglaló táblázat**

| **Fogalom**                      | **Magyarázat**                                                                                 |
|----------------------------------|---------------------------------------------------------------------------------------------|
| **Vektorok és mátrixok**         | Alapvető eszközök a transzformációkhoz (pl. eltolás, forgatás, nyújtás).                      |
| **Homogén koordináták**          | Egységes formát biztosítanak a transzformációk (különösen az eltolás) kezelésére.             |
| **Vetítések**                    | 3D objektumok 2D síkra való leképezése (párhuzamos, centrális).                              |
| **Ponttranszformációk**          | Egybevágósági, hasonlósági, és affin transzformációk különböző tulajdonságokkal.              |
| **Window-Viewport transzformáció**| Egy ablak tartalmának egy másik területre való átméretezése.                                  |

---
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
### **11. Fénysugárkövető algoritmus, fényösszetevők, fényforrások és anyagtulajdonságok**

A fénysugárkövetés (ray tracing) egy alapvető technika a fotorealisztikus számítógépi grafika létrehozásához. Az alábbiakban bemutatom az algoritmust, a fény modellezésének alapjait, a fényforrások típusait és az anyagtulajdonságokat.

---

## **1. Fénysugárkövető algoritmus (Ray Tracing)**

### **Cél**:
- A valósághű árnyékok, tükröződések és áttetszőségek modellezése azáltal, hogy a **fénysugarak útját** követjük a kamera felé.

### **Alapötlet**:
1. **Sugár indítása**:
   - A kamera minden pixeléből elindítunk egy **látósugarat** a 3D térbe.
2. **Objektumok metszése**:
   - Meghatározzuk, hogy a sugár hol metszi az objektumokat.
3. **Fény számítása**:
   - Az adott metszési pontban kiszámítjuk a megvilágítást a **fényforrások**, **tükröződések** és más jellemzők figyelembevételével.
4. **Másodlagos sugarak**:
   - Ha az objektum felülete tükröző, indítunk egy másodlagos sugarat a tükörirányban.
   - Ha áttetsző, számításba vesszük a törést.
5. **Összegzés**:
   - A visszatérő sugarak színét és intenzitását kombináljuk, hogy megkapjuk a végső pixel színét.

---

### **Algoritmus lépései**:
1. **Látósugarak generálása**:
   - A kamera és a képpontok koordinátái alapján kiszámítjuk a sugarak irányát.
2. **Metszéspont számítása**:
   - Minden sugárra meghatározzuk, hogy mely objektumot metszi elsőként (pl. gömb, sík, háromszög).
3. **Fényösszetevők számítása**:
   - Diffúz megvilágítás, tükröződés, árnyékok.
4. **Másodlagos sugarak indítása**:
   - Rekurzív számítás a tükröződésekhez és törésekhez.
5. **Kombinálás**:
   - A különböző sugarakból származó színösszetevőket összeadjuk.

---

### **Előnyök**:
- Fotorealisztikus eredmények (árnyékok, tükröződések, törések pontos megjelenítése).
- Egyszerű matematikai modell, amely jól illeszkedik a valós világ fizikai törvényeihez.

### **Hátrányok**:
- Nagyon számításigényes (nagy számú sugár és másodlagos sugár kezelése).
- Nem ideális valós idejű rendereléshez, bár modern GPU-k javítják a teljesítményt.

---

## **2. Fényösszetevők**

A fény számítása három fő összetevő alapján történik:

### **2.1 Környezeti (ambient) fény**
- Az általános megvilágítást modellezi, amely minden irányból érkezik.
- **Jellemzők**:
  - Állandó érték minden pontra.
  - Nem veszi figyelembe a fényforrások irányát.
- **Képlete**:
  
$$I_a = k_a I_\text{ambient},$$

ahol:
- $k_a$: Anyag környezeti reflexiós együttható,
- $I_\text{ambient}$: Környezeti fény intenzitása.

---

### **2.2 Diffúz (diffuse) fény**
- Az objektum felületének szórt megvilágítása a Lambert-féle törvény szerint.
- **Jellemzők**:
  - A fény intenzitása a felület normálvektorának és a fény irányának szögétől függ.
- **Képlete**:
  
$$I_d = k_d I_\text{light} (\mathbf{N} \cdot \mathbf{L}),$$

ahol:
- $k_d$: Diffúz reflexiós együttható,
- $I_\text{light}$: Fényforrás intenzitása,
- $\mathbf{N}$: Felület normálvektora,
- $\mathbf{L}$: Fény iránya.

---

### **2.3 Tükör (specular) fény**
- Az objektum felületéről visszaverődő fény, amely csillogó hatást kelt.
- **Jellemzők**:
  - Az intenzitás a megfigyelő pozíciójától függ.
- **Képlete**:
  
$$I_s = k_s I_\text{light} (\mathbf{R} \cdot \mathbf{V})^n,$$

ahol:
- $k_s$: Tükör reflexiós együttható,
- $I_\text{light}$: Fényforrás intenzitása,
- $\mathbf{R}$: Visszavert fény iránya,
- $\mathbf{V}$: Megfigyelő iránya,
- $n$: A felület simaságát szabályozó együttható.

---

## **3. Fényforrások**

A fényforrások különböző típusai befolyásolják a megvilágítást:

### **3.1 Pontfényforrás (point light)**
- Egyetlen pontból sugárzik minden irányba.
- **Példa**: Egy izzó lámpa.

---

### **3.2 Irányfény (directional light)**
- A fény párhuzamos sugarakban érkezik egy adott irányból.
- **Példa**: Napfény.

---

### **3.3 Szórt fényforrás (area light)**
- Egy felületről érkezik, így lágy árnyékokat eredményez.
- **Példa**: Világító panel.

---

### **3.4 Spotfény (spotlight)**
- Egy adott irányban és szögben fókuszálja a fényt.
- **Példa**: Színpadi reflektor.

---

## **4. Anyagtulajdonságok**

Az anyagtulajdonságok határozzák meg, hogyan reagál egy objektum a különböző fényösszetevőkre.

### **4.1 Reflexiós együtthatók**
- **Környezeti reflexió ($k_a$)**: Mennyire szórja vissza az anyag a környezeti fényt.
- **Diffúz reflexió ($k_d$)**: Mennyire szórja vissza az anyag a szórt fényt.
- **Tükör reflexió ($k_s$)**: Mennyire csillog az anyag.

---

### **4.2 Törésmutató**
- Meghatározza, hogy a fény hogyan törik az anyagban.
- **Példa**:
  - Vákuum: $n = 1.0$,
  - Üveg: $n = 1.5$,
  - Gyémánt: $n = 2.4$.

---

### **4.3 Szín**
- Az anyag visszavert színét az egyes fényösszetevők színeződése határozza meg.

---

### **4.4 Durvaság**
- A tükörfény szóródásának mértéke (pl. matt vagy fényes felület).

---

## **Összefoglaló táblázat**

| **Fogalom**               | **Lényeg**                                                                 |
|---------------------------|---------------------------------------------------------------------------|
| **Fénysugárkövetés**       | Fénysugarak követése a fotorealisztikus renderelés érdekében.             |
| **Fényösszetevők**         | Környezeti, diffúz és tükörfény.                                         |
| **Fényforrások**           | Pontfény, irányfény, szórt fény, spotfény.                               |
| **Anyagtulajdonságok**     | Reflexiós együtthatók, törésmutató, szín, durvaság.                      |

---
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
