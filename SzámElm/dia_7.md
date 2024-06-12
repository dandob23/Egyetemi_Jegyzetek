Itt található a PowerPoint prezentáció alapján készült felsorolásos jegyzet az NP osztályról:

### NP osztály

#### Általános fogalmak

- **NP osztály:** Gráfelméleti nyelvek, számelméleti problémák, egyenletek megoldásai, utazóügynök probléma stb.
- Az NP-be tartozás bizonyítéka: A nyelvet eldöntő polinom időkorlátos nemdeterminisztikus Turing-gép.
- Alternatív módszer: Egy egyszerűbb módszer, amely visszavezetést ad a determinisztikus eldöntésre.

#### Tanú alkalmazása

- A nemdeterminisztikus eldöntési problémát kétfelé "hasítjuk":
  - A tanú legyen polinom hosszúságú.
  - A tanút alkalmazó számítás legyen polinom időbonyolultságú.

#### NP-beli nyelvek: Hamilton-kört tartalmazó gráfok

- **Hamilton-kör:** Egy gráf köre Hamilton-kör, ha a gráf minden csúcsa pontosan egyszer szerepel.
- **Nyelv:** Hamilton-körrel rendelkező gráfok nyelve.
- **Tanú:** A gráf csúcsainak egy permutációja.
- **Permutáció ellenőrzése:** Egymás utáni csúcsait él köti-e össze? (Polinom időkorlátos determinisztikus Turing-géppel eldönthető.)

#### Tanú-tétel összeállítása

- **1. kritérium:** A tanú legyen polinom hosszúságú.
  - \( t(n) \) egy polinomja.
- **2. kritérium:** A tanút alkalmazó számítás legyen determinisztikus és polinom időbonyolultságú.
  - Létezik olyan \( L \) nyelv, amely \( \{(x, y) | y \text{ tanú, hogy } M \text{ elfogadja } x\} \) szópárokból áll, és eldönthető determinisztikus polinom időkorlátos Turing-géppel.

#### Tanú-tétel

- **Tétel:** Legyen \( L \) egy nyelv.
  - \( L \in NP \), ha létezik olyan polinom \( p \) és determinisztikus Turing-gép \( M \), hogy:
    - \( x \in L \) esetén létezik olyan \( y \), hogy \( |y| \leq p(|x|) \) és \( M \) elfogadja \( (x, y) \)-t.
    - \( x \notin L \) esetén minden \( y \)-ra \( M \) elutasítja \( (x, y) \)-t.

#### NP-beli nyelvek példái

- **3 színnel színezhető gráfok:**
  - **Nyelv:** Egy gráf csúcsai 3 színnel színezhetőek-e úgy, hogy minden éle két különböző színű csúcsot köt össze?
  - **Tanú:** A gráf egy színezése.
  - **Ellenőrzés:** Minden él különböző színű csúcsokat köt-e össze? (Polinom időkorlátos determinisztikus Turing-géppel eldönthető.)

- **Egész faktorizáció:**
  - **Probléma:** Adott egy \( N \) egész szám és egy \( k \) egész szám úgy, hogy \( k < N \). Vajon létezik olyan \( m \) szám, hogy \( k \cdot m = N \)?
  - **Tanú:** Egy \( m \) egész szám.
  - **Ellenőrzés:** \( m \) osztja-e \( N \)-t? (Polinom időkorlátos determinisztikus Turing-géppel eldönthető.)

Ez a jegyzet segít áttekinteni az NP osztályba tartozó nyelveket és a hozzájuk kapcsolódó fogalmakat.