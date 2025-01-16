# Robotika Ismertető

## A robotikához kapcsolódó alapvető ismeretek

A robotika a gépek és rendszerek tervezésével, építésével, vezérlésével és alkalmazásával foglalkozik. Alapvető ismeretek közé tartozik a mechanika, az elektronika, az informatika és a mesterséges intelligencia alapjai. A robotikában használt rendszerek célja, hogy az embereket helyettesítsék vagy segítsek a monoton, veszélyes vagy nagy pontosságot igénylő feladatok végrehajtásában.

## Elektronikai alapok – digitális elektronika

A digitális elektronika az elektronikai rendszerek azon ága, amely digitális jelek feldolgozásával és tárolásával foglalkozik. Alapvető komponensei közé tartoznak a logikai kapuk (AND, OR, NOT stb.), flip-flopok, regiszterek, számlálók és mikrokontrollerek. A digitális áramkörök működésének alapja a két állapotú (bináris) jelrendszer, ahol az 1 és 0 értékek az áramkör állapotait jelölik.

## Elektronikai mérések eszközei és módszerei

Az elektronikai mérések során használt eszközök és módszerek alapvetőek a fejlesztés és hibakeresés során. Néhány fontos mérőeszköz:
- **Multiméter**: Feszültség, áram, ellenállás mérésére szolgáló eszköz.
- **Oszcilloszkóp**: Elektronikus jelek időbeli változásának megjelenítésére és elemzésére használatos.
- **LCR-mérő**: Induktivitás, kapacitás és ellenállás mérésére szolgáló eszköz.

A mérések során alkalmazott módszerek közé tartozik a különböző jelalakok és paraméterek (pl. amplitúdó, frekvencia) mérése és elemzése.

## Lehetséges vezérlők (LEGO, Arduino, Raspberry Pi)

### LEGO
- **LEGO Mindstorms**: Programozható robotkészletek, amelyek különböző szenzorokkal és motorokkal vannak felszerelve. Ideális oktatási célokra és hobbiprojektekhez.

### Arduino
- **Arduino**: Nyílt forráskódú mikrokontroller platform, amely könnyen használható és széles körben elterjedt. Alkalmas kezdőknek és haladóknak egyaránt.

### Raspberry Pi
- **Raspberry Pi**: Egykártyás számítógép, amely teljes funkcionalitású operációs rendszert futtat. Alkalmas komplexebb projektekhez, mint például a mesterséges intelligencia és a gépi látás.

## Az alkalmazott prototipizáló eszköz megismerése

### Breadboard (forrasztásmentes próbapanel)
- Lehetővé teszi az áramkörök gyors és egyszerű összeállítását forrasztás nélkül. Ideális eszköz a tervezés és tesztelés korai szakaszában.

### PCB (Printed Circuit Board)
- Nyomtatott áramköri lap, amely tartós és megbízható áramkörök építésére szolgál. A tervezést speciális szoftverek segítségével végzik, mint például az Eagle vagy a KiCad.

## A fejlesztés szoftvereszköze

### Integrated Development Environments (IDE)
- **Arduino IDE**: Könnyen használható fejlesztőkörnyezet Arduino projektekhez.
- **VS Code**: Kiterjeszthető, több nyelvet támogató kódszerkesztő.
- **Thonny**: Kezdőknek ajánlott Python IDE.

### Verziókezelő rendszerek
- **Git**: Verziókezelő rendszer, amely lehetővé teszi a kód fejlesztésének nyomon követését és közös munkát.

### Szimulációs eszközök
- **Proteus**: Áramköri szimuláció és PCB tervezés.
- **Tinkercad**: Online szimulációs eszköz Arduino projektekhez.

## Vezérlő szoftverek modellezése, modellek megadási módjai

### Modellezési technikák
- **Állapotgépek (State Machines)**: A rendszer különböző állapotait és az azok közötti átmeneteket írják le.
- **Blokkdiagramok**: A rendszer különböző részeinek és azok közötti kapcsolatoknak a vizuális ábrázolása.
- **UML (Unified Modeling Language)**: Szabványosított modellezési nyelv különböző diagramokkal, például osztálydiagramokkal, állapotdiagramokkal.

### Modellek megadási módjai
- **Grafikus felületek**: Eszközök, mint a Simulink (MATLAB), ahol grafikus felületen lehet modelleket létrehozni.
- **Szöveges leírások**: Leíró nyelvek, mint a VHDL vagy a Verilog digitális áramkörök szimulációjához.
- **Szkriptek**: Programozási nyelveken írt kódok, például Python szkriptek ROS környezetben.

## A hardverfejlesztés hardver- és szoftvereszközei

### Hardvereszközök
- **Mikrokontrollerek és mikroszámítógépek**: Arduino, Raspberry Pi, ESP8266/ESP32.
- **Áramköri tervezés és prototípus készítés**: Breadboard, PCB, 3D nyomtatók, CNC gépek.
- **Mérőeszközök**: Multiméter, oszcilloszkóp, LCR-mérő.

### Szoftvereszközök
- **Áramköri tervező szoftverek**: Eagle, KiCad, Fritzing.
- **Szimulációs szoftverek**: Proteus, LTSpice.
- **IDE-k és programozási eszközök**: Arduino IDE, VS Code, Thonny.

## A vezérlőszoftver fejlesztésének eszközei

### Fejlesztőkörnyezetek (IDEs)
- **Arduino IDE**: Egyszerű környezet Arduino programozásához.
- **Visual Studio Code**: Sokoldalú, kiterjeszthető IDE különböző programozási nyelvekhez.
- **Thonny**: Egyszerű, kezdőknek ajánlott Python IDE.
- **PyCharm**: Kifinomult Python IDE professzionális fejlesztéshez.

### Verziókezelő rendszerek
- **Git**: Verziókezelő rendszer, amely lehetővé teszi a kód fejlesztésének nyomon követését és közös munkát.
- **GitHub**: Online platform Git-alapú projektek kezeléséhez és megosztásához.
- **GitLab**: Hasonló funkcionalitású platform, amely saját szerveren is futtatható.

### Szimulációs és modellező eszközök
- **MATLAB/Simulink**: Fejlett szimulációs és modellezési környezetek mérnöki és tudományos alkalmazásokhoz.
- **Tinkercad**: Online szimulációs eszköz Arduino projektekhez.

### Debuggerek
- **Serial Monitor (Arduino IDE)**: Soros kommunikációs eszköz a program működésének megfigyelésére.
- **gdb**: GNU Debugger, amely széles körben használt eszköz C/C++ programok hibakereséséhez.
- **PyCharm Debugger**: Hatékony hibakereső Python programokhoz.

## Szenzorok és aktuátorok

### Szenzorok
- **Hőmérséklet szenzorok**: LM35, DHT22.
- **Fény szenzorok**: LDR, TSL2561.
- **Hang szenzorok**: Elektret mikrofon.
- **Távolságmérő szenzorok**: Ultrahangos szenzor (HC-SR04), IR távolságmérő.
- **Mozgás szenzorok**: PIR, gyroszkóp és gyorsulásmérő (MPU6050).

### Aktuátorok
- **Motorok**: DC motorok, szervomotorok, léptetőmotorok.
- **LED-ek**: Egyszerű LED, RGB LED.
- **Hangszórók és piezoelektromos elemek**: Piezo buzzer, hangszóró.

## Digitális

 KI- és BEmenetek használata – egyszerűbb vezérlési lehetőségek

### Digitális Bemenetek
- **Érzékelés**: Nyomógombok, kapcsolók, szenzorok.
- **Programozás**: `digitalRead(pin)` függvény az Arduino esetében.

### Digitális Kimenetek
- **Vezérlés**: LED-ek, relék, digitális kijelzők.
- **Programozás**: `digitalWrite(pin, value)` függvény az Arduino esetében.

### Egyszerű vezérlési lehetőségek
- **Nyomógombos vezérlés**: Kapcsolók és nyomógombok beolvasása és LED-ek vezérlése.
- **Alapvető logikai műveletek**: IF-ELSE szerkezetek, hogy reagáljanak a bemeneti jelek változásaira.

## Analóg jelek kezelése

### Analóg Bemenetek
- **Szenzorok**: Potenciométer, fényérzékelők.
- **Programozás**: `analogRead(pin)` függvény az Arduino esetében.

### Analóg Kimenetek
- **PWM (Pulse Width Modulation)**: Analóg jel szimulálása digitális kimeneten.
- **Programozás**: `analogWrite(pin, value)` függvény az Arduino esetében.

### Példák
- **LED fényerejének szabályozása**: Potenciométerrel analóg érték beolvasása és PWM használata LED fényerejének vezérléséhez.
- **Motor sebességének szabályozása**: Hasonlóan a LED vezérléséhez, a motor sebességét PWM segítségével lehet szabályozni.

## Rendszerezés

### Projektek rendszerezése
1. **Dokumentáció**: Minden projekthez kapcsolódó információ (pl. leírás, működési elv, áramköri rajzok) rögzítése.
   - **GitHub/GitLab wiki**: Dokumentáció tárolására és megosztására.

2. **Kód és fájlok szervezése**: Logikus mappa szerkezet kialakítása.
   - **Mappák**: `src` a forráskódoknak, `docs` a dokumentációknak, `tests` a teszteléshez.
   - **Verziókezelés**: Git használata a változások nyomon követésére és a csapatmunkára.

3. **Projektmenedzsment eszközök**: Feladatok nyomon követése és határidők kezelése.
   - **Trello, Asana**: Egyszerű feladatkezelő eszközök.
   - **JIRA**: Fejlettebb projektmenedzsment eszköz nagyobb projektekhez és csapatokhoz.

### Előadás, forráselemzés, hallgatói kutatómunka
1. **Előadás készítése**:
   - **Prezentációkészítő eszközök**: PowerPoint, Google Slides.
   - **Tartalom**: Téma ismertetése, ábrák és diagramok, élő demók.

2. **Forráselemzés**:
   - **Könyvek és tudományos cikkek**: Mélyreható kutatás és szakirodalom felhasználása.
   - **Online források**: Blogok, szakmai fórumok (pl. Stack Overflow), nyílt forráskódú projektek elemzése.

3. **Hallgatói kutatómunka**:
   - **Projektek és kísérletek**: Gyakorlati feladatok és saját projektek készítése a tanultak alkalmazására.
   - **Dokumentáció és prezentáció**: Az elvégzett munka részletes dokumentálása és bemutatása az oktatóknak és diáktársaknak.