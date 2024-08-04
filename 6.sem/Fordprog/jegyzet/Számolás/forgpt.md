### Használati Utasítás a Feladatok Megoldásához

Ez az utasítás segít a különböző formális nyelvekhez kapcsolódó feladatok megoldásában, az automata és nyelvtani átalakításokban, valamint az algoritmusok alkalmazásában. Az alábbiakban a lépések és példák részletesen le vannak írva.

#### CYK Algoritmus

1. **Chomsky-féle Normálforma:**
   - **Szabályok:** `A -> BC` vagy `A -> a`
   - Az összes szabály átalakítása Chomsky-féle normálformába.
   - **Példa:**
     - Eredeti szabály: `S -> aB | aA | b`
     - Chomsky normálformában: `S -> AB | BC, A -> a, B -> b`

2. **CYK Tábla Kitöltése:**
   - **0. lépés:** Rajz elkészítése.
   - **1. lépés:** Az első sorban melyik szabályból vezethető le az adott karakter.
   - **2. lépés:** A következő sorok kitöltése párokban.
   - **Példa:** `w = aaabbaa`
     - Első sor: `a -> A`
     - Második sor: `AA -> B`
     - Harmadik sor: `BB -> S`

3. **Eredmény Ellenőrzése:**
   - Ha a tábla legfelső négyzete tartalmazza a kezdő szimbólumot, akkor a szó levezethető a nyelvtanból.
   - **Példa:** `S` a legfelső négyzetben.

#### Early Algoritmus

1. **Tábla Mérete:** n+1 oszlop, ahol n a szó hossza.
2. **Szabályok:**
   - A -> u.v
   - Minden szabály alkalmazása a megfelelő helyeken.
3. **Tábla Kitöltése:**
   - **0. lépés:** Minden halmaz elkészítése.
   - **1. lépés:** Kezdőszimbólum felvétele a bal oldali cellába.
   - **2. lépés:** Pontozott szabályok kitöltése.
   - **Példa:**
     - Szabály: `S -> aSb`
     - Tábla kitöltése a megfelelő szabályokkal és pontozott átmenetekkel.

#### Automata és Grammatikák

1. **Reguláris Nyelvtanok és Véges Automaták Kapcsolata:**
   - Véges automaták állapotainak és átmeneteinek ábrázolása.
   - **Példa:**
     - Nyelvtan: `S -> aS | b`
     - Automata: Állapotdiagram, ahol az átmenetek megfelelnek a nyelvtani szabályoknak.

2. **Veremautomaták és Környezetfüggetlen Nyelvek:**
   - Veremautomata használata a környezetfüggetlen nyelvek elemzésére.
   - **Példa:**
     - Nyelvtan: `S -> aSb | ε`
     - Veremautomata konfiguráció: Állapotok és verem tartalmának ábrázolása.

#### Normálformák

1. **Reguláris Nyelvek Normálformái:**
   - **Gyenge normálforma:** `A -> aB` vagy `A -> a`.
   - **Erős normálforma:** `A -> BC` vagy `A -> a`.
   - **Példa:**
     - Eredeti szabály: `S -> aB`
     - Gyenge normálformában: `S -> aB`

2. **Környezetfüggetlen Nyelvek Normálformái:**
   - **Chomsky-féle normálforma:** `A -> BC` vagy `A -> a`.
   - **Greibach-féle normálforma:** `A -> aα`.
   - **Példa:**
     - Eredeti szabály: `S -> aS | b`
     - Greibach normálformában: `S -> aS'`

3. **Környezetfüggő Nyelvek Normálformái:**
   - **Kuroda normálforma:** `AB -> CD`, `A -> a`.
   - **Penttonen-féle normálforma:** `AB -> AC`, `A -> a`.
   - **Példa:**
     - Eredeti szabály: `A -> BCD`
     - Kuroda normálformában: `AB -> CD`

#### További Példák és Gyakorlatok

1. **Veremautomata Konfiguráció:**
   - Példa: `(S, 1 | 1aa11aabb)`
   - Állapotok és verem tartalmának ábrázolása.

2. **Véges Automaták és Reguláris Nyelvek:**
   - Példa: `A -> aB`, `B -> bA`
   - Véges automata állapotdiagramjának elkészítése.

Ez a használati utasítás segít a formális nyelvekhez kapcsolódó feladatok megoldásában az algoritmusok és automaták segítségével. Ha specifikus feladatot adsz, ezt az utasítást követve pontosan megoldom a feladatot.