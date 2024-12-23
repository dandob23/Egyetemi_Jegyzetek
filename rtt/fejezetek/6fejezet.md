### **6. Practices: Jól bevált módszerek**

---

#### **Extrém Programozás (XP)**  
- **Lényege:** Feladatok kiemelkedően precíz végrehajtása (pl. tesztvezérelt fejlesztés).  
- **Módszerek:**  
  - Tesztvezérelt fejlesztés (TDD).  
  - Folyamatos integráció.  
  - Kódszépítés (Refactoring).  
  - Forráskód átnézése (Code Review).  
  - Páros programozás.

#### **Tiszta Kód (Clean Code)**  
- **Fő ismérvek:**  
  - Könnyű olvashatóság.  
  - Rövid, egyszerű metódusok.  
  - Mellékhatások elkerülése.  
  - Rövid paraméterlista.

#### **Cserkészszabály (Boy Scout Rule)**  
- Mindig hagyd tisztábban a kódot, mint ahogy találtad.

#### **Rothadó Kód (Rotting Code)**  
- **Jellemzők:** Merevség, törékenység, homályosság.  
- **Okok:** Nagy metódusok, erős csatoltság, duplikált kód.

---

### **6.2. Egységteszt**

#### **Cél és működés**  
- **Cél:** Automatizált tesztek írása a kód működésének ellenőrzésére.  
- **Működés:** Fix bemeneti paraméterek, elvárt és aktuális kimenet összehasonlítása.  

#### **Előnyei:**  
- Hibák gyors azonosítása.  
- Regressziós tesztelés automatizálása.  

#### **JUnit5 Maven integráció**  
- **Függőségek hozzáadása:**
```xml
<dependency>
    <groupId>org.junit.jupiter</groupId>
    <artifactId>junit-jupiter-engine</artifactId>
    <version>5.9.2</version>
    <scope>test</scope>
</dependency>
```  

---

### **6.3. Tesztvezérelt Fejlesztés (TDD)**  

#### **Alapelvek:**  
1. Tesztet írunk, mielőtt kódot írnánk.  
2. Csak minimális kódot írunk a teszt sikeréhez.  

#### **Lépések:**  
1. **Piros:** Teszt írása, amely hibát jelez.  
2. **Zöld:** Minimális kód írása, hogy a teszt sikeres legyen.  
3. **Kék:** Refaktorálás a kód tisztábbá tételéhez.  

#### **Előnyök:**  
- Tesztelhetőség növelése.  
- Regressziós tesztelés támogatása.  
- Kód karbantarthatóságának javítása.

#### **Példa (Piros–Zöld–Kék):**  
- Egységtesztek írása egyszerű esetekhez, majd fokozatosan bonyolultabb struktúrákhoz.  
- Refaktorálás redundancia eltávolításához.

---

### **6.4. Viselkedésvezérelt Fejlesztés (BDD)**  

#### **Lényege:**  
- A TDD továbbfejlesztése a csapat együttműködésének erősítésére (fejlesztők, üzleti elemzők, tesztelők).  

#### **Cél:**  
- Felhasználói sztorik lefordítása tesztelhető viselkedési leírásokká.  
- Egységes nyelv biztosítása (Given, When, Then).  

#### **Folyamata:**  
1. **Felfedezés:** Követelmények azonosítása.  
2. **Kialakítás:** Felhasználói sztorik Gherkin formátumba írása.  
3. **Automatizáció:** Tesztek implementálása (pl. Cucumber).  

#### **Gherkin alapelemek:**  
- **Scenario/Example:** Forgatókönyv címe.  
- **Given:** Kezdőállapot.  
- **When:** Trigger esemény.  
- **Then:** Elvárt eredmény.  
- **And/But:** Logikai kapcsolatok.  

#### **Feature fájl:**  
- **Kiterjesztés:** `.feature`.  
- **Haladó elemek:**  
  - **Background:** Közös lépések minden forgatókönyvhöz.  
  - **Scenario Outline:** Táblázatos változók és eredmények.  
  - **Doc String:** Többsoros adatok.

---

### **6.5. Naplózás**

#### **Célja:**  
- Hibák nyomon követése és elemzése.  
- Kritikus rendszerekben az utolsó konzisztens állapot visszaállításának biztosítása.  

#### **Naplózási szintek:**  
1. Csak fő események.  
2. Fő funkciók követése.  
3. Minden metódushívás.  
4. Részletes értékadások naplózása.  

#### **Fontos megjegyzések:**  
- Lassíthatja a programot, de elengedhetetlen a hibajavításhoz.  
- **Java-ban:** Log4J használata.  
- **C#-ban:** Trace osztály a naplózásra.  

---

### **6.6. Aspektusorientált programozás (AOP)**

#### **Fő gondolatok:**  
- **Tiszta osztályok:** Elkülönítés naplózástól, jogosultságkezeléstől stb.  

#### **Fogalmak:**  
1. **Aspektus:** Általános követelmények (pl. naplózás) megvalósítása.  
2. **Szövés:** Az aspektusok integrálása a kódba.  
3. **Kapcsolódási pontok:** Helyek, ahol az aspektus érvényesül (pl. metódusok előtt/után).  
4. **Pontszűrő:** Összerendeli az aspektusokat és kapcsolódási pontokat.  

#### **Szövési módok:**  
- Fordítási időben.  
- Futási időben.  

---

### **6.7. Statikus tesztelési technikák**

#### **Statikus tesztelés jellemzői:**  
- **Definíció:** Forráskód és dokumentáció elemzése futtatás nélkül.  
- **Előnye:** Korán azonosítja a hibákat, gazdaságosabb a javítás.  

#### **Két típusa:**  
1. **Felülvizsgálat:** Manuális átnézés.  
2. **Statikus elemzés:** Automatizált hibakeresés.  

---

### **6.7. Felülvizsgálati típusok**

1. **Informális felülvizsgálat:** Fejlesztők közötti átnézés.  
2. **Átvizsgálás:** Modulok ismertetése és hibakeresés.  
3. **Technikai felülvizsgálat:** Külső szakértők bevonása.  
4. **Inspekció:** Részletes, szerződéses keretben végzett vizsgálat.

---

### **6.7.6. Statikus elemzés**

#### **Előnyei:**  
- Hibatípusok könnyebb felismerése, pl. nullreferenciák, holtpontok.  

#### **Típusai:**  
1. Forráskód alapú elemzés.  
2. Forráskód és modell alapú elemzés.  

#### **Eszközök:**  
- **Specifikus:** Holtpontkeresők.  
- **Általános:** FindBugs, Sonar.  

#### **FindBugs használata:**  
- Telepítés és automatikus elemzés Eclipse-ben.  
- Hibák jelzése és részletes hibaelemzés.  