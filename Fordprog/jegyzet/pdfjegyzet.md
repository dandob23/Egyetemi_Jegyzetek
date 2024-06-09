### Fogalomszótár

- **Zárt szóhalmaz**: Az összes szóból és az üres szóból álló halmaz.
- **Generatív nyelvtan (N, T, P, S)**: Egy formális nyelv definíciója.
  - **N**: Nemterminális jelek
  - **T**: Terminális jelek
  - **P**: Szabályok halmaza
  - **S**: Kezdő szimbólum
- **Chomsky-hierarchia**: Formális nyelvek hierarchiája négy típussal.
  - **0. típus**: Mondatszerkezetű nyelvek
  - **1. típus**: Kontextusfüggő nyelvek
  - **2. típus**: Kontextusfüggetlen nyelvek
  - **3. típus**: Reguláris nyelvek
- **Normálformák**: Szabványosított formák a nyelvtanokhoz.

### Chomsky-hierarchia

#### 0. típus: Mondatszerkezetű nyelvek
- Általános alakú szabályok

#### 1. típus: Kontextusfüggő nyelvek
- Minden szabályra igaz: \( u \rightarrow v \), ahol \( |u| \leq |v| \)

#### 2. típus: Kontextusfüggetlen nyelvek
- Szabályok alakja: \( A \rightarrow u \), ahol \( A \in N \), \( u \in (T \cup N)^* \)

#### 3. típus: Reguláris nyelvek
- Jobblineáris szabályok: \( A \rightarrow aB \) vagy \( A \rightarrow a \)
- Ballineáris szabályok: \( A \rightarrow Ba \) vagy \( A \rightarrow a \)

### Normálformák

#### Gyenge normálforma
- Szabályok legfeljebb két karakterből állnak: \( A \rightarrow aB \) vagy \( A \rightarrow a \)

#### Erős normálforma
- Szabályok alakja: \( A \rightarrow BC \) vagy \( A \rightarrow a \)

#### Lineáris nyelvek
- Szabályok alakja: \( A \rightarrow uBv \) vagy \( A \rightarrow u \)

### Kontextusfüggő nyelvek normálformái

#### Kuroda normálforma
1. Terminális normálforma
2. Hosszú szabályok kiküszöbölése

#### Penttonen normálforma
- Szabályok alakja: \( AB \rightarrow AC \), \( A \rightarrow a \)

### Kontextusfüggetlen nyelvek normálformái

#### Chomsky-féle normálforma
- Szabályok alakja: \( A \rightarrow BC \) vagy \( A \rightarrow a \)

#### Greibach-féle normálforma
- Szabályok alakja: \( A \rightarrow a\alpha \)

### Egyéb definíciók és tételek

- **Inesszó lemma**: Minden kontextusfüggetlen nyelv generálható kontextusfüggő nyelvtannal is.
- **Bábelrekurzió**: Kontextusfüggetlen nyelvtanban egy szabály alkalmazásának iteratív megismétlése.
- **Geffert-normálformák**: Egy adott nyelvhez tartozó normálformák kisebb szabályhalmaza.

### Fogalomszótár

- **T**: Lezárt, összes kinyerhető szó + λ (üres szó)
- **Generatív nyelvtan**: (N, T, P, S)
  - **N**: Nemterminális jelek
  - **T**: Terminális jelek
  - **P**: Szabályok
  - **S**: Start szimbólum
- **Chomsky hierarchia**
  - 0. típus: Mondatszerkezetű nyelvtanok
  - 1. típus: Monoton (szóhossznemcsökkentő) nyelvtanok
  - 2. típus: Környezetfüggetlen nyelvtanok
  - 3. típus: Reguláris nyelvtanok

### Szabályok, Tételek és Definíciók

#### Generatív Nyelvtan
- **Szabályok formája**: (N ∪ T)* N (N ∪ T)*
- **Példa**: u → v

#### Chomsky Hierarchia
- **0. típus**: Minden mondatszerkezetű nyelvtan.
- **1. típus**: Minden szabályra igaz, hogy u → v esetén |u| ≤ |v|, kivéve: S → ε, ha S nem jelenik meg a jobb oldalon.
- **2. típus**: Környezetfüggetlen nyelvtanok, ahol A → u, A ∈ N, u ∈ (T ∪ N)*.
- **2.5 típus**: Lineáris nyelvtanok, A → uBv vagy A → u'.
- **3. típus**: Reguláris nyelvtanok, A → uB vagy A → u', A ∈ N, u' ∈ T*.

#### Normálformák
- **Erős normálforma**: Nincs láncszabály, nincs üres szó.
- **Gyenge normálforma**: Jobb oldala max 2 hosszú.
- **Chomsky-féle normálforma**: A → BC vagy A → a.

#### Automatik
- **0. típus**: Turing gép (Determinista és nemdeterminista)
- **1. típus**: Lineárisan korlátozott automata (könyvszekrényautomata)
- **2. típus**: Veremautomata (Pushdown automata, determinista és nemdeterminista)
- **2.5 típus**: Egyszer forduló veremautomata (kétfejű véges automata)
- **3. típus**: Véges automata (Determinista és nemdeterminista)

#### Véges Automaták
- **Átmenetfüggvény**:
  - 1. Q x T → Q (Determinista)
  - 2. Q x T → 2^Q (Nemdeterminista)
  - 3. Q x (T ∪ {λ}) → 2^Q (Nemdeterminista üres szóval)
  
#### Veremautomaták
- **Átmenetfüggvény**: Q x (T ∪ {λ}) x V → 2^(Q x V*)
- **Elfogadási feltétel**:
  - Állapot alapján: q ∈ F
  - Üres veremmel: q, λ, λ
  
### Példák és Gyakorlatok

#### Példa 1: Véges automata működése
- Átmenetfüggvény és állapotok ábrázolása gráfként.

#### Példa 2: Veremautomata
- Konfigurációk, átmenetfüggvények definiálása, nyelv elfogadása.

### Különleges Automaták
- **Determinista Veremautomata**: Minden lehetséges konfiguráció esetén legfeljebb 1 átmenetet engedélyez.
- **Számlálónyelvek**: Veremben csak egyféle veremszimbólum van.
- **Egyszer fordulós veremautomata**: Lineáris nyelveket fogad el.

### Monoton Nyelvek
- **Monoton definíció**: |u| ≤ |v|
- **Normálformák**:
  - **Karada normálforma**: A → BC vagy A → B vagy A → a
  - **Reed-féle trükk**: AB → CD

### További Definíciók
- **Környezetfüggetlen nyelv**: Csak a terminális jelek számítanak.
- **Környezetfüggő nyelv**: Kontextus is fontos az átmenetekhez.

#### Automaták Típusai
0. **Típus:** Turing-gép (Determinista és nemdeterminista)
1. **Lineárisan Korlátozott Automata:** Átnyíró szalagos automata
2. **Veremautomata:** Fraktál automata (véges halmazok)
    - 2.5. **Egyszer Forduló Veremautomata:** Kétfejű véges automata
3. **Véges Automata:** Determinista és nemdeterminista

#### Véges Automaták
- **Komponensek:**
  - \( Q \): Állapotok halmaza
  - \( T \): Végső ábécé
  - \( q_0 \): Kezdőállapot
  - \( F \): Végállapotok halmaza
  - \( \delta \): Átmenetfüggvény
- **Átmenetfüggvény Lehetőségek:**
  - Determinista: \( \delta : Q \times T \to Q \)
  - Nemdeterminista: \( \delta : Q \times T \to 2^Q \)
  - Üres szavas átmenettel: \( \delta : Q \times (T \cup \{\lambda\}) \to 2^Q \)

#### Kétszalagos Veremautomaták
- Véges állapotvezérlővel rendelkeznek, és lineáris nyelveket fogadnak el.

#### Regularis Kifejezések
- Egyszerű szintaxisfák és azokat definiáló műveletek:
  - Unió, konkatenáció, Kleene-csillag (\(r^*\))

#### CYK Algoritmus (Chomsky-féle Normálforma)
- **Lépések:**
  1. Tábla elkészítése
  2. Szabályok alkalmazása a megfelelő helyeken

#### Automata és Grammatikák Kapcsolata
- **Reguláris Kifejezések és Véges Automaták:** Egy automata reguláris nyelvet fogad el, ha megfeleltethető egy reguláris kifejezésnek.
- **CYK Algoritmus:** Chomsky normálformájú nyelvek elemzése és szavak felismerése.
- **Early Algoritmus:** Nincs szükség Chomsky normálformára, általánosabb elemzési módszer.

#### Szintaxisfák és Gráfok
- **Egyszerű Gráfok:** Automata állapotai és átmenetei, valamint a szabályok ábrázolása.

#### Early Algoritmus (Környezetfüggetlen Nyelvek Elemzése)
- **Nem szükséges Chomsky normálforma:** Általánosabb elemzés
- **Pontosított szabályok:** Pl.: \( A \rightarrow BCD \)
- **Táblázat mérete:** \( n \times n \), ahol \( n \) a szó hossza

#### Lépések:
1. **Kezdő állapot:** \( (0,0) \) cella kitöltése a kezdőszimbólummal.
2. **Szabályok alkalmazása:** Minden nemterminálishoz tartozó szabály hozzáadása a megfelelő cellához.
3. **Kitöltés balról jobbra:** \( i \) növelése, \( j = i + 1 \).
4. **Szabálymásolás:** Pontmegtartással, terminálisok átlépésével.
5. **Cellahasonlítás:** Összehasonlítás és a megfelelő szabályok alkalmazása.

#### Példa:
- **Halmazok:** \(\{a, +, *, (, )\}\)
- **Szabályok:**
  - \( S \rightarrow S + A \)
  - \( A \rightarrow A * B \)
  - \( B \rightarrow (S)\)
  - \( A \rightarrow B \)
  - \( B \rightarrow a \)

### 12. Előadás: Fordítóprogramok

#### Hardverek
- **Szoftver értelmezése:** Magas szintű nyelv, formula szintézis

#### Compiler felépítése:
- **Forráskód program:** Input forráskód
- **Source handler:** Kezeli a forráskódot
- **Lista:** Kimeneti szimbólum lista
- **Compiler:** Fordítja a forráskódot
- **Code handler:** Kód kezelő
- **Támogató program:** A végső program

#### Elemzés:
- **Lexikális elemző:** Szimbólumsorozatok felismerése
- **Szintaktikai elemző:** Szimbólumok helyes szintaxis szerint
- **Szemantikai elemző:** Értelmezhetőség vizsgálata, pl. azonosítók összeadása

#### Szinonimák
- **Lexikális elemző:** Kódgenerálás
- **Szintaktikai elemző:** Szintaxisfa generálás
- **Szemantikai elemző:** Kódkapcsolatok

#### Szintaktikai Elemzők:
- **LL(k), LL(1):** Felülről lefelé
- **LR(k), LR(1):** Alulról felfelé

### Példák és Gyakorlatok
- **Automata működése:** Átmenetfüggvény és állapotok ábrázolása gráfként.
- **CYK Algoritmus:** Chomsky normálformájú nyelvek elemzése és szavak felismerése.
- **Early Algoritmus:** Nincs szükség Chomsky normálformára, általánosabb elemzési módszer.
