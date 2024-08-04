### Eldönthetetlen Problémák

#### Van olyan probléma, mely algoritmussal nem megoldható?

- **Azaz van olyan nyelv, mely Turing-géppel nem eldönthető?**
  - Igen. (sajnos)

- **Van-e olyan 𝑈 Turing-gép, hogy:**
  - ∀𝑇 Turing-gép és ∀𝑥 input esetén:
    - 𝑈 megkapja a 𝑇 „programját” és az 𝑥 inputot, és megmondja, hogy 𝑇 megállna-e az 𝑥 inputon?
  - Nincs ilyen Turing-gép, ezért a megállási probléma eldönthetetlen.

### Post Megfeleltetési Problémája

- **Adott egy min. 2 elemű ábécé:** 𝐴
- **Adott 2 véges sorozat 𝐴 szavaiból:**
  - 𝛼_1, 𝛼_2, …, 𝛼_𝑁 és 𝛽_1, 𝛽_2, …, 𝛽_𝑁
- **Kérdés:** Összefűzhetőek a két sorozat szavai úgy (ismétlődésekkel), hogy összeolvasva ugyanazt a szót kapjuk?
  - 𝛼_(𝑖_1), 𝛼_(𝑖_2), …, 𝛼_(𝑖_𝑘) = 𝛽_(𝑖_1), 𝛽_(𝑖_2), …, 𝛽_(𝑖_𝑘), ahol 1 ≤ 𝑖_𝑗 ≤ 𝑁
  - Ez a probléma eldönthetetlen.

### Bonyolultsági Osztályok Összefüggései

#### Idő- és Tárbonyolultsági Osztályok

- **Az eldönthető nyelveket idő- és tárbonyolultsági osztályokba soroltuk.**
  - 𝐓𝐈𝐌𝐄(𝑓(𝑛)) ⊆ 𝐍𝐓𝐈𝐌𝐄(𝑓(𝑛))
  - 𝐒𝐏𝐀𝐂𝐄(𝑓(𝑛)) ⊆ 𝐍𝐒𝐏𝐀𝐂𝐄(𝑓(𝑛))

- **Egy Turing-gép 𝑘 lépésben max. 𝑘 szalagcellát használ.**
  - 𝐓𝐈𝐌𝐄(𝑓(𝑛)) ⊆ 𝐒𝐏𝐀𝐂𝐄(𝑓(𝑛))
  - 𝐍𝐓𝐈𝐌𝐄(𝑓(𝑛)) ⊆ 𝐍𝐒𝐏𝐀𝐂𝐄(𝑓(𝑛))

#### Szimuláció Nemdeterminisztikus Turing-géppel

- **Egy 𝑂(𝑓(𝑛)) időkorlátos nemdeterminisztikus 𝑇 Turing-gépet szimuláljunk egy 𝑇’ determinisztikussal!**
  - A 𝑇 számítási fájának egy ágát 𝑇’ végigszámolja: 𝑂(𝑓(𝑛)) lépés, max. 𝑂(𝑓(𝑛)) cella.
  - Visszalép a fa gyökerébe.
  - Másik ággal teszi ugyanezt.
  - Közben ugyanazt a szalagot használja (újra).
  - Mindvégig 𝑂(𝑓(𝑛)) cellát használ.
  - 𝐍𝐓𝐈𝐌𝐄(𝑓(𝑛)) ⊆ 𝐒𝐏𝐀𝐂𝐄(𝑓(𝑛))

#### Tár-idő Tétel

- **Tétel:** 𝐍𝐒𝐏𝐀𝐂𝐄(𝑓(𝑛)) ⊆ 𝐓𝐈𝐌𝐄(𝑐^𝑓(𝑛))

### Bonyolultsági Osztályok Definíciói

- 𝐏 = ⋃_(𝑘≥1) 𝐓𝐈𝐌𝐄(𝑛^𝑘)
- 𝐍𝐏 = ⋃_(𝑘≥1) 𝐍𝐓𝐈𝐌𝐄(𝑛^𝑘)
- 𝐄𝐗𝐏𝐓𝐈𝐌𝐄 = ⋃_(𝑘≥1) 𝐓𝐈𝐌𝐄(𝑐^(𝑛^𝑘))
- 𝐍𝐄𝐗𝐏𝐓𝐈𝐌𝐄 = ⋃_(𝑘≥1) 𝐍𝐓𝐈𝐌𝐄(𝑐^(𝑛^𝑘))
- 𝐋 = 𝐒𝐏𝐀𝐂𝐄(log_𝑐⁡𝑛)
- 𝐍𝐋 = 𝐍𝐒𝐏𝐀𝐂𝐄(log_𝑐⁡𝑛)
- 𝐏𝐒𝐏𝐀𝐂𝐄 = ⋃_(𝑘≥1) 𝐒𝐏𝐀𝐂𝐄(𝑛^𝑘)
- 𝐄𝐗𝐏𝐒𝐏𝐀𝐂𝐄 = ⋃_(𝑘≥1) 𝐒𝐏𝐀𝐂𝐄(𝑐^(𝑛^𝑘))

### Tartalmazási Viszonyok

- **Mivel 𝐒𝐏𝐀𝐂𝐄(𝑓(𝑛)) ⊆ 𝐍𝐒𝐏𝐀𝐂𝐄(𝑓(𝑛)):**
  - 𝐋 ⊆ 𝐍𝐋

- **Tár-idő tétel:** 𝐍𝐒𝐏𝐀𝐂𝐄(𝑓(𝑛)) ⊆ 𝐓𝐈𝐌𝐄(𝑐^𝑓(𝑛))
  - 𝐍𝐋 ⊆ 𝐏

- **Mivel 𝐓𝐈𝐌𝐄(𝑓(𝑛)) ⊆ 𝐍𝐓𝐈𝐌𝐄(𝑓(𝑛)):**
  - 𝐏 ⊆ 𝐍𝐏

- **Mivel 𝐍𝐓𝐈𝐌𝐄(𝑓(𝑛)) ⊆ 𝐒𝐏𝐀𝐂𝐄(𝑓(𝑛)):**
  - 𝐍𝐏 ⊆ 𝐏𝐒𝐏𝐀𝐂𝐄

- **Minden 𝑂(𝑓(𝑛)) tárkorlátos nemdeterminisztikus Turing-gép szimulálható 𝑂(𝑓^2 (𝑛)) tárkorlátos determinisztikus Turing-géppel.**
  - Azaz: 𝐍𝐒𝐏𝐀𝐂𝐄(𝑓(𝑛)) ⊆ 𝐒𝐏𝐀𝐂𝐄(𝑓^2 (𝑛))
  - Ezért: 𝐏𝐒𝐏𝐀𝐂𝐄 = 𝐍𝐏𝐒𝐏𝐀𝐂𝐄
  - És 𝐄𝐗𝐏𝐒𝐏𝐀𝐂𝐄 = 𝐍𝐄𝐗𝐏𝐒𝐏𝐀𝐂𝐄 stb.

#### Tár-idő Tétel Következményei

- 𝐏𝐒𝐏𝐀𝐂𝐄 ⊆ 𝐄𝐗𝐏𝐓𝐈𝐌𝐄