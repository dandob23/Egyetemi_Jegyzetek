### Tárbonyolultság és Turing-gép architektúrája

Az időbonyolultságon kívül más bonyolultság-fogalmak is vizsgálhatók:

- A Turing-gép számítása során felhasznált szalagcellák száma

**Kérdés**: Milyen Turing-gép architektúrát vegyünk alapul?  
**Válasz**: Legyen \( T \) k-szalagos Turing-gép, és \( x \) ennek egy inputja.

Legyen \( (q, u_1, v_1, \ldots, u_k, v_k) \) egy megállási konfigurációja, melyre:
\[ (q_0, \triangleright, x, \triangleright, \epsilon, \ldots, \triangleright, \epsilon) \overset{T^t}{\rightarrow} (q, \triangleright u_1, v_1, \ldots, \triangleright u_k, v_k) \]

- Az inputot nem kellene a tárigénybe beleszámítani.
  - Ha beleszámítanánk, sohasem tudnánk lineáris tárbonyolultság alá menni.
- Ne számítsuk a tárigénybe se az inputot, se az outputot!
- Ne lehessen az input- és outputszalagokon tényleges számítási lépéseket végezni!
  - Inputszalag: csak olvasható.
  - Outputszalag: csak írható.

Logaritmikus tárbonyolultsági osztályokat is tudunk majd definiálni.

### Többszalagos Turing-gép

\[ T = \langle k, \Sigma, Q, q_0, F, \delta \rangle \]
- \( k \): szalagok száma, \( k \geq 2 \)
- \(\Sigma\): szalagjelek (betűk) halmaza, \(\triangleright, \sqcup \in \Sigma\)
- \( Q \): állapotok halmaza, \( Q \neq \emptyset \)
- \( q_0 \): kezdőállapot, \( q_0 \in Q \)
- \( F \): elfogadó állapotok halmaza, \( F \subseteq Q \)
- \(\delta\): (állapot)átmenetfüggvény, \(\delta: Q \times \Sigma^k \rightarrow Q \times \Sigma^k \times \{ \leftarrow, - , \rightarrow \}^k\)

\[ \delta(q, \sigma_1, \ldots, \sigma_k) = (q', \sigma_1', m_1, \ldots, \sigma_k', m_k) \]
- Ha \(\sigma_i = \triangleright\), akkor \(\sigma_i' = \triangleright\) és \( m_i = \rightarrow \)

### Lyukszalagos Turing-gép

Legyen \( T \) k-szalagos lyukszalagos Turing-gép, és \( x \) ennek egy inputja.

Legyen \( (q, u_1, v_1, \ldots, u_k, v_k) \) egy megállási konfigurációja, melyre:
\[ (q_0, \triangleright, x, \triangleright, \epsilon, \ldots, \triangleright, \epsilon) \overset{T^t}{\rightarrow} (q, \triangleright u_1, v_1, \ldots, \triangleright u_k, v_k) \]

### Tárigény

\( T \) tárigénye az x inputon: \(\sum_{i=2}^{k-1} |u_i v_i|\)

### Tárkorlát

\[ T \] f(n) tárkorlátos:

- \( T \) tárigénye minden \( x \) inputon legfeljebb \( f(|x|) \).

### Tárbonyolultsági osztályok

Az eldönthető nyelvek további osztályozása:

- A nyelveket eldöntő Turing-gépek tárkorlátja alapján
- A lyukszalagos Turing-gépet vesszük alapul 

### SPACE(𝑓(𝑛)) osztály

\[ L \in SPACE(f(n)) \]

ha van olyan \( O(f(n)) \) tárkorlátos lyukszalagos Turing-gép, mely eldönti \( L \)-t.

### Polinomiális tárkorlátos Turing-géppel eldönthető nyelvek osztálya

\[ PSPACE = \bigcup_{k \geq 1} SPACE(n^k) \]

### Exponenciális tárkorlátos Turing-géppel eldönthető nyelvek osztálya

\[ EXPSPACE = \bigcup_{k \geq 1} SPACE(c^{n^k}) \]

### Logaritmikus tárkorlátos Turing-géppel eldönthető nyelvek osztálya

\[ L = SPACE(\log_c n) \]