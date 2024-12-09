A TDD megközelítés következő lépésekben történik: **tesztírás**, **implementáció**, majd **refaktorálás**. Az alábbiakban lépésről lépésre bemutatom, hogyan lehet a feladatot TDD segítségével megoldani.

---

### **1. Tesztírás: A legegyszerűbb eset (alapértelmezett Fibonacci számok)**

#### Teszt:
Először azt ellenőrizzük, hogy a `Fibo` osztály alapértelmezett inicializálása helyes Fibonacci értékeket tartalmaz.

```java
import org.junit.jupiter.api.*;
import static org.junit.jupiter.api.Assertions.*;
import java.util.*;

public class FiboTest {
    private Fibo fibo;

    @BeforeEach
    public void setUp() {
        fibo = new Fibo();
    }

    @Test
    public void testInitialFibonacciValues() {
        assertEquals(1, fibo.get(0));
        assertEquals(1, fibo.get(1));
        assertEquals(2, fibo.get(2));
        assertEquals(3, fibo.get(3));
        assertEquals(5, fibo.get(4));
        assertEquals(8, fibo.get(5));
        assertEquals(13, fibo.get(6));
    }
}
```

---

### **2. Kódírás: Inicializálás minimális implementációval**

#### `Fibo` osztály:
```java
import java.util.*;

public class Fibo {
    private final Map<Integer, Integer> fiboMap = new HashMap<>();

    public Fibo() {
        fiboMap.put(0, 1);
        fiboMap.put(1, 1);
        fiboMap.put(2, 2);
        fiboMap.put(3, 3);
        fiboMap.put(4, 5);
        fiboMap.put(5, 8);
        fiboMap.put(6, 13);
    }

    public int get(int n) {
        return fiboMap.getOrDefault(n, -1);
    }
}
```

---

### **3. Teszt: Fibonacci szám generálása dinamikusan**

Most egy olyan tesztet írunk, amely biztosítja, hogy a dinamikusan generált Fibonacci számokat is helyesen kezelje az osztály.

#### Teszt:
```java
    @Test
    public void testCalculateFibonacciValue() {
        assertEquals(21, fibo.calculate(7)); // fibo(7) = 13 + 8
        assertEquals(34, fibo.calculate(8)); // fibo(8) = 21 + 13
    }
```

---

### **4. Kódfejlesztés: Fibonacci szám generálás**

A `calculate` metódust úgy implementáljuk, hogy dinamikusan kiszámolja a Fibonacci értékeket, és tárolja őket a `fiboMap`-ben.

#### `Fibo` osztály frissítése:
```java
    public int calculate(int n) {
        if (fiboMap.containsKey(n)) {
            return fiboMap.get(n);
        }
        int value = calculate(n - 1) + calculate(n - 2);
        fiboMap.put(n, value);
        return value;
    }
```

---

### **5. Teszt: Cache frissítés**

A következő lépésben teszteljük a `Cache` osztályt és annak `frissít` metódusát, amely új értékeket ad hozzá a `Fibo` tárolójához.

#### Teszt:
```java
    @Test
    public void testCacheUpdate() {
        Cache cache = new Cache();
        cache.add(7, 21); // Cache-be tesszük a fibo(7) értékét
        cache.add(8, 34); // Cache-be tesszük a fibo(8) értékét

        cache.frissít(fibo); // Frissítjük a Fibo tárolót

        assertEquals(21, fibo.get(7));
        assertEquals(34, fibo.get(8));
    }
```

---

### **6. Kódírás: Cache frissítés**

Létrehozzuk a `Cache` osztályt, amely a `frissít` metódusban adja hozzá a hiányzó értékeket a `Fibo` tárolóhoz.

#### `Cache` osztály:
```java
import java.util.*;

public class Cache {
    private final Map<Integer, Integer> cache = new HashMap<>();

    public void add(int n, int value) {
        cache.put(n, value);
    }

    public void frissít(Fibo f) {
        for (Map.Entry<Integer, Integer> entry : cache.entrySet()) {
            if (!f.contains(entry.getKey())) {
                f.add(entry.getKey(), entry.getValue());
            }
        }
    }
}
```

#### `Fibo` osztály frissítése:
```java
    public boolean contains(int n) {
        return fiboMap.containsKey(n);
    }

    public void add(int n, int value) {
        fiboMap.put(n, value);
    }
```

---

### **7. Refaktorálás**

Az elkészült osztályokat átnézzük, hogy megfelelnek-e a tiszta kód elveinek, és optimalizálunk, ha szükséges.

---

### **Összegzés**

A TDD módszerrel lépésről lépésre kifejlesztettük a `Fibo` osztályt a Fibonacci számok kezelésére, valamint a `Cache` osztályt az értékek frissítésére. Az osztályok tesztelhetők és rugalmasak, biztosítva a helyes működést és a jövőbeni bővítések lehetőségét.