Itt található a PowerPoint prezentáció alapján készült felsorolásos jegyzet a bonyolultsági osztályok összefüggéseiről:

### Eldönthető nyelvek és bonyolultsági osztályok közötti összefüggések

#### Eldönthetőség

- **Kérdés:** Van olyan probléma, amely algoritmussal nem megoldható?
- Van olyan nyelv, amely Turing-géppel nem eldönthető?
  - **Válasz:** Igen, van.
- **Megállási probléma:**
  - Univerzális Turing-gép kérdése:
    - Van-e olyan Turing-gép, amely meg tudja mondani, hogy egy adott Turing-gép megáll-e egy adott inputon?
    - **Válasz:** Nincs ilyen Turing-gép, ezért a megállási probléma eldönthetetlen.

#### Post megfeleltetési problémája

- Adott egy min. 2 elemű ábécé: \( \Sigma \)
- Adott 2 véges sorozat \( \Sigma^* \) szavaiból: \( \alpha_1, \alpha_2, ..., \alpha_m \) és \( \beta_1, \beta_2, ..., \beta_n \)
- **Kérdés:** Összefűzhetőek-e a két sorozat szavai úgy, hogy összeolvasva ugyanazt a szót kapjuk? Azaz van-e olyan \( i_1, i_2, ..., i_k \) index sorozat, hogy \( \alpha_{i_1}\alpha_{i_2}...\alpha_{i_k} = \beta_{j_1}\beta_{j_2}...\beta_{j_k} \)?
  - **Válasz:** Ez a probléma eldönthetetlen.

#### Bonyolultsági osztályok összefüggései

- Az eldönthető nyelveket idő- és tárbonyolultsági osztályokba soroltuk.
- Egy Turing-gép \( t(n) \) lépésben max. \( t(n) \) szalagcellát használhat.

#### NP és P relációja

- Egy \( t(n) \) időkorlátos nemdeterminisztikus Turing-gépet szimuláljunk egy determinisztikus Turing-géppel.
  - Számítási fa egy ágának végigszámolása: \( t(n) \) lépés, max. \( t(n) \) cella.
  - Visszalép a fa gyökerébe, és ugyanazt a szalagot használja újra.
  - Mindvégig \( t(n) \) cellát használ.
- **Következmény:** \( NP \subseteq P \)

#### P és PSPACE relációja

- Tár-idő tétel: \( P \subseteq PSPACE \)

#### NP és EXPTIME relációja

- Mivel \( P \subseteq EXPTIME \), ezért \( NP \subseteq EXPTIME \).

#### NSPACE és PSPACE relációja

- Minden \( s(n) \) tárkorlátos nemdeterminisztikus Turing-gép szimulálható \( O(s^2(n)) \) tárkorlátos determinisztikus Turing-géppel.
  - **Következmény:** \( NSPACE(s(n)) \subseteq PSPACE(s(n)) \)
  - \( NPSPACE = PSPACE \)

#### Bonyolultsági osztályok „térképe”

- Vizualizálás a különböző bonyolultsági osztályok relációiról és összefüggéseiről.

Ez a jegyzet segít áttekinteni az eldönthetőség kérdését és a különböző bonyolultsági osztályok közötti összefüggéseket.