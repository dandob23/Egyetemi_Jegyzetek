### **3. A Használatieset-alapú Tervezés és Termékei**  

#### **Bevezetés**  
- Az 1960-as évek szoftvertervezése adatfolyamokra épült.  
- **Irányzatok:** Adatbázis-központú, batch/pipeline, felhasználói felület központú, responsive design.  
- **RUP módszertan:** A használati esetek középpontba helyezése.  

#### **Használatieset-alapú tervezés**  
- **Fogalom:** Szereplők és funkciók közötti interakciók egyszerű ábrázolása.  
- **Előnyei:** Tisztább kommunikáció, gyorsabb visszacsatolás.  

---

### **3.1 Használatieset-tervezés**  

#### **Történeti háttér**  
- **Eredet:** Ivar Jacobson (1987), *Object-Oriented Software Engineering*.  

#### **Diagram elemei**  
- **Szereplők (actors):** Pálcikaember.  
- **Használati esetek:** Ellipszisek.  
- **Rendszerhatár:** Téglalap az alrendszerek elválasztására.  
- **Kapcsolatok:** Nyilak a szereplők és a funkciók között.  

#### **Példa:**  
- Az eladó számlát készít, a polcfeltöltő csak polcot tölthet fel.  

---

#### **Rendszerhatár és összetett rendszerek**  
- **Fogalom:** Meghatározza, mi tartozik a rendszerbe, segít az alrendszerek felelősségének elkülönítésében.  
- **Példa:** A webshop a vásárlásért felel, a raktár a készletért, a számlázás az adminisztrációért.  

#### **Fő tanulságok**  
1. **Használatieset-diagramok:** Egyszerűek, gyors visszacsatolást adnak.  
2. **Rendszerhatár:** Egyértelműsíti a felelősségeket.  
3. **Kommunikáció:** Közös nyelvet biztosít a tervezők és megrendelők között.  

---

### **Szereplők és Használati Esetek**  

#### **Szereplők**  
- **Szereplők:** Emberek, rendszerek, alrendszerek, amelyek a rendszerrel interakcióba lépnek.  
- **Nem szereplők:** Adatok, erőforrások (pl. adatbázis, pénz).  

#### **Használati esetek**  
- **Fő használati esetek:** A rendszer céljait valósítják meg.  
- **Sima használati esetek:** Kiegészítő funkciók.  

#### **Példa: Autóbolt**  
1. **Autóválasztás:** Sima használati eset.  
2. **Vásárló adatainak rögzítése:** Üzleti használati eset.  
3. **Foglaló adatainak rögzítése:** Üzleti használati eset.  

---

### **Nyilak a Használatieset-diagramon**  
1. **Generalizáció-specializáció:** Háromszög alakú nyíl.  
2. **<<include>>:** Kiemeli a közös részeket.  
3. **<<extend>>:** Az opcionális funkciók megjelenítése.  

---

### **Hierarchia és Visszakövethetőség**  

#### **Struktúra:**  
- Vízió → Epikek → Használati esetek → Felhasználói sztorik.  

#### **Példa:**  
- Autóeladás: Autóválasztás, beszámítás.  

---

### **Felhasználói Sztori**  

#### **Fogalom**  
- **Használati eset:** A rendszer célját valósítja meg.  
- **Felhasználói sztori:** A használati eset konkrét példája.  

#### **Példa: Autóeladás**  
1. **Forgatókönyv:** Vásárló autót választ, az eladó rögzíti az adatokat, számlát készít.  
2. **UML-diagramok:**  
   - **Aktivitási diagram:** Vásárló → Eladó → Adatok rögzítése.  
   - **Szekvenciadiagram:** Vásárló → GUI → Számlázás → Átadás.  

---

### **Fontos megjegyzések**  
- **Iteratív folyamat:** Alábontás, javítás, részletezés.  
- **Egyszerűség:** A diagramok célja az áttekinthetőség.  
- **MVP:** Csak az alapvető funkciókat tartalmazza.  

---

### **Összegzés**  
- **Használatieset-diagramok:** Tisztán ábrázolják a rendszer fő funkcióit.  
- **Hierarchikus tervezés:** Támogatja a logikus és konzisztens struktúrát.