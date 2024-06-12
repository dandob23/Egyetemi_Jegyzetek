Itt található a PowerPoint prezentáció alapján készült felsorolásos jegyzet a tárbonyolultsági osztályokról:

### Tárbonyolultsági osztályok

#### Általános fogalmak

- Az időbonyolultságon kívül más bonyolultság-fogalmak is vizsgálhatók.
- A Turing-gép számítása során felhasznált szalagcellák száma.
- **Kérdés:** Milyen Turing-gép architektúrát vegyünk alapul?

#### Tárigény

- Legyen \( M \) -szalagos Turing-gép és \( x \) ennek egy inputja.
- \( M \) megállási konfigurációja:
  - \( S_M(x) \): \( M \) tárigénye az \( x \) inputon.

#### Lyukszalagos Turing-gépek motivációja

- Az inputot nem kellene a tárigénybe beleszámítani.
  - Ha beleszámítanánk, sohasem tudnánk lineáris tárbonyolultság alá menni.
- Az input és az output nem számít bele a tárigénybe.
  - Inputszalag: csak olvasható.
  - Outputszalag: csak írható.
- Lehetővé teszi logaritmikus tárbonyolultsági osztályok definiálását.

#### Lyukszalagos Turing-gép definíciója

- \(\Sigma\): szalagjelek (betűk) halmaza
- \( Q \): állapotok halmaza
- \( q_0 \): kezdőállapot
- \( F \): elfogadó állapotok halmaza
- \(\delta\): állapotátmenetfüggvény
  - \( \delta(q, a_1, a_2, ..., a_k) = (q', b_1, b_2, ..., b_k, m_1, m_2, ..., m_k) \)

#### Tárigény

- Legyen \( M \) -szalagos lyukszalagos Turing-gép és \( x \) ennek egy inputja.
- \( M \) megállási konfigurációja:
  - \( S_M(x) \): \( M \) tárigénye az \( x \) inputon.

#### Tárkorlát

- \( M \) tárkorlátos:
  - \( S_M(x) \): \( M \) tárigénye minden \( x \) inputon legfeljebb \( f(|x|) \).

#### Tárbonyolultsági osztályok

- Az eldönthető nyelvek további osztályozása.
- A nyelveket eldöntő Turing-gépek tárkorlátja alapján.
- A lyukszalagos Turing-gépet vesszük alapul.

#### Tárbonyolultsági osztályok definíciói

- **\( DSPACE(f(n)) \) osztály:**
  - Ha van olyan \( f(n) \) tárkorlátos lyukszalagos Turing-gép, amely eldönti \( L \)-t.
- **\( PSPACE \) osztály:**
  - Polinomiális tárkorlátos Turing-géppel eldönthető nyelvek osztálya.
- **\( EXPSPACE \) osztály:**
  - Exponenciális tárkorlátos Turing-géppel eldönthető nyelvek osztálya.
- **\( L \) osztály:**
  - Logaritmikus tárkorlátos Turing-géppel eldönthető nyelvek osztálya.

Ez a jegyzet segít áttekinteni a tárbonyolultsági osztályokat és a hozzájuk kapcsolódó fogalmakat.