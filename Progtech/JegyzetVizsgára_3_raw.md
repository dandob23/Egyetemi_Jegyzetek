3. fejezet:

Principles: Az objektumorientált tervezés alapelvei
Absztrakt alapelvek
Mielőtt rátérünk az objektumorientált tervezés alapelveire, érdemes megvizsgálni azokat az absztrakt alapelveket, amiből minden más általunk tárgyalt alapelv levezethető. Absztrakt alapelvek:
A program kódja állandóan változik.
Amit szét lehet választani, azt érdemes szétválasztani.
A szoftver is csak egy termék, olyan, mint egy doboz müzli.
A szoftverfejlesztésnek nincs Szent Grálja.
A program kódja állandóan változik
Az első elv a programozási technológiák alapelve. Kimondja, hogy a programunk forráskódja előbb vagy utóbb megváltozik. Ennek több oka lehet. Néhány lehetséges ok:
Új igény merül fel.
Valamely igény változik.
A program környezete változik.
A program valamely részét optimalizálni kell.
A programban hibát találunk.
A programot szépítjük (idegen szóval refaktoráljuk).
Ez a fő-fő elvünk, amiből közvetve, vagy közvetlenül minden más elv következik.
Ügyek szétválasztása – Separation of Concerns
Az előző elv írja le, hogy mi a legnagyobb probléma a szoftverfejlesztés során, amivel minden programozónak és tervezőnek szembe kell nézni: A program kódja állandóan változik! Szerencsére nem csak a problémát, hanem a probléma ellenszerét is ismerjük, ami szintén egy elv:
Amit szét lehet választani, azt érdemes szétválasztani.
Ezt az elvet a szakirodalom az ügyek szétválasztása (angolul: Separation of Concerns) néven ismeri. Nagyon magas szintű, sok más elvben, tervezési mintában visszaköszön. Alapötlete az, hogy ha szétválasztjuk a szétválasztható dolgokat, akkor az így kapott kisebb részeket könnyebb kezelni.
Az ügyek szétválasztása a mi nagy, lángoló fegyverünk, ami néha kard, néha alabárd, néha láncfűrész, de a lényege, hogy szétválaszt, szétvág. Ehhez az elvhez érdemes visszatérni akkor, amikor már sikerült elmélyedni a tervezési elvekben, illetve a tervezési mintákban, és végiggondolni, hogy hol is bújik meg: mit választottunk el mitől és ez hogyan teszi rugalmasabbá a forráskódunkat, a terveket.

2. ábra: Az ügyek szétválasztása elvet egy lángoló kardként képzelhetjük el
A szoftver is csak egy termék, olyan, mint egy doboz müzli
A következő elv a rendszerfejlesztés technológiájának alapelve. Kimondja, hogy a szoftver is csak egy termék, és mint ilyen, hasonló jellemzőkkel bír, mint egy doboz müzli. Ezen tulajdonságok közül néhány fontosabb:
A szoftvernek van ára, gyártója, forgalmazója, vevője.
A szoftvernek van minősége, doboza, designja, dokumentációja.
A szoftverre vonatkoznak törvényi előírások, szabványok és ajánlások.
A szoftverfejlesztésnek nincs Szent Grálja
A következő elv a rendszerszervezés alapelve. Eredeti angol megfogalmazása: „There is no Silver Bullet”. Kimondja, hogy a szoftverfejlesztés területén nincs olyan kitüntetett módszertan, technológia vagy szemléletmód, amely egymaga megoldaná a minőségi és egyben olcsó szoftverfejlesztés gondját (lásd még a szoftverkrízisről szóló részeket). Ugyanakkor a modern módszertanok, jól bevált módszerek, tervezési eszközök és újabban a mesterséges intelligencia kombinációja nagyságrendekkel jobb és olcsóbb szoftverfejlesztést tesz lehetővé.
A terv legyen nagyon egyszerű, de annyira bonyolult amennyire muszáj 
A tervezés egyik legnépszerűbb alapelve a KISS:
Maradjon ostobán egyszerű! Angolul: Keep It Simple, Stupid!
Ez azt jelenti, hogy a terv akkor jó, ha már nem lehet tovább egyszerűsíteni, a funkciók letisztultak, még egy ostoba is tudja használni. Ennek az elvnek egy másik változata YAGNI elv:
Úgyse lesz rá szükség! Angolul: You Aren't Gonna Need It!
Egy funkciót, egy osztályt, egy plusz absztrakciós szintet csak akkor adunk hozzá a tervhez, az elkészült termékhez, ha biztosan szükség van rá. Ez az extrém programozás egyik alapelve.
Forráskód szintjén a DRY alapelvet szoktuk használni:
Ne ismételd önmagad! Angolul: Don’t Repeate Yourself!
Azaz a forráskódban ne legyenek ismétlődő részletek, hanem azokat emeljük ki egy metódusba, egy másik osztályba, vagy akár egy plusz absztrakciós szintbe. E miatt a DRY alapelv ellene hat a KISS alapelvnek: néha muszáj plusz absztrakciós szintet bevezetni. Ha nem tartjuk be a DRY elvet, akkor azt szoktuk mondani, hogy a forráskód nem elég száraz. A KISS és a DRY elveket együtt érhetjük tetten az egy ismert mérnöki alapelvben:
Olyan egyszerűen, amennyire csak lehet, és csak annyira bonyolultan, amennyire muszáj. Angolul: As simple as possible, as complicated as neccessary.
Azaz, a terv legyen nagyon egyszerű, de annyira bonyolult amennyire muszáj. Azaz a KISS mellett muszáj a DRY elvet is követni. 
További elvek
A jegyzet további elveket is tartalmaz, ezek:
az objektumorientált programozás alapelvei,
az objektumorientált tervezés alapelvei.
Az objektumorientált programozás alapelvei:
Egységbezárás (angolul: encapsulation)
Öröklődés (angolul: inheritance)
Többalakúság (angolul: polymorphism) 
Ebben a könyvben a debreceni és egri programozó képzés hagyományait követve a fenti 3 objektumorientált programozási alapelvet használjuk. Ezeket részletesen kifejtjük a későbbi fejezetekben.
Ugyanakkor meg kell jegyezni, hogy az angol nyelvű irodalom általában 4 objektumorientált programozás alapelvet használ. A fenti hármat kiegészítik az absztrakció elvével. Illetve sok forrás az objektumorientált programozás alapelveihez sorolja az objektum-orientált programozás alapvető technikai megoldásait is, mint az osztály és az objektumok használatát, a késői kötést, a név túlterhelést, illetve a metódusok felülírását.
A miskolci programozó képzés hagyományosan az információ rejtést (angolul: information hiding) külön objektumorientált programozási alapelvnek tekinti. Ebben a könyvben az információ rejtést az egységbezárás részeként értelmezzük.
Az objektumorientált tervezés alapelveinek köre nem teljesen letisztult terület. Néhány elvnek több, az irodalomban elterjedt neve is van. Az egyes alapelvgyűjtemények szűkebbek, mások bővebbek. A leginkább elfogadott alapelvek a következők:
GOF1: Programozz felületre implementáció helyett.
GOF2: Használj objektum-összetételt öröklés helyett, ha csak lehet.
HP (angolul: Hollywood Principle): Ne hívj, majd mi hívunk.
OCP (angolul: Open-Closed Principle): Az osztályok legyenek nyitottak a bővítésre, de zártak a módosításra.
LSP (angolul: Liskov Substitutional Principle): Az alosztály legyen egyben altípus is.
DIP (angolul: Dependency Inversion Principle): Absztrakciótól függj, ne függj konkrét osztályoktól.
Ezeket részletesen kifejtjük a későbbi fejezetekben.
A jegyzet megírását nagyban inspirált a „Joel on Software” című blog. Innen kerültek be a jegyzetbe a következő elvek:
A szivárgó absztrakció elve.
Joel teszt.
Módosított 80/20 elv.
A szivárgó absztrakció elve kimondja, hogy minél magasabb absztrakciós szinten álló programozási nyelvet használ a programozó, annál nagyobb rálátással kell rendelkeznie a szoftverfejlesztésre, mert egy hiba adódhat abból, hogy egy alsóbb absztrakciós szintet nem tökéletesen fed le a felette lévő. Az ilyen hibák megértéséhez és javításához az alsóbb szintek ismerete szükséges.
A Joel teszt, habár nem elv, szintén ide került. Ez egy szoftverfejlesztő cég termelékenységi potenciáját hivatott tesztelni:
Használsz forráskövető rendszert?
Megy a fordítás egy lépésben?
Naponta fordítod a szoftvered?
Van hibakövető rendszered?
Új kód írása előtt kijavítod a hibákat?
Van jól karbantartott ütemezésed?
Van specifikációd?
A programozók nyugodt körülmények között dolgozhatnak?
Az elérhető legjobb segédeszközöket használjátok?
Vannak tesztelőid?
Íratsz kódot a felvételi elbeszélgetésen?
Végzel folyosói használhatósági tesztet?
Reméljük, hogy jegyzetünk segít jó eredmények elérésében a Joel-teszten!
A módosított 80/20 elv az eredeti 80/20 elv alkalmazása a szoftver termékre. Az eredeti elv szoftverek esetében kimondja, hogy a szoftver utolsó 20%-ának elkészítése (más értelmezésben a legkritikusabb 20% elkészítése) a fejlesztés idejének 80%-át emészti fel (más értelmezésben a hibakeresés az idő 80%-át emészti fel). A módosított 80/20 elv kimondja, hogy a felhasználók 80%-a a szoftvertermék funkcióinak csak 20%-át használja, de mindegyikük más-más 20%-át.
Ez az elv arról szól, hogy csak komplex, sok-sok funkcióval bíró szoftverek lehetnek sikeresek a piacon. Ez az elv ellentmondani látszik a Unix fejlesztési filozófiájának: „Olyan programokat készíts, ami csak egy dolgot csinál, de azt jól csinálja”. Eredeti megfogalmazásában: „Write programs that do one thing and do it well.”
Ezen túl tárgyaljuk Fred Brooks megfigyelését, miszerint: új munkatárs felvétele egy késésben lévő szoftverprojekthez csak további késést okoz. Eredeti megfogalmazása: „Adding manpower to a late software project makes it later.”
Az objektumorientált programozás alapelvei
A szoftverkrízisre a programozási nyelvek azt a választ adták, hogy megjelentek a modulok, illetve a moduláris programozás. A modul a forráskód olyan kis része, amelyet egy programozó képes átlátni. A modulok gyakran fordítási alegységek is, azaz külön állományban találhatók. Az objektumorientált programozás (OOP) esetén a modul az osztály, ami egyben fordítási alegység is.
Az osztály első megközelítésben a valóság egy (megfogható vagy megfoghatatlan) darabkájának absztrakciója. Hogy ez a darabka kicsi vagy nagy, az az osztály felbontását (más szavakkal: granularitását, szemcsézettségét, durvaságát, angol szóval: granularity) adja meg. Ugyanakkor az osztály lehet teljesen technikai is, a valóságban semmihez sem kapcsolható. Tervezési minták sok ilyen osztályt tartalmaznak.
Az osztály második megközelítésben egy összetett, inhomogén adattípus. Sokban hasonlít a rekordhoz, ami szintén egy összetett, inhomogén adattípus. Ugyanúgy vannak mezői, a mezői bármilyen típusúak lehetnek, a mezőit minősítő jellel (sok nyelvben ez a pont (.)) érjük el. Egy különbség, hogy az osztály tartalmazhat metódusokat (eljárásokat, függvényeket), a rekord nem.
A rekord az eljárásorientált nyelvek (vagy más néven az imperatív nyelvek) kedvenc típusa. Az eljárások rekordokon dolgoznak. Az OOP is az imperatív programozási nyelvek családjába tartozik, csak itt már a rekordokat és a rekordokon dolgozó eljárásokat egybeolvasztjuk, méghozzá osztályokba. Azt mondjuk, hogy az adatokat és a rajtuk végrehajtott műveleteket egységbe zárjuk. Ezeket az egységeket hívjuk osztályoknak.
Az osztály mezőkből (más néven adattagokból) és metódusokból áll. A metódusok az adattagokon értelmezett műveletek.
public class Kutya {
	private String név;
	public Kutya(String név) { this.név = név; }
	public String GetNév() { return név; }
}

Osztály példa – Kutya osztály
A Kutya osztály UML ábrája:

PlantUML szkriptje:
@startuml
class Kutya{
-String név
+Kutya(String név) {this.név = név; }
+String GetNév() { return név; }
}
@enduml

Itt jegyezzük meg, hogy a jegyzetben egy kicsit szabadon használjuk az UML osztálydiagramját. Az UML nyelvi definíciója szerint a visszatéréi típust nem a függvény neve elé kellene írni, hanem mögé. A kapcsos zárójel pedig nem a függvény törzsének helye, hanem megszorításokat lehet közé írni. Mégis, mi ezt a C alapú nyelvekhez közel lévő, fenti leírást részesítjük előnyben. Ezt azért tehetjük meg, mert az évek során kiderült, hogy az UML csak két dologra jó, az ötletek gyors felrajzolására (skiccelésre), és a kiforrott megoldások dokumentálására. Tehát fontos, hogy egy UML ábra olvasmányos legyen, kényelmes egy Java vagy C# nyelvhez szokott szem számára.
Az osztálynak lehetnek példányai. A példányokat objektumoknak hívjuk. Ha maradunk annál a megközelítésnél, hogy az osztály a valóság absztrakciója, akkor a Kutya osztály a világ összes lehetséges kutyájának az absztrakciója. Ennek az osztálynak egy példánya, azaz egy Kutya típusú objektum, pedig a valóság egy konkrét kutyájának az absztrakciója. A konkrét kutya nevét az osztály konstruktorában adhatjuk meg, amikor példányosítjuk.
Az eddig leírtak valószínűleg mindenkinek ismertek voltak. Ugyanakkor van egy másik, programozástechnikai megközelítés is. E szerint az osztálynak két jellemzője van:
felülete és
megvalósítása (idegen szóval: implementációja, angolul: implementation).
Az objektumnak három jellemzője van:
felülete (vagy típusa),
viselkedése és
belső állapota.
Az osztály felületét a publikus részei adják. Mezőt ritkán teszünk publikussá, jellemzően metódusokon és property-ken keresztül használjuk őket (kivéve a statikus konstans mezőket), ezért az osztály felületét a publikus metódusainak feje adja. Általánosan: Ami publikus, az az osztály felületéhez tartozik. Az osztály felülete adja meg, hogy milyen szolgáltatásokat nyújt az osztály. A Kutya osztály például vissza tudja adni a kutya nevét a GetNév metódussal.
Az osztály megvalósítását a metódusainak (nem csak a publikus, hanem az összes metódusának) a törzse adja meg. Például a GetNév metódus implementációja az, hogy visszaadja a név mező értékét. Habár ez a szokásos kódja a GetNév-nek, más megvalósítást is megadhatnánk.

Kutya kutyám = new Kutya("Bodri");

Példányosítás példa – a kutyám nevű objektum a Kutya osztály példánya
A fenti példában létrehoztuk a kutyám nevű objektumot, ami a Kutya osztály egy példánya. A konkrét kutyánkat Bodrinak hívják. Fontos megjegyezni, hogy a kutyám nevű változó Kutya osztály referencia típusú. Tehát a kutyám csak egy referencia a példányra, amit a new utasítással hoztunk létre. A példány típusa és a referencia típusa nem feltétlenül egyezik meg, mint azt látni fogjuk.
Az objektum felülete megegyezik az osztályának a felületével, azaz a kutya objektum és a Kutya osztály felülete megegyezik. Még pontosabb azt mondani, hogy kutyám objektum Kutya típusú, vagy rövidebben, a kutyám Kutya típusú. Látni fogjuk, hogy egy objektumnak több típusa is lehet.
Érdekesség: Az erősen típusos nyelveken egy objektumot csak akkor használhatok egy osztály példányaként, ha olyan típusú. Ilyen nyelv pl. a Java és a C#. A gyengén típusos nyelveknél elegendő, ha az objektum felülete bővebb az osztályénál. Ilyen nyelv pl. a Smalltalk.
Az objektum belső állapotát mezőinek pillanatnyi értéke határozza meg. Mivel az osztály metódusai megváltoztathatják a mezők értékeit, ezért a metódusokat tekinthetjük állapotátmeneti operátoroknak is. Az objektum kezdő állapotát a mezőinek kezdő értéke és az őt létrehozó konstruktorhívás határozza meg.
Az objektum viselkedését a metódusainak implementációja adja. Az objektum viselkedése függ a belső állapottól. Ha van egy if utasítás a forráskódban, akkor már kétféle viselkedés lehet. Hogy melyik fog futni, az a mezők értékétől (belső állapot), és a paraméterek értékétől (külső állapot) függ.
Az szoktuk mondani, hogy az osztály megvalósítása az maga a forráskód, vagyis a forráskód statikus vetülete. Az objektum viselkedése pedig a forráskód dinamikus vetülete, azaz, a futó forráskód. A viselkedés arra a kérdésre ad választ, hogy a forráskód mely ága hajtódik végre. Ez utóbbi nyilván a mezők értékétől, azaz az objektum belső állapotától, és a futó metódus paramétereitől, azaz a külső állapottól függ.
Fontos megjegyezni, hogy az interfésznek csak felülete van, az absztrakt osztálynak felülete és részleges megvalósítása. Az absztrakt osztálynak lehet, hogy egyáltalán nincs megvalósítása, ha minden metódusa absztrakt.
A fenti fogalmakkal fogalmazzuk meg az objektumorientáltság jól ismert alapelveit. Látni fogjuk, hogy az eddigi kedvencünkről, az öröklődésről kiderül, hogy veszélyes. Az új kedvencünk a többalakúság lesz.
Egységbezárás – Encapsulation
Az egységbezárás (angolul: encapsulation) klasszikus megfogalmazása valahogy így hangzik: Az adattagokat és a rajtuk műveleteket végrehajtó metódusokat egységbe zárjuk, ezt az egységet osztálynak nevezzük. Új fogalmainkkal az egységbezárás azt jelenti, hogy az objektum belső állapotát meg kell védeni, azt csak a saját metódusai változtathatják meg. Ezt szokás információ rejtésnek (angolul: information hiding) is nevezni. Ez a két megfogalmazás kiegészíti egymást, mindkettő jogos.
Öröklődés – Inheritance
Az öröklődés (angolul: inheritance) a kód-újrahasznosítás kényelmes formája. A gyermekosztály az ős osztály minden nem privát mezőjét és metódusát megörökli. Azaz a gyermekosztály örökli az ős osztály felületét és megvalósítását. Mint látni fogjuk, az öröklődés a gyermek és az ős osztály között implementációs függőséget okoz, ami kerülendő. Öröklődés helyett, hacsak lehet, objektum-összetételt ajánlott használni.
Az örökölt, absztrakt vagy virtuális metódusokat felülírhatjuk (angolul: overriding). Ezt a lehetőséget sokan a többalakúsághoz sorolják.
Többalakúság – Polymorphism
A jegyzetben ismertetett tervezési alapelvek és tervezési minták majd mindegyike a többalakúságon (angolul: polymorphism) alapszik. Tehát ez egy nagyon fontos alapelv. Maga a többalakúság az öröklődés következménye. Mivel a gyermekosztály örökli az ős felületét, ezért a gyermekosztály példányai megkapják az ős típusát is. Így egy objektum több típusként, azaz több alakban is használható.
public class Vizsla : Kutya { }
Kutya kutya = new Vizsla("Frakk");

Többalakúságra példa – a „Frakk” nevű vizsla példány használható Kutyaként
A fenti példában a Vizsla osztály a Kutya osztály gyermeke. A Vizsla konstruktora segítségével készítünk egy „Frakk” nevű Vizsla példányt. Ennek a példánynak három típusa van: Vizsla, Kutya és Object. Mindhárom típus példányaként használható. Erre rögtön látunk is egy példát, hiszen egy Kutya típusú változónak adjuk át értékül az új példányt.
Nézzük meg az Object - Kutya - Vizsla öröklődési hierarchia UML diagramját:

PlantUML scriptje:
@startuml
Object <|-- Kutya
Kutya  <|-- Vizsla
@enduml

Egy osztály példányai az öröklődési hierarchián felfelé haladva rendelkeznek az összes típussal. Ennek megfelelően minden objektum Object típusú is, hiszen ha nem adjuk meg egy osztály ősét, akkor az az Object osztályból származik. Akárhogy is, minden osztályhierarchia tetején, Java és C# nyelv esetén is. az Object osztály van.
Sok szerző a metódus túlterhelést (overloading) is a többalakúsághoz sorolja, hiszen ezáltal egy metódusnak több alakja lesz. Ebben a jegyzetben mi többalakúságon csak azt értjük, hogy egy objektum több osztály példányaként is használható.
Az OOP hasznos megoldásai
Azt gondolnánk, hogy a fenti három alapelv közül az öröklődés a legerősebb, hiszen ez teszi lehetővé, hogy nagyon egyszerűen újrahasznosítsuk az ős kódját. Lehet, hogy az OOP ettől lett népszerű, de az OOP igazi ereje ezekben a technikákban rejlik:
Automatikus szemétgyűjtés (angolul: garbage collection, angol rövidítése: GC),
Mező, mint lokális-globális változó,
Többalakúság használata osztály behelyettesítésre,
Csatoltság csökkentése objektum-összetétellel.
Automatikus szemétgyűjtés
Az automatikus szemétgyűjtés nem csak az OOP nyelvekre jellemző, de az OOP nyelvekkel egyszerre lett népszerű. Leveszi a programozó válláról azt a terhet, hogy az általa lefoglalt memória (minden new utasítás memóriát foglal) felszabadításáról gondoskodjon. Ezt a programozó
elfelejtheti,
rosszul oldhatja meg (pl. túl korán szabadítja fel, vagy mást szabadít fel).
Tudjuk, hogy amit lehet rosszul csinálni, azt a programozók a nagy hajtásban általában rosszul is csinálják. Ha ezt, az automatikusan is megoldható feladatot, a keretrendszer végzi el, az nagyban csökkenti a fejlesztési és a tesztelési időt is. Ugyanakkor ez nem OOP specifikus tulajdonság.
Ahhoz, hogy megértsük az automatikus szemétgyűjtést, nézzük át mit is jelent a memória foglalás, illetve mi is az a memória szoftver szemszögből nézve.
A processzor az adatokat és metódusokat a véletlen hozzáférésű tárban (angolul: Random Access Memory - RAM) helyezi el. Véletlen a hozzáférése mert bármelyik adatát el tudjuk érni, mégpedig annak memória címével. Ez a cím a legtöbb magasszintű programnyelvben nem érhető el, mivel nem közvetlenül alacsony szinten kezeli a címeket a kódunkat futtató virtuális gép, hanem a számára biztosított memória területet felosztja a metódusok és adatok tárolására alkalmas területekre. Az adatokat a halom (angolul: heap) és a verem (angolul: stack) fogja tárolni. A heap-ben az osztályok, a példányaik és a példány változók tárolódnak, míg a stack a metódusok lokális változóit tartalmazza. Ebből is látható, hogy a stack addig létezik, míg a metódus, amihez tartozik fut, ezzel szemben a heap az független a metódusok életciklusától, így az objektumok léte nem közvetlen függ az azokat használó metódusoktól.
De hogyan is valósul meg mindezek használata a programunk futtatása során? Nézzünk erre egy példát! Tételezzük fel, hogy van egy olyan Java program, amiben van egy Circle osztály, az pedig rendelkezik egy radius változóval és ki tudja számolni a saját területét. Továbbá rendelkezik három metódussal. Az m1() csak saját lokális változóját használja, de meghívja az m2() metódust. Az m2() rendelkezik bemenő paraméterrel és egy saját lokális változóval is, továbbá meghívja az m3() metódust. Végezetül az m3() létrehoz egy Circle példányt és kiírja annak területét. Java programunk belépési pontja a main(), ami csak az m1() metódust fogja meghívni.
public class Main {
   public static void main(String[] args) {
       m1();
   }


   static void m1(){
       int x = 0;
       m2(x);
   }
   static void m2 (int b){
       int a = 0;
       m3();
   }
   static void m3(){
       Circle circle = new Circle(10);
       System.out.println(circle.area());
   }
}
A memóriafoglalás folyamatának megértését kezdjük az elején, a main() metódusnál!
Mikor a program végrehajtása elér ide, akkor a main() metódus számára létrejön egy lefoglalt terület a stack-en és ebbe bekerül az args változó és a hozzá tartozó adat.

Folytatódik a main() feldolgozása és mikor elér oda, hogy meghívja az m1() metódust, akkor annak is lefoglalásra kerül egy stack terület az x változójával együtt.

Mivel az m1() meghívja az m2() metódust, így annak is lefoglalásra kerül egy terület a stack-en és ebbe két változó (b  és a) tárolódnak el.

Amint az m2() meghívja az m3() metódust, természetesen ahhoz is létrejön a stack-en egy tárterület.

Az m3() egyetlen circle lokális változóval rendelkezik. Viszont ennek példányosítási folyamata el fog térni az eddigiektől, ugyanis lefoglalásra kerül a new kulcsszó hatására  a Circle osztály definíción alapuló példány a heap-en. Erre hivatkozás, vagyis referencia még nem létezik, tehát hivatkozni rá nem tudunk az m3() metódusból.

Ahhoz, hogy el tudjuk érni a heap-en létrejött példányt, a stack-en kell egy referencia rá, ez lesz a circle változó, ami egy Circle típusú objektumra fog mutatni.

Most már rendelkezünk referenciával és objektummal is, de a kettő még nincs összerendelve. Ezt tesszük meg mikor az egyenlőség jellel összekötjük őket.

Összefoglalva, a Circle circle = new Circle(10); sor mind a heap mind a stack területen lefoglal az m3() metódus számára helyet és a circle lesz az a referencia amivel az m3()-ból hivatkozni tudunk a heap-en tárolt adatokra.
Miért jó ez? A válasz a stack és heap közti különbségen alapul.  Ugyanis mikor az m3() lefut, akkor megszűnik és vele együtt a stack-en tárol területe is felszabadul.

De a heap-en tárolt példányra más referencia még hivatkozhat, annak nem kell megszűnnie. Lényegében csak a circle lokális változó törlődik automatikusan.
Természetesen amennyiben a Circle példányt nem használja más, akkor idővel a Garbage Collector ezt felfedezi és fel fogja szabadítani azt. 

Végezetül pedig ahogy az m2() és m1() is lefut azok stack-en foglalt területei is felszabadulnak, és ha a main()-ben sincs más ami fenntarthatná, annak tárhelye is törlődik, végül a program leáll.

További érdekességek ebben a témában: cím: Java Stack and Heap - Java Memory Management, link: https://www.youtube.com/watch?v=450maTzSIvA.
A mező mint lokális-globális változó
A mező mint lokális-globális változó egy nagyon hasznos újítás. Tudjuk, hogy sok imperatív nyelvben van globális változó. Ezek gyorsabb és kisebb kód fejlesztését teszik lehetővé, hiszen egy globális változót nem kell paraméterként átadni. Ugyanakkor a globális változók használata mellékhatást okoz.
Mellékhatásnak nevezzük, ha egy alprogram (függvény, eljárás, vagy metódus) megváltoztatja a környezetét, azaz:
globális változóba ír,
kimenetre (képernyőre / nyomtatóra / kimeneti portra) ír,
fájlba ír.
Mellékhatás használatával gyorsíthatjuk a program futását, de használata nehezen megtalálható hibákat eredményez, mivel a hiba a változás helyétől távol lévő programsor hibás működését eredményezheti. Az ilyen hibák megtalálásához nem elég az új funkció részletes nyomkövetése. Gyakran az egész forráskódot muszáj átvizsgálni, ami időrabló feladat. Ezért nem tanácsos mellékhatáshoz folyamodni, azaz globális változót használni.
Mégis, a globális változók használata gyorsítja a programot és kisebb, elegánsabb a forráskód is. Tehát jó lenne, ha lenne globális változó, illetve mégse lenne jó. A mező pont ilyen, hiszen az osztályon belül globális, kívülről elérhetetlen. A mezők használatával tudunk mellékhatást előidézni, de ez az osztályon belül lokális, így az esetleges mellékhatásokból fakadó hibák könnyebben megtalálhatók.
Igazság szerint csinálhatunk teljesen globális változót is. Egy publikus osztályszintű mezőt bárhonnan írhatunk és olvashatunk, tehát az ilyen mező globális. Szerencsére az egységbezárás, illetve azon belül az információ rejtés miatt a publikus mezőket természetellenesnek érezzük, így senki sem használ már globális változókat OOP nyelveken.
Többalakúság használata osztály behelyettesítésre
A többalakúság biztosítja, hogy a kódunk rugalmas legyen. Míg az öröklődés nagyon merev struktúrákat hoz létre, addig a többalakúság a rugalmasságot szolgálja. Ennek alapja, hogy egy gyermekosztályú példány használható mindenütt, ahol ős osztály típusú paramétert várunk. Ez a többalakúság lényege.
Például könnyen készíthetünk egy pipagyár osztályt. Hogy konkrétan milyen pipát gyártunk, az csak attól függ, hogy a fapipa vagy a tajtékpipa gyermekét példányosítjuk.
Hol van itt a többalakúság, hiszen eddig szinte csak öröklődésről beszéltünk? Helyes megfigyelés, hiszen többalakúság nincs öröklődés nélkül. A gyermekosztály helyettesíthető az ős helyére. A lényeg a helyettesítésen van. Attól függ a programok működése, hogy mely gyermeket helyettesítjük be. Ezt a behelyettesítést viszont a többalakúságnak köszönhetjük, ami nem feltétlenül öröklődés útján érhető el, hanem egy interfész implementációjával is. Mikor helyettesíthetünk be egy osztályt a másik helyére? Ha ez az osztály:
a másik osztály gyermeke,
ha megvalósítja a várt interfészt,
vagy megvan minden metódus, amit hívni akarok (csak a gyengén típusos nyelvek esetén).
Hol van lehetőség behelyettesítésre:
Paraméterátadás (ős osztályú példányt várunk, de gyermeket kapunk),
Példányosítás (a referencia ős osztály típusú, de egy gyermek példányra mutat),
Felelősséginjektálás (kívülről kapunk egy objektumot, aminek csak a felületét ismerjük).
Látni fogjuk, hogy minden tervezési minta a behelyettesíthetőség lehetőségén alapszik.
Csatoltság csökkentése objektum-összetétellel
A csatoltság (angolul: coupling) alatt annak fokát értjük, hogy egy osztály (vagy más modul) milyen mértékben alapszik a többi osztályon. A csatoltságot szokás a kohézió (angolul: cohesion) ellentéteként értelmezni. Alacsony fokú csatolás általában magas fokú kohéziót eredményez, illetve ez a másik irányban is igaz. A csatoltság mértékét Larry Constantine csoportjának munkája alapján a következő módon számoljuk.
Definíció: OOP-ben a csatoltság annak mértéke, hogy milyen erős kapcsolatban áll egy osztály a többi osztállyal. A csatolás mértéke két osztály, mondjuk A és B között növekszik, ha:
A-nak van B típusú mezője.
A meghívja B valamelyik metódusát.
A-nak van olyan metódusa, amelynek visszatérési típusa B.
A B-nek leszármazottja, vagy implementálja B-t.
A csatoltság szintjei (legerősebbtől a leggyengébbig):
erősen csatolt (angolul: tightly coupled)
gyengén / lazán csatolt (angolul: loosly coupled)
réteg (angolul: layer)
Az erős csatoltság erős függőséget is jelent. A következő fajta függőségeket szoktuk megkülönböztetni:
Függőség a hardver és szoftver környezettől: Ha a programunk függ egy adott hardvertől vagy szoftvertől (leggyakrabban operációs rendszertől), akkor ez azt jelenti, hogy ezek speciális tulajdonságait kihasználjuk és így a programunk nem, vagy csak nehezen portolható át egy másik környezetbe. Ennek egyik nagyszerű megoldása a virtuális gép használata. A forráskódunkat egy virtuális gép utasításaira fordítjuk le. Ha egy adott operációs rendszer felett egy adott hardveren fut a virtuális gép, akkor a mi programunk is futni fog.
Implementációs függőség: Egy osztály függ egy másik implementációjától, azaz ha az egyik osztály megváltoztatása esetén meg kell változtatni a másik osztályt is, akkor implementációs függőségről beszélünk. Ez is egyfajta környezeti függés, egy osztály függ a környezetében lévő egy vagy több másik osztálytól, de itt a környezete a program forráskódja. Ha csak a másik osztály felületétől függünk, azaz teljesen mindegy, hogy hogyan implementáltuk a másik osztály metódusait, csak azok helyes eredményt adjanak, akkor nem beszélünk implementációs függőségről. Ezzel a függőséggel még részletesen fogunk foglalkozni.
Algoritmikus függőség: Akkor beszélünk algoritmikus függőségről, ha nehézkes az algoritmusok finomhangolása. Gyakran előfordul, hogy a program egy-egy részét gyorsabbá kell tenni, mondjuk buborékos rendezés helyett gyors rendezést kell alkalmazni. Például, ha a rendezés közben szemléltetjük a rendezés folyamatát, akkor nehéz lesz áttérni egyik rendezésről a másikra.
A három függőség közül csak az implementációs függőséggel foglalkozunk, de azzal nagyon részletesen. Már megemlítettük, hogy az öröklődés implementációs függőséget okoz. Nézzünk erre egy példát Java nyelven. A feladat a beépített HashSet osztály bővítése a betett elemek számolásával.
import java.util.*;
public class MyHashSet extends HashSet{
 	private int addCount = 0;
 	public boolean add(Object o){
       	addCount++;
       	return super.add(o);
 	}
 	public boolean addAll(Collection c){
       	addCount += c.size();
       	return super.addAll(c);
 	}
 	public int getAddCount(){ return addCount; }
}


A MyHashSet UML ábrája:


PlantUML szkriptje:
@startuml
class HashSet{}
class MyHashSet{
-int addCount = 0;
+boolean add(Object o){addCount++; return super.add(o);}
+boolean addAll(Collection c){ addCount += c.size(); return super.addAll(c);}
+int getAddCount(){ return addCount; }
}
HashSet <|-- MyHashSet
@enduml

Ebben a példában létrehoztuk örökléssel a MyHashSet osztályt. Annyival egészítettük ki az őst, hogy számoljuk, hány elemet adunk hozzá a hasító halmazhoz. Ehhez az addCount mezőt használjuk, ami kezdetben nulla. Két metódussal lehet elemet hozzáadni a halmazhoz, az add és az addAll metódussal, ezért ezeket felülírjuk. Az add megnöveli eggyel az addCount-ot és meghívja az ős add metódusát, hiszen az tudja hogyan kell ezt a feladatot megoldani, mi csak ráültünk a megoldásra. Az addAll hasonlóan működik, de ott több elemet adunk egyszerre hozzá a listához, ezért az addCount értékét az elemek számával növeli meg.
Ezt a feladatot mindenki hasonlóan készítette volna el, hiszen a kód-újrahasznosítás legegyszerűbb formája az öröklés. Egy bökkenő van. Ez így nem megfelelően működik!
import java.util.*;
public class Main {
 	public static void main(String[] args){
       	HashSet s = new MyHashSet();
       	String[] abc = {"a","b","c"};
       	s.addAll(Arrays.asList(abc));
 	 	System.out.println(s.getAddCount());
 	}
}

Ebben a példában létrehoztunk egy 3 elemű tömböt, azt addAll metódussal hozzáadtuk a MyHashSet egyik példányához. Ezután kiíratjuk, hány elemet adtunk hozzá a halmazhoz. Azt várnánk, hogy a program azt írja ki, hogy 3, de e helyett az írja, hogy 6.
Mi történt? Nem tudtuk, hogy az ősben, azaz a HashSet osztályban, úgy van megvalósítva az addAll metódus, hogy az egy ciklusban hívogatja az add metódust, így veszi fel az elemeket. Amikor a gyermek addAll metódusát hívtuk, az hozzáadott 3-at az addCount-hoz és meghívta az ős addAll metódusát. Az háromszor meghívta az add metódust. A késői kötés miatt nem az ős add metódusát, hanem a gyermek add metódusát hívta, ami szépen mindig 1-gyel növelte az addCount értékét. Így jött ki a 6. Azaz az történt, hogy csúnyán ráfáztunk az öröklődés okozta implementációs függőségre.
A fenti kódot úgy lehet kijavítani, hogy csak az add metódusban növeljük az addCount értékét:
import java.util.*;
public class MyHashSet extends HashSet{
 	private int addCount = 0;
 	public boolean add(Object o){
       	addCount++;
       	return super.add(o);
 	}
 	public int getAddCount(){ return addCount; }
}


A MyHashSet UML ábrája:

PlantUML szkriptje:
@startuml
class HashSet{}
class MyHashSet{
-int addCount = 0;
+boolean add(Object o){addCount++; return super.add(o);}
+int getAddCount(){ return addCount; }
}
HashSet <|-- MyHashSet
@enduml

Amikor írjuk a gyerek osztályt, tudnunk kell, hogyan van az ős implementálva, különben hasonló nehezen megérthető problémákkal találhatjuk magunkat szembe. Ugyanakkor, ha kihasználjuk, hogy hogyan van implementálva az ős, akkor az ős változása eredményezheti, hogy a gyermeknek is változnia kell. Ez pedig implementációs függés!
Hogyan lehet ezt elkerülni? A megoldás, hogy ne öröklődést, hanem objektum-összetételt használjunk: Ha az A osztálynak van egy B osztály típusú mezője, akkor azt mondjuk, hogy objektum-összetételt használtunk.
Az öröklődés mindig kiváltható objektum-összetétellel, hiszen az alábbi két, végletekig leegyszerűsített program ugyanazt csinálja:

class A {
   public void M1() {
      Console.Write("hello");
   }
}
class B : A {
  
   public void M2() { M1(); }
}
class Program {
  static void Main(string[] a)
  {
 	B b = new B();
 	b.M2();
 	Console.ReadLine();
  }
}




class A {
   public void M1() {
      Console.Write("hello");
   }
}
class B {
   A a = new A();
   public void M2() { a.M1(); }
}
class Program {
  static void Main(string[] a)
  {
 	B b = new B();
 	b.M2();
 	Console.ReadLine();
  }
}



Itt a B osztály az A osztály gyermeke, így örökli az A osztályból az M1 metódust, amit M2 metódusban hív meg. A főprogramban meghívjuk az M2 metódust, amely meghívja az ősben lévő M1 metódust, ami kiírja, hogy hello.
Itt a B osztálynak van egy A típusú mezője. Ezt példányosítanunk kell. Az M2 metódus meghívja ezen a mezőn keresztül az M1 metódust. A főprogramban meghívjuk az M2 metódust, amely az objektum-összetétel, azaz az „a” referencián keresztül hívja az M1 metódust, ami kiírja, hogy hello.


@startuml
class A{
+void M1()
}
class B{
+void M2()
}
A <|-- B
@enduml





@startuml
class A{
+void M1()
}
class B{
-A a
+void M2()
}
A <-down-o B: -a
@enduml





Az objektum-összetétel nagyon rugalmas, hiszen az futási időben történik, szemben az öröklődéssel, ami már fordítási időben ismert. Ugyanakkor az öröklődést sokkal egyszerűbb felfogni, megérteni és elmagyarázni. Ezért objektum-összetételt, ami kisebb csatoltságot, kisebb implementációs függőséget és rugalmasabb kódot biztosít, csak akkor használjunk, ha már sok programozói tapasztalattal bírunk.
Amikor objektum-összetételnél egy metódust úgy valósítunk meg, hogy annak lényegi része csak az, hogy az összetételt megvalósító referencián keresztül meghívunk egy metódust, akkor azt mondjuk, hogy delegáljuk a felelősséget a beágyazott objektumnak. A fenti példában ilyen az M2 metódus, ami csak meghívja az M1 metódust. A felelősség delegálás fogalmát nem szabad összekeverni a C# nyelv delegate kulcsszavával, hiszen azzal függvénytípust hozunk létre, nem felelősség átadásra való.
Az objektum-összetételnél kérdés, hogy hogyan kapjuk meg az összetételben szereplő objektumot. A fenti példában saját példányt készítettünk. Ezzel a kérdéssel részletesen foglalkozunk a felelősséginjektálás témakörén belül.
A későbbiekben látni fogjuk, hogy habár az öröklődést mindig ki lehet váltani objektum-összetétellel, nem mindig ez a célravezető, hiszen öröklődés nélkül nincs többalakúság. Többalakúság nélkül pedig nem lehet rugalmas kódot írni.
Tervezési alapelvek
Az objektumorientált tervezés alapelvei (angolul: object-oriented design principles) a tervezési mintáknál magasabb absztrakciós szinten írják le, milyen a „jó” program. A tervezési minták ezeket az alapelveket valósítják meg szintén még egy elég magas absztrakciós szinten. Végül a tervezési mintákat realizáló programok az alapelvek megvalósulásai. Az alapelveket természetesen úgy is fel lehet használni, hogy nem követjük a tervezési mintákat.
A tervezési alapelvek abban segítenek, hogy több, általában egyenértékű programozói eszköz, pl. öröklődés- és objektum-összetétel közül kiválasszuk azt, amely jobb kódot eredményez. Általában jó a kód, ha rugalmasan bővíthető, újrafelhasználható komponensekből áll és könnyen érthető más programozók számára is.
A tervezési alapelvek segítenek, hogy ne essünk például abba a hibába, hogy egy osztályba kódolunk mindent, hogy élvezzük a mezők, mint globális változók programozást gyorsító hatását. A tapasztalat az, hogy lehet programozni az alapelvek ismerete nélkül, vagy akár tudatos megszegésével, csak nem érdemes. Gondoljunk vissza a programozási technológiák alapelvére: „A program kódja állandóan változik!”. Azaz, ha rugalmatlan programot írunk, akkor a jövőben keserítjük meg az életünket, amikor egy változást kell belehegeszteni a programunkba. Inkább érdemes a jelenben több időt rászánni a fejlesztésre és biztosítani, hogy a jövőben könnyű legyen a változások kezelése. Ezt biztosítja számunkra az alapelvek betartása.
Lecke 7.: A GOF könyvei alapelvei
A lecke célja és tartalma
Célok, megszerezhető kompetenciák: A lecke végére megismerkedünk a GOF könyv két tervezési alapelvével, a GOF1 és GOF2 alapelvekkel, így képesek leszünk ezeket a gyakorlatban alkalmazni.
Szükséges eszközök, források: A GOF könyv. A könyv magyar címe: „Programtervezési minták, Újrahasznosítható elemek objektumközpontú programokhoz.” A könyv angol címe: „Design Patterns: Elements of Reusable Object-Oriented Software”.
Feldolgozási idő: 90 perc.
Témakörök: GOF1, GOF2, objektum-összetétel, HAS-A kapcsolat, becsomagolás.
A lecke tartalma: Ebben a leckében áttekintjük a GOF könyv két alapelvét és gyakorlati alkalmazásukat. Először is, megvizsgáljuk a „Programozz felületre implementáció helyett” alapelvet (GOF1), amely arra ösztönzi a tervezőket, hogy az interfészre programozzanak, ne pedig az implementációra. A következő alapelv, a „Használj objektum-összetételt öröklés helyett, ha csak lehet” (GOF2) arra ösztönzi a tervezőket, hogy inkább objektum-összetételt alkalmazzanak az öröklés helyett. Az öröklés előnyeit és korlátait összehasonlítva láthatjuk, hogy az objektum-összetétel rugalmasabb és jobban támogatja a tervezési változásokat. A továbbiakban megvizsgáljuk az IS-A és HAS-A kapcsolatot. Az IS-A kapcsolat az öröklődést jelenti, míg a HAS-A kapcsolat az objektum-összetételt. Ezután részletesen foglalkozunk az aggregációval és a kompozícióval, két különböző objektum-összetétel típussal. Aggregáció esetén a rész létezhet az egész nélkül is. Kompozíció esetén a rész nem létezhet az egész nélkül. Végül, megvizsgáljuk az átlátszó és átlátszatlan becsomagolást, amik szintén az objektum-összetétel típusai.
A GOF könyv 1. alapelve – GOF1
A GOF1 alapelv a Gang of Four (GOF) könyvben jelent meg 1995-ben. A könyv magyar címe: „Programtervezési minták, Újrahasznosítható elemek objektumközpontú programokhoz.” A könyv angol címe: „Design Patterns: Elements of Reusable Object-Oriented Software”. Az alapelv eredeti angol megfogalmazása: „Program to an interface, not an implementation”, azaz „Programozz felületre implementáció helyett”.
Mit jelent ez a gyakorlatban? Egyáltalán, hogy lehet implementációra programozni? Miért rossz implementációra programozni? Miért jó felületre?
Akkor programozunk implementációra, ha kihasználjuk, hogy egy osztály hogyan lett implementálva. Egy példát a MyHashSet osztályon keresztül már láttunk, amikor tudnunk kellett, hogyan lett az ős implementálva. Egy másik példa:
class NagySzám {
	//maximum ennyi számjegyű nagy szám
	private const int maxHossz = 20;
	//használt számrendszer alapja
	private const int alap = 10;
	//a számjegyek fordított sorrendben vannak
	//pl. 64 esetén: számjegyek[0]=4, számjegyek[1]=6
	private int[] számjegyek = new int[maxHossz];
	public NagySzám(int[] szám) {
    	Array.Copy(szám, számjegyek, szám.Length);
	}
	public static NagySzám Összead(NagySzám S1, NagySzám S2) {
    	int[] A = S1.számjegyek;
    	int[] B = S2.számjegyek;
    	int[] C = new int[maxHossz];
    	int átvitel = 0;
    	for(int i=0; i<maxHossz; i++) {
        	C[i] = A[i] + B[i] + átvitel;
        	átvitel = C[i] / alap;  C[i] %= alap;
    	}
    	return new NagySzám(C);
	}
	public long ToLong() {
    	int i = maxHossz - 1; long szám = 0;
    	while (számjegyek[i] == 0 && i>0) i--;
    	for (; i >= 0; i--) {
        	szám *= alap; szám += számjegyek[i];
    	}
    	return szám;
	}
}


A NagySzám UML ábrája:

PlantUML szkriptje:

@startuml
class NagySzám{
-const int maxHossz = 20;
-const int alap = 10;
-int[] számjegyek= new int[maxHossz];
+NagySzám(int[] szám){ Aray.Copy(szám,számjegyek,szám.Length);}
+static NagySzám Összead(NagySzám S1, NagySzám S2)
+long ToLong()
}
note right of NagySzám::Összead
private static NagySzám Összead(NagySzám S1, NagySzám S2){
int[] A = S1.számjegyek;
int[] B = S2.számjegyek;
int[] C = new int[maxHossz];
int átvitel = 0;
for(int i=0;i<maxHossz;i++){
 C[i] = A[i] + B[i] + átvitel;
 átvitel = C[i] / alap;
 C[i] %= alap;
 }
return new NagySzám(C);
}
endnote
note bottom of NagySzám
public long ToLong(){
int i = maxHossz - 1;
long szám = 0;
while(számjegyek[i] == 0&& i>0) i--;
for(; i >=0; i--){
 szám *= alap; szám+= számjegeyek[i];
 }
return szám;
}
endnote
@enduml

A fenti példában készítettünk egy NagySzám osztályt, amely a nagy szám számjegyeit a számjegyek tömbben tárolja. A legkisebb helyiértékű szám van a legkisebb indexen. A konstruktor ezt a tömböt tölti fel. Ezen túl két metódust látunk, az egyik az összeadás, a másik long típusú számmá alakítja vissza a számjegyek tömbben tárolt számot. A tömbben tárolt szám számrendszerének alapja az alap konstansban van eltárolva. Most 10-es számrendszer az alapértelmezett. De mi van, ha az alap megváltozik? Sajnos akkor minden kód, ami feltételezi, hogy 10-es számrendszert használunk, az elromlik. Például az alábbi is:
class Program {
	static void Main(string[] args) {
    	int[] a = { 3, 5 }; //53
    	int[] b = { 1, 2, 3 }; //321
    	NagySzám A = new NagySzám(a);
    	NagySzám B = new NagySzám(b);
    	NagySzám C = NagySzám.Összead(A, B);
    	Console.WriteLine(C.ToLong());
    	Console.ReadLine();
	}
}

A fenti kód 374-et ír ki, ha az alap 10-es, 252-öt, ha az alapot átírjuk 8-ra, és így tovább. Tehát a NagySzám belső implementációja befolyásolja az őt használó osztályok működését. A problémát az okozza, hogy a bemeneti szám átalakítását lusták voltunk elvégezni, habár az a NagySzám felelőssége lenne. Az átalakítást a hívóra hagytuk, de ez rossz megoldás, mint ahogy láttuk.
A megoldás, ha egy olyan konstruktort csinálunk, ami egy long típusú számot vár. A másik konstruktort priváttá kell tenni. Ebben az esetben akármilyen belső alapot használunk, az nem fogja zavarni a többi osztályt. Tehát a jó megoldás (csak a megváltozott és az új kódot mutatjuk):
class NagySzám {
	...
	private NagySzám(int[] szám) { // ez mostmár privát
    	  Array.Copy(szám, számjegyek, szám.Length);
	}
	public NagySzám(long szám) { //új konstruktor
    	  int i = 0;
    	  while (szám > 0) {
        	számjegyek[i] = (int)(szám % alap);
        	szám /= alap;
        	i++;
    	  }
	}
	...
}
class Program {
	static void Main(string[] args) {
    	  NagySzám A = new NagySzám(53);
    	  NagySzám B = new NagySzám(321);
    	  NagySzám C = NagySzám.Összead(A, B);
    	  Console.WriteLine(C.ToLong()); //374
    	  Console.ReadLine();
	}
}



A NagySzám UML ábrája:

PlantUML szkriptje:
@startuml
class NagySzám{
-const int maxHossz = 20;
-const int alap = 10;
-int[] számjegyek= new int[maxHossz];
-NagySzám(int[] szám){ Aray.Copy(szám,számjegyek,szám.Length);}
+NagySzám(long szám)
+static NagySzám Összead(NagySzám S1, NagySzám S2)
+long ToLong()
}
note right of NagySzám::NagySzám
// ez mostmár privát
endnote
note left of NagySzám::"NagySzám(long szám)"
	public NagySzám(long szám) { //új konstruktor
    	int i = 0;
    	while (szám > 0) {
        	számjegyek[i] = (int)(szám % alap);
        	szám /= alap;
        	i++;
    	}
}
endnote
@enduml

Most már akármilyen számrendszert használ a NagySzám, mindig 374 lesz az eredmény.
Látható, hogy általában akkor kényszerülünk implementációra programozni, ha az osztály felelősségi körét rosszul határoztuk meg és egy osztály több felelősségi kört is lefed, vagy egy felelősséget nem teljesen fed le, mint a NagySzám. Tehát, ha a kódunkban találunk olyan részt, amely egy másik osztály implementációjától függ, akkor az hibás tervre utal.
Ha implementációra programozunk, és ha megváltozik az osztály, akkor a vele kapcsolatban álló osztályoknak is változniuk kell. Ezzel szemben, ha felületre programozunk, és megváltozik az implementáció, de a felület nem, akkor nem kell megváltoztatni a többi osztályt.
A GOF könyv 2. alapelve – GOF2
A GOF2 alapelv, hasonlóan a GOF1-hez, a GOF könyvben jelent meg 1995-ben. Az alapelv eredeti angol megfogalmazása: „Favor object composition over class inheritance”, azaz „Használj objektum-összetételt öröklés helyett, ha csak lehet”.
Mit jelent ez a gyakorlatban? Egyáltalán mit jelent az objektum-összetétel? Miért jobb az öröklődésnél? Mi a baj az öröklődéssel? Ha jobb az objektum-összetétel, akkor miért nem mindig azt használjuk?
Már láttuk, hogy objektum-összetétellel mindig ki lehet váltani az öröklődést. Az öröklés azért jó, mert megörököljük az ős összes szolgáltatását (metódusait), amit használni tudunk. Objektum-összetételnél ezen osztály egy példányára szerzek egy referenciát és azon keresztül használjuk a szolgáltatásait. Ez utóbbi futási időben dinamikusan változhat, hiszen az, hogy melyik objektumra mutat a referencia, futási időben változtatható.
Az IS-A és a HAS-A kapcsolat
Az öröklődést IS-A kapcsolatnak hívjuk. Ha a Kutya osztály a Gerinces osztály gyermeke, akkor azt mondjuk, hogy „a kutya egy gerinces”, azaz angolul „the dog ’is a’ vertebrate”. Innen jön az IS-A elnevezés.
IS-A kapcsolatnak nevezzük azt is, amikor egy osztály megvalósít egy interfészt, hiszen ekkor az osztály példányai megkapják az interfész típusát is.
Az objektum-összetételt HAS-A kapcsolatnak hívjuk. Ha a Kutya osztályban van egy gerinc nevű mező, ami Gerinces osztály típusú, akkor azt mondjuk, hogy „a kutyának van egy gerince”, azaz angolul „the dog ’has a’ backbone”. Innen jön a HAS-A elnevezés.
A következő példában a Kutya és a Gerinces osztály közt IS-A kapcsolat, a Kutya2 és a Gerinces osztály közt pedig HAS-A kapcsolat van.
class Gerinces {
	public void LábVezérlés() {
    	  Console.WriteLine("mozog a lába.");
	}
}
class Kutya : Gerinces {
	public void Fut() {
    	  Console.Write("Gyorsan ");
    	  LábVezérlés();
	}
}
class Kutya2 {
	Gerinces gerinc;
	public Kutya2(Gerinces gerinc) { this.gerinc = gerinc; }
	public void Fut() {
    	  Console.Write("Gyorsan ");
    	  gerinc.LábVezérlés();
	}
}
class Program {
	static void Main(string[] args) {
    	  Kutya bodri = new Kutya();
    	  bodri.Fut();
    	  Kutya2 rex = new Kutya2(new Gerinces());
    	  rex.Fut();
    	  Console.ReadLine();
	}
}


Az osztályok UML ábrája:

PlantUML szkriptje:
@startuml
class Gerinces{
+void LábVezérlés(){Console.WriteLine("mozog a lába");}
}
class Kutya{
+void Fut(){Console.Write("Gyorsan "); LábVezérlés();}
}
class Kutya2{
-Gerinces gerinc;
+Kutya2(Gerinces gerinc){ this.gerinc = gerinc; }
+void Fut(){ Console.Write("Gyorsan "); gerinc.Lábvezérlés(); }
}
Gerinces <|-- Kutya
Gerinces <-o Kutya2: -gerinc
@enduml

Figyeljük meg, hogy mindkét megoldás esetén a Fut metódus ugyanúgy működik. Ez a példa is mutatja, hogy az öröklődés kiváltható objektum-összetétellel, azaz az IS-A kapcsolat kiváltható HAS-A kapcsolattal.
Átlátszó és átlátszatlan újrahasznosítás
Az öröklődést néha átlátszó újrahasznosításnak (angolul: white box reuse) is hívjuk. Ezzel arra utalunk, hogy az örökölt metódusokat használhatjuk és azokról sok információnk van, gyakran ismerjük a forráskódjukat is.
Az objektum-összetételt átlátszatlan újrahasznosításnak (angolul: black box reuse) is hívjuk. Ezzel arra utalunk, hogy az összetételt megvalósító mezőn keresztül hívhatunk metódusokat, de azok megvalósításáról általában nincs információnk.
Aggregáció és kompozíció
Az objektum-összetételt, vagy más néven a HAS-A kapcsolatot több szempontból is lehet osztályozni. Az első szempont a birtoklás módja, a második a becsomagolás (angolul: wrapping) módja.
Az első szempont azt helyezi a középpontba, hogy az objektum-összetétel mindig birtoklást fejez ki. Pl. a kutyának van farka. A második szempont pedig azt hangsúlyozza ki, hogy az objektum-összetételnél a birtokolt objektumot a birtokló becsomagolja. Pl. a tűzfal becsomagol egy szervert, amely csak rajta keresztül érhető el.
A birtoklás módja szerint az objektum-összetétel lehet aggregáció és a kompozíció:
Aggregáció (angolul: aggregation): A birtokolt példány nem csak az enyém, azt más is használhatja. Például a kutyának van gazdija, de a gazdi nem csak a kutyáé. Ennek a példának megfelelő kódrészlet:
   class Ember { }
   class Kutya
   {
  	Ember gazdi; // HAS-A kapcsolat, amit a gazdi nevű mező valósít meg
  	public Kutya(Ember gazdi) { this.gazdi = gazdi; }
   }
   class Program
   {
  	public static void Main()
	{
    	 Ember gabi = new Ember();
    	 Kutya buksi = new Kutya(gabi); // gabi nem csak buksi gazdija
     	 Kutya cézár = new Kutya(gabi); // nem kizárólagos tulajdonlás
  	}
   }


Az osztályok UML ábrája:

PlantUML szkriptje:

@startuml
class Ember{}
class Kutya{
-Ember gazdi
+Kutya(Ember gazdi) {this.gazdi = gazdi;}
}
Ember <-left-o Kutya:-gazdi
@enduml

Kompozíció (angolul: composition): A birtokolt példány csak az enyém, azt más nem is ismerheti. Például a kutyának van farka, azt csak ő csóválhatja. Ennek a példának megfelelő kódrészlet:
class KutyaFarok { public void Csóvál() { } }
   class Kutya
   {
  	KutyaFarok farok; // HAS-A kapcsolat, amit a farok nevű mező valósít meg
  	public Kutya() { farok = new KutyaFarok(); } // kizárólagos tulajdonlás
  	public void Csóvál() { farok.Csóvál(); }
   }


Az osztályok UML ábrája:

PlantUML szkriptje:
@startuml
class KutyaFarok {
+void Csóvál(){}
}
class Kutya{
-KutyaFarok farok;
+Kutya(){ farok = newKutyaFarok(); }
+void Csóvál(){ farok.Csóvál(); }
}
KutyaFarok <-left-* Kutya: -farok
@enduml

Vizsgáljuk meg az aggregációt és a kompozíciót. Vegyük a következő esetet: „A gitárosnak van egy gitárja.” Ugyebár ez egy objektum-összetétel, hiszen HAS-A kapcsolat van a gitáros és a gitár között. Hogy melyik fajta összetételt kell választani, azt egy egyszerű kérdéssel lehet eldönteni: Ha a gitáros meghal, vele temetik a gitárját is? Ha igen, akkor kompozícióról beszélünk, ha nem, aggregációról. Azaz, ha senki másnak nincs rá referenciája, és ezért a szemétgyűjtő felszabadítja, akkor kompozíció. Aggregációra szép példa többek közt a stratégia tervezési minta. Kompozícióra szép példa az állapot tervezési minta.
Átlátszó és átlátszatlan becsomagolás
Az objektum-összetétel soha nem öncélú, hanem van rá valamilyen jó okunk. Ez az ok nagyon gyakran az, hogy a saját metódusaink, más néven szolgáltatásaink, megírásához szükségünk van olyan metódusok hívására, amit a birtokolt objektumból lehet hívni. Más szóhasználattal azt mondjuk: A saját szolgáltatásainkhoz szükségünk van a birtokolt objektum szolgáltatásaira. Ha azért birtoklunk egy objektumot, hogy a saját szolgáltatásaink felelősségét részben vagy egészben átadjuk neki (idegen szóval delegáljuk), akkor birtoklás mellett becsomagolásról is beszélünk.
A becsomagolás módja szerint a becsomagolás lehet átlátszó vagy átlátszatlan:
Átlátszó becsomagolás: A becsomagolt példány ugyanolyan felületű, mint a becsomagoló, azaz a becsomagolt objektum szolgáltatásai elérhetők a becsomagolón keresztül. Amikor hívjuk az A metódust, akkor az meghívja a becsomagolt objektum A metódusát. Más szóval, az A metódus átadja (idegen szóval delegálja) a felelősséget a becsomagolt objektum A metódusának. Ezt szemlélteti a lenti példa. A megvalósításához kell egy IS-A és egy HAS-A kapcsolat is. A HAS-A kapcsolat lehet aggregáció és kompozíció is. Például a karácsonyfa karácsonyfa marad, akárhány díszt is teszünk rá. Ezt úgy érjük el, hogy a dísszel becsomagoljuk a karácsonyfát, úgy hogy az objektum majd minden, díszítéstől nem függő, metódusa egyszerűen meghívja a becsomagolt karácsonyfa ugyanolyan nevű metódusát. Azért van értelme, hogy a díszítés után a karácsonyfa karácsonyfa maradjon, mert így további díszeket lehet rátenni, lásd a díszítő tervezési mintát.
Példa kódrészlet, ami követi a fenti magyarázatot:
   class GömbDísz : KarácsonyFa // IS-A kapcsolat a KarácsonyFa osztállyal
   {
      KarácsonyFa kf; // HAS-A kapcsolat a KarácsonyFa osztállyal
      public GömbDísz(KarácsonyFa kf) { this.kf = kf; }
      public override string GetTípus()
      {
     	return kf.GetTípus(); // felelősség átadás
      }
      public void A() { kf.A(); } // felelősség átadás általánosítva
      public override string ToString()
      {
     	return "Díszes " + kf.ToString(); // részleges felelősség átadás
      }
   }

A GömbDísz UML ábrája:

PlantUML szkriptje:
@startuml
class KarácsonyFa{}
class GömbDísz{
-KarácsonyFa kf
+GömbDísz(KraácsonyFa kf){ this.kf = kf; }
+override string GetTípus(){ return kf.GetTípus();
+void A(){ kf.A(); }
+override string ToString(){ return "Díszes" + kf.ToString();}
}
KarácsonyFa <--o GömbDísz: -kf
KarácsonyFa <|-- GömbDísz
@enduml

Átlátszatlan becsomagolás: A becsomagolt példány nem ugyanolyan felületű, mint a becsomagoló, így a becsomagolt objektum szolgáltatásai rejtve maradnak, kívülről nem érhetők el. Ugyanakkor az elérhető szolgáltatások elvégzéséhez felhasználhatók a becsomagolt objektum szolgáltatásai. Ilyenkor nem elvárás, hogy ugyanaz legyen a metódus neve, mint aminek delegáljuk a felelősséget. Azaz A metódusból nem biztos, hogy A metódust kell hogy hívjuk, hanem akár hívhatjuk a B metódust, vagy a C metódust, attól függően, hogy melyik valósítja meg azt a működést, amire szükségünk van. A megvalósításához csak egy HAS-A kapcsolat kell. A HAS-A kapcsolat lehet aggregáció és kompozíció is. A fenti példa itt is használható, de ebben az esetben, a becsomagolt karácsonyfa nem marad karácsonyfa, azaz nincs IS-A kapcsolat, és ezért nem lehet újabb díszeket rátenni. Példa kódrészlet, ami követi a fenti magyarázatot:
   class GömbDísz // nincs IS-A kapcsolat a KarácsonyFa osztállyal
   {
  	KarácsonyFa kf; // csak HAS-A kapcsolat van
  	public GömbDísz(KarácsonyFa kf) { this.kf = kf; }
  	public string GetTípus() { return kf.GetTípus(); } // felelősség átadás
  	public void A() { kf.A(); } // felelősség átadás általánosítva
  	public override string ToString()
  	{
     	  return "Díszes " + kf.ToString();// részleges felelősség átadás
  	}
   }


GömbDísz UML ábrája:

PlantUML szkriptje:

@startuml
class KarácsonyFa{}
class GömbDísz{
-KarácsonyFa kf;
+GömbDísz(KarácsonyFa kf) { this.kf = kf; }
+void A() { kf.B(); }
+override string ToString(){ return "Díszes"+kf.ToString();}
}
KarácsonyFa <-o GömbDísz: -kf
@enduml

Vizsgáljuk meg az átlátszó és az átlátszatlan becsomagolást is. Az átlátszó becsomagolás általában aggregáció, de lehet kompozíció is. Ilyenkor a becsomagolt osztállyal gyermek (IS-A) és összetétel (HAS-A) viszonyban is állunk: „Az ős gyermeke vagyok, hogy ős típusként használható legyek. Illetve becsomagolom az ősöm egy példányát, hogy azon keresztül használhassam a szolgáltatásait.” Erre szép példa a dekorátor tervezési minta. Átlátszatlan becsomagolás esetén: „Szintén használom a becsomagolt objektum szolgáltatásait, de azokat nem publikálom külvilág felé.” Erre szép példa az illesztő tervezési minta.
Rész – egész viszony
A kompozíció megfogalmazható úgy is, hogy a rész nem létezhet az egész nélkül. A kutya farka csak a kutyával együtt létezhet, ha nincs kutya, akkor nincs farka sem. Ezzel szemben aggregáció esetén a rész létezhet az egész nélkül is. Az autóból kiszedhető az ülés, az ülésen lehet ülni anélkül is, hogy az egy autó része lenne.
Fordítva is érdemes megvizsgálni a kérdést. Az egész létezhet-e a részei nélkül. Objektum-összetétel esetén az egész nem létezhet a részei nélkül, ugyanakkor a részei lecserélhetők menet közben a program futása alatt. Ez adja az objektum-összetétel rugalmasságát.
A következő példa azt mutatja, hogy egy autó objektum sima ülés részét lecseréljük sportülésre:
abstract class Ülés { /*...*/ }
class SimaÜlés : Ülés { /*...*/ }
class SportÜlés : Ülés { /*...*/ }
class Autó
{
   Ülés ülés;
   public Auto(Ülés ülés) { this.ülés = ülés; }
   public void SetÜlés(Ülés ülés) { this.ülés = ülés; }
}
   class Program
   {
  	public static void Main()
	{
    	 Autó autó1 = new Autó(new SimaÜlés()); // az autóban sima ülés van
     	 autó1.SetÜlés(new SportÜlés()); // az ülést lecseréljük sport ülésre
  	}
   }

Az osztályok UML ábrája:

PlantUML szkriptje:
@startuml
abstract class Ülés{}
class SimaÜlés{}
class SportÜlés{}
class Autó{
-Ülés ülés;
+Auto(Ülés ülés) { this.ülés = ülés; }
+void SetÜlés(Ülés ülés) { this.ülés = ülés; }
}
Ülés <|-- SimaÜlés
Ülés <|-- SportÜlés
Ülés <-o Autó: -ülés
@enduml

Összegző példa objektum-összetételre
Nézzünk egy szép példát objektum-összetételre.
class Alváz { /*...*/ }
class Kaszni { /*...*/ }
class Motor { /*...*/ }
class Autó
{
	Alváz alváz;
	Kaszni kaszni;
	Motor motor;
	public Auto(Alváz alváz, Kaszni kaszni, Motor motor)
	{
    	this.alváz = alváz;
    	this.kaszni = kaszni;
    	this.motor = motor;
	}
}

Az osztályok UML ábrája:

PlantUML szkriptje:
@startuml
class Alváz{}
class Kaszni{}
class Motor{}
class Autó{
-Alváz alváz
-Kaszni kaszni
-Motor motor
+Autó(Alváz alváz, Kaszni kaszni, Motor motor)
}
Alváz <-up-o Autó: -alváz
Kaszni <-left-o Autó: -kaszni
Motor <-right-o Autó: -motor
@enduml

A fenti példában hármas objektum-összetételt látunk. Az autó 3 fő alkatrészből áll, ezek aggregációja adja az autót. Az is látszik a fenti példából, hogy ez egy átlátszatlan becsomagolás, hiszen az Autó és a többi három osztály között csak HAS-A kapcsolat van, IS-A kapcsolat nincs.
Az objektum-összetétel és a csatoltság
Csatoltság szempontjából az öröklődés a legerősebb, majd jön a kompozíció és az aggregáció. Éppen ez az oka, hogy a GOF2 kimondja, hogy használjunk inkább objektum-összetételt öröklődés helyett, hiszen az kisebb csatoltságot eredményez és így rugalmasabb kódot kapunk. Ugyanakkor ki kell emelni, hogy az ilyen kód nehezebben átlátható, ezért nem szabad túlzásba vinni az objektum-összetételt.
Ha egy osztálynak van olyan mezője, amely lehet null értékű, akkor az a mező általában nem objektum-összetételt valósít meg, hanem az objektum-összetételtől lazább kapcsolatot, a barátságot (angolul: dependency). A barátság egy átmeneti kapcsolat, gyakran nem is kell hozzá mező, elegendő annyi, hogy az objektum egy metódusában kap egy referenciát egy másik metódusra, kér tőle valamit és el is felejti.
GOF2 a gyakorlatban
Egy másik ok, ami miatt nem váltunk ki minden öröklődést objektum-összetétellel, az az, hogy öröklődés nélkül nincs többalakúság (legalábbis erősen típusos nyelvek esetén). Jól tudjuk, hogy egy osztályhierarchia tetején lévő osztály példánya helyett bármelyik gyermekosztály példányát használhatjuk. Erre gyakran van szükségünk, hiszen így tudunk a változásokhoz könnyen alkalmazkodni. Például van egy gyermekosztályunk, ami Windows speciális, egy másik Unix speciális, az egyik környezetben az egyiket, a másikban a másikat használjuk.
Összegzés és ellenőrző kérdések
Ebben a leckében áttekintettük a GOF könyv két alapelvét és gyakorlati alkalmazásukat. Először is, megvizsgáltuk a „Programozz felületre implementáció helyett” alapelvet (GOF1), amely arra ösztönzi a tervezőket, hogy az interfészre programozzanak, ne pedig az implementációra. A következő alapelv, a „Használj objektum-összetételt öröklés helyett, ha csak lehet” (GOF2) arra ösztönzi a tervezőket, hogy inkább objektum-összetételt alkalmazzanak az öröklés helyett. Az öröklés előnyeit és korlátait összehasonlítva láthattuk, hogy az objektum-összetétel rugalmasabb és jobban támogatja a tervezési változásokat. A továbbiakban megvizsgáltuk az IS-A és HAS-A kapcsolatot. Az IS-A kapcsolat az öröklődést jelenti, míg a HAS-A kapcsolat az objektum-összetételt. Ezután részletesen foglalkoztunk az aggregációval és a kompozícióval, két különböző objektum-összetétel típussal. Aggregáció esetén a rész létezhet az egész nélkül is. Kompozíció esetén a rész nem létezhet az egész nélkül. Végül, megvizsgáltuk az átlátszó és átlátszatlan becsomagolást, amik szintén az objektum-összetétel típusai.
Ellenőrző kérdések:
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
Lecke 8.: SOLID tervezési alapelvek
A lecke célja és tartalma
Célok, megszerezhető kompetenciák: A lecke végére megismerkedünk a SOLID tervezési alapelvekkel.
Szükséges eszközök, források: Robert C. Martin Tiszta kód című könyve. Robert C. Martin PPP könyve.
Feldolgozási idő: 90 perc.
Témakörök: A SOLID alapelvek, úgy mint: SRP, OCP, LSP, ISP, DIP.
A lecke tartalma: Ebben a leckében áttekintjük a szakirodalomban leginkább elfogadott 5 objektum orientált tervezési alapelvet, amit összefoglaló néven SOLID alapelveknek szoktunk nevezni. Robert C. Martin, akit sokan csak Bob bácsinak (angolul: Uncle Bob) hívnak, szerint a legfontosabb alapelv a SOLID elvek közül az első, az SRP, azaz az Egy felelősség elve. Ez az elv kimondja, hogy minden modulnak, osztálynak csak egy felelősségi köre legyen, de azt fedje le teljesen. A jegyzet szerzői szerint a legfontosabb alapelv, a SOLID elvek közül a második, az OCP, azaz a Nyitva-zárt alapelv. Ez az elv kimondja, hogy az osztályok, illetve az osztály hierarchiák legyenek nyitottak a bővítésre, de zártak a módosításra. Ez az elv azért nagyon fontos, mert szintaxis szintjén is megfogalmazható: Ne használjunk override kulcsszót csak absztrakt, illetve horog (angolul: hook) metódusok felülírására, illetve ne használjunk if-else if szerkezeteket. Az SRP-t nem lehet ilyen alacsony szinten megfogalmazni. A többi SOLID alapelvet is bemutatjuk egy-egy példán keresztül.
Bevezetés
A SOLID tervezési alapelvek fogalom a legfontosabb, a szakirodalomban leginkább elismert, 5 objektumorientált tervezési alapelvet jelöli. Ezek a következők:
SRP (Single Responsibility Principle) – Egy felelősség - egy osztály alapelve
OCP (Open-Closed Principle) – Nyitva-zárt alapelv
LSP (Liskov Substitution Principle) – Liskov-féle behelyettesítési alapelv
ISP (Interface Segregation Principle) – Interfészszegregációs-alapelv
DIP (Dependency Inversion Principle) – Függőség megfordításának alapelve
Az első betűket összeolvasva kapjuk: SOLID. Lássuk ezeket bevezető szinten.
SRP (Single Responsibility Principle) – Egy felelősség - egy osztály alapelve 
Az Egy felelősség - egy osztály alapelve (angolul: Single Responsibility Principle – SRP) azt mondja ki, hogy minden osztálynak egyetlen felelősséget kell lefednie, de azt teljes egészében. Eredeti angol megfogalmazása: „A class should have only one reason to change”, azaz „Az osztályoknak csak egy oka legyen a változásra”.
Már a GOF1 elvnél is láttuk, hogy ha egy osztály nem fedi le teljesen a saját felelősségi körét, akkor muszáj implementációra programozni, hogy egy másik osztály megvalósítsa azokat a szolgáltatásokat, amik kimaradtak az osztályból.
Ha egy osztály több felelősségi kört is ellát, például a MacsKuty eszik, alszik, ugat, egerészik, akkor sokkal jobban ki van téve a változásoknak, mintha csak egy felelősséget látna el. A MacsKuty osztályt meg kell változtatni, ha kiderül, hogy a kutyák nem csak a postást ugatják meg, hanem a bicikliseket is, illetve akkor is, ha a macskák viselkedése változik vagy bővül.
Már láttuk, hogy minden módosítás magában hordozza a veszélyt, hogy egy forráskódszörnyet kapjunk, amihez már senki se mer hozzányúlni. Az ilyen kód fejlesztése nagyon drága.
Gyakran szembesülünk azzal, hogy mi szeretnénk, hogy minden osztálynak csak egy oka legyen a változásra, azaz egy felelősségi kört lásson el, de minden osztálynak kell naplóznia vagy a jogosultságokat ellenőriznie. Erre ad megoldást az aspektusorientált programozás. Ezeket a felelősségeket, mint például a naplózás, kiemeljük egy úgynevezett aspektusba, amit bármely osztályhoz hozzákapcsolhatunk.
Robert C. Martin Tiszta kód című könyve szerint a legfontosabb SOLID alapelv az SRP.
Az egy felelősség - egy osztály elvére szép példa a felelősséglánc tervezési minta.
OCP (Open-Closed Principle) – Nyitva-zárt alapelv
Az Open-Closed Principle (OCP), magyarul a nyitva-zárt elv, kimondja, hogy a program forráskódja legyen nyitott a bővítésre, de zárt a módosításra. Eredeti angol megfogalmazása: „Classes should be open for extension, but closed for modification”.
Egy kicsit szűkebb értelmezésben, az osztályhierarchiánk legyen nyitott a bővítésre, de zárt a módosításra. Ez azt jelenti, hogy új alosztályt vagy egy új metódust nyugodtan felvehetünk, de meglévőt nem írhatunk felül. Ennek azért van értelme, mert ha már van egy működő, letesztelt, kiforrott metódusunk és azt megváltoztatjuk, akkor több negatív dolog is történhet:
a változás miatt az eddig működő ágak hibásak lesznek,
a változás miatt a vele implementációs függőségben lévő kódrészeket is változtatni kell,
a változás általában azt jelenti, hogy olyan esetet kezelünk le, amit eddig nem, azaz bejön egy új if vagy else, esetleg egy switch, ami csökkenti a kód átláthatóságát, és egy idő után már senki se mer hozzányúlni.
Az OCP elvet meg lehet fogalmazni a szintaxis szintjén is C# nyelv esetén: Ne használd az override kulcsszót, kivéve ha
absztrakt vagy
horog (angolul: hook)
metódust akarsz felülírni.
Ugyebár az absztrakt metódusokat muszáj felülírni, de ez nem az OCP megszegése, hiszen az absztrakt metódusnak nincs törzse, így lényegében a törzzsel bővítjük a kódot, nem módosítunk semmit. A másik eset, amikor horog (angolul: hook) metódust írunk felül. Akkor beszélek horog metódusokról, ha a metódusnak van ugyan törzse, de az teljesen üres. Ezek felülírása nem kötelező, csak opcionális, így arra használják őket, hogy a gyermekosztályok opcionálisan bővíthessék megvalósításukat. Ezek felülírásával lényegében megint csak bővítjük a kódot, nem módosítjuk, azaz nem szegjük meg az OCP elvet.
A horog metódus törzse üres, vagy csak egy return utasítás van benne egy alapértelmezett értékkel. Ez utóbbira példa C# nyelven a ToString vagy Java nyelven a toString metódus. Tehát ha a ToString metódust írjuk felül, azzal még nem szegjük meg az OCP elvet.
A következő rövid példában nem tarjuk be az OCP elvet:
class Alakzat
{
	public const int TEGLALAP = 1;
	public const int KOR = 2;
	int tipus;
	public Alakzat(int tipus) { this.tipus = tipus; }
	public int GetTipus() { return tipus; }
}
class Teglalap : Alakzat{Teglalap():base(Alakzat.TEGLALAP){}}
class Kor : Alakzat{ Kor():base(Alakzat.KOR){} }
class GrafikusSzerkeszto
{
	public void RajzolAlakzat(Alakzat a)
	{
    	  if (a.GetTipus() == Alakzat.TEGLALAP)RajzolTeglalap(a);
    	  else if (a.GetTipus() == Alakzat.KOR) RajzolKor(a);
	}
	public void RajzolKor(Kor k) { /* ... */ }
	public void RajzolTeglalap(Teglalap t) { /* ... */ }
}

Ha egy kódban if – else if szerkezetet látunk, akkor az valószínűleg azt mutatja, hogy nem tartottuk be az OCP elvet. Nem tartottuk be, hiszen, ha új alakzatot akarunk hozzáadni a kódhoz, akkor az if – else if szerkezetet tovább kell bővítenünk. Lássuk, hogy lehet ezt kivédeni:
abstract class Alakzat{ public abstract void Rajzol(); }
class Teglalap : Alakzat
{
	public override void Rajzol() { /* téglalapot rajzol */ }
}
class Kor : Alakzat
{
	public override void Rajzol() { /*kört rajzol */ }
}
class GrafikusSzerkeszto
{
	public void RajzolAlakzat(Alakzat a) { a.Rajzol(); }
}

A fenti példában bevezettünk egy közös őst, az absztrakt Alakzatot. A konkrét alakzatok csak felülírják az ős absztrakt Rajzol metódusát és kész is az új gyermek. Ebből akárhányat hozzáadhatunk, a meglévő kódot nem kell változtatni. Tehát itt betartjuk az OCP elvet.
A közös absztrakt ős másik előnye az, hogy ha a kódban a gyermekosztály példányait csak az közös ős felületén keresztül használjuk, akkor ezzel betartjuk a GOF1 ajánlást is.
Az OCP elv alkalmazására nagyon szép példa a stratégia és a sablonmetódus tervezési minta. Az utóbbi horog (angolul: hook) metódusokra is ad példát.
LSP (Liskov Substitution Principle) – Liskov-féle behelyettesítési alapelv
A Liskov-féle behelyettesítési elv (angolul: Liskov Substitution Principle), rövid nevén LSP, kimondja, hogy a program viselkedése nem változhat meg attól, hogy az ős osztály egy példánya helyett a jövőben valamelyik gyermekosztályának példányát használjuk. Azaz a program által visszaadott érték nem függ attól, hogy egy Kutya vagy egy Vizsla vagy egy Komondor példány lábainak számát adjuk vissza. Eredeti angol megfogalmazása: „If for each object o1 of type S there is an object o2 of type T such that for all programs P defined in terms of T, the behavior of P is unchanged when o1 is substituted for o2 then S is a subtype of T”.
Nézzünk egy példát, amely nem felel meg az LSP elvnek. A klasszikus ellenpélda az ellipszis – kör illetve a téglalap – négyzet példa. A kör olyan speciális ellipszis, ahol a két sugár egyenlő. A négyzet olyan speciális téglalap, ahol az oldalak egyenlő hosszúak. Szinte adja magát, hogy a kör az ellipszis alosztálya, illetve a négyzet a téglalap alosztálya legyen. Lássuk a téglalap – négyzet példát:
class Téglalap
{
	protected int a, b;
	//@ utófeltétel: a == x és b == \régi(b)
	public virtual void SetA(int x) { a = x; }
	public virtual void SetB(int x) { b = x; }
	public int Terület() { return a * b; }
}
class Négyzet : Téglalap
{
	// invariáns: a == b;
	// utófeltétel: a == x && b == x;
	public override void SetA(int x) { a = x; b = x; }
	public override void SetB(int x) { a = x; b = x; }
}

A fenti példában az a és b mezőt használjuk a téglalap oldalhosszainak tárolására. Mindkét mezőhöz tartozik egy szetter metódus. A Négyzet osztályban a két szetter metódust felül kellett írni, mert a négyzet két oldala egyenlő. Azt mondjuk, hogy ez a Négyzet osztály invariánsa, mert minden metódushívás előtt és után igaznak kell lennie, hogy a két oldal egyenlő. A SetA metódusnak megadtuk az utófeltételét is. A gond az, hogy a Négyzet osztályban a SetA utófeltétele gyengébb, mint a Téglalap osztályban. Pedig, mint látni fogjuk, a gyermekosztályban az utófeltételeknek erősebbeknek, az előfeltételeknek gyengébbeknek kellene lennie, hogy betartsuk az LSP elvet.
class Program
{
	public static void Main(string[] args)
	{
    	  Random rnd = new Random();
    	  for (int i = 0; i < 10; i++)
    	  {
        	Téglalap rect;
        	if (rnd.Next(2) == 0) rect = new Téglalap();
        	else                  rect = new Négyzet();
        	rect.SetA(10);
        	rect.SetB(5);
        	Console.WriteLine(rect.Terület());
    	  }
    	  Console.ReadLine();
	}
}

A fenti főprogram 50%-os valószínűséggel a Téglalap osztályt, 50%-os valószínűséggel ennek gyermekosztályát a Négyzetet példányosítja. Ha az LSP igaz lenne, akkor mindegy lenne, melyik osztály példányán keresztül hívjuk a Terület metódust, de ez nem igaz, mert a SetA és a SetB teljesen másképp viselkedik a két osztályban. Ennek megfelelően egyszer 50, egyszer 25 lesz a kiírt érték. Azaz a program viselkedése függ attól, melyik példányt használjuk, azaz az LSP elvet megszegtük.
Mi is volt a tényleges probléma a fenti példában? A probléma az, hogy a Négyzet alosztálya a Téglalapnak, de nem altípusa.

Szerződésalapú programozás – Design by Contract
Az előzőekben használtuk az altípus fogalmát az LSP megfogalmazásához, de nem definiáltuk, mi is az altípus. Ezt pótolja ez a rész. Az altípus fogalmának megadásához be kell vezetnünk a szerződésalapú programozás (angolul: Design by Contract) fogalmait:
előfeltétel, amely a bemenetre és a mezőkre ad megkötést,
utófeltétel, amely a kimentre és a mezőkre ad megkötést,
invariáns, amely csak a mezőkre ad megkötést.
Megjegyezzük, hogy a szerződésalapú programozás magyar nyelvű irodalmában használatos a szerződésalapú tervezés is.
A metódus előfeltétele írja le, hogy milyen bementre működik helyesen a metódus. Az előfeltétel általában a metódus paraméterei és az osztály mezői segítségével írja le ezt a feltételt. Például az Osztás(int osztandó, int osztó) metódus előfeltétele, hogy az osztó ne legyen nulla.
A metódus utófeltétele írja le, hogy milyen feltételnek felel meg a visszaadott érték, illetve milyen állapotátmenet történt, azaz az osztály mezői hogyan változnak a metódushívás hatására. Például a Maximum(int X, int Y) utófeltétele, hogy a visszatérési érték X, ha X>Y, egyébként Y.
A metódus szerződése az, hogy ha a hívó úgy hívja meg a metódust, hogy igaz az előfeltétele, akkor igaz lesz az utófeltétele is a metódus lefutása után. Az előfeltétel és az utófeltétel így két állapot közti átmenetet ír le, a metódus futása előtti és utáni állapotét. Az elő- és utófeltétel párok megadása helyett adhatunk egy úgynevezett állapotátmeneti megszorítást (ez ugyanazt a feladatot látja el, mint a Turing-gépek delta függvénye, csak predikátumként megadva), ami leírja az összes lehetséges állapotátmenetet. E helyett a szakirodalom ajánlja még a történeti megszorítás (angolul: history constraint) használatát, de erre nem térünk ki részletesen.
Ezen túl még beszélünk osztályinvariánsról is. Az osztályinvariáns az osztály lehetséges állapotait írja le, azaz az osztály mezőire ad feltételt. Az invariánsnak minden metódushívás előtt és után igaznak kell lennie.
Tegyük fel, hogy az N(égyzet) osztály gyermeke a T(églalap) osztálynak. Azt mondjuk, hogy az N egyben altípusa is a T osztálynak akkor és csak akkor, ha
a T mezői felett az N invariánsából következik a T invariánsa,
T minden metódusára igaz, hogy
a metódus T-ben megadott előfeltételéből következik az N megadott előfeltétele,
a metódus N-ben megadott utófeltételéből következik a T megadott utófeltétele,
a metódus N-ben csak olyan kivételeket válthat ki, amelyek megegyeznek vagy gyermekei a T megadott kivételeknek. Megjegyzés: Ezt a Java esetén a fordító helyettünk ellenőrzi, de C# esetén a kiváltott kivételek nem részei a metódus fejének, így a fordító nem tudja ezt helyettünk ellenőrizni.
a T mezői felett az N állapot átmeneti megszorításából következik a T állapot átmeneti megszorítása.
Az utolsó feltételre azért van szükség, mert a gyermekosztályban lehetnek új metódusok is, és ezeknek is be kell tartaniuk az ős állapot átmeneti megszorítását. Ha az ősben „egyes” állapotból nem lehet közvetlenül elérni a „hármas” állapotot, akkor ezt a gyermekben sem szabad.
A Téglalap – Négyzet példában az invariánsra vonatkozó feltétel igaz, hiszen a Téglalap invariánsa IGAZ, a Négyzeté pedig a == b, és könnyen belátható, hogy a == b formulából következik az IGAZ. Az előfeltételekre vonatkozó feltétel is igaz. Az utófeltételek feltétele viszont hamis, mert a SetA metódus esetén az a == x ÉS b == x ==> a == x ÉS b == \régi(b) állítás nem igaz. Ezért a Négyzet nem altípusa a Téglalapnak.
Az altípus definícióját informálisan gyakran így adjuk meg:
az ős mezői felett az altípus invariánsa nem gyengébb, mint az ősé,
az altípusban az előfeltételek nem erősebbek, mint az ősben,
az altípusban az utófeltételek nem gyengébbek, mint az ősben,
az altípus betartja ősének történeti megszorítást (angolul: history constraint).
Erősebb feltételt úgy kapok, ha az eredeti feltételhez ÉS-sel veszek hozzá egy plusz feltételt. Gyengébb feltételt úgy kapok, ha az eredeti feltételhez VAGY-gyal veszek hozzá egy plusz feltételt. Egy kicsit könnyebb ezt megérteni, ha halmazokkal fogalmazzuk meg. Mivel a gyengébb feltétel nagyobb halmazt, az erősebb feltétel pedig kisebb halmazt jelent, a fenti definíció így is megadható:
az ős mezői felett a belső állapotok halmaza kisebb vagy egyenlő az altípusban, mint az ősben,
minden metódus értelmezési tartománya nagyobb vagy egyenlő az altípusban, mint az ősben,
minden metódusra a metódus hívása előtti lehetséges belső állapotok halmaza nagyobb vagy egyenlő az altípusban, mint az ősben,
minden metódus értékkészlete kisebb vagy egyenlő az altípusban, mint az ősben,
minden metódusra a metódus hívása utáni lehetséges belső állapotok halmaza kisebb vagy egyenlő az altípusban, mint az ősben,
az ős mezői felett a lehetséges állapotátmenetek halmaza kisebb vagy egyenlő az altípusban, mint az ősben.
Ha a Téglalap – Négyzet példában betartottuk volna az OCP elvet, akkor az LSP elvet se sértettük volna meg. Hogy lehet betartani az OCP elvet ebben a példában? Úgy, hogy egyáltalán nem készítünk SetA és SetB metódust, mert akkor azokat mindenképpen felül kellene írni. Csak konstruktort készítünk és a területmetódust. Az OCP és az LSP általában egymást erősítik.


ISP (Interface Segregation Principle) – Interfészszegregációs-alapelv
Az interfészszegregációs-alapelv (angolul: Interface Segregation Principle – ISP) azt mondja ki, hogy egy sok szolgáltatást nyújtó osztály fölé el kell helyezni interfészeket, hogy minden kliens, amely használja az osztály szolgáltatásait, csak azokat a metódusokat lássa, amelyeket ténylegesen használ. Eredeti angol megfogalmazása: „No client should be forced to depend on methods it does not use”, azaz „Egy kliens se legyen rászorítva, hogy olyan metódusoktól függjön, amiket nem is használ”.
Ez az elv segít a fordítási függőség visszaszorításában. Képzeljük csak el, hogy minden szolgáltatást, például egy fénymásoló esetén a fénymásolást, nyomtatást, faxküldést, a példányok szétválogatását egy nagy Feladat osztály látna el. Ekkor, ha a fénymásolás rész megváltozik, akkor újra kell fordítani a Feladat osztályt és lényegében az egész alkalmazást, mert mindenki innen hívja a szolgáltatásokat. Ez egy néhány 100 ezer soros forráskód esetén bizony már egy kávészünetnyi idő. Nyilván így nem lehet programot fejleszteni.
A megoldás, hogy minden klienshez (kliensnek nevezzük a forráskód azon részét, ami használja a szóban forgó osztály szolgáltatásait) készítünk egy interfészt, amely csak azokat a metódusokat tartalmazza, amelyeket a kliens ténylegesen használ. Tehát lesz egy fénymásoló, egy nyomtató, egy fax és egy szétválogatás interfész. A Feladat ezen interfészek mindegyikét implementálja. Az egyes kliensek a Feladat osztályt a nekik megfelelő interfészen keresztül fogják csak látni, mert ilyen típusú példányként kapják meg. Ezáltal ha megváltozik a Feladat osztály, akkor az alkalmazásnak csak azt a részét kell újrafordítani, amit érint a változás.
Az ilyen monumentális osztályokat, mint a fenti példában a Feladat, kövér osztályoknak nevezzük. Gyakran előfordul, hogy egy sovány kis néhány száz soros osztály elkezd hízni, egyre több felelősséget lát el, és a végén egy kövér, sok ezer soros osztályt kapunk. A kövér osztályokat az egy felelősség - egy osztály elv (SRP) kizárja, de ha már van egy ilyen osztályunk, akkor egyszerűbb fölé tenni néhány interfészt, mint a kövér osztályt szétszedni kisebbekre. Egy egyszerű példa:
interface IWorkable { void Work(); }
interface IFeedable { void Eat(); }
interface IWorker : IFeedable, IWorkable {}
class Worker : IWorker
{
	public void Work() { /* dolgozik */ }
	public void Eat() { /* eszik */ }
}
class Program
{
	public static void Main(String[] args)
	{
    	  IWorkable workable = new Worker();
    	  IFeedable feedable = new Worker();
    	  IWorker worker = new Worker();
	}
}

Ha betartjuk az interfész szegregációs elvet, akkor a forráskód kevésbé csatolt lesz és így egyszerűbben változtatható. Erre az elvre szép példa az illesztő tervezési minta.
DIP (Dependency Inversion Principle) – Függőség megfordításának alapelve
A függőség megfordításának elve (angolul: Dependency Inversion Principle – DIP) azt mondja ki, hogy a magas szintű komponensek ne függjenek alacsony szintű implementációs részleteket kidolgozó osztályoktól, hanem épp fordítva, a magas absztrakciós szinten álló komponensektől függjenek az alacsony absztrakciós szinten álló modulok. Eredeti angol megfogalmazása: „High-level modules should not depend on low-level modules. Both should depend on abstractions.” Azaz: „A magas szintű modulok ne függjenek az alacsony szintű moduloktól. Mindkettő függjön az absztrakciótól.” Ezt ennél frappánsabban így szoktuk mondani: „Absztrakciótól függj, ne függj konkrét osztályoktól”.
Az alacsony szintű komponensek újrafelhasználása jól megoldott az úgynevezett osztálykönyvtárak (angolul: library) segítségével. Ezekbe gyűjtjük össze azokat a metódusokat, amikre gyakran szükségünk van. A magas szintű komponensek, amik a rendszer logikáját írják le, általában nehezen újrafelhasználhatók. Ezen segít a függőség megfordítása. Vegyük a következő egyszerű leíró nyelven íródott kódot:
public void Copy() { while( (char c = Console.ReadKey()) != EOF) Printer.printChar(c); }
Itt a Copy metódus függ a Console.ReadKey és a Printer.printChar metódustól. A Copy metódus fontos logikát ír le, a forrásból a célra kell másolni karaktereket file vége jelig. Ezt a logikát sok helyen fel lehet használni, hiszen a forrás bármi lehet és a cél is, ami karaktereket tud beolvasni, illetve kiírni. Ha most ezt a kódot újra akarjuk hasznosítani, akkor két lehetőségünk van. Az első, hogy if – else – if szerkezet segítségével megállapítjuk, hogy most melyik forrásra, illetve célra van szükségünk. Ez nagyon csúnya, nehezen átlátható, módosítható kódot eredményez. A másik lehetőség, hogy a forrás és a cél referenciáját kívülről adjuk meg a hívó felelősség injektálásával (angolul: dependency injection).
A felelősség injektálásának több típusa is létezik:
Felelősség injektálása konstruktorral: Ebben az esetben az osztály a konstruktorán keresztül kapja meg azokat a referenciákat, amiken keresztül a neki hasznos szolgáltatásokat meg tudja hívni. Ezt más néven objektum-összetételnek is nevezzük és a leggyakrabban épp így programozzuk le. (Javascript keretrendszereknél gyakran alkalmazott módszer, Angular JS)
Felelősség injektálása szetter metódusokkal: Ebben az esetben az osztály szetter metódusokon keresztül kapja meg azokat a referenciákat, amikre szüksége van a működéséhez. Általában ezt csak akkor használjuk, ha opcionális működés megvalósításához kell objektum-összetételt alkalmaznunk. (Java esetén gyakran alkalmazott módszer, JEE7)
Felelősség injektálása interfész megvalósításával. Ha a példányt a magas szintű komponens is elkészítheti, akkor elegendő megadni a példány interfészét, amit általában maga a magas szintű komponens valósít meg, de paraméterosztály paramétereként is jöhet az interfész.
Felelősség injektálása elnevezési konvenció, konfigurációs állomány, vagy annotáció alapján. Ez általában keretrendszerekre jellemző. Ezeket csak tapasztalt programozóknak ajánljuk, mert nyomkövetéssel nem lehet megtalálni, hogy honnan jön a példány és ez nagyon zavaró lehet.
A fenti egyszerű Copy metódus a függőség megfordítás elvének megfelelő változata látható a következő példában. A fenti lehetőségek közül a felelősség beinjektálás konstruktorral megoldást választottuk.
class Source2Sink
{
	private System.IO.Stream source;
	private System.IO.Stream sink;
	public Source2Sink(Stream source, Stream sink)
	{
    	  this.source = source;
    	  this.sink = sink;
	}
	public void Copy()
	{
    	  byte b = source.ReadByte();
    	  while (b != 26)
    	  {
        	sink.WriteByte(b);
        	b = source.ReadByte();}
    	  }
	}
}

Sokan kritizálják a függőség megfordításának elvét, miszerint az csak az objektum-összetétel használatának, azaz a GOF2 elvnek egy következménye. Mások szerint ez egy önálló tervezési minta. Mindenesetre a haszna vitathatatlan, ha rugalmas kód fejlesztésére törekszünk.
Összegzés és ellenőrző kérdések
Ebben a leckében áttekintettük a szakirodalomban leginkább elfogadott 5 objektum orientált tervezési alapelvet, amit összefoglaló néven SOLID alapelveknek szoktunk nevezni. Robert C. Martin, akit sokan csak Bob bácsinak (angolul: Uncle Bob) hívnak, szerint a legfontosabb alapelv a SOLID elvek közül az első, az SRP, azaz az Egy felelősség elve. Ez az elv kimondja, hogy minden modulnak, osztálynak csak egy felelősségi köre legyen, de azt fedje le teljesen. A jegyzet szerzői szerint a legfontosabb alapelv, a SOLID elvek közül a második, az OCP, azaz a Nyitva-zárt alapelv. Ez az elv kimondja, hogy az osztályok, illetve az osztály hierarchiák legyenek nyitottak a bővítésre, de zártak a módosításra. Ez az elv azért nagyon fontos, mert szintaxis szintjén is megfogalmazható: Ne használjunk override kulcsszót csak absztrakt, illetve horog (angolul: hook) metódusok felülírására, illetve ne használjunk if-else if szerkezeteket. Az SRP-t nem lehet ilyen alacsony szinten megfogalmazni. A többi SOLID alapelvet is bemutattuk egy-egy példán keresztül.
Ellenőrző kérdések:
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
További tervezési alapelvek
Itt említjük meg azokat a tervezési alapelveket, amelyek a szakirodalomban kevésbé elfogadottak, ugyanakkor mégis érdemes megismerkedni velük.
Hollywood alapelv – HP (Hollywood Principle)
A Hollywood alapelv eredeti angol megfogalmazása: „Don’t call us, we’ll call you”, azaz „Ne hívj, majd mi hívunk”. A Hollywood alapelvet a következő példával szemléltethetjük: Rómeó szerepére szereplőválogatást hirdetnek. Több száz jelentkező van. A válogatás után mindenki szeretné megtudni, ő kapta-e a hőn áhított szerepet. Két megoldás van:
Mindenki kisebb-nagyobb időközönként érdeklődik, ő kapta-e a szerepet. Ilyenkor a titkár egyre idegesebben válaszol, hogy még nincs döntés, hívjon később. Ez a tevékeny várakozás (angolul: busy waiting).
Következő alkalommal a titkár már jó előre közli minden színésszel, ne hívj, majd mi hívunk. Azaz senki se érdeklődjön, ha majd megvan a döntés, mindenkit értesítünk, hogy megkapta-e a szerepet. Ez a Hollywood elv alkalmazása.
A tevékeny várakozás nagyon káros, mert foglalja a processzoridőt, lassítja a többi szálat. Tipikus megoldása, hogy egy végtelen ciklusban egy sleep hívással várunk, majd hívjuk a metódust, ami megmondja, hogy várni kell-e még. Ha már nem kell várni, akkor egy break utasítással kilépünk a ciklusból.
A tevékeny várakozás megoldásnak van létjogosultsága, de csak nagyon kevés helyzetben. A legismertebb a megfigyelő kutya (angolul: watchdog), amikor egy távoli objektumot kérdezgetünk (ping-elgetünk) megadott időközönként, hogy él-e még. Ezt máshogyan nem tudjuk megoldani, hiszen, ha elmegy az áram, a távoli gép nem tud még egy üzenetet sem küldeni, hogy mostantól elérhetetlen lesz. Ha a figyelő kutya észreveszi, hogy lehalt a távoli objektum, akkor annak feladatát másra osztják.
A Hollywood elv azt mondja ki, hogy ne az kérdezgessük, hogy megtörtént-e egy adott esemény, hanem ez az esemény értesítse a várakozókat. Ezt a megoldást használja például a Java eseménykezelése. Ha lenyomunk egy gombot, akkor keletkezik egy esemény, de ezen túl semmi se történik. Ha azt akarjuk, hogy történjen is valami, akkor fel kell iratkozni az eseményre egy figyelőt (Java nyelvhasználattal listener-t). Ha kiváltódik az esemény, akkor az összes feliratkozott figyelő értesítést kap. Pontosan ezt valósítja meg a Megfigyelő tervezési minta.
A Hollywood elv akkor ad nagy segítséget, ha egy-több kapcsolatban vannak az objektumok és a több oldal dinamikusan változik, azaz fel is lehet iratkozni, meg le is. Egyik alternatívája az üzenetsugárzás (angolul: broadcasting), amikor egy üzenet mindenki máshoz eljut. Ekkor az üzenet küldője nem feltétlenül ismeri az üzenet fogadóját, ami előny lehet. Hátránya, hogy olyan objektum is megkaphatja az üzenetet, akit nem érdekel.
Demeter törvénye / a legkisebb tudás elve
Demeter törvénye, vagy más néven a legkisebb tudás elve (angolul: Law of Demeter / Principle of Least Knowledge) kimondja, hogy egy osztály csak a közvetlen ismerőseit hívhatja. Eredeti angol megfogalmazása: „Talk only to your immediate friends”. Azaz: „Csak a közvetlen ismerőseiddel beszélj”.
Praktikusan úgy is megfogalmazhatjuk ezt az elvet, hogy csak annak a példánynak a metódusát hívhatjuk, akire van referenciánk, azaz az A.getB().C() alakú hívások tilosak. Ez az elv azért hasznos, mert ha betartjuk, akkor a változások mindig csak lokális hatásúak lesznek.

