5.fejezet:

Practices: Jól bevált módszerek
A jól bevált módszerek (angolul: best practices) fő forrása az extrém programozás (angolul: eXtreme Programming, röviden: XP) nevű Agilis módszert. Az XP akkor használható sikeresen, ha megrendelő és a szoftverfejlesztő cég akár napi szinten, vagy még sűrűbben tud egyeztetni. Ez lényegében csak akkor fordul elő, ha egy cégen belül egy osztály megrendel a cég saját informatikai osztályától egy belső fejlesztést. E miatt maga az extrém programozás nem terjedt el, de elterjedtek a módszerei, mint úgynevezett jól bevált módszerek.
Ennek az az oka, hogy az extrém programozás attól extrém, hogy ezen a módszertanon belül, ha valamit csinálunk, akkor extrém mód jól csináljuk, illetve, ha valamit nem csinálunk, akkor azt extrém mód nem csináljuk. Az extrém programozás előírja például, hogy csináljunk tesztelést, ennek megfelelően extrém jól csináljuk a tesztelést, úgynevezett Tesztvezérelt fejlesztés (angolul: Test Driven Development – TDD) csinálunk. És miért pont Tesztvezérelt fejlesztést? Mert a sokéves tapasztalat szerint ez a legextrémebb, legjobb tesztelés! És ha ez a legjobb, akkor ezt érdemes lenne máshol is alkalmazni! Ezen gondolatmenet és tapasztalat útján terjedtek el az extrém programozás módszerei, és lettek jól bevált módszerek.
Persze nem minden XP módszer terjedt el. Például a páros programozás az XP egyik módszere, és aki kipróbálta, az dicsérni is szokta, mégsem terjedt el széles körben a szoftvercégek gyakorlatában.
Nézzük először az XP módszereit, aztán vizsgáljuk meg részletsebben azokat, amik széles körben elterjedtek:

Az XP jól bevált módszerei
Az XP módszertan módszerei:
Páros programozás (angolul: pair programming): Két programozó ír egy kódot, pontosabban az egyik írja, a másik figyeli. Ha a figyelő hibát lát vagy nem érti a kódot, akkor azonnal szól. A két programozó folyamatosan megbeszéli, hogy hogyan érdemes megoldani az adott problémát.
Tesztvezérelt fejlesztés (angolul: test driven development): Már a metódus elkészítése előtt megírjuk a hozzá tartozó egységteszteket, vagy más néven unit-teszteket. Ezt néha hívják „először a teszt” (angolul: test-first) megközelítésnek is.
Forráskód átnézése (angolul: code review): Az elkészült nagyobb modulokat, pl. osztályokat, egy vezető fejlesztő átnézi, hogy van-e benne hiba, nem érthető, nem dokumentált rész. A modul fejlesztői elmagyarázzák, mit és miért csináltak. A vezető fejlesztő elmondja, hogyan lehet ezt jobban, szebben csinálni.
Folyamatos integráció (angolul: continuous integration): A nap (vagy a hét) végén, a verziókövető rendszerbe bekerült kódokat integrációs teszt alá vetjük, hogy kiderüljön, hogy azok képesek-e együttműködni. Így nagyon korán kiszűrhető a programozók közti félreértés.
Kódszépítés (angolul: refactoring): A már letesztelt, működő kódban lehet szépíteni, az esetleg lassú, rugalmatlan, vagy egyszerűen csak csúnya részeket. A kódszépítés előfeltétele, hogy legyen sokegységteszt. A szépítés során nem szabad megváltoztatni a kód funkcionalitását, de a szerkezet, pl. egy metódus törzse, szabadon változtatható. A szépítés után minden egységtesztet le kell futtatni, nem csak a megváltozott kódhoz tartozókat, hogy lássuk, a változások okoztak-e hibát.
Az extrém programozás legnagyobb erénye, hogy olyan fejlesztési módszereket hozott a felszínre, amik magas minőséget biztosítanak. Ezek, mint pl. a TDD, nagyon népszerűek lettek.
A jól bevált módszerek másik forrása a Robert C. Martin nevéhez köthető Tiszta kód (angolul: Clean Code) nevű könyv és videó sorozat, ami az Agilis szoftverfejlesztés filozófiáját tárgyalja sok-sok könyvön és videón keresztül, a nélkül, hogy valamelyik konkrét Agilis módszertan mellé letenné a voksot.
Ebben a fejezetben kisebb-nagyobb részletességgel tárgyaljuk azokat módszereket, amik szerintünk jól bevált módszernek tekinthetők.
Tiszta kód
A tiszta kód (angolul: clean code) fogalmának nagyon sok jelentésrétege van. Ebben a jegyzetben ezeknek csak egy részével foglalkozunk. Sokkal részletesebb foglalkozik a témával Robert C. Martin Tiszta kód című könyve.
A tiszta kód egyik legfontosabb ismérve, hogy könnyen olvasható. Ez azért fontos, mert a forráskódot nem magunknak írjuk, hanem más programozóknak, akik tovább fogják azt fejleszteni. Még abban az esetben is, ha saját magunk fejlesztjük tovább, akkor is egy idegen programozónak írjuk a kódunkat, mert gyakran megfigyelhető, hogy egy néhány hónappal korábban írt programról már nem ismerjük fel, hogy azt saját magunk írtuk.
A könnyen olvashatóság egyik ismérve, hogy a kód olvasása közben nem kell ide-oda ugrálnunk a forráskódban. Ezt úgy érjük el, hogy a belépési pont az első metódus. Ha ebben a metódusban meghívjuk az A, B, és C metódusokat, akkor ezek ilyen sorrendben követik ezt a metódust.
A tiszta kód másik ismerve, hogy nem tartalmaz megjegyzést. Természetesen az elején lehet copyright megjegyzés, illetve használhatunk öndokumentáló megjegyzést a szerződések rögzítésére (lásd: LSP), de nem lehet benne olyan megjegyzés, ami egy mezőt vagy egy kódrészletet magyaráz. Ha ilyen van a kódunkban, azzal beismerjük, hogy nem használunk beszédes változó neveket, nehezen érthető részek vannak a kódban, illetve, hogy konvenciókat használunk, amit, ha a többi programozó nem tart be, akkor összeomlik a programunk. A másik probléma a megjegyzésekkel, hogy gyakran elszakadnak a kódtól, nem változnak együtt a kóddal. Egy ilyen megjegyzést senki se mer törölni, mert lehet, hogy egy későbbi hibajavításhoz fontos lesz.
A tiszta kód ajánlást ad a metódusok méretére. Egy metódus legyen 5-6 soros, csak 1-2 if utasítást tartalmazzon, 1 ciklust, kivételes esetben többet. Az ilyen metódusokat könnyű megérteni. Ha ezek a metódusok olyan metódusokat hívnak, amelynek beszédes neve van, akkor gyakran ezeket már meg se kell nézni.
Fontos, hogy kerüljük a mellékhatásokat. Mellékhatás az, ha egy metódus megváltoztatja a környezetét, azaz, ha megváltoztatja valamelyik mező értékét (belsőállapot-átmenet), kiír a képernyőre, valamelyik portra üzenetet küld. Ugyanakkor nem lehet teljesen elkerülni a mellékhatást. Az ajánlás szerint, ha egy metódus visszaad valamit, azaz kiszámol valamit, akkor ne legyen mellékhatása. Ha void-ot add vissza, akkor lehet mellékhatása.
A paraméterlistára is vannak ajánlások. Törekedjünk a rövid paraméterlistákra. A legjobb, ha egy paraméterünk sincs, egy vagy kettő elfogadható, három már soknak számít. Ne használjunk logikai paramétert, illetve ne használjunk kimeneti paramétert.
Cserkészszabály
A tiszta kód egyik alapelve a cserkészszabály (angolul: boy scout rule), amely így szól:
Mindig hagyd a táborhelyet tisztábban, mint ahogy találtad.
Szoftverfejlesztés esetén ez azt jelenti, hogy ha a verziókövető rendszerből kiveszünk egy osztályt, akkor kötelesek vagyunk tisztábban visszatenni. Gondoljunk bele, ha ezt mindenki betartaná, akkor a forráskódunk egyre tisztább és tisztább lenne.
Rothadó kód
A tiszta kód ellentétje a rothadó kód (angolul: rotting code). Akkor mondjuk, hogy a kód rothad, ha a programozóink már nem mernek hozzányúlni, mert attól félnek, hogy egy hibajavítás egy másik hibát fog eredményezni.
A rothadó kód nagyon lelassítja a fejlesztést, ami ahhoz vezet, hogy a versenytársak megelőzik a cégünket, végül tönkre megyünk.
Rothadó kód egy szép tiszta kódból lesz. A fő elvünk kimondja, hogy a kód állandóan változik. A szép tiszta kód is változik, és ahogy változik, kezd szép lassan csúnya rothadó kóddá változni. Ennek legfőbb oka, hogy nem tartjuk be a tervezési alapelveket, például switch szerkezetet vagy if – else – if szerkezetet használunk, illetve nem refaktoráljuk a kódot, hogy bevezessünk egy-egy tervezési mintát, amikor már látszik, hogy érdemes lenne használni.
A rothadó kódot megelőzik a kódszagok (angolul: code smell). A szakirodalom nagyon sok ilyen szagot ismer. Ezek közül a legegyszerűbbek:
túl nagy metódusok,
túl nagy osztályok,
osztályok sok mezővel,
duplikált kódrészletek, copy/paste kódrészletek,
burjánzó if – else –if és/vagy switch szerkezetek,
megvalósításra programozás,
erős csatoltság, pl. Demeter törvényének megsértésével.
Illetve a rossz szagok. Amíg a kódszag inkább csak jelzés, hogy a szag forrását érdemes lenne ellenőrizni, addig a rossz szag már komoly figyelmeztetés, hogy hozzá kell fogni a kód kitisztításához. A szakirodalom a következő rossz szagokat különbözteti meg:
Merevség (angolul: rigidity): A rendszert nehéz megváltoztatni, egy-egy változtatás sokkal több időbe telik, mint amennyit becsültünk a feladatra, egy-egy változás nem várt nehézségekbe ütközik.
Törékenység (angolul: fragility): A rendszer nagyon érzékeny a változásokra, egy-egy változás nagyon sok további változást von maga után, egy-egy hibajavítás mindig újabb és újabb hibákat szül.
Mozdulatlanság (angolul: immobility): A rendszer egyes részeit funkciójuk szerint jó lenne újra felhasználni, de az újrafelhasználás komoly erőfeszítéseket igényelne.
Viszkozitás (angolul: viscosity): Egy-egy változtatás nagyon körülményes, inkább a „vállunk felett átnyúlós”, „workaround” megoldást választjuk. Másik formája, amikor olyan lassú a fordítás, hogy arra törekszünk, hogy csak kevés osztályt kelljen újrafordítani, ezért nem oda teszem a metódusokat, ahova kellene, hanem oda, amit könnyű újrafordítani.
Szükségtelen komplexitás (angolul: needless complexity): Sok változata van. A legmarkánsabb, amikor túlbonyolítunk egy osztályt, hogy egy későbbi változást könnyű legyen kezelni, de az a változás sohasem következik be.
Homályosság (angolul: opacity): Nehezen olvasható, nehezen érthető kód.
Lecke 12.: Egységteszt
A lecke célja és tartalma
Célok, megszerezhető kompetenciák: A lecke végére megismerkedünk az egységteszt alapjaival, illetve, hogy az egyes IDE-kben hogyan kell egységtesztet írni.
Szükséges eszközök, források: Visual Studio, IntelliJ
Feldolgozási idő: 30 perc.
Témakörök: Egységteszt készítése IntelliJ-ben JUnit5 csomagot használva, Egységteszt készítése Visual Studio-ban.
A lecke tartalma: Ebben a leckében áttekintjük, hogyan kell egységtesztet, vagy más szóval unit-tesztet írni két nagyon elterjedt integrált fejlesztési környezetben (angolul: IDE). Ezek az IntelliJ és a Visual Stúdió. Ebben a leckében nem térünk ki a JUnit5, illetve a C# UnitTest minden részletére, csak az alapokat mutatjuk be.
Bevezetés
Az egységteszt, vagy más néven unit-teszt a metódusok tesztje. Egy egységtesztben rögzítjük a metódus paramétereit, illetve megmondjuk, hogy erre a bemenetre mi az elvárt kimenet. Lefuttatjuk a metódust a rögzített paraméterekkel. Így megkapjuk az aktuális visszatérési értéket. A kettőt összehasonlítjuk, és ha ugyanaz, akkor az egységteszt zöld lesz, ha nem, akkor piros.
Egy példa egységteszt, először Javában:
@Test
public void TestMethod1() {
    SzámolóGép target = new SzámolóGép();
    int a = 2;
    int b = 2;
    int expected = 4;
    int actual = target.Összead(a,b);
    Assertions.assertEquals(expected,actual);
}
Illetve C#-ban ugyanaz:
[TestMethod]
public void TestMethod1()
{
    SzámolóGép target = new SzámolóGép();
    int a = 2;
    int b = 2;
    int expected = 4;
    int actual = target.Összead(a, b);
    Assert.AreEqual(expected, actual);
}
Jól látható, hogy a SzámolóGép osztály Összead metódusát teszteljük. Ennek két paramétere van, a és b. Ezeket fixáljuk, jelen esetben mind a kettő 2 lesz. Megadjuk, hogy erre a bemenetre az elvárt kimenet (a kódban: expected) 4. Kiszámoljuk az aktuális kimentet (a kódban: actual). Majd a kettőt összehasonlítjuk.
Az egységtesztek legnagyobb előnye, hogy egyszerre el tudjuk indítani az összes tesztesetet, egyetlen gombnyomással. Így a regressziós teszt nagyon egyszerűvé válik, hiszen egy-egy változtatás után csak le kell futtatnnunk az összes egységtesztet, ami csupán egy gombnyomás!
Egységteszt készítése JUnit5 és Maven használata esetén
Ahhoz, hogy egységtesztet, vagy más néven unit-tesztet tudjunk írni Javában, ahhoz kell egy ezt támogató keretrendszer. Napjainkban a legelterjedtebb keretrendszer a JUnit5, amit külső függőségként kell hozzáadni a projekthez. Ezt talán legegyszerűbb a Maven építés-automatizálási segédeszköz (angolul: build-automation utilities) megtenni.
Maven esetén a pom.xml nevű állományba kell felsorolni a külső függőségeket. JUnit5 használatához ezeket a sorokat kell beszúrni a pom.xml-be:
<dependencies>
    <dependency>
        <groupId>org.junit.jupiter</groupId>
        <artifactId>junit-jupiter-engine</artifactId>
        <version>5.9.2</version>
        <scope>test</scope>
    </dependency>
</dependencies>
Ezek után egy frissítést kell futtatni. IntelliJ IDE esetén az a pom.xml-ben jobb klikk (helyi menü) -> Maven -> Reload project menüvel lehetséges, vagy a pom.xml ablak jobb felső sarkában megjelenő Reload gomb segítségével. Ezután már a következő kis program futtatható lesz:
import static org.junit.jupiter.api.Assertions.assertEquals;
import org.junit.jupiter.api.Test;
import org.example.SzámolóGép;
public class Test1 {
    @Test
    public void TestMethod1() {
        SzámolóGép target = new SzámolóGép();
        int a = 2;
        int b = 2;
        int expected = 4;
        int actual = target.Összead(a, b);
        assertEquals(expected, actual);
    }
}
Figyeljük meg, hogy szükség van néhány import-ra. Az első import rögtön nagyon érdekes, hiszen ez egy osztály statikus metódusát importálja import static kulcsszavak segítségével. Az első import lehetővé teszi, hogy az elvárt és az aktuális érték összehasonlítható legyen assertEquals segítségével.
A második import ahhoz szüksége, hogy használhassuk a @Test annotációt. Ez az az annotáció, ami egy metódust unit-tesztté tesz. A harmadik import ahhoz kell, hogy a SzámolóGép osztályt tesztelni tudjuk.
Ezen túl ebben a kis példában megvan minden, ami egy klasszikus unit-teszthez kell:
target,
fix input paraméterek,
elvárt érték,
aktuális érték,
a kettő összehasonlítása.
Egységteszt készítése Visual Studio 2013 vagy újabb esetén
Ahhoz, hogy egységtesztet, vagy más néven unit-tesztet tudjunk írni Visual Studio 2013 segítségével, ahhoz az alábbi 3 előkészítő lépést kell megtennünk:
Unit Test Projekt hozzáadása az aktuális Solution-höz: A SolutionExplorer-ben (View -> Solution Explorer) a Solution-ön jobb klikk, majd Add -> New project … -> Visual C# -> Test -> Unit Test Project -> OK.
A Unit Test Projekten belül referenciák kibővítése a projekttel, amit tesztelni akarunk: A Solution Explorer-ben a UnitTestProjecten1-en belül a References-en jobb klikk, majd Add Reference… -> Solution –> Projects, az Application neve melletti jelölő négyzetbe pipa, majd OK.
A UnitTest1.cs fájlba beírni egy using utasít, hogy hivatkozni tudjunk a tesztelendő osztályokra: ha a tesztelni kívánt osztályok a ConsoleApplication4 névtérben vannak, akkor a „using ConsoleApplication4;” utasítást kell beleírni.
Ha minden sikerült, akkor a UnitTest1.cs fájlunk így fog kinézni:
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication4;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
Ha a fenti leírás alapján nem sikerülnek az előkészítő lépések, akkor érdemes megnézni egy sokkal részletesebb útmutatót, amely itt található: 
https://learn.microsoft.com/en-us/visualstudio/test/getting-started-with-unit-testing?view=vs-2022.
Egységteszt készítése Visual Studio 2008 és 2010 esetén
Egységtesztet, vagy más néven unit-tesztet Visual Studio 2008 és 2010 programmal is készíthetünk. Ehhez a következő menükön kell végigmenni: Test -> New Test… -> Unit Test Wizard –> a metódus kiválasztása, amelyhez egységtesztet szeretnénk készíteni.
Egy példa egységteszt amelyet a fenti eljárással generáltunk a maximum értéket visszaadó max(int a, int b) metódushoz:
[TestMethod()]
public void MaxTest()
{
   Program target = new Program(); // TODO: Initialize to an appropriate value
   int a = 10; // TODO: Initialize to an appropriate value
   int b = 20; // TODO: Initialize to an appropriate value
   int expected = 20; // TODO: Initialize to an appropriate value
   int actual;
   actual = target.max(a, b);
   Assert.AreEqual(expected, actual);
}
A két mező értékét és az elvárt visszatérési értéket kézzel állítjuk be.
Összegzés és ellenőrző kérdések
Ebben a leckében áttekintettük, hogyan kell egységtesztet, vagy más szóval unit-tesztet írni két nagyon elterjedt integrált fejlesztési környezetben (angolul: IDE). Ezek az IntelliJ és a Visual Stúdió. Ebben a leckében nem tértünk ki a JUnit5, illetve a C# UnitTest minden részletére, csak az alapokat mutattuk be.
Ellenőrző kérdések:
Kérdés: Java esetén melyik a legelterjedtebb unit-tesztelési környezet?
Válasz: Jelen pillanatban a JUnit5 csomag a legelterjedtebb.
Kérdés: Melyen 5 pontból áll általában egy unit-teszt?
Válasz: Target, fix input paraméterek, elvárt érték, aktuális érték, a kettő összehasonlítása.
Kérdés: Maven használata esetén hova kell írnia JUnit5 függőségeit?
Válasz: A POM.XML fájlba kell írni a <dependencies> részbe.
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
Lecke 14.: Viselkedésvezérelt fejlesztés – Behaviour Driven Development – BDD
A lecke célja és tartalma
Célok, megszerezhető kompetenciák: A lecke végére megismerkedünk és gyakorlati tapasztalatot kapunk a BDD technológiában egy példa megvalósításán keresztül.
Szükséges eszközök, források:
Java SDK, IntelliJ IDEA, Maven build tool, Cucumber for Java plugin az IntelliJ-hez
https://www.jetbrains.com/idea/download
https://cucumber.io/docs/installation/
https://maven.apache.org/install.html
https://www.oracle.com/java/technologies/downloads/
Feldolgozási idő: 90 perc.
Témakörök: Bevezetés a BDD módszertanba, a Gherkin nyelv megismerése és a Cucumber használata.
A lecke tartalma: 2000 környékén Daniel Terhorst-North szerette volna a TDD módszertanát továbbfejleszteni, mivel úgy érezte, hogy vannak hiányosságai, melyet a fejlesztésben résztvevő három fél közti kollaboráció definiálatlansága okoz. Mind a három félnek megfelelő információval kell rendelkeznie a feladatról, ugyanazokat a folyamatokat kell követnie és lehetőleg a legrövidebb idő alatt kell a feladatot megfelelően végrehajtania. Ennek eredményeképpen, létrehozta a JBehave eszközt a Java nyelvhez, hogy viselkedéseket (angolul: behaviour) tudjon definiálni tesztek helyett.
Bevezetés
Viselkedésvezérelt fejlesztés (angolul: Behaviour-Driven Development - BDD) a TDD édestestvére, habár nem a tesztelésre helyezi a fő fókuszt, hanem a „Három Amigó” közös munkájára.
A TDD szoftverfejlesztési technika összefüggésben áll az extrém programozással (angolul: eXtreme Programming - XP), az automatizált tesztekkel, melyek első teszteléskor még hibát jeleznek, hiszen az üzleti logika nincs készen. De a fejlesztés előrehaladtával, ahogy a kódunk kiteljesedik, a tesztek is sikerrel zárulnak.
A technika előnye, hogy a teszteket a későbbiekben is fel tudjuk használni annak ellenőrzésére, hogy bármilyen változtatás hatása nem hoz negatív eredményt, azaz a programunk még mindig hiba nélkül fut. A nehézséget leginkább az okozza, hogy meg tudjuk jól fogalmazni a teszteket, az üzleti logikát és a teljesítés kritériumait. Amennyiben megköveteljük a mindenre kiterjedő tervezést, akkor megsértjük az agilis módszertan alapelveit. Ugyanakkor rendelkezésre állnak olyan eszközök, mint a felhasználói történetek (angolul: User Story) ahol mindennek az alapját le tudjuk fektetni. A BDD ezen definíciókat használja és konvertálja olyan viselkedésekké, amit a kódunknak meg kell valósítania.
A BDD nem tesztek írására szolgál, hanem a „Három Amigót”, az üzleti elemzőt / termék tulajdonost, a fejlesztőt és a tesztelőt (angolul: Three Amigos - business analyst/product owner, developer, tester) összeköti, hogy a definiálást követően implementálni tudják, végül pedig ellenőrizhessék a megvalósított funkciókat melyen a User Storyk-ban lettek megfogalmazva.
A BDD nem csak tesztelési módszer 
„A BDD olyan módszer egy szoftverfejlesztő csapat számára, amivel az üzletemberek és fejlesztők közti különbségeket át lehet hidalni a következők segítségével:
Szerepek közötti együttműködés ösztönzése a megoldandó probléma közös megértésének kialakítása érdekében,
Gyors, kis iterációkban végzett munka a visszacsatolás és az információ áramlás növelése érdekében,
Rendszerdokumentáció készítése, amely automatikusan ellenőrzi van a rendszer viselkedéséhez.
Ezt úgy érjük el, hogy az együttműködés konkrét, valós példákra alapozva készül, melyek a rendszer tényleges viselkedését illusztrálják. Ezeket a példákat használjuk arra, hogy eligazodjunk az ötlettől a megvalósításig, a folyamatos együttműködés során.” Forrás: https://cucumber.io/docs/bdd/.
A Kiáltvány az agilis szoftverfejlesztésért (The Agile Manifesto), többek közte előnyben részesíti „a működő szoftvert az átfogó dokumentációval szemben” valamint „a változás iránti készséget a tervek szolgai követésével szemben”, lásd: http://agilemanifesto.org/iso/hu/manifesto.html.
Úgy is fogalmazhatunk, hogy a változó követelmények ellenére mindig működő szoftvert kell létrehozni. Ugyanakkor a változó követelmények le kell tudni írni, talán ennek a legmegfelelőbb módszere a megrendelő felkérése könnyen érthető, de technológiailag mégis hasznos felhasználói történetek megfogalmazására. Ilyen dokumentumok segítségével a termék tulajdonos (angolul: product owner) lényegében kapcsolódási felületet biztosít a kliens és a fejlesztők között. Hiszen tartalmazni fogja a követelményeket és az elvárt eredményeket is, ennek megfelelően a felhasználói történet célja megadja az elfogadás kritériumát is az automatizált tesztek végén.
Látható, hogy a BDD nem a tesztelésről szól, sokkal inkább egy olyan eljárást ad, amivel apró iterációkra bonthatók a nagy feladatok. Három lépésre bonthatjuk fel egy BDD iterációját:
Felfedezés (angolul: Discovery),
Kialakítás (angolul: Formulation),
Automatizáció (angolul: Automation).
És az eredmény pedig a működő szoftver természetesen.
A felfedezés fázist arra használjuk, hogy minden résztvevő számára érthető követelményeket szedjünk össze, valós példákra alapozva. Ez sokkal inkább egy olyan folyamat, ahol arról beszélgetnek a résztvevők, mit csinálhat majd a rendszer. Célszerű a Három Amigonak reszt vennie rajta, sőt bevonhatják a UX tervezőt is.
A kialakítás fázis során már inkább arra koncentrálunk mit valósítson meg a rendszer. Célszerű ezt a fejlesztőknek végrehajtania, esetleg a tesztelők iránymutatásával, a végeredményt pedig az üzleti elemző (angolul: business analyst) vagy a termék tulajdonos (angolul: product owner) részéről el kell fogadtatni. Ez az a fázis, ahol a felfedezés fázis felhasználói történeteit átkonvertáljuk a Gherkin nyelvre.
Az automatizáció fázis használja fel a kialakítás fázis futtatható dokumentációját, hogy automatizált teszteket készítsen belőle, az üzleti folyamatok implementációjának segítésére.
A felhasználói történetek érthetően az üzleti elemző (angolul: business analyst) vagy a termék tulajdonos (angolul: product owner) számára, és lényegében ez az, amit a Gherkin nyelv is leír, ami pedig könnyen érthető a fejlesztő számára. Végezetül pedig a Gherkin nyelvet a Cucumber eszköz fel tudja dolgozni és akár emberi olvasásra alkalmas teszteket készít belőle.  Ezért a Gherkin nyelv az, ami egységesen érthető minden szereplő számára, ugyanakkor a követelmények és az eredmények leírása mellett létrejön vele az elkészült kód dokumentációja is.
A Gherkin nyelv bemutatása példákon keresztül
A Gherkin nyelv hasonlatosságot mutat a felhasználói történetek megfogalmazásaihoz, emiatt könnyen megtanulható minden résztvevő számára. A nyelv egyaránt olvasható ember és szoftver számára, csak pár kulcsszóból és speciális karakterből áll.
A Gherkin nyelv kulcsszavai:
Feature
Scenario (or Example)
Scenarios (or Exmaples)
Given
When
Then
And
But
Background
Scenario Outline /Scenario Template
Addicionális információt hordozó speciális karakterek:
Doc String – a Step definíciókban használatosak több sornyi szöveg ábrázolására. Erre a szöveget három darab idézőjel közé kell tenni (“ “ “).
Data Table – táblázatos adatok felsorolását teszi lehetővé, a | karaktert használja.
Feature lerások címkék (Tag-ek) segítségével összeköthetők, ilyen címkéket a @ karakter segítségével tudunk készíteni.
Megjegyzéseket minden újsorban a # karakter után adhatunk meg.
Nézzünk meg egy példát!
Feature: Bridge-keeper test.
  In Monty Python and the Holly Grail the bridge-keeper at the 
  Bridge of Death asks three questions to let someone path the bridge. One question is about the favourite colour.  
  Scenario: What is your favourite colour?
  Given that it is blue
  When I supply blue colour as my answer
  Then I should be told ‘Right. Off you go.’
Vagy vegyünk egy technológiaibb beállítottságú példát:
Feature: Gross price calculator
  In Hungary most product has 27% VAT included in its price. 
  Adding VAT to net price should result gross price.
  Scenario: What is the gross price of a product?
  Given that the net price is 100
  When I calculate gross price
  Then I should get result 127
A kialakítás (angolul: formulation) fázisban lettek ez a funkció létrehozva, tartalma pedig egyetlen Scenario több Step definícióval.
Feature: A Gherkin Feature-ök .feature kiterjesztésű szövegfájlokba kerülnek, aminek legelső kulcsszava a Feature amit egy kettőspont követ ( Feature: ). A Feature definíció a Feature: után írt névvel lesz teljes. 
A következő sortól pedig az adott funkcióról írhatunk több soros leírást. Ezt mindaddig folytathatjuk, míg egy Background, Rule, Scenario (vagy Example) kezdetű új sor meg nem jelenik. Ezt a leírást nem használja a Gherkin, de a későbbiekben a szoftver dokumentálásához, vagy az elvárt viselkedés megértéséhez hasznos lehet. 
Egy Feature több Scenaro-t, Example-t, vagy Scenario Outline-t tartalmazhat, de csak egy Feature lehet egy .feature fájlban definiálva.
Scenario vagy Example: Ugyanazt takarják, bármelyiket megadhatjuk egy példa megadására. Tartalmazhat egy vagy több Step definíciót a leíráshoz.
Step: Egy Scenario működésének lépéseit fogalmazza meg, így egyszerűsödik a példa megértése. Minden Step egy új sorba kerül.
A következő kulcsszavakkal definiáljuk a lépéseket: Given, When, Then, And, But.
Given segítségével adhatjuk meg a Scenario kezdőállapotát. Ennek jól definiált állításnak kell lennie ennek megfelelően. Amennyiben összetettebb a probléma minthogy egyetlen Given lépésben meg tudnánk fogalmazni, akkor további Given sorokkal bővíthetjük annak leírását.
And és But ugyanarra használatosak, mint a Given, de sokkal olvashatóbbá teszik a kezdeti állapot leírását, kiemelve logikai összefüggéseket is. Mindenképp jobb gyakorlat ezeket használni több Given helyett.
When segítségével adhatunk olyan eseményeket, amelyek kezdeményezik a Scenario végrehajtását.
Then pedig lekezeli az őt megelőző lépések eredményét.

Example: Lunch requirements
  Given that I am hungry
  Given that I am thirsty
  Given that I am driving after lunch
  When I order meal
  Then I should order food and beverage
  But I shouldn't order alcohol
De ugyanezt leírhatjuk And és But segítségével is.
Example: Lunch requirements
  Given that I am hungry
  And I am thirsty
  But I am driving after lunch
  When I order meal
  Then I should order food and beverage
  But I shouldn't order alcohol

Background: Amikor több olyan Scenario-t hozunk létre egy Feature-ben, aminek közös lépései vannak, akkor ezen közös részeket kiemelhetjük egy Background definícióba. Minden Scenario előtt a Background-ban tárolt lépések meg lesznek hívva, emiatt ezt a legelső Scenario vagy Example előtt kell létrehozni. És mivel minden Scenario számára közös lesz, csak egyetlen Background lehet egy Feature fájlban.
Például:
Feature: Testing user roles.
  Background:
    Given an administrator with username “admin”
    And a user with username “user”
  Scenario: Setting up a new user as an administrator
    Given I am logged in with username “admin”
    When I enter to the system
    Then I should see “Add new user”
  Scenario: Setting up a new user as a user
    Given I am logged in with username “user”
    When I enter to the system
    Then I should not see "Add new user"

Scenario Outline / Scenario Template: Abban az esetben, ha ugyanazt a Scenario-t kell többször lefuttatnunk, de különböző paraméterekkel, akkor természetesen lemásolhatjuk a Scenario-t és készíthetünk variánsokat belőle. Ugyanakkor ez nem jó módszer, hiszen, ha valamit az elsőben javítani kell, akkor azt át kell vezetni minden változatán is, ami fáradtságos munka lehet, nem beszélve a hibalehetőségekről. Ennek megoldására szolgál a Scenario Outline (vagy Scenario Template) amivel a változó paraméterket adhatjuk meg táblázatos formában.
Scenario Outline: PIN code entry
  Given a pinpad to enter a PIN code
  When I enter <pin> 
  Then I should get <result> as a reply
  Examples:
    | pin  | result |
    | 1234 |  false |
    | 1111 |  true  |
    | 0000 |  false |
Sokkal átláthatóbbá válik ezáltal a példa és könnyebb is változtatni rajta.
A táblázat fejléce a változók nevei, amikre a szövegben a < és > jelek között hivatkozhatunk, a táblázat oszlopait pedig a | karakter segítségével építhetjük fel. 
Data Tables: Data Tables, vagyis adattáblák olyan tömbök, amiket változó értékek felsorolásár ahasználhatunk, ugyanakkor a Data Tables API összetettsége miatt túlmutat jelen dokumentum méretein, további információt a hivatalos dokumentációban lehet találni róla: https://github.com/cucumber/cucumber-jvm/tree/main/datatable
Doc String: Amennyiben egy Step leírása többsoros definíciót igényel, azt Doc String megadásával tehetjük meg, amit három darab idézőjellel tudunk megadni.
Scenario: Entering a multiline recipe
  Given that we have a recipe
  """
  1. Fill up the kettle with water
  2. Boil the water
  3. Place a teabag in a mug
  4. Pour boiling water into the mug
  5. Brew the tea for 30 seconds
  6. Remove the teabag
  7. Enjoy your tea
  """
  When I enter it into the text entry field
  Then I should see the whole recipe and not just the first line
A Cucumber használatának bemutatása
Az automatizáció (angolul: automation) fázis során a Gherkin nyelven megfogalmazott viselkedések átalakításra kerülnek végrehajtható tesztekké. A Cucumber az az eszköz, ami fel tudja dolgozni a Gherkin nyelvet és legenerálja a kívánt kódot. Mi az IntelliJ pluginját fogjuk használni a következő példában.
Ahhoz, hogy a BDD-t ki tudjuk próbálni, el kell készítenünk egy Java projektet. Ehhez indítsuk el az IntelliJ-t! Amennyiben volt már projekt megnyitva, akkor a File menü Close parancsával zárjuk be. A megjelenő Welcome to IntelliJ ablakban kattintsunk a New Project gombra, aminek hatására megjelenik a New Project ablak:

New Project ablak
Adjuk meg a projekt adatait.
A projekt neve legyen cucumber_example. Telepítve kell lennie egy JDK-nak is, ezt a JDK résznél választhatjuk ki. A build eszköz legyen Maven, és a forráskódunk nyelve pedig Java. Győződjünk meg róla, hogy az Add sample code engedélyezve van, mivel ezzel az alap Java osztályokat is elkészíti a fejlesztői környezet. Ha mindent megadtunk, akkor kattintsunk a Create gombra!
A projekt az elkészülte után betöltődik az IntelliJ-be és a szerkesztő felületen megnyílik a Main osztályunk, ami tartalmazza a main() belépési pontot.
Ahhoz, hogy a Cucumbert használni tudjuk, a pom.xml projekt konfigurációs fájlt is szerkesztenünk kell. Induláskor a következő tartalma lesz:
<?xml version="1.0" encoding="UTF-8"?>
<project xmlns="http://maven.apache.org/POM/4.0.0"
         xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
         xsi:schemaLocation="http://maven.apache.org/POM/4.0.0 http://maven.apache.org/xsd/maven-4.0.0.xsd">
    <modelVersion>4.0.0</modelVersion>
    <groupId>org.example</groupId>
    <artifactId>cucumber_example</artifactId>
    <version>1.0-SNAPSHOT</version>
    <properties>
        <maven.compiler.source>16</maven.compiler.source>
        <maven.compiler.target>16</maven.compiler.target>
        <project.build.sourceEncoding>UTF-8</project.build.sourceEncoding>
    </properties>
</project>
Adjuk a következőket a </properties> és </project> tag-ek közé. Ezek segítségével a Maven letölti mindazokat a függőségeket, melyekre a projektnek szüksége van.
<dependencyManagement>
    <dependencies>
        <dependency>
            <groupId>io.cucumber</groupId>
            <artifactId>cucumber-bom</artifactId>
            <version>7.17.0</version>
            <type>pom</type>
            <scope>import</scope>
        </dependency>
        <dependency>
            <groupId>org.junit</groupId>
            <artifactId>junit-bom</artifactId>
            <version>5.10.2</version>
            <type>pom</type>
            <scope>import</scope>
        </dependency>
    </dependencies>
</dependencyManagement>
<dependencies>
    <dependency>
        <groupId>io.cucumber</groupId>
        <artifactId>cucumber-java</artifactId>
        <scope>test</scope>
    </dependency>
    <dependency>
        <groupId>io.cucumber</groupId>
        <artifactId>cucumber-junit-platform-engine</artifactId>
        <scope>test</scope>
    </dependency>
    <dependency>
        <groupId>org.junit.platform</groupId>
        <artifactId>junit-platform-suite</artifactId>
        <scope>test</scope>
    </dependency>
    <dependency>
        <groupId>org.junit.jupiter</groupId>
        <artifactId>junit-jupiter</artifactId>
        <scope>test</scope>
    </dependency>
</dependencies>
<build>
    <plugins>
        <plugin>
            <groupId>org.apache.maven.plugins</groupId>
            <artifactId>maven-compiler-plugin</artifactId>
            <version>3.13.0</version>
            <configuration>
                <encoding>UTF-8</encoding>
                <source>1.8</source>
                <target>1.8</target>
            </configuration>
        </plugin>
        <plugin>
            <groupId>org.apache.maven.plugins</groupId>
            <artifactId>maven-surefire-plugin</artifactId>
            <version>3.2.5</version>
        </plugin>
    </plugins>
</build>
A szerkesztés után a változtatások érvényesítéséhez kattintsunk a következő Load Maven Changes gombra.

Load Maven Changes
Ezzel tudjuk a pom.xml változásait érvényesíteni.
Következő lépésben létrehozzuk azt a .feature fájlt amibe elkészítjük az első BDD Feature-t. Ehhez jobb egérgombbal kattintsunk a src/main/java/resource könyvtáron a projekt ablakban. A megjelenő felugró ablakban válasszuk a New majd File menüpontokat. 

New File
Hozzunk létre egy FirstFeature.feature fájlt.
A fájl neve legyen FirstFeature.feature. Az elkészült fájlunk megjelenik a src/main/java/resources útvonalon és tartalma természetesen üres lesz.
Másoljuk át bele a következőket!
Feature: Learning Cucumber
  We are creating a Feature for learning the use of Gherkin and Cucumber.
  Scenario: Adding two numbers together
    Given that I have an initial value of 5
    When I add 2 to it
    Then I get 7

Oldalt a sorszámok mellett láthatunk két darab kettős nyilat, egyk a Feature: mellett, a másik pedig a Scenario: mellett jelenik meg. A Feaure melletti minden Scenario-t lefuttat, ha pedig kiválasztunk egy Scenario-t akkor csak azt.

Scenario-k futtatása
Run ‘Future: FirstFeature’

Indítsuk el a Feature: mellettit, ehhez a kettős nyílra kell kattinatni, majd a megjelenő felugró ablakból ki kell választani a Run ‘Future: FirstFeature’ menüpontot.
És evvel végre is hajtottuk az első Cucumber tesztünket!
Ami a következőhöz hasonló hibával fog leállni:
Step undefined
You can implement this step and 2 other step(s) using the snippet(s) below:


@Given("that I have an initial value of {int}")
public void that_i_have_an_initial_value_of(Integer int1) {
    // Write code here that turns the phrase above into concrete actions
    throw new io.cucumber.java.PendingException();
}
@When("I add {int} to it")
public void i_add_to_it(Integer int1) {
    // Write code here that turns the phrase above into concrete actions
    throw new io.cucumber.java.PendingException();
}
@Then("I get {int}")
public void i_get(Integer int1) {
    // Write code here that turns the phrase above into concrete actions
    throw new io.cucumber.java.PendingException();
}


Step skipped
Step skipped
Undefined scenarios:
…
1 Scenarios (1 undefined)
3 Steps (2 skipped, 1 undefined)
0m0,561s
Mivel még semmilyen kódot nem hoztunk létre, így a hiba amit kapunk: 1 Scenarios (1 undefined) and 3 Steps (2 skipped, 1 undefined) azt jelenti, hogy egy Scenario-bó 2 Step át lett ugorva és egy pedig nincs definiálva. De ez az elvárt viselkedés, mivel nincs még egyetlen tesztünk sem elkészíte. Ugyanakkor segítséget is kapunk a hiba javításához: “You can implement missing steps with the snippets below”. 
@Given("that I have an initial value of {int}")
public void that_i_have_an_initial_value_of(Integer int1) {
    // Write code here that turns the phrase above into concrete actions
    throw new io.cucumber.java.PendingException();
}


@When("I add {int} to it")
public void i_add_to_it(Integer int1) {
    // Write code here that turns the phrase above into concrete actions
    throw new io.cucumber.java.PendingException();
}


@Then("I get {int}")
public void i_get(Integer int1) {
    // Write code here that turns the phrase above into concrete actions
    throw new io.cucumber.java.PendingException();
}
Hajtsuk is végre ezt! Kattintsunk jobb egérgombbal az src/test könyvtáron a projekt ablakban, majd a felugró ablakban New és a Package menüpontokat válasszuk ki. Célszerű ugyanazt a csomagnevet megadni, amit a Main-nél is használunk (ez alapból az: org.example). 
Amint megjelenik a csomag a test könyvtárban, máris létrehozhatjuk a szükséges tesztosztályokat. Jobb egér kattintás a csomagnéven, majd New és Java Class a felugró ablakból. Hívjuk az új osztályunkat a következőnek: StepDefinitions.

New / Java Class
Válasszuk az osztály létrehozást, majd névnek adjuk meg a StepDefinitions-t.
Amint a StepDefinitions osztály elkészült, másoljuk bele a hibába javasolt hiányzó sorokat!
A Given, When és a Then piros színnel ki lesznek emelve, mivel hiányoznak az őket tartalmazó csomagok importjai. Ehhez fogadjuk el a következő képen látható úgynevezett Quick Fix gyorsjavításokat.

Importáljuk a megfelelő csomagokat
Quick Fix javaslatokat biztosít számunkra a hiba megoldására.
Vagy ha úgy gyorsabb, akkor a következő import sorokat másoljuk az osztály elejére:
import io.cucumber.java.en.Given;
import io.cucumber.java.en.Then;
import io.cucumber.java.en.When;
Amint a javításokkal elkészülünk, máris futtathatjuk a tesztet ismét. Továbbra is elbukik mind a három teszt, mivel nincs valódi tartalmuk. 
Nézzük meg a StepDefinitions osztály tartalmát!
@Given("that I have an initial value of {int}")
public void that_i_have_an_initial_value_of(Integer int1) {
    // Write code here that turns the phrase above into concrete actions
    throw new io.cucumber.java.PendingException();
}


@When("I add {int} to it")
public void i_add_to_it(Integer int1) {
    // Write code here that turns the phrase above into concrete actions
    throw new io.cucumber.java.PendingException();
}


@Then("I get {int}")
public void i_get(Integer int1) {
    // Write code here that turns the phrase above into concrete actions
    throw new io.cucumber.java.PendingException();
}
A három darab Gherkin lépés három darab metódussá lesz átkonvertálva, felhasználva a lépések definícióit a metódus nevek létrehozásához. Mindegyik annotálva lesz valamelyik annotációval a következők közül: @Given, @When and @Then. Illetve ahol a leírásban számot érzékelt a Cucumber, ott egy integer egész változót hoz létre.
Folytassuk a tényleges üzleti logika implementálásval!
Készítsünk egy új Java osztályt Calculator névvel és a következő tartalommal (jobb egérkattintás a Man osztályt tartalmazó csomag nevén, majd New / Java Class és az osztály neve legyen Calculator:
package org.example;
public class Calculator { 
    public int firstNumber;
    public int secondNumber;
    public int add(){
        return firstNumber+secondNumber;
    }
}
Ezt követően lépjünk vissza a StepDefinitions osztályba és módosítsuk a 3 metódust a következők szerint:
package org.example;
import io.cucumber.java.en.Given;
import io.cucumber.java.en.Then;
import io.cucumber.java.en.When;
import static org.junit.jupiter.api.Assertions.assertEquals;
public class StepDefinitions {
    Calculator calculator = new Calculator();
    int actualResult = 0;
    @Given("that I have an initial value of {int}")
    public void that_i_have_an_initial_value_of(Integer int1) {
        calculator.firstNumber = int1;
    }
    @When("I add {int} to it")
    public void i_add_to_it(Integer int1) {
        calculator.secondNumber=int1;
        actualResult = calculator.add();
    }
    @Then("I get {int}")
    public void i_get(Integer int1) {
        assertEquals(7, actualResult);
    }
}
Figyeljünk oda, hogy a org.junit.jupiter.api.Assertions.assertEquals importálása is megjelenjen a forrás elején.  Erre amiatt van szükség, hogy az assertEquals() metódus le tudjon futni a @Then lépésben. (Ez a sor fogja a tényleges teszt futtatást megvalósítani.)
Most már nyugodtan futtathatjuk a tesztet aminek az eredménye a következőhöz hasonlatos kell, hogy legyen:
1 Scenarios (1 passed)
3 Steps (3 passed)
0m0,505s
Ezek szerint 1 Scenario lefutott ami 3 db lépésből áll. Ezek alapján a Calculator osztály megvalósítja az elvárt működést. Az üzleti logika implementálva lett és tesztelve a megtervezett elfogadási tesztek alapján. Ugyanakkor a Feature fájlunk egy alap dokumentációt is ad a projekthez.
Összegzés és ellenőrző kérdések
A BDD alapja a TDD, de nem csak tesztelésről szól. Segít betölteni a Három Amigo közti kommunikációs teret. És bár a BDD használatához szükségünk van szoftver eszközökre, de ettől még nem értékeljük jobban ezen eszközöket az egyéneknél és a személyes kommunikációnál.
A Gherkin nyelv képes leírni a User Story-k tartalmát, amit viszont a tervezők és a Cucumber is fel tud dolgozni.
Összességében a felhasznált technológiákkal agilisek maradtunk!
Ellenőrző kérdések:
Kérdés: Mi az a BDD?
Válasz: Egy eszköz a fejlesztők, teszterek és üzletemberek számára, hogy megvalósítsák azt a kollaborációt, amivel létrehozhatják a szükséges követelményeket egy félig technikai nyelven.
Kérdés: Hasonaltos a Gherkin a User Story-hoz?
Válasz: Igen hasonlít hozzá. De amíg a User Story mondatai olyanokkal indul, hogy „Mint egy .... , azért hogy ... „ a Gherkin a “Given, When, Then” szavakat használja.
Kérdés: Szükség van speciális szerkesztőre a .feature fájlok szerkesztésére?
Válasz: Nem, egy hétköznapi szövegszerkesztővel is módosíthatjuk. De a fájl kiterjesztésének .feature-nek kell lennie.
Kérdés: Tartalmazhat több Given lépést egy Gherkin Scenario?
Válasz: Igen, de a jobb megértés miatt célszerűbb And és But alternatíváit használni.
Kérdés: Amikor első alkalommal futtatjuk a Cucumber-t az adott Feature definíción akkor megáll hibával?
Válasz: Igen, mivel még nincs egyetlen teszt sem létrehozva.
Naplózás
A naplózás vagy log készítés (angolul: logging) az a folyamat, amikor a program futása közben naplóbejegyzéseket készítünk, hogy váratlan hiba esetén, azaz amikor a program futási hibával áll meg, képesek legyünk megmondani, hogy mi volt a hiba oka. Arra nem számíthatunk, hogy a felhasználó pontosan elmondja, hogy mit csinált, ami a hibát okozta. Ehelyett olyan részletes naplót kell vezetni, hogy abból kiderüljön a hiba oka.
Általában minden metódus elején és végén készítünk egy naplóbejegyzést, de akár minden értékadást is körbevehetünk naplózással. Szokás naplózási szinteket használni, amit egy konfigurációs állományban lehet beállítani. Egyes szinten csak a fő eseményeket naplózzuk, kettes szinten a program fő funkciói már követhető a naplóból, hármas szinten minden metódushívásnál készítünk naplóbejegyzést, négyes szinten szinte minden értékadásról készítünk naplóbejegyzést.
A naplózást úgy kell felfognunk, mintha ez lenne az egyetlen eszközünk a nyomkövetés helyett. Amit nyomkövetés során nézni szoktunk, azt kell naplózni is!
A naplóállományok általában nagyok, nehezen kezelhetők sima szövegszerkesztővel. Ezért speciális szövegnézegető szoftverrel érdemes megtekinteni őket, amiket tail (magyarul: farok) programoknak hívunk.
Ha tail-lel nézzük a naplót, lásd a tail parancs -f kapcsolóját, és keletkezik egy új sor, akkor az rögtön meg is jelenik. Az egyes szavakhoz színeket rendelhetünk, például az error szó általában piros, így könnyebben megtalálhatjuk, amit keresünk. Egy egyszerű tail program pl. a BareTail, de sok más hasonlóan színvonalas és ingyenes tail program is található.
Naplóbejegyzéseket Java esetén általában a Log4J csomag használatával készítünk. Ez egy appache.org-os projekt és széles körben elfogadott, ipari szabványnak tekinthető. Az appache.org-os projektekről általában is elmondható, hogy magas színvonalúak.
C# estén a beépített Trace osztályt használhatjuk, amely a System.Diagnostics névtérben van. Az alábbi egyszerű példaprogram létrehoz egy napló állományt C:\Temp\log.txt néven, illetve minden naplóbejegyzést kiír a konzolra is. Ezt úgy érjük el, hogy két TraceListener-t adunk hozzá a Trace-hez. Megjegyzés: Ebből látható, hogy a Trace és a TraceListener-ek között megfigyelő (angolul: observer) tervezési minta van.
using System;
using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        TraceListener t1 = new TextWriterTraceListener(@"C:\Temp\log.txt");
        TraceListener t2 = new ConsoleTraceListener();
        Trace.Listeners.Add(t1);
        Trace.Listeners.Add(t2);
        Trace.TraceInformation("Napló indul");
        // todo: hasznos rész
        Trace.TraceInformation("Napló vége");
        Trace.Flush();
        Console.ReadLine();
    }
}
Fontos megjegyezni, hogy a TraceInformation hatására a bejegyzés csak egy pufferbe kerül be, amit a rendszer csak akkor ürít, ha az betelt, vagy kiadjuk a Trace.Flush parancsot. Ezért érdemes beállítani az AutoFlush lehetőséget.
A naplózásról tudni kell, hogy lassítja a program futását, de naplózni ennek ellenére is kell, mert ha az ügyfélnél hiba történik, akkor minden pénzt megér egy jó naplófájl.
Érdemes még megjegyezni, hogy kritikus rendszereknél, pl. pénztári rendszer, arra is fel kell készíteni a naplót, hogy segítségével visszaállíthassuk az utolsó konzisztens állapotot. Ettől többet a Pillanatkép (angolul: Memento) tervezési minta leírásából tudhatunk meg.
Aspektusorientált programozás
Az aspektusorientált programozás alapgondolata az, hogy használjunk tiszta osztályokat, olyan osztályokat, amiket nem szennyez be a naplózás, a jogosultság kezelés, és más ilyen, mindenhol előjövő feladatok. Az egyszerűség kedvéért vegyük a naplózást (általában minden jegyzetben ez a példa).
Naplózni kell a hallgató osztályban és a kurzus osztályban is. Ez azt mutatja, hogy a naplózás egy aspektus. Aspektusok azok a feladatok, amiket minden, vagy legalábbis nagyon sok különböző feladatú osztálynak el kell végeznie. Ezeket átmetsző ügyeknek (angolul: crosscutting concerns) is nevezzük.
Az aspektusokat érdemes külön szervezni, mert így tisztább osztályokat kaphatunk. Ha tiszta osztályra gondolunk, akkor eszünkbe juthat a Java nyelv POJO fogalma. Ez a Plain Old Java Object rövidítése. A Java programozók ezt olyan értelemben használják, hogy olyan osztály, amiben nincs JEE (Java Enterprise Edition) specifikus kódrészlet, nincs benne naplózás és más egyéb „fertőzés”. A POJO megfelelője C#-ban a POCO, Plain Old C# Object.
Az aspektusorientált programozás fogalmai:
Aspektus (angolul: aspect): Ide kell kiszervezni az átmetsző követelményeket.
Szövés (angolul: weaving): Az a folyamat, ami során az aspektusokat beleszőjük a programba.
Kapcsolódási pontok (angolul: join point): Ezeken a pontokon lehet beleszőni a programba az aspektusokat. Általában metódusok előtt és után érdemes aspektusokat beleszőni a programba, de akár a metódus helyére is kerülhet az aspektus, azaz lecserélhető a metódus kódja.
Pontszűrő (angolul: pointcut): Itt rendeljük össze az aspektusokat és a kapcsolódási pontokat, azaz megmondjuk, hogy melyik aspektust melyik kapcsolódási pontnál kell beleszőni a programba.
A szövésnek több módja van, aszerint, hogy az aspektusok mikor kerülnek bele a program kódjába:
fordítás idejében történő szövés:
az aspektus a forráskódba kerül,
az aspektus a köztes (byte) kódba kerül.
futási időben történő szövés:
az aspektus a köztes (byte) kódba kerül.
Ha a forráskódba kerül az aspektus, akkor az megoldható egy egyszerű előfordítóval. A mai modern rendszerek a köztes kódba szövik az aspektusokat.
Az alábbiakban megmutatjuk, hogyan lehet C#-ban a PostSharp keretrendszer segítségével aspektusorientáltan programozni.
using System;
using PostSharp.Aspects;
using System.Diagnostics;
[Serializable]
public sealed class TraceAttribute : OnMethodBoundaryAspect
{
    private readonly string category;
    public TraceAttribute(string category)
    {
        this.category = category;
    }
    public string Category { get { return category; } }
    public override void OnEntry(MethodExecutionArgs args)
    {
        Trace.WriteLine(string.Format("Entering {0}.{1}.",
         args.Method.DeclaringType.Name, args.Method.Name), this.category);
    }
    public override void OnExit(MethodExecutionArgs args)
    {
        Trace.WriteLine(string.Format("Leaving {0}.{1}.",
         args.Method.DeclaringType.Name, args.Method.Name), this.category);
    }
}
public class HasznosOsztály
{
    [Trace("Hasznos")]
    public void HasznosMetódus1()
    {
        Console.WriteLine("Valami hasznos");
    }

    [Trace("Hasznos")]
    public void HasznosMetódus2()
    {
        Console.WriteLine("Valami nagyon hasznos");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Trace.Listeners.Add(
            new TextWriterTraceListener(Console.Out));
        HasznosOsztály hasznos = new HasznosOsztály();
        hasznos.HasznosMetódus1();
        hasznos.HasznosMetódus2();
    }
}
A fenti példakód csak akkor fog működni, ha installáltuk a PostSharp rendszert a Visual Studio-hoz és a projekthez hozzáadtuk a PostSharp-ot. Ezt a SolutionExplorer-ben a projektre jobb klikk után előjövő helyi menüben tehetjük meg.
Figyeljük meg, hogy a fenti példában a Hasznos Osztály egy POCO, amit attribútumokkal láttunk el. Az attribútumok az osztály, vagy a metódus neve elé írt szögletes zárójel közti kifejezések, amelyek befolyásolják a fordító működését.
Ebből a kis példakódból látható, hogy új aspektust írni úgy lehet, hogy az OnMethodBoundaryAspect osztályból származtattunk egy osztályt. Természetesen lehet más alaposztályból is származtatni, de erre most nem térünk ki. 
Az új osztálynak szerializálhatónak kell lennie, amit a [Serializable] attribútummal jelölünk. Az osztály, amit létrehozunk, végső soron egy attribútum lesz, így az osztály nevének XYZAttribute alakúnak kell lennie és az XYZ-t attribútumként használhatjuk. A mi esetünkben az XYZ helyén Trace áll. Az attribútumnak lehet paramétere is, ami abból látszik, hogy a konstruktornak van-e paramétere. A mi esetünkben egy paramétere van.
Az aspektuson belül hozzuk létre a kapcsolódási pontokat (angolul: join point) az „On” kezdetű metódusokkal. Ez esetben kettőt írtunk meg: az OnEntry és az OnExit metódusokat. Amit az OnEntry-be írunk, az a kiszűrt metódusok előtt fog lefutni, amit az OnExit-be írunk, az utána.
A Pontszűrő (ngolul: pointcut) ez esetben a Trace attribútum. Az a metódus, ami elé odaírjuk ezt a attribútumot, azelőtt le fog futni az OnEntry, utána pedig az OnExit. Ez esetben naplózás történik. Gondoljunk bele, mennyivel egyszerűbb így a naplózás kezelése!
A szövés automatikusan történik, amikor lefordítjuk a projektet. A PostSharp rendszer a köztes kódba fordítja bele az aspektusainkat, így az ilyen kód nyomkövetése nehéz.
Végezetül, vegyük észre, hogy itt is a Separation of Concerns elvet használtuk. A naplózás felelősségét és a naplózással bepiszkított metódusokat szétvágtuk naplózó aspektusra és POCO osztályokra, amiket később majd szövéssel rak össze a PostSharp.
Statikus tesztelési technikák
A statikus tesztelési technikák a szoftver forráskódját vizsgálják fordítási időben. Ide tartozik a dokumentáció felülvizsgálata is. A statikus tesztelés párja a dinamikus tesztelés, amely a szoftvert futásidőben teszteli. 
A statikus tesztelési technikáknak két fajtája van: 
felülvizsgálat és 
statikus elemzés. 
A felülvizsgálat a kód, illetve a dokumentáció, vagy ezek együttes manuális átnézését jelenti. Ide tartozik például a páros programozás. A statikus elemzés a kód, illetve a dokumentáció automatikus vizsgálatát jelenti, ahol a statikus elemzést végző segédeszköz megvizsgálja a kódot (illetve a dokumentációt), hogy bizonyos szabályoknak megfelel-e. Ide tartozik például a helyesírás ellenőrzése. 
A statikus technikával más típusú hibák találhatók meg könnyen, mint a dinamikus tesztelési technikákkal. Statikus technikákkal könnyen megtalálhatók azok a kódsorok, ahol null referencián keresztül akarunk metódust hívni. Ugyanezt elérni dinamikus teszteléssel nagyon költséges, hiszen 100%-os kódlefedettség kell hozzá. Ugyanakkor dinamikus teszteléssel könnyen észrevehető, hogy ha rossz képlet alapján számítjuk pl. az árengedményt. Ugyanezt statikusan nehéz észrevenni, hacsak nincs egy szemfüles vezető programozónk, aki átlátja az üzleti oldalt is. 
A statikus tesztelési technikák előnye, hogy nagyon korán alkalmazhatók, már akkor is, amikor még nincs is futtatható verzió. Így hamarabb lehet velük hibákat találni és így gazdaságosabb a hibajavítás.
Felülvizsgálat – Bevezetés
A felülvizsgálat azt jelenti, hogy manuálisan átnézzük a forráskódot és fejben futtatjuk vagy egyszerűen csak gyanús részeket keresünk benne. Ezzel szemben áll a statikus elemzés, ahol szoftverekkel nézetjük át automatikusan a forráskódot. A felülvizsgálat fehérdobozos teszt, mivel kell hozzá a forráskód. A felülvizsgálat lehet informális, pl. páros programozás, de akár nagyon formális is, amikor a folyamatot jól dokumentáljuk, illetve a két szélsőség közti átmenetek. 
Ezeket a hibákat könnyebb felülvizsgálattal megtalálni, mint más technikákkal: 
szabványoktól / kódolási szabályoktól való eltérések, 
követelményekkel kapcsolatos hibák, pl. nincs minden funkcionális követelményhez funkció, 
tervezési hibák, pl. az adatbázis nincs harmadik normál-formában, 
karbantarthatóság hiánya, pl. nincs biztonsági mentés és visszaállítás funkció, 
hibás interfész-specifikációk, pl. dokumentálatlan előfeltételek. 
A felülvizsgálat legismertebb típusai: 
informális felülvizsgálat (csoporton belüli), 
átvizsgálás (házon belüli), 
technikai felülvizsgálat (külsős szakérő bevonásával, rövid idejű), 
inspekció (külsős szakérő bevonásával, hosszú idejű).
Felülvizsgálat – Informális felülvizsgálat
Sok szoftvercégnél elfogadott megoldás, hogy egy tapasztalt programozó átnézi (angolul: review) a kezdők kódját. A kezdők a kritikából rengeteg tapasztalatot szerezhetnek. A kockázatosnak ítélt részeket (pl. amire gyakran kerül a vezérlés, vagy kevésbé ismert megoldást alkalmaz) több tapasztalt programozó is átnézheti. Ennek hatékonysága függ az átnézők rátermettségétől. Ez a leginkább informális felülvizsgálat, ezért is nevezik informális felülvizsgálatnak.
Ehhez hasonló a páros programozás (angolul: pair programming) is. Ekkor két programozó ír egy kódot, pontosabban az egyik írja, a másik figyeli. Ha a figyelő hibát lát vagy nem érti a kódot, akkor azonnal szól. A két programozó folyamatosan megbeszéli, hogy hogyan érdemes megoldani az adott problémát. 
A kódszépítés (angolul: refactoring) egy másik módja a felülvizsgálatnak. Ilyenkor a már letesztelt, működő kódot lehet szépíteni, ami esetleg lassú, rugalmatlan, vagy egyszerűen csak csúnya. A kódszépítés előfeltétele, hogy legyen sok egységteszt. A szépítés során nem szabad megváltoztatni a kód funkcionalitását, de a szerkezet, pl. egy metódus törzse, szabadon változtatható. A szépítés után minden egységtesztet le kell futtatni, nem csak a megváltozott kódhoz tartozókat, hogy lássuk, a változások okoztak-e hibát. A kódszépítést a szerző és egy tapasztalt programozó végzi közösen. 
Az informális felülvizsgálat legfőbb jellemzői: 
informális, a fejlesztőcsapaton belüli felülvizsgálat, 
kezdeményezheti a szerző vagy egy tapasztaltabb fejlesztő, ritkán a menedzsment, 
hatékonysága függ az átnéző személyétől, minél tapasztaltabb, annál több hibát vehet észre, 
célja a korai, költséghatékony hiba felderítés.
Felülvizsgálat – Átvizsgálás
Az átvizsgálás már egy kicsit formálisabb módja a felülvizsgálatnak. Általában az alkalmazott módszertan előírja, hogy az elkészült kisebb-nagyobb modulokat ismertetni kell a csapat többi tagjával, a többi csapattal. Célja, hogy mások is átlássák az általunk írt kódrészletet (ez csökkenti a kárt, amit egy programozó elvesztése okozhat, lásd kockázatmenedzsment), kritikai megjegyzéseikkel segítsék a kód minőségének javítását. Aszerint, hogy hány embernek mutatjuk be az elkészült modult, ezekről beszélhetünk: 
váll feletti átnézés (angolul: over-the-shoulder review), 
forráskód átnézése (angolul: code review), 
kódátvétel (angolul: code acceptance review),
körbeküldés (angolul: pass-around), 
csoportos átnézés (angolul: team review),
felületátnézés (angolul: interface review),
kódprezentálás (angolul: code presentation). 
Váll feletti átnézés (angoul: over-the-shoulder review): Az egyik programozó egy ideje nézi saját forráskódját, de nem találja a hibát. Valamelyik kollégáját megkéri, hogy segítsen. Mialatt elmagyarázza a problémát, általában rá is jön a megoldásra. Ha mégsem, akkor a kollégának lehet egy jó ötlete, hogy mi okozhatja a hibát. Általában ennyi elég is a hiba megtalálásához. Ha nem, jöhet a forráskód átnézése. 
Forráskód átnézése (angolul: code review): A kód írója megkér egy tapasztalt programozót, hogy segítsen megtalálni egy nehezen megtalálható hibát. Együtt nyomkövetik a programot, miközben a szerző magyarázza, mit miért csinált. Ellenőrzik, hogy a kód megfelel-e a specifikációnak. Ezt addig folytatják, amíg meg nem találják a hibát. 
Kódátvétel (angolul: code acceptance review): Az elkészült nagyobb modulokat, pl. osztályokat, a vezető fejlesztő vagy egy tapasztalt programozó átnézi, hogy van-e benne hiba, nem érthető, nem dokumentált rész. A modul fejlesztői elmagyarázzák, mit és miért csináltak. A vezető fejlesztő elmondja, hogyan lehet ezt jobban, szebben csinálni. Ha hibát talál (ez gyakran logikai hiba), akkor arra rámutat, vázolja a javítást.
Körbeküldés (angolul: pass-around): A kód szerzője körbeküldi az általa írt kódrészletet, ami akár egy egész modul is lehet. A címzettek véleményezik a kódot, például megírják, melyik részét érdemes tesztelni. A körbeküldés általában megelőzi a kód felvételét a verziókövető rendszerbe. Általában csak akkor használják, ha egy kódrészlet kritikus fontosságú, pl. egy sokak által használt interfész. Az intenzív kommunikációt előíró módszertanokra (pl. Scrum) nem jellemző. 
Csoportos átnézés (angolul: team review): A csoportos átnézés a körbeküldést helyettesíti. Itt is egy érzékeny kódrészletet néznek át többen, de interaktívan. A kódot a szerző prezentálja, sorról sorra magyarázza. Általában elvárás, hogy ha valaki valamit nem ért, azonnal szóljon. A prezentáció végén a vezető programozó elmondja, szerinte mit lehetett volna jobban csinálni. Ehhez is gyakran hozzászólnak a többiek. Több módszertan (pl. extrém programozás) limitálja ezen alkalmak időhosszát fél vagy egy órában. 
Felületátnézés (angolul: interface review): Hasonló a csoportos átnézéshez, de itt általában több embernek mutatjuk be azt az interfészt, amelyen keresztül a csoportunk fejlesztése lesz elérhető. Ez azért fontos, hogy az egyes csoportok egyeztetni tudják elvárásaikat egymás felé. Ezeket rögzítik és az integrációs teszt során felhasználják. 
Kódprezentálás (angolul: code presentation): Hasonló a csoportos átnézéshez, de az érdekes kódot nem a csoporton belül, hanem a cégen belül mutatjuk be. Akkor gyakori, ha több telephelyen fejlesztik ugyanazt a szoftvert. Nem feltétlenül az egész cég vesz részt benne, lehet, hogy csak három ember, de könnyen előfordulhat, hogy ezek más-más kontinensen vannak. A kódprezentálás célja lehet egy hiba bemutatása, amit egy másik csapat talált és megkéri a kód tulajdonosát, hogy javítsa. Másik gyakori cél a csúcsfejlesztők összehozása, hogy a keretrendszer továbbfejlesztését megbeszéljék. 
Az átvizsgálás legfőbb jellemzői: 
a moderátor maga a szerző, lehet jegyzőkönyvvezető is, de az nem a szerző, 
a résztvevők a cég alkalmazottai, külső szakértők nem jellemzőek, 
lehet informális és formális is, ha formális, akkor van pl. jegyzőkönyv, 
általában az alkalmazott módszertan írja elő vagy a menedzsment kezdeményezi, 
a szerzők jól felkészülnek, pl. szemléltető ábrákat készítenek, a többi résztvevő átnézi a kapcsolódó dokumentációt, 
célja az elkészült modulok ismertetése, megértések, azokban hibakeresés.
Felülvizsgálat – Technikai felülvizsgálat
Technikai felülvizsgálatra általában akkor kerül sor, ha a szoftver teljesítményével nem vagyunk elégedettek. Azt általában könnyű megtalálni a felhasználói visszajelzések és úgynevezett profiler programok segítségével, hogy mi az a szűk keresztmetszet (angolul: bottleneck), ami a lassúságot okozza. Ugyanakkor az nagyon nehéz kérdés, hogy hogyan oldjuk fel ezeket a szűk keresztmetszeteket. Ha lenne egyszerű megoldás, akkor a programozók eleve azt használták volna, tehát ez általában a szoftver cég alkalmazottainak tudását meghaladó probléma. 
Ilyenkor külső szakértőket szoktak felkérni, hogy segítsenek. Leggyakrabban egy-egy lekérdezés bizonyul túl lassúnak. Ilyenkor egy index hozzáadása a táblához nagyságrendekkel gyorsítja a lekérdezést. A kérdés már csak az, mit indexeljünk és hogyan. A külsős szakértők átnézik a megoldásunkat és javaslatokat adnak. 
Mivel ez a fajta tanácsadás nagyon drága, ezért ez egy jól dokumentált folyamat. A szoftvercég leírja, hogy mi a probléma. Mind a cég alkalmazottai, mind a szakértők felkészülnek, átnézik a dokumentációkat. A megbeszélést általában egy moderátor vezeti, aki jegyzőkönyvet is ír. A moderátor nem lehet a program írója. A résztvevők megbeszélik, hogy mi a probléma gyökere. A szakértők több megoldási javaslatot is adnak. Kiválasztanak egy megoldást. Ezt vagy a szerző, vagy a szakértők implementálják. 
A technikai vizsgálat másik típusa, amikor külső szakértők azt ellenőrzik, hogy a szoftver vagy a dokumentációja megfelel-e az előírt szabványoknak. Az ellenőrzést nem a megrendelő, hanem a szoftvercég vagy a szabvány hitelesítését végző szervezet kezdeményezi. Pl. az emberi életre is veszélyes (angolul: life-critical) rendszerek dokumentációjára az IEC61508 szabvány vonatkozik. Ennek betartása a cég érdeke, mert ha kiderül, hogy nem tartja be a szabványt, akkor a termékeit akár ki is vonhatják a piacról.
Akkor is ehhez a technikához fordulnak, ha a szoftverben van egy hiba, amit nagyon nehéz reprodukálni, és a szoftvercég saját alkalmazottai nem tudják megtalálni (megtalálhatatlan hiba). Ez többszálú vagy elosztott rendszereknél fordul általában elő egy holtpont (angolul: deadlock) vagy kiéheztetés (angolul: starvation) formájában, de lehet ez egy memóriaszivárgás (angolul: memory lake) is. Ilyenkor a szakértő megmutatja, hogyan kell azt a statikus elemző szoftvert használni, pl. egy holtpont keresőt (angolul: deadlock checker), ami megtalálja a hibás részt. Az így feltárt hibát általában már a cég szakemberei is javítani tudják. 
A technikai felülvizsgálat legfőbb jellemzői: 
a szoftvercég kezdeményezi, ha külső szakértők bevonására van szüksége, 
moderátor vezeti (nem a szerző), aki jegyzőkönyvet is vezet, 
inkább formális, mint informális, 
a találkozó előtt a résztvevők felkészülnek, 
opcionálisan ellenőrző lista használata, amit a felek előre elfogadnak, 
célja a megtalálhatatlan hibák felderítése, vagy a szoftver lassúságát okozó szűk keresztmetszetek megszüntetés, vagy szabványok ellenőrzése.
Felülvizsgálat – Inspekció
Ez a legformálisabb felülvizsgálat. Ezt is akkor használjuk, ha külső szakértő bevonására van szükségünk. A technikai felülvizsgálattól az különbözteti meg, hogy a szoftvercég és a szakértőt adó cég részletesebb szerződést köt, amely magában foglalja: 
a megoldandó feladat leírását, 
azt a célfeltételt, ami a probléma megoldásával el kell érni, 
a célfeltételben használt metrikák leírását, 
az inspekciós jelentés formáját. 
Míg a technikai átnézésnél gyakran csak annyit kérünk a szakértőktől, hogy legyen sokkal gyorsabb egy lekérdezés, az inspekció esetén leírjuk pontosan, hogy milyen gyors legyen. 
Az inspekció szó abból jön, hogy a probléma megoldásához általában nem elég csak a szoftver egy részét átvizsgálni, hanem az egész forráskódot adatbázissal együtt inspekció alá kell vonni. Inspekciót alkalmazunk akkor is, ha egy régi (esetleg már nem támogatott programozási nyelven íródott) kódot akarunk szépíteni / átírni, hogy ismét rugalmasan lehessen bővíteni. 
Az inspektornak nagy tekintélyű szakembernek kell lennie, mert az általa javasolt változtatások általában nagyon fájóak, nehezen kivitelezhetőek. Ha nincs meg a bizalom, hogy ezekkel a változtatásokkal el lehet érni a célt, akkor a fejlesztőcsapat ellenállásán elbukhat a kezdeményezés. 
Az inspektort általában egy-két hónapig is a fejlesztők rendelkezésére áll szemben a technikai felülvizsgálattal, amikor a szakértők gyorsan, akár néhány óra alatt megoldják a problémát. Ezért ugyanannak a szakértőnek a napidíja általában kisebb inspekció esetén, mint technikai felülvizsgálat esetén. 
Az inspekció lehet rövid távú is (egy-két hetes), ha a szakértőre nincs szükség a probléma megoldásához, csak a feltárásához. Ekkor a szakértő egy inspekciós jelentést ír, amely leírja, hogyan kell megoldani a problémát. Ehhez általában csatolni kell egy példaprogramot is, egy úgynevezett PoC-ot (angolul: Proof of Concept), amely alapján a cég saját fejlesztői is képesek megoldani a problémát. A „pocok”-nak demonstrálnia kell, hogy a kívánt metrika értékek elérhetőek a segítségével. 
Az inspekció legfőbb jellemzői: 
a szoftvercég kezdeményezi, ha hosszabb távon van szüksége külső szakértőre,
részletes szerződés szabályozza, ami a problémát, a célfeltételt és célban szereplő metrikákat is leírja, 
opcionálisan „pocok” (angolul: Proof of Concept) készítése, 
inspekciós jelentés készítése, 
célja: teljesítményfokozás a szakértő által kiválóan ismert technológia segítségével vagy elavult kód frissítése.
Statikus elemzés - Bevezetés
A statikus elemzés fehérdobozos teszt, hiszen szükséges hozzá a forráskód. Néhány esetben, pl. holtpontellenőrzés, elegendő a lefordított köztes kód (byte kód). A statikus elemzés azért hasznos, mert olyan hibákat fedez fel, amiket más tesztelési eljárással nehéz megtalálni. Például kiszűrhető segítségével minden null referencia - hivatkozás, ami futási hibához vezethet, ha benne marad a programban. Az összes null referencia - hivatkozás kiszűrése dinamikus technikákkal (pl. komponensteszttel vagy rendszerteszttel) nagyon sok időbe telne, mert 100%-os kódlefedettséget kellene elérnünk. 
A statikus elemzés azt használja ki, hogy az ilyen tipikus hibák leírhatók egyszerű szabályokkal, amiket egy egyszerű kódelemző (parser) gyorsan tud elemezni. Például null referencia - hivatkozás akkor lehetséges, ha egy „a = null;” értékadó utasítás és egy „a.akármi;” hivatkozás közt van olyan végrehajtási út, ahol az „a” referencia nem kap null-tól különböző értéket. Ugyan ezt lehet dinamikus technikákkal is vizsgálni, de ahhoz annyi tesztesetet kell fejleszteni, ami minden lehetséges végrehajtási utat tesztel az „a = null;” és az „a.akármi;” közt. 
A forráskód statikus elemzésnek két változata ismert, ezek: 
statikus elemzés csak a forráskód alapján, 
statikus elemzés a forráskód és modell alapján. 
Ezen túl lehetséges a dokumentumok statikus elemzése is, de ezekre nem térünk ki. 
A következő hibatípusokat könnyebb statikus elemzéssel megtalálni, mint más technikákkal: 
null referenciára - hivatkozás, 
tömbök túl- vagy alulindexelése, 
nullával való osztás, 
lezáratlan adatfolyam (angolul: unclosed stream), 
holtpont (angolul: deadlock), 
kiéheztetés (angolul: starvation). 
Az egyes eszközök lehetnek specifikusak, mint pl. a holtpontkeresők, illetve általánosak, mint pl. a FindBugs. 
Statikus elemzés csak a forráskód alapján
Azok az elemzők, amelyek csak a forráskódot használják fel az elemzéshez, nagyon hasznosak olyan szempontból, hogy nem igényelnek plusz erőfeszítést a programozóktól a specifikáció megírásához. Ilyen eszköz például a FindBugs. Ezeket az eszközöket csak bele kell illeszteni a fordítás folyamatába. Ezután a statikus elemző felhívja a figyelmünket a tipikus programozói hibákra. Ezek általában programozásinyelv-specifikusak, de léteznek nyelvfüggetlenek, pl. a Sonar vagy a Yasca rendszer, amelyek egy-egy plugin segítségével adaptálhatóak a kedvenc nyelvünkhöz. 
Jelen jegyzetben a FindBugs használatát fogjuk bemutatni Eclipse környezetben. Először telepíteni kell a FindBugs plugint. Ehhez indítsuk el az Eclipse rendszert, majd válasszuk a Help -> Install New Software… menüt. A megjelenő ablakban adjuk hozzá a plugin források listájához az alábbi linket az Add gombbal: https://findbugs.cs.umd.edu/eclipse/. Ezután néhány Next gomb és a felhasználási feltételek elfogadása után a rendszer elkezdi installálni a FindBugs plugint. Ez néhány percet vesz igénybe, ami után újraindul az Eclipse. Ezután már használhatjuk a FindBugs-t. 
A használatához válasszunk ki egy projektet, majd a helyi menüben válasszuk a Find Bugs -> Find Bugs menüt. Ez egyrészt megkeresi azokat a sorokat, amelyek valamilyen szabálynak nem felelnek meg, másrészt átvisz minket a FindBugs perspektívába. Ha talál olyan sorokat, amelyek potenciálisan hibát okozhatnak, akkor ezeket bal oldalon egy kicsi piros bogárikonnal jelzi. Ha ezekre ráállunk vagy rákattintunk, akkor láthatjuk, milyen típusú hibát okozhat. Ezekről részletes információt is kérhetünk, ha a FindBugs perspektíva Bug Explorer ablakában kiválasztjuk valamelyiket. 
Az egyes hibák ellenőrzését ki/be lehet kapcsolni a projekt Properties ablakának FindBugs panelén. Itt érdemes a Run atomatically opciót bekapcsolni. Így minden egyes mentésnél lefut a FindBugs. Ebben az ablakban az is látható, melyik hiba ellenőrzése gyors, illetve melyik lassú. Például a null referenciára-hivatkozás ellenőrzése lassú. 
Nézzünk néhány gyakori hibát, amit megtalál a FindBugs az alapbeállításaival: 
public int fact(int n) { return n * fact(n - 1); }
Itt a „There is an apparent infinite recursive loop” figyelmeztetést kapjuk nagyon helyesen, hiszen itt egy rekurzív függvényt írtunk bázisfeltétel nélkül, és így semmi se állítja meg a rekurziót. 
Integer i = 1, j = 0; if(i == j) System.out.println("ugyanaz");
Ebben a példában a „Suspicious comparison of Integer references” figyelmeztetést kapjuk. Ez azért van, mert referenciák egyenlőségét ugyan tényleg a dupla egyenlőségjellel kell vizsgálni, de a mögöttük lévő tartalom egyenlőségét az equals metódussal kell megvizsgálni. Tehát ez egy lehetséges hiba, amit érdemes a fejlesztőknek alaposan megnézni. 
int i = 0; i = i++; System.out.println(i);
Itt több hibát is kapunk: „Overwritten increment” és „Self assignment of local variable”. Az első hiba arra utal, hogy hiába akartuk növelni az i változó értékét, az elvész. A második hiba azt fejezi ki, hogy egy változót önmagával akarunk felülírni. 
Nézzünk olyan esetet is, aminél hibásan ad figyelmeztetést a FindBugs: 
Object o; int i = 1; if (i == 1) { o = "hello"; } System.out.println(o.toString());
A fenti esetre a „Possible null pointer dereference of o” hibát kapjuk, habár egyértelműen látszik, hogy az o értéket fog kapni, hiszen igaz az if utasítás feltétele. Ugyanakkor a FindBugs rendszer nem képes kiszámolni a változók lehetséges értékeit az egyes ágakon, hiszen nem tartalmaz egy automatikus tételbizonyítót. Ezzel szemben a következő alfejezetben tárgyalt ESC/Java2 eszköz képes erre, hiszen egy automatikus tételbizonyítóra épül.
