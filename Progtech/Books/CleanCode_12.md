### 12. Fejezet: Láthatóság

#### Bevezetés
A láthatóság kérdése kulcsfontosságú a tiszta kód szempontjából. Az adatok és a kód elemeinek elérhetősége nagyban befolyásolja a kód olvashatóságát, karbantarthatóságát és megbízhatóságát.

#### Kód láthatóságának fontossága
- **Encapsulation (Enkapszuláció):** Az objektumorientált programozás alapelve, amely szerint az adatokhoz való hozzáférést korlátozni kell, és csak meghatározott módon (metódusokon keresztül) lehet elérni őket.
- **Adat elrejtése:** Az adatokat priváttá tesszük, hogy megvédjük azokat a közvetlen módosítástól és biztosítsuk az adat integritását.

#### Láthatósági szintek
- **Private (Privát):** Az osztályon belül érhetők el. Ez a legszigorúbb láthatósági szint, amely biztosítja, hogy az adatok csak az adott osztályon belül módosíthatók.
- **Protected (Védett):** Az adott osztályon és annak leszármazottain belül érhetők el.
- **Public (Nyilvános):** Bárki által elérhetőek. Ez a legkevésbé szigorú szint, amely lehetővé teszi, hogy az adatokat bárki módosíthassa.
- **Package-private (Csomag-private):** Az adott csomagon belül érhetők el. Ez a Java nyelvre jellemző láthatósági szint.

#### Metódusok és láthatóság
- **Accessor (Hozzáférő) metódusok:** Olyan metódusok, amelyek lehetővé teszik a privát adatok elérését. Például getter és setter metódusok.
- **Mutator (Módosító) metódusok:** Olyan metódusok, amelyek lehetővé teszik a privát adatok módosítását.

#### Láthatóság és tesztelhetőség
- **Tesztelhetőség növelése:** A láthatóság helyes kezelése növeli a kód tesztelhetőségét. A jól enkapszulált kód könnyebben izolálható és tesztelhető.
- **Tesztelési stratégiák:** Biztosítani kell, hogy a tesztkód is hozzáférjen a szükséges adatokhoz anélkül, hogy megsértené az enkapszuláció elveit.

#### Információ elrejtése
- **Minimális publikus interfész:** Az osztályok publikus interfészét a lehető legkisebbre kell korlátozni. Csak azokat a metódusokat tegyük publikussá, amelyekre valóban szükség van kívülről.
- **Implementáció elrejtése:** Az osztály belső működésének részleteit rejtsük el, hogy a változtatások ne befolyásolják a külső kódot.

#### Példák és gyakorlatok
- **Példák az enkapszulációra:** Konkrét példák arra, hogyan lehet helyesen alkalmazni az enkapszulációt és a láthatósági szinteket.
- **Gyakorlati tippek:** Tippek és trükkök a helyes láthatóság kezelésére a kódban.

#### Összefoglalás
A láthatóság helyes kezelése kulcsfontosságú a tiszta kód szempontjából. Az enkapszuláció és az adatok megfelelő elrejtése növeli a kód olvashatóságát, karbantarthatóságát és megbízhatóságát. A publikus interfész minimalizálása és a belső részletek elrejtése alapvető fontosságú az objektumorientált programozásban.

Ezek az alapvető pontok és fogalmak, amelyeket a 12. fejezet tárgyal. Ha további részletekre vagy példákra van szükséged, szívesen segítek!