### **Tervezési minták – részletes magyarázat**  

A tervezési minták általánosan alkalmazható, jól bevált megoldások, amelyek segítenek gyakori szoftvertervezési problémák kezelésében. Ezek a minták a "Separation of Concerns" elvét hangsúlyozzák, azaz a felelősségek szétválasztását a kód tisztasága és karbantarthatósága érdekében. Az alábbiakban részletesen ismertetjük a megadott mintákat, különös figyelemmel az absztrakcióra és a DIP (Dependency Inversion Principle) szerepére.

---

### **8.1. Szétválasztás a fókuszban: Híd és Megfigyelő**  

#### **8.1.1. Híd (Bridge)**  
A Híd minta célja az absztrakció és az implementáció szétválasztása, hogy mindkettő külön-külön fejleszthető és változtatható legyen.  

- **Működési elv:**  
  Az absztrakciót (például egy eszköz felületét) egy interfész vagy absztrakt osztály írja le. Az implementációkat külön osztályok valósítják meg, amelyek az absztrakcióhoz kapcsolódnak, de attól függetlenek.  
  Például egy grafikus rajzoló programban a **Shape** osztály absztrakció lehet, míg a konkrét implementációkat (pl. **Circle**, **Square**) külön osztályok kezelik, amelyek különböző grafikus API-kat (pl. OpenGL, DirectX) használhatnak.  

- **DIP szerepe:**  
  A Híd minta követi a DIP elvét, mivel az absztrakció (Shape) nem függ a konkrét implementációktól, hanem csak interfészekre támaszkodik.

#### **8.1.2. Megfigyelő (Observer)**  
A Megfigyelő minta egy olyan viselkedési minta, amely lehetővé teszi, hogy egy objektum (tárgy) értesítse a hozzá kapcsolódó megfigyelőket állapotváltozásairól.  

- **Működési elv:**  
  Az alany (Subject) tartalmaz egy listát a megfigyelőkről, amelyeket értesít, ha egy adott esemény bekövetkezik. Például egy hírportál (Subject) értesíti az előfizetőket (Observers), ha új cikk jelenik meg.  

- **DIP szerepe:**  
  A Megfigyelő minta tiszteletben tartja a DIP elvét, mert az alany és a megfigyelők közötti kommunikáció interfészeken keresztül történik, így az alany nem függ a konkrét megfigyelő implementációktól.  

---

### **8.2. Létrehozási tervezési minták**  

A létrehozási minták célja, hogy a példányosítás folyamata rugalmas és a kód számára átlátható legyen.  

#### **8.2.1. Absztrakt gyár (Abstract Factory)**  
Ez a minta egy interfészt biztosít, amely különböző, kapcsolódó vagy egymástól függő objektumok létrehozását teszi lehetővé anélkül, hogy megnevezné azok konkrét osztályait.  

- **Működési elv:**  
  Az Absztrakt gyár interfésze például egy **UIFactory** lehet, amely **Button** és **Checkbox** objektumokat hoz létre. Az implementáció lehet **WindowsUIFactory** vagy **MacUIFactory**, attól függően, hogy milyen platformot céloz a rendszer.  

- **DIP szerepe:**  
  Az Absztrakt gyár követi a DIP-et, mivel a kliens kód nem függ a konkrét osztályoktól, csak az interfésztől.

#### **8.2.2. Építő (Builder)**  
Az Építő minta összetett objektumok lépésenkénti felépítésére használatos, lehetővé téve a különböző reprezentációk létrehozását.  

- **Működési elv:**  
  Egy **Builder** interfész határozza meg az építés lépéseit, például **addWalls()**, **addRoof()** egy ház építéséhez. Az egyes konkrét építők (pl. **WoodenHouseBuilder**) a lépéseket különböző módokon valósítják meg.  

- **DIP szerepe:**  
  Az Építő minta szintén megfelel a DIP-nek, mivel az építés folyamata az interfészen keresztül zajlik.

#### **8.2.3. Prototípus (Prototype)**  
Ez a minta lehetővé teszi objektumok új példányainak létrehozását meglévő objektumok másolásával, nem pedig példányosítással.  

- **Működési elv:**  
  Egy objektum példányosítása helyett annak másolatát készítjük el a **clone()** metódussal. Például egy diagram elemeket tartalmazó szoftverben a meglévő alakzatok másolatát hozhatjuk létre a gyorsabb működés érdekében.  

- **DIP szerepe:**  
  A Prototípus minta az absztrakciót helyezi előtérbe azzal, hogy az objektumokat a saját interfészükön keresztül másolja.

---

### **8.3. Szerkezeti tervezési minták**  

Ezek a minták az osztályok és objektumok közötti kapcsolatokra összpontosítanak, megkönnyítve a nagyobb rendszerek felépítését.

#### **8.3.1. Díszítő (Decorator) és Összetétel (Composite)**  
- **Díszítő (Decorator):**  
  A Díszítő mintával dinamikusan adhatsz hozzá új viselkedést egy objektumhoz anélkül, hogy megváltoztatnád az osztályát. Például egy szövegszerkesztőben a szövegek különböző formázásai (félkövér, dőlt) díszítőkkel valósíthatók meg.  

- **Összetétel (Composite):**  
  Az Összetétel mintával hierarchikus struktúrákat hozhatsz létre, ahol az egyes elemek és a struktúra egésze ugyanúgy kezelhetők. Például egy mappastruktúrában a mappák és fájlok közötti kapcsolatot ez a minta reprezentálhatja.

- **DIP szerepe:**  
  Mindkét minta követi a DIP-et az interfészek használata révén, megakadályozva, hogy a magasabb szintű komponensek konkrét implementációktól függjenek.

#### **8.3.2. Pehelysúlyú (Flyweight)**  
Ez a minta a memóriaterhelés csökkentésére használható olyan esetekben, amikor sok hasonló objektumra van szükség. A közös állapotot megosztjuk az objektumok között.  

#### **8.3.3. Helyettes (Proxy)**  
A Proxy egy helyettesítő objektum, amely egy másik objektumhoz biztosít hozzáférést, például a hozzáférés ellenőrzéséhez vagy a műveletek késleltetéséhez.

---

### **8.4. Viselkedési tervezési minták**  

Ezek a minták az objektumok közötti kommunikációra és viselkedésre fókuszálnak. Céljuk, hogy strukturáltabbá és rugalmasabbá tegyék az interakciókat a rendszer különböző részei között. Ezek a minták különösen hasznosak, amikor az objektumok közötti együttműködés dinamikus vagy összetett.

#### **8.4.1. Felelősséglánc (Chain of Responsibility)**  
Egy sor objektum közül egy kezeli a kérést, például egy hiba feldolgozása során.  

- **Működési elv:**  
  A kérést egy lánc mentén továbbítjuk, ahol az egyes objektumok eldöntik, hogy feldolgozzák-e azt, vagy továbbküldik a következő elemnek. Például egy technikai támogatási rendszerben az ügyfél kérése először az ügyfélszolgálathoz kerül, majd ha szükséges, magasabb szintű szakértőknek adják tovább.

- **DIP szerepe:**  
  A kliens objektum nem függ a konkrét lánctagoktól, mivel a lánc interfészeken keresztül működik.

#### **8.4.2. Parancs (Command)**  
Egy műveletet objektumként ábrázol, így lehetővé téve a műveletek elmentését és visszavonását.  

- **Működési elv:**  
  A parancs minta egy absztrakciót biztosít a műveletek számára. Az egyes parancsok különálló objektumokként reprezentálják a műveleteket, amelyeket végre lehet hajtani, visszavonni, vagy akár sorosítani és elmenteni későbbi végrehajtásra. Például egy szövegszerkesztő "visszavonás" funkciója ilyen parancsokat használhat.

- **DIP szerepe:**  
  A parancs interfészen keresztül biztosítja a végrehajtás és visszavonás lehetőségét, így a kliens független a konkrét művelettől.

#### **8.4.3. Értelmező (Interpreter)**  
Lehetővé teszi egy nyelvtan szintaxisának értelmezését, például matematikai kifejezések esetén.  

- **Működési elv:**  
  Egy szabályok alapján működő rendszerben az értelmező minta segítségével a nyelvtani elemek külön osztályokként kerülnek implementálásra, amelyek képesek értelmezni és végrehajtani a bemeneti kifejezéseket. Például egy kalkulátor programban egy matematikai kifejezés (pl. `2 + 3 * 4`) értelmezéséhez használható.

- **DIP szerepe:**  
  Az értelmező mintában az osztályok interfészen keresztül kommunikálnak, így az egyes szabályok könnyen módosíthatók vagy bővíthetők.

#### **8.4.4. Iterátor (Iterator)**  
Egy gyűjtemény elemein történő iterálást tesz lehetővé egységes módon.  

- **Működési elv:**  
  Az iterátor minta egy egységes interfészt biztosít, amely lehetővé teszi, hogy egy gyűjtemény elemein anélkül lépkedjünk végig, hogy ismernünk kellene annak belső szerkezetét. Például egy lista vagy egy halmaz elemeit iterálhatjuk egy `Next` és `HasNext` metódust biztosító iterátor objektummal.

- **DIP szerepe:**  
  Az iterátor interfész elválasztja a gyűjtemény szerkezetét és annak kezelését, biztosítva a rugalmasságot.

#### **8.4.5. Közvetítő (Mediator)**  
Az objektumok közötti kommunikáció központosítása egyetlen közvetítő objektum segítségével.  

- **Működési elv:**  
  A közvetítő minta megszünteti a közvetlen függőségeket az objektumok között azáltal, hogy egy központi osztály kezeli a kommunikációt. Például egy chat alkalmazásban a felhasználók közötti üzenetváltást egy közvetítő szerver irányítja.

- **DIP szerepe:**  
  A közvetítő interfészen keresztül biztosítja az objektumok közötti interakciót, csökkentve a függőségeket.

#### **8.4.6. Pillanatkép (Memento)**  
Az objektum állapotának mentésére és visszaállítására szolgál.  

- **Működési elv:**  
  Egy objektum állapota elmenthető egy pillanatképbe, majd később visszaállítható. Például egy játékban a játékos aktuális állapotát (pl. életerő, helyszín) elmenthetjük, hogy a játékot később ugyanonnan folytathassuk.

- **DIP szerepe:**  
  A pillanatkép minta elválasztja az állapot kezelését az objektum belső működésétől, így biztosítva az absztrakciót.

#### **8.4.7. Állapot (State)**  
Lehetővé teszi egy objektum viselkedésének megváltozását annak aktuális állapota alapján.  

- **Működési elv:**  
  Az állapotokat külön osztályok kezelik, amelyek az aktuális állapothoz kapcsolódó viselkedést implementálják. Például egy jegykezelő rendszerben a jegy különböző állapotai lehetnek (pl. "foglalva", "vásárolva", "használva"), amelyek különböző működést eredményeznek.

- **DIP szerepe:**  
  Az állapot kezelése absztrakt interfészen keresztül történik, így a kliens független a konkrét állapottól.

#### **8.4.8. Stratégia (Strategy)**  
Egy viselkedést definiál, majd lehetővé teszi annak megváltoztatását futásidőben különböző stratégiák használatával.  

- **Működési elv:**  
  A stratégia interfész biztosítja az algoritmusok cserélhetőségét, például egy grafikus alkalmazás különböző renderelési stratégiákat (pl. 2D, 3D) alkalmazhat ugyanazon interfész alapján.

- **DIP szerepe:**  
  Az interfész és a konkrét stratégia implementációk szétválasztása minimalizálja a függőségeket.

#### **8.4.9. Sablon- és Gyártó Metódus (Template Method és Factory Method)**  

- **Sablon metódus (Template Method):**  
  Egy algoritmus sablont biztosít, ahol az algoritmus egyes lépései az alosztályokban testreszabhatók.  
  Például egy játékban az AI ellenfelek támadási logikája közös lépéseket tartalmazhat (pl. célpont keresés), de a támadási stílust az alosztály határozza meg.

- **Gyártó metódus (Factory Method):**  
  Egy absztrakt metódust definiál az objektumok létrehozására, például egy játék különböző fegyvereinek létrehozásához.

- **DIP szerepe:**  
  Az absztrakcióval biztosítja a rugalmasságot a példányosítás során. 