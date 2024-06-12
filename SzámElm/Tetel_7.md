### 7. Eldönthetetlen nyelvek. TIME, NTIME, SPACE és NSPACE összefüggései. Nevezetes nyelvosztályok összefüggései.

#### Eldönthetetlen nyelvek

- **Eldönthetetlenség:** Egy nyelv eldönthetetlen, ha nincs olyan Turing-gép, amely minden lehetséges bemenetre helyesen eldönti, hogy a bemenet a nyelv eleme-e.
  - **Példa - Megállási probléma (Halting Problem):** Létezik-e olyan Turing-gép, amely eldönti, hogy egy adott Turing-gép egy adott bemeneten megáll-e?
    - **Tétel:** A megállási probléma eldönthetetlen.
    - **Bizonyítás:** Diagonálizáció módszerével.

- **Rekurzív és rekurzívan felsorolható nyelvek:**
  - **Rekurzív nyelv:** Olyan nyelv, amelyet egy Turing-gép minden bemenetre nézve megállással eldönt.
  - **Rekurzívan felsorolható nyelv:** Olyan nyelv, amelyet egy Turing-gép felismer, azaz a nyelvhez tartozó bemeneteket elfogadja, de a nyelvhez nem tartozó bemenetekre nem feltétlenül áll meg.

#### TIME, NTIME, SPACE és NSPACE összefüggései

- **TIME és NTIME összefüggései:**
  - **Deterministic Time (TIME):** Az időbonyolultsági osztályok azon nyelvek halmazát tartalmazzák, amelyek eldönthetők determinisztikus Turing-gépekkel adott időkorlát alatt.
    - **\(P\):** Polinomiális időben eldönthető nyelvek osztálya.
    - **\(EXPTIME\):** Exponenciális időben eldönthető nyelvek osztálya.
  - **Nondeterministic Time (NTIME):** Az időbonyolultsági osztályok azon nyelvek halmazát tartalmazzák, amelyek eldönthetők nemdeterminisztikus Turing-gépekkel adott időkorlát alatt.
    - **\(NP\):** Polinomiális időben eldönthető nyelvek nemdeterminisztikus Turing-gépekkel.
    - **\(NEXP\):** Exponenciális időben eldönthető nyelvek nemdeterminisztikus Turing-gépekkel.
  - **Kapcsolat:** \(P \subseteq NP \subseteq EXPTIME \subseteq NEXP\)

- **SPACE és NSPACE összefüggései:**
  - **Deterministic Space (SPACE):** Azok a nyelvek, amelyek eldönthetők determinisztikus Turing-gépekkel adott tárkorlát alatt.
    - **\(L\):** Logaritmikus tárban eldönthető nyelvek osztálya.
    - **\(PSPACE\):** Polinomiális tárban eldönthető nyelvek osztálya.
  - **Nondeterministic Space (NSPACE):** Azok a nyelvek, amelyek eldönthetők nemdeterminisztikus Turing-gépekkel adott tárkorlát alatt.
    - **\(NL\):** Logaritmikus tárban eldönthető nyelvek nemdeterminisztikus Turing-gépekkel.
    - **\(NPSPACE\):** Polinomiális tárban eldönthető nyelvek nemdeterminisztikus Turing-gépekkel.
  - **Kapcsolat:** \(L \subseteq NL \subseteq PSPACE = NPSPACE\)

#### Nevezetes nyelvosztályok összefüggései

- **\(P\) és \(NP\) kapcsolata:**
  - Nyitott kérdés: \(P = NP\)?
  - Ha \(P = NP\), akkor minden probléma, amely megoldható nemdeterminisztikus Turing-géppel polinomiális időben, determinisztikus Turing-géppel is megoldható polinomiális időben.

- **\(L\) és \(P\) kapcsolata:**
  - \(L \subseteq P\)
  - Minden logaritmikus tárban eldönthető nyelv polinomiális időben is eldönthető.

- **\(NL\) és \(PSPACE\) kapcsolata:**
  - \(NL \subseteq PSPACE\)
  - Minden logaritmikus tárban nemdeterminisztikus Turing-géppel eldönthető nyelv polinomiális tárban determinisztikus Turing-géppel is eldönthető.

- **\(PSPACE\) és \(EXPTIME\) kapcsolata:**
  - \(PSPACE \subseteq EXPTIME\)
  - Minden polinomiális tárban eldönthető nyelv exponenciális időben is eldönthető.

- **További kapcsolatok:**
  - \(P \subseteq PSPACE\)
  - \(NP \subseteq NPSPACE = PSPACE\)

Ezek az összefüggések és definíciók segítenek megérteni a különböző nyelvosztályok közötti kapcsolatokat és a számításelmélet alapvető kérdéseit, beleértve az eldönthetetlen nyelveket és a bonyolultsági osztályok közötti relációkat.