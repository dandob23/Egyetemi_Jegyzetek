### SRP (Single Responsibility Principle) – Egy felelősség - egy osztály alapelve 

- minden osztálynak egyetlen felelősséget kell lefednie, de azt teljes egészében („A class should have only one reason to change” - „Az osztályoknak csak egy oka legyen a változásra”)
- ha egy osztály nem fedi le teljesen a saját felelősségi körét, akkor muszáj implementációra programozni, hogy egy másik osztály megvalósítsa azokat a szolgáltatásokat, amik kimaradtak az osztályból.
- Ha egy osztály több felelősségi kört is ellát, akkor sokkal jobban ki van téve a változásoknak, mintha csak egy felelősséget látna el. 
	- pl.: a MacsKuty eszik, alszik, ugat, egerészik,
	- A MacsKuty osztályt meg kell változtatni, ha kiderül, hogy a kutyák nem csak a postást ugatják meg, hanem a bicikliseket is, illetve akkor is, ha a macskák viselkedése változik vagy bővül.
- minden módosítás magában hordozza a veszélyt, hogy egy forráskódszörnyet kapjunk, amihez már senki se mer hozzányúlni. Az ilyen kód fejlesztése nagyon drága.
- Gyakran szembesülünk -> szeretnénk, hogy **minden osztálynak csak egy oka legyen a változásra**, azaz egy felelősségi kört lásson el, **de minden osztálynak kell naplóznia vagy a jogosultságokat ellenőriznie**.
	- megoldás: **aspektusorientált programozás**
	- Ezeket a felelősségeket, mint például a naplózás, kiemeljük egy úgynevezett aspektusba, amit bármely osztályhoz hozzákapcsolhatunk
	- Bob bácsi szerint a legfontosabb SOLID alapelv az SRP
- felelősséglánc tervezési minta **jó példa**

### LSP (Liskov Substitution Principle) – Liskov-féle behelyettesítési alapelv

- a program viselkedése nem változhat meg attól, hogy az ős osztály egy példánya helyett a jövőben valamelyik gyermekosztályának példányát használjuk.
- tehát, a program által visszaadott érték nem függ attól, hogy egy Kutya vagy egy Vizsla vagy egy Komondor példány lábainak számát adjuk vissza

Nézzünk egy példát, amely nem felel meg az LSP elvnek. 

```csharp
class Téglalap
{
	protected int a, b;
	//@ utófeltétel: a == x és b == \régi(b)
	public virtual void SetA(int x) { a = x; }
	public virtual void SetB(int x) { b = x; }
	public int Terület() { return a * b; }
}
```
```csharp
class Négyzet : Téglalap
{
	// invariáns: a == b;
	// utófeltétel: a == x && b == x;
	public override void SetA(int x) { a = x; b = x; }
	public override void SetB(int x) { a = x; b = x; }
}
```

- A fenti példában az a és b mezőt használjuk a téglalap oldalhosszainak tárolására. 
- Mindkét mezőhöz tartozik egy szetter metódus. 
- A Négyzet osztályban a két szetter metódust felül kellett írni, mert a négyzet két oldala egyenlő. 
- Azt mondjuk, hogy ez a Négyzet osztály invariánsa, mert minden metódushívás előtt és után igaznak kell lennie, hogy a két oldal egyenlő. 
- A `SetA` metódusnak megadtuk az utófeltételét is. 
- A gond az, hogy a `Négyzet` osztályban a `SetA` utófeltétele gyengébb, mint a `Téglalap` osztályban. Pedig, mint látni fogjuk, a gyermekosztályban az utófeltételeknek erősebbeknek, az előfeltételeknek gyengébbeknek kellene lennie, hogy betartsuk az LSP elvet.

```csharp
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
```

- A fenti főprogram 50%-os valószínűséggel a Téglalap osztályt, 50%-os valószínűséggel ennek gyermekosztályát a Négyzetet példányosítja. 
- Ha az LSP igaz lenne, akkor mindegy lenne, melyik osztály példányán keresztül hívjuk a Terület metódust, de ez nem igaz, mert a `SetA` és a `SetB` teljesen másképp viselkedik a két osztályban. 
- Ennek megfelelően egyszer 50, egyszer 25 lesz a kiírt érték. 
- Azaz a program viselkedése függ attól, melyik példányt használjuk, azaz **az LSP elvet megszegtük**.
- A probléma az, hogy **a Négyzet alosztálya a Téglalapnak, de nem altípusa**.

### ISP (Interface Segregation Principle) – Interfészszegregációs-alapelv

- egy sok szolgáltatást nyújtó osztály fölé el kell helyezni interfészeket => **minden kliens**, amely használja az osztály szolgáltatásait, **csak azokat a metódusokat lássa, amelyeket ténylegesen használ**.
- „No client should be forced to depend on methods it does not use”, azaz „Egy kliens se legyen rászorítva, hogy olyan metódusoktól függjön, amiket nem is használ”
- segít a fordítási függőség visszaszorításában
- Képzeljük el, hogy minden szolgáltatást, például egy fénymásoló esetén a fénymásolást, nyomtatást, faxküldést, a példányok szétválogatását egy nagy Feladat osztály látna el.
- ekkor, **ha a fénymásolás rész megváltozik**, akkor **újra kell fordítani a Feladat osztályt** és lényegében az egész alkalmazást, **mert mindenki innen hívja** a szolgáltatásokat.
	- megoldás: minden klienshez készítünk egy interfészt, amely csak azokat a metódusokat tartalmazza, amelyeket a kliens ténylegesen használ.
		- `kliens: a forráskód azon része, ami használja az osztály szolgáltatásait`
	- Tehát lesz egy fénymásoló, egy nyomtató, egy fax és egy szétválogatás interfész.
	- A Feladat ezen interfészek mindegyikét implementálja.
	- Az egyes kliensek a Feladat osztályt (`kövér osztály`) a nekik megfelelő interfészen keresztül fogják csak látni, mert ilyen típusú példányként kapják meg. Ezáltal ha megváltozik a Feladat osztály, akkor az alkalmazásnak csak azt a részét kell újrafordítani, amit érint a változás.
	- A kövér osztályokat az egy felelősség - egy osztály elv (SRP) kizárja, de ha már van egy ilyen osztályunk, akkor egyszerűbb fölé tenni néhány interfészt, mint a kövér osztályt szétszedni kisebbekre. 

- Ha betartjuk az ISP-t
	- a forráskód kevésbé csatolt lesz
	- egyszerűbben változtatható. 
- az illesztő tervezési minta **jó példa**

Egy egyszerű példa:
```csharp
interface IWorkable { void Work(); }
```
```csharp
interface IFeedable { void Eat(); }
```
```csharp
interface IWorker : IFeedable, IWorkable {}
```
```csharp
class Worker : IWorker
{
	public void Work() { /* dolgozik */ }
	public void Eat() { /* eszik */ }
}
```
```csharp
class Program
{
	public static void Main(String[] args)
	{
    	  IWorkable workable = new Worker();
    	  IFeedable feedable = new Worker();
    	  IWorker worker = new Worker();
	}
}
```

### DIP (Dependency Inversion Principle) – Függőség megfordításának alapelve

- **a magas szintű komponensek ne függjenek alacsony szintű implementációs részleteket kidolgozó osztályoktól**, *se fordítva*
- hanem **a magas szintű és az alacsony szintű komponensek is *absztrakciótól* függjenek**.
- „High-level modules should not depend on low-level modules. Both should depend on abstractions.” Azaz: „A magas szintű modulok ne függjenek az alacsony szintű moduloktól. Mindkettő függjön az absztrakciótól.”
- tehát: „Absztrakciótól függj, ne függj konkrét osztályoktól”.
- Az alacsony szintű komponensek újrafelhasználása jól megoldott az úgynevezett osztálykönyvtárak (angolul: library) segítségével
	- Ezekbe gyűjtjük össze azokat a metódusokat, amikre gyakran szükségünk van.
- A magas szintű komponensek, amik a rendszer logikáját írják le, általában nehezen újrafelhasználhatók.
	- Ezen segít a függőség megfordítása.
	- Vegyük a következő egyszerű leíró nyelven íródott kódot:

```csharp
public void Copy() { while( (char c = Console.ReadKey()) != EOF) Printer.printChar(c); }
```

- A Copy metódus **függ** a `Console.ReadKey` és a `Printer.printChar` metódustól.
- fontos logikát ír le, *a forrásból a célra kell másolni karaktereket fájl vége jelig.*
- Ezt a logikát **sok helyen fel lehet használni**, hiszen a forrás bármi lehet és a cél is, ami karaktereket tud beolvasni, illetve kiírni.
- Ha ezt a kódot újra akarjuk hasznosítani, akkor **két lehetőségünk** van. 
	- 1: `if – else – if` szerkezet segítségével megállapítjuk, hogy most melyik forrásra, illetve célra van szükségünk. => csúnya, nehezen átlátható, nehezen módosítható kódot eredményez.
	- 2: a forrás és a cél referenciáját kívülről adjuk meg a hívó felelősség injektálásával (dependency injection).
		- felelősség injektálása: 
			- konstruktorral: Ebben az esetben az osztály a konstruktorán keresztül kapja meg azokat a referenciákat, amiken keresztül a neki hasznos szolgáltatásokat meg tudja hívni. (**objektum-összetétel**, *leggyakoribb*)
			- szetter metódusokkal: Ebben az esetben az osztály szetter metódusokon keresztül kapja meg azokat a referenciákat, amikre szüksége van a működéséhez. (ezt csak akkor, ha opcionális működés megvalósításához kell objektum-összetételt alkalmaznunk.)
			- interfész megvalósításával: Ha a példányt a magas szintű komponens is elkészítheti, akkor elegendő megadni a példány interfészét, amit általában maga a magas szintű komponens valósít meg, de paraméterosztály paramétereként is jöhet az interfész.
			- elnevezési konvenció / konfigurációs állomány / annotáció alapján: Ez általában keretrendszerekre jellemző. Ezeket csak tapasztalt programozóknak ajánljuk, mert nyomkövetéssel nem lehet megtalálni, hogy honnan jön a példány és ez nagyon zavaró lehet.	

Felelősség beinjektálása konstruktorral:

```csharp
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
```

- Sok kritika: csak az objektum-összetétel használatának, azaz a GOF2 elvnek egy következménye. 
- Mások szerint ez egy önálló tervezési minta. 
- Mindenesetre -> rugalmas lesz a kód

### GOF

„Programozz felületre implementáció helyett” alapelv (GOF1):
- arra ösztönzi a tervezőket, hogy az interfészre programozzanak, ne pedig az implementációra. 

„Használj objektum-összetételt öröklés helyett, ha csak lehet” (GOF2):
- inkább objektum-összetételt alkalmazzanak az öröklés helyett. 
- Az öröklés előnyeit és korlátait összehasonlítva láthatjuk, hogy az objektum-összetétel rugalmasabb és jobban támogatja a tervezési változásokat. 

IS-A és HAS-A kapcsolat:
- Az IS-A kapcsolat az öröklődést jelenti
- a HAS-A kapcsolat az objektum-összetételt. 

aggregáció és a kompozíció:
- két különböző objektum-összetétel típus
- Aggregáció esetén a rész létezhet az egész nélkül is. 
- Kompozíció esetén a rész nem létezhet az egész nélkül. 

átlátszó és átlátszatlan becsomagolás:
- bjektum-összetétel típusai.

#### A GOF könyv 1. alapelve – GOF1
- „Program to an interface, not an implementation”, azaz „Programozz felületre implementáció helyett”.
- Akkor programozunk implementációra, ha kihasználjuk, hogy egy osztály hogyan lett implementálva. 
Egy példát a MyHashSet osztályon keresztül már láttunk, amikor tudnunk kellett, hogyan lett az ős implementálva. 

Egy másik példa:
```csharp
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
```

- A fenti példában készítettünk egy `NagySzám` osztályt, amely a nagy szám számjegyeit a számjegyek tömbben tárolja. 
- A legkisebb helyiértékű szám van a legkisebb indexen. 
- A konstruktor ezt a tömböt tölti fel. 
- Ezen túl két metódust látunk, az egyik az összeadás, a másik long típusú számmá alakítja vissza a számjegyek tömbben tárolt számot. 
- A tömbben tárolt szám számrendszerének alapja az alap konstansban van eltárolva. 

Most 10-es számrendszer az alapértelmezett. De mi van, ha az alap megváltozik? 
Sajnos akkor minden kód, ami feltételezi, hogy 10-es számrendszert használunk, az elromlik. 

Például az alábbi is:
```csharp
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
```

- A fenti kód 374-et ír ki, ha az alap 10-es, 252-öt, ha az alapot átírjuk 8-ra, és így tovább. 
- Tehát a NagySzám belső implementációja befolyásolja az őt használó osztályok működését. 
- A problémát az okozza, hogy a bemeneti szám átalakítását lusták voltunk elvégezni, habár az a NagySzám felelőssége lenne. 
- Az átalakítást a hívóra hagytuk, de ez rossz megoldás, mint ahogy láttuk.
- A megoldás, ha egy olyan konstruktort csinálunk, ami egy long típusú számot vár. A másik konstruktort priváttá kell tenni. Ebben az esetben akármilyen belső alapot használunk, az nem fogja zavarni a többi osztályt. 
- Tehát a jó megoldás (csak a megváltozott és az új kódot mutatjuk):

```csharp
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
```
```csharp
class Program {
	static void Main(string[] args) {
    	  NagySzám A = new NagySzám(53);
    	  NagySzám B = new NagySzám(321);
    	  NagySzám C = NagySzám.Összead(A, B);
    	  Console.WriteLine(C.ToLong()); //374
    	  Console.ReadLine();
	}
}
```

- Most már akármilyen számrendszert használ a NagySzám, mindig 374 lesz az eredmény.
- Látható, hogy általában akkor kényszerülünk implementációra programozni, ha az osztály felelősségi körét rosszul határoztuk meg és egy osztály több felelősségi kört is lefed, vagy egy felelősséget nem teljesen fed le, mint a NagySzám. 
- Tehát, ha a kódunkban találunk olyan részt, amely egy másik osztály implementációjától függ, akkor az hibás tervre utal.
- Ha implementációra programozunk, és ha megváltozik az osztály, akkor a vele kapcsolatban álló osztályoknak is változniuk kell. 
- Ezzel szemben, **ha felületre programozunk**, és megváltozik az implementáció, de a felület nem, akkor **nem kell megváltoztatni a többi osztályt**.

#### A GOF könyv 2. alapelve – GOF2
- „Favor object composition over class inheritance”, azaz „Használj objektum-összetételt öröklés helyett, ha csak lehet”.
- Már láttuk, hogy objektum-összetétellel mindig ki lehet váltani az öröklődést. 
- Az öröklés azért jó, mert megörököljük az ős összes szolgáltatását (metódusait), amit használni tudunk. 
- Objektum-összetételnél ezen osztály egy példányára szerzek egy referenciát és azon keresztül használjuk a szolgáltatásait. 
- Ez utóbbi futási időben dinamikusan változhat, hiszen az, hogy melyik objektumra mutat a referencia, futási időben változtatható.

#### Az IS-A és a HAS-A kapcsolat

- Az öröklődést IS-A kapcsolatnak hívjuk. 
	- Ha a Kutya osztály a Gerinces osztály gyermeke, akkor azt mondjuk, hogy „a kutya egy gerinces”, azaz angolul „the dog ’is a’ vertebrate”. 
	- Innen jön az IS-A elnevezés.
	- IS-A kapcsolatnak nevezzük azt is, amikor egy osztály megvalósít egy interfészt, hiszen ekkor az osztály példányai megkapják az interfész típusát is.

- Az objektum-összetételt HAS-A kapcsolatnak hívjuk. 
	- Ha a Kutya osztályban van egy gerinc nevű mező, ami Gerinces osztály típusú, akkor azt mondjuk, hogy „a kutyának van egy gerince”, azaz angolul „the dog ’has a’ backbone”. 
	- Innen jön a HAS-A elnevezés.

A következő példában a Kutya és a Gerinces osztály közt IS-A kapcsolat, a Kutya2 és a Gerinces osztály közt pedig HAS-A kapcsolat van.
```csharp
class Gerinces {
	public void LábVezérlés() {
    	  Console.WriteLine("mozog a lába.");
	}
}
```
```csharp
class Kutya : Gerinces {
	public void Fut() {
    	  Console.Write("Gyorsan ");
    	  LábVezérlés();
	}
}
```
```csharp
class Kutya2 {
	Gerinces gerinc;
	public Kutya2(Gerinces gerinc) { this.gerinc = gerinc; }
	public void Fut() {
    	  Console.Write("Gyorsan ");
    	  gerinc.LábVezérlés();
	}
}
```
```csharp
class Program {
	static void Main(string[] args) {
    	  Kutya bodri = new Kutya();
    	  bodri.Fut();
    	  Kutya2 rex = new Kutya2(new Gerinces());
    	  rex.Fut();
    	  Console.ReadLine();
	}
}
```

- Mindkét megoldás esetén a Fut metódus ugyanúgy működik. 
- Ez a példa is mutatja, hogy az öröklődés kiváltható objektum-összetétellel, azaz az IS-A kapcsolat kiváltható HAS-A kapcsolattal.

#### Átlátszó és átlátszatlan újrahasznosítás

- Az **öröklődést** néha **átlátszó újrahasznosításnak** (angolul: white box reuse) is hívjuk. 
- Ezzel arra utalunk, hogy az örökölt metódusokat használhatjuk és azokról sok információnk van, gyakran ismerjük a forráskódjukat is.
----
- Az **objektum-összetételt** **átlátszatlan újrahasznosításnak** (angolul: black box reuse) is hívjuk. 
- Ezzel arra utalunk, hogy az összetételt megvalósító mezőn keresztül hívhatunk metódusokat, de azok megvalósításáról általában nincs információnk.

#### Aggregáció és kompozíció

- Az objektum-összetételt, vagy más néven a HAS-A kapcsolatot több szempontból is lehet osztályozni. 
- Az első szempont a birtoklás módja, a második a becsomagolás (angolul: wrapping) módja.

- Az első szempont azt helyezi a középpontba, hogy az objektum-összetétel mindig birtoklást fejez ki. 
	- Pl. a kutyának van farka. 
- A második szempont pedig azt hangsúlyozza ki, hogy az objektum-összetételnél a birtokolt objektumot a birtokló becsomagolja. 
	- Pl. a tűzfal becsomagol egy szervert, amely csak rajta keresztül érhető el.

- A birtoklás módja szerint az objektum-összetétel lehet aggregáció és a kompozíció:

- **Aggregáció** (angolul: aggregation): A birtokolt példány nem csak az enyém, azt más is használhatja. 
	- Például a kutyának van gazdija, de a gazdi nem csak a kutyáé. 

Ennek a példának megfelelő kódrészlet:
```csharp
   class Ember { }
```
```csharp
   class Kutya
   {
  	Ember gazdi; // HAS-A kapcsolat, amit a gazdi nevű mező valósít meg
  	public Kutya(Ember gazdi) { this.gazdi = gazdi; }
   }
```
```csharp
   class Program
   {
  	public static void Main()
	{
    	 Ember gabi = new Ember();
    	 Kutya buksi = new Kutya(gabi); // gabi nem csak buksi gazdija
     	 Kutya cézár = new Kutya(gabi); // nem kizárólagos tulajdonlás
  	}
   }
```
```csharp

----

- Kompozíció (angolul: composition): A birtokolt példány csak az enyém, azt más nem is ismerheti. 
	- Például a kutyának van farka, azt csak ő csóválhatja. 

Ennek a példának megfelelő kódrészlet:
```csharp
class KutyaFarok { public void Csóvál() { } }
```
```csharp
   class Kutya
   {
  	KutyaFarok farok; // HAS-A kapcsolat, amit a farok nevű mező valósít meg
  	public Kutya() { farok = new KutyaFarok(); } // kizárólagos tulajdonlás
  	public void Csóvál() { farok.Csóvál(); }
   }
```

Vizsgáljuk meg az aggregációt és a kompozíciót. Vegyük a következő esetet: 
- „A gitárosnak van egy gitárja.” -> objektum-összetétel, hiszen HAS-A kapcsolat van a gitáros és a gitár között. 
- **hogyan lehet eldönteni**: Ha a gitáros meghal, vele temetik a gitárját is? 
	- Ha igen, akkor kompozícióról beszélünk, 
	- ha nem, aggregációról. 
- Azaz, ha senki másnak nincs rá referenciája, és ezért a szemétgyűjtő felszabadítja, akkor kompozíció. 
- Aggregációra szép példa többek közt a stratégia tervezési minta. 
- Kompozícióra szép példa az állapot tervezési minta.

#### Átlátszó és átlátszatlan becsomagolás

- Az objektum-összetétel soha nem öncélú, hanem van rá valamilyen jó okunk. 
- Ez az ok nagyon gyakran az, hogy 
	- a saját metódusaink, más néven szolgáltatásaink, megírásához szükségünk van olyan metódusok hívására, amit a birtokolt objektumból lehet hívni. 
	- Más szóhasználattal azt mondjuk: **A saját szolgáltatásainkhoz szükségünk van a birtokolt objektum szolgáltatásaira**. 
- Ha azért birtoklunk egy objektumot, hogy a saját szolgáltatásaink felelősségét részben vagy egészben átadjuk neki (idegen szóval delegáljuk), akkor birtoklás mellett **becsomagolásról** is beszélünk.

A becsomagolás módja szerint a becsomagolás **lehet átlátszó vagy átlátszatlan**:

- **Átlátszó becsomagolás**: 
	- A becsomagolt példány ugyanolyan felületű, mint a becsomagoló
	- tehát, a becsomagolt objektum szolgáltatásai elérhetők a becsomagolón keresztül. 
	- Amikor hívjuk az A metódust, akkor az meghívja a becsomagolt objektum A metódusát. 
	- Más szóval, az A metódus átadja (idegen szóval delegálja) a felelősséget a becsomagolt objektum A metódusának. 

Ezt szemlélteti a lenti példa. 
- A megvalósításához kell egy IS-A és egy HAS-A kapcsolat is. 
	- A HAS-A kapcsolat lehet aggregáció és kompozíció is. 
	- Például a karácsonyfa karácsonyfa marad, akárhány díszt is teszünk rá. 
		- Ezt úgy érjük el, hogy a dísszel becsomagoljuk a karácsonyfát, úgy hogy az objektum majd minden, díszítéstől nem függő, metódusa egyszerűen meghívja a becsomagolt karácsonyfa ugyanolyan nevű metódusát. 
	- Azért van értelme, hogy a díszítés után a karácsonyfa karácsonyfa maradjon, mert így további díszeket lehet rátenni, lásd a díszítő tervezési mintát.

Példa kódrészlet, ami követi a fenti magyarázatot:
```csharp
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
```
----

- **Átlátszatlan becsomagolás**: 
- A becsomagolt példány nem ugyanolyan felületű, mint a becsomagoló, így a becsomagolt objektum szolgáltatásai rejtve maradnak, kívülről nem érhetők el. 
- Ugyanakkor az elérhető szolgáltatások elvégzéséhez felhasználhatók a becsomagolt objektum szolgáltatásai. 
- Ilyenkor nem elvárás, hogy ugyanaz legyen a metódus neve, mint aminek delegáljuk a felelősséget. 
- Azaz A metódusból nem biztos, hogy A metódust kell hogy hívjuk, hanem akár hívhatjuk a B metódust, vagy a C metódust, attól függően, hogy melyik valósítja meg azt a működést, amire szükségünk van. 
- A megvalósításához csak egy HAS-A kapcsolat kell. 
	- A HAS-A kapcsolat lehet aggregáció és kompozíció is. 

A fenti példa itt is használható, de ebben az esetben, a becsomagolt karácsonyfa nem marad karácsonyfa, azaz nincs IS-A kapcsolat, és ezért nem lehet újabb díszeket rátenni. 

Példa kódrészlet, ami követi a fenti magyarázatot:
   
```csharp
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
```

- Vizsgáljuk meg az átlátszó és az átlátszatlan becsomagolást is. 
- Az átlátszó becsomagolás általában aggregáció, de lehet kompozíció is. 
	- Ilyenkor a becsomagolt osztállyal gyermek (IS-A) és összetétel (HAS-A) viszonyban is állunk: 
	- „Az ős gyermeke vagyok, hogy ős típusként használható legyek. Illetve becsomagolom az ősöm egy példányát, hogy azon keresztül használhassam a szolgáltatásait.” 
	- Erre szép példa a dekorátor tervezési minta. 

- Átlátszatlan becsomagolás esetén: 
	- „Szintén használom a becsomagolt objektum szolgáltatásait, de azokat nem publikálom külvilág felé.” 
	- Erre szép példa az illesztő tervezési minta.


#### Az objektum-összetétel és a csatoltság

- Csatoltság szempontjából az öröklődés a legerősebb, majd jön a kompozíció és az aggregáció. 
- Éppen ez az oka, hogy a GOF2 kimondja, hogy használjunk inkább objektum-összetételt öröklődés helyett, hiszen az kisebb csatoltságot eredményez és így rugalmasabb kódot kapunk. 
	- Ugyanakkor ki kell emelni, hogy az ilyen kód nehezebben átlátható, ezért nem szabad túlzásba vinni az objektum-összetételt.

- Ha egy osztálynak van olyan mezője, amely lehet null értékű, akkor az a mező általában nem objektum-összetételt valósít meg, hanem az objektum-összetételtől lazább kapcsolatot, a barátságot (angolul: dependency). 
- A barátság egy átmeneti kapcsolat, gyakran nem is kell hozzá mező, elegendő annyi, hogy az objektum egy metódusában kap egy referenciát egy másik metódusra, kér tőle valamit és el is felejti.

#### GOF2 a gyakorlatban

- Egy másik ok, ami miatt nem váltunk ki minden öröklődést objektum-összetétellel, az az, hogy öröklődés nélkül nincs többalakúság (legalábbis erősen típusos nyelvek esetén). 
- Jól tudjuk, hogy egy osztályhierarchia tetején lévő osztály példánya helyett bármelyik gyermekosztály példányát használhatjuk. 
- Erre gyakran van szükségünk, hiszen így tudunk a változásokhoz könnyen alkalmazkodni. 
	- Például van egy gyermekosztályunk, ami Windows speciális, egy másik Unix speciális, az egyik környezetben az egyiket, a másikban a másikat használjuk.








