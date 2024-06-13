### Teljes Nyelvek Nyelvosztályokra Nézve

#### Adott 𝐶 nyelvosztályra nézve teljes nyelvek
- **Magukban hordozzák a 𝐶-be tartozó összes nyelv eldöntésének nehézségét.**
- **Pontosabban be lehet „lőni” az adott nyelv eldöntésének bonyolultságát.**
- **Segítségükkel könnyű bizonyítani, ha két osztály egybeesik.**

### Visszavezetés (Karp-redukció)

- **Az 𝐿_1 ⊆ 𝐼^∗ nyelv visszavezethető az 𝐿_2 ⊆ 𝐼^∗ nyelvre:**
  - ∃𝑓: 𝐼^∗ ↦ 𝐼^∗ polinom időkorlátos determinisztikus Turing-géppel kiszámítható (szó)függvény, hogy:
    - ∀𝑥 ∈ 𝐼^∗ szóra:
      - 𝑥 ∈ 𝐿_1 ⇔ 𝑓(𝑥) ∈ 𝐿_2
  - **Jelölés:** 𝐿_1 ≺ 𝐿_2

- **Visszavezetés tranzitivitása:**
  - ha 𝐿_1 ≺ 𝐿_2 és 𝐿_2 ≺ 𝐿_3, akkor 𝐿_1 ≺ 𝐿_3.

- **𝐏, 𝐍𝐏, 𝐏𝐒𝐏𝐀𝐂𝐄, 𝐄𝐗𝐏𝐓𝐈𝐌𝐄, 𝐍𝐄𝐗𝐏𝐓𝐈𝐌𝐄, 𝐄𝐗𝐏𝐒𝐏𝐀𝐂𝐄 zártak a visszavezetésre.**
  - Pl. ha 𝐿_1 ≺ 𝐿_2 és 𝐿_2 ∈ 𝐍𝐏, akkor 𝐿_1 ∈ 𝐍𝐏.

### Nyelvosztályok és Nehézségük

- **Legyen 𝐶 egy nyelvosztály és 𝐿 egy nyelv.**
  - Ha 𝐿 ∈ 𝐶, akkor ez 𝐿 eldöntésének bonyolultságára felső korlátot ad.
  - Ha 𝐿 „magában hordja” az összes 𝐿′ ∈ 𝐶 eldöntésének bonyolultságát:
    - Az 𝐿 nyelv 𝐶-nehéz, ha:
      - ∀𝐿′ ∈ 𝐶 esetén 𝐿′ ≺ 𝐿.
    - Ha 𝐿 𝐶-nehéz, akkor ez 𝐿 eldöntésének bonyolultságára alsó korlátot ad.
    - Az 𝐿 nyelv 𝐶-teljes, ha 𝐿 ∈ 𝐶 és 𝐿 𝐶-nehéz.
      - Eldöntésének bonyolultsága pontosan 𝐶.

### Több 𝐶-teljes Nyelv Keresése

- **Ha találunk egy 𝐶-teljes nyelvet, hogyan kereshetünk több 𝐶-teljes nyelvet?**
  - Ha:
    - 𝐿_1 𝐶-teljes → 𝐿_2 𝐶-nehéz → 𝐿_2 𝐶-teljes
    - 𝐿_1 ≺ 𝐿_2 → 𝐿_2 𝐶-nehéz → 𝐿_2 𝐶-teljes
    - 𝐿_2 ∈ 𝐶 → 𝐿_2 𝐶-teljes

### Példa: 𝐍𝐏-teljes Nyelvek

- **Találni kell egy 𝐍𝐏-teljes nyelvet (pl. SAT).**
  - Egy 𝐿 nyelv 𝐍𝐏-teljessége belátható:
    - 𝐿 ∈ 𝐍𝐏 ???: Tanú-tétel segítségével
    - 𝑆𝐴𝑇 ≺ 𝐿 ???: Visszavezetés konstruálásával

### Központi Kérdés a Számításelméletben

- **Ha egy 𝐍𝐏-teljes nyelvről sikerülne belátni, hogy 𝐏-ben van:**
  - 𝐏 = 𝐍𝐏
  - Ez a számításelmélet központi kérdése!
