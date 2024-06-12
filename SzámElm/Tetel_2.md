### 2. Algoritmus modellek. Egyszalagos determinisztikus Turing-gép felépítése és definíciója, kapcsolódó fogalmak: konfiguráció, megállás, elfogadás/elutasítás, időkorlát. Eldöntött/felismert nyelv.

#### Algoritmus modellek

- **Turing-gép:** Egy elméleti számítási modell, amelyet Alan Turing javasolt. Alapvetően egy végtelen szalagon működik, amelyre írni és olvasni tud, és amelyen egy olvasó-író fej mozog.
- **RAM gépek:** Egy elméleti modell, amely a valódi számítógépekhez hasonlóan központi processzort és véges memóriát használ.
- **Lambda-kalkulus:** Egy formális rendszer a funkcionális programozás és a számításelmélet alapjainak leírására.
- **Markov algoritmus:** Egy elméleti számítási modell, amely szabályokat használ a sztringek átírására.

#### Egyszalagos determinisztikus Turing-gép felépítése és definíciója

- **Turing-gép elemei:**
  - **Szalag (\(\Sigma\))**: Végtelen hosszúságú, cellákra osztott szalag, amelyre jelek (betűk) írhatók.
  - **Fej**: A szalag egy celláját olvassa vagy írja, és mozoghat balra vagy jobbra.
  - **Állapotok halmaza (\(Q\))**: A gép belső állapotainak véges halmaza.
  - **Kezdőállapot (\(q_0\))**: A Turing-gép kezdeti állapota.
  - **Elfogadó állapotok halmaza (\(F\))**: Azok az állapotok, amelyekben a gép elfogad egy bemenetet.
  - **Állapotátmenet függvény (\(\delta\))**: Meghatározza, hogyan változik az állapot, a szalagra írandó jel és a fej mozgásának iránya egy adott állapot és szalagjel alapján.

- **Turing-gép definíciója:**
  - \(\Sigma\): Szalagjelek halmaza
  - \(Q\): Állapotok halmaza
  - \(q_0\): Kezdőállapot
  - \(F\): Elfogadó állapotok halmaza
  - \(\delta\): Állapotátmenetfüggvény

#### Kapcsolódó fogalmak

- **Konfiguráció:** A Turing-gép aktuális állapota, a szalag tartalma és a fej pozíciója.
  - Jelölése: \( (q, \alpha a \beta) \), ahol \(q\) az aktuális állapot, \(\alpha\) és \(\beta\) a szalag bal és jobb oldala, \(a\) pedig az aktuálisan olvasott betű.
  
- **Megállási konfiguráció:** Olyan konfiguráció, amelyben a Turing-gép nem tud továbblépni.
  - Az állapotátmenetfüggvény nincs értelmezve az aktuális állapoton és szalagon lévő jelnél, vagy az aktuális állapot az elfogadó állapotok halmazában van.

- **Elfogadás/elutasítás:** 
  - **Elfogadás:** Ha a Turing-gép eljut egy elfogadó állapotba, akkor elfogadja a bemenetet.
  - **Elutasítás:** Ha a Turing-gép megállás nélkül fut, vagy elutasító állapotba kerül, akkor elutasítja a bemenetet.

- **Időkorlát:** Az a maximális lépésszám, amelyet a Turing-gép végrehajt egy adott bemeneten.
  - Időbonyolultság: Az adott bemenetre a Turing-gép által végrehajtott lépések száma.
  - Időkorlátos Turing-gép: Olyan Turing-gép, amely egy polinom időbonyolultsági korlátot nem lép túl.

#### Eldöntött/felismert nyelv

- **Eldöntött nyelv:** 
  - Egy nyelv akkor eldöntött, ha létezik olyan Turing-gép, amely minden bemenetre megáll, és eldönti, hogy a bemenet a nyelv eleme-e.
  - Azaz minden \(w\) bemenetre \(M\) elfogadja vagy elutasítja \(w\)-t.

- **Felismert nyelv:**
  - Egy nyelv akkor felismert, ha létezik olyan Turing-gép, amely minden, a nyelvhez tartozó bemenetet elfogad, de a nyelvhez nem tartozó bemenetek esetén nem biztos, hogy megáll.
  - Azaz minden \(w \in L\) bemenetre \(M\) elfogadja \(w\)-t, de ha \(w \notin L\), akkor \(M\) nem feltétlenül áll meg.

Ezek az alapvető fogalmak és definíciók segítenek megérteni a Turing-gépek működését és a kapcsolódó számításelméleti koncepciókat.