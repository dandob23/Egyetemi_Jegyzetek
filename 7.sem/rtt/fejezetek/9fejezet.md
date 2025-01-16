### **9. CRUD: Létrehozás, olvasás, frissítés és törlés**

#### **CRUD Alapfogalmak**
- **CRUD jelentése:**  
  - **C**reate (Létrehozás).  
  - **R**ead (Olvasás).  
  - **U**pdate (Frissítés).  
  - **D**elete (Törlés).  
- **Gyakoriság:**  
  - Az információs rendszerek tervezési feladatainak jelentős része CRUD-oldal tervezés (5-ből 3-4).  
- **Tervezői szerep:**  
  - Képernyőtervek, backend és frontend kommunikáció megtervezése.  
  - Logikai és fizikai megszorításokra fókuszálás.

---

### **9.1. Listázás**

#### **Tervezési kérdések a termék tulajdonos (PO) felé:**

1. **Lapozás:**  
   - Egy oldalon hány elem legyen? (Pl. 20).  
   - Lapozógombok helye és állapota (pl. szürke, ha nem kattintható).  
   - Hány oldalnyi ugrás gombokkal (pl. 5 vagy 10 oldal)?  
   - Mutassa a jelenlegi oldal számát? (Általában igen).  

2. **Csíkozás:**  
   - Használjunk vizuális csíkozást? (Pl. minden második sor).  
   - Legyen konfigurálható? (Általában nem).  

3. **Rendezés:**  
   - Mely oszlopok szerint lehessen rendezni?  
   - Növekvő és csökkenő sorrend váltása hogyan történjen?  
   - Többszintű rendezés lehetséges?  
   - Kell rendezés megszüntető gomb?  

4. **Keresés:**  
   - Egész táblában, vagy csak oszloponként? (Általában egész tábla).  
   - Keresőmező helye (pl. lista felett).  
   - Mikor történjen keresés? (Pl. 3 betű begépelése után).  
   - Engedélyezzünk-e joker karaktereket (*, ?)? (Általában nem).  

5. **Szűrés:**  
   - Oszloponkénti szűrési feltételek megadhatók?  
   - Kis form vagy oszlopfejlécben legyenek a szűrési opciók?

6. **Törlés:**  
   - Legyen törlés opció?  
   - Legyen törlés megerősítő ablak?  
   - Mi történjen, ha az összes elemet törlik?

7. **Módosítás:**  
   - Lehető-e listaelemeket módosítani?  
   - Módosítás megerősítő ablak szükséges-e?

8. **Beszúrás:**  
   - Új elemek beszúrásának lehetősége?  
   - Hová lehet beszúrni (pl. lista végére, kurzor elé/mögé)?  

---

#### **Tervezési kérdések a vezető programozó felé:**

1. **Lekérdezés:**  
   - Hány oldalnyi adatot kérhet le a kliens? (Pl. aktuális, előző, következő).  

2. **Törlés:**  
   - Fizikai vagy logikai törlés legyen?  
   - Kaszkádolt törlést az adatbázis motor vagy a backend végezzen?  

---

### **9.2. CRUD tervezés állapotgéppel**

#### **Állapotgép alapelvei:**  
- A lista állapotai közötti átmenetek események hatására történnek.  
- Használjunk átlátható, szimmetrikus struktúrát.  
- Csökkentsük az állapotok számát (általában max. 8 állapot).  

#### **Hasznos tervezési trükkök:**  
- **Összefogó állapotok:** Ha sok az állapot, egy nagyobb állapotba vonhatók össze.  
- **Mezők bevezetése:** Hasonló állapotok összevonására.  
- **Rövidítések használata:** Dokumentálással egyértelműsíthetők.  
- **Szimmetria:** Közös logika kihasználása hasonló funkciók között.  

#### **Konkrét példák:**  
1. **Lapozás előre és hátra gombokkal:**  
   - Állapotok: Első, Középső, Utolsó oldal.  
   - Átmenetek: Előre/hátra gombok (utolsó/első oldalon szürke állapot).  

2. **Lista rendezése két oszlop szerint:**  
   - **Szabályok:** Növekvő, csökkenő sorrend mindkét oszlopban, többszintű rendezés lehetősége.  
   - **Összevonás:** Egy állapot az oszlopok szerinti sorrendekhez (pl. A és B szerint).  

3. **Átláthatóság optimalizálása:**  
   - Szimmetrikus struktúrák: Egy oszlop logikája másik oszlopra is alkalmazható.  
   - Rövidítések és mezők bevezetése.  

--- 

**Végezetül:**  
- A CRUD tervezés kulcsa a funkcionalitás és átláthatóság közötti egyensúly megtartása.  
- Használjunk állapotgépeket az összetett műveletek egyszerűsítésére és vizuális ábrázolására.