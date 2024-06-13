1. **Algoritmusok bonyolultságának mérése, bonyolultságok típusai. Bonyolultsági függvények, ordó jelölés. Keresési és rendezési algoritmusok, gráfalgoritmusok bonyolultsága.**
    - Algoritmusok bonyolultsága: Időbonyolultság, tárbonyolultság.
    - Bonyolultságelmélet: Worst-case complexity, elemi lépések.
    - Keresési algoritmusok időbonyolultsága: Lineáris és bináris keresés.
    - Ordó jelölés: O(f), bonyolultsági függvények típusai (logaritmikus, lineáris, polinomiális, exponenciális, stb.).
    - Rendezési algoritmusok: Buborék rendezés, beszúrásos rendezés (lineáris és bináris kereséssel), összefésüléses rendezés.
    - Gráfalgoritmusok: Mélységi keresés (DFS), szélességi keresés (BFS), Dijkstra algoritmus, Floyd-Warshall algoritmus, Hamilton-kör probléma.

- 1. dia: Algoritmusok bonyolultsága, Keresési algoritmusok időbonyolultsága, Ordó jelölés, Bonyolultsági függvények, Rendezési algoritmusok időbonyolultsága, Gráfok, Elérhetőség problémája, Hamilton-kör probléma.


2. **Algoritmus modellek. Egyszalagos determinisztikus Turing-gép felépítése és definíciója, kapcsolódó fogalmak: konfiguráció, megállás, elfogadás/elutasítás, időkorlát. Eldöntött/felismert nyelv.**
    - Algoritmus modellek: Turing-gép, rekurzív függvények, lambda-kalkulus, Markov algoritmus.
    - Turing-gép definíciója: Vezérlő, szalag, állapotok.
    - Konfiguráció, megállás, elfogadás/elutasítás, időkorlát.
    - Eldöntött és felismert nyelvek.

- 2. dia: Algoritmus modellek és Turing-gép, Church-Turing tézis és tétel, Turing-gép felépítése és definíciója, Konfigurációk, Input és kezdőkonfiguráció, Megállási konfiguráció, Rákövetkezés, Turing-gép megállásának vizsgálata, Elfogadás és elutasítás, Időigény és időkorlát, Eldöntött és felismert nyelvek.


3. **Többszalagos determinisztikus Turing-gép felépítése és definíciója, kapcsolódó fogalmak: konfiguráció, megállás, elfogadás/elutasítás, időkorlát. Szimulációja egyszalagos Turing-géppel.**
    - Többszalagos Turing-gép: Formális definíció, konfigurációk, kezdő- és megállási konfigurációk, szalagok funkciói.
    - Szimuláció egyszalagos Turing-géppel: Kódolás, lépésszám, dekódolás.

- 3. dia: Többszalagos Turing-gép definíciója, Konfigurációk, Szalagok funkciói, Kezdő- és megállási konfigurációk, Output meghatározása, Örökölt fogalmak.


4. **Időbonyolultsági osztályok. Lineáris felgyorsítás tétele. Lyukszalagos Turing-gépek, tárbonyolultsági osztályok.**
    - Időbonyolultsági osztályok: TIME(f(n)), P, EXPTIME.
    - Lineáris felgyorsítás tétele.
    - Lyukszalagos Turing-gép: Tárigény, tárkorlát, tárbonyolultsági osztályok (SPACE(f(n)), PSPACE, EXPSPACE, L).

- 4. dia: Időbonyolultsági osztályok, Polinomiális és exponenciális időkorlátos Turing-gépek, Szimuláció, Kódolás, Turing-gép szimulációja, Dekódolás, Lépésszám összesítve, Lineáris felgyorsítás tétele.
- 5. dia: Tárbonyolultság és Turing-gép architektúrája, Többszalagos Turing-gép, Lyukszalagos Turing-gép, Tárigény, Tárkorlát, Tárbonyolultsági osztályok.


5. **Nemdeterminisztikus Turing-gép működése és definíciója, hozzájuk kapcsolódó fogalmak. Szimulációja determinisztikus Turing-géppel. Nemdeterminisztikus bonyolultsági osztályok.**
    - Nemdeterminisztikus Turing-gép: Definíció, input feldolgozása, időkorlát, szimuláció determinisztikus Turing-géppel.
    - Nemdeterminisztikus bonyolultsági osztályok: NTIME(f(n)), NSPACE(f(n)), NP, NEXPTIME, NL.

- 6. dia: Nem-determinisztikus Turing-gépek és bonyolultsági osztályok, Nem-determinisztikus Turing-gép definíciója, Input feldolgozása, Időkorlát, Szimuláció, Nem-determinisztikus bonyolultsági osztályok (NTIME, NSPACE, NP, NEXPTIME, NL).


6. **NP nyelvosztály. Tanú-tétel. Példa NP-beli nyelvekre és a tanú-tétel alkalmazására.**
    - NP osztály: Definíció, példák (gráfelméleti nyelvek, számelméleti problémák, egyenletek megoldásai, utazóügynök probléma).
    - Tanú-tétel: Tanú fogalma, tanú kritériumai, tanú-tétel bizonyítása.
    - Példák: Hamilton-kör, 3-SAT, 3-SZIN, egész faktorizáció.

- 7. dia: NP Osztályba Tartozó Nyelvek Példái, NP-be Tartozás Bizonyítéka, Tanú és Polinom Mélység, Példa: Hamilton-kör, Tanú Kritériumai, Példa: Gráf Színezése, Példa: Egész Faktorizáció.


7. **Eldönthetetlen nyelvek. TIME, NTIME, SPACE és NSPACE összefüggései. Nevezetes nyelvosztályok összefüggései.**
    - Eldönthetetlen nyelvek: Megállási probléma, Post megfeleltetési probléma.
    - Bonyolultsági osztályok összefüggései: TIME vs SPACE, NTIME vs NSPACE.
    - Nevezetes nyelvosztályok: P, NP, PSPACE, EXPTIME, NEXPTIME, L, NL.

- 8. dia: Eldönthetetlen Problémák, Post Megfeleltetési Problémája, Bonyolultsági Osztályok Összefüggései, Szimuláció Nemdeterminisztikus Turing-géppel, Tár-idő Tétel, Bonyolultsági Osztályok Definíciói, Tartalmazási Viszonyok.


8. **Visszavezetések. Nehézség és teljesség. Teljes nyelvek keresése. A számításelmélet központi kérdése és az NP-teljes nyelvek szerepe. Példák NP-teljes nyelvekre.**
    - Visszavezetések (Karp-redukció): Definíció, tranzitivitás, zártság a visszavezetésre.
    - Nyelvosztályok és nehézségük: C-nehéz és C-teljes nyelvek.
    - Teljes nyelvek keresése: NP-teljes nyelvek (Hamilton-kör probléma, utazóügynök probléma, hátizsák probléma, SAT, 3-SAT, 3-SZIN).
    - Számításelmélet központi kérdése: P vs NP.

- 9. dia: Teljes Nyelvek Nyelvosztályokra Nézve, Visszavezetés (Karp-redukció), Nyelvosztályok és Nehézségük, Több C-teljes Nyelv Keresése, Példa: NP-teljes Nyelvek, SAT nyelv, 3-SAT, 3-SZIN.


9. **A SAT nyelv teljessége (bizonyítása csak vázlatosan). A 3-SAT és 3-SZIN nyelvek NP-teljessége. Példák más osztályokra teljes nyelvekre.**
    - SAT: Kielégíthető Boole-formulák nyelve, SAT ∈ NP, SAT NP-nehézsége.
    - 3-SAT: Kielégíthető 3-KNF formulák nyelve, 3-SAT ∈ NP, 3-SAT NP-nehézsége.
    - 3-SZIN: 3 színnel színezhető gráfok nyelve, 3-SZIN ∈ NP, 3-SZIN NP-nehézsége.
    - Példák más osztályokra teljes nyelvekre: NL-teljes nyelvek (elérhetőség gráfokban, 2-SAT), P-teljes nyelvek (hálózat-kiértékelés, lineáris programozás), PSPACE-teljes nyelvek (QBF, Reversi/Othello, Mahjong solitaire), EXPTIME-teljes nyelvek (sakk, go).

- 10. dia: Példa NP-teljes nyelvekre: Hamilton-kör probléma, Utazóügynök probléma, Hátizsák probléma, NP-teljes Nyelv Találása, SAT nyelv, SAT ∈ NP, SAT NP-nehézsége, Konjunktív normálforma (KNF), 3-KNF, 3-SAT, 3-SZIN.
- 11. dia: Példa NL-teljes nyelvekre (elérhetőség gráfokban, 2-SAT), P-teljes nyelvekre (hálózat-kiértékelés, lineáris programozás), PSPACE-teljes nyelvekre (QBF, Reversi/Othello, Mahjong solitaire), EXPTIME-teljes nyelvekre (sakk, go).
