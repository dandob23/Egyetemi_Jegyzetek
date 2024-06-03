4- fejezet:

Patterns: Tervezési minták
A tervezési minták gyakori programozói feladatokat oldanak meg. Gyakorlott programozók, miután már sokszor megoldottak egy-egy problémát, desztillálták a bevált megoldások lényegét. Így születtek a tervezési minták, ezek gyűjteményei. Ezek közül az első a GOF könyv volt, majd ezt több is követte. Ezek közül a legjelentősebbek:
„The GOF book”: Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides: Design Patterns, Elements of Reusable Object-Oriented Software, 1995.
„A GOF könyv”: Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides: Programtervezési minták, Újrahasznosítható elemek objektumközpontú programokhoz, Kiskapu Kiadó, 2004.
Robert C. Martin: Agile Software Development, Principles, Patterns, and Practices, Prentice Hall, 2002.
Eric Freeman, Elisabeth Robson, Kathy Sierra, Bert Bates: Head First Design Patterns, O'Reilly Media, 2004.
Alan Shalloway, James Trott: Design Patterns Explained, A New Perspective on Object Oriented Design, 2004.
Cay S. Horstmann: Object-Oriented Design and Patterns, Wiley, 2006.
Robert C. Martin: Clean Architecture, A Craftsman's Guide to Software Structure and Design, 2017.
Vaskaran Sarcar: Design Patterns in C#: A Hands-on Guide with Real-world Examples, 2020.
J.J. Geewax: API Design Patterns, 2021.
Addy Osmani: Learning JavaScript Design Patterns: A JavaScript and React Developer's Guide, 2023.
Ebben a jegyzetben elsősorban a GOF könyvben ismertetett mintákat nézzük át.
A minták alkalmazásával könnyen bővíthető, módosítható osztályszerkezetet kapunk, tehát rugalmas kódot. Az ár, amit ezért fizetünk, a bonyolultabb, nehezebben átlátható kód és a nagyobb fejlesztési idő. Sokan azt mondják, hogy ez nem fizetőik ki. Törekedjünk a legegyszerűbb megoldásra (lásd extrém programozás) és ha kell, kódszépítéssel általánosítsuk a kódot. Így érjük el a rugalmas kódot.
A tervezési minták viszonylagos bonyolultsága abból adódik, hogy olyan osztályokat tartalmaznak, amiknek semmi köze valóságos objektumokhoz, habár azt tanultuk, hogy egy OOP osztály a valóság absztrakciója. Ugyanakkor ezekre a technikai osztályokra szükség van a rugalmassághoz. Ezek azok az osztályok, amiket józan paraszti ésszel nehéz kitalálni, de nem is kell, mert a legjobb megoldások tervezési minták formájában rendelkezésre állnak.
Architekturális minták
Az architektúra a program azon része, ami nem változik az idő során, vagy ha változik, akkor az nagyon nehezen kivitelezhető. Talán egy szívátültetéshez vagy agyműtéthez hasonlítható.
MVC – Model-View-Controller
Az MVC minta talán az első tervezési minta. A nevét a három fő komponensének nevéből kapta:
Model (magyarul modell): Az adatokat kezelő réteg. Ez felel az adatok tárolásáért, visszaolvasásáért. Itt foglalnak helyet azok a függvények is, amik műveleteket végeznek az adatokon. Része az adatbázis is.
View (magyarul nézet): A felhasználói felület megjelenítéséért, a felhasználó különféle nyűgjeinek a Vezérlő felé továbbításáért felelős réteg. Itt jelennek meg a felhasználó számára a vezérlőelemek, a felhasználónak szánt adatok megfelelő formában való megjelenítése is itt történik.
Controller (magyarul vezérlő): Ez a réteg a vezérlőelemek eseményeinek alapján meghívja a modell megfelelő függvényeit, illetve ha a megjelenítésben érintett adatok változnak, akkor erről értesíti a Nézetet. Általában itt kap helyet az üzleti logika.

Az MVC modell
Az alkalmazást három egységre bontjuk. Külön egység felelős a megjelenítésért, az adatok kezeléséért valamint a felhasználói cselekedetek megfelelő kezeléséért. Ez több okból is jó nekünk, legelőször is, ha lecseréljük valamelyik részt, akkor a többi még maradhat, nem kell hozzányúlni, több időnk marad (munkaidőben játszani:). Könnyebben módosíthatjuk az egyes részeket.
Az MVC egyik fő újítása az volt, hogy lehetővé tette, hogy egy modellhez több nézet is tartozzon. Minden nézet ugyanannak a modellnek a belső állapotát jeleníti meg. Bármelyik nézeten lenyomnak egy gombot, az az esemény eljut a kontrollerhez. A kontroller meghívja a modell megfelelő metódusát. Ha e miatt a modell belső állapota megváltozik, akkor a modell a megfigyelő tervezési mintának megfelelően értesíti a nézeteket, hogy változás történt, nekik is meg kell változni.

Az MVVM modell
Az MVC mintának több továbbfejlesztése is létezik. Ezek közül a két legismertebb:
MVP – Model View Presenter, magyarul Modell – Nézet – Megjelenítő: Ebben a változatban a modell nem a nézetet, hanem a megjelenítőt értesíti, ha változás történik. A megjelenítő lekéri az adatokat a modellből, feldolgozza, és megformázza a nézet számára. A nézet nem lép interakcióba az üzleti logikával.
MVVM – Model View View-Model, magyarul Modell – Nézet – Nézetmodell: Ez az MVP továbbfejlesztése, ahol a nézetben a lehető legkevesebb logika van. A nézetmodell elvégez minden feladatot a nézet helyett, csak a megjelenítés marad a nézetre.
Többrétegű architektúra
Réteg alatt a program olyan jól elszeparált részét értjük, amely akár külön számítógépen futhat. A rétegek jól definiált interfészeken keresztül kommunikálnak, mindig csak a felettük és alattuk lévő réteggel kommunikálhatnak. A rétegek annyira lazán csatoltak a többihez, hogy egy réteg a többi réteg számára észrevétlenül lecserélhető, feltéve, hogy ugyanazt az interfészt használja, mint az elődje.
A többrétegű architektúra akárhány rétegből állhat. Minél több a rétegek száma, annál rugalmasabb a rendszer, de ezzel szembeható, hogy annál nehezebb a karbantartása. A legismertebb többrétegű architektúra a 3 rétegű (angolul: 3-tier programming). Itt a három réteg:
Felhasználói felület
Üzleti logika
Adatbázis
A felhasználói felület gyakran grafikus, így csak a GUI (angolul: Graphical User Interface) rövidítéssel hivatkozunk rá. Az üzleti logikát (angolul: business logic) angol neve után gyakran BL-nek rövidítjük. Az adatbázis (angolul: database) réteget gyakran perzisztencia rétegnek hívjuk és általában DB-nek rövidítjük az angol neve után.
Hiba azt gondolni, hogy a háromrétegű architektúra csak az MVC minta másik neve. Az első esetén a felhasználói felület nem kommunikálhat az adatbázisréteggel, tehát ez egy lineáris rendszer a kommunikáció útját tekintve. Ezzel szemben az MVC háromszög alakú, hiszen a modell közvetlenül értesíti a nézeteket, ha megváltozik.
A 3 rétegű architektúra általában három számítógépet használ:
kliens
alkalmazásszerver
adatbázisszerver
A kliens lehet vastag vagy vékony kliens. A vékony kliens csak egy böngésző, illetve a benne futó weboldal. A vastag kliens egy általában C# vagy Java nyelven megírt önálló alkalmazás. Mindkettőnek van előnye és hátránya:
Vékony kliens
Vastag kliens
Szegényes felhasználói élmény.
Gazdag felhasználói élmény.
Nem kell frissíteni. Nem kell a frissítéseket eljuttatni a felhasználóhoz.
Hibajavítás, új verzió kiadása csak frissítéssel lehetséges.
Kicsi hardverigény.
Magas hardverigény.
A kliens számítógép erőforrásai csak részben állnak rendelkezésére.
A kliens számítógép erőforrásaihoz hozzáférhet, pl. állományt írhat, olvashat.
Fő hátránya a szegényes felhasználó élmény, de ez AJAX technológiával gazdagabbá tehető.
Fő hátránya a nehézkes frissítés, de ez történhet automatikusan is, ha van internetkapcsolat.

Látható, hogy a két technológia előnyei és hátrányai kezdenek kiegyenlítődni, ezért a vékony kliens használata egyre terjed.

A háromrétegű szoftver architektúra
Az alkalmazásszerveren (hardver értelemben) JavaEE platform esetén alkalmazásszerver (szoftver értelemben) fut. Ez megkönnyíti az alkalmazás fejlesztését, mert néhány szerverfunkciót, pl. a terheléselosztást (angolul: load balancing) megold helyettünk az alkalmazásszerver.
Lecke 9.: Létrehozási tervezési minták
A lecke célja és tartalma
Célok, megszerezhető kompetenciák: A lecke végére megismerkedünk néhány létrehozási tervezési mintával egy-egy példán keresztül.
Szükséges eszközök, források: A GOF könyv. A Head First Design Patterns könyv.
Feldolgozási idő: 90 perc.
Témakörök: Létrehozási tervezési minták, Egyke, Prototípus, Gyártómetódus, Absztrakt gyár.
A lecke tartalma: Ebben a leckében áttekintjük a 4 legegyszerűbb létrehozási tervezési mintát, úgy mint: Egyke, Prototípus, Gyártómetódus, Absztrakt gyár. A létrehozási tervezési minták fő feladata, hogy a példányosítás folyamatát egységbe zárják, így, ha módosul a létrehozás folyamata, akkor azt csak egy helyen kell megváltoztatni.
Bevezetés
A létrehozási tervezési minták olyan tervezési minták, amelyek objektumok gyártásának bevált módszereit mutatják be.
A létrehozási minták feladata, hogy megszüntessék a sok, new kulcsszóval ránk szakadó függőséget. Ha úgy írjuk meg a programunkat, hogy mindenhová a new Kutya() hívást írjuk, amikor Kutya példányra van szükségünk, akkor nehéz lesz ezt lecserélni egy későbbi new SzuperKutya() hívásra. Jobban járunk, ha a „gyártást” a létrehozási mintákra hagyjuk és például így készítjük a kutyáinkat: kutyaGyár.createKutya(). Ilyenkor, ha változnak a követelmények, akkor csak egy helyen kell változtatni a létrehozás módját, ott, ahol létrehozzuk a kutyaGyár példányt.
Egyke – Singleton
Gyakori feladat, hogy egy osztályt úgy kell megírnunk, hogy csak egy példány lehet belőle. Ez nem okoz gondot, ha jól ismerjük az objektumorientált programozás alapelveit. Tudjuk, hogy az osztályból példányt a konstruktorával készíthetünk. Ha van publikus konstruktor az osztályban, akkor akárhány példány készíthető belőle. Tehát publikus konstruktora nem lehet az egykének. De ha nincs konstruktor, akkor nincs példány, amin keresztül hívhatnánk a metódusait. A megoldás az osztályszintű metódusok. Ezeket akkor is lehet hívni, ha nincs példány. Az egykének van egy osztályszintű szerezPéldány (angolul: getInstance) metódusa, ami mindenkinek ugyanazt a példányt adja vissza. Ezt a metódust szokás globális hozzáférési pontnak is hívni. Természetesen ezt a példányt is létre kell hozni, de a privát konstruktort a szerezPéldány hívhatja, hiszen ő is az egyke osztály része. Forráskód:
using System;
namespace Singleton
{
    public class Singleton
    {
        // statikus mező az egyetlen példány számára
        private static Singleton uniqueInstance=null;
        // privát konstruktor, hogy ne lehessen 'new' kulcsszóval példányosítani
        private Singleton() { }
        // biztosítja számunkra a példányosítást és egyben visszaadja a példányt
        // mindenkinek ugyanazt
        public static Singleton GetInstance()
        {
            if (uniqueInstance==null) // megvizsgálja, hogy létezik-e már egy példány
            {  
                uniqueInstance = new Singleton(); // ha nem, akkor létrehozza azt
            }
            // visszaadja a példányt
            return uniqueInstance;
         }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //a konstruktor private, nem lehet new kulcsszóval példányosítani
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();
            // Teszt: ugyanaz a példány-e a kettő?
            if (s1 == s2)
            {
                Console.WriteLine("Ugyanaz! Tehát csak egy példány van.");
            }
            Console.ReadKey();
        }
    }

Szálbiztos megoldás
using System;
namespace SingletonThreadSafe
{
    public sealed class Singleton
    {
        // A statikus konstruktor akkor fut le, amikor az osztályt példányosítjuk,
        // vagy statikus tagra hivatkozunk ÉS egy Application Domain alatt 
        // (értsd: adott program futásakor) maximum egyszer futhat le.
        private static readonly Singleton instance = new Singleton();
        // privát konstruktor külső 'new' példányosítás ellen 
        private Singleton() { }
        // statikus konstruktor
        // Azon osztályok, melyek nem rendelkeznek statikus 
        // konstruktorral beforefieldinit attribútumot
        // kapnak az IL kódban. A statikus tagok inicializációja 
        // a program kezdetén azonnal megtörténik. 
        // Az olyan osztályok, amelyeknek van statikus konstruktora 
        // ezt nem kapják meg,
        // ezért a statikus tagok akkor példányosulnak,
        // amikor először hivatkozunk az osztályra,
        // vagyis jelen esetben amikor elkérjük a példányt.
        static Singleton() { }
        public static Singleton GetInstance { return instance; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();
            if (s1 == s2) { Console.WriteLine("OK"); }
            Console.ReadKey();
        }
    }
}
UML ábrája:

Példa UML ábra az Egyke tervezési minta
PlantUML szkriptje:
@startuml
class Singleton {
 - Singleton()
 - {static} Singleton instance = new Singleton();
 + {static} GetInstance() { return instance;}
}
note right of Singleton
A konstruktor privát, így nem
lehet másik példányt létrehozni kívülről.
Egyetlen mezőjében tárolódik a példány, 
mindenki ezt kapja vissza a
GetInstance() metóduson keresztül.
Hívása: Singleton.GetInstance();
end note
@enduml
Gyakorlófeladat: Készítsünk forráskódot az alábbi leírás szerint. A megoldáshoz használjuk az egyke tervezési mintát!
Feladat: Hozzon létre egy olyan Híváslista osztályt, amelyből csak egy lehet. Gondoljon bele, hogy van-e értelme több Híváslista példányt tárolni a telefonján? Ha igen, miért, ha nem, miért nem?
Mivel nincs értelme több Híváslista példányt tárolni, ezért eleve úgy kell létrehozni az osztályt, hogy abból csak egy példány lehessen és mindenki ezt az egy példányt érhesse csak el, egy úgynevezett globális hozzáférési ponton keresztül.
Gondolja végig, hogy egy ilyen osztály hogyan nézhet ki és válaszoljon az alábbi kérdésekre:
Lehet publikus konstruktora ennek az osztálynak?
Ha nem lehet, akkor hogyan hozzuk létre belőle példányt, hiszen azt konstruktorhívással lehet csak?
Ha kívülről nem hívható, attól még belülről hívható?
Ha belülről meghívhatja egy metódus, akkor azt a metódust kellene meghívni?
Csakhogy egy példányszintű metódus meghívásához kellene példány, de ahhoz pedig példányosítani kellene, amit nem lehet. Hogyan lehet ezt feloldani?
Ha ez osztály szintű metódussal megoldható, akkor hogyan kell ennek a metódusnak kinéznie?
Hívhatjuk ezt globális hozzáférési pontnak?
Az egyes kérdésekre a válaszok:
Nem lehet, mert akkor akárhány példányt lehetne belőle készíteni. Figyelem, ha nem írunk konstruktor, akkor az osztálynak van egy automatikus konstruktora, amely nulla paraméteres és publikus, ezért kell írni egy nem publikus, mondjuk privát konstruktort, ami akár lehet üres is.
Attól, hogy nincs publikus konstruktor, attól van konstruktora, tehát példányosítani is lehet, igaz ez a konstruktor csak belülről hívható.
Igen, belülről minden metódus hívható, akármilyen is a láthatósági szintje.
Igen, ez jó megoldás. Arra kell figyelni, hogy a konstruktor által adott új példányt vissza kell adni.
Amíg nem tudunk példányt csinálni, addig nem lehet példányszintű metódust se hívni. Ez úgy oldható fel, hogy osztályszintű metódusra bízzuk a példányosítást, hiszen osztályszintű metódus hívásához nem kell példány.
Ez már egyszerű, megnézi, hogy létezik-e már a példány, ha nem, akkor létrehozza, egyébként pedig mindenkinek ugyanazt a példányt adja vissza. Lásd az osztály megvalósítását.
Igen, az ilyen metódust globális hozzáférési pontnak hívjuk, illetve magát az osztályt Egykének (angolul: Singleton).
A fenti gondolatmenetből jól látható, hogy az egyke tervezési mintát kell használni, hiszen:
Van egy private vagy protected konstruktora, nincs public konstruktora.
Van egy Egyke típusú osztály szintű metódusa, aminek szokásos neve „instance”.
Van egy publikus Egyke típusú metódusa, amely mindig ugyanazt a példányt (az instance nevű mezőt) adja vissza. Ha ez a példány még null, akkor előtte példányosítja. Ezt a metódust hagyományosan „GetInstance()” metódusnak hívjuk.
Ezen kívül kellenek feladat specifikus példány szintű mezők és metódusok. A fenti példa esetén egy Híváslista típusú mező és az ezt visszaadó get metódus kell.
A feladat megoldásához készítsen főprogramot, amely lekéri kétszer is az Egykéből a híváslitást. Adjunk hozzá ez egyikhez egy hívásást, listázzuk ki a másikat. Vegye észre, hogy ha egyiket szerkesztjük, a másik is változik, hiszen a két lista ugyanoda mutat, hiszen csak egy Híváslista példány van, mindenki azt használja.
Vegye észre továbbá, ez a minta általában minden ilyen feladatra használható. Például minden nyomtatóhoz csak egy nyomtatási sor tartozik, tehát ez is egy egyke.
Vegye észre továbbá, hogy az Egyke.GetInstance() hívások new kulcsszóval történő példányosításokat helyettesítenek.
Prototípus – Prototype
A prototípus (angolul: prototype) egy létrehozási tervezési minta, amely egy prototípus klónozásával gyárt objektumokat. A klónok a prototípus pontos másolatai, de saját memória címük van, így a klón megváltoztatása nem változtatja meg a prototípust. Ez a tervezési minta mély klónozást (angolul: deep copy) használ.
A klónozás (angolul: clone) az a programozási technika, amikor a klónozandó objektummal teljesen megegyező új objektumot hozunk létre, azaz a két objektum belső állapota ugyanaz lesz. Az új objektum részben vagy teljesen független az a klónozott objektumtól.
A prototípus tervezési minta fő technikája, mint láttuk, a klónozás. A klónozás feladata, hogy az eredeti objektummal megegyező objektumot hozzon létre. Erre az egyszerű értékadás nem alkalmas, mert azok csak az objektum referenciáját másolják, így a két referencia ugyanoda mutat. A klónozásnak két fajtája van:
sekély klónozás (angolul: shallow copy): A klónozásnak az a fajtája, amikor az eredeti objektum referencia típusú mezőit csak másoljuk (a két referencia ugyanoda fog mutatni), így az új klón csak részben lesz független az eredeti objektumtól.
mély klónozás (angolul: deep copy): A klónozásnak az a fajtája, amikor az eredeti objektum referencia típusú mezőit is klónozzuk (a két referencia nem ugyanoda mutat), így az új klón teljesen független lesz az eredeti objektumtól. A megváltoztathatatlan (angolul: immutable) mezőket, mint például a string típusúakat, nem érdemes klónozni.
A különbség a sekély és a mély klónozás közt az, hogy sekély esetben az osztály referenciáit ugyanúgy másoljuk, mint az elemi típusait. Mély klónozásnál az osztály referenciái által mutatott objektumokat is klónozzuk. Nézzük ezt meg egy konkrét példán:
    class Ember
    {
        private String név;
        private Ember[] barátok;
        public Ember DeepCopy()
        {
            Ember clone = new Ember();
            clone.név = név;
            clone.barátok = (Ember[])barátok.Clone();
            return clone;
        }
        public Ember ShallowCopy()
        {
            Ember clone = new Ember();
            clone.név = név;
            clone.barátok = barátok;
            return clone;
        }
        public Ember ShallowCopy2() 
        { 
            return (Ember)MemberwiseClone(); 
        }
    }
A sekély klónozást a C# nyelv a MemberwiseClone() metódussal segíti, ami az Object osztály része, így minden osztály örökli. Ezért tudtunk a sekély klónozásra két verziót adni a fenti példában.
Példa: A prototípus mintát egy példán keresztül mutatjuk be: Hurrá, a magyar gépkocsigyártás újra feléledt, legalábbis a példánk kedvéért. Megjött a befektetők, és utasítást adtak a tehergépkocsi gyártás beindítására! Kis csapatunk összedugja a fejét és úgy dönt, mer nagyban gondolkodni. Amennyiben sikeres lesz a teherautó üzletág, akkor megvehetjük a méltán híres Porsche és Aston Martin márkákat a profitból. Ezért, gondolva a jövőre, első körben egy általános gépkocsi osztályt hoznak létre, mely azokat a tulajdonságokat tartalmazza, amik minden négy vagy több kerekű gépesített járműre jellemzőek. Ebből az osztályból öröklődik a nagy és erős tehergépkocsi, melynek csak pár speciális tulajdonságát kell beállítanunk. Majd, ha a zsebünk tele lesz a teherautó eladás bevételeiből, és végre megvettük a fent említett márkákat, könnyű dolgunk lesz az implementáció során, hiszen egy új osztályban beállítjuk a sportkocsi végsebességét, a tankméretet kisebbre vesszük és indulhat a sorozatgyártás a gyáron keresztül, és a határ a csillagos ég, vagy a Forma 1! A gyártósor egy prototípust vár. Mindegy, hogy milyen Gépkocsit kap, mindent tud gyártani, mert csak klónozza a prototípust. A klónozáson túl csak festeni tud. Szóval a gyár buta, de hatékony.
A lenti forráskódban figyeljük meg, hogy sekély klónozást használunk. Ezt kétféleképen is megírtuk. Ha a MemberwiseClone() segítségével oldjuk meg, akkor elegendő az ősbe megírni a Clone() metódust. Egyébként minden alosztályban meg kell írni. Ezt a megoldást a lenti megoldásban megjegyzések formájában látjuk. Forráskód:
using System;
namespace Prototípus
{
    public abstract class Gépkocsi : ICloneable
    {
        private string tipus;
        public string Tipus
        {
            get { return tipus; }
            set { tipus = value; }
        }
        private int utasokSzama;
        public int UtasokSzama
        {
            get { return utasokSzama; }
            set { utasokSzama = value; }
        }
        private double tankMeret;
        public double TankMeret
        {
            get { return tankMeret; }
            set { tankMeret = value; }
        }
        private string szin;
        public string Szin
        {
            get { return szin; }
            set { szin = value; }
        }
        public Gépkocsi(string tipus, int utasokSzama, double tankMeret)
        {
            this.tipus = tipus;
            this.utasokSzama = utasokSzama;
            this.tankMeret = tankMeret;
        }
        public object Clone() { return this.MemberwiseClone(); }
        /*
        public virtual object Clone() 
        {
            Gépkocsi uj = new Gépkocsi(Tipus, UtasokSzama, TankMeret);
            uj.Szin = Szin;
            return uj;
        }*/
        public override string ToString()
        {
            return tipus + " " + utasokSzama + " " + tankMeret + " " + szin;
        }
    }
    public class Versenyautó : Gépkocsi
    {
        private int vegsebesseg;
        public int Vegsebesseg
        {
            get { return vegsebesseg; }
            set { vegsebesseg = value; }
        }
        public Versenyautó(string t, int u, double tm, int vegsebesseg) :
            base(t, u, tm) { this.vegsebesseg = vegsebesseg; }
        /*
        public override object Clone()
        {
            Versenyautó uj = 
                new Versenyautó(Tipus, UtasokSzama, TankMeret, Vegsebesseg);
            uj.Szin = Szin;
            return uj;
        }*/
        public override string ToString()
        {
            return base.ToString() + " " + vegsebesseg;
        }
    }
    public class Teherautó : Gépkocsi
    {
        private double teherbiras;
        public double Teherbiras
        {
            get { return teherbiras; }
            set { teherbiras = value; }
        }
        public Teherautó(string t, int u, double tm, double teherbiras)
            : base(t, u, tm) { this.teherbiras = teherbiras; }
        /*
        public override object Clone()
        {
            Teherautó uj =
                new Teherautó(Tipus, UtasokSzama, TankMeret, Teherbiras);
            uj.Szin = Szin;
            return uj;
        }*/ 
        public override string ToString()
        {
            return base.ToString() + " " + Teherbiras;
        }
    }
    public class Gyar
    {
        public Gépkocsi[] sorozatgyartas(Gépkocsi g, string sz, int db)
        {
            Gépkocsi[] temp = new Gépkocsi[db];
            for (int i = 0; i < db; i++)
            {
                temp[i] = (Gépkocsi)g.Clone();
                temp[i].Szin = sz;
            }
            return temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //a versenyautó és a teherautó prototípus létrehozása
            Gépkocsi prototipus1 = new Versenyautó("Aston Martin", 4, 180, 220);
            Gépkocsi prototipus2 = new Teherautó("Csepel", 3, 200, 1000);
            Gyar gyartosor = new Gyar();
            // legyárt 10 piros versenyautót
            Gépkocsi[] vk = gyartosor.sorozatgyartas(prototipus1, "Piros", 10);
            foreach (Versenyautó v in vk) { Console.WriteLine(v); }
            // legyárt 20 szürke teherautót
            Gépkocsi[] tk = gyartosor.sorozatgyartas(prototipus2, "Szürke", 20);
            foreach (Teherautó t in tk) { Console.WriteLine(t); }
            Console.ReadLine();
        }
    }
}
UML ábra:

Példa UML ábra a prototípus tervezési mintára
PlantUML szkript:
@startuml
interface ICloneable {
+ Object Clone()
}
class Gépkocsi {
- String _Szin
- int _UtasokSzama
- double _Tankmeret
--
+Object Clone() {return MemberwiseClone();}
--properties--
+String Szin()
+int UtasokSzama()
+double Tankmeret()
}
class Versenyautó {
- int _Végsebesség
--properties--
+ int Végsebesség()
}
class Teherautó {
- double _Teherbírás
--properties--
+double Teherbírás()
}
Gépkocsi .right.|> ICloneable
Gépkocsi <|-down- Teherautó
Gépkocsi <|-down- Versenyautó
entity prototipus1:Versenyautó {
+Object Clone()
--properties--
+String Szin()
+String Tipus()
+int UtasokSzama()
+int Végsebesség()
}
Versenyautó .. "prototipus1:Versenyautó" : new Versenyautó("Aston Martin", 4, 180, 220);
note right of "prototipus1:Versenyautó"
 Ez a prototípus.
 Ezt fogjuk tömeggyártásba vonni.
end note
@enduml
Gyakorlófeladat: Készítsünk forráskódot az alábbi leírás szerint. A megoldáshoz használjuk a prototípus tervezési mintát!
Feladat: Készítsünk telefon gyárat. A telefongyárnak átadunk egy minta telefont, amit egy az egyben lemásol. A másolat megy tovább a szalagon, ahol egyedi tulajdonságokat kap, mint pl. a szín.
Ennek a feladatnak a megoldásához azt kell végiggondolni, hogy hogyan lehet tökéletesen lemásolni egy bonyolult objektumot. Szerencsére erre van megoldás objektumorientált programozásban, a klónozás, illetve a klónozást alkalmazó prototípus tervezési minta.
Telefon osztály:
A telefon funkcionalitását megvalósító mezők és metódusok.
Egyedi tulajdonságok mezői, pl. szín, típus.
SetSzín(szín): Beállítja a szín mezőt.
Clone(): mélységi klónozás (angolul: deep copy) segítségével lemásolja az telefont és visszaadja tökéletes másolatát.
TelefonGyár osztály:
prototípus: a gyártáshoz szükséges prototípus.
SetPrototípus(prototípus): beállítja a prototípus mezőt.
Gyárt(szín): lemásolja a prototípust a prototípus.Clone() hívással, majd a másolatnak beállítja a színét és visszaadja a másolatot.
Főprogram: Hozzunk létre egy telefont. Hozzunk létre egy telefongyárat gyár néven. A gyárnak adjuk át a telefont. Gyártsunk a prototípus alapján 10 kék és 5 piros telefont.
Vegye észre, hogy minden gyár.Gyárt(szín) metódushívás kivált egy new kulcsszóval történő példányosítást. Ha a példányosítás menete változik, pl. minden telefonnak egyedi szériaszámot kell adnia, akkor ezt elég a Gyárt metódusba lekódolni, míg a másik esetben minden new után bele kellene illeszteni ezt a kódba.
Gyártómetódus – Factory Method
A gyártómetódus (angolul: factory method) egy létrehozási tervezési minta. Ezzel a mintával lehet szépen kiváltani a programunkban lévő rengeteg hasonló new utasítást. A minta leírja, hogyan készítsünk gyártómetódust. Ezt magyarul gyakran készít, angolul a create szóval kezdjük. A gyártómetódus a nevében magadott terméket adja vissza, tehát a készítKutya (angolul: createDog) egy kutyát, a készítMacska (angolul: createCat) egy macskát. Ez azért jobb, mint a new Kutya() vagy a new Macska() konstruktor hívás, mert itt az elkészítés algoritmusát egységbe tudjuk zárni. Ez azért előnyös, mert ha a gyártás folyamata változik, akkor azt csak egy helyen kell módosítani. Általában a gyártás folyamata ritkán változik, inkább az a kérdés mit kell gyártani, azaz ez gyakran változik, ezért ezt az OCP elvnek megfelelően a gyermekosztály dönti el.
Tehát az ősben lévő gyártómetódus leírja a gyártás algoritmusát, a gyermekosztály eldönti, hogy mit kell pontosan gyártani. Ezt úgy érjük el, hogy az algoritmus háromféle lépést tartalmazhat:
A gyártás közös lépései: Ezek az ősben konkrét metódusok, általában nem virtuálisak, illetve Java nyelven final metódusok.
A gyártás kötelező változó lépései. Ezek az ősben absztrakt metódusok, amiket a gyermek felülír, hogy eldöntse, hogy mit kell gyártani. A gyermekosztályok itt hívják meg a termék konstruktorát.
A gyártás opcionális lépései: Ezek az ősben horog (angolul: hook) metódusok, azaz a metódusnak van törzse, de az üres. Ezeket az OCP elv megszegése nélkül lehet felülírni az opcionális lépések kifejtéséhez.
Jó példa a gyártómetódusra az Office csomag alkalmazásaiban lévő Új menüpont. Ez minden alkalmazásban létrehoz egy új dokumentumot és megnyitja. A megnyitás közös, de a létrehozás más és más. A szövegszerkesztő esetén egy üres szöveges dokumentumot, táblázatkezelő esetén egy üres táblázatot kell létrehozni.
Érdekes megfigyelni, hogy az absztrakt ős és a gyermekosztályai IoC (angolul: Inversion of Control) viszonyban állnak. Azaz nem a gyermek hívja az ős metódusait, hanem az ős a gyermekét. Ezt úgy érjük el, hogy a gyártómetódus absztrakt-, illetve virtuális metódusokat hív. Amikor a gyermekosztály példányán keresztül hívjuk majd a gyártómetódust, akkor a késői kötés miatt ezen metódusok helyett az őket felülíró gyermekbéli metódusok fognak lefutni. Forráskód:
using System;
namespace FactoryMethod
{
     abstract class MinositesGyar
     {
        public Minosites CreateMinosites()
        {
            // itt a gyártás előtt lehet ezt-azt csinálni, pl. logolni
            return Minosit();
        }
        public abstract Minosites Minosit();
    }
    class KonkretMinositesGyar1 : MinositesGyar
    {
        public override Minosites Minosit() { return new A_Minosites(); }
    }
    class KonkretMinositesGyar2 : MinositesGyar
    {
        public override Minosites Minosit() { return new B_Minosites(); }
    }
    interface Minosites { void Minosit(); }
    class A_Minosites : Minosites
    {
        public void Minosit() { Console.WriteLine("A-mínősítésben részesül!"); }
    }
    class B_Minosites : Minosites
    {
        public void Minosit() { Console.WriteLine("B-minősítésben részesül!"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MinositesGyar[] minosito = new MinositesGyar[2];
            minosito[0] = new KonkretMinositesGyar1();
            minosito[1] = new KonkretMinositesGyar2();
            foreach (MinositesGyar m in minosito)
            {
                Minosites minosites = m.CreateMinosites();
                minosites.Minosit();
            }
            Console.ReadLine();
        }
    }
}
UML ábra:

Példa UML ábra a gyártómetódus tervezési mintára
PlantUML szkript:
@startuml
interface Minősítés {
  + void Minősít()
}
class A_Minősítés {
  + void Minősít()
}
class B_Minősítés {
  + void Minősít()
}
abstract class MinősítésGyár {
  + {abstract} Minősítés Minősít() {lépés_1(); lépés_2(); return lépés_3();}
  - void lépés_1() {...}
  # virtual void lépés_2() {}
  # abstract Minősítés lépés_3();
}
class KonkrétMinősítőGyár1 {
  # override void lépés_2() {...}
  # override Minősítés lépés_3() {...; return new A_Minősítés();}
}
class KonkrétMinősítőGyár2 {
  # override void lépés_2() {...}
  # override Minősítés lépés_3() {...; return new A_Minősítés();}
}
note "Az ős a gyártás lépéseinek sorrendjét adja meg. A lépéseket a gyermek osztályok fejtik ki." as N1
Minősítés <|.. A_Minősítés
Minősítés <|.. B_Minősítés
MinősítésGyár <|-- KonkrétMinősítőGyár1
MinősítésGyár <|-- KonkrétMinősítőGyár2
KonkrétMinősítőGyár1 .up.> A_Minősítés : <<create>>
KonkrétMinősítőGyár2 .up.> B_Minősítés : <<create>>
KonkrétMinősítőGyár1 .. N1
KonkrétMinősítőGyár2 .. N1
@enduml
Gyakorlófeladat: Készítsünk forráskódot az alábbi leírás szerint. A megoldáshoz használjuk a gyártómetódus tervezési mintát!
Feladat: Ma reggel az egyik programozónk, aki egyébként teljesen normális, azzal állt elő, hogy gazoljuk ki a „new” szócskát a kódjainkból. Először azt gondoltuk, hogy nem itta meg a reggeli kávéját és majd rendbe jön, de azután újragondoltunk a dolgokat. Mit is jelent a „new”? Azt, hogy hozzákötöttük magunkat egy konkrét osztályhoz, amivel nincs is semmi baj, amíg nem gondolunk a: „programozz interfészre”, illetve a „nyílt a változásra, de zárt a módosításokra” varázsszavakra. Kapóra jött az új ötlet kipróbálásához a nemrég érkezett megrendelés, melyben egy zsíros kenyér franchise hálózatot kellett kidolgozni. A csomagolásnak országos szinten egyformának kell lennie, de a kenyeret vidékenként más-más vastagságúra vágják, még Pest és Buda között is különbség van, és akkor még nem szóltunk a különböző típusokról, kacsazsíros, libazsíros stb. Két absztrakt osztályt hoztunk létre, egyet a boltnak, egyet a terméknek. Esetünkben ez a ZsírosDeszka. A boltban kidolgoztuk a csomagol függvényt az egyencsomagolásért, de az elkészítés függvényét absztrakt típusúra vettük. Egyszóval rábíztuk a konkrét boltra, milyen vastagra vágja a kenyeret, mennyi zsírt ken rá. A másik osztályt a termékért hoztuk létre. Mert mi kell a zsíros deszkához? Kenyér, zsír, só, hagyma, de csak a kenyérből legalább nyolc félét tudunk egy ültő helyünkben felsorolni. Így a nyíregyházi bolt tud gyártani nyíregyházi stílusú zsíros kenyeret. Szóval, ha zsíros kenyeret kell gyártanunk Kecskeméten a kódunk kb. így fog kinézni: ZsírosDeszka zsírosKenyér = KecskemétiBolt.készítZsírosDeszka();.
Absztrakt gyár – Absztrakt Factory
Az Absztrakt gyár (angolul: Absztrakt Factory) egy létrehozási tervezési minta, amely olyan objektumok gyártására jó, amelyek képesek egymással együttműködni, ennek megfelelően több létrehozásra alkalmas metódust (angolul: create method) tartalmaz.
Ez azt jelenti, hogy akkor érdemes absztrakt gyárat használni, ha egyszerre több dolgot gyárt a gyárunk, és azoknak egymással kompatibilisnek kell lenniük. Azaz, ha gyártunk alvázat és motort, akkor azoknak összeépíthetőnek kell lenniük. Forráskód:
using System;
namespace AbstractFactory
{
    abstract class Alváz { }
    class OpelAlváz : Alváz { }
    class MerciAlváz : Alváz { }
    abstract class Motor { }
    class OpelMotor : Motor { }
    class MerciMotor : Motor { }
    abstract class AutóGyár
    {
        public abstract Alváz CreateAlváz();
        public abstract Motor CreateMotor();
    }
    class OpelGyár : AutóGyár
    {
        public override Alváz CreateAlváz() { return new OpelAlváz(); }
        public override Motor CreateMotor() { return new OpelMotor(); }
    }
    class MerciGyár : AutóGyár
    {
        public override Alváz CreateAlváz() { return new MerciAlváz(); }
        public override Motor CreateMotor() { return new MerciMotor(); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AutóGyár gyár = new OpelGyár();
            Alváz alváz1 = gyár.CreateAlváz();
            Motor motor1 = gyár.CreateMotor();
        }
    }
}
Gyakorlófeladat: Készítsünk forráskódot az alábbi leírás szerint. A megoldáshoz használjuk az absztrakt gyár tervezési mintát!
Feladat: A telefon részegységekből áll: kijelző, akkumulátor, panel. Egy konkrét telefon csak a hozzá való részegységekből építhető fel. Készítsen X123 és Y987 telefon gyártására alkalmas gyárakat.
Mielőtt nekilát a feladatnak, vegye észre, hogy mindkét gyárnak gyártania kell minden részegységet, tehát minden gyárnak lesz GyártAkkumulátor() metódusa. Ezért ezek kiemelhetőek egy közös ősbe, az absztrakt gyárba.
Absztrakt alkatrész osztályok:
AbsztraktKijelző: A kijelző alkatrészek közös őse.
AbsztraktAkkumulátor: Az akkumulátorok közös őse.
AbsztraktPanel: A panelek közös őse.
AbsztraktGyár osztály:
GyártKijelző(): absztrakt metódus, visszatérési típusa AbsztraktKijelző.
GyártAkkumulátor(): absztrakt metódus, visszatérési típusa AbsztraktAkkumulátor.
GyártPanel(): absztrakt metódus, visszatérési típusa AbsztraktPanel.
Konkrét alkatrész osztályok:
X123Kijelző: X123 típusú készülékhez való kijelző, őse az AbsztraktKijelző.
X123Akkumulátor: X123 típusú készülékhez való akkumulátor, őse az AbsztraktAkkumulátor.
X123Panel: X123 típusú készülékhez való panel, őse az AbsztraktPanel.
Y987Kijelző: Y987 típusú készülékhez való kijelző, őse az AbsztraktKijelző.
Y987Akkumulátor: Y987 típusú készülékhez való akkumulátor, őse az AbsztraktAkkumulátor.
Y987Panel: Y987 típusú készülékhez való panel, őse az AbsztraktPanel.
X123Gyár osztály:
GyártKijelző(): X123Kijelző típusú objektumot gyárt.
GyártAkkumulátor(): X123Akkumulátor típusú objektumot gyárt..
GyártPanel(): X123Panel típusú objektumot gyárt.
Y987Gyár osztály:
GyártKijelző(): Y987Kijelző típusú objektumot gyárt.
GyártAkkumulátor(): Y987Akkumulátor típusú objektumot gyárt..
GyártPanel():Y987Panel típusú objektumot gyárt.
Főprogram: Hozzon létre egy X123 és egy Y987 gyárat. Gyártson a segítségükkel különböző alkatrészeket.
Megjegyzés: Az alkatrészek összeszerelésére az Építő (angolul: Builder) tervezési minta a legalkalmasabb.
Vegye észre, hogy minden Gyárt szóval kezdődő metódus kivált egy-egy new kulcsszóval történő objektum létrehozást.
Összegzés és ellenőrző kérdések
Ebben a leckében áttekintettük a 4 legegyszerűbb létrehozási tervezési mintát, úgy mint: Egyke, Prototípus, Gyártómetódus, Absztrakt gyár. A létrehozási tervezési minták fő feladata, hogy a példányosítás folyamatát egységbe zárják, így, ha módosul a létrehozás folyamata, akkor azt csak egy helyen kell megváltoztatni.
Ellenőrző kérdések:
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
Lecke 10.: Szerkezeti tervezési minták
A lecke célja és tartalma
Célok, megszerezhető kompetenciák: A lecke végére megismerkedünk néhány szerkezeti tervezési mintával egy-egy példán keresztül.
Szükséges eszközök, források: A GOF könyv. A Head First Design Patterns könyv.
Feldolgozási idő: 90 perc.
Témakörök: Szerkezeti tervezési minták, Illesztő, Díszítő, Helyettes.
A lecke tartalma: Ebben a leckében áttekintjük a 3 legegyszerűbb szerkezeti tervezési mintát, úgy mint: Illesztő, Díszítő, Helyettes. A szerkezeti tervezési minták fő feladata, hogy megmutassák, hogyan kell használni az objektum-összetételt, hogy az elvárásainknak megfelelő futási ideje szerkezeteket tudjuk létrehozni.
Bevezetés
A szerkezeti tervezési minták arra adnak módszert, hogy hogyan használjuk az objektum-összetételt új objektum szerkezetek létrehozására. Ebben a fejezetben ezt a technikát gyakran becsomagolásnak (angolul: wrapping) nevezzük. Más megfogalmazásban a szerkezeti minták azt mutatják meg, hogy hogyan használjuk a gyakorlatban az objektum-összetételt, hogy az igényeinknek megfelelő objektumszerkezetek létrejöhessenek futási időben.
Ismétlésképp leírjuk az objektum-összetételnek, vagy más néven a HAS-A kapcsolatnak a fajtáit, amelyek a birtoklás módja szerint az aggregáció és a kompozíció, illetve a becsomagolás módja szerint az átlátszó és az átlátszatlan becsomagolás:
aggregáció: amikor az összetételben szereplő objektum nem kizárólagos tulajdona az őt tartalmazó objektumnak,
kompozíció: amikor kizárólagos tulajdona,
átlátszó csomagolás: amikor a tulajdonos ugyanolyan típusú, mint az összetételben szereplő objektum, és így a felületük ugyanolyan.
átlátszatlan csomagolás: amikor a tulajdonos nem ugyanolyan típusú, mint az összetételben szereplő objektum, és így a felületük más.
Illesztő – Adapter
Az illesztő (angolul: adapter) egy szerkezeti tervezési minta, amely átalakítja a becsomagolt objektum felületét a kívánt felületre. Ehhez nem átlátszó becsomagolást használ. Arra szolgál, hogy egy meglévő osztály felületét hozzá igazítsuk saját elvárásainkhoz. Leggyakoribb példa, hogy egy régebben megírt osztályt akarunk újrahasznosítani úgy, hogy beillesztjük egy osztályhierarchiába. Mivel ehhez hozzá kell igazítani az ős által előírt felülethez, ezért illesztőmintát kell használnunk.
A régi osztályt ilyen estben gyakran illesztendőnek (angolul: adaptee) hívjuk. Az illesztő és az illesztendő között általában kompozíció van, azaz az illesztő kizárólagosan birtokolja az illesztendőt. Ezt gyakran úgy is mondjuk, hogy az illesztő becsomagolja az illesztendőt. Ennek megfelelő az illesztőminta másik angol neve: Wrapper. Ugyanakkor ez a becsomagolás átlátszatlan, hiszen az illesztő nem nyújtja az illesztendő felületét.
Példa: Az alábbi példában az Ember osztályhierarchiába illesztjük bele a Robot osztályt a Robot2Ember osztály segítségével. Tehet a Robot az illesztendő (angolul: adaptee), a Robot2Ember az illesztő (angolul: adapter). Úgy is mondhatnánk, hogy a robotunkat emberként szeretnénk használni. A főprogramban ehhez az R2D2 nevű robotunkat becsomagoljuk egy Robot2Ember példányba.
Mivel az illesztő átkonvertálja az egyik felületet egy másikká, ezért gyakran Régi2Új nevet adunk az osztálynak. Példánkban Robot2Ember. Itt a 2 az angol „Two” szóra utal, amit ugyanúgy kell kiejteni, mint az angol „To” szót. Ez egy gyakori elnevezési konvenció a konverziót végző metódusokra, osztályokra. Forráskód:
using System;
abstract class Ember
{
    public abstract string GetNév();
    public abstract int GetIQ();
}
class Robot
{
    string ID;
    int memory; //memoria MB-ban megadva
    public Robot(string ID, int memory)
    {
        this.ID = ID;
        this.memory = memory;
    }
    public string GetID() { return ID; }
    public int GetMemory() { return memory; }
}
class Robot2Ember : Ember
{
    Robot robi;
    public Robot2Ember(Robot robi) { this.robi = robi; }
    public override string GetNév()
    {
        return robi.GetID();
    }
    public override int GetIQ()
    {
        return robi.GetMemory() / 1024; // 1GB memória = 1 IQ
    }
}
class Program
{
    static void Main(string[] args)
    {
        Robot R2D2 = new Robot("R2D2", 80000);
        Ember R2D2wrapper = new Robot2Ember(R2D2);
        Console.WriteLine("Neve: {0}", R2D2wrapper.GetNév());
        Console.WriteLine("IQ-ja: {0}", R2D2wrapper.GetIQ());
        Console.ReadLine();
    }
}
Díszítő – Decorator
A díszítő tervezési minta az átlátszó becsomagolás jó példája. Gyakran a karácsonyfa díszítés feladatán keresztül mutatjuk be: Attól, hogy a karácsonyfára felteszek egy gömböt, az még karácsonyfa marad, azaz a díszítés átlátszó. Ezt úgy érjük el, hogy az objektum-összetételben szereplő mindkét osztály ugyanazon őstől származik, azaz ugyanolyan típusúak. Ez azért hasznos, mert a díszítőelemek gyakran változnak, könnyen elképzelhető, hogy új díszt kell felvenni. Ha díszítő egy külön típus lenne, akkor a karácsonyfa-feldolgozó algoritmusok esetleg bonyolultak lehetnek.
A díszítőmintánál egy absztrakt ősből indulunk ki. Ennek kétfajta gyermeke van, alaposztályok, amiket díszíteni lehet és díszítőosztályok. A karácsonyfa példa esetén az alaposztályok a különböző fenyőfák. A díszítőosztályokat általában egy absztrakt díszítőosztály alá szervezzük, de ez nem kötelező.
A díszítés során az ős minden metódusát implementálni kell, úgy, hogy a becsomagolt példány metódusát meghívjuk, illetve ahol ez szükséges, ott hozzáadjuk a plusz funkcionalitást. Kétféle díszítésről beszélhetünk:
Amikor a meglévő metódusok felelősségkörét bővítjük. Ilyen a karácsonyfás példa.
Amikor új metódusokat is hozzáadunk a meglévőkhöz. Ilyen a Java adatfolyam (angolul: stream) kezelése, illetve a lenti kölcsönözhető jármű példája.
Mindkét esetben a példányosítás tipikusan így történik:
ŐsOsztály példány = new DíszítőN(…new Díszítő1( new AlapOsztály())…);
Az ilyen fajta teleszkópszerűen nyúló konstruktor hívás szerkezeteket teleszkópikus konstruktornak hívjuk.
Mivel a csomagolás átlátszó, ezért akárhányszor becsomagolhatjuk a példányunkat, akár egy díszítővel kétszer is. Ez rendkívül dinamikus, könnyen bővíthető szerkezetet eredményez, amit öröklődéssel csak nagyon sok osztállyal lehetne megvalósítani.
Érdekes megfigyelni a minta UML ábráján, hogy a díszítőosztályból visszafelé mutat egy aggregáció az ős osztályra. Ez az adatbázis-kezelés Alkalmazott – Főnök reláció megoldásához hasonlít, amikor az Alkalmazott tábla önmagával áll egy-több kapcsolatban, ahol a külső kulcs a főnök alkalmazott_ID értékét tartalmazza.
Példa: A díszítőmintát a következő példával mutatjuk be. Képzeljük el, hogy egy versenypályán üzemeltetünk egy autókölcsönzőt. Az autókölcsönzőben természetesen több típusú autót, többnyire versenyautót adunk kölcsönzésre. A lényeg, hogy előfordulhat az, hogy újabb autókkal bővítjük az állományt. Felkészülve erre, először egy alapautó-osztályt hoznak létre, amelyben a bérelhető autók információi szerepelnek, mint gyártó neve, a modell neve, a bérlés időtartama körökben számolva és a bérlés díja. A kölcsönzőben időnként akciókkal kedveskednek az ügyfeleknek, valamint változó, hogy egy bizonyos autó kölcsönözhető-e vagy sem. Ezen extrák hozzáadását a díszítőminta implementálásával tették lehetővé. Az alapautó-osztályból származik az alapdekorátor-osztály, mely elvégzi a becsomagolást. A konkrét díszítőosztályoknak már csak a funkciók kibővítésével kell foglalkozniuk. Amint egy autót feldíszítünk, mint kölcsönözhető, az már csak a bérlőjét várja, aki kiviszi a pályára. Az akciókat is díszítőosztályokkal valósíthatjuk meg. Látható, ha új autókkal bővül a parkunk, vagy újabb akciós ajánlatokat szeretnénk bevezetni, azt könnyedén megtehetjük, új konkrétautó és konkrétdíszítő osztályok hozzáadásával. Forráskód:
using System;
namespace DecoratorDesignPattern
{
    public abstract class VehicleBase // alap osztály, adott funkcionalitásokkal
    {
        public abstract string Make { get; }
        public abstract string Model { get; }
        public abstract double HirePrice { get; }
        public abstract int HireLaps { get; }
    }
    public class Ferrari360 : VehicleBase // egy konkrét autó
    {
        public override string Make { get { return "Ferrari"; } }
        public override string Model { get { return "360"; } }
        public override double HirePrice { get { return 100; } }
        public override int HireLaps { get { return 10; } }
    }
    public abstract class VehicleDecoratorBase : VehicleBase // a dekorátor osztály
    {
        private VehicleBase vehicle; // HAS-A kapcsolat, ezt csomagoljuk be
        public VehicleDecoratorBase(VehicleBase v) { vehicle = v; }
        public override string Make { get { return vehicle.Make; } }
        public override string Model { get { return vehicle.Model; } }
        public override double HirePrice { get { return vehicle.HirePrice; } }
        public override int HireLaps { get {return vehicle.HireLaps; } }
    }
    public class SpecialOffer : VehicleDecoratorBase // konkrét dekorátor osztály
    {
        public SpecialOffer(VehicleBase v) : base(v) { }
        public int Discount { get; set; }
        public int ExtraLaps { get; set; }
        public override double HirePrice
        {
            get
            {
                double price = base.HirePrice;
                int percentage = 100 - Discount;
                return Math.Round((price * percentage) / 100, 2);
            }
        }
        public override int HireLaps { get { return (base.HireLaps + ExtraLaps); } }
    }
    public class Hireable : VehicleDecoratorBase
    {
        public Hireable(VehicleBase v) : base(v) { }
        public void Hire(string name)
        {
            Console.WriteLine("{0} {1} típust kölcsönzött {2} {3}$-ért {4} körre.\r\n", Make, Model, name, HirePrice, HireLaps);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ferrari360 car = new Ferrari360();
            Console.WriteLine("Alap Ferrari360:\r\n");
            Console.WriteLine("Alap ár: {0}, alap tesztkörök száma: {1}\r\n\r\n", car.HirePrice, car.HireLaps);
            SpecialOffer offer = new SpecialOffer(car);
            offer.Discount = 25;
            offer.ExtraLaps = 2;
            Console.WriteLine("Speciális ajánlat:\r\n");
            Console.WriteLine("Különleges ajánlat ára: {0}, {1}$-ért\r\n\r\n", offer.HirePrice, offer.HireLaps);
            Hireable hire = new Hireable(car);
            hire.Hire("Bill");
            Hireable hire2 = new Hireable(offer);
            hire2.Hire("Jack");
            Console.ReadLine();
        }
    }
}
UML ábra:

Példa UML ábra a díszítő tervezési mintára
PlantUML szkript:
@startuml
class VehicleBase{
- int _HireLaps
- double _HirePrice
- char _Make
- char _Model
--properties--
+ int HireLaps
+ double HirePrice(): double
+ char Make
+ char Model
}

class VehicleDecoratorBase{
- VehicleBase _vehicle
}
class Ferrari360{}
class SpecialOffer{}
class Hireable{}

VehicleBase <|-- Ferrari360
VehicleBase <|-right- VehicleDecoratorBase
VehicleDecoratorBase o-left- "1" VehicleBase
VehicleDecoratorBase <|-- SpecialOffer
VehicleDecoratorBase <|-- Hireable
@enduml
Gyakorló feladat: Az alábbi leírás szerint készítsünk forráskódot. A megoldáshoz használjuk a díszítő tervezési mintát!
Feladat 1.: Nekem senki ne mondja, hogy egy programozó élete unalmas, azon kívül, hogy szabadidejében ugyanazokat a dolgokat teheti, mint más rendes ember. Még a munkájában is kaphat érdekes megbízatásokat. A minap kaptunk is: Egy bringaboltot kellett csinálnunk. Mi már láttuk is a szemünk előtt a sok csillogó-villogó bringát fel-alá gurulni a szalonban. Okosan, vagy inkább objektumorientáltan-t kéne mondanom, készítettünk egy absztrakt osztályt BringaAlap néven, majd ebből az osztályból származtattuk a Bringa21seb, BringaCsengővel, BringaNői stb. osztályokat, ezek az osztályok tudták a konkrét példány árát. Telt-múlt az idő, és a vásárlók igényeit követve már ilyen osztályneveket használtunk: BringaCsengovel21sebAluvazSarvedoveldecsakElolAkcios. Szép ugye? Éreztük rögtön, hogy ez így nem lesz jó, arról nem is beszélve, hogy osztályaink számának növekedése hasonlított egy demográfiai robbanáshoz. Hosszas tanácskozás után kénytelenek voltunk belátni, hogy majdnem az egész kódot ki kell dobni, bár az első, absztrakt BringaAlap osztályt megtartottuk. Ebben írtunk egy GetLeírás és egy Ár nevű absztrakt függvényt a hozzájuk tartozó mezőkkel. Ebből öröklődött a konkrét Bringa, de még kellettek az alkatrészek: csengő, váltó, sárvédő stb. Így létrehoztunk egy újabb absztrakt osztályt, amit BringaDíszítőnek neveztünk el és ez is a BringaAlap gyermek. A Díszítőből származnak a konkrét elemek, amelyek csak a saját áraikat ismerik, de az Ár függvényük és a konstruktoruk úgy van megírva, hogy az őket hívó elem árát is hozzáadják az árhoz. Tulajdonképpen veszünk egy bringát, majd „körbecsomagoljuk” (ezért nevezik ezt a mintát wrapper-nek is) egy sárvédővel, majd ezt egy csengővel és így tovább. Amikor minden igényt kielégítettünk, meghívjuk a legutolsó elem Ár függvényét, mely a saját árával meghívja a következő elem ugyanezen függvényét, és a végén visszakapjuk az összeállítás teljes árát.
Feladat 2.: Készítsen egy kávéitalprogramot, amely szemlélteti a díszítő működését! A feladat szempontjából csak az ár és a kávé összetevői számítsanak (pl. cukor, tejszín, tej, hab, esetleg rum, öntet)! A program vegye figyelembe az árak alakulását is. A feladat az, hogy a kezdetben üres, keserű, fekete kávénkat díszítsük fel.
Feladat 3.: Készítsen karácsonyfa programot, amely egy alap fenyőfát díszíthetünk különböző díszekkel. A legfontosabb megfigyelés az az, hogy egy karácsonyfa karácsonyfa marad a díszítés után is. Ez azt jelenti, hogy átlátszó becsomagolást kell használnunk.
A feladat megoldásához kell egy absztrakt ős, amely rögzíti a karácsonyfa szolgáltatásait. Ez jelen esetben csak egy metódus le, a kirajzol, ami az egyszerűség kedvéért csak kiír valamit a képernyőre. Ezen túl kell legalább egy fenyőfa típus, amit díszíteni fogunk és legalább egy dísz típus. Ha több dísz típus is van, akkor érdemes nekik egy közös őst létrehozni.
AbsztraktKarácsonyfa osztály:
Absztrakt osztály, a fenyő és a dísz típusoknak is az őse.
KiRajzol(): Absztrakt metódus. Kirajzolja, vagy csak kiírja, a karácsonyfát.
LucFenyő osztály:
Az AbsztraktKarácsonyfa osztályból származik, ezt lehet díszíteni.
KiRajzol(): kiírja, hogy „lucfenyő”.
AbsztraktDísz osztály:
Az AbsztraktKarácsonyfa osztályból származik, ezt lehet díszíteni.
karácsonyfa: AbsztraktKarácsonyfa típusú mező. Azt a karácsonyfát tartalmazza, amire a dísz kerül. Ez egy objektumösszetétel, azon belül is átlátszó becsomagolás, mert az AbsztraktDísz és a karácsonyfa is AbsztraktKarácsonyfa típusú.
AbsztraktDísz(karácsonyfa): Konstruktor, beállítja a karácsonyfa nevű mezőt. Mivel egy objektum összetétel kívülről kap értéket, ezért ez egy felelősség beinjektálás.
DíszRajzolás(): Absztrakt metódus, a gyermekosztályok fogják kifejteni. Kirajzolja, vagy csak kiírja, a díszt.
KiRajzol(): Kódja: DíszRajzolás(); karácsonyfa.KiRajzol(); Ez egy felelősség átadás, és egy a gyermekben kifejtendő metódus hívása. Az első kirajzolja az eddigi karácsonyfát, a második az új díszt.
GömbDísz osztály:
Az AbsztraktDísz osztályból származik, ez egy feldíszített karácsonyfa, amit tovább lehet díszíteni.
GömbDísz(karácsonyfa): Konstruktor, egyszerűen meghívja az ős konstruktorát a karácsonyfa paraméterrel.
DíszRajzolás(): Kiírja, hogy „gömbös”.
Főprogram: Hozzon létre egy lucfenyőt. Csomagolja be egy gömb dísz segítségével, így egy „gömbös lucfenyő” jön létre. Készítsen „gömbös gömbös lucfenyő”-t. Csínáljon új dísz típusokat, pl. CsillagDísz és készítsen egy „csillagos gömbös gömbös lucfenyő”-t.
Vegye észre, hogy használtuk átlátszó becsomagolást, felelősség beinjektálást, felelősség átadás.
Helyettes – Proxy
A helyettes (angolul: proxy) tervezési minta egy nagyon egyszerű kompozícióra ad példát, ami ráadásul átlátszó becsomagolás. Egy valamilyen szempontból érdekes (drága, távoli, biztonsági szempontból érzékeny stb.) példányt birtokol a helyettese. Ez az érdekes objektum nem érhető el kívülről, csak a helyettesén keresztül érhetők el a szolgáltatásai. Ugyanakkor a külvilág azt hiszi, hogy az érdekes objektumot közvetlenül éri el, mert a helyettes átlátszó módon csomagolja be az érdekes objektumot. Az átlátszóság miatt a helyettesnek és az érdekes objektumnak közös őse van.
Sokféle helyettes létezik aszerint, hogy milyen szempontból érdekes a helyettesített objektum, pl.:
Virtuális proxy: Nagy erőforrásigényű objektumok (pl. kép) helyettesítése a példányosítás (vagy más drága művelet) elhalasztásával, amíg ez lehetséges. A szövegszerkesztők ezt használják a képek betöltésére. Ha csak gyorsan átlapozom a dokumentumot, akkor a kép nem töltődik be (elhalasztódik a betöltés), csak a helye látszik.
Távoli proxy: Távoli objektumok lokális megjelenítése átlátszó módon. A kliens nem is érzékeli, hogy a tényleges objektum egy másik gépen van, amíg van hálózati kapcsolat. Ezt alkalmazza a távoli metódushívás (remote method invocation – RMI).
Védelmi proxy: A hozzáférést szabályozza különböző jogok esetén.
Okos referencia: Az egyszerű referenciát helyettesíti olyan esetekben, amikor az objektum elérésekor további műveletek szükségesek.
Gyorsító tár (angolul: cache): Ha van olyan számítás (ide sorolva a letöltéseket is), ami drága, akkor a számítás eredményét érdemes letárolni egy gyorsító tárban, ami szintén egyfajta proxy.
Mivel nagyon sokféle helyettes létezik, ezért ezeket összefoglalóan helyettes állatkertnek (angolul: Proxy Zoo) szoktuk nevezni.
Forráskód – Példa 1.
using System;
namespace helyettes
{
    class MainApp
    {
        static void Main()
        {
            // Készítünk egy helyettest és kérünk egy szolgáltatást.
            Proxy proxy = new Proxy();
            proxy.Kérés();
            Console.ReadKey();
        }
    }
    // Közös interfész a Tárgy és a Proxi számára, ezáltal tud a minta működni.
    abstract class Tárgy { public abstract void Kérés(); }
    // valódi munka "tárgy"amit tenni akarunk
    // a valódi objektum, amit a proxy elrejt
    class ValódiTárgy : Tárgy
    {
        public override void Kérés()
        {
            Console.WriteLine("Meghívom a ValódiTárgy.Kérés-et()");
        }
    }
    // The 'Proxy' osztály
    // Tartalmaz egy referenciát a tényleges objektumra, hogy el tudja azt érni. 
    // Szabályozza a hozzáférést a tényleges objektumhoz, feladata lehet a tényleges 
    // objektum létrehozása és törlése is.
    class Proxy : Tárgy
    {
        private ValódiTárgy valódiTárgy;
        public override void Kérés()
        {
            if (valódiTárgy == null) { valódiTárgy = new ValódiTárgy(); }
            valódiTárgy.Kérés();
        }
    }
}
UML ábra:

UML ábra a helyettes tervezési mintára
PlantUML szkript:
@startuml
abstract class Tárgy {
 + {abstract} void Kérés()
}
class ValódiTárgy {}
class Proxy {
 - ValódiTárgy valódiTárgy
 + void Kérés() { if (valódiTárgy == null) 
 {...} else valódiTárgy.Kérés(); }
}
ValódiTárgy -up-|> Tárgy
Proxy -up-|> Tárgy
Proxy o-right-> ValódiTárgy
@enduml
Forráskód – Példa 2.
using System;
using System.Collections.Generic;
abstract class Faktoriális
{
    public abstract long Fakt(int n); //n faktoriálist számol
}
class FaktoriálisCache : Faktoriális
{
    class RekurzívFaktoriális : Faktoriális  // beágyazott osztály
    {
        public override long Fakt(int n)
        {
            if (n == 0) return 1;
            return n * Fakt(n - 1);
        }
    }
    Dictionary<int, long> t = new Dictionary<int, long>();
    RekurzívFaktoriális f = new RekurzívFaktoriális();
    public override long Fakt(int n)
    {
        if (t.ContainsKey(n)) return t[n];
        long value = f.Fakt(n);
        t.Add(n, value);
        return value;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Faktoriális f = new FaktoriálisCache();
        Console.WriteLine(f.Fakt(20));
        Console.WriteLine(f.Fakt(10));
        Console.WriteLine(f.Fakt(20));
        Console.ReadLine();
    }
}
Gyakorlófeladat: Az alábbi leírás szerint készítsünk forráskódot. A megoldáshoz használjuk a helyettes tervezési mintát!
Feladat 1.: A fenti forráskódot úgy írjuk át, hogy minden részeredmény bekerüljön az átmeneti tárba (angolul: cache). A rekurzió során is figyeljük, hogy a kívánt részeredmény megvan-e az átmeneti tárban. Hasonlítsuk össze az egyes megoldások futásidejét!
Feladat 2.: Ki ne ismerné azokat a helyes kis automatákat, amik némi pénz bedobása után jópofa dolgokat adnak egy műanyag golyóban. A hálózat üzemeltetője jelentkezett cégünknél, hogy szeretné az interneten keresztül felügyelni a gépek állapotát, mint például tudni, hogy mennyi golyó van még benne. A megvalósítási megbeszélésen egyik kollégánk megemlítette, hogy Ő volt egy csapatépítő tréningen, ahol az esti tábortűznél egy nagyszakállú, bölcs és kellőképpen öreg programozó mesélt nekik a proxyról és hogy az pont valami ilyesmire való. Szakkönyvek, internet és valóban, az öregnek igaza volt. Innen már könnyű út vezetett a megvalósításig. Természetesen az absztrakt osztályok kidolgozásával kezdtük, először is a közös felületet kellett megírni, amin a helyettes és a mi kis automatánk megtalálja a közös nyelvet. Tehát ebbe az osztályba került a MennyiGolyo() és a MennyiPenz() absztrakt függvény. A szakirodalomból azt is megtudtuk, hogy a visszatérési értékeknek seriaziable-nek kell lenniük a hálózati forgalom miatt. Ezután a Proxy-t implementáltuk, feladata, hogy a kliens kérését (a főnök utasítását) eljuttassa az automatának. Ami ténylegesen átmegy, az a meghívott függvény neve és az esetleges argumentumai. Az igazi kemény munkát ezután az automata (ValódiTárgy) végzi, hiszen csak ő tudja hány golyó rejt még meglepetést az arra sétálóknak. Meghívja a MennyiGolyo() függvényt, majd a kapott eredmény visszajuttatja a Proxy-nak, mely büszkén mutatja azt fel a kliensnek. Persze ebben az esetben nem szabad megfeledkezni a kivételkezeléséről sem, mert amit a hálózaton keresztül elküldünk, az nem biztos, hogy oda is ér.
Összegzés és ellenőrző kérdések
Ebben a leckében áttekintettük a 3 legegyszerűbb szerkezeti tervezési mintát, úgy mint: Illesztő, Díszítő, Helyettes. A szerkezeti tervezési minták fő feladata, hogy megmutassák, hogyan kell használni az objektum-összetételt, hogy az elvárásainknak megfelelő futási ideje szerkezeteket tudjuk létrehozni.
Ellenőrző kérdések:
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
Lecke 11.: Viselkedési tervezési minták
A lecke célja és tartalma
Célok, megszerezhető kompetenciák: A lecke végére megismerkedünk néhány viselkedési tervezési mintával egy-egy példán keresztül.
Szükséges eszközök, források: A GOF könyv. A Head First Design Patterns könyv.
Feldolgozási idő: 90 perc.
Témakörök: Viselkedési tervezési minták, Állapot, Megfigyelő, Sablonmetódus, Stratégia, Látógató.
A lecke tartalma: Ebben a leckében áttekintünk 5 fontos viselkedési tervezési mintát, úgy mint: Állapot, Megfigyelő, Sablonmetódus, Stratégia, Látógató. A viselkedési tervezési minták olyan megoldást biztosítanak, amelyek könnyen bővíthetők új viselkedéssel. Ehhez általában csak egy új alosztállyal kell bővíteni a meglévő osztály hierarchiát.
Bevezetés
A viselkedési tervezési minták arra adnak módszert, hogy hogyan írjunk olyan programot, amit nagyon könnyű újfajta viselkedéssel bővíteni, ha előre látható, hogy milyen fajta viselkedésekre lehet számítani a jövőben.
Ehhez meg kell érteni a szétválasztás elvét (angolul: Separation of Concerns), amely kimondja:
Amit szét lehet választani, azt érdemes szétválasztani.
Különösen igaz ez az úgynevezett változékony metódusokra. A változékony metódusokat mindig érdemes kiemelni az őket tartalmazó osztályból.
A kiemelt metódusok meghívására sok módszer van, ezek közül bemutatjuk a felelősség átadást, a kontrol megfordítását (angolul: Inversion of Control, vagy röviden IoC) és a műsorszórást.
A felelősség átadás vagy delegálás alatt azt értjük, hogy egy objektum valamely metódusa meghívja a birtokolt objektum egy metódusát, hogy az helyette oldja meg a feladatot részben vagy egészben.
A kontrol megfordítása (angolul: Inversion of Control, vagy röviden IoC) az a programozási módszer, amikor nem az üzemi kód hívja az előre megirt általános kódot, pl. egy könyvtár (angolul: library) függvényt, hanem az általános kód hívja az üzemi kódot. Egyik példája, amikor nem a gyermekosztály hívja az ősosztályt, hanem az ős a gyermeket.
A műsorszórás (angolul: broadcast) egy olyan programozási módszer, amikor egy metódus sok más, előre nem ismert metódust hív meg egy lista alapján.
Állapot – State
Az állapot (angolul: state) viselkedési tervezési mintát akkor használjuk, ha több összefüggő változékony metódust akarunk kiemelni és azokat delegációval meghívni.
Lehetővé teszi egy objektum viselkedésének megváltozását, amikor megváltozik az állapota.
Egy jól ismert példa a TCPConnection osztály, amely egy hálózati kapcsolatot reprezentál. Három állapota lehet: Listening, Established, Closed. A kéréseket az állapotától függően kezeli.
Használjuk, ha
az objektum viselkedése függ az állapotától, és a viselkedését az aktuális állapotnak megfelelően futás közben meg kell változtatnia, illetve
a műveleteknek nagy feltételes ágai vannak, melyek az objektum állapotától függenek.
Előnyök:
Egységbe zárja az állapotfüggő viselkedést, így könnyű új állapotok bevezetése.
Áttekinthetőbb kód (nincs nagy switch-case szerkezet).
Az állapot objektumokat meg lehet osztani.
Hátrányok: Nő az osztályok száma, ezért csak indokolt esetben használjuk.
Példa: Az állapot tervezési mintát a következő példán keresztül mutatjuk be: Feladatunk, hogy elkészítsünk egy rendkívül egyszerű audio lejátszót. A lejátszónknak a következőképpen kell működnie: ha a lejátszó készenléti állapotban van, akkor a lejátszás gomb hatástalan, az audioforrás gombbal pedig megkezdődik az mp3 fájl lejátszása. Mp3 lejátszás közben a lejátszás gomb leállítja a lejátszást, az audioforrás gomb pedig rádióhallgatást tesz lehetővé. Ha az mp3 lejátszás szünetel, akkor a lejátszás gomb hatására folytatódik a lejátszás, az audioforrás gomb pedig ebben az esetben is rádióhallgatást tesz lehetővé. Rádióhallgatás közben a lejátszás gomb adót vált, az audioforrás gomb pedig készenléti üzemmódot eredményez. A leírt összetett működés eléréséhez az állapotgépet valósítjuk meg. Létrehozzuk az audiolejátszó osztályunkat, amelynek van egy belső állapota, valamint egy lejátszás és egy audioforrás metódusa. Létrehozunk egy alapállapot osztályt is, melyből a később szükséges állapotaink származni fognak, és amelyek később a lejátszónk állapotai lehetnek. Az, hogy a lejátszónk az egyes állapotokban hogyan reagál a lejátszás és audio forrás lenyomására, az egyes állapotoktól függ, ezért ezek az egyes állapotokban vannak definiálva, csakúgy, mint az állapotátmenetek is. Módszerünk előnye, hogy könnyedén bővíthetjük a lejátszónkat újabb állapotokkal, és ezáltal újabb funkciókkal bővülhet. Forráskód:
using System;
namespace Állapot
{
    /// <summary>
    /// Állapot viselkedési tervezési minta
    /// média lejátszó
    /// két gomb
    /// 4 állapot
    /// a két gomb viselkedése más és más lesz a 4 belső állapottól függően
    /// lesz egy: Állapot
    /// Play gomb
    /// Audió forrás gomb
    /// Állapotváltozások:
    /// Állapotok: készenlét, mp3 lejátszás, mp3 megállítás, rádió hallgatás
    /// Lejátszás: stop-paused, start-play, next station
    /// Audió forr: mp3 play, rádió play, rádió play, készenlét
    /// </summary>
    public class AudioPlayer
    {
        private AudioPlayerState state; // ebben tároljuk a belső állapotot
        public AudioPlayer(AudioPlayerState state) { this.state = state; }
        public AudioPlayerState SetState
        {
            get { return state; }
            set { state = value; }
        }
        public void PressPlay() { state.PressPlay(this); }
        public void PressAudioSource() { state.PressAudioSource(this); }
    }
    public abstract class AudioPlayerState // állapot reprezentálása
    {
        // a két gomblenyomása
        public abstract void PressPlay(AudioPlayer player);
        public abstract void PressAudioSource(AudioPlayer player);
    }
    public class StandbyState : AudioPlayerState // készenléti állapot
    {
        public StandbyState() { Console.WriteLine("StandBy"); }
        public override void PressPlay(AudioPlayer player)
        {
            Console.WriteLine("Play pressed: no effect");
        }
        public override void PressAudioSource(AudioPlayer player)
        {
            player.SetState = new MP3PlayingState();
        }
    }
    public class MP3PlayingState : AudioPlayerState // mp3 hallgatás állapot
    {
        public MP3PlayingState() { Console.WriteLine("Playing MP3"); }
        public override void PressPlay(AudioPlayer player)
        {
            player.SetState = new MP3PausedState();
        }
        public override void PressAudioSource(AudioPlayer player)
        {
            player.SetState = new RadioState();
        }
    }
    public class MP3PausedState : AudioPlayerState // a megállított mp3 állapot
    {
        public MP3PausedState() { Console.WriteLine("Paused MP3"); }
        public override void PressPlay(AudioPlayer player)
        {
            player.SetState = new MP3PlayingState();
        }
        public override void PressAudioSource(AudioPlayer player)
        {
            player.SetState = new RadioState();
        }
    }
    public class RadioState : AudioPlayerState // a rádió állapot
    {
        public RadioState() { Console.WriteLine("Playing Radio"); }
        public override void PressPlay(AudioPlayer player)
        {
            Console.WriteLine("Switch to next Station");
        }
        public override void PressAudioSource(AudioPlayer player)
        {
            player.SetState = new StandbyState();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AudioPlayer player = new AudioPlayer(new StandbyState());
            player.PressPlay();
            player.PressAudioSource();
            player.PressPlay();
            player.PressPlay();
            player.PressAudioSource();
            player.PressPlay();
            player.PressAudioSource();
            Console.ReadLine();
        }
    }
}
UML ábra:

Példa UML ábra az állapot tervezési mintára
PlantUML szkript:
@startuml
class AudioPlayer {
- AudioPlayerState state;
+ void PressPlay() { state.PressPlay(this); }
+ void PressAudioSource() { state.PressAudioSource(this); }
--properties--
- AudioPlayerState State;
}
abstract class AudioPlayerState {
+ {abstract} void PressPlay(AudioPlayer player);
+ {abstract} void PressAudioSource(AudioPlayer player);
}
class StandbyState { }
class MP3PlayingState {
+ void PressPlay(AudioPlayer player) { player.State = new MP3PausedState(); }
+ void PressAudioSource(AudioPlayer player){ player.State = new RadioState(); }
}
class MP3PausedState {}
class RadioState {}
AudioPlayer o--> AudioPlayerState : -state
StandbyState -down-|> AudioPlayerState
MP3PlayingState -up-|> AudioPlayerState
MP3PausedState -down-|> AudioPlayerState
RadioState -up-|> AudioPlayerState
@enduml
Mivel a fenti ábrára nem minden állapotátmenet fért el, ezért külön UML ábrán mutatjuk az állapotátmeneteket:

A példaprogram állapotgép diagrammja
PlantUML szkript:
@startuml
StandbyState : /Print:"StandBy"
MP3PlayingState : /Print:"Playing MP3"
MP3PausedState : /Print:"Paused MP3"
RadioState : /Print:"Playing Radio"
[*] --> StandbyState : <<create>>
StandbyState --> StandbyState : PressPlay / no effect
StandbyState --> MP3PlayingState : PressAudioSource
MP3PlayingState --> MP3PausedState : PressPlay
MP3PlayingState --> RadioState : PressAudioSource
MP3PausedState --> MP3PlayingState : PressPlay
MP3PausedState --> RadioState : PressAudioSource
RadioState --> RadioState : PressPlay / Switch to next Station
RadioState --> StandbyState : PressAudioSource
@enduml
Gyakorlófeladat: Az alábbi leírás szerint készítsünk forráskódot. A megoldáshoz használjuk az állapottervezési mintát!
Feladat: Egy napon az egyik munkatársunk kiment a kávéautomatához egy frissítő italért, pár perc múlva vörös fejjel és kezében az automata programjával jött vissza. Kérdésünkre elmondta, hogy nem először jár úgy, hogy a gép elnyeli az aprót, de kávét nem ad, úgyhogy gondolta, a programmal lesz a baj. Elkezdtük tanulmányozni a szoftvert, mely tele volt csúnya és néhol egymásba ágyazott IF feltételekkel (ezek váltották a belső állapotot, ha bedobtuk a pénzt vagy elfogyott a kávépor stb.). Rögtön gondoltuk, hogy erre van jobb módszer. Először hívtunk egy grafikust, aki lerajzolt mindent, majd egy állapotdiagramban a gép lehetséges belső állapotait (pl. nincs apró, apró bedobva stb.). Ebből rögtön láttuk, hogy egyes állapotokban a gépnek meg kell, hogy változzon a viselkedése (ha nincs apró és megnyomom a kávégombot, nem adhat kávét, míg ha van apró, akkor illik legalább valami sötét löttyöt adni). Így már tudtunk csinálni egy interfészt az állapotoknak. Ebből az osztályból dolgoztuk ki a konkrét állapotokat külön osztályokba. Alapesetben a gép a „nincs apró” állapotban (osztályban) van, de ha dobunk be aprót, akkor lecseréli az állapotát (osztályát) „apró bedobva” típusúra. Mióta megírtuk a programot, nekünk már apró sem kell a kávéhoz.
Megfigyelő – Observer
A megfigyelő (angolul: observer) egy viselkedési tervezési minta, amely egy esemény által kiváltott változékony metódust emel ki egy egy-sok kapcsolat sok oldalára, és amely műsorszórással hívja meg a kiemelt metódusokat. A műsorszórás (angolul: broadcast) egy olyan programozási módszer, amikor egy metódus sok más, előre nem ismert, metódust hív meg egy lista alapján. Ez a tervezési minta a Hollywood Principle tervezési alapelvet valósítja meg.
A megfigyelőnek két fajtája van a húzó (angolul: pull) és a toló (angolul: push), amelyek abban különböznek, hogyan adjuk át az eseményt a megfigyelőknek. A húzó megfigyelő egy referenciát ad át a megfigyelőknek, amin keresztül lehúzhatják az eseményt. A toló megfigyelő magát az eseményt adja át a megfigyelőknek paraméterként.
A megfigyelő tervezési minta lehetővé teszi, hogy egy objektum megváltozása esetén értesíteni tudjon tetszőleges más objektumokat anélkül, hogy bármit is tudna róluk. Részei:
Alany: Tárolja a beregisztrált megfigyelőket, interfészt kínál a megfigyelők be- és kiregisztrálására valamint értesítésére.
Megfigyelő: Interfészt definiál azon objektumok számára, amelyek értesülni szeretnének az alanyban bekövetkezett változásról. Erre a frissít (Update) metódus szolgál.
Kétfajta megfigyelő megvalósítást ismerünk:
„Pull-os” vagy húzó megfigyelő: Ebben az esetben a megfigyelő lehúzza a változásokat az alanytól.
„Push-os” vagy toló megfigyelő: Ebben az esetben az alany odanyomja a változásokat a megfigyelőnek.
A kettő között ott van a különbség, hogy a Frissít metódus milyen paramétert kap. Ha az alany átadja önmagát (egy Frissít(this) hívás segítségével) a megfigyelőnek, akkor ezen a referencián keresztül a megfigyelő képes lekérdezni a változásokat. Azaz ez a „pull-os” megoldás.
Ha a Frissít metódusnak az alany azokat a mezőit adja át, amik megváltoztak és amiket a megfigyelő figyel, akkor „push-os” megoldásról beszélünk. A következő példában épp egy ilyen megvalósítást láthatunk. Forráskód:
using System;
using System.Collections.Generic;

namespace Megfigyelő
{
    public interface ISubject
    {
        // observer regisztrálásra
        void RegisterObserver(IObserver o);
        // observer törlésre
        void RemoveObserver(IObserver o);
        // meghívódik, hogy értesítse az megfigyelőket
        // amikor a Subject állapota megváltozik
        void NotifyObservers();
    }
    public interface IObserver
    {
        // értékék amiket megkapnak az observerek a Subjecttől, push-os megoldás
        void Update(float temp, float humidity, float pressure);
    }
    public interface IDisplayElement
    {
        // megjelenítés
        void Display();
    }
    // implementáljuk a Subject interfészt
    public class WeatherData : ISubject
    {
        // hozzáadunk egy listát amiben observereket tárolunk
        private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;
        public WeatherData()
        {
            // létrehozzuk az observereket tároló listát
            observers = new List<IObserver>();
        }
        public void RegisterObserver(IObserver o)
        {
            // amikor egy observer regisztrál, egyszerűen hozzáadjuk a listához
            observers.Add(o);
        }
        public void RemoveObserver(IObserver o)
        {
            // amikor egy observer kéri a törlését, egyszerűen töröljük a listából
            int i = observers.IndexOf(o);
            if (i >= 0)
            {
                observers.Remove(o);
            }
        }
        // itt szólunk az observereknek az állapotról
        // mivel mind observerek, van Update() metódusuk, így tudjuk őket értesíteni
        public void NotifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                IObserver observer = (IObserver)observers.ElementAt(i);
                observer.Update(temperature, humidity, pressure); // ez push-os
                // observer.Update(this); // ez pull-os
            }
        }
        // amikor a Weather Station-től megkapjuk a frissített értékeket, 
        //értesítjük az observereket
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }
        // értékek beállítása hogy tesztelhessük a megjelenítést
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
        // egyéb metódusok
    }
    // a display implementálja az Observert,
    //így fogadhat változásokat a WeatherData objektumtól
    // továbbá implementálja a DisplayElement-et, mivel 
    //minden display element-nek implementálnia kell ezt az interfészt
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;
        // a konstruktor megkapja a weatherData objektumot
        // (a Subject) és arra használjuk, hogy
        // a display-t observerként regisztráljuk
        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        // amikor az Update() meghívódik, mentjük a temperature-t és a humidity-t
        // majd meghívjuk a Display()-t
        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }
        // Megjelenítjük a legújabb eredményeket
        public void Display()
        {
            Console.WriteLine("Current conditions: " + temperature + "F degrees and " + humidity + "% humidity");
        }
    }
    public class WeatherStation
    {
        static void Main(string[] args)
        {
            // létrehozzuk a weatherData objektumot
            WeatherData weatherData = new WeatherData();
            // létrehozzuk a displayt és odaajuk neki a weatherData-t
            CurrentConditionsDisplay currentDisplay = 
                                     new CurrentConditionsDisplay(weatherData);
            // új időjárási mérésértékek szimulálása
            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);
            Console.ReadKey();
        }
    }
}
UML ábra:

Példa UML ábra a megfigyelő tervezési mintára
PlantUML szkript:
@startuml
interface IObserver {
+void Update(float, float, float)
}
interface ISubject {
+void NotifyObserver()
+void RegisterObserver(IObserver)
+void RemoveObserver(IObserver)
}
interface IDisplayElement {
+void Display()
}
class WeatherData {
-float humidity
-float pressure
-float temperature
-List<IObserver> observers
--
+void setMeasurement(float, float, float)
}
class CurrentConditionDisplay {
-float humidity
-float temperature
-ISubject weatherData
+void Update(float, float, float)
}
IObserver <|.down. CurrentConditionDisplay
IDisplayElement <|.down. CurrentConditionDisplay
ISubject <|.down. WeatherData
ISubject o-right-> "*" IObserver
@enduml
Gyakorlófeladat: Az alábbi leírás szerint készítsünk forráskódot. A megoldáshoz használjuk a megfigyelő tervezési mintát!
Feladat 1.: A fenti példakódot alakítsuk át „pull-os” megfigyelővé.
Feladat 2.: Cégünk azt a megtisztelő feladatot kapta, hogy kalózhajót kellett programozni, ami több heti kódírás után egész szépen úszott a vízen, egy picike probléma volt csak vele. Mégpedig, hogy a főárboc tetején lévő kosárban ülő őrszemnek nem volt rádiója, hiszen még nem találták fel, ezért minden alkalommal, ha valaki alatta ment el, az felkiabált, hogy látja-e már a gazdag zsákmányt vagy az ellent. Szegény emberünknek úgy kiszáradt a torka, hogy egy hordó rumot kellett délig meginnia. A probléma orvoslására és a rumkészlet megmentésére azt találtuk ki, hogy aki szeretne értesülni a hírekről (Observer), az köt egy kötelet a csuklójához, majd a másik végét feldobja (RegisterObserver()) az őrszemnek (Subject). Amikor az őrszem említésre méltót lát, akkor megrángatja a kötelek végét (NotifyObservers()), és az összegyűlt „megfigyelőknek” lekiabálja a hírt (Update()). Aki nem kíváncsi tovább az eseményekre, az egész egyszerűen lehúzza a kötelének a végét a kosárból (RemoveObserver()).
Feladat 3.: Készítsen példát a Megfiyelő (angolul: Observer) tervezési mintára. A konkrét példa legyen a klasszikus Rajongók – Lady GaGa példa.
Az a feladatunk, hogy tegyük lehetővé a sok rajongónak, hogy kövessék Lady GaGa posztjait. Amikor Lady GaGA posztol valamit, akkor arról minden rajongója értesül. A rajongok fel-, illetve lejelentkezhetnek Lady GaGa híroldaláról.
Gondoljuk végig, hogy mi kell ennek a feladatnak a megoldásához. Vegyük észre, hogy itt egy sok kapcsolat van a híresség híroldala és a rajongók közt, és egy esemény, a posztolás, hatására kell értesíteni mindenkit a sok oldalon. Ez egy klasszikus Megfigyelő tervezési mintának megfelelő feladat.
A híroldalon van egy lista, a rajongók listája, erre lehet fel-, illetve leiratkozni. Kell tovább egy Értesít() metódus, ami az utolsó posztot küldi minden a listán lévő rajongónak.
Mivel a posztot küldjük, ezért ez a megoldás egy úgynevezett toló (félig angolul: „push”-os) megoldás lesz. Ha csak refenciát küldenénk, ahonnan a poszt lehúzható, akkor húzó (félig angolul: „pull”-os”) megoldásunk lenne.
Híroldal osztály:
híresség: A híroldal tulajdonosának neve.
rajongók: A rajongók listája.
poszt: Az utolsó poszt szövege.
Híroldal(híresség): Konstruktor, beállítja a híresség nevét. A rajongok listáját létrehozza üresen.
Feliratkozás(rajongó): A rajongót felveszi a rajongók listájára.
Leiratkozás(rajongó): A rajongót leveszi a rajongók listájáról.
Értesít(): Minden rajongónak meghívja a Frissít(poszt) metódusát az utolsó poszttal.
Posztol(poszt): Beállítja a poszt mezőt és meghívja az Értesít() metódust.
Rajongó osztály:
Frissít(poszt): Megkapja az utolsó posztot. Legegyszerűbb, ha csak kiírjuk a képernyőre a poszt tartalmát.
Ezen túl lehet más mezője, metódusa.
Főprogram: Hozzon létre két rajongót. Hozza létre Lady GaGa híroldalát. Mindkét rajongót írassa fel a híroldalra. Lady GaGa posztolja, hol lesz a következő koncertje. Gondoljuk végig, hogy mit fog kiírni a program és miért.
Írja át a programot az IObserver és az IObservable interfészek használatával!
Tanulmányozza figyelmesen az értesít kódját: forach(rajongó raj in rajongók) raj.Értesít(poszt); Vegye észre, hogy ez az ügynevezett műsorszórás, hiszen egy eseményről nem csak egy objektum, hanem minden érdekelt objektum értesül.
Sablonmetódus – Template Method
A sablonmetódus (angolul: template method) egy viselkedési tervezési minta, amely egy vagy több változékony metódust emel ki egy gyermekosztályba, és amely IoC segítségével hívja meg a kiemelt metódusukat.
A sablonmetódus egy olyan tervezési minta, amit akkor használunk, ha van egy általános receptünk, ami alapján több hasonló dolog is gyártható. Klasszikus példa a teafőzés és kávéfőzés, amit részletesen is ismertetünk. A sablonmetódus tervezési mintát gyakran hasonlítják össze a stratégia tervezési mintával az alábbi mondattal:
Stratégia: Ugyanazt csináljuk, de másképp;
Sablonmetódus: Ugyanúgy csináljuk, de mást.
A receptben háromféle lépés lehet:
kötelező és közös: bármit készítünk a recepttel, ez a lépés mindig ugyanaz,
kötelező, de nem közös: bármit készítünk a recepttel, ez a lépés szükséges, de minden esetben mást és mást kell konkrétan csinálni,
opcionális: ez a lépés nem minden esetben szükséges.
Ezeket programozástechnikailag így valósíthatjuk meg:
A kötelező és közös lépések olyan metódusok, amelyek már az ősben konkrétak és azokat általában nem is szabad felülírni. Ilyen a forró ital főzésénél a vízforraló metódus.
A kötelező, de nem közös lépések az ősben absztrakt metódusok, amit a gyermekosztályok fejtenek ki. Ilyen a forró ital főzésénél az édesítés.
Az opcionális lépések az ősben horog (angolul: hook) metódusok, azaz van törzsük, de az üres. Ezek a metódusok virtuálisak, hogy aki akarja, az felülírhassa őket.
Mivel a gyermekosztálynak implementálnia kell minden absztrakt metódust, ezért az ilyenek kötelezőek. Igaz, hogy akár az implementáció üres is lehet. Mivel a horog (angolul: hook) metódusoknak van implementációjuk, de üres az üres, ezért nem muszáj őket felülírni, de lehet az OCP elv megszegése nélkül. Ezért ezek az opcionális lépések. A horog (angolul: hook) metódusokat C# nyelven virtuálisnak kell deklarálni.
Maga a recept a sablonmetódus. Gyakran csak ez az egy metódus publikus, minden más metódus, azaz a recept lépései, privát vagy védett metódusok (a szerint, hogy a gyermek felülírhatja-e vagy sem). Erre azért van szükség, hogy az egyes lépéseket ne lehessen össze-vissza sorrendben hívni, csak a recept által rögzített sorrendben.
Elméletben a sablonmetódus egy algoritmus, amelyben a lépések nem változnak, de a lépések tartalma igen. Ha esetleg mégis bejön egy új lépés, azt érdemes horog (angolul: hook) metódusnak felvenni.
Érdekes megfigyelni, hogy az absztrakt ős és a gyermekosztályai IoC (angolul: Inversion of Control) viszonyban állnak hasonlóan, mint a gyártómetódus esetén. Ugyanúgy itt is: nem a gyermek hívja az ős metódusait, hanem az ős a gyermekét. Ezt úgy érjük el, hogy a sablonmetódus absztrakt-, illetve virtuális metódusokat hív. Amikor a gyermekosztály példányán keresztül hívjuk majd a sablonmetódust, akkor a késői kötés miatt ezen metódusok helyett az őket felülíró gyermekbéli metódusok fognak lefutni.
Példa: A sablonmetódust egy példával szemléltetjük: Nincs is jobb a visszatérő ügyfélnél, és már nekünk is van ilyen. A gyártómetódus kapcsán megismert zsíroskenyérbolt visszatért. Olyan jól ment az üzlet, hogy kávét és teát is elkezdtek árusítani. Két kolléga el is kezdte a munkát, egyikőjük a teát, míg a másik a kávét kapta feladatául. Estig nyugalom is volt az irodában, amikor is a teás kolléga meggyanúsította a kávést, hogy tőle lopta a kódot. Megnéztük és tényleg nagyon hasonló dolgokat írtak, például: mindkettőjüknél volt vízforraló függvény és kitölt függvény. Ezek a dolgok mindkét ital esetében ugyanúgy történnek. Nosza, tegyük őket egy absztrakt osztályba. Ennek Ital lett a neve. Az elkészítési lépéseket (függvényeket: vízforraló, kitölt) betettük egy elkészít nevű függvénybe, nehogy valaki előbb tudja kitölteni az italt, mint a vizet felforralni. Majd jött a következő ötlet, a hozzávalók hozzáadását is ide tettük, sőt csináltunk egy főz függvényt is, hogy teljes legyen a csapat. Mindkét előző függvény absztrakt, mert ezt majd a konkrét osztály kidolgozza, hiszen a kávéba tej és cukor kell, míg a teába citrom. Most már csak a két konkrét Tea és Kávé osztályt kellett kidolgozni, ahol a főz és az édesít (ami néha ugyan savanyít) függvények implementálása volt a feladat. Hazafelé menet még hallottuk a két kollegánk veszekedését: akkor is tőlem loptad! Másnap jött az ötlet, hogy a teába rumot is lehet tenni. Ez egyelőre opcionális lehetőség és nem is élünk vele, mert még a főnök nem egyezett bele. Talán majd télen. Forráskód:
using System;
namespace ItalKészítő
{
    public abstract class Ital
    {
        public void Elkészít()
        {// Ez a függvény nem kapta meg a virtual jelzőt a sorrend betartása miatt.
            vízforraló();// kötelező és közös lépés
            főz(); // inversion of control, mert a gyermek főz metódusa fog futni
            édesít(); // kötelező és nem közös lépés
            rum();    // opcionális
            kitölt();
        }
        private void vízforraló() // kötelező közös lépés
        {// Ennek szintén nem kell felűlírhatónak lennie
            Console.WriteLine("Vízforralás 98..99..100c");
        }
        protected abstract void főz(); // Ki kell dolgoznia a konkrét osztálynak.
        protected abstract void édesít(); // Ezek kötelező nem közös lépések.
        protected virtual void rum(){} // Ez egy hook, vagyis egy opcionális lépés.
        private void kitölt() // kötelező közös lépés
        {
            Console.WriteLine("Egy szép porceláncsészébe öntöm az italt\n");
        }
    }
    public class Tea : Ital
    {
        protected override void főz()
        {
            // ezt ki kell dolgozni, hiszen másképp főzök teát, mint kávét
            Console.WriteLine("Belógatom és tunkolom a tea filtert");
        }
        protected override void édesít()
        {
            Console.WriteLine("Kis cukor, és egy kis citrom ízlés szerint");
        }
    }
    public class Kávé : Ital
    {
        protected override void főz()
        {
            // ezt ki kell dolgozni, hiszen másképp főzök teát, mint kávét
            Console.WriteLine("Leforrázom a kávét egy jó török kávé kedvéért.");
        }
        protected override void édesít()
        {
            Console.WriteLine("Kis cukor, és egy kis tej ízlés szerint");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ital tea = new Tea();
            Ital kávé = new Kávé();
            tea.Elkészít(); // a késői kötés miatt a Tea főz és édesít metódusa fut
            kávé.Elkészít();// a késői kötés miatt a Kávé főz és édesít metódusa fut
            Console.ReadKey();
        }
    }
}
Gyakorló feladat: Az alábbi leírás szerint készítsünk forráskódot. A megoldáshoz használjuk a sablonmetódus tervezési mintát!
Feladat: Egészítse ki az alábbi kódrészletet! Írja meg a hiányzó metódusokat és a főprogramot! A feladat megoldásához döntse el, hogy melyik lépés 
közös és kötelező,
kötelező, de nem közös,
opcionális.
A kódrészlet:
    abstract class BuktaSütés
    {
        public void Recept()
        {
            tésztaGyúrás();
            töltelékBele();
            beSűtőbe();
            porcukorTetejére();
        }
        private void tésztaGyúrás() // ezt megadtuk segítségnek
        {
            Console.WriteLine("Meggyúrom a tésztát.");
        }
        // írja mega hiányzó metódusokat
    }
    class TurósBuktaSűtés : BuktaSűtés
    {
        // írja mega hiányzó metódusokat
    }
    class LekvárosBuktaSűtés : BuktaSűtés
    {
        // írja mega hiányzó metódusokat
    }
Stratégia – Strategy
A Stratégia (angolul: Strategy) egy viselkedési tervezési minta, amely mindig egy, és mindig csak egy változékony metódust emel ki egy osztály hierarchiába, és amely felelősség átadással hívja meg a kiemelt metódust.
A stratégia tervezési mintát akkor használjuk, ha van egy (se több, se kevesebb) változékony metódusunk. Változékony metódus például a kosárban lévő áruk árának kiszámítása, hiszen a folyton változó akciók miatt mindig másképp kell kiszámolni az árat. Változékony metódus a Kacsa osztályon belül lévő Hápog metódus is, hiszen másképp hápog a házi kacsa, a néma kacsa, a gumikacsa és ott van még Donald kacsa is, aki rekedten hápog.
A változékony metódus kódját nem szabad csak úgy felülírni lépten-nyomon, hiszen ezzel megsértenénk az OCP elvet. A megoldás az, hogy a stratégia tervezési mintát alkalmazva a változékony metódust kiemeljük egy osztályhierarchiába. Figyeljük meg, hogy ez a lépés egy szétválasztás, azaz a Separation of Conserns elv alkalmazása. Szétválasztjuk az osztályt és a változékony metódust. Majd a szétválasztott dolgokat újra összerakjuk objektum-összetétel segítségével.
Az osztályhierarchia tetején egy absztrakt osztály van, ami csak a kiszervezett metódus fejét tartalmazza. Ennek az osztálynak a gyermekei a konkrét stratégiák. Az az osztály, amiből kiszerveztük a metódust, az objektum-összetétel segítségével kap egy referenciát a stratégiára. Ezen referencián keresztül hívjuk a kiszervezett metódust.
A kacsás példánál maradva: hápogási stratégiát alkalmazva a kacsa hápogási viselkedése attól fog függni, hogy melyik konkrét hápogási stratégiát injektáltuk be az objektum-összetételt megvalósító mezőbe.
A kiemelt metódus tevékenységét az eredeti osztály átadja (más szóval: delegálja) a stratégiának az objektum-összetételt megvalósító mezőn keresztül. Így a késői kötés miatt a beinjektált konkrét stratégia metódusa fut le.
Figyeljük meg az alábbi forráskódokban, hogy minden stratégiában csak egy metódus van! Ez így helyes, nem is szabad többnek lennie, mert akkor már nem stratégiának hívnánk. Ha több összetartozó változékony metódust emelünk ki, akkor azt állapottervezési mintának hívjuk.
Az alábbi forráskódban, azaz a kacsás példában minden fenti megállapítás kiemelésre került megjegyzések segítségével, azaz az objektum-összetételt megvalósító sorok, a felelősség beinjektálását megvalósító sorok, a felelősség átadását (idegen szóval delegálását) megvalósító sorok.
Forráskód 1.:
using System;

abstract class Kacsa
{
    public abstract void Hápog();
    public abstract void Repül();
}	
class SzépKacsa : Kacsa
{
    HápogásiStratégia hs; // objektum-összetétel
    RepülésiStratégia rs; // objektum-összetétel
    public SzépKacsa(HápogásiStratégia hs, RepülésiStratégia rs)
    {
        this.hs = hs; // felelőség beinjektálása
        this.rs = rs; // felelőség beinjektálása
    }
    public override void Hápog()
    {
        hs.Hápog(); // felelőség átadása a stratégiának, azaz delegáció
    }
    public override void Repül()
    {
        rs.Repül(); // felelőség átadása a stratégiának, azaz delegáció
    }
}
// ide emelem ki a változékony Hápog metódus kódját
abstract class HápogásiStratégia
{
    public abstract void Hápog();
}
// ide emelem ki a változékony Repül metódus kódját
abstract class RepülésiStratégia
{
    public abstract void Repül();
}
// itt jönnek a konkrét repülési és hápogási stratégiák
class NormálHápogás : HápogásiStratégia
{
    public override void Hápog()
    {
        Console.WriteLine("HápHáp");
    }
}
class RekedtHápogás : HápogásiStratégia
{
    public override void Hápog()
    {
        Console.WriteLine("HákrrHákrrr");
    }
}
class NemRepül : RepülésiStratégia
{
    public override void Repül()
    {
        Console.WriteLine("Nem tud repülni");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Kacsa donald =
            new SzépKacsa(
                new RekedtHápogás(), // felelőség beinjektálása
                new NemRepül()       // felelőség beinjektálása
            );
        donald.Hápog(); // késői kötés miatt a RekedtHápogás-ból hívja
        donald.Repül(); // késői kötés miatt a NemRepül-ből hívja
        Console.ReadLine();
    }
}

Forráskód 2.:
using System;

public abstract class KávéStratégia
{
    public abstract void KávéFőzés();
}
public class GyengeKávé : KávéStratégia
{
    public override void KávéFőzés()
    {
        Console.WriteLine("Gyenge kávét főztél. Ha csak kicsit vagy fáradt.");
    }
}
public class NormalKávé : KávéStratégia
{
    public override void KávéFőzés()
    {
        Console.WriteLine("Normál kávét főztél. Egy átlagos napra.");
    }
}
public class ErősKávé : KávéStratégia
{
    public override void KávéFőzés()
    {
        Console.WriteLine("Egy erős kávé. A hosszú és fárasztó napokra.");
    }
}
public class KávéGép
{
    private KávéStratégia kávéStratégia;
    public void KávéValasztás(KávéStratégia k)
    {
        kávéStratégia = k;
    }
    public void KávéFőzés()
    {
        kávéStratégia.KávéFőzés();
    }
}
class Program
{
    static void Main(string[] args)
    {
        KávéGép automata = new KávéGép();
        automata.KávéValasztás(new GyengeKávé());
        automata.KávéFőzés();
        automata.KávéValasztás(new ErősKávé());
        automata.KávéFőzés();
        automata.KávéValasztás(new NormalKávé());
        automata.KávéFőzés();
        Console.ReadLine();
    }
}
UML ábra:

UML ábra a stratégia tervezési mintára
PlantUML szkript:
@startuml
abstract class KávéStratégia{
+ {abstract} KávéFőzés(): void
}
class GyengeKávé{}
class ErősKávé{}
class NormálKávé{}
class KávéGép{
- KávéStratégia _kávéStratégia
+ void KávéFőzés()
+ void KávéVálasztás(KávéStratégia)
}
KávéStratégia <|-- GyengeKávé
KávéStratégia <|-- ErősKávé
KávéStratégia <|-- NormálKávé
KávéGép o-right-> KávéStratégia
@enduml
Gyakorlófeladat 1.: A Kacsa osztályt egészítsük ki az Úszik metódussal. Mivel ez egy változékony metódus, szervezzük ki egy külön stratégiába, az ÚszásiStratégia nevű osztályhierarchiába. Ezzel egészítsük ki a SzépKacsa osztályt a RepülésiStartégia és az HápogásiStartégia megoldását követve.
Gyakorlófeladat 2.: A KávéStratégia példában az alábbi két sor sorrendjét cseréljük fel:
        automata.KávéValasztás(new GyengeKávé());
        automata.KávéFőzés();

A kérdés az, hogy ez milyen futási hibához fog fezetni, illetve, hogyan lehet megakadályozni, hogy ez a hiba fellépjen a KávéGép osztály kódjának megváltoztatásával.
Gyakorlófeladat 3.: Készítsük el az alábbi leírásnak megfelelő forráskódot. A feladat megoldásához használjuk a stratégia tervezési mintát!
Feladat: Micsoda megtiszteltetés! A Magyar Forma-1 istálló megkért minket, hogy készítsünk nekik programot, hogy milyen időben milyen vezetési stílust válasszanak a pilóták. Tettük is a dolgunkat a feladat komolyságához méltón. Elkészült a kód és mi az esti tévézés helyett kivetítettük, hogy gyönyörködjünk a jól végzett munkánk eredményében. A kreációnk tele volt switch és if-else-if elágazásokkal, amik az időjáráshoz képest más és más vezetési stílusú függvényt hívtak meg. Halk, elégedett mormogás a sötét teremben, amikor valaki felkiáltott: én azt olvastam, hogy ha egy kódban sok a feltételes utasítás, akkor nézd meg, hátha rá tudsz húzni egy stratégiát. Sajnos a főnők is ott volt, úgyhogy nem volt mit tenni. A már megszokott absztrakt osztállyal kezdtük. Ennek neve VezetésiStratégia lett. Ennek van egy absztrakt függvénye, a Vezet, ez írja le a technikát. Ebből születnek a konkrét osztályok, mint például a CsúszósÚtStratégia vagy a NaposIdőStratégia. Ezek az osztályok kidolgozzák a legjobb stílust a Vezet függvényükben. Már csak egy osztály hiányzott, a Pilóta, melynek van egy Stílusválasztás függvénye, ami paraméterként egy VezetésiStratégia példányt vár. Pilótánk másik függvénye a Versenyez. Ez csak a beállított stratégia Vezet függvényét hívja meg. A verseny napján létrehozunk egy Pilóta példányt az útviszonyoknak megfelelő VezetésiStratégiával, meghívjuk a Versenyez függvényt és vasárnap délután elégedetten nézzük, ahogy megnyeri a versenyt.
Látogató – Visitor
A látógató (angolul: visitor) viselkedési tervezési minta egy vagy több változékony metódust szervez ki egy másik osztály hierarchiába. A kiszervezett metódusokat ágens technológiának megfelelően képes fogadni és kiszolgálni.
A látógató tervezési mintát akkor használjuk, ha már van egy kiforrott adatszerkezetünk, pl. bináris fa, lista, sor (angolul: queue) vagy verem (angolul: stack), ami már előreláthatóan nem fog változni, de lehetőséget akarunk adni arra, hogy könnyen lehessen bővíteni az adatszerkezetet feldolgozó algoritmusok sorát. Ilyenkor érdemes szétválasztani az adatszerkezetet és a feldolgozó metódusokat. Az adatszerkezetbe mindösszesen egy látogató fogadás (angolul: accept visitor) metódus kell, ami fogadja a látogatókat. A látogató fogadás metódus kódja mindig ugyanaz: v.Visit(this).
Ily módon nagyon egyszerű új látogatót írni, de ha megváltozik az adatszerkezet, akkor az összes látogató kódját frissíteni kell. Ez a látogató minta hátránya.
Ágensalapú programozás: Az ágensalapú (angolul: agent based) programozás a kliens–szerver architektúra alternatívája. A kliens–szerver architektúra remekült bevált a gyakorlatban, de néha azért vannak gondok. Abban az esetben, ha a kliens által elvégzendő számoláshoz nagyon sok adatra van szükség a szerverről, de maga a számolás eredménye ehhez mérten elenyésző méretű, akkor jobb az ágensalapú programozás.
A kliens–szerver architektúrában adat mozog a szerver és a kliens között. Ezzel szemben az ágensalapú programozásnál végrehajtható kód mozog a két gép között. Ezt a végrehajtható kódot hívjuk ágensnek.
Az ágens a kliensről indul valamilyen speciális feladattal. Eljut a szervergépre. Az ott lévő adatok segítségével elvégzi a feladatát, az eredményt megjegyzi, majd visszatér, és az ágens tájékoztatja megbízóját az eredményről.
Legyen most az a feladatunk, hogy megtudjuk, hány perces a legújabb szuper mozifilm. Két lehetőségünk van:
Vagy letöltjük a filmet a szolgáltatótól és miután lejött, megnézzük, hány perces. Ez a klasszikus kliens-szerver megoldás.
Vagy írunk egy kis scriptet, feltöltjük a scriptet a szolgáltató szerverére, a script megnézi, hány perces a film, és visszakapjuk az értéke. Ez már nagyon hasonlít az ágensalapú megoldáshoz, annyi a különbség, hogy az ágenst nem nekem kell távolról indítani, nekem csak elküldeni kell, és ha megérkezik, akkor magától elindul.
Látható, hogy a második megoldás sokkal kisebb hálózati adatforgalommal jár. Ez az ágensalapú megoldás előnye. Ugyanakkor ez a módszer távolról se terjedt el, hiszen ki szeretné, hogy mindenféle külvilágból érkező kód lefuthasson a szerverén. Ezek a kódok könnyen lehetnek rosszindulatúak is.
A megoldás az úgynevezett homokozó (angolul: sandbox) használata. A szerveren létrehozok egy homokozót, ami lényegében egy virtuális szerver saját erőforrásokkal, csak olvasható állományokkal, illetve egy kicsi írható-olvasható háttértárral is. A homokozó általában a CPU és a memória 10%-át kaphatja meg maximálisan és időnként újraindul a homokozó, hogy a beragadt ágensek ne foglalják a helyet a működők elől.
A homokozóban minden szabad, kivéve egyet, kijönni a homokozóból. Tehát szabad lökdösődni, futkározni, sőt verekedni is, de nem szabad a homokozón kívül üldögélő szülőket megdobálni.
Az ágensalapú programozás tervezési minta megfelelője a látogató (angolul: visitor) tervezési minta. A látogató mintában az adatszerkezet a szerver, a fogad metódus a homokozó, a látogató pedig az ágens.
A jegyzetben találunk még egy alfejezetet erről a tervezési mintáról, ahol tovább finomítjuk eddigi ismereteinket, hiszen ebben a részben még nem fejtettünk ki egy fontos fogalmat, a dupla hivatkozásfeloldás (angolul: double dispatch). Forráskód:
using System;
public abstract class BFa
{
    BFa bal, jobb;
    public BFa Bal { get { return bal; } }
    public BFa Jobb { get { return jobb; } }
    public BFa(BFa bal, BFa jobb)
    {
        this.bal = bal;
        this.jobb = jobb;
    }
    public BFa() : this(null, null) { }
    public abstract void AcceptVisitor(Visitor v);
}
public class Fa : BFa
{
    int szám;
    public int Szám { get { return szám; } }
    public Fa(int szám, BFa bal, BFa jobb) : base(bal, jobb)
    {
        this.szám = szám;
    }
    public override void AcceptVisitor(Visitor v)
    {
        v.Visit(this);
    }
}
public class Levél : BFa
{
    int szám;
    public int Szám { get { return szám; } }
    public Levél(int szám) : base()
    {
        this.szám = szám;
    }
    public override void AcceptVisitor(Visitor v)
    {
        v.Visit(this);
    }
}
public abstract class Visitor
{
    public abstract void Visit(Fa f);
    public abstract void Visit(Levél f);
}
public class SumVisitor : Visitor
{
    int sum = 0;
    public int Sum { get { return sum; } }
    public override void Visit(Fa f)
    {
        sum += f.Szám;
        if (f.Bal != null) f.Bal.AcceptVisitor(this);
        if (f.Jobb != null) f.Jobb.AcceptVisitor(this);
    }
    public override void Visit(Levél f)
    {
        sum += f.Szám;
    }
}
public class MaxVisitor : Visitor
{
    int max = int.MinValue;
    public int Max { get { return max; } }
    public override void Visit(Fa f)
    {
        if (f.Szám > max) max = f.Szám;
        if (f.Bal != null) f.Bal.AcceptVisitor(this);
        if (f.Jobb != null) f.Jobb.AcceptVisitor(this);
    }
    public override void Visit(Levél f)
    {
        if (f.Szám > max) max = f.Szám;
    }
}

class Program
{
    static void Main(string[] args)
    {
        BFa fa = new Fa(5, new Levél(8), new Levél(3));
        Visitor sumv = new SumVisitor();
        Visitor maxv = new MaxVisitor();
        fa.AcceptVisitor(sumv);
        fa.AcceptVisitor(maxv);
        Console.WriteLine("A fában lévő számok összege: {0}", sumv.Sum);
        Console.WriteLine("A fában lévő legnagyobb szám: {0}",maxv.Max);
        Console.ReadLine();
    }
}

Gyakorlófeladat: Ezt a mintát elsőre nehéz megérteni, de ha a fenti fához írunk egy-két további látogatót a meglévő Sum és Max mellé, mondjuk a Min, vagy a ToString látogatót, akkor elsajátítjuk a minta működését. Tehát a fenti példát egészítsük ki a MinVisitor és a ToStringVistor osztályokkal, illetve ezek egy-egy példányát hívjuk meg a főprogramból.
Dupla hivatkozásfeloldás – Double dispatch 
Azt szoktuk mondani, hogy a Látogató tervezési minta az egyetlen, amit józan paraszti ésszel nehéz kitalálni. Minden más tervezési mintát egy kis tapasztalat után és egy kis józan paraszti ésszel bárki képes újra felfedezni. Ennek oka a dupla hivatkozásfeloldás (angolul: double dispatch).
Általában csak egyszeres hivatkozásfeloldásra van szükségünk, a késő kötésre. Ha van egy polimorfikus metódus hívásunk, például: referencia.valamiHasznos(), akkor a késő kötés oldja fel, hogy az osztály hierarchiában lévő több valamiHasznos() nevű metódus közül melyik fog lefutni. Ehhez a késő kötés megnézi, hogy a referencia milyen példányra mutat, és a példány metódusa kerül meghívásra.
Ugyanakkor van egy másik eset is, amikor hivatkozásfeloldásra van szükségünk, ez a metódus túlterhelés (angolul: overloading), amikor egy metódusból több változat van más-más paraméter listával. Például, tegyük fel, hogy a valamiHasznos metódust túlterheltük:
void valamiHasznos(int i) { … }
void valamiHasznos(String s) { … }
Most, ha belefutunk egy hívásba: valamiHasznos(x), akkor a x kifejezés típusától függ, hogy melyik változat fog lefutni.
Dupla hivatkozásfeloldás (angolul: double dispatch) esetén mind a két fajta hivatkozásfeloldásra szükségünk van. Például a referencia.valamiHasznos(x) hívásnál először késői kötéssel kell meghatároznunk, hogy melyik osztály példányából kell futtatni a metódust, majd az x kifejezés típusának segítségével kell meghatároznunk, hogy melyik túlterhelt változatnak kell futnia.
Pontosan ezt használja ki a Látogató tervezési minta. Nézzük részletesen, hogy hogyan. Látogató tervezési mintát akkor használunk, ha már van egy jól kiforrott, kitesztelt adatszerkezetünk, amit már nem akarunk bővíteni. Ez a fenti példában a BFa osztály hierarchia, ami áll a BFA, a Fa és a Levél osztályokból.
Ahhoz, hogy az adatszerkezetet képes legyen feldolgozni egy látogató, ehhez minden osztály implementálja az AcceptVisitor metódust, méghozzá mindenki teljesen ugyanúgy:
void AcceptVisitor(Visitor v) { v.Visit(this); }
Azaz fogadunk egy látogatót, v, majd rögtön meghívjuk a Visit metódusát önmagunkkal: v.Visit(this). Erről nagyon könnyen felismerhető a Látogató tervezési minta, és itt van a dupla hivatkozásfeloldás. Ahhoz, hogy tudjuk, hogy melyik metódusnak kell lefutnia, tudnunk kell milyen látogatóra mutat a v referencia. És hogy ezen belül a visit metódusnak melyik változata fusson le, ahhoz tudnunk kell a this típusát, ugyanis a Visit-nek az ősön kívül minden adatszerkezet osztályra fel kell készülnie:
void Visit(Fa f)
void Visit(Levél f)
Ha a this típusa Fa volt, akkor az első változat fut le, ha Levél, akkor a második.
Tehát a v.Visit(this) hívás feloldásához dupla hivatkozásfeloldás kell, azaz a Látogató tervezési minta alapja a dupla hivatkozásfeloldás.
Összegzés és ellenőrző kérdések
Ebben a leckében áttekintettünk 5 fontos viselkedési tervezési mintát, úgy mint: Állapot, Megfigyelő, Sablonmetódus, Stratégia, Látógató. A viselkedési tervezési minták olyan megoldást biztosítanak, amelyek könnyen bővíthetők új viselkedéssel. Ehhez általában csak egy új alosztállyal kell bővíteni a meglévő osztály hierarchiát.
Ellenőrző kérdések:
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
