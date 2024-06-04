### Stratégia (Strategy) tervezési minta

A **Stratégia (Strategy)** egy viselkedési tervezési minta, amely lehetővé teszi, hogy egy osztály hierarchiában egyetlen változékony metódust emeljünk ki. Ezt a metódust felelősség átadással (delegációval) hívjuk meg, amely lehetővé teszi az algoritmusok dinamikus cseréjét futásidőben.

#### Mikor használjuk?
A stratégia tervezési mintát akkor alkalmazzuk, ha van egy (se több, se kevesebb) változékony metódusunk. Például:
- A kosárban lévő áruk árának kiszámítása, ahol a változó akciók miatt mindig másképp kell kiszámolni az árat.
- A Kacsa osztályon belül lévő Hápog metódus, ahol különböző típusú kacsák különbözőképpen hápognak (házi kacsa, néma kacsa, gumikacsa, Donald kacsa).

#### Miért fontos?
A változékony metódus kódját nem szabad csak úgy felülírni, mert ezzel megsértenénk az OCP (Open/Closed Principle) elvet. A stratégia minta alkalmazásával a változékony metódust kiemeljük egy külön osztályhierarchiába, és ezzel alkalmazzuk a Separation of Concerns (Felelősségek szétválasztása) elvet. Így az osztályt és a változékony metódust szétválasztjuk, majd objektum-összetétel segítségével újra összerakjuk.

#### Hogyan működik?
1. **Absztrakt stratégia osztály:** Az osztályhierarchia tetején egy absztrakt osztály van, amely csak a kiszervezett metódus fejét tartalmazza.
2. **Konkrét stratégiák:** Az absztrakt osztály gyermekei a konkrét stratégiák, amelyek megvalósítják a változékony metódust.
3. **Referenciamező:** Az eredeti osztály, amelyből kiszerveztük a metódust, egy referenciamezőt kap a stratégiára.
4. **Delegálás:** Az eredeti osztály a kiszervezett metódust ezen referencián keresztül hívja meg.

#### Előnyök:
- **Rugalmasság:** Az algoritmusok dinamikusan cserélhetők futásidőben.
- **OCP betartása:** Az osztályok zártak a módosításra és nyitottak a bővítésre.
- **Separation of Concerns:** A felelősségek világosan elkülöníthetők.

#### Hátrányok:
- **Komplexitás:** Növeli az osztályok számát és a kód komplexitását.
- **Karakterisztika:** Az objektum-összetétel és delegáció miatt több helyen kell módosítani a kódot egy új stratégia hozzáadásakor.

A stratégia minta alkalmazásával a kód rugalmasabbá és könnyebben karbantarthatóvá válik, lehetővé téve az algoritmusok dinamikus cserélését és bővítését anélkül, hogy a meglévő kódot módosítani kellene.

```csharp
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
```

```csharp
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
```

---

### Open-Closed Principle (OCP)

Az **Open-Closed Principle (OCP)**, magyarul a nyitva-zárt elv, kimondja, hogy a program forráskódja legyen nyitott a bővítésre, de zárt a módosításra. Eredeti angol megfogalmazása: „Classes should be open for extension, but closed for modification.”

#### Mikor használjuk?
Az OCP elvet akkor alkalmazzuk, ha biztosítani szeretnénk, hogy egy meglévő osztály vagy metódus új funkciókkal bővíthető legyen anélkül, hogy a meglévő kódot módosítani kellene.

#### Miért fontos?
Az OCP elv követésével elkerülhető, hogy a már működő, letesztelt, kiforrott metódusokat módosítsuk, ami számos problémát okozhat:
1. **Hibás ágak:** A változtatás miatt az eddig működő ágak hibásak lesznek.
2. **Implementációs függőség:** A változtatás miatt a vele implementációs függőségben lévő kódrészeket is változtatni kell.
3. **Átláthatóság csökkenése:** A változtatás általában azt jelenti, hogy olyan esetet kezelünk le, amit eddig nem, így csökken a kód átláthatósága, és egy idő után már senki sem mer hozzányúlni.

#### Hogyan működik?
Az OCP elv követése érdekében az osztályokat és metódusokat úgy kell megtervezni, hogy új funkciók hozzáadásához ne kelljen a meglévő kódot módosítani. Ezt az alábbiak segítségével érhetjük el:
1. **Absztrakt osztályok és interfészek:** Az absztrakt osztályok és interfészek lehetővé teszik az új alosztályok létrehozását anélkül, hogy a meglévő osztályokat módosítani kellene.
2. **Horog (hook) metódusok:** Az olyan metódusok, amelyeknek van ugyan törzse, de az üres, vagy csak egy alapértelmezett értéket adnak vissza, opcionálisan felülírhatók a gyermekosztályokban.

#### Szintaktikai megfogalmazás C# nyelven:
Ne használd az `override` kulcsszót, kivéve ha absztrakt vagy horog (hook) metódust akarsz felülírni.

- **Absztrakt metódusok:** Muszáj felülírni őket, de ez nem az OCP megszegése, hiszen az absztrakt metódusnak nincs törzse, így lényegében a törzzsel bővítjük a kódot, nem módosítunk semmit.
- **Horog (hook) metódusok:** Olyan metódusok, amelyeknek van ugyan törzse, de az teljesen üres, vagy csak egy alapértelmezett értéket adnak vissza.

#### Előnyök:
- **Rugalmasság:** Az osztályok és metódusok új funkciókkal bővíthetők anélkül, hogy a meglévő kódot módosítani kellene.
- **Stabilitás:** A meglévő, letesztelt kód stabil marad, és nem kell attól tartani, hogy a változtatások új hibákat okoznak.

#### Hátrányok:
- **Komplexitás:** Növelheti a rendszer komplexitását, mivel több absztrakt osztályt és interfészt kell létrehozni.
- **Karakterisztika:** Az OCP elv betartása néha bonyolultabb tervezést igényel, ami több időt és erőforrást igényelhet.

Az OCP elv követése hosszú távon megkönnyíti a kód karbantartását és bővítését, mivel lehetővé teszi új funkciók hozzáadását anélkül, hogy a meglévő kódot módosítani kellene.

Ha egy kódban if – else if szerkezetet látunk, akkor az valószínűleg azt mutatja, hogy nem tartottuk be az OCP elvet. Nem tartottuk be, hiszen, ha új alakzatot akarunk hozzáadni a kódhoz, akkor az if – else if szerkezetet tovább kell bővítenünk. Lássuk, hogy lehet ezt kivédeni:

```csharp
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
```

A fenti példában bevezettünk egy közös őst, az absztrakt Alakzatot. A konkrét alakzatok csak felülírják az ős absztrakt Rajzol metódusát és kész is az új gyermek. Ebből akárhányat hozzáadhatunk, a meglévő kódot nem kell változtatni. Tehát itt betartjuk az OCP elvet.
A közös absztrakt ős másik előnye az, hogy ha a kódban a gyermekosztály példányait csak az közös ős felületén keresztül használjuk, akkor ezzel betartjuk a GOF1 ajánlást is.
Az OCP elv alkalmazására nagyon szép példa a stratégia és a sablonmetódus tervezési minta. Az utóbbi horog (angolul: hook) metódusokra is ad példát.

---

### Single Responsibility Principle (SRP)

Az **Egy felelősség - egy osztály alapelve** (angolul: Single Responsibility Principle – SRP) azt mondja ki, hogy minden osztálynak egyetlen felelősséget kell lefednie, de azt teljes egészében. Eredeti angol megfogalmazása: „A class should have only one reason to change”, azaz „Az osztályoknak csak egy oka legyen a változásra”.

#### Mikor használjuk?
Az SRP elvet akkor alkalmazzuk, amikor szeretnénk biztosítani, hogy egy osztály csak egy jól meghatározott feladatot végezzen, és ne legyen túl sokféle felelőssége.

#### Miért fontos?
Ha egy osztály több felelősségi kört is ellát, az alábbi problémákkal szembesülhetünk:
1. **Magas változékonyság:** Az osztályt gyakran kell módosítani, mert különböző felelősségi körök változnak.
2. **Nehezen karbantartható kód:** A sokféle felelősség miatt az osztály kódja bonyolult és nehezen érthető.
3. **Nagyobb hibakockázat:** A változtatások nagyobb valószínűséggel vezetnek hibákhoz, mivel több felelősségi kör is érintett lehet.

#### Hogyan működik?
Az SRP elv követése érdekében minden osztálynak egyetlen, jól meghatározott felelősségi körre kell koncentrálnia. Ezt az alábbiak segítségével érhetjük el:
1. **Felelősségi körök azonosítása:** Azonosítsuk az osztály különböző felelősségi köreit, és osszuk szét őket különböző osztályok között.
2. **Aspektusorientált programozás:** Az olyan keresztmetszeti felelősségeket, mint a naplózás vagy a jogosultságkezelés, külön aspektusokba szervezzük.

#### Példa:
Vegyünk egy példát egy alkalmazásban, amelyben egy jelentéskészítő osztály több felelősséget is ellát: adatgyűjtés, jelentés formázása és jelentés kiírása.

**Eredeti osztály (túl sok felelősség):**

```csharp
public class JelentésKészítő {
    public void AdatGyűjtés() {
        // Adatok gyűjtése
    }

    public void JelentésFormázás() {
        // Jelentés formázása
    }

    public void JelentésKiírás() {
        // Jelentés kiírása
    }
}
```

**Osztályok szétválasztása (egy felelősség - egy osztály):**

```csharp
public class AdatGyűjtő {
    public void AdatGyűjtés() {
        // Adatok gyűjtése
    }
}

public class JelentésFormázó {
    public void JelentésFormázás() {
        // Jelentés formázása
    }
}

public class JelentésKiíró {
    public void JelentésKiírás() {
        // Jelentés kiírása
    }
}
```

**Használat:**

```csharp
var adatGyűjtő = new AdatGyűjtő();
var jelentésFormázó = new JelentésFormázó();
var jelentésKiíró = new JelentésKiíró();

adatGyűjtő.AdatGyűjtés();
jelentésFormázó.JelentésFormázás();
jelentésKiíró.JelentésKiírás();
```

#### Előnyök:
- **Egyszerűbb karbantartás:** Az osztályok egyértelmű felelősségi köre miatt a kód könnyebben érthető és karbantartható.
- **Csökkentett hibakockázat:** A változtatások kisebb valószínűséggel vezetnek hibákhoz, mivel az osztályok csak egyetlen felelősségi körrel rendelkeznek.
- **Nagyobb rugalmasság:** Az osztályok könnyebben bővíthetők és módosíthatók anélkül, hogy más felelősségi körök sérülnének.

#### Hátrányok:
- **Több osztály:** Az SRP elv követése több osztály létrehozását igényli, ami növelheti a rendszer komplexitását.
- **Bonyolultabb struktúra:** Az osztályok közötti kapcsolatok és az objektumok összetétele bonyolultabb lehet.

#### Aspektusorientált programozás:
Az olyan keresztmetszeti felelősségeket, mint a naplózás vagy a jogosultságkezelés, külön aspektusokba szervezzük. Ezeket az aspektusokat bármely osztályhoz hozzákapcsolhatjuk, így biztosítva, hogy minden osztály egyetlen felelősségi körrel rendelkezzen.

#### Felelősséglánc tervezési minta:
Az **SRP** szép példája a felelősséglánc tervezési minta, amelyben az egyes felelősségeket külön osztályokba szervezzük, és a felelősség átadása láncszerűen történik az osztályok között.

Az SRP elv követése hosszú távon megkönnyíti a kód karbantartását és bővítését, mivel biztosítja, hogy minden osztály csak egyetlen, jól meghatározott feladatot végezzen.

---

### Állapot (State) Tervezési Minta

Az **Állapot** (angolul: State) viselkedési tervezési mintát akkor használjuk, ha több összefüggő változékony metódust akarunk kiemelni és azokat delegációval meghívni. Lehetővé teszi egy objektum viselkedésének megváltozását, amikor megváltozik az állapota.

#### Használati példa
Egy jól ismert példa a **TCPConnection** osztály, amely egy hálózati kapcsolatot reprezentál. Három állapota lehet: Listening, Established, Closed. A kéréseket az állapotától függően kezeli.

#### Mikor használjuk?
1. **Az objektum viselkedése függ az állapotától:** Az objektum viselkedését az aktuális állapotnak megfelelően futás közben meg kell változtatnia.
2. **Nagy feltételes ágak:** A műveleteknek nagy feltételes ágai vannak, melyek az objektum állapotától függenek.

#### Előnyök
- **Egységbe zárja az állapotfüggő viselkedést:** Könnyű új állapotok bevezetése.
- **Áttekinthetőbb kód:** Nincs nagy switch-case szerkezet.
- **Az állapot objektumokat meg lehet osztani.**

#### Hátrányok
- **Nő az osztályok száma:** Ezért csak indokolt esetben használjuk.

### C# Példa a Kép Alapján

A kép alapján egy kapu (Gate) osztály különböző állapotait (nyitott és zárt) kezeljük az állapot tervezési minta segítségével.

#### Interface és Állapot Osztályok

```csharp
public interface GateState {
    void Enter();
    void Pay();
    void PayOk();
    void PayFailed();
}

public class OpenGateState : GateState {
    private Gate gate;

    public OpenGateState(Gate gate) {
        this.gate = gate;
    }

    public void Enter() {
        // Engedje be a felhasználót
        Console.WriteLine("User entered. Gate is now closing.");
        this.gate.ChangeState(new ClosedGateState(this.gate));
    }

    public void Pay() {
        Console.WriteLine("Gate is already open. No need to pay.");
    }

    public void PayOk() {
        Console.WriteLine("Payment already accepted. Gate is open.");
    }

    public void PayFailed() {
        Console.WriteLine("Payment failed but gate is already open.");
    }
}

public class ClosedGateState : GateState {
    private Gate gate;

    public ClosedGateState(Gate gate) {
        this.gate = gate;
    }

    public void Enter() {
        Console.WriteLine("Gate is closed. Please pay to enter.");
    }

    public void Pay() {
        Console.WriteLine("Processing payment...");
        // Simulate payment process
        this.gate.ChangeState(new OpenGateState(this.gate));
        Console.WriteLine("Payment successful. Gate is now open.");
    }

    public void PayOk() {
        Console.WriteLine("Gate is closed. Please pay to open.");
    }

    public void PayFailed() {
        Console.WriteLine("Payment failed. Gate remains closed.");
    }
}
```

#### Gate Osztály

```csharp
public class Gate {
    private GateState state;

    public Gate() {
        this.state = new ClosedGateState(this);
    }

    public void Enter() {
        this.state.Enter();
    }

    public void Pay() {
        this.state.Pay();
    }

    public void PayOk() {
        this.state.PayOk();
    }

    public void PayFailed() {
        this.state.PayFailed();
    }

    public void ChangeState(GateState state) {
        this.state = state;
    }
}
```

#### Használat

```csharp
public class Program {
    public static void Main(string[] args) {
        Gate gate = new Gate();
        
        gate.Enter();         // "Gate is closed. Please pay to enter."
        gate.Pay();           // "Processing payment... Payment successful. Gate is now open."
        gate.Enter();         // "User entered. Gate is now closing."
        gate.PayOk();         // "Gate is closed. Please pay to open."
        gate.PayFailed();     // "Payment failed. Gate remains closed."
    }
}
```

Ez a kód bemutatja, hogyan lehet alkalmazni az állapot tervezési mintát egy kapu (Gate) osztály különböző állapotainak kezelésére, ahol az állapotok közötti átmenetek és az egyes állapotok viselkedése külön-külön osztályokba van zárva.

---

