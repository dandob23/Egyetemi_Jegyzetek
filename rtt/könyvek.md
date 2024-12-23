### **Robert C. Martin – Clean Architecture: A Craftsman's Guide to Software Structure and Design**

#### **A könyv felépítése**
1. **Bevezetés:**  
   - A szoftver architektúra fontosságának bemutatása.  
   - Cél: megérteni, hogyan alakítsunk ki tartós, rugalmas rendszereket.  

2. **Alapfogalmak:**  
   - "Mi az architektúra?"  
   - Szilárd alapelvek: SRP (Single Responsibility Principle), OCP (Open/Closed Principle), stb.  

3. **A szoftver architektúra szabályai:**  
   - Határok és rétegek elválasztása.  
   - Adatok és viselkedések szétválasztása.  

4. **Tiszta architektúra:**  
   - Határrétegek szerepe.  
   - A belső körök fontossága: entitások és használati esetek.  

5. **Részletek:**  
   - Technológiai döntések és azok időzítése.  
   - A "döntéseink megfordíthatósága" elv.  

6. **Példák és gyakorlat:**  
   - Történetek valódi szoftverprojektekből.  
   - Példák a tiszta architektúra alkalmazására különböző típusú rendszerekben.

7. **Összegzés:**  
   - A szoftver minőségének hosszú távú fenntartása.  
   - A folyamatos tanulás és fejlődés fontossága.

---

#### **Legfontosabb mondatok/idézetek és jelentésük**

1. **"Architecture is about intent."**  
   - **Jelentés:** Az architektúra célja, hogy elősegítse a rendszer jövőbeli fenntarthatóságát és rugalmasságát.  
   - **Hely:** Bevezető fejezet.  

2. **"A good architecture allows major decisions to be deferred."**  
   - **Jelentés:** Egy jó architektúra megkönnyíti a technológiai vagy implementációs döntések késleltetését, amíg nem feltétlen szükségesek.  
   - **Hely:** Technológiai döntések fejezet.  

3. **"The Dependency Rule: Source code dependencies must point only inward, toward higher-level policies."**  
   - **Jelentés:** Az alacsony szintű modulok (pl. adatbázisok, keretrendszerek) ne függjenek a magas szintű logikától, hanem fordítva.  
   - **Hely:** Tiszta architektúra fejezet.  

4. **"Frameworks are tools, not ways of life."**  
   - **Jelentés:** A keretrendszerek használata hasznos, de ne kötődjünk hozzájuk annyira, hogy az akadályozza a rugalmasságot.  
   - **Hely:** Részletek fejezet.  

5. **"Keep your options open as long as possible."**  
   - **Jelentés:** Az implementációs döntéseket addig érdemes halogatni, amíg teljesen meg nem értjük a követelményeket.  
   - **Hely:** Összegzés.

---

#### **Rövid összefoglaló**

- **Cél:** Hosszú távon fenntartható, rugalmas szoftverarchitektúrák tervezése.  
- **Fókusz:**  
  - Szilárd alapelvek (SRP, OCP).  
  - Határok és rétegek elválasztása.  
  - A belső körök (entitások, use case-ek) védelme.  
- **Fontos tanulságok:**  
  - Az architektúra a rendszerek "életbiztosítása".  
  - A technológia másodlagos az architektúra céljaihoz képest.  
  - A jó döntések késleltethetők, és megfordíthatók.  
- **Gyakorlati tanácsok:**  
  - Keretek használata helyett az alkalmazás logikájának helyes szervezése a kulcs.  
  - Minimalizáljuk a technológiai függőségeket.  
  - Az egyszerűség és átláthatóság hosszú távon meghálálja magát.



### **Kanban és Scrum: Mindkettőből a legjobbat – Bemutató**  

#### **1. A könyv felépítése:**  
1. **Bevezetés:** Miért van szükség Kanbanra és Scrumra?  
2. **Kanban és Scrum összehasonlítása:** Alapelvek, gyakorlatok és különbségek.  
3. **Kanban használata Scrum csapatokban:** Hogyan egészítik ki egymást.  
4. **Gyakorlati példák:** Konkrét helyzetek bemutatása.  
5. **Záró gondolatok:** Mikor melyik módszert válasszuk.  

---

#### **2. Legfontosabb mondatok/idézetek és jelentésük:**  

1. **"Kanban fokozatos változásra ösztönöz, míg a Scrum radikális váltásokat követel."**  
   - **Jelentés:** A Kanban adaptív és kevésbé invazív, a Scrum strukturáltabb és forradalmibb.  
   - **Elhelyezkedés:** Kanban és Scrum összehasonlítása fejezet.  

2. **"A Scrum sprintjeiben fixált ütemezés uralkodik, míg a Kanban folyamatos áramlást biztosít."**  
   - **Jelentés:** A Scrum időalapú iterációkra, a Kanban folyamatos munkafolyamat-kezelésre épül.  
   - **Elhelyezkedés:** Scrum sprintjei és Kanban flow-rendszere közti különbségeknél.  

3. **"Kanban a vizualizáció mestere, Scrum a csapatmunkáé."**  
   - **Jelentés:** A Kanban a folyamatok átláthatóságát növeli, a Scrum a csapatdinamikát erősíti.  
   - **Elhelyezkedés:** Alapelvek és gyakorlatok szakasz.  

4. **"A Kanban nem előírásokat ad, hanem keretet, a Scrum pontos szabályrendszerrel dolgozik."**  
   - **Jelentés:** A Kanban rugalmasan alkalmazható, a Scrum szigorúbb keretrendszert követ.  
   - **Elhelyezkedés:** Scrum szabályrendszerének és Kanban rugalmasságának leírásánál.  

---

#### **3. Rövid összefoglaló:**  

- **Témája:**  
  A könyv bemutatja, hogyan egészíti ki egymást a Kanban és a Scrum, és segít eldönteni, melyiket érdemes alkalmazni a különböző helyzetekben.  

- **Kulcsfogalmak:**  
  1. **Kanban:** Rugalmas, vizualizált munkafolyamat-kezelés.  
  2. **Scrum:** Iteráció-alapú, csapatszintű agilis keretrendszer.  

- **Legfontosabb különbségek:**  
  - Kanban: Folyamatos fejlesztés és áramlás.  
  - Scrum: Sprint-alapú iterációk és csapatszintű szerveződés.  

- **Legfontosabb tanulságok:**  
  1. A Kanban könnyebb átmenetet biztosít a változások bevezetéséhez.  
  2. A Scrum jobban szabályozott, ideális zárt projektekhez.  
  3. A kettő kombinációja erősítheti az agilitást és a csapat hatékonyságát.  