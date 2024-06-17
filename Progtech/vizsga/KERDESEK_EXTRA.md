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
