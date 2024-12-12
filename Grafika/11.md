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

Ha szeretnél példát valamelyik képlet konkrét számítására (pl. fényösszetevők kiszámítása vagy fénysugárkövetési folyamat modellezése), jelezd bátran! 😊
