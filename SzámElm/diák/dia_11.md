### Példa 𝐍𝐋-teljes nyelvekre: Elérhetőség gráfokban

**Kérdés:** Létezik-e út két adott csúcs között?

- Nemdeterminisztikusan bejárjuk a gráfot az egyik csúcsból indulva.
- Elég csak az aktuális csúcsot (annak sorszámát) tárolni.
- A sorszámot 2-es, 3-as, … vagy 10-es, stb. számként ábrázoljuk.
- Logaritmikus számkódolás: \(\log n\)

### Példa 𝐍𝐋-teljes nyelvekre: 2−𝑆𝐴𝑇

**Kérdés:** A \((𝑙_1 \vee 𝑙_2)\) klózokból álló KNF kielégíthető-e?

- Alacsonyabb bonyolultság, mint 3−𝑆𝐴𝑇 és 𝑆𝐴𝑇 esetén (𝐍𝐏-teljes).

### Példa 𝐏-teljes nyelvekre: Hálózat-kiértékelés

**Kérdés:** Logikai áramkör outputja 0 vagy 1-e?

- Logikai kapuk: pl. AND, OR, NOT, XOR.
- Adott input bitek esetén.

### Példa 𝐏-teljes nyelvekre: Lineáris programozás

**Optimalizációs probléma:**

- Feltételek, mint lineáris egyenlőtlenségek: \(𝐴𝐱≤𝐛\)
- Célfüggvényt maximalizálni: \(\max: 𝐜^𝑇 𝐱\)
- …ahol \(𝐱≥0\).

**Ismert algoritmus:** szimplex módszer.

### Példa 𝐏𝐒𝐏𝐀𝐂𝐄-teljes nyelvekre: 𝑄𝐵𝐅

**Kérdés:** \(𝑆𝐴𝑇\) probléma kvantorokkal.

\[
∃𝑥_1∀𝑥_2 ((𝑥_1 \vee 𝑥_2 )∧(¬𝑥_1 \vee 𝑥_2 ))
\]

- Nagyobb bonyolultságú, mint a \(𝑆𝐴𝑇\) (𝐍𝐏-teljes).

### Példa 𝐏𝐒𝐏𝐀𝐂𝐄-teljes nyelvekre

- **Reversi/Othello**
- **Mahjong solitaire**

### Példa 𝐄𝐗𝐏𝐓𝐈𝐌𝐄-teljes nyelvekre

- **Sakk**
- **Go**

---