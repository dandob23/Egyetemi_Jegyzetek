### 7. Fejezet: Hibakezelés (Error Handling) összefoglalása

A hibakezelés a kód minőségének és megbízhatóságának kulcsfontosságú eleme. Ebben a fejezetben Robert C. Martin részletesen tárgyalja a hibakezelés alapelveit és legjobb gyakorlatait, amelyek segítenek tiszta és karbantartható kódot írni.

#### Alapelvek és legjobb gyakorlatok

1. **Kivételkezelés használata**
   - A kivételek (exceptions) használata előnyösebb a hibakódok (error codes) helyett, mivel azok elkülönítik a hibakezelést a normál működéstől.
   - A kivételek lehetővé teszik, hogy a hibák kezelése külön történjen, így a kód olvashatóbbá és karbantarthatóbbá válik.

2. **Kivétel dobása és kezelése**
   - **Kivétel dobása (Throwing Exceptions):**
     - Kivételt dobni akkor érdemes, amikor egy függvény vagy metódus nem tudja folytatni a normál működést.
     - Fontos, hogy a kivételek legyenek specifikusak és informatívak. Például, használjunk saját kivételosztályokat az általános `Exception` osztály helyett.
   - **Kivétel kezelése (Catching Exceptions):**
     - A kivételek kezelésekor figyeljünk arra, hogy ne nyeljük el a kivételeket (ne legyen üres catch blokk).
     - Csak ott kezeljük a kivételeket, ahol valóban értelme van, és ahol képesek vagyunk megfelelően reagálni a hibára.

3. **Kivétel típusok és hierarchia**
   - Használjunk megfelelően elnevezett kivételosztályokat, amelyek tükrözik a hiba természetét.
   - Alakítsunk ki hierarchiát a kivételosztályok között, hogy a különböző hibák kezelése egyszerűbbé váljon.

4. **A hibakezelés elválasztása a fő logikától**
   - A hibakezelést különítsük el a normál működési logikától, hogy a kód olvashatóbb és karbantarthatóbb legyen.
   - A `try-catch` blokkok használatát minimalizáljuk és azok tartalmát tegyük érthetővé.

5. **Ne használjuk kivételeket normál folyamatok kezelésére**
   - A kivételeket rendkívüli helyzetek kezelésére használjuk, ne a normál folyamatok irányítására.
   - A kivételek dobása és kezelése költséges művelet, ezért kerülni kell a túlzott használatukat.

6. **Források felszabadítása hibakezelés során**
   - Biztosítsuk, hogy a források (pl. fájlok, hálózati kapcsolatok) megfelelően fel legyenek szabadítva, még akkor is, ha kivétel keletkezik.
   - Használjunk `finally` blokkot vagy automatikus forráskezelést (`try-with-resources` Java-ban) a források biztonságos felszabadítására.

7. **Egyértelmű és informatív hibaüzenetek**
   - A kivételeknek tartalmazniuk kell részletes és hasznos információkat a hibáról, hogy könnyebb legyen a hibakeresés és a javítás.
   - Kerüljük az általános és semmitmondó hibaüzeneteket.

#### Példák és kódminták

##### Kivétel dobása:

```java
public void readFile(String fileName) throws FileNotFoundException {
    File file = new File(fileName);
    if (!file.exists()) {
        throw new FileNotFoundException("File not found: " + fileName);
    }
    // file reading logic
}
```

##### Kivétel kezelése:

```java
public void processFile(String fileName) {
    try {
        readFile(fileName);
    } catch (FileNotFoundException e) {
        System.err.println(e.getMessage());
        // handle the error, maybe log it and inform the user
    }
}
```

##### Saját kivételosztály létrehozása:

```java
public class InvalidUserInputException extends Exception {
    public InvalidUserInputException(String message) {
        super(message);
    }
}
```

##### Kivétel dobása és kezelése saját kivételosztállyal:

```java
public void processUserInput(String input) throws InvalidUserInputException {
    if (input == null || input.isEmpty()) {
        throw new InvalidUserInputException("User input cannot be null or empty");
    }
    // process the input
}

public void handleUserInput(String input) {
    try {
        processUserInput(input);
    } catch (InvalidUserInputException e) {
        System.err.println(e.getMessage());
        // handle the error, maybe log it and inform the user
    }
}
```

#### Összegzés

A 7. fejezet hangsúlyozza, hogy a hibakezelésnek mindig célzott, informatív és a normál működéstől elkülönítettnek kell lennie. A megfelelő kivételkezelés használata elengedhetetlen a tiszta, olvasható és karbantartható kód megírásához. A fent leírt alapelvek és gyakorlatok segítenek abban, hogy hatékonyan és biztonságosan kezeljük a kódban felmerülő hibákat.