Itt található a PowerPoint prezentáció alapján készült felsorolásos jegyzet:

### Algoritmus modellek és Turing-gép

#### Algoritmus-fogalom

- Mi az az algoritmus?
- Mik az elemi lépések?
- Mi az idő- és tárbonyolultság?

#### Algoritmus modellek

- Turing-gép
- Rekurzív függvények
- Lambda-kalkulus
- Markov algoritmus

#### Alan Turing (1912-1954)

- II. világháború alatt: Enigma feltörése
- 1945-től: Digitális számítógép – "Mark 1"
- 1948-tól: Mesterséges intelligencia – Turing-teszt
- 1952-től: hormonkezelés majd öngyilkosság

#### Algoritmikus problémák

- 1950-es évek lelkesedése
- Church-Turing tézis: a Turing-gép képes minden kiszámítható függvényt kiszámítani
- Church-Turing tétel: vannak Turing-géppel nem kiszámítható függvények

#### Turing-gép

- **2 fő alkatrész:**
  - Vezérlő: Lehetséges belső állapotainak halmaza
  - Szalag: Végtelen cellákból áll, író-olvasó fej aktuális pozíciója

- **Turing-gép elemei:**
  - \(\Sigma\): szalagjelek (betűk) halmaza
  - \(Q\): állapotok halmaza
  - \(q_0\): kezdőállapot
  - \(F\): elfogadó állapotok halmaza
  - \(\delta\): állapotátmenetfüggvény

- **Átmenetfüggvény (\(\delta\)):**
  - Bemenő paraméterei: aktuális állapot és aktuálisan olvasott betű
  - Visszaadott értékei: következő állapot, cellára visszaírandó betű, fej mozgásának iránya

#### Turing-gép definíciója

- \(\Sigma\): szalagjelek (betűk) halmaza
- \(Q\): állapotok halmaza
- \(q_0\): kezdőállapot
- \(F\): elfogadó állapotok halmaza
- \(\delta\): állapotátmenetfüggvény

#### Turing-gép - Példa

- Van-e a megadott input szóban ‘x’ betű?

#### Turing-gép - Konfiguráció

- **Szükséges leírás:**
  - Milyen állapotban van a vezérlő?
  - Milyen betűk vannak a szalagon?
  - Melyik cellán áll az író-olvasó fej?

#### Input és kezdőkonfiguráció

- Input: egy \(w\) szó speciális betűk nélkül
- Kezdőkonfiguráció: kezdőállapotban, fej a kezdőbetűn, input jobbra indul, minden más cella üres

#### Megállási konfiguráció

- Olyan konfiguráció, ahonnan a Turing-gép nem tud továbblépni (átmenetfüggvény nincs értelmezve az aktuális állapoton és az aktuálisan olvasott betűn)

#### Közvetlen rákövetkezés

- Ha \(\delta(q, a) = (q', b, R)\), akkor a következő állapot \(q'\), a szalagra visszaírandó betű \(b\), és a fej jobbra lép.

#### Rákövetkezés

- Léteznek \(C_1, C_2, ..., C_k\) konfigurációk, hogy \(C_1 \rightarrow C_2 \rightarrow ... \rightarrow C_k\)

#### Megállás és elfogadás/elutasítás

- Input: \(w\)
- Ha van olyan megállási konfiguráció, hogy \(q \in F\), akkor \(M\) elfogadja \(w\)-t, különben elutasítja.

#### Időigény vs időkorlát

- Időigény: konkrét \(w\) inputon a megállásig megtett lépések száma (\(t(w)\))
- Időkorlát: minden lehetséges inputra egy felső korlát az időigényre (függvény formájában: \(T(n)\), ahol \(n\) az input hossza)

#### Számítási probléma = Nyelv

- Számítási problémák nyelvekként (szavak halmazai) reprezentálva
- Turing-gép milyen eredményt ad az \(L\) nyelv \(w\) szavain mint inputokon?

#### Eldöntött / felismert nyelv

- \(L\) nyelv eldöntése: minden \(w\) inputra elfogadja vagy elutasítja
- \(L\) nyelv felismerése: minden \(w\) inputra elfogadja vagy nem áll meg

#### Rekurzív / rekurzíve felsorolható nyelvek

- Rekurzív nyelv (\(L\)): létezik Turing-gép, mely eldönti \(L\)-t
- Rekurzíve felsorolható nyelv (\(L\)): létezik Turing-gép, mely felismeri \(L\)-t
- Rekurzív nyelvek osztálya: \(REC\)
- Rekurzíve felsorolható nyelvek osztálya: \(RE\)

Ez a jegyzet segíthet a számításelmélet témakörében a Turing-gépekkel kapcsolatos ismeretek rendszerezésében és megértésében.