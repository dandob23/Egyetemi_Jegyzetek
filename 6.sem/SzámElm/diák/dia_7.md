### NP-be Tartozás Bizonyítéka

#### NP Osztályba Tartozó Nyelvek Példái

Gráfelméleti nyelvek, számelméleti problémák, egyenletek megoldásai, utazóügynök probléma stb.

#### NP-be Tartozás Bizonyítéka

A nyelvet eldöntő polinom időkorlátos nem-determinisztikus Turing-gép.

Ehelyett: egy egyszerűbb módszer, mely visszavezetést ad a determinisztikus eldöntésre.
Garantálni kell: a számítási fa polinom mélységű. Hogyan?

#### Tanú és Polinom Mélység

1. **A tanú legyen polinom hosszúságú!**
   - Ez garantálja, hogy a szaggatott vonal feletti részfa polinom mélységű.

2. **A tanút alkalmazó számítás legyen polinom időbonyolultságú!**
   - Ez garantálja, hogy a szaggatott vonal alatti minden egyes ág polinom hosszúságú.

#### Példa: Hamilton-kör

Egy gráf köre Hamilton-kör, ha azon a gráf minden csúcsa pontosan egyszer szerepel.
Hamilton-körrel rendelkező gráfok nyelve: "HAM"
"HAM" ∈ NP

1. **Tanú**: Egy \( x \) gráf tanúja a csúcsainak egy permutációja lesz.
   - \( y \) permutáció hossza polinomiális \( x \)-hez képest, mivel \(|y| \leq |x|\).

2. **Permutáció Ellenőrzése**:
   - Egymás utáni csúcsait él köti-e össze?
   - (Polinom időkorlátos determinisztikus Turing-géppel eldönthető)

#### Tanú Kritériumai

1. **Polinom Hosszúságú Tanú**:
   - \(|y|\) az \(|x|\)-nek legyen polinomja!
   - \(|y| \leq |x| \cdot c\)
   - \(|y| \leq |x|^c\)
   - \(|y| \leq c^{|x|}\)

2. **Determinista Polinom Időbonyolultságú Számítás**:
   - Inputja: \( (x, y) \)
   - Determinisztikus
   - Polinom időbonyolultságú

#### Tétel

Legyen \( L \) egy nyelv.
\[ L \in NP \]
ha és csak ha
\[ \exists c > 0 \text{ és } \exists L' \in P, \text{ hogy } \forall x \text{ szó esetén: } x \in L \iff \exists y \text{ szó, hogy } |y| \leq |x|^c \text{ és } (x, y) \in L' \]

#### Példa: Gráf Színezése

Egy gráf csúcsai \( k \geq 1 \) színnel színezhetőek-e úgy, hogy minden éle két különböző színű csúcsot köt össze?
\( k \)-színnel színezhető gráfok nyelve: \( k\)-SZIN
3-SZIN ∈ NP

1. **Tanú**: Egy \( x \) gráf tanúja a gráf egy színezése lesz.
   - Egy ilyen színezés leírható max. \( 2 \cdot |x| \) db. bináris számjeggyel, azaz \(|y| \leq 2 \cdot |x|\).

2. **Színezés Ellenőrzése**:
   - Minden él különböző színű csúcsokat köt-e össze?
   - (Polinom időkorlátos determinisztikus Turing-géppel eldönthető)

#### Példa: Egész Faktorizáció

Kriptográfiai protokollok biztonságossága alapszik ezen a nehéz problémán.
Pl. RSA: 232-jegyű számok egész faktorizációja.

Adott egy \( x \) egész szám és egy másik \( m \) egész szám úgy, hogy \( 1 < m < x \).

Vajon létezik olyan \( y \) szám, hogy \( 1 < y \leq m \) és \( y \) osztja \( x \)-et?

1. **Tanú**: Egy \( x \) egész szám tanúja egy \( y \) egész szám lesz.
   - Mivel \( 1 < m < x \) és \( 1 < y \leq m \), így \( y < x \).
   - Ezért \(|y| \leq |x|\).

2. **Ellenőrzés**:
   - \( y \) osztja-e \( x \)-et?
   - (Akár az általános iskolában tanult algoritmussal)
   - (Polinom időkorlátos determinisztikus Turing-géppel eldönthető)