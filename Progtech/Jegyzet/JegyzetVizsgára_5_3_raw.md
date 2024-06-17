5.3 fejezet:

Lecke 13.: Tesztvezérelt fejlesztés – Test Driven Development – TDD
A lecke célja és tartalma
Célok, megszerezhető kompetenciák: A lecke végére megismerkedünk a TDD alapjaival, alapelveivel, jelentőségével, miszerint a TDD a szoftverfejlesztés kettős könyvelése.
Szükséges eszközök, források: Robert C. Martin Tiszta kód című könyve.
Feldolgozási idő: 90 perc.
Témakörök: TDD alapelvei, Piros – Zöld – Piros, Piros – Zöld – Kék – Piros, Kettős könyvelés.
A lecke tartalma: Ebben a leckében áttekintjük a Tesztvezérelt Fejlesztés (angolul: Test Driven Development - TDD) és a Tiszta Kód közötti kapcsolatot. A Tiszta Kód célja könnyen olvasható, könnyen karbantartható forráskód írása. Előbb-utóbb minden forráskód elkezd bűzölögni, majd rothadni. Ez ellen néha-néha refaktorálnunk, szépítenünk kell a kódot. A refaktorálás előfeltétele, hogy legyen sok-sok unit-tesztünk, hogy legyen bátorságunk hozzányúlni a kódhoz. Ebben segít a TDD, amelynek alapelvei: 1.: Ne írj üzemi kódot, kivéve, hogy egy hibás tesztet kielégíts. 2.: Csak annyit tesztet írja, amely elegendő egy hiba demonstrálására. 3.: Csak annyi üzemi kódot írj, hogy kielégítsd a tesztet. A TDD másik neve: Piros – Zöld – Piros, illetve, ha kód szépítési lépés is van, akkor: Piros – Zöld – Kék – Piros.
Bevezetés
A tesztvezérelt fejlesztés (angolul: Test Driven Development, TDD) egy jól bevált módszer (angolul: Best Practice), amely az agilis módszerekkel, illetve a tiszta kód eszményével együtt terjedt el. A TDD első hallásra nagyon furcsa: ne a metódust írjuk meg, majd utána a hozzá tartozó egységtesztet, vagy más néven unit-tesztet, hanem épp fordítva, először írjuk az egységtesztet, úgy, hogy a tesztelt metódusnak még a feje sincs kész, majd csak ezután írjuk meg a metódust.
A TDD még ettől is továbbmegy, azt írj elő, hogy a metódusból csak annyit írjunk meg, hogy épp átmenjen a legutoljára megírt egységteszten. Ezután írjunk egy új egységtesztet a már félkész metódushoz, ami egy eddig le ne fedett esetet tesztel, aztán írjuk meg a metódusba ezt az esetet. És így tovább, amíg minden estet le fedünk tesztesettel, illetve kóddal a metódusban.
Tehát a TDD lépései így foglalhatók össze:
Egységtesztet írunk először, csak utána metódust.
Minden egységteszt az eddig nem tesztelt lehető legegyszerűbb esetet írja le.
A metódusból csak annyit írunk meg, hogy épp átmenjen az összes egységteszten.
Robert C. Martin (népszerű nevén Uncle Bob) is három pontban írja le a TDD lényegét. Az ő megfogalmazását eredeti angol nyelven adjuk meg:
„Write no production code except to pass a failing test.” Azaz: Ne írj üzemi kódot, kivéve, hogy egy hibás tesztet kielégíts.
„Write only enough of a test to demonstrate a failure.” Azaz: Csak annyit tesztet írja, amely elegendő egy hiba demonstrálására.
„Write only enough production code to pass the test.” Azaz: Csak annyi üzemi kódot írj, hogy kielégítsd a tesztet.
A két megfogalmazás egy kicsit máshova helyezi a hangsúlyt, de mind a kettő kiemeli, hogy a metódusokat apró lépésekben fejlesztjük, úgy, hogy minden lépés előtt írunk egy egységtesztet.
Ha betartjuk a TDD ajánlásait, akkor annak rengetek pozitív hatása van. Lássuk ezeket:
Így nem felejtünk el egységtesztet írni, ami azért jó, mert így sok-sok tesztesetünk lesz.
Illetve így a tesztelő fejünkkel gondolkozunk először és nem a programozó fejünkkel. A programozó fejünk szép és hatékony kódot szeretne írni, ami gyakran nehezen tesztelhető. Viszont a tesztelő fejünket használva először biztosak lehetünk abban, hogy a metódusunkat könnyű lesz tesztelni.
Nyugodt szívvel merünk hozzányúlni a kódhoz, mert egy-egy változás után a regressziós teszt futtatása nagyon egyszerű, így van egy biztosítás a zsebünkbe, hogy ha esetleg a változás hibát okozna, akkor azt észre fogjuk venni. Tehát van bátorságunk szépíteni a kódot. Ezzel elkerüljük, hogy a forráskód ne váljon spagetti kóddá, vagy ami még rosszabb, bűzhödt, rothadó kóddá.
A tesztek a kód nagy részét lefedik, így a program magas minőségében biztosak lehetünk.
Sokkal kevesebb időt kell hibakereséssel, nyomkövetéssel töltenünk.
Az egységteszt a legjobb, programozóknak szóló dokumentáció, így könnyebb megérteni a kódunkat.
Továbbá, minden programozónak két feje, azaz gondolkozási módja van. A programozó fejünk így gondolkozik: „Én egy programozó zseni vagyok, rövid és gyors kódot írok!”. A tesztelő fejünk így gondolkozik: „Mindegy, hogy van implementálva, csak működő képes legyen, tudjam tesztelni.”
A TDD egyik nagy előnye, hogy először a sokkal pragmatikusabb tesztelő fejünkkel gondolkozik. Például szem előtt tartjuk, hogy az osztályaink legyenek publikusak, hiszen csak publikus osztályokat lehet tesztelni. Lássuk be, a programozó fejünk még sose gondolt arra, hogy egy osztály publikus legyen vagy sem.
TDD és a tiszta kód
A tiszta kód alapja a TDD. Ha TDD-t használunk, akkor van sok-sok egységtesztünk, ami bátorságot ad, hogy hozzányúljunk a kódhoz. Ha látjuk, hogy kezd romlani a kódunk, akkor merjük azt refaktorálni. Emiatt a TDD a tiszta kód alapja!
Habár a fenti bekezdés igaz és velős, mégis ez az alfejezet nagyon rövid lett, ezért megkérdeztük ChatGPT 3.5 AGI-t, hogy fejtse ki a véleményét ebben a témában. A prompt ez volt:
Kérlek, egyetemi jegyzet stílusban írj erről a témáról: TDD és a tiszta kód kapcsolata.
ChatGPT 3.5 válasza (néhány iteráció után):
### Tesztvezérelt Fejlesztés (TDD) és Tiszta Kód Kapcsolata
A Tesztvezérelt Fejlesztés (Test-Driven Development, TDD) és a Tiszta Kód elve között szoros kapcsolat van, amely alapvető fontosságú a hatékony és fenntartható szoftverfejlesztéshez. A TDD egy olyan fejlesztési módszer, amelyben a fejlesztő először ír tesztet, majd csak ezután ír üzemi kódot, hogy a teszt sikeresen lefusson. Ez a módszer fokozza a fejlesztés folyamatának fókuszát a funkcionalitásra és a végtermék elvárt viselkedésére.
A TDD gyakorlása során a tesztek szorosan meghatározzák a kívánt funkciókat és elvárt viselkedést, ezáltal irányítják a kód implementációját. Ez a folyamat arra ösztönzi a fejlesztőket, hogy csak azt a kódot írják meg, ami szükséges a tesztek sikeres lefuttatásához, így minimalizálva a fölösleges kód mennyiségét és javítva a kód olvashatóságát.
A Tiszta Kód elve a szoftverfejlesztésben arra törekszik, hogy a kód könnyen érthető, karbantartható és kiegészíthető legyen. Ez magában foglalja a jól strukturált, jól elnevezett osztályok és metódusok használatát, valamint az egyszerű és kifejező kód írását. A tiszta kód elvei segítenek megőrizni a kód hosszú távú érthetőségét és fenntarthatóságát.
A TDD és a Tiszta Kód szoros kölcsönhatása azt eredményezi, hogy a TDD által generált tesztek arra ösztönzik a fejlesztőket, hogy a kód tisztasági elveit kövessék. A tesztek meghatározzák a kód funkcionalitását és elvárt viselkedését, míg a tiszta kód elvei segítenek abban, hogy ezeket a célokat hatékonyan és olvasható módon valósítsák meg. Ennek eredményeként a TDD és a Tiszta Kód együttműködése elősegíti a magas minőségű, karbantartható és kiegészíthető kód létrehozását, ami hosszú távon előnyös a szoftverfejlesztés során.
---
ChatGPT válaszát elolvasva, ami alapvetően jó, mégis kicsit csalódtunk, hiszen, nem emelte ki a lényeget, miszerint a unit-tesztek az az életbiztosításunk, ami ahhoz kell, hogy legyen bátorságunk a kódot tisztán tartani, refaktorálni, mielőtt az rothadó kóddá válna.
Piros – Zöld – Piros
Tudjuk, hogy a sikertelen egységteszt, más néven unit-teszt jelzése minden keretrendszerben piros, a sikeresé zöld. Azt is tudjuk, hogy a TDD előírja, hogy a metódusból (az üzemi kódból) csak annyit írjunk meg, hogy épp átmenjen a legutoljára megírt egységteszten. Ezután írjunk egy új egységtesztet a már félkész metódushoz, ami egy eddig le ne fedett esetet tesztel, aztán írjuk meg a metódusba ezt az esetet. És így tovább, amíg minden estet lefedünk tesztesettel, illetve üzemi kóddal a metódusban.
Azaz először lesz egy piros egységteszt, majd ez zöld lesz, aztán írunk egy újat, ami szintén piros lesz, majd zöld, és így tovább. A TDD ezen tulajdonsága miatt a TDD-t szokás Piros – Zöld – Piros tesztelésnek is hívni.
TDD esettanulmány
Lássunk egy egyszerű példát TDD használatára. TDD segítségével fogjuk lefejleszteni a bináris fában lévő számok összegét kiszámító metódust. Minden egységteszt után közöljük az egész bináris fa osztályt.
A lenti példában, ami több körre van osztva, az egységteszteket a UnitTest1.cs fájlba kell másolni, a BFa osztályt pedig a Program.cs nevű fájlba.
Első kör:
[TestMethod]
public void TestAzÜresFábanASzámokÖsszegeNulla ()
{
    BFa target = new BFa();
    int expected = 0;
    int actual = target.Szum();
    Assert.AreEqual(expected, actual);
}
public class BFa
{
    public int Szum() { return 0; }

Második kör:
[TestMethod]
public void TestSzumCsakGyökérbőlÁllóFa()
{
    BFa target = new BFa(1);
    int expected = 1;
    int actual = target.Szum();
    Assert.AreEqual(expected, actual);
}
public class BFa
{
    int szám;
    public BFa() { szám = 0; }
    public BFa(int szám) { this.szám = szám; }
    public int Szum() { return szám; }
}
Harmadik kör:
[TestMethod]
public void TestSzumeEgyBalÁgúFával()
{
    BFa target = new BFa(1, new BFa(2), null);
    int expected = 3;
    int actual = target.Szum();
    Assert.AreEqual(expected, actual);
}
public class BFa
{
    int szám;
    BFa bal, jobb;
    public BFa() { szám = 0; }
    public BFa(int szám) { this.szám = szám; }
    public BFa(int szám, BFa bal, BFa jobb) : this(szám) 
    { 
        this.bal = bal; 
        this.jobb = jobb;
    }
    public int Szum()
    {
        int szum = szám;
        if (bal != null) szum += bal.Szum();
        return szum; 
    }
}
Negyedik kör:
[TestMethod]
public void TestSzumEgyNagyFával()
{
    BFa target = new BFa(1, 
        new BFa(2, new BFa(3), null), 
        new BFa(4, null, 
            new BFa(5, new BFa(6), new BFa(7))));
    int expected = 1+2+3+4+5+6+7;
    int actual = target.Szum();
    Assert.AreEqual(expected, actual);
}
public class BFa
{
    int szám;
    BFa bal, jobb;
    public BFa() { szám = 0; }
    public BFa(int szám) { this.szám = szám; }
    public BFa(int szám, BFa bal, BFa jobb) : this(szám) 
    { 
        this.bal = bal; 
        this.jobb = jobb;
    }
    public int Szum()
    {
        int szum = szám;
        if (bal != null) szum += bal.Szum();
        if (jobb != null) szum += jobb.Szum();
        return szum; 
    }
}
Piros – Zöld – Kék – Piros
Mint már írtuk, a TDD másik neve a Piros – Zöld – Piros tesztelés. A fenti esettanulmányban nagyon jól látható, hogy a Szum metódust lépésről lépésre írjuk meg, úgy, hogy először megírjuk az új esetet lefedő egységtesztet, majd az ezt megvalósító kódot.
A fenti esettanulmányból nem látszik viszont, hogy néha szépítjük is (idegen szóval refaktoráljuk) a kódot. Ha azt vesszük észre, hogy a kódban redundáns sorok vannak, vagy lehetne alkalmazni egy tervezési mintát, esetleg szét lehetne választani valamit, amire eddig nem volt szükség, akkor kódszépítés következik. Ez a kék fázis. Elvileg minden zöld lépés után kék jön, ezért a TDD-t nevezhetjük Piros – Zöld – Kék – Piros tesztelésnek is.
A fenti példánál maradva, amikor bevezetjük a harmadik BFa konstruktort, akkor általában az először így néz ki:
public BFa(int szám, BFa bal, BFa jobb)
{
    this.szám = szám;
    this.bal = bal; 
    this.jobb = jobb;
}
Ez tartalmaz egy redundáns sort is, hiszen a „this.szám = szám;” utasítást végrehajtjuk az egy paraméteres konstruktorban is. Miután ezt észrevettük, érdemes kódszépítést végrehajtani, hogy eltüntessük a redundáns sort. Ennek ez lesz a végeredménye:
public BFa(int szám, BFa bal, BFa jobb) : this(szám)
{ 
    this.bal = bal; 
    this.jobb = jobb;
}
A TDD a szoftverfejlesztés kettős könyvelése
A szoftverfejlesztés nagyon érzékeny, könnyű helytelen kódsort írni. Szerencsés esetben a kódsor csak szintaktikailag helytelen. Ilyenkor a fordító kiírja, hogy ez és ez a sor hibás, mi a hiba benne, jó esetben még megoldási javaslatot is ad. Viszont, ha szemantikai hiba van benne, akkor nagyon nehéz megtalálni a hibát, ami könnyen futási hibához vezethet.
A könyvelés is hasonlóan érzékeny terület. Elég egy számot rosszul bevezetni a könyvelésbe, és máris az egész elromlik. A könyvelés területén ezt a kettős könyveléssel védik ki. Minden számlát felvesznek a Tartozik és a Követel oldalon is. A két oldal összegének mindig nullának kell lennie. Ha valamelyik oldalon rosszul veszünk fel egy számlát, akkor rögtön látjuk, hogy hiba van. Könnyen belátható, hogy a kettős könyvelés nagyon hasznos!
A TDD a szoftverfejlesztés kettős könyvelése. Minden esetet lefedünk teszttel és kóddal is. Ha bármelyik oldalon hibázunk, akkor azt azonnal észrevesszük.
Erre a gyönyörű összefüggésre Robert C. Martin (népszerű nevén Uncle Bob) hívja fel a figyelmünket Clean Code című videósorozatában.
Összegzés és ellenőrző kérdések
Ebben a leckében áttekintettük a Tesztvezérelt Fejlesztés (angolul: Test Driven Development - TDD) és a Tiszta Kód közötti kapcsolatot. A Tiszta Kód célja könnyen olvasható, könnyen karbantartható forráskód írása. Előbb-utóbb minden forráskód elkezd bűzölögni, majd rothadni. Ez ellen néha-néha refaktorálnunk, szépítenünk kell a kódot. A refaktorálás előfeltétele, hogy legyen sok-sok unit-tesztünk, hogy legyen bátorságunk hozzányúlni a kódhoz. Ebben segít a TDD, amelynek alapelvei: 1.: Ne írj üzemi kódot, kivéve, hogy egy hibás tesztet kielégíts. 2.: Csak annyit tesztet írja, amely elegendő egy hiba demonstrálására. 3.: Csak annyi üzemi kódot írj, hogy kielégítsd a tesztet. A TDD másik neve: Piros – Zöld – Piros, illetve, ha kód szépítési lépés is van, akkor: Piros – Zöld – Kék – Piros.
Ellenőrző kérdések:
Kérdés: Mit jelent a Piros – Zöld – Piros?
Válasz: A Piros – Zöld – Piros a TDD egy másik neve. Az elnevezés onnan ered, hogy a TDD alapelveit betartva először egy unit-tesztet írunk, ami piros lesz. Aztán megírjuk az ezt kiegészítő üzemi kódot, így ez a unit-teszt zöld lesz. Ha még nincs kész a metódus, akkor írunk egy újabb unit-tesztet erre a metódusra, ami megint piros lesz. Ezt ismételjük, amíg el nem készül a metódus.
Kérdés: Mit jelent a Piros – Zöld – Kék – Piros?
Válasz: A piros a sikertelen unit teszt, a zöld a sikeres unit teszt, a kék a refaktorlás színe. Ezeket a lépéseket ismételgetjük a TDD alapelvei szerint, amíg el nem készül az adott metódus.
Kérdés: Miért hívjuk a TDD módszert a szoftverfejlesztés kettős könyvelésének?
Válasz: Mivel a program minden kis részletéhez van unit-tesztünk és üzemi kódunk is, ezért, a TDD a szoftverfejlesztés kettős könyvelése. Előnye: Ha vagy az egyik, vagy a másik helyen elrontjuk az üzleti logikát, akkor arról hibajelentést kapunk
Kérdés: Miért érdemes először a tesztet megírni, és csak utána az üzemi kódot?
Válasz: Ennek rengeteg előnye van, talán a legfontosabb, hogy így nem felejtünk el unit-teszteket írni, és így lesz sok-sok unit tesztünk, ami a kód szépítés előfeltétele, a kód szépítés pedig ahhoz kell, hogy ne kezdjen el bűzölögni, majd rothadni a kódunk.
Kérdés: Miért mondják azt, hogy egy programozónak két feje van?
Válasz: Minden programozó tud programozóként és tesztelőként is gondolkozni, de a két gondolkozásmóddal alapvetően másként közelítünk meg egy szoftverfejlesztési problémát. A programozó fejünk egy csúcsminőségi megoldást szeretne, ami valószínűleg elég bonyolult is. A tesztelő fejünk egy egyszerű, könnyen tesztelhető megoldást szeretne.
Kérdés: A TDD módszer melyik P betűhöz tartozik: Principles, Patterns, Practices?
Válasz: A TDD egy jól bevált módszer, azaz a Practices szóhoz tartozik.
Kérdés: Mi a unit-tesztelés extrém változata?
Válasz: A TDD, hiszen TDD esetén unit-tesztelés csinálunk extrém jól.
