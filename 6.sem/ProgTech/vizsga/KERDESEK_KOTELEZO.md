### OCP (Open-Closed Principle) – Nyitva-zárt alapelv

- nyitva-zárt elv
- program forráskódja **legyen nyitott a bővítésre, de zárt a módosításra** („Classes should be open for extension, but closed for modification”)
- tehát, az osztályhierarchiánk legyen nyitott a bővítésre, de zárt a módosításra
- azt jelenti, hogy **új alosztályt vagy egy új metódust** nyugodtan **felvehetünk, de meglévőt nem írhatunk felül**.
- mert ha már van egy működő, letesztelt, kiforrott metódusunk és azt megváltoztatjuk, akkor több negatív dolog is történhet:
	- a változás miatt az eddig működő ágak hibásak lesznek,
	- a változás miatt a vele implementációs függőségben lévő kódrészeket is változtatni kell,
	- a változás általában azt jelenti, hogy olyan esetet kezelünk le, amit eddig nem, azaz bejön egy új if vagy else, esetleg egy switch, 
ami csökkenti a kód átláthatóságát, és egy idő után már senki se mer hozzányúlni.

- tehát, **ne használd az override kulcsszót**, **kivéve ha *absztrakt* vagy *horog*** (angolul: hook)
	- az **absztrakt** metódusokat muszáj felülírni, de ez nem az OCP megszegése, hiszen az absztrakt metódusnak **nincs törzse**, 
így lényegében a törzzsel bővítjük a kódot, nem módosítunk semmit. 
	- amikor **horog** (angolul: hook) metódust írunk felül. Akkor beszélek horog metódusokról, ha a metódusnak **van** ugyan **törzse**, **de az** teljesen **üres**. A horog metódus törzse üres, vagy csak egy return utasítás van benne egy alapértelmezett értékkel. *(pl: ToString)*
		- Ezek felülírása nem kötelező, csak opcionális, így arra használják őket, hogy a gyermekosztályok opcionálisan bővíthessék megvalósításukat.

A következő rövid példában **nem** tarjuk be az OCP elvet:
```csharp
class Alakzat
{
	public const int TEGLALAP = 1;
	public const int KOR = 2;
	int tipus;
	public Alakzat(int tipus) { this.tipus = tipus; }
	public int GetTipus() { return tipus; }
}
```
```csharp
class Teglalap : Alakzat{Teglalap():base(Alakzat.TEGLALAP){}}
```
```csharp
class Kor : Alakzat{ Kor():base(Alakzat.KOR){} }
```
```csharp
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
```

- ha a kódban -> `if - else if` => valószínűleg OCP megszegés
	- mert, ha új alakzatot akarunk hozzáadni a kódhoz, akkor az `if – else if` szerkezetet tovább kell bővítenünk.


Lássuk, hogy lehet ezt kivédeni:

```csharp
abstract class Alakzat{ public abstract void Rajzol(); }
```
```csharp
class Teglalap : Alakzat
{
	public override void Rajzol() { /* téglalapot rajzol */ }
}
```
```csharp
class Kor : Alakzat
{
	public override void Rajzol() { /*kört rajzol */ }
}
```
```csharp
class GrafikusSzerkeszto
{
	public void RajzolAlakzat(Alakzat a) { a.Rajzol(); }
}
```
- fenti példa:
	- közös ős -> absztrakt Alakzat
	- A konkrét alakzatok csak felülírják az ős absztrakt Rajzol metódusát és kész is az új gyermek (ebből akármennyit hozzáadhatunk, nem változtatjuk a meglévő kódot)
	- **OCP betartása**
	- **GOF1 betartása, ha** a kódban a gyermekosztály példányait csak az közös ős felületén keresztül használjuk
	- stratégia, sablonmetódus tervezési minta (hook) *jó példák* az OCP-re

### TDD 

Témakörök: **TDD alapelvei**, **Piros – Zöld – Piros**, **Piros – Zöld – Kék – Piros**, **Kettős könyvelés**.

*Tesztvezérelt Fejlesztés* (angolul: Test Driven Development - TDD) és a *Tiszta Kód* közötti kapcsolat: 
- A Tiszta Kód célja könnyen olvasható, könnyen karbantartható forráskód írása. 
- Előbb-utóbb minden forráskód elkezd bűzölögni, majd rothadni
	- megoldás: refaktorálás, szépítenünk kell a kódot. 
	- előfeltétele: 
		- sok-sok unit-teszt
		- bátorság hozzányúlni a kódhoz
- TDD alapelvei: 
	- 1.: Ne írj üzemi kódot, kivéve, hogy egy hibás tesztet kielégíts. 
	- 2.: Csak annyit tesztet írja, amely elegendő egy hiba demonstrálására. 
	- 3.: Csak annyi üzemi kódot írj, hogy kielégítsd a tesztet. 
- A TDD másik neve: Piros – Zöld – Piros, illetve, ha kód szépítési lépés is van, akkor: Piros – Zöld – Kék – Piros.

#### Bevezetés

- A TDD egy jól bevált módszer (angolul: *Best Practice*)
- az agilis módszerekkel, illetve a tiszta kód eszményével együtt terjedt el. 
- első hallásra furcsa: *ne a metódust írjuk meg, majd utána a hozzá tartozó egységtesztet, vagy más néven unit-tesztet, hanem épp fordítva, először írjuk az egységtesztet, úgy, hogy a tesztelt metódusnak még a feje sincs kész, majd csak ezután írjuk meg a metódust.*
- még ettől is továbbmegy -> a metódusból csak annyit írjunk meg, hogy épp átmenjen a legutoljára megírt egységteszten. 
- Ezután -> új egységteszt a már félkész metódushoz, ami egy eddig le nem fedett esetet tesztel, aztán írjuk meg a metódusba ezt az esetet. 
- amíg minden esetet le fedünk tesztesettel, illetve kóddal a metódusban.

- a TDD lépései:
	- Egységtesztet írunk először, csak utána metódust.
	- Minden egységteszt az eddig nem tesztelt lehető legegyszerűbb esetet írja le.
	- A metódusból csak annyit írunk meg, hogy épp átmenjen az összes egységteszten.

Uncle Bob három pontban írja le a TDD lényegét: 
- *„Write no production code except to pass a failing test.”* Azaz: **Ne írj üzemi kódot, kivéve, hogy egy hibás tesztet kielégíts.**
- *„Write only enough of a test to demonstrate a failure.”* Azaz: **Csak annyit tesztet írja, amely elegendő egy hiba demonstrálására.**
- *„Write only enough production code to pass the test.”* Azaz: **Csak annyi üzemi kódot írj, hogy kielégítsd a tesztet.**

- a metódusokat apró lépésekben fejlesztjük, úgy, hogy minden lépés előtt írunk egy egységtesztet.
- Ha betartjuk  => **sok pozitív hatás.** 
	- Nem felejtünk el egységtesztet írni, ami azért jó, mert így sok-sok tesztesetünk lesz.
	- Így a tesztelő fejünkkel gondolkozunk először és nem a programozó fejünkkel. 
		- Programozó fej -> szép és hatékony kódot szeretne írni => gyakran nehezen tesztelhető
			- „Én egy programozó zseni vagyok, rövid és gyors kódot írok!”
		- Tesztelő fej -> biztosak lehetünk abban, hogy a metódusunkat könnyű lesz tesztelni.
			- „Mindegy, hogy van implementálva, csak működőképesműködő képes legyen, tudjam tesztelni.”
	- Nyugodt szívvel merünk hozzányúlni a kódhoz, mert egy-egy változás után a regressziós teszt futtatása nagyon egyszerű, így van egy biztosítás a zsebünkbe, hogy ha esetleg a változás hibát okozna, akkor azt észre fogjuk venni. Tehát van bátorságunk szépíteni a kódot. 
	- Ezzel elkerüljük, hogy a forráskód ne váljon spagetti kóddá, vagy ami még rosszabb, bűzhödt, rothadó kóddá.
	- A tesztek a kód nagy részét lefedik, így a program magas minőségében biztosak lehetünk.
	- Kevesebb idő -> hibakeresés, nyomkövetés
	- Unit-test => a legjobb, programozóknak szóló dokumentáció, így könnyebb megérteni a kódunkat.
	- először a tesztelő fejünkkel gondolkozunk. 
		- pl.: szem előtt tartjuk, hogy az osztályaink legyenek publikusak, hiszen csak publikus osztályokat lehet tesztelni.

#### TDD és a tiszta kód

- A tiszta kód alapja a TDD. 
- Ha TDD-t használunk, akkor van sok-sok egységtesztünk, ami bátorságot ad, hogy hozzányúljunk a kódhoz. 
- Ha látjuk, hogy kezd romlani a kódunk, akkor merjük azt refaktorálni. **Emiatt a TDD a tiszta kód alapja!**
- A unit-tesztek az az életbiztosításunk, ami ahhoz kell, hogy legyen bátorságunk a kódot:
	- tisztán tartani
	- refaktorálni, mielőtt az rothadó kóddá válna.

**Piros – Zöld – Piros**
- A sikertelen egységteszt, jelzése piros, a sikeresé zöld. 
- A TDD előírja, hogy a metódusból (*az üzemi kódból*) csak annyit írjunk meg, hogy épp átmenjen a legutoljára megírt egységteszten. 
- Ezután írjunk egy új egységtesztet a már félkész metódushoz, ami egy eddig le nem fedett esetet tesztel, aztán írjuk meg a metódusba ezt az esetet. 
- És így tovább, amíg minden esetet lefedünk tesztesettel, illetve üzemi kóddal a metódusban.

- Először lesz egy piros egységteszt, majd ez zöld lesz, aztán írunk egy újat, ami szintén piros lesz, majd zöld, és így tovább. 
- A TDD ezen tulajdonsága miatt a TDD-t szokás *Piros – Zöld – Piros* tesztelésnek is hívni.


**Piros – Zöld – Kék – Piros**

- Ha azt vesszük észre, hogy a kódban redundáns sorok vannak, vagy lehetne alkalmazni egy tervezési mintát, esetleg szét lehetne választani valamit, amire eddig nem volt szükség, akkor kódszépítés következi (*kék fázis*). 
- Minden zöld lépés után kék jön, ezért a TDD-t nevezhetjük *Piros – Zöld – Kék – Piros* tesztelésnek is.

#### A TDD a szoftverfejlesztés kettős könyvelése
- A szoftverfejlesztés nagyon érzékeny, könnyű helytelen kódsort írni. 
- Szerencsés esetben a kódsor csak szintaktikailag helytelen. 
	- Ilyenkor a fordító kiírja, hogy ez és ez a sor hibás, mi a hiba benne, jobb esetben még megoldási javaslatot is ad. 
- Viszont, ha szemantikai hiba van benne, akkor nagyon nehéz megtalálni a hibát, ami könnyen futási hibához vezethet.

**Példa**: 
- A könyvelés is hasonlóan érzékeny terület. 
- Elég egy számot rosszul bevezetni a könyvelésbe, és máris az egész elromlik. 
- A könyvelés területén ezt a kettős könyveléssel védik ki. 
	- Minden számlát felvesznek a Tartozik és a Követel oldalon is. 
	- A két oldal összegének mindig nullának kell lennie. 
	- Ha valamelyik oldalon rosszul veszünk fel egy számlát, akkor rögtön látjuk, hogy hiba van. 
	- Könnyen belátható, hogy a kettős könyvelés nagyon hasznos!
- A TDD a szoftverfejlesztés kettős könyvelése. "Uncle bob - Clean Code"

### Stratégia minta

**Strategy (Stratégia)**:
- lehetővé teszi, hogy egy osztály viselkedését különböző stratégiákra bontsuk
- ezeket a stratégiákat dinamikusan váltjuk
- osztály hierarchiában van
- ebben az osztály hierarchiában egyetlen változékony metódust kiemelünk
- delegációval (felelősség átadás) meghívjuk (lehetővé teszi hogy az algoritmusokat futásidőben cseréljük)
- akkor alkalmazzuk, ha van **egy darab** változékony metódusunk
- A Kacsa osztályon belül lévő Hápog metódus, ahol különböző típusú kacsák különbözőképpen hápognak (házi kacsa, néma kacsa, gumikacsa, Donald kacsa).
- A változékony metódus kódját nem szabad csak úgy felülírni => OCP megsértése
- Helyyette a változékony metódust kiemeljük egy külön osztályhierarchiába
- az osztályt és a változékony metódust szétválasztjuk -> objektum-összetétel összerakjuk
- Működése: 
    - Az osztályhierarchia tetején egy absztrakt osztály van (csak a kiszervezett metódus fejét tartalmazza)
    - Az absztrakt osztály gyermekei a stratégiák, amelyek megvalósítják a változékony metódust.
    - Az eredeti osztály (amelyből kiszerveztük a metódust) egy referenciamezőt kap a stratégiára.
    - (delegálás) Az eredeti osztály a kiszervezett metódust ezen referencián keresztül hívja meg.
- Előnyök:
    - futásidőben cserélhető algoritmusok
    - OCP betartása ( Az osztályok zártak a módosításra és nyitottak a bővítésre.)
    - a felelősségek könnyen elkülöníthetők
- Hátrányok:
    - Növeli az osztályok számát és a kód komplexitását.
    - Az objektum-összetétel és delegáció miatt több helyen kell módosítani a kódot egy új stratégia hozzáadásakor.

```csharp
abstract class Kacsa
{
    public abstract void Hápog();
    public abstract void Repül();
}
```
---
```csharp
//változékony Hápog metódus
abstract class HápogásiStratégia
{
    public abstract void Hápog();
}
```

```csharp
//változékony Repül metódus
abstract class RepülésiStratégia
{
    public abstract void Repül();
}
```
---
```csharp
// itt jönnek a konkrét repülési és hápogási stratégiák
class NormálHápogás : HápogásiStratégia
{
    public override void Hápog()
    {
        Console.WriteLine("HápHáp");
    }
}
```

```csharp
class RekedtHápogás : HápogásiStratégia
{
    public override void Hápog()
    {
        Console.WriteLine("HákrrHákrrr");
    }
}
```

```csharp
class NemRepül : RepülésiStratégia
{
    public override void Repül()
    {
        Console.WriteLine("Nem tud repülni");
    }
}
```
---
```csharp
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
```
---
```csharp
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
```

![strategia](https://github.com/dandob23/jegyzetek/blob/main/Progtech/UML/STRATEGY.png)
