A TDD (Test-Driven Development) megközelítés három fő lépésben zajlik: **tesztírás**, **kódfejlesztés**, és **refaktorálás**. Az alábbiakban lépésről lépésre haladva mutatom be, hogyan fejlesztjük le a `EgerTávolság` osztályt és a `kivitelezhető` metódust TDD módszerrel.

---

### **1. Tesztírás: Kezdjük a legkisebb funkcionalitással**
Az első cél, hogy a `kivitelezhető` metódus `true`-t adjon vissza, ha a bemenet egy üres lista. Ehhez először létrehozunk egy tesztet.

#### Teszt:
```java
import org.junit.jupiter.api.*;
import java.util.*;

import static org.junit.jupiter.api.Assertions.*;

public class EgerTávolságTest {
    private EgerTávolság egerTávolság;

    @BeforeEach
    public void setUp() {
        egerTávolság = new EgerTávolság();
    }

    @Test
    public void testKivitelezhető_EmptyList_ReturnsTrue() throws SajátKivétel {
        List<String> városok = Collections.emptyList();
        assertTrue(egerTávolság.kivitelezhető(városok));
    }
}
```

---

### **2. Kódfejlesztés: Minimális implementáció a teszthez**
Csak annyi kódot írunk, hogy a teszt sikeresen lefusson.

#### Osztály:
```java
import java.util.*;

public class EgerTávolság {
    public boolean kivitelezhető(List<String> városNevek) {
        return true; // Az üres lista esetén mindig igaz
    }
}
```

---

### **3. Újabb teszt: Egyszerű, nem üres lista**
Most ellenőrizzük, hogy a `kivitelezhető` metódus működik-e olyan esetben, amikor a városok össztávolsága 500 km alatt van.

#### Új teszt:
```java
    @Test
    public void testKivitelezhető_ValidCities_ReturnsTrue() throws SajátKivétel {
        egerTávolság.addTávolság("Miskolc", 120);
        egerTávolság.addTávolság("Debrecen", 150);

        List<String> városok = Arrays.asList("Miskolc", "Debrecen");
        assertTrue(egerTávolság.kivitelezhető(városok));
    }
```

#### Refaktorálás: Új metódus az adatok hozzáadására
Bevezetjük a `addTávolság` metódust, hogy távolságokat adhassunk hozzá.

#### Osztály frissítése:
```java
import java.util.*;

public class EgerTávolság {
    private final Map<String, Integer> távolságok = new HashMap<>();

    public void addTávolság(String város, int távolság) {
        távolságok.put(város, távolság);
    }

    public boolean kivitelezhető(List<String> városNevek) {
        int összesTávolság = 0;
        for (String város : városNevek) {
            összesTávolság += távolságok.getOrDefault(város, 0);
        }
        return összesTávolság < 500;
    }
}
```

---

### **4. Újabb teszt: Összes távolság meghaladja az 500 km-t**
Most teszteljük, hogy a metódus `false`-t ad vissza, ha a városok távolsága összesen eléri vagy meghaladja az 500 km-t.

#### Új teszt:
```java
    @Test
    public void testKivitelezhető_TotalDistanceOverLimit_ReturnsFalse() throws SajátKivétel {
        egerTávolság.addTávolság("Miskolc", 250);
        egerTávolság.addTávolság("Debrecen", 300);

        List<String> városok = Arrays.asList("Miskolc", "Debrecen");
        assertFalse(egerTávolság.kivitelezhető(városok));
    }
```

---

### **5. Kivételkezelés: Null paraméter**
Teszteljük, hogy dobja-e a megfelelő kivételt, ha a bemeneti lista null.

#### Teszt:
```java
    @Test
    public void testKivitelezhető_NullList_ThrowsException() {
        assertThrows(SajátKivétel.class, () -> egerTávolság.kivitelezhető(null));
    }
```

#### Kód frissítése:
```java
    public boolean kivitelezhető(List<String> városNevek) throws SajátKivétel {
        if (városNevek == null) {
            throw new SajátKivétel("A városNevek lista nem lehet null!");
        }

        int összesTávolság = 0;
        for (String város : városNevek) {
            összesTávolság += távolságok.getOrDefault(város, 0);
        }
        return összesTávolság < 500;
    }
```

#### Saját kivételosztály:
```java
public class SajátKivétel extends Exception {
    public SajátKivétel(String üzenet) {
        super(üzenet);
    }
}
```

---

### **6. Távolság frissítése fájlból**
Létrehozunk egy `pontosít` metódust, amely frissíti a távolságokat egy fájlból.

#### Teszt:
```java
    @Test
    public void testPontosít_FileUpdatesDistances() throws IOException {
        Pontosít pontosító = new Pontosít();
        pontosító.pontosít(egerTávolság.getTávolságok());
        assertEquals(150, egerTávolság.getTávolságok().get("Debrecen"));
    }
```

#### `Pontosít` osztály:
```java
import java.io.*;
import java.util.*;

public class Pontosít {
    public void pontosít(Map<String, Integer> távolságok) throws IOException {
        try (BufferedReader reader = new BufferedReader(new FileReader("friss_adatok.txt"))) {
            String sor;
            while ((sor = reader.readLine()) != null) {
                String[] adatok = sor.split(",");
                String város = adatok[0].trim();
                int távolság = Integer.parseInt(adatok[1].trim());
                távolságok.put(város, távolság);
            }
        }
    }
}
```

---

### **Összegzés**
A TDD módszerrel minden lépésben tesztekkel vezéreltük a fejlesztést. A kód rövid, tiszta és jól tesztelt. Az osztály immár képes kezelni a távolságadatokat, számításokat végezni, és kivételeket dobni a megfelelő esetekben.