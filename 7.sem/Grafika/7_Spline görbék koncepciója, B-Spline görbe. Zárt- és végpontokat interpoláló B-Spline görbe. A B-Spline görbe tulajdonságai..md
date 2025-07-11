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

Ha szeretnél konkrét példát egy B-Spline görbe kiszámítására, vagy további magyarázatot a bázisfüggvényekkel kapcsolatban, jelezd bátran! 😊
