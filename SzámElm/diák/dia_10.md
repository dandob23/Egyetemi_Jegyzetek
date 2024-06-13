### Példa 𝐍𝐏-teljes nyelvekre: Hamilton-kör probléma

Van a gráfnak olyan köre, mely minden csúcsot pontosan egyszer érint?

---

### Példa 𝐍𝐏-teljes nyelvekre: Utazóügynök probléma

Adottak városok, ill. költségek a városok közti utakhoz rendelve. Melyik a legolcsóbb körút, mely minden várost pontosan egyszer érint?

#### Naív algoritmus időbonyolultsága
- \(𝑂(n!)\)

#### Létezik ilyen determinisztikus algoritmus
- \(𝑂(n^2 2^n)\)

#### Létezik polinom időbonyolultságú determinisztikus algoritmus?
- Egyelőre nem ismert.

---

### Példa 𝐍𝐏-teljes nyelvekre: Hátizsák probléma

Adott kapacitású hátizsákba hogyan pakoljuk a lehető legnagyobb értékű cuccot?

---

### 𝐍𝐏-teljes Nyelv Találása

#### Találni kell egy 𝐍𝐏-teljes nyelvet (pl. 𝑆𝐴𝑇).

Egy 𝐿 nyelv 𝐍𝐏-teljessége belátható:
- 𝐿∈𝐍𝐏 ???: Tanú-tétel segítségével
- 𝑆𝐴𝑇≺𝐿 ???: Visszavezetés konstruálásával

---

### 𝑆𝐴𝑇: A kielégíthető Boole-formulák nyelve

#### Boole-formula építőelemei:
- Ítéletváltozók: \(𝑥_1,𝑥_2,\dots\)
- Logikai operátorok: negáció, konjunkció, diszjunkció

#### Példa formula
- kielégíthető?
\[
(𝑥_1 \vee 𝑥_3) \wedge (\neg 𝑥_2 \vee (𝑥_3 \wedge \neg 𝑥_1) \vee \neg 𝑥_3)
\]

---

### 𝑆𝐴𝑇∈𝐍𝐏
- Könnyű bizonyítani a Tanú-tétellel.
- A tanú a Boole-formula változóinak egy kiértékelése.

### 𝑆𝐴𝑇 𝐍𝐏-nehéz
- Nehéz bizonyítani.
- Bármely nemdeterminisztikus, polinom időkorlátos Turing-gép működését felírhatjuk egy (hatalmas) Boole-formula alakjában.

#### Szükséges ítéletváltozók:
- \(𝐶_{𝑖,𝑗}^𝜎\): Az \(𝑖\). lépésben a \(𝑗\). cellában \(𝜎\) van.
- \(𝐹_{𝑖,𝑗}\): Az \(𝑖\). lépésben a \(𝑗\). cellán áll a fej.
- \(𝑄_𝑖^𝑞\): Az \(𝑖\). lépésben a \(𝑞\) állapotban van.
- Minden \(𝜎 ∈ Σ, 𝑞 ∈ 𝑄\) és \(𝑖,𝑗 = 0, \dots, 𝑛^𝑑\) esetén.

#### Turing-gép működésének leírása, pl.:
- Kezdetben \(𝑞_0\) állapotban van: \(𝑄_0^{𝑞_0}\)
- Kezdetben a fej a 0. pozícióban van: \(𝐹_{0,0}\)
- A szalag kezdeti tartalma pl. 0100 input esetén:
  \[
  𝐶_{0,0}^{⊳} ∧ 𝐶_{0,1}^{0} ∧ 𝐶_{0,2}^{1} ∧ 𝐶_{0,3}^{0} ∧ 𝐶_{0,4}^{0} ∧ 𝐶_{0,5}^{⊔} ∧ \dots ∧ 𝐶_{0,𝑛^𝑑}^{⊔}
  \]

---

### Konjunktív normálforma (KNF)

\[
(𝑥_1 \vee 𝑥_3) \wedge (\neg 𝑥_2 \vee 𝑥_3 \vee 𝑥_1 \vee \neg 𝑥_4) \wedge (\neg 𝑥_1 \vee 𝑥_4)
\]

### 3-KNF

Minden klóz 3-elemű:
\[
(𝑥_1 \vee 𝑥_3 \vee 𝑥_3) \wedge (\neg 𝑥_2 \vee 𝑥_3 \vee \neg 𝑥_4) \wedge (\neg 𝑥_1 \vee 𝑥_4 \vee 𝑥_2)
\]

### 3−𝑆𝐴𝑇

Kielégíthető 3-KNF-ben levő Boole-formulák nyelve.
- Minden Boole-formula átírható 3-KNF-re.
- Ezért van a 𝑆𝐴𝑇-nak visszavezetése 3−𝑆𝐴𝑇-ra:
  \[
  𝑆𝐴𝑇 ≺ 3−𝑆𝐴𝑇
  \]
- Ezért 3−𝑆𝐴𝑇 egy 𝐍𝐏-nehéz nyelv.
- Mivel 3−𝑆𝐴𝑇 ∈ 𝐍𝐏 is teljesül, így 3−𝑆𝐴𝑇 𝐍𝐏-teljes.

---

### 3 színnel színezhető gráfok nyelve

Korábban beláttuk, hogy 3−𝑆𝑍𝐼𝑁 ∈ 𝐍𝐏

#### Vajon 𝐍𝐏-nehéz is?
- Ha igen, akkor 3−𝑆𝑍𝐼𝑁 𝐍𝐏-teljes.
- Bármely 𝜙 3−𝐾𝑁𝐹 Boole formulához meg lehet adni egy 𝐺 gráfot úgy, hogy:
  \[
  𝜙 ∈ 3−𝑆𝐴𝑇 \Leftrightarrow 𝐺 ∈ 3−𝑆𝑍𝐼𝑁
  \]
- Ezért:
  \[
  3−𝑆𝐴𝑇 ≺ 3−𝑆𝑍𝐼𝑁
  \]

---

### További 𝐍𝐏-teljes nyelvek

- Hamilton-kört tartalmazó gráfok nyelve
- Utazóügynök-probléma
- Maximális klikk probléma gráfokban
- Maximális független csúcshalmaz keresése gráfokban
- Minimális/maximális feszítőfa keresése gráfokban
- Sávszélesség maximalizálásának problémája
- Számok faktorizációja, azaz szorzótényezőkre bontása


