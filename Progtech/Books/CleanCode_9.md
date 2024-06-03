### 9. Fejezet: Egységtesztek

A 9. fejezet az egységtesztelés fontosságáról és a jó tesztek írásának alapelveiről szól. Itt részletesen áttekintjük a legfontosabb fogalmakat és megjegyzéseket a fejezetből.

#### Miért fontos az egységtesztelés?
- **Minőségi biztosítás:** Az egységtesztek segítenek biztosítani, hogy a kód helyesen működik és megfelel a követelményeknek.
- **Gyors visszajelzés:** A tesztek gyorsan visszajelzést adnak a kód helyességéről, így a hibák korán észlelhetők és javíthatók.
- **Refaktorálás támogatása:** A meglévő tesztek biztonságot nyújtanak, hogy a kód refaktorálása során nem rontjuk el a működést.

#### A jó egységtesztek jellemzői
- **Gyorsak:** Az egységteszteknek gyorsan kell futniuk, hogy gyakran futtathatók legyenek.
- **Izoláltak:** Minden tesztnek függetlennek kell lennie a többitől, nem szabad, hogy az egyik teszt eredménye befolyásolja a másikat.
- **Ismételhetők:** A teszteknek mindig ugyanazt az eredményt kell adniuk, függetlenül attól, hányszor futtatjuk őket.
- **Automatizáltak:** A teszteket automatizált eszközökkel kell futtatni, hogy minimalizáljuk az emberi beavatkozást és hibalehetőséget.
- **Olvashatók:** A teszteknek ugyanolyan olvashatónak kell lenniük, mint a produkciós kódnak, hogy könnyen érthetők és karbantarthatók legyenek.

#### Test-Driven Development (TDD)
- **Definíció:** A TDD egy fejlesztési módszertan, amelyben a kód írása előtt teszteket írunk.
- **Ciklus:** A TDD három lépésből álló cikluson alapul: 
  1. **Red:** Írjunk egy tesztet, amely nem sikerül (piros állapot).
  2. **Green:** Írjunk annyi kódot, amennyi szükséges ahhoz, hogy a teszt sikeres legyen (zöld állapot).
  3. **Refactor:** Refaktoráljuk a kódot, miközben biztosítjuk, hogy a teszt továbbra is sikeres legyen.

#### Tesztelési szintek
- **Egységtesztek:** A kód legkisebb egységeit (pl. függvényeket, metódusokat) tesztelik.
- **Integrációs tesztek:** Különböző kódegységek együttműködését tesztelik.
- **Rendszertesztek:** A teljes rendszer működését ellenőrzik.

#### Tesztesetek írása
- **Pozitív tesztesetek:** Olyan esetek, amelyeknél a kódnak a várt módon kell működnie.
- **Negatív tesztesetek:** Olyan esetek, amelyeknél a kódnak helyesen kell kezelnie a hibás vagy váratlan bemeneteket.
- **Határérték tesztek:** Olyan esetek, amelyeknél a kódot a bemenetek határértékein teszteljük.

#### Tesztelési módszertanok
- **Black-box tesztelés:** A tesztelő nem látja a kód belső működését, csak a bemeneteket és a kimeneteket.
- **White-box tesztelés:** A tesztelő ismeri a kód belső működését és ennek megfelelően írja a teszteket.

#### Tesztelési eszközök
- **xUnit keretrendszerek:** Az egységteszteléshez használt keretrendszerek családja (pl. JUnit, NUnit, PHPUnit), amelyek szabványosított struktúrát és eszközöket biztosítanak a teszteléshez.

#### Fontos megjegyzések
- **Tesztelési piramis:** A tesztelési piramis szerint a legtöbb tesztnek egységteszteknek kell lennie, ezt követik az integrációs tesztek, és végül a rendszertesztek.
- **Mocks és stubs:** Az egységtesztek izolálása érdekében gyakran használnak mockokat (hamis objektumokat) és stubokat (helyettesítőket).
- **Kódlefedettség:** A kódlefedettség mérése segít meghatározni, hogy a kód hány százalékát tesztelték, de nem garantálja a kód helyességét.

Ez a fejezet kulcsfontosságú az egységtesztelés alapelveinek megértéséhez és alkalmazásához. Ha további részletekre vagy példákra van szükséged, bátran kérdezz!