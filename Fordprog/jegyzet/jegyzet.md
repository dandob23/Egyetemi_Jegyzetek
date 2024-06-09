### Fogalmak és Definíciók

#### Generatív Nyelvtan
- **N**: Nemterminális jelek – a nyelvtan szimbólumai, amelyek további szimbólumokra bonthatók.
- **T**: Terminális jelek – a nyelv legkisebb egységei, amelyeket nem lehet tovább bontani.
- **P**: Szabályok halmaza – azok a szabályok, amelyek meghatározzák, hogyan alakulnak át a nemterminális jelek.
- **S**: Kezdő szimbólum – a nyelvtan kiindulási pontja, amiből a mondatok generálhatók.
- **Zárt szóhalmaz**: Az összes szóból és az üres szóból álló halmaz.
- **Üresszó lemma**: Az állítás, miszerint egy kontextusfüggetlen nyelv csak akkor tartalmazza az üres szót, ha a kezdő szimbólum levezeti az üres szót.

#### Chomsky Hierarchia
- **0. típus**: Mondatszerkezetű nyelvtanok – minden szabályra igaz, hogy bármelyik szimbólum helyettesíthető.
- **1. típus**: Monoton és környezetfüggő nyelvek – a szabályok jobboldala hosszabb vagy egyenlő hosszúságú, mint a baloldala.
- **2. típus**: Környezetfüggetlen nyelvek – szabályok alakja: \( A \rightarrow u \), ahol \( A \in N \), \( u \in (T \cup N)^* \).
- **3. típus**: Reguláris nyelvek – szabályok alakja: \( A \rightarrow aB \) vagy \( A \rightarrow a \) (jobblineáris) és \( A \rightarrow Ba \) vagy \( A \rightarrow a \) (ballineáris).

#### Normálformák
- **Reguláris nyelvek**:
  - **Gyenge normálforma**: Szabályok legfeljebb két karakterből állnak: \( A \rightarrow aB \) vagy \( A \rightarrow a \).
  - **Erős normálforma**: Szabályok alakja: \( A \rightarrow BC \) vagy \( A \rightarrow a \).
- **Lineáris nyelvek**: Szabályok alakja: \( A \rightarrow uBv \) vagy \( A \rightarrow u \).
- **Környezetfüggetlen nyelvek**:
  - **Chomsky-féle normálforma**: \( A \rightarrow BC \) vagy \( A \rightarrow a \).
  - **Greibach-féle normálforma**: \( A \rightarrow a\alpha \).
- **Környezetfüggő nyelvek**:
  - **Kuroda normálforma**: Az összes kontextusfüggő nyelvtan átalakítható erre a formára.
  - **Penttonen-féle normálforma**: Szabályok alakja: \( AB \rightarrow AC \), \( A \rightarrow a \).
  - **Geffert-normálformák**: Speciális kontextusfüggő nyelvtan normálformák.

#### Egyéb Normálformák
- **Nulladik típushoz normálformák**: Speciális normálformák a 0. típusú nyelvekhez.
- **Révész-féle trükk**: Egy egyszerűsítési módszer a nyelvtanokban.
- **Révész-féle egyoldali normálforma**: Egy különleges normálforma a nyelvtanokban.

#### Reguláris Kifejezések
- **Kleene-csillag (\(r^*\))**: Lehetővé teszi egy kifejezés tetszőleges számú ismétlését.
- **Reguláris kifejezések ekvivalenciái**:
  - **Asszociatív**: \( (r + s) + t = r + (s + t) \).
  - **Kommutatív**: \( r + s = s + r \).
- **Unió normálforma**: Egy speciális forma, amelyben unió műveletek szerepelnek.
- **Uniomentes nyelvek**: Nyelvek, amelyek nem használnak unió műveleteket.

### Automaták

#### Típusok
- **0. típus**: Turing gép – minden számítható feladat megoldására képes, determinisztikus és nemdeterminista változata is van.
- **1. típus**: Lineárisan korlátozott automata – egy Turing gép, amelynek szalagja csak egy előre meghatározott hosszúságú lehet.
- **2. típus**: Veremautomata – olyan automata, amely egy veremet használ, determinisztikus és nemdeterminista változata is van.
  - **Egyszer forduló veremautomata**: Kétfejű véges automata, amely csak egyszer mehet végig a veremen.
- **3. típus**: Véges automaták – állapotok és átmenetek véges halmazával dolgoznak, determinisztikus és nemdeterminista változata is van.
  - **2 fejű véges automaták**: Olyan véges automaták, amelyek két olvasó fejjel rendelkeznek.

#### Speciális Automaták
- **Determinista veremautomata**: Egy veremautomata, amely minden konfigurációban legfeljebb egy átmenetet engedélyez.
- **Számlálónyelvek**: Veremben csak egyféle veremszimbólum van.
- **Egyszer fordulós veremautomata**: Lineáris nyelveket fogad el.
- **Fraktál automata**: Speciális véges automata.

#### Egyéb Definíciók
- **Cayley táblázat**: Véges csoportok műveleteinek ábrázolására szolgál.
- **S(delta) függvény**: Az átmenetfüggvény speciális formája.

### Algoritmusok és Lemma

#### CYK Algoritmus
- **Környezetfüggetlen nyelvek elemzése**: Algoritmus a szavak felismerésére Chomsky normálformájú nyelvekben.
- **Példa**: A szó "aabb" felismerése egy kontextusfüggetlen nyelvtan segítségével.

#### Early Algoritmus
- **Környezetfüggetlen nyelvek elemzése**: Nincs szükség Chomsky normálformára, általánosabb elemzési módszer.

#### Szintaxis Gráf
- Az automata állapotainak és átmeneteinek ábrázolása gráfként.
- **Lemma**: Bizonyítja, hogy egy adott nyelv szabályai szerint generálható.

### Fordítóprogramok

#### Felépítés
- **Forráskód -> Source handler -> Lista**
  - **Compiler**
  - **Code handler -> Tárgynyelvű program**
- **Compiler Komponensei**
  - **Lexikális elemző**: Szimbólumsorozatok felismerése.
  - **Szintaktikai elemző**: Szimbólumok helyes szintaxis szerint.
  - **Szemantikai elemző**: Értelmezhetőség vizsgálata, például azonosítók összeadása.

### Egyéb Témakörök
- **Formula vezérlésű gép**: Hardverek és szoftverek kombinációja magas szintű nyelvek értelmezésére.
- **Interpreter**: Program, amely egy magas szintű nyelv utasításait közvetlenül végrehajtja.
- **Hazug paradoxon**: Logikai paradoxon, amely egy állítás önellentmondását fogalmazza meg.
- **Halting-probléma**: Az a kérdés, hogy egy adott program megáll-e véges időn belül egy adott bemenetre.

Remélem, hogy ezek a magyarázatok segítenek jobban megérteni a fogalmakat és azok használatát. Ha további részletekre van szükség, kérlek jelezd!