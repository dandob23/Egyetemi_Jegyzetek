1. fejezet:
Bevezetés
A jegyzet célja, hogy egy nagyon friss kihívásra reagáljon: A legújabb mesterséges intelligencia megoldások már egész jól programoznak!
Eddig az informatikai alapszakokon (programtervező informatikus, mérnökinformatikus, és gazdaságinformatikus) a képzés fő célja az volt, hogy a hallgatók megtanuljanak programozni. Ugyanakkor a nagy nyelvi modelleken (angolul: Large Language Model - LLM) alapuló mesterséges intelligenciák (magyar rövidítése: MI, angolul: artificial intelligence, angol rövidítése: AI) már egész jól programoznak. Az LLM alapú mesterséges intelligenciákat szokás mesterséges általános intelligenciáknak (angolul: Artificial General Intelligence, angol rövidítése: AGI) is hívni, amikkel bármiről lehet beszélgetni, programozásról is. A jegyzet írásának idejekor, azaz 2024 év elején, ezek voltak a legismertebb AGI megoldások:
OpenAI ChatGPT (előfizetés nélkül GPT-3.5, előfizetés esetén GTP-4.0 modellt használja)
Google PaLM és Gemini
ANTHROPI/C Claude 3
Meta LLaMA
Ráadásul már van olyan szűk MI, úgynevezett mesterséges szűk intelligencia (angolul: Artificial Narrow Intelligence, angol rövidítése: ANI), ami kifejezetten a programozók munkáját hivatott segíteni:
Microsoft Copilot
Ez azt jelenti, hogy a mesterséges intelligencia átveheti a junior programozók munkáját. Ha ez tényleg bekövetkezik, akkor az informatika oktatásnak erre reagálni kell. Lássuk a lehetséges reakciókat:
Képezzünk célirányosan kérdező (angolul: prompt engineering) szakembereket! Bízhatunk abban, hogy az MI nem veszi át teljesen a junior programozók munkáját, csak segíti őket, és így az oktatás során nem csak a programozási környezetek használatát, pl. a nyomkövetést kell megtanítani, hanem azt is, hogyan kell az MI-től célirányosan kérdezni, hogy segítsen kijavítani egy hibát, megírni egy metódust.
Képezzünk medior programozókat! Ha junior programozókra már nincs szükség, akkor rögtön medior programozókat kell a programozó képzésben képezni, azaz lehetővé kell tenni, hogy a hallgatók specializálódjanak a piacon ismert irányokba, ezeken a területeken projekt munkában vegyenek részt, ezeken a területeken pár éves munkatapasztalatnak megfelelő tudást szerezzenek. A piacon jól ismert specializált programozói szakmák a következők: 
frontend programozó (magyarul: webprogramozó)
backend programozó (magyarul: szerver oldali programozó)
full stack (backend + frontend) programozó
adattudós (angolul: data scientist)
gépi tanulás szakértő (angolul: machine learning expert)
Képezzünk junior tervezőket! Ha junior programozókra már nincs szükség, mert lesznek olyan MI-k, amik egy tervből képesek jó minőségű kódot írni, amit néhány medior, egy-két senior programozó kicsiszol, akkor megnő az igény a tervezői munkakörökre. Ebben az esetben a cégek junior programozók helyett junior tervezőket fognak keresni. Ez a tendencia már most is megfigyelhető, az egyik legismertebb hazai banki informatikai beszállító szoftverház már most több junior tervezőt keres, mint junior programozót. Ez azt jelenti, hogy a programozó képzés keretében elmélyült tervezési ismereteket is nyújtani kell a felsőoktatásban.
Képezzünk kommunikatív, csapatmunkára alkalmas szakembereket! Ha junior programozókra már nincs szükség, mert az MI megfelelően jó minőségű kódot ír, még akkor is szükség lesz csapatra, ami képes együttműködni a MI-vel, illetve a tagok egymással. Ennek megfelelően a programozó képzésben nagyobb hangsúlyt kell kapnia az úgynevezett soft skill-ek (magyarul: csapatmunka készségek) fejlesztésének.
Bizonyára lesznek más válaszok is, amik néhány év múlva visszatekintve egyértelműek lesznek, de most nehezen láthatók.
Ennek a jegyzetnek a célja, hogy a 3-mas számú választ tegye lehetővé: Képezzünk junior tervezőket! Eddig nem is létezett olyan szakma, hogy junior tervező. A munkaerő piacon elfogadott szemlélet szerint csak az lehetett tervező, akinek már néhány év tapasztalata volt programozóként, esetleg tesztelőként, hogy könnyen megértse a szót a keze alá dolgozó programozókkal. E miatt lényegében csak medior tervezőként lehetett kezdeni a tervezői a szakmát. Ennek a jegyzetnek a célja, hogy a kedves olvasó olyan tudásra tegyen szert, aminek a segítségével sikeresen elhelyezkedhet junior tervezőként.
A jegyzet használható referenciakönyvnek, amiben csak megnézzük azt a tervezési fogalmat, amire kíváncsiak vagyunk, illetve, használható egymásra épülő leckék sorozataként is. Az ide tartozó fejezeteket megjelöltük a lecke szóval. A többi fejezet inkább a referenciaként használható.
Lecke 1.: A tervezői szakma
A lecke célja és tartalma
Célok, megszerezhető kompetenciák: A lecke végére megismerkedünk a tervezői szakmákkal.
Szükséges eszközök, források: -
Feldolgozási idő: 90 perc.
Témakörök: üzleti folyamat, üzleti elemző, rendszerelemző, folyamatelemző.
A lecke tartalma: Ebben a leckében azt a 3 tervezői szakmát nézzük át, amik hazánkban a legelterjedtebbek. Ezek az üzleti elemző, a rendszerelemző, és a folyamatelemző. Mindhárom szakma részleteit feltárjuk, az átfedéseket megmutatjuk. Az üzleti elemző és rendszerszervező kiemelkedő szerepet játszanak az üzleti folyamatok hatékonyságának növelésében és a fejlesztési folyamat előzetes tervezésében. A folyamatelemzők pedig proaktívan hozzájárulnak a vállalati folyamatok javításához és automatizálásához. Az első két szakma képviselő általában szoftverfejlesztő cégeknek dolgoznak, a harmadik szakma képviselő pedig a megrendelői oldalon.
Bevezetés
A számítógépes információs rendszereket tervező szakma több speciális szakmát takar:
üzleti elemző (angolul: business analyst),
rendszerelemző, rendszerszervező (angolul: system analyst, system architect),
folyamatelemző, folyamatszervező (angolul: process analyst, process architect),
követelményelemző (angolul: requirement engineer),
adatelemző (angolul: data analyst),
változáselemző (angolul: change management analyst).
A fenti lista nyilván nem teljeskörű, inkább csak ízelítő, milyen sokféle a számítógépes információs rendszert tervező szakma. A fenti listából csak az első hármat fejtjük ki. A többi munkakör nagyon-nagyon ritkán jelenik meg hazai informatikai álláshirdetésekben, és ha mégis, biztosan nem junior szinten.
Mint látható, a tervezői szakmát néha az elemző (angolul: analyst), néha a szervező (angolul: architect) szóval is jelölik. Általában az architekt egy nagyon kiemelkedő, mély tudású szakembert jelöl. Talán már csak a guru szó közvetít nagyobb tiszteletet, de nem is szokás használni ezt a szót csak a rendszergazda guru, illetve a Linux guru szókapcsolatokban.
Üzleti elemző és az üzleti folyamat fogalma
Az üzleti elemző (angolul: business analyst) feladata, hogy 
megértse a megrendelő üzleti folyamatait (angolul: business process),
javaslatokat tegyen az üzleti folyamatok javítására, annak érdekében, hogy a megrendelő pénzt, időt takarítson meg, nőjön a hatékonysága;
az elfogadott javaslatok alapján követelmény specifikációt készít,
a követelmény specifikáció alapján funkcionális specifikációt készít.
Miután proaktív módon meggyőzi a megrendelőt a változások fontosságáról, vagy a megrendelőben magától igények merülnek fel, akkor ezeket az igényeket mint követelményeket megfogalmazza. A követelményeket vagy átadja a rendszer elemzőnek, vagy ő maga készít ezekből informatikai rendszertervet egy módszertan mentén, esetleg ad-hoc módon.
Hogy az üzleti folyamat (angolul: business process) alatt pontosan mit értünk, az iskolánként eltérő lehet. Mi ezt a definíciót használjuk: Az üzleti folyamat olyan 
gyakran ismétlődő tevékenység sorozat,
amelynek bemenete
nyersanyag, félkész termékek,
adat, információ,
energia;
amelyet egy cég 
munkatársai, megbízottjai, 
robotjai, 
szoftveri együttműködve végeznek; ehhez
felhasználják a cég eszközeit, amik lehetnek
pénzügyi eszközök (tőke, hitel, bér),
termelőeszközök, szerszámok, gépsorok,
számítógépek, szerverek, szenzorok, munkaállomások,
járművek, targoncák, szállító eszközök; 
és ez értéket teremt.
Az érték lehet:
kézzelfogható árucikk, félkész termék, részegység, csomagolás,
szolgáltatás,
kézzel nem fogható döntés, terv, ellenőrzés,
ezeket dokumentáló dokumentáció, illetve
bármilyen más dolog, ami a cég valamely üzleti céljának elérését szolgálja.
Azt lehet mondani, hogy minden folyamat üzleti folyamat, ha azt egy cégen belül végezzük, nem egyszeri, és a cég érdekét szolgálja.
Ezek mind elég intuitív feltételek, valószínűleg bárki egy kis józan paraszti ésszel így definiálná az üzleti folyamatot. Egy nem teljesen természetes kikötést adtunk: Az üzleti folyamat, olyan folyamat, ami gyakran ismétlődik. Azaz megismételhető. Ezt sok más definíció úgy fogalmazza meg, hogy strukturált. E helyett mi a gyakran ismétlődő megfogalmazást használjuk, mert ez az a pont, ahol az informatika hatékonyan tud egy üzleti folyamatot javítani.
Az üzleti elemző legfontosabb feladata, hogy megértse a megrendelő üzleti folyamatait. Ehhez úgynevezett domain tudásra van szüksége. Itt van egy rekurzív csapda, mert a domain tudásnak része az üzleti folyamatok ismerte, az üzleti folyamatok megismeréséhez pedig szükséges a domain tudás. Ezt a csapdát úgy lehet kivédeni, ha a domain tudás összegyűjtését egy tanulási folyamatnak fogjuk fel. Először csak a megrendelő alapvető szakszavait tanuljuk meg. Aztán megismerjük az alapvető struktúrákat, döntéshozatali folyamatokat. Majd szép fokozatosan feltárjuk a megrendelő üzleti folyamatait. Ha valamit nem értünk, fontos, hogy kérdezzünk, mert az üzleti elemző legnagyobb ellensége a félreértés. A legjobb barátja pedig a rendszerszemlélet.
A rendszerszemlélet annak a képessége, hogy egy „sztoriról” képesek vagyunk eldönteni, hogy kerek egész, vagy bizonyos részletek még nem világosok. Itt a sztori leggyakrabban egy üzleti folyamat leírása. Például strand belépőjegyet árusítunk: Van díjmentes kisgyerek jegy 0-tól 5 éves korig. Van kedvezményes diákjegy, amihez diákigazolvány kell. Van kedvezményes családi jegy 2 felnőtt + 2 gyermek részére. Van normál felnőttjegy. És van szintén kedvezményes nyugdíjas jegy. Kerek ez a sztori? Hiányzik valami részlet? Ennyi információ alapján implementálható ez a funkció?
Aki észreveszi, hogy a kedvezmény sehol sincs pontosan megadva, az már jó úton halad. Az sem derül ki, hogy a normál felnőttjegy mennyibe kerül. Azt már egy kicsit nehezebb észrevenni, hogy a gyermek fogalma nem olvasható ki a fenti listából. Ki a gyerek? Akinek diákigazolványa van? Aki 18 évét még nem töltötte be? Ez nem derül ki, erre rá kell kérdezni.
A félreértések nagyon gyakran abból adódnak, hogy ami a megrendelőnek egyértelmű, arra a megrendelő nem veszteget szót, hiszen egyértelmű. A jó üzleti elemzőnek fontos képessége, hogy ráérezzen, mint hallgatott el a megrendelő. A másik fontos tulajdonsága, hogy proaktív módon ajánlja a fejlesztéseket.
Mivel az üzleti folyamatok gyakran ismétlődnek, ezért gyakran érdemes őket automatizálni. Az viszonylag ritka, hogy egy informatikai megoldás közvetlenül hasznot termel a megrendelőnek. Persze van ilyen is, például egy webshop közvetlenül hasznot termel. Sokkal gyakoribb, hogy egy informatikai megoldás időt, más erőforrást spórol meg, a szokottnál gyorsabb és pontosabb választ ad, a válasz összefüggéseit is megmutatja, és így közvetett hasznot termel. Ez úgy érhető el, ha sikerül egy-egy üzleti folyamatot automatizálni.
Rendszerszervezés
A rendszerszervezés feladata, hogy az implementálás előtt jó alaposan gondoljuk végig a rendszert, amit tervezünk. Miért? Mert minél hamarabb derül ki egy tervezési hiba, annál olcsóbb azt javítani. Ez egy fontos felismerés, mert olcsón szeretnénk magas minőségű szoftvert készíteni. Ez nehéz feladat, hiszen a mai napig szoftverkrízisről beszélhetünk (lásd: Szoftverkrízis). A szoftverkrízisre adott egyik válasz a rendszerszervezés.
A rendszerszervezés egy körfolyamatot támogat, a szoftverfejlesztés életciklusát (angolul: Software Development Life Cycle, röviden: SDLC). Ez alatt sok termék (szoftver, dokumentáció) keletkezik, amelyek elkészítésére a módszertanok tesznek ajánlást. A legfontosabb dokumentum a rendszerterv, ami vagy egy nagy összefüggő doksi, vagy rengeteg kisebb dokumentum alkotja, amelyek a backlog részei. Az SDLC fogalmát részletesen áttekintjük egy későbbi fejezetben.
Az SDLC első része a követelmények elemzése és a terv elkészítése, amit így együtt angolul "(system) analysis and design”-nak nevezünk és A&D rövidítéssel hivatkozunk rá. Később ezt a rövidítést gyakran használjuk.
A korai módszertanok nagy hangsúlyt fektettek arra, hogyan kell részletes, előretekintő rendszertervet írni. Ha egy fejlesztő nem értett valamit, akkor megnézte a rendszertervet. A mai módszertanok erre kevésbé figyelnek, inkább az iterációban és a fejlesztők közti kommunikációban bíznak. Ha egy fejlesztő nem ért valamit, megkérdezi a másik fejlesztőt.
Rendszerterv, és backlog
A rendszerterv (angolul: Design Specifications, esetleg: System Design Specifications) fogalmát részletesen áttekintjük egy későbbi fejezetben. Itt most csak a fogalom bevezetésére kerül sor. A rendszerterv arra szolgál, hogy a tervező alaposan átgondolja, mit és hogyan kell elkészíteni. Azt gondolhatnánk, hogy ez teljesen felesleges, mert a programozók úgyis végigmennek ezeken a lépéseken. A követelmény specifikáció alapján átgondolják, mit és hogyan kell implementálni, elkezdik megvalósítani, és ha kiderül, hogy valamit úgy nem lehet megoldani, ahogy elsőre tervezték, akkor újra átgondolják, újból nekifutnak.
Ez egy kis projektnél, úgynevezett garázs projektnél működik is. Ugyanakkor van két fogalom, amit ismernünk kell, ez a programozás-kicsiben (angolul: programming in small) és a programozás-nagyban (angolul: programming in large). Ez utóbbi kicsit hasonlít a WALL-E mozifilmben a Buy N Large (magyarul: Vásárolj Nagyban) cég nevére.
A programozás-kicsiben fogalmat használjuk a garázs projektek megnevezésére: Pár haver saját szórakozására programot ír. Jobb, mint ha hangosan zenélnének, legalább csendben vannak. 
Ezzel szemben a programozás-nagyban azt jelenti, hogy akkora kódot írunk, amit már egy-két ember, akármilyen zsenik, már nem lát át. Ekkora kód írásánál már csapatmunka kell, ezt a munkát már szervezni kell, a fejlesztéshez pénzt paripát fegyvert kell biztosítani.
Az első esetben megengedhetjük magunknak, hogy nem tervezünk, legfeljebb vakvágányra futunk, legfeljebb csak demó szinting jutunk. A második esetben luxus kihagyni a tervezést. A tapasztalat azt mutatja, sokkal jobb többször alaposan átgondolni egy feladatot, teleírni néhány lapot példákkal, mielőtt egy sor kódot is írnánk.
100 Forintos Licit: A fő gond azzal van, hogy ha valaki valamibe energiát fuccsol, akkor azt már nem akarja veszni hagyni, vagy csak nehezen. Erre épül a 100 Forintos Licit játék: Bocsátsunk licitálásra egy 100 forintos érmét. Egy kicsit keltsük fel a közönség érdeklődését, ez egy kivételes darab, a monda szerint több híresség birtokában is volt, és most bárki megszerezheti, aki a legtöbbet ajánlja érte. Azonban van egy csavar: Nemcsak a legnagyobb licit fizet, hanem a második legnagyobb is, ugyanakkor ő nem kap semmit. Próbálják ki! A tapasztalat azt mutatja, hogy a második nem akarja veszni hagyni a befektetését, akár irracionálisan nagy árat is hajlandó fizetni egy egyszerű 100 forintos érméért; de amikor rálicitál az eddigi legnagyobb licitre, akkor az lesz ugyanebben a helyzetben, ő se akarja veszni hagyni a pénzét, ő is rálicitál. Lám, milyen gyarló az ember!
Ugyanez történik, ha terv nélkül vágunk bele a fejlesztésbe. Lesz egy félig-meddig jó megoldásunk, amit refaktorálással toldozunk-foldozunk, de sose lesz igazán jó. Azaz, lehetne, csak el kellene dobni az eddigi kódot, és elölről kezdeni, de ehhez túl gyarlók vagyunk. Ha pedig már annyira rothad a kód, hogy már tényleg csak ez az opció marad, az eldobás és újrakezdés, akkor valamelyik versenytárs úgyis leköröz minket, tönkre megy a cég.
Tehát, programozás-nagyban esetén tervezni kell: Gondolja át a tervező még a fehér lapon mit és hogyan fejlesszünk. Ettől függetlenül biztosan lesz olyan, hogy kiderül, a terv nem jó, de a módszertanok kezelik ezt a helyzetet is.
És ezzel elértünk a módszertanok gondolatához. Ahogy a Buy N Large nem egy pozitív szereplő a WALL-E filmben, úgy a programozás-nagyban sem feltétlenül pozitív. Ez a fogalom azt jelenti, hogy a programozás már nem programozó zsenik művészete, hanem egyfajta jól megfizetett mérnöki munka. Nem egyéni, hanem csapat munka, ahol a cél már nem a kivételes minőség, hanem az átlagosan jó minőség. Ehhez kell egy módszertan.
Ahhoz, hogy az átlagosan jó minőséget elérjük egy átlagos képességű csapattal, ahhoz szükségünk van egy szoftver főzési receptes könyvre. Ezt a receptes könyvet hívjuk szoftverfejlesztési módszertannak.
Persze felmerül a kérdés, hogy miért átlagos képességű csapattal dolgozunk? Miért nem válogatjuk össze a zseniket? Miért nem egy kimagaslóan jó képességű csapattal dolgozunk? Nos, ezt kipróbálta néhány amerikai top egyetemen. Az volt a tapasztalat, hogy a belharcok felőrölték a csapatot, nem tudott kialakulni a csapaton belüli hierarchia, mindenki főnök akart lenni, egymás fúrására ment el az energiájuk. Ebből az következik, hogy a programozás-nagyban szükségszerűen magával vonja a csapatban fejlesztést, ami szükségszerűen magával vonja, hogy átlagos képességű csapatunk legyen, ami miatt kell módszertan, hogy a csapat munkája ne egy katyvasz, hanem egy átlagosan jó minőségű szoftver legyen.
A szoftverfejlesztési módszertanok arra a kérdésre adnak választ, hogyan bontsuk fel a bonyolult szoftverfejlesztést több egyszerűbb lépésre, hogy ennek eredményeként egy átlagosan jó minőségű szoftvert kapjunk.
Minden módszertan elfogadja azt az alapgondolatot, hogy fejlesztés előtt érdemes átgondolni, hogy mit és hogyan fejlesztünk. A nehézsúlyú módszertanok előírják, hogy rendszertervet kell készíteni. A könnyűsúlyú módszertanok pedig előírják egy folyamatosan finomított backlog használatát.
A kettő ugyanazt szolgálja, a tervező átgondolja a feladatot, megoldási javaslatot ad, még mielőtt a csapat ráveti magát a feladatra. A különbség ott van, hogy a rendszerterv egy nagy dokumentum, a backlog először egy apró, pár oldalas dokumentum, ami folyamatosan bővül. A backlog sose áll össze egy nagy dokumentummá, hanem megmarad sok kis dokumentum strukturált listájának.
A backlog szónak nincs elfogadott magyar fordítása. Azért nehéz lefordítani, mert elsődleges jelentése, hogy milyen feladatok vannak még hátra, mit kell még megtervezni, lefejleszteni. Másrészt jelenti az elkészült dokumentumok összességét is. Harmadrészt egyszerre utalhat még el nem készült, és már elkészült dokumentumokra is. Negyedrészt a backlog egy prioritásos lista, a lista tetején lévő feladatokat biztosan megcsináljuk, a lista alján lévőket aligha. Ötödrészt, időben változik, bővül, finomodik. Azaz, mindenféle feladatot tartalmaz, illetve ezek alapján létrejött termékeket (terv, ábra, dokumentum), amik egy másik feladat bemenetei, egész addig, amíg a feladat végeredménye már forráskód; a forráskód már nem része a backlognak. Lehetséges magyar fordítások:
prioritásos teendőlista,
háttérkészlet,
feladattár.
Egy fórum beszélgetésben még ezek merültek fel, kiszűrve a komolytalan hozzászólásokat:
hátraléklista, így egybeírva, vagy különírva: hátralék lista,
várólista,
hátralévő feladatok,
feladatok,
teendők.
Ebben a jegyzetben a backlog szót úgy használjuk, mint egy angolból magyarba meghonosodott szakszót. Ha mégis magyarul kellene mondani, akkor a feladattár mellé tesszük le a voksunkat.
A backlog először csak egy pár oldalas vízió. Aztán a vízió alapján nagyon magas szintű eposzokat (angolul: epic) fogalmazunk meg. Majd ezeket folyamatosan alábontjuk sztorik sorozatává. A sztorikat felbontjuk feladatokra. Mivel az epik szó kezd meghonosodni nyelvünkben, ezért az eposz helyett inkább az epik szakszót használjuk ebben a jegyzetben.
Az epik egy összefüggő funkció csoport, alrendszer, vagy modul, ami egy-egy szóba, szókapcsolatba sűríthető. Epik lehet mondjuk a beléptető oldal, az eladási alrendszer, a gazda modul. A víziót nem szoktuk feladat szintnek tekinteni, így az epik a legfelsőbb hierarchia szint a feladatok listájában.
A második szint a felhasználói sztorik (angolul: user story) szintje. Felhasználói sztori helyett mondhatjuk röviden, hogy sztori. Egy epik több sztorit tartalmazhat. A felhasználói sztori egy funkció egy lefutása a felhasználó szemszögéből. Általában forgatókönyvszerű (angolul: scenario) leírás: Béla bácsi elindítja a rendszert, sikeres belépés után szeretné használni a gazda modult, ehhez megnyomja a Gazda Modul feliratú gombot a főképernyőn. Ezen belül szeretné megnézni a csapadék adatokat, de nincs megfelelő szolgáltatás előfizetve. A rendszer felajánl 4-5 lehetséges előfizetést, amik közül Béla bácsi választ. Ezután már megtekintheti a csapadék adatokat.
A harmadik szint a feladatok (angolul: task) szintje. Feladat helyett használhatjuk a taszk szót is. Mivel a feladat szó egyszerre jelölhet egy nagy átfogó epiket és egy kis fejlesztési feladatot, ezért az utóbbi értelemben inkább a taszk szót használjuk. Egy sztori több taszkot tartalmazhat. Egy sztorihoz általában tartozik egy-egy frontend-tervezési, programozási és tesztelési taszk. Ugyanígy egy-egy backend-tervezési, programozási és tesztelési taszk.
Ha egy sztori vagy egy taszk túl nagy, túl komplex, akkor finomítjuk, több kisebb sztorira, illetve taszkra bontjuk. Ezt a folyamatot az egyes módszertanok pontosan szabályozzák.
Tehát a backlog egy folyamatosan bővülő feladattár, ahol a bővülés módja:
a finomítás, és
az alábontás, illetve
egy feladat eredménye lehet egy vagy több új feladat.
Azaz egy feladat feladatokat szül, egész addig, amíg forráskódot, illetve prototípust nem kapunk.
A backlog bővítésének fő folyamata:
A rendszer vízióját finomítjuk és epikeket hozunk létre. 
Az epik alábontása a felhasználói sztorik listája. 
A sztori alábontása a taszkok listája.
A taszkok eredménye lehet:
ábra, 
terv, 
módosítási kérelem (angolul: change request, angol rövidítése: CR), 
tesztjelentés, 
bármilyen dokumentum, 
de akár forráskód is.
Amíg ezek újabb feladatok bemenetei, addig a backlog bővítésére szolgálnak, de a kész forráskód, illetve a prototípus már nem része a backlognak.
A backlog egy-egy része lehet teljesen kifejtett. Más részei további finomításra, alábontásra váró részek. Egy szépen alábontott backlog egyszerre tartalmazza:
a követelmény specifikációt,
a funkcionális specifikációt,
az ütemtervet, és 
a rendszertervet is.
Előnye, hogy folyamatosan bővül, így minden bővítés előtt lehet kommunikálni a megrendelővel: 
megmutatni, hol tart a fejlesztés, 
megmutatni az utolsó prototípust,
megkérdezni, hogy jó irányba halad-e a terv, illetve a fejlesztés.
Akár rendszertervet készítünk, akár backlogot, ezek elkészítése, illetve gondozása a tervezők feladata.
Rendszerelemző, és rendszerszervező
A rendszerelemző (angolul: system analyst) és az üzleti elemző (angolul: business analyst) munkakör ritkán válik szét, legalábbis az itthoni informatikai piacon. Gyakran az üzleti elemző feladata a rendszerterv elkészítése is, ami egyébként már inkább a rendszerelemző feladata lenne. illetve gyakran a rendszerelemző feladata az üzleti igények megértése is, ami egyértelmű az üzleti elemző feladata. Az agilis módszertanok elterjedésével kezd szétválni a két szakma. Azok a tervezők, akik jobban tudnak kommunikálni a megrendelővel, ők az üzleti elemzők és gyakran a termék tulajdonosok is (angolul: product owner). Míg azok a tervezők, akik inkább a programozókkal, tesztelőkkel kommunikálnak sikeresen, nem szeretnek a megrendelővel kommunikálni, azok a rendszerelemzők. Egy üzleti elemző, ha a termék tulajdonos is, akkor nem része az agilis fejlesztő csapatnak, hanem inkább 2-3 csapat tartozik alá. Egy rendszerelemző általában csak egy csapathoz tartozik.
A rendszerelemző feladatköre
a funkcionális specifikáció alapján a logikai és a fizikai rendszerterv elkészítése, 
ha a módszertan rendszerterv helyett más dokumentum elkészítést írja elő, pl. backlog, akkor annak elkészítése, finomítása.
Mit látható a két szakma pontos szétválasztása nehéz, inkább csak hozzávetőleges szabályok adhatok:
Az üzleti elemző inkább a megrendelővel tartja a kapcsolatot.
A rendszerelemző inkább a fejlesztő csapattal tartja a kapcsolatot.
Az üzleti elemző inkább az A&D (angolul: Analysis and Design) feladatok első felében aktív:
elkészíti a követelmény specifikációt,
elkészíti a funkcionális specifikációt,
új epikeket vesz fel a backlogra,
új felhasználói sztorikat vesz fel a backlogra.
A rendszerelemző inkább az A&D feladatok második felében aktív:
elkészíti a rendszertervet,
a backlogon lévő terveket finomítja,
a felhasználói sztorikat finomítja, taszkokat vesz fel a backlogra.
Míg üzleti elemző esetében nem szokás arhitekt szintről beszélni, rendszerelemző (angolul: system analyst) munkakörben általában létezik még egy fokozat, ez a rendszerszervező (angolul: system architect). Ez a szó, rendszerszervező, már kezd kikopni a szaknyelvből, habár még a 90-es évek elején gyakran találkozhattunk ezzel a szóval az álláshirdetésekben. A rendszerszervező szó helyett egyre gyakrabban arhitektnek hívjuk azokat a magasan képzett, nagy tapasztalattal bíró tervezőket, akiknek a feladata az architekturális kérdések eldöntése.
Folyamatelemző, és folyamatszervező
A következő tervezői szakma a folyamatelemző (angolul: business process analyst, vagy röviden: process analyst). Míg eddig azt írtuk, hogy egy tervező gyakran egymaga látja el az üzleti elemző és a rendszerelemző munkaköröket, addig itt épp fordított a helyzet, ritka, hogy egy folyamatelemző más tervezői feladatot is ellásson. Ennek az az oka, hogy a folyamatelemzők általában a megrendelői oldalon ülnek, míg az üzleti elemzők és a rendszerelemzők a fejlesztést végző szoftverházban dolgoznak.
Míg az üzleti elemzőnél azt írtuk, hogy feladata proaktív módon javaslatokat tenni az üzleti folyamatok javítására, addig ez a folyamatelemzőre hatványozottan igaz: A folyamatelemző fő feladata az üzleti folyamatok javítása, automatizálása, mindezt a lehető legnyomulósabb, proaktív módon.
Miért hangsúlyozzuk ki ennyire a proaktivitást? Mert minden változásnak vannak vesztesei. Ha valamely folyamatot javítunk, automatizálunk, akkor Pista bácsinak és Mari néninek kevesebb lesz a munkája, és ha nem képesek továbbképezni magukat a cégen belül, akkor előbb-utóbb kirúgják őket. Általában egy vezető látja ezt, de a vezetőknek fontos, hogy tisztelet övezze őket. Épp ezért, egy vezető, legyen a neve Zolika, ritkán adja ki utasításba, hogy na Ferikém, javítani kellene F123-as folyamaton, hogy éves szinten megspóroljunk néhány milliót. Inkább az a bevett megoldás, hogy Ferike meglátja a javítás lehetőségét, és addig nyomul Zolikánál, amíg nem sikerül a szükséges fejlesztést jóváhagyatni. Zolika örül, mert spóroltak néhány milliót és ezért nem őt utálják. Ferike is örül, mert igazolva van az a magas fizetése, még talán év végi bónuszt is kap, és hogy mindenki szerint ő az oka, hogy nyugdíj előtt kivágták Mari nénit és Pista bácsit, na az nem zavarja.
Persze nem ennyire fekete és fehér a helyzet, de minden tervezőnek tisztában kell lennie azzal, hogy minden fejlesztés egyben változás is, aminek lesznek nyertesei és vesztesei.
Még egy fontos kérdés merül fel: Hogyan tudja a folyamatelemző meggyőzni a vezetőséget egy-egy folyamat javításáról? A válasz kulcsszava a ROI (angolul: Return on Investment, magyarul: megtérülés számítás). Azt szokták mondani, hogy minden fejlesztést érdemes megtenni, aminek a megtérülési ideje legfeljebb 3 év, és semmit se, ahol a megtérülés 5 év feletti. Nyilván a fenti két szélsőérték nagyban függ a cég helyzetétől, de durva szabálynak elfogadható.
Elvileg ROI-t számolni nagyon egyszerű: ROI = A befektetés várható hozamának összege a következő X évben / (a befektetett összeg + fenntartási költségek X évre). Részletesen:
A befektetés hozama = A cég értékének növekedése + Bevétel növekedés + Kiadás csökkenés.
A befektetett összeg = A fejlesztés költsége.
Fenntartási költség 1 évre = A fejlesztés üzemeltetési költsége 1 évre = éves licensz díj + éves üzemeltetési díj.
Úgy tűnik, ROI-t számolni egyszerű, csak 2 számot kell elosztani. A nehézség abból adódik, hogy ezek a számok általában csak becslések. A várható hozam általában abból adódik, hogy jobb lesz a szolgáltatás, de hogy ez hány forintot ér, mennyivel nő ettől a cég értéke, azt csak becsülni lehet. Egy kicsit egyszerűbb a helyzet, ha egy-két ember munkája kiváltható a fejlesztéssel, mert akkor az ő fizetésük kiesik, ez kiadás csökkenést, illetve termelékenység növekedését eredményez.
A másik oldalt is nehéz számolni, mert habár kapunk egy árajánlatot a fejlesztő cégtől, de általános tapasztalat, hogy minden informatikai projekt idő- és költségtúllépéstől szenved (lásd: Szoftverkrízis), amit majd a szoftvercég CR (angolul: change request, magyarul: változtatási kérelem) formájában próbál rányomni a megrendelőre.
Nézzünk egy példát: A B12-es folyamat az egyik fő szolgáltatása a cégünknek, minden részvényes imádja. Ugyanakkor a folyamat 3. lépése kiváltható egy egyszerű adatbázis lekérdezéssel, feltéve, hogy a login folyamatba még egy plusz adatot bekérünk. A fejlesztési igény alapján kapunk egy 4MFt-os árajánlatot, éves karbantartási díj pedig 1MFt. Becslések szerint az egyszerűbb folyamat az első évben 4MFt-ot, második évben 5MFt-ot, a harmadik évben 8MFt-os cég érték növekedést fog jelenteni a mostani értékhez képest. Vigyázat ezeket a számokat nem szabad összeadni, mert a bázis év a mostani év, és nem az előző év. A 3. évre számított ROI = 8 MFt / (4MFt + 3 * 1 MFt) = 8/7. Mivel ez a szám X = 3 éves távlatban nagyobb, mint 1, ezért ezt a fejlesztést érdemes megrendelni.
Általában itt még nem áll meg a ROI számítás. Kockázatokkal is számolni kell. Mi van, ha 20%-kal több lesz a fejlesztés költsége? Ez sajnos nagyon valószínű. Mennyire valószínű, hogy túlértékeltük a cégérték növekedést? Ez azt jelenti, hogy több ROI értéket is számolni kell különböző konfidenciaszinttel, magyar szóval: megbízhatósági szinttel. Ennek ismeretében tud a döntéshozó megalapozott döntést hozni.
Összegezve, a folyamatelemző feladatai:
az ad-hoc folyamatokból szabályozott folyamatokat készít,
a meglévő folyamatokat megismeri, dokumentálja, javítja, automatizálja,
az ehhez szükséges fejlesztések megrendelését előkészíti,
ROI-t számol,
kapcsolatot tart a fejlesztést végző szakemberekkel,
mindezt proaktív módon teszi.
Az üzleti folyamatokat már megvizsgáltuk az üzleti elemző munkakör leírásánál. Itt tovább elemezzük az üzleti folyamatok fogalmát. Két szélsőséges eset van:
ad-hoc üzleti folyamat, és
túlszabályozott üzleti folyamat.
Akkor mondjuk, hogy egy üzleti folyamat ad-hoc, ha nem szabályozott, nincs benne az SZMSZ-ben (szervezeti és működési szabályzat), ha úgynevezett tacit tudás kell hozzá (magyar szóval: hallgatólagos tudás). Például: Mari néni tudja, hogy a nyomtatópapír beszerzés legegyszerűbb módja, hogy telefonál Gyuri bácsinak, a raktárosnak, hogy hozzon fel két csomaggal, ha jön tenni a szépet Mari néninek.
A másik véglet, amikor egy üzleti folyamat túlszabályozott, és épp ezért kevésbé hatékony, kevésbé gyors, mint lehetne. Például a nyomtatópapír rendeléshez kell egy 13B belső megrendelés, amit egy 7C összegző lapon a megrendelési osztály osztályvezetője hagy jóvá, amiről értesíti az operatív igazgatót a 23E adatlapon.
Nyilván mindkét szélsőséges eset rossz. A folyamatelemző kollégának kell meglátni azt a pontot, amikor egy ad-hoc folyamatot már érdemes szabályozni, illetve önmérsékletet kell gyakorolni, nehogy túlszabályozza a folyamatokat.
Ettől is fontosabb a folyamatok automatizálása. Ennek előfeltétele, hogy a folyamatok jól dokumentáltak legyenek. Ehhez érdemes a BPMN (Business Process Model and Notation) grafikus nyelvet használni, ami épp üzleti folyamatok modellezésére jó. Nem szabad összekeverni a BPML (Business Process Modeling Language) nyelvvel, ami szintén ugyanerre jó, de a támogatása már régen megszűnt.
Ezután fel kell tárni azokat a részfolyamatokat, amit általában informatikai megoldásokkal, pl:
adatbázis létrehozásával,
szövegfelismeréssel,
szövegbányászattal,
szoftverrobot alkalmazásával,
gyorsítani lehet, egy-két munkás munkáját ezzel megkönnyítve, esetleg kiváltva.
Külön ki kell emelni a szoftverrobotokat, hiszen az AI fejlődésével ezek a megoldások a jegyzet írásának időpontjában kezdenek olyan pontosságot elérni, mint egy átlagos alkalmazott. Például elérhető megfizethető áron olyan szoftverrobot, ami 80-85%-os pontossággal képes eldönteni egy email-ről, hogy az termék reklamáció vagy sem. Ettől jobb pontosságot csak egy jól megfizetett tapasztalt ember képes elérni.
Fontos, hogy a javítás növelje a cég versenyelőnyét, produktivitását, profit termelő képességét, egyszóval a cég érdekében álljon.
Ugyanakkor az éghajlatváltozás miatt lehet még egy oka a folyamatok változásának, ami nem javítja se a termelékenységet, se a profit termelési képességet. Ez pedig a cég társadalmi hasznosságának növelése. Erre a szakszó a CSR (Corporate Social Responsibility, magyarul: vállalati társadalmi felelősségvállalás).
Mivel az éghajlatváltozás komolyan veszélyezteti társadalmunk jólétét, sőt az egész emberiség fennmaradását, ezért a CSR egyre fontosabb. Minden folyamatelemzőnek mihamarabb bele kell terveznie CSR lépéseket az általa gondozott folyamatokba. Mik lehetnek ezek?
Mielőtt átnézzük a valódi, előremutató CSR barát megoldásokat, nézzünk rá valamire, ami nem az, aminek tűnik. Ez a greenwashing (magyarul: zöldre festés, zöldre mosás, zöldálca), amikor úgy tűnik, hogy egy cég mindent megtesz, hogy kevesebb szén-dioxidot bocsásson ki, közben pedig nem is.
Greenwashing lehet például:
Csomagoláson feltüntetett szén-dioxid elnyelő, vagy biodiverzitást megőrző projekt támogatása, miközben ez a támogatás csak a csomagoláson létezik, a valóságban nem.
Kosárba tehetünk a vásárlásunk környezeti lábnyomát kiegyenlítő néhány százforintos virtuális terméket, amit lényegében minden vásárló megengedhet magának, de ez a pénz a valóságban a céget gazdagítja, nem fordítják valós környezetvédelmi programokra. 
Javasolt rákeresni az interneten konkrét példákra. Ezekkel a félrevezető lépésekkel cégek kihasználják a tájékozatlan vásárló jóindulatát, környezettudatossági szándékát, de igazából csak profitra vadásznak.
Példák a valódi vállalati társadalmi felelősségvállalásra:
papírmentes folyamatok;
erdőültetési projektek támogatása (vigyázat, könnyen zöldálcának tűnhet);
biodiverzitást megőrző projektet támogatása (vigyázat, könnyen zöldálcának tűnhet);
lebomló csomagolás használata;
szerverek felhőbe költöztetése, zöld energiát használó felhőszolgáltató választása;
energiahatékony (angolul: Energy Efficiency) design; az “Energy Efficiency” minőségi jelző a negyedik helyen van a “Software Architecture in Practice, Len Bass, Paul Clements, Rick Kazman, 2021” szakkönyvben.
körfolyamatok tervezése: 
elromlott, rossz termékek visszagyűjtése, újrahasznosítása;
ami az egyik folyamatban keletkező melléktermék, hulladék, az egy másik folyamatban hasznosítható bemenet; például a sörfőzés mellékterméke a melegvíz, ami üvegházi dísznövény termesztést tesz lehetővé;
megmaradt építkezési alapanyag meghirdetése, hátha másnak jó lesz;
stb...
Fontos megjegyezni, hogy a CSR lépések bevezetése ugyanúgy a vállalat vezetőjének a döntése, a folyamatelemző csak javaslatot tehet rá proaktív módon. Általában fontos, hogy a cég egésze, a munkavállalók és a vezetőség is támogassa a zöld átállást. Ilyenkor is kell ROI-t számolni, de ekkor azt is bele kell számolni a megtérülésbe, hogy hány vásárló, felhasználó fordul el a cégtől, ha a cég nem lépi meg azokat a lépéseket, amiket a versenytársai, vagy amiket a közösség elvár. Ezek nehezen becsülhető tételek. A közvélemény nyomása nélkül a cégek nehezen szánják rá magukat a CSR lépésekre, ami a folyamatelemző szemszögéből nézve csak a szokásos nehézség. A folyamatelemző feladata, hogy megelőzze a kényszerű lépéseket, mihamarabb legyenek tervei a folyamatok zöldítésére, még mielőtt a közvélemény kikényszeríti azokat.
Ahogy a rendszerelemző szakma esetén, a folyamatelemző (angolul: process analyst) szakmának is van architekt foka, a folyamatszervező (angolul: process architect). A folyamatszervező feladata a folyamat architektúra megtervezése, az ehhez kapcsolódó architekturális kérdések eldöntése. Általában ez a cégen belüli szerepkörök, illetve a szerepkörökhöz tartozó jogosultságok kialakítását jelenti. Ilyesmi kérdések ezek: Melyik szerepkörben lévő munkatárs indíthat B12-es folyamatot? Kellenek-e jóváhagyások? Milyen szerepkör hagyhat jóvá? Szerepkörök vannak vagy jogosultságok? Kell-e mindkettő? Van-e szerepkör hierarchia? Van-e jogosultság hierarchia?
Összegzés és ellenőrző kérdések
Ebben a leckében azt a 3 tervezői szakmát néztük át, amik hazánkban a legelterjedtebbek. Ezek az üzleti elemző, a rendszerelemző, és a folyamatelemző. Mindhárom szakma részleteit feltártuk, az átfedéseket megmutattuk. Az üzleti elemző és rendszerszervező kiemelkedő szerepet játszanak az üzleti folyamatok hatékonyságának növelésében és a fejlesztési folyamat előzetes tervezésében. A folyamatelemzők pedig proaktívan hozzájárulnak a vállalati folyamatok javításához és automatizálásához. Az első két szakma képviselő általában szoftverfejlesztő cégeknek dolgoznak, a harmadik szakma képviselő pedig a megrendelői oldalon.
Ellenőrző kérdések:
Kérdés: Kinek a feladata a 3 szakma közül a közvetlen kapcsolattartás a megrendelővel?
Válasz: Mindhárom szakmára jellemző, de leginkább az üzleti elemzőre.
Kérdés: Kinek a feladata a rendszerterv elkészítése, illetve a backlog karbantartása?
Válasz: Ha a 3 szakma szétválik, akkor az üzleti elemző feladat a rendszerterv elkészítése és a backlog karbantartása. Ha ezek a szerepkörök nem vállnak szét, akkor gyakran az üzleti elemző készíti el, tartja karban ezeket a termékeket.
Kérdés: Mi az üzleti elemző feladata?
Válasz: Az üzleti elemző feladata az üzleti igények megértése és dokumentálása.
Kérdés: Milyen dokumentumokat készít az üzleti elemző?
Válasz: Követelmény- és funkcionális specifikációkat.
Kérdés: Mit jelent az üzleti folyamat fogalma?
Válasz: Az üzleti folyamat gyakran ismétlődő tevékenységek sorozataként definiálható, amely értéket teremt a cég számára.
Kérdés: Mire van szüksége az üzleti elemzőnek a megrendelő igényeinek megértéséhez?
Válasz: Az üzleti elemzőnek alapos domain tudásra van szüksége.
Kérdés: Miért érdemes automatizálni az üzleti folyamatokat?
Válasz: Az üzleti folyamatok automatizálása időt és erőforrásokat takaríthat meg a cég számára.
Kérdés: Mi az SDLC első lépése, és milyen rövidítéssel hivatkoznak rá?
Válasz: Az SDLC első lépése a követelmények elemzése és a tervezés, amit angolul "(system) analysis and design”-nak nevezünk, vagy röviden: A&D-nek.
Kérdés: Mi a rendszerelemző és az üzleti elemző feladata?
Válasz: Az üzleti elemző inkább a megrendelővel tartja a kapcsolatot és az A&D feladatok első felében aktív, azaz a követelmény és funkcionális specifikációt készíti el, míg a rendszerelemző inkább a fejlesztő csapattal tartja a kapcsolatot és az A&D feladatok második felében aktív, azaz a rendszertervet készíti el.
Kérdés: Mi a folyamatelemző (angolul: business process analyst) fő feladata?
Válasz: Az üzleti folyamatok javítása és automatizálása proaktív módon.
Kérdés: Mi a különbség az üzleti elemző és a folyamatelemző között?
Válasz: Míg az üzleti elemzők a fejlesztést végző szoftverházban dolgoznak, addig a folyamatelemzők a megrendelői oldalon tevékenykednek.
Kérdés: Milyen szerepet játszik az ROI (angolul: Return on Investment) a folyamatelemző munkájában?
Válasz: Az ROI segít meggyőzni a vezetőséget egy-egy folyamat javításáról vagy automatizálásáról, hiszen ez mutatja meg a befektetés megtérülését.
Kérdés: Mit jelent az ad-hoc üzleti folyamat
Válasz: Az ad-hoc üzleti folyamat olyan, amely nem szabályozott, így a munkatársak tacit tudásán alapszik.
Kérdés: Mi a kockázat a folyamatok automatizálásakor?
Válasz: Az informatikai projektek idő- és költségtúllépésének lehetősége, amelynek eredményeként változhat az ROI, a megtérülési idő.
Kérdés: Milyen példákat említ a jegyzet a valódi vállalati társadalmi felelősségvállalásra?
Válasz: Példák lehetnek például a papírmentes folyamatok, az erdőültetési projektek támogatása vagy a körfolyamatok kialakítása.
Számítógépes információs rendszer fogalma
Az információs rendszerek (angolul: Informatívon Systems), egészen pontosan a számítógépes információs rendszerek (angolul: Computer Information Systems, angol rövidítése: CIS), vagy más szóval informatikai rendszerek, fogalmi rendszere a magyar nyelvű szakirodalomban szerencsére jól körbejárt kérdés. A régi rendszerszervezők jól ismerték Halassy Béla úgynevezett „sárga könyvét”, ami hasonló becenév, mint Programtervezési minták könyv beceneve, amit mindenki csak „GOF könyvnek” hív. A harmadik ilyen becenévvel rendelkező könyv a „kék könyv”. A hivatkozott könyvek:
„A sárga könyv”: Halassy Béla, Az adatbázis-tervezés alapjai és titkai, IDG Magyarország Lapkiadó Kft., 1994.
„A kék könyv”: Halassy Béla, Ember – információ – rendszer, IDG Magyarország Lapkiadó Kft., 1996.
„A GOF könyv”: Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides, Programtervezési minták, Újrahasznosítható elemek objektumközpontú programokhoz, Kiskapu Kiadó, 2004.
A GOF könyv onnan kapta nevét, hogy 4 szerzője van, és őket így négyen úgy hívták, hogy a négyek bandája (angolul: Gang of Four, angol rövidítése: GoF, vagy: GOF), és ennek angol rövidítéséből jött a GOF könyv név.
A sárga és a kék könyv nevének eredetét könnyű kitalálni, a sárga könyv borítója jellegzetesen sárga, a kék könyvé pedig kék. Szerencsére mindkét könyv könnyen elérhető a Magyar Elektronikus Könyvtáron keresztül: www.mek.oszk.hu.
Az alábbiakban a kék könyvben található definíciókat idézzük szó szerint, még akkor is, ha nem mindegyikkel értünk egyet, akkor is, ha az idézett szöveg helyesírása a mai szabályok szerint nem jó. Érdemes elolvasni Halassy úr eredeti gondolatait a kék könyvből, de némi magyarázattal mi is szolgálunk:
Adat: „Az adat értelmezhető, de nem értelmezett ismeret.”
Információ: „Az információ értelmezett adat.”
Rendszer: „A rendszer egymással összefüggő tényezők szervezett együttese.”
Informatikai, informatikai szakember: „Az informatika az ismeretek megismerésének, azok célszerű elrendezésének és kezelésének a tudománya. Az informatikus az a szakember, aki ebben a tudományban jártas.”
Tevékenység: „Tevékenységnek az adatok kezelését és előállítását célzó illetve az előbbieket vezérlő műveletek szervezett egységét tekintjük.”
Esemény: „Eseménynek az információs tevékenységet kiváltó illetve az azt lezáró momentumot nevezzük.”
Erőforrás: „Erőforrásnak az IR fejlesztéséhez és működtetéséhez szükséges időt, pénzt és technikai eszközöket - hardver illetve szoftver - tekintjük.”
Felhasználó: „Felhasználó az ismeretekkel kapcsolatban álló ember(csoport).”
Szabvány: „A szabvány az IR valamilyen tényezőjére vonatkozó megegyezés.”
Információs Rendszer (IR): „Az információs rendszer
adatoknak (információknak); 
a velük kapcsolatos információs eseményeknek;
a rajtuk végrehajtott információs tevékenységeknek;
az előzőekkel kapcsolatos erőforrásoknak;
az információk felhasználóinak;
ill. a fentieket szabályozó szabványoknak és eljárásoknak
a szervezett együttese.”
Fizikai adatterv: „Fizikai szintű - röviden: fizikai - adattervnek az ismereteknek az ábrázolását és tárolóeszközökön való elhelyezését rögzítő tervet nevezzük.”
Fogalmi adatterv: „Fogalmi szintű - röviden: fogalmi - adattervnek a valóságnak a kompromisszumoktól mentes képét rögzítő tervet nevezzük.”
Logikai adatterv: „Logikai szintű - röviden: logikai - adattervnek az alkalmazási környezet korlátainak megfelelően átalakított kompromisszumos tartalmi (fogalmi) tervet nevezzük.”
Tervezési folyamat: „Tervezési-folyamatnak [design-process], azaz tervezésnek hívjuk azt az időben lezajló tevékenység-sorozatot, amelynek során az információs rendszer adott vetületekbe és szintekbe sorolt elemeit meghatározzuk illetve azokat tudatosan összehangoljuk.”
Terv: „Terv-terméknek [design-product], azaz tervnek a tervezési-folyamat végeredményét, produktumát nevezzük.”
A fenti definíciók mind a kék könyvből származnak. Majd mindegyik definíció szerintünk is helyes, egyedül az „ismeret” szó használatával nem értünk egyet. A fenti definíciókban az ismeret fogalma nem kerül definiálásra, így ez zavarra adhat okot. E helyett mi a szimbólum fogalmára építjük fel a definícióinkat. E miatt az adat fogalmára saját definíciót adunk:
Definíció (Jel): Azt mondjuk, hogy a jel érzékszerveinkkel felfogható szimbólum, általában írott, vagy kimondott.
Definíció (Adat): Azt mondjuk, hogy az adat értelmezhető, de nem értelmezett jelsorozat.
A többi definíció jó. Érdekes, hogy rendszerterv szó helyett az adatterv szót használja Halassy úr, de ez abból fakad, hogy ő az adatbázis központú rendszerszervezők táborába tartozik.
Hasonlítsuk össze az információs rendszer és az üzleti folyamat definícióját:
Az üzleti folyamat olyan 
- gyakran ismétlődő tevékenység sorozat,
- amelynek bemenete
--- nyersanyag, félkész termékek,
--- adat, információ,
--- energia;
- amelyet egy cég 
--- munkatársai, megbízottjai, 
--- robotjai, 
--- szoftveri együttműködve végeznek; ehhez
- felhasználják a cég eszközeit, amik lehetnek
--- pénzügyi eszközök (tőke, hitel, bér),
--- termelőeszközök, szerszámok, gépsorok,
--- számítógépek, szerverek, szenzorok, munkaállomások,
--- járművek, targoncák, szállító eszközök; 
és ez értéket teremt.
Információs Rendszer (IR): „Az információs rendszer
- adatoknak (információknak); 
- a velük kapcsolatos információs eseményeknek;
- a rajtuk végrehajtott információs tevékenységeknek;
- az előzőekkel kapcsolatos erőforrásoknak;
- az információk felhasználóinak;
- ill. a fentieket szabályozó szabványoknak és eljárásoknak
a szervezett együttese.”

Látható, hogy a két fogalom egyes részei könnyen megfeleltethetők egymásnak:
adat, információ = adat (információ),
a cég eszközei = erőforrások,
a cég munkatársai = felhasználók,
üzleti folyamat = eljárás.
Illetve, van egy-két fogalom, ami nagyjából megfelel egymásnak. Például:
tevékenység = információs tevékenység,
ismételt = szervezett.
Illetve egy-két fogalom, ami csak az egyik oldalon található meg. Például:
az információs esemény csak az IR oldalon van,
a nyersanyag, a félkész termékek, csak üzleti folyamat oldalon található meg.
Levonható a következtetés, hogy a két fogalom nem ugyanaz. Sőt, mivel a Halassy féle eljárás fogalom leginkább az üzleti folyamatnak felel meg, ezét ezek egymásra épülő fogalmak. Ennek a megfigyelésnek a szellemében fogalmazzuk át az információs rendszer fogalmát, illetve az erre épülő fogalmakat:
Definíció (Szervezett Rendszer (SZR)): Azt mondjuk, hogy egy szervezett rendszer (SZR) egymással összefüggő elemek szervezett együttese, amely működéséhez a környezetéből adatot, információt, tőkét, nyersanyagot, energiát vesz fel, salakanyagait és termékeit a környezete felé közvetíti.
Definíció (Információs Rendszer (IR)): Azt mondjuk, hogy egy információs rendszer (IR) olyan SZR, amely adatokat gyűjt, azokat tisztítja, rendszerezi, tárolja, feldolgozza, és az így elálló információk áramlását segíti a rendszer egyes elemei és a rendszer környezete felé.
Definíció (Számítógépes Információs Rendszer (SZIR)): Azt mondjuk, hogy egy számítógépes információs rendszer (SZIR) olyan IR, amely feladatai elvégzésére és automatizálására számítógépeket és azokon futó szoftvereket, mesterséges intelligenciákat használ.
Definíció (Vállalati Információs Rendszer (VIR)): Azt mondjuk, hogy egy vállalati információs rendszer (VIR) olyan IR, amely a vállalat üzleti folyamataihoz szükséges információáramlást biztosítja.
Definíció (Számítógépes Vállalati Információs Rendszer (SZVIR)): Azt mondjuk, hogy egy számítógépes vállalati információs rendszer (SZVIR) olyan VIR, amely a vállalat üzleti folyamataihoz szükséges információáramlást számítógépekkel, azokon futó szoftverekkel és mesterséges intelligenciákkal segíti.
A fenti definíciókat így foglalhatjuk össze: Az SZR fogalmát részben Halassy úr rendszer definícióját foglalja magába, részben a fenntartható fejlődésből ismert önszerveződő rendszer fogalmát. Az önszerveződő rendszer olyan „élő” rendszer, amely környezetéből szerzi a működéséhez szükséges anyagokat, energiát, salakanyagait a környezetébe üríti és alkalmazkodik a változásokhoz. Ebből lett végül a SZR definíciója, amely egyrészt használja a „szervezett” szót, mint a a Hallasy féle definíció, másrészt használja a „környezet” szót, mint az önszerveződő rendszer definíciója. Ezek után az egyes definíciók mindig az előzőre épülnek, így csak a lényeges pontokat kellett megadni, ami rövid, velős megfogalmazásokhoz vezetett. Az IR olyan SZR, amely adatokat gyűjt, információkat állít elő, ez a terméke, ezt adja el a külvilág felé, illetve ezzel segíti a belső működést. A VIR olyan IR, ahol üzleti folyamatokhoz szükséges információ áramláson van a hangsúly. Itt már nem az információ a termék, de a termék előállításához kell információ is. A SZVIR olyan VIR, ahol a folyamatokat számítógép segíti.
A VIR rövidítés egy kicsit veszélyes, mert egy másik elfogadott fogalomnak, a Vállalatirányítási Információs Rendszernek is ez a rövidítése, és ez a fogalom az elterjedtebb a szakirodalomban. Mindenesetre a jegyzetben csak az „információs rendszer” vagy a „számítógépes információs rendszer” szókapcsolatot használjuk és ez alatt az SZVIR fogalmát értjük. Ha ez félrevezető lenne, akkor a fenti fogalmak egyikét fogjuk használni a rövidítésével együtt. Továbbá, a VIR rövidítést önmagában nem fogjuk használni a fenti ok miatt.
Ezt a fejezetet lehetne folytatni a különböző számítógépes vállalati információs rendszerek (SZVIR) típusainak felsorolásával, azok jellemzésével. Ugyanakkor nekünk, a szerzőknek, nem ez a szakterületünk. Mi, a szerzők, a programozás, a használati eset alapú tervezés, a programtervezési minták, az objektum orientál tervezési alapelvek és a jól bevált módszerek területén vagyunk szakértők, így elsősorban ezekre a területekre koncentrálunk.
Szoftverkrízis
A rendszerszervezés fő problémája az úgynevezett szoftverkrízis (angolul: software crisis). A szoftverkrízis alatt azt értjük, hogy a szoftverprojektek jelentős része sikertelen. Sikertelen a következő értelemben:
Vagy a tervezettnél drágábban készül el (over budget),
Vagy a tervezetnél hosszabb idő alatt (over time),
Vagy nem az igényeknek megfelelő,
Vagy nagyon rossz minőségű / rossz hatásfokú / nehezen karbantartható,
Vagy anyagi / környezeti / egészségügyi kárhoz vezet,
Vagy átadásra sem kerül.
A szoftverkrízis egyidős a számítógépek elterjedésével. Mivel maga a hardver szoftver nélkül csak egy használhatatlan vas, ezért kezdetektől nagy az igény a felhasználóbarát, magas minőségű, olcsó szoftverek iránt. Ezt az igényt a szoftverfejlesztő ipar a mai napig képtelen kielégíteni.
A sikertelen szoftverprojektek száma csökken. A hetvenes évek 80-90%-os sikertelen projektaránya napjainkra azért lassan, de csökken. Szerencsére a sikertelen szoftverprojektek sikertelenségének okai kevésbé súlyosak. Míg a hetvenes években a sikertelen projektek túlnyomó többsége átadásra sem került, addig manapság a sikertelenség oka inkább az idő vagy a pénzügyi keretek túllépése. Gyakori még, hogy a megrendelő nem az igényeinek teljesen megfelelő szoftvert kapja, de ez inkább a megrendelő és a szoftvercégek elégtelen kommunikációjának tudható be.
A szoftverkrízisnek több ismert oka is van:
Elégtelen hatékonyság: A szoftvercégek nem elég hatékonyak, azaz adott idő alatt kevesebb jó minőségű kódot fejlesztenek, mint az elvárható lenne.
Művészlelkű programozók: A programozók „programozóművészeknek” tekintik magukat, akik a programozást öncélú megvalósítási formának tekintik, amiért jól fizetnek.
Félreértés: A szoftvercégek nem ismerik azt a szakterületet (angolul: domain), ahonnan a megrendelő jön és így nem értik szaknyelvét. Ez félreértéseket szülhet.
Gyorsan változó környezet / igények: Egy hosszú szoftverprojekt ideje alatt megváltozhat a megrendelő igénye. Ennek oka lehet például egy új jogszabály, azaz a program környezetének megváltozása.
A fejlesztési idő nehezen becsülhető: A szoftverprojektek sikertelenségének legfőbb oka, hogy az előre kitűzött időpontra nem készül el a program. Ennek fő oka, hogy rendkívül sok váratlan nehézségbe ütközhet egy programozó („szívás” nélkül nem lehet programot fejleszteni), ami nehezen becsülhető.
Kevéssé specifikált feladat: Gyakori probléma, hogy a specifikáció egyetlen oldalas. Sok követelményre csak a fejlesztés során derül fény.
Miután a kiváltó okokat többé-kevésbé megismertük, ismerjük meg a szoftverkrízisre adott főbb válaszokat is:
A rendszerszervezés legfőbb válasza a tervezés. Mielőtt neki látunk a programozásnak, ez előtt alaposan végiggondoljuk, hogy mit és hogyan fogunk megoldani. Ezeket a megoldásokat a tervezési dokumentumaiban, más szóval, a tervezés termékeiben (angolul: A&D project deliverables) rögzítjük. Sok év alatt az a tapasztalat alakult ki, hogy a tervezés középpontjába érdemes a használati eseteket a (angolul: use case) állítani, ami a legegyszerűbb eszköz a funkcionális követelmények rögzítésére. 
A rendszerszervezés másik válasza a módszertanok bevezetése. A módszertanok szigorúan vagy kevésbé szigorúan, de előírják a szoftverfejlesztés lépéseinek, azon belül a tervezés lépéseinek sorrendjét. Meghatározzák, mikor kell a megrendelőnek és a fejlesztőnek kommunikálnia, ezek alapján milyen dokumentumoknak kell létrejönniük. Minden lépés néhány dokumentumra épül és általában egy új dokumentum vagy programrészlet az eredménye. A lépések a szoftverfejlesztés életciklusának a lépései.
A rendszerszervezés másik válasza a kockázatmenedzsment. A kockázatmenedzsment kimondja, hogy a kockázatokat fel kell mérni, azokat a valószínűségük és okozott idő / pénz veszteségük szerint osztályozni és a legsúlyosabb kockázatokra készülni kell. Ez általában redundáns erőforrások biztosításával lehetséges.
A rendszerszervezés következő válasza a megrendelő és a fejlesztő kommunikációját segítő vizuális nyelvek bevezetése, ezek egységesítése. Az UML, és főleg a használati esetek (angolul: use case) elterjedése egy olyan jelölésrendszert biztosít, amelyet a megrendelő szakemberei és a programozók is könnyen megértenek. Ez segíti a félreértések elkerülését a két fél közt.
A programozási technológiák első válasza, hogy a programozási nyelvek fejlődésével egy utasítás egyre több gépi kódú utasításnak felel meg. Ez az arány assembler nyelveknél egy az egyhez (1:1), azaz egy assembler memonic egy gépi kódú utasításnak felel meg. A második generációs nyelvek (Fortran, COBOL, PL/1) esetén egy utasítás néhány tucat gépi kódú utasítást vált ki (1:10). A harmadik generációs procedurális nyelveknél (Pascal, Ada, C/C++) egy utasítás néhány száz gépi kódú utasításnak felelhet meg (1:100). A negyedik generációs OOP nyelvek (Java, C#) esetén ez a szám néhány ezer is lehet (1:1000). Ezzel a módszerrel nő a programozók hatékonysága.
A programozási technológiák második válasza a program modulokra bontása (lásd: Separation of Concerns). Már az assembler nyelvek is megengedték, hogy a forráskódot több állományba tároljuk, ezek között szubrutinokat hívjunk. Minden állományt külön kellett fordítani (angolul: compile) tárgykódú programmá, ami már gépi kódú, de amiben a címzések még nem feloldottak. A tárgykódú programokat egy szerkesztő (angolul: linker) segítségével kellett futtatható programmá összeszerkeszteni. A modularitás a programozási nyelvek fejlődésével egyre nagyobb támogatást kapott. Megjelentek a függvények és az eljárások (együtt alprogramok), a modulok (fordítási alegységek), végül az osztályok, amik az adattagokat és a rajtuk végzett metódusokat zárja egységbe. A modularitás nagy áldása az, hogy megengedi, hogy több programozó készítse a programot. Illetve az aspektusok, amik annyira nem terjedtek el, de amik lehetővé teszik, hogy az olyan funkciókat zárják egységbe, amit sok osztálynak implementálnia kell, pl. naplózás, jogosultság ellenőrzés. Minden programozónak csak a saját modulját kell átlátnia, a többit nem. Ez azért fontos, mert egy programozó csak néhány ezer, esetleg tízezer kódsort lát át, azaz egy modul maximális mérete kb. 10 000 sor. A modularitás megengedi, hogy ennél nagyobb programot is fejleszthessünk azáltal, hogy azt kisebb, átlátható modulokra bontjuk. A moduloknak természetesen kommunikálniuk kell. Erre később térünk ki.
A programozási technológiák fő válasza a tervezési alapelvek és a tervezési minták bevezetése. A tervezési alapelvek magas szintű jó tanácsok, hogy hogyan érdemes programot fejleszteni. A tervezési minták alacsonyabb szintű ajánlások, egy-egy gyakori problémára nyújtanak kiforrott, mégis általános megoldást. Jól megfigyelhető, hogy a tervezési minták követik a tervezési alapelveket.
A programozási technológiák legújabb válasza a szakterület specifikus (angolul: domain specific) keretrendszerek, programozási nyelvek megjelenése, illetve olyan technológiák megjelenése, amelyekkel ezek könnyen elkészíthetők. A területspecifikus fejlesztés ígérete az, hogy egy konkrét területre specifikált nyelven a fejlesztés sokkal hatékonyabb. Gondoljunk például arra, milyen egyszerű CMS rendszerekkel webportált készíteni. A területspecifikus technológiák közül ezek a legismertebbek:
Modell vezérelt architektúra, vagy másik nevénmodel vezérelt programozás (angolul: Model Driven Architecture / Development, röviden: MDA),
Szakterület specifikus modellezés (angolul: Domain-Specific Modeling, röviden: DSM),
Szakterület vezérelt tervezés (angolul: Domain-Driven Design, röviden: DDD).
A szoftverfejlesztés technológiájának első válasza a programozó munkájának segítése. Nagyon fontos lépés volt az editorok, nyomkövető (debugger) rendszerek integrálása egy integrált fejlesztési környezetbe (angolul: Integrated Development Environment, röviden: IDE), ami többek közt szintaxis-kiemeléssel (angolul: syntax highlight) segíti a programozó munkáját. Ide sorolható minden olyan szoftver, ami a programozók munkáját segíti.
A szoftverfejlesztés technológiájának további válasza (ami az előző általánosítása) a csoportmunkát segítő technológiák kifejlesztése. Láttuk, hogy a program modulokra bontható, a modulokat más-más programozó készítheti. A fejlesztőknek sokat kell kommunikálniuk, hiszen továbbra is egy szoftvert fejlesztenek, a modulok függnek egymástól, a moduloknak hívniuk kell egymást. Ide tartozik minden olyan szoftver, ami több programozó együttes munkáját segíti. A fő csapatmunkát segítő technológiák:
Verziókövetés
Hibakövetés
Modellező eszközök
Függőségek leírást és feloldását segítő „make” eszközök
A szoftverfejlesztés technológiájának második válasza a tesztelés segítése, automatizálása. Itt nagy szerepet kap az egységtesztek (angolul: unit-tests) elterjedése, ami lehetővé tette az agilis módszertanok elterjedését. Ezen a területen belül külön kiemelendő a tesztvezérelt fejlesztés (Test-Driven Development, TDD), amely előírja, hogy először írjunk egységtesztet, csak utána a tesztelendő metódust.
A szoftverfejlesztés technológiájának harmadik válasza a konténer technológia megjelenése. Egy-egy szoftvernek annyi függősége van, a felhasznált applikáció szerver beállításai annyira bonyolultak, hogy a szoftvert ezekkel együtt, sőt az operációs rendszerrel együtt, bezárják egy konténerbe, ami operációs rendszer szintű virtualizációt valósít meg, és így bármilyen gépen lehet futtatni. Ebből adódik a technológia fő előnye: Nagyon könnyen lehet prototípust készíteni és azt eljuttatni a megrendelőhöz. Ez az alapja a folyamatos integrációnak (angolul: Continuous Improvement – CI), amikor nagyon sűrűn, akár sprintenként készül új prototípus.
A szoftverkrízisre adott legújabb válasz: A mesterséges intelligencia megtanítjuk programozni. Miután a GIT verziókövető rendszer népszerű lett, megjelent a GitHub, ahol nagyon kényelmesen, és ami a fő, ingyenesen lehetett, és még most is lehet, szoftver projekteket tárolni. Rengeteg kisebb-nagyobb projekt költözött a GitHub-ra. Mindez pár év múlva nyert értelmet, amikor kiderült, hogy az itt elérhető rengeteg programmal, sok millió programsorral tanítanak fel egy mesterséges intelligenciát, a Copilot nevű MI-t. És mint kiderült, a jelenlegi AGI-k egész jól programoznak. Sok programozóban merül fel a kérdés: „Az rendben, hogy az MI-k munkahelyeket tesznek tönkre. Ez tudtuk, erre számítottunk, de mi programozók, miért a programozó szakmát nyírjuk ki először?” Nyilván, ez egy sarkítás, de jól érzékelteti, hogy milyen bizonytalanság uralkodik a szakmában, és miért kell a tervezés oktatására nagyobb hangsúlyt fektetni.
Ebben a jegyzetben főleg a tervezést, a használati eset alapú tervezést, és a használat esetek alábontására alkalmas tervezési lépéseket ismertetjük, de nem a szokásos UML központú leírást használva, bár rengeteg UML ábra található a jegyzetben, hanem inkább egy programozói szemléletet tükröző leírást használva. Azt mutatjuk be, hogy ha egy programozó átáll a tervezői oldalra, akkor hogyan látja ezt az oldalt.
A három P betűs szó: Principles, Patterns, Practices
Ennek a jegyzetnek a középpontjában a tervezés, mint a szoftverkrízisre adott fő válasz áll; a tervezésen belül is a használati eset (angolul: use case) alapú tervezés. A használati eset alapú tervezés sajátja, hogy a magas szintű használati eset ábrákat alá kell bontani, finomítani kell. Ahhoz, hogy rugalmas, könnyen bővíthető architektúrát tudjunk tervezni, elengedhetetlen a címben szereplő három P betűs szó (röviden: 3P) ismerete. A 3P ezeket az angol szavakat, illetve fogalmakat jelölik:
Principles, hosszabban: Design Principles, magyarul: tervezési alapelvek;
Patterns, hosszabban: Design Patterns, magyarul: tervezési minták;
Practices, hosszabban: Best Practices, magyarul: jól bevált módszerek.
A 3P központi szerepet játszik ebben a jegyzetben. Miután körbejárjuk a user case alapú tervezést, és már átlátjuk a tervezett rendszer funkcióit, ezután következik a funkciók kibontása, a kapcsolódó adatbázis és osztály tervek elkészítése.
Amikor megtervezzük az osztályokat, akkor alapvető kérdés az osztályok felbontása. Az egyik extrém eset, amikor csupán egy osztályunk van és az old meg minden feladatot. A másik extrém, hogy minden osztályunk nagyon kicsi, csak egy-egy részfeladat megoldását látja el. Nyilván mindkét megoldás rossz. Az első megoldás rossz, mert az osztályon belül a mező globális változó és ha egy nagy, mondjuk 10 ezer soros kódot írunk, abban a globális változók használata már megtalálhatatlan hibákat eredményez. Nyilván a másik megoldás is rossz, mert a megoldás sok-sok kicsi osztálya szükségszerűen maga után vonzza a hosszú hívási láncokat: történik valami és csak az 5-6 hívás után lesz végre egy for ciklus, ami csinál is valamit.
A két megoldás közt nagyon sok átmenet lehetséges és ez igazán tervezői kérdés, hogy melyik feladatot melyik osztály zárja egységbe. A sok lehetséges megoldás közt megtalálni egy könnyen bővíthető, könnyen újrafelhasználható megoldást, ebben segít a PPP elsajátítása.
Az alapelvek (angolul: principles) az alapvető kérdést segítenek eldönteni: Mit zárjunk egységbe egy osztályban? Azok felé milyen absztrakciós szinteket tegyünk?
Ha jól használtuk az alapelveket, akkor valószínűleg valamilyen tervezési mintához közel álló megoldást találtunk. A terven belül érdemes nevet adni a gyermeknek: itt egy stratégiát alkalmazunk, itt pedig valamilyen megfigyelő tervezési mintát. Ezek a szavak, a minták jól ismert nevei, jól ismertek a programozók körében, könnyebben megértik ezek segítségével a tervet.
Persze úgy is megközelíthető a terv, hogy nem az alapelvek betartására törekszünk, hanem próbáljuk megtalálni azt a tervezési mintát, amit használni érdemes. és ha tervezési mintát használunk, akkor az alapelveket is betartjuk, hiszen a tervezési minták jól bevált, időtálló receptek, ami abból következik, hogy betartják a tervezési alapelveket.
Ezeken túl már csak a jól bevált módszerek alkalmazása marad, amik már a konkrét fejlesztésre adnak módszereket: használjunk sok unit-tesztet, nézzük át egymás kódját!
Ugyanakkor a jól bevált módszerek oldaláról is indulhat a terv alábontása, hiszen vannak olyan módszerek, ahol először a teszteket, vagy nagyon konkrét forgatókönyveket kell a kód előtt elkészíteni. Lásd a TDD és a BDD módszereket.
Tehát a 3P a használati eset alapú terveket alábontásában segít. Hogy ezt melyik P betű felől kezdjük, az már a tervezőn, a tervező körüli csapaton múlik, és talán a tervezés területén tapasztalható divat hullámokon is.
Van, aki a RUP idején kezdett el tervezni és ezért az UML alapú eszközöket részesíti előnyben. Van, aki a Sarum korai korszakában, ezért a tervezési mintákat részesíti előnyben, hogy könnyen bővíthető kódot tervezzen. Van, aki már a tiszta kód időszakában kezdett tervezni, ezért a TDD módszerre helyezi a hangsúlyt. Mostanában a Scrum érett korszakában járunk, ahol a Scrum-ot illik kombinálni Kanban vagy más módszertanokkal. Ezek a tervezők már jól eséllyel a SOLID elvek betartására törekszenek, illetve nem ismeretlen előttük a BDD, ami szép lassan felváltja, kiegészíti a TDD módszert.
Mit hoz a jövő? Mindenképp előtérbe kerülnek a nagy nyelvi modelleken alapuló általános mesterséges intelligenciák (AGI-k), illetve majd megjelennek az egyes területekre fejlesztett speciális modellek is (ANI-k). Hogy ezeket hogyan fogjuk a szoftverfejlesztésre, számítógépes információs rendszerek tervezésére használni, azt pontosan még nem látható. Annyi tűnik biztosnak, hogy érdemes lesz ezeket használni, hogy növeljék a szoftverfejlesztő cégek termelékenységét.
Illetve az látszik még, hogy az inga kezd visszalengi. A módszertanok hajnalán sok-sok dokumentációval dolgoztunk, majd egyre kevesebbel, egészen az extrém programozásig (angolul: eXtreme Programming, röviden: XP), ahol lényegében nem írtunk dokumentációt, csak rengeteg unit-tesztet. Az XP fő elve, hogy ha valamit csinálunk, akkor azt csináljuk extrém jól, ha valamit nem csinálunk, akkor extrém módon ne csináljuk: ne csináljunk egyáltalán dokumentációt, de csináljunk nagyon sok unit-tesztet. Aztán ez a tendencia megfordult, újra elkezdtünk írni felhasználói sztorikat, mostanában újra kezd elterjedni a rendszerterv meglétének az igénye, ami az jelenti, hogy az inga visszafelé leng, megint egyre több dokumentációt használunk.
Valószínűleg a terjedelmes dokumentációból majd mesterséges intelligencia segítségével fejlesztünk szoftvert, ahol a kérésünkbe (angolul: prompt) bele kell majd fogalmazni a 3P-re vonatkozó tudásunkat: „Kedves mesterséges intelligencia, kérlek, a következő terv alapján készíts Java programot a Megfigyelő tervezési minta használatával és a SOLID elveket betartásával.”
Az is sejthető, hogy az egyik legújabb hype a craftmanship, annak a ténynek az elfogadása, hogy az informatikusoknak maguktól kell továbbképezniük magukat, hogy ne maradjanak le az informatika gyorsvonatjáról. A craftmanship (magyarul: jómunkásembernek lenni) azt jelenti, hogy nem várhatjuk el az állam bácsitól, a cégtől, ahol dolgozunk, hogy gondoskodjon a továbbképzésünkről, hanem erről saját magunknak kell gondoskodnunk. Úgy tűnik, szép lassan átlépünk a craftmanship korszakába. Hogy ez jelenti-e egy új módszertan megjelenését, vagy marad a Scrum valamilyen változata, az még nem látszik.
Hogy a kedves olvasó milyen módszereket fog használni a használati eset alapú terv finomítására, az az egyéni tapasztalatokon túl ezen a jegyzeten is múlik, ezért igyekszünk egy alapos munkát a kedves olvasó kezébe adni! Ennek megfelelően a 3P kifejtését egy-egy fejezetben mutatjuk be. Kivétel képez a DIP (angolul: Dependency Inversion Principle, magyarul: Függőség megfordításának alapelve), amelyet még további 2 fejezetben fejtünk ki.
A jó terv viták eredménye
Sir Tony Hoare-tól származó híres idézet szerint: „premature optimization is the root of all evil” (szó szerinti fordítása: a korai optimalizáció minden gonosz forrása; szabad fordításban: minden fejfásunk fő oka a korai optimalizálás), ami alatt mi programozók azt értjük, hogy nem érdemes az optimalizálással foglalkozni, amig nincs visszajelzés, hogy valamelyik része a szoftvernek lassú. Csináljunk egy mezítlábas megoldást és majd később optimalizálunk, ha kell.
A fenti idézetet Donald Knuth így magyarázza: „Programmers waste enormous amounts of time thinking about, or worrying about, the speed of noncritical parts of their programs, and these attempts at efficiency actually have a strong negative impact when debugging and maintenance are considered. We should forget about small efficiencies, say about 97% of the time: premature optimization is the root of all evil. Yet we should not pass up our opportunities in that critical 3%.”
Magyarul: „A programozók rengeteg időt vesztegetnek azzal, hogy a programjaik nem kritikus részeinek sebességén gondolkodnak vagy ezen aggódnak, és ezek a hatékonysági megfontolások valójában erős negatív hatással vannak a hibakeresésre és a karbantartásra. El kell felejtenünk a kis hatékonyságú optimalizálást, mondjuk az esetek 97%-ában: a korai optimalizáció minden gonosz forrása. Mégsem szabad elszalasztani az optimalizációs lehetőségeinket ebben a kritikus 3%-ban.”
Hoare úr gondolata sok változatban él tovább, például az extrém programozás (XP) szerint törekedjünk a legegyszerűbb megoldásra és ha az nem elég rugalmas, akkor majd refaktoráljuk a kódot. Ehhez hasonló az iteratív módszertanok, azon belül is a Scrum gondolata, minden iterációban, ahogy kiderülnek az eddig rejtett követelmények, finomítjuk a megoldást. Illetve van egy XP alapelv, hogy „úgyse lesz rá szükség” (lásd: YAGNI), amit érthetünk az optimalizációra is: úgyse lesz szükség gyors, optimális kódra.
Ezzel szemben áll a tervezői gondolkozás, ami röviden így jellemezhető: A terv legyen rugalmas, könnyen bővíthető, az egyes modulok könnyen újrahasznosíthatók, hiszen így tudunk alkalmazkodni a folyton változó megrendelői igényekhez, illetve az újrafelhasználás a szoftvercég sikerének fő kulcsa.
Sajnos ez a kettő gyakran szemben áll. A rugalmas tervben, szükségszerűen plusz absztrakciós szintek vannak (lásd: DIP), ami egyfajta korai optimalizáció, és tényleg nehézkessé teszi a hibakeresést. 
A programozói gondolkozásban is létezik a korai optimalizáció elfogadása, amit, mint láttuk, Donald Knuth is elfogad. Habár kevésbé népszerű, de elfogadott a 3F gondolata: Function, Form, Fitness; magyarul: Funkcionalitás, Forma, Fitnesz. Ez a 3 szó a válasz arra kérdésre: Milyen a jó a szoftver?
Funkcionalitás (angolul: Function): A jó szoftver az igényeknek megfelelő funkcionalitással bír.
Forma (angolul: Form): A jó szoftver könnyen karbantartható.
Fitnesz (angolul: Fitness): A jó szoftver gyors és fit.
Az eredeti angol forrás itt tekinthető meg: https://wiki.c2.com/?DesignForPerformance.
Tervezői körökben elfogadott továbbá az a nézet, hogy ami egyszerű, az jó (lásd: KISS). Ez a gondolat a hadi mérnököktől származik, ahol nagyon fontos, hogy a fegyverek könnyen használhatók legyenek. Később ez a gondolat annyira elfogadott lett, hogy manapság ez már az egyik fő mérnöki alapelv. 
Tehát a tervezői gondolkodást az általános megoldásra való törekvés jellemzi, a programozói gondolkozást pedig az egyszerűségre való törekvés. Ez gyakran ellentétes, de nem kibékíthetetlenül ellentétes, hiszen a programozók is elfogadják, hogy néhol szükség van az általánosításra, az optimalizációra és a tervezők is elismerik, hogy ami egyszerű, az jó.
Ha a terv elkészítése csak a tervező feladata, akkor az valószínűleg túlzottan általános lesz, sok-sok felesleges absztrakciós szinttel. Ha a tervet egy programozó készíti, akkor az valószínűleg túl egyszerű lesz, nem elég rugalmas, nem elég újrafelhasználható, csak néhány rafaktorálási kör után lesz elérhető a megfelelő rugalmasság.
A jó terv a két álláspont vitájából születik, a tervező és a vezető programozó vitájából, hogy megtalálják, mely absztrakciós szintekre van tényleg szükség, hol kell valóban optimalizálni, és mi az a rész, ahol elég egy mezítlábas megoldás, és mi az, amit akár egy mesterséges intelligencia is megírhat.
