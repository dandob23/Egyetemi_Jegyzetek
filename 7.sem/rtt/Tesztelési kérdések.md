- **TDD (Test-Driven Development):**  
  Egy szoftverfejlesztési módszertan, amely a tesztek írását helyezi előtérbe. A TDD folyamatában a fejlesztők először megírják a teszteseteket, majd a kódot addig fejlesztik, amíg a tesztek át nem mennek. A ciklus három lépésből áll:  
  1. **Red** – Írj egy tesztet, amely sikertelen.  
  2. **Green** – Írd meg a minimális kódot, amely a tesztet sikeressé teszi.  
  3. **Refactor** – Tisztítsd meg a kódot anélkül, hogy a teszt sikertelenné válna.

- **BDD (Behavior-Driven Development):**  
  A TDD-hez hasonló módszertan, amely a viselkedésre összpontosít. Az üzleti igények leírására érthető, emberi nyelven írt forgatókönyveket használ, amelyeket automatizált tesztekké alakítanak. Gyakran Gherkin nyelvet alkalmaz (Given-When-Then minták). Ez a megközelítés támogatja a jobb kommunikációt a fejlesztők, a tesztelők és az üzleti szereplők között.

- **BVA (Boundary Value Analysis):**  
  Egy fekete doboz tesztelési technika, amely a határértékek körüli hibák megtalálására összpontosít. A tesztekben a minimum, a maximum és a határérték közeli értékeket vizsgálják, mert ezeknél a kód gyakran hajlamos a hibákra.

- **3 értékű BVA:**  
  A Boundary Value Analysis egy kiterjesztett változata, amely a határérték alatti, határértéken lévő és határérték feletti értékeket vizsgálja. Például egy [1, 10] intervallumnál az értékek: 0 (alatta), 1 (határon) és 2 (felette). Ez biztosítja, hogy minden kritikus határ közelében lévő hibát felismerjenek.

- **JUnit5 paraméteres unit teszt:**  
  Egy JUnit5 funkció, amely lehetővé teszi ugyanazon teszteset különböző paraméterekkel történő futtatását. Ezáltal egyszerűbbé válik a kód több különböző bemeneti értékkel való tesztelése. Ehhez a `@ParameterizedTest` annotációt és olyan argumentumforrásokat használunk, mint például `@ValueSource`, `@CsvSource` vagy `@MethodSource`.

- **JUnit5 ismételt unit teszt:**  
  A JUnit5-ben a tesztek többszöri végrehajtása az `@RepeatedTest` annotációval lehetséges. Ez hasznos például véletlenszerű vagy nem determinisztikus viselkedés vizsgálatakor, illetve a kód stabilitásának tesztelésére. Az annotáció paraméterként megadhatja a futtatások számát, és minden ismétléshez hozzáférhet a sorszámhoz.

