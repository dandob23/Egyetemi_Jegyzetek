Itt található a PowerPoint prezentáció alapján készült felsorolásos jegyzet a teljességről:

### Teljesség

#### Teljes nyelvek

- Adott nyelvosztályra nézve teljes nyelvek.
- Magukban hordozzák az adott osztályba tartozó összes nyelv eldöntésének nehézségét.
- Pontosabban be lehet „lőni” az adott nyelv eldöntésének bonyolultságát.
- Segítségükkel könnyű bizonyítani, ha két osztály egybeesik.

#### Visszavezetés (Karp-redukció)

- **Definíció:** Az \( L_1 \) nyelv visszavezethető az \( L_2 \) nyelvre:
  - Létezik polinom időkorlátos determinisztikus Turing-géppel kiszámítható függvény \( f \), hogy minden \( x \) szóra:
    - \( x \in L_1 \iff f(x) \in L_2 \)
- **Jelölés:** \( L_1 \leq_p L_2 \)
- **Tranzitivitás:** Ha \( L_1 \leq_p L_2 \) és \( L_2 \leq_p L_3 \), akkor \( L_1 \leq_p L_3 \).

#### Tartalmazás = Felső korlát

- Legyen \( C \) egy nyelvosztály és \( L \) egy nyelv.
- Ha \( L \in C \), akkor ez \( L \) eldöntésének bonyolultságára felső korlátot ad.

#### Nehézség = Alsó korlát

- Az \( L \) nyelv \( C \)-nehéz, ha:
  - Minden \( L' \in C \) esetén \( L' \leq_p L \).

#### Teljesség = Pontos illeszkedés

- Az \( L \) nyelv \( C \)-teljes, ha:
  - \( L \in C \)
  - \( L \) \( C \)-nehéz.
- Eldöntésének bonyolultsága pontosan \( C \).

#### Nehézség és teljesség „öröklődése”

- Ha találunk egy \( C \)-teljes nyelvet, hogyan kereshetünk több \( C \)-teljes nyelvet?
  - Ha \( L_1 \) \( C \)-teljes és \( L_1 \leq_p L_2 \), akkor \( L_2 \) \( C \)-nehéz.
  - Ha \( L_2 \) \( C \)-nehéz és \( L_2 \in C \), akkor \( L_2 \) \( C \)-teljes.

#### \( NP \)-teljes nyelvek keresése

- Találni kell egy \( NP \)-teljes nyelvet (pl. SAT).
- Egy nyelv \( NP \)-teljessége belátható:
  - **\( NP \)-beliség:** Tanú-tétel segítségével.
  - **Nehézség:** Visszavezetés konstruálásával.

#### \( NP \)-teljes nyelvek fontossága

- Ha egy \( NP \)-teljes nyelvről sikerülne belátni, hogy \( P \)-ben van:
  - \( P = NP \)
  - Minden \( NP \)-beli nyelv polinom időben eldönthető.
  - Ez a számításelmélet központi kérdése!

Ez a jegyzet segít áttekinteni a teljesség fogalmát és annak jelentőségét a számításelméletben, különös tekintettel az \( NP \)-teljes nyelvekre és azok összefüggéseire.