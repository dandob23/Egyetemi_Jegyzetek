A TDD módszerrel lépésről lépésre fejleszthetjük az osztályt a következő lépésekben. Ehhez Boundary Value Analysis (BVA) alapelveit alkalmazzuk, amely során a határértékeket és azok környezetét teszteljük. Az ismételt tesztelésre (`@RepeatedTest`) és paraméteres tesztelésre (`@ParameterizedTest`) is példát mutatok.

---

### **1. Tesztírás: Alapértelmezett kategóriák inicializálása**

#### Teszt:
Az első tesztünk azt ellenőrzi, hogy az osztály alapértelmezett kategóriákat állít be a megadott intervallumokra.

```java
import org.junit.jupiter.api.*;
import static org.junit.jupiter.api.Assertions.*;
import java.util.*;

public class ÉletkorAlapjánOsztálybaSorolTest {
    private ÉletkorAlapjánOsztálybaSorol osztályzó;

    @BeforeEach
    public void setUp() {
        osztályzó = new ÉletkorAlapjánOsztálybaSorol();
        osztályzó.alapértelmezettKategóriák();
    }

    @Test
    public void testDefaultCategoriesInitialization() {
        assertEquals("hiba", osztályzó.GetOsztály(-1));
        assertEquals("csecsemő", osztályzó.GetOsztály(0));
        assertEquals("kisgyerek", osztályzó.GetOsztály(2));
        assertEquals("felnött", osztályzó.GetOsztály(40));
        assertEquals("idős", osztályzó.GetOsztály(120));
        assertEquals("hiba", osztályzó.GetOsztály(121));
    }
}
```

---

### **2. Kódírás: Alapértelmezett kategóriák inicializálása**

#### `ÉletkorAlapjánOsztálybaSorol` osztály:
```java
import java.util.*;

public class ÉletkorAlapjánOsztálybaSorol {
    private final Map<MyInterval, String> osztályzó = new HashMap<>();

    public void alapértelmezettKategóriák() {
        setElnevezés(Integer.MIN_VALUE, -1, "hiba");
        setElnevezés(0, 1, "csecsemő");
        setElnevezés(2, 6, "kisgyerek");
        setElnevezés(7, 12, "gyerek");
        setElnevezés(13, 18, "tini");
        setElnevezés(19, 21, "fiatal_felnött");
        setElnevezés(22, 65, "felnött");
        setElnevezés(66, 120, "idős");
        setElnevezés(121, Integer.MAX_VALUE, "hiba");
    }

    public String GetOsztály(int életkor) {
        for (Map.Entry<MyInterval, String> entry : osztályzó.entrySet()) {
            if (entry.getKey().contains(életkor)) {
                return entry.getValue();
            }
        }
        return "hiba";
    }

    public void setElnevezés(int minÉletkor, int maxÉletkor, String elnevezés) {
        osztályzó.put(new MyInterval(minÉletkor, maxÉletkor), elnevezés);
    }
}
```

#### `MyInterval` osztály:
```java
public class MyInterval {
    private final int minÉletkor;
    private final int maxÉletkor;

    public MyInterval(int minÉletkor, int maxÉletkor) {
        this.minÉletkor = minÉletkor;
        this.maxÉletkor = maxÉletkor;
    }

    public boolean contains(int value) {
        return value >= minÉletkor && value <= maxÉletkor;
    }

    @Override
    public boolean equals(Object obj) {
        if (this == obj) return true;
        if (obj == null || getClass() != obj.getClass()) return false;
        MyInterval that = (MyInterval) obj;
        return minÉletkor == that.minÉletkor && maxÉletkor == that.maxÉletkor;
    }

    @Override
    public int hashCode() {
        return 13 * minÉletkor + 7 * maxÉletkor;
    }
}
```

---

### **3. Tesztírás: Paraméteres tesztelés BVA-hoz**

A határértékek teszteléséhez paraméteres tesztet használunk.

#### Teszt:
```java
import org.junit.jupiter.params.*;
import org.junit.jupiter.params.provider.CsvSource;

public class ÉletkorAlapjánOsztálybaSorolParameterizedTest {
    private ÉletkorAlapjánOsztálybaSorol osztályzó;

    @BeforeEach
    public void setUp() {
        osztályzó = new ÉletkorAlapjánOsztálybaSorol();
        osztályzó.alapértelmezettKategóriák();
    }

    @ParameterizedTest
    @CsvSource({
        "-1, hiba",
        "0, csecsemő",
        "1, csecsemő",
        "2, kisgyerek",
        "6, kisgyerek",
        "7, gyerek",
        "12, gyerek",
        "13, tini",
        "18, tini",
        "19, fiatal_felnött",
        "21, fiatal_felnött",
        "22, felnött",
        "65, felnött",
        "66, idős",
        "120, idős",
        "121, hiba"
    })
    public void testGetOsztályBoundaryValues(int életkor, String elvárt) {
        assertEquals(elvárt, osztályzó.GetOsztály(életkor));
    }
}
```

---

### **4. Teszt: Ismételt tesztelés**

Egy ismételt teszttel random életkorokat vizsgálhatunk, hogy a határértékekre vonatkozó logika stabil.

#### Teszt:
```java
import org.junit.jupiter.api.RepeatedTest;

import java.util.Random;

public class ÉletkorAlapjánOsztálybaSorolRepeatedTest {
    private ÉletkorAlapjánOsztálybaSorol osztályzó;
    private final Random random = new Random();

    @BeforeEach
    public void setUp() {
        osztályzó = new ÉletkorAlapjánOsztálybaSorol();
        osztályzó.alapértelmezettKategóriák();
    }

    @RepeatedTest(10)
    public void testRandomAges() {
        int életkor = random.nextInt(130) - 5; // -5 és 124 között
        String kategória = osztályzó.GetOsztály(életkor);
        assertNotNull(kategória);
    }
}
```

---

### **5. Refaktorálás**

Átnézzük a kódot, hogy optimalizálható-e. Ellenőrizzük a hatékonyságot és a tisztaságot.

---

### **Összegzés**

Ezzel a TDD folyamattal:
- Az alapértelmezett kategóriákat megfelelően inicializáltuk.
- A BVA határértékek szerint teszteltük a logikát.
- Paraméteres és ismételt tesztekkel biztosítottuk a helyes működést különböző esetekben.