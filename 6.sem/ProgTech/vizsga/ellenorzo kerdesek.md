Kérdés: Minek a rövidítése a GOF?
Válasz: Gang of Four, magyarul: négyek bandája.

Kérdés: Melyik könyvre utalunk a GOF könyv szókapcsolattal?
Válasz: A könyv magyar címe: „Programtervezési minták, Újrahasznosítható elemek objektumközpontú programokhoz.” A könyv angol címe: „Design Patterns: Elements of Reusable Object-Oriented Software”. A könyvnek 4 szerzője van, akiket együtt a négyek bandájának, angolul: Gang of Four, szoktunk hívni. Ennek a rövidítése a GOF.

Kérdés: Az öröklődés az IS-A kapcsolat, vagy a HAS-A kapcsolat:
Válasz: Az öröklődés az IS-A kapcsolat.

Kérdés: Az objektum-összetétel a IS-A kapcsolat, vagy a HAS-A kapcsolat?
Válasz: Az objektum-összetétel a HAS-A kapcsolat.

Kérdés: A kompozíció az IS-A, vagy HAS-A kapcsolat egy fajtája.
Válasz: A HAS-A kapcsolat egy fajtája.

Kérdés: Az aggregáció az IS-A, vagy HAS-A kapcsolat egy fajtája.
Válasz: A HAS-A kapcsolat egy fajtája.

Kérdés: A becsomagolás az IS-A, vagy HAS-A kapcsolat egy fajtája.
Válasz: A HAS-A kapcsolat egy fajtája.

Kérdés: Mik azok a SOLID alapelvek?
Válasz: A szakirodalomban leginkább elfogadott 5 legfontosabb objektum orientált tervezési alapelv: SRP, OCP, LSP, ISP, DIP.

Kérdés: Minek a rövidítése az SRP és mint mond ki?
Válasz: Ennek a rövidítése: Single Responsibility Principle, magyarul: Egy felelőssége elv. Kimondja, hogy minden osztálynak, illetve modulnak csak egy felelősségi köre legyen, de azt fedje le teljesen.

Kérdés: Minek a rövidítése az OCP és mit mond ki?
Válasz: Ennek a rövidítése: Open-Closed Principle, magyarul: Nyitva-zárt alapev. Kimondja, hogy az osztályok, illetve az osztály hierarchiák legyenek nyitottak a bővítésre de zártak a módosításra.

Kérdés: Robert C. Martin Tiszta kód című könyve szerint melyik a legfontosabb SOLID alapelv?
Válasz: Az SRP.

Kérdés: Mi a jelentősége az OCP alapelvnek?
Válasz: Az OCP elvet kimondhatjuk a szintaxis szintjén is, míg ez SRP esetén nem ilyen egyértelmű.

Kérdés: Melyik SOLID alapelv megértéséhez van szükség a szerződés alapú programozásra?
Válasz: Az LSP megértéséhez kell bevezetni a szerződés alapú programozást.

Kérdés: Mi a létrehozási tervezési minták feladata?
Válasz: A példányosítás folyamatának egységbe zárása, így, ha változik a folyamata, akkor azt csak egy helyen kell megváltoztatni.

Kérdés: Ma a Singleton (magyarul: egyke) tervezési minta célja?
Válasz: Létrehozni egy olyan osztályt, aminek csak egy példánya lehet.

Kérdés: Minden különbözik a mohó és a lusta Singleton (magyarul: egyke) tervezési minta?
Válasz: A mohó Singleton akkor is létrehozza a példányt, ha azt soha senki nem kéri le. A lusta Singleton csak akkor hozza létre, ha valaki lekéri a példányt, de az még nincs kész.

Kérdés: Milyen típusai vannak a klónozásnak, ezek miben különböznek?
Válasz: Két szélsőséges típusa van: a sekély klónozás és a mély klónozás. Sekély klónozás esetén minden mezőt egyszerű értékadással másolok. Mély klónozás esetén a referenciákat klónozom. A két szélsőség közt bármilyen átmenet elképzelhető.

Kérdés: Minden Office alkalmazásnak van Fájl->Új parancsa, amik nagyon hasonlóan működnek, mégis mindegyiknek teljesen más az eredménye. Melyik tervezési minta van ennek a hátterében?
Válasz: A gyártómetódus, hiszen a gyártómetódusban a gyártási folyamat lépései fixek, de az egyes gyermekosztályok fejtik ki ezeket a lépéseket.

Kérdés: Ha több összefüggő terméket kell gyártani, akkor melyik tervezési mintát érdemes használni?
Válasz: Az absztrakt gyárat, hiszen ez pont arra való, hogy több, összefüggő terméket gyártsunk a segítségével.

Kérdés: Melyik tervezési mintát kell használni, ha egy értékes objektumhoz szabályozott hozzáférést szeretnék biztosítani?
Válasz: Helyettes (angolul: Proxy).

Kérdés: A három tervezési minta közül melyik használ átlátszó becsomagolást: Illesztő, Díszítő, Helyettes?
Válasz: A Díszítő (angolul: Decorator) és a Helyettes (angolul: Proxy).

Kérdés: Mikor lesz egy becsomagolás átlátszó?
Válasz: Az átlátszó becsomagoláshoz kell HAS-A kapcsolat, azaz becsomagolás, és IS-A kapcsolat is, azaz a becsomagolónak és a becsomagoltnak kell, hogy legyen közös felülete.

Kérdés: Miért marad a karácsonyfa díszítés után is karácsonyfa?
Válasz: Mert a Díszító (angolul: Decorator) tervezési minta átlátszó becsomagolást használ.

Kérdés: Az Illesztő tervezési minta által használ becsomagolás miért átlátszatlan?
Válasz: Mert a becsomagolás teljesen elrejti a becsomagolt objektum felületét, habár minden viselkedést a becsomagolt viselkedésére kell visszavezetni.

Kérdés: Milyen tervezési mintát kell használni gyorsító tár (angolul: cache) megvalósításához?
Válasz: Helyettes (angolul: Proxy) tervezési mintával lehet ezt a feladatot jól megoldani.

Kérdés: Mit jelent a helyettes állatkert (angolul: Proxy Zoo) kifejezés?
Válasz: Azt jelenti, hogy helyettesből nagyon sok fajta van: gyorsító tár, okos referencia, távoli metódus hívás, stb.

Kérdés: Mi a viselkedési tervezési minták közös jellemzője?
Válasz: A viselkedési tervezési minták segítenek olyan programok létrehozásában, amelyek könnyen bővíthetők új viselkedéssel.

Kérdés: Melyik tervezési mintát kell használni, ha egy eseményre több lehetséges válaszreakciót is szeret adni?
Válasz: A Megfigyelő (angolul: Observer) tervezési minta pont erre jó: egy megfigyelt, ahol az esemény bekövetkezik, több megfigyelő, amely ezeket az eseményeket feldolgozza.

Kérdés: Hogyan jelenik meg az IoC a Sablonmetódus tervezési mintában?
Válasz: Nem az gyermek hívja az ősét, hanem az ős a gyermekét, azaz az ősben van olyan metódus, ami konkrét és ez absztrakt metódust hív, ami a gyermekben lesz kifejtve.

Kérdés: Mit jelent a horog (angolul: hook) metódus?
Válasz: Olyan virtuális metódus, amelynek van törzse, de a törzse üres, vagy csak egy return utasítás van benne. A Sablonmetódus (angolul: Template Method) tervezési mintában az opcionális lépések horog (angolul: hook) metódusok.

Kérdés: Melyik tervezési mintát érdemes használni egy olyan eszköz programjának elkészítésére, amelyen van egy gomb, de a gomb más-más funkcióval bír az eszköz más-más állapotában?
Válasz: Az Állapot tervezési minta pont ennek a feladatnak a megoldására szolgál.

Kérdés: Melyik tervezési mintát használjuk, ha van egy változékony metódusunk, pl.: GetÁr(), aminek a kódja gyakran változik.
Válasz: Ilyen esetben a Stratégia a jó választás. A változékony metódust kiemeljük egy új osztály hierarchiába, és mindig csak egy új osztályt adunk hozzá, amikor egy új változatot kell írni.

Kérdés: Melyik tervezési mintára mondják, hogy józan paraszti ésszel nehezen kitalálható?
Válasz: Majd minden forrás a Látogató (angolul: Visitor) tervezési mintát jelöli meg, mint a legnehezebben megérthetőt. Ennek oka, hogy dupla hivatkozásfeloldást technikát alkalmaz.

Kérdés: Mit mond ki a szétválasztás elve?
Válasz: Az elv kimondja, hogy amit szét lehet választani, azt érdemes is szétválasztani.

Kérdés: Milyen előnyei vannak az Állapot viselkedési tervezési mintának?
Válasz: Az előnyök közé tartozik, hogy egységbe zárja az állapotfüggő viselkedést, könnyen új állapotokat vezethetünk be, áttekinthetőbb kódot eredményez, és az állapot objektumokat megoszthatjuk.

Kérdés: Mi a hátránya az Állapot viselkedési tervezési mintának?
Válasz: A hátránya, hogy nő az osztályok száma, ezért csak indokolt esetekben érdemes használni.

Kérdés: Hogyan foglalható egy mondatba a Stratégia és a Sablonmetódus különbsége?
Válasz: Stratégia esetén ugyanazt csináljuk, de másképp; Sablonmetódus esetén ugyanúgy csináljuk, de mást.

Kérdés: Milyen előnyei vannak a Stratégia tervezési mintának az OCP elv szempontjából?
Válasz: A Stratégia tervezési minta segít az OCP elv betartásában, mivel lehetővé teszi új viselkedések hozzáadását a rendszerhez anélkül, hogy a meglévő osztályokat módosítani kellene. Ezáltal a rendszer zárt marad a módosítások előtt, de nyitott új funkciók hozzáadására.

Kérdés: Milyen helyzetekben használjuk a látogató tervezési mintát?
Válasz: A látogató tervezési mintát akkor használjuk, ha már van egy kiforrott adatszerkezetünk, de lehetőséget akarunk adni arra, hogy könnyen lehessen bővíteni az adatszerkezetet feldolgozó algoritmusok sorát.

Kérdés: Mi a homokozó (angolul: sandbox) szerepe az ágensalapú programozásban?
Válasz: A homokozó egy virtuális szerver, amely korlátozza az ágens által elérhető erőforrásokat és funkcionalitást, így minimalizálva a biztonsági kockázatokat.

Kérdés: Mi a dupla hivatkozásfeloldás (amgolul: double dispatch)?
Válasz: A referencia.valamiHasznos(x) metódushívás feloldásához fel kell oldani, hogy a referencia hova mutat, ez a késői kötés. Továbbá, ha a valamiHasznos egy túlterhelt metódus, akkor az x kifejezés típusa alapján el kell dönteni, hogy melyik változatát kell hívni.

Kérdés: Java esetén melyik a legelterjedtebb unit-tesztelési környezet?
Válasz: Jelen pillanatban a JUnit5 csomag a legelterjedtebb.

Kérdés: Melyen 5 pontból áll általában egy unit-teszt?
Válasz: Target, fix input paraméterek, elvárt érték, aktuális érték, a kettő összehasonlítása.

Kérdés: Maven használata esetén hova kell írnia JUnit5 függőségeit?
Válasz: A POM.XML fájlba kell írni a <dependencies> részbe.

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