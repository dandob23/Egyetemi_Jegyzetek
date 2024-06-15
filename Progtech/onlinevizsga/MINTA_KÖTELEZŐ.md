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

![strategia]()

---
---

### Állapot (State) Tervezési Minta

**State**:
- viselkedési tervezési minta
- használat ha: több összefüggő változékony metódust akarunk kiemelni és azokat delegációval meghívni
- Az objektum viselkedése függ az állapotától -> futás közben változtatja meg
- Nagy feltételes ágak () -> Az aktuális állapottól függően a műveleteknek nagy feltételes ágai vannak
- Előnyok:
    - Egységbe zárja az állapotfüggő viselkedést -> könnyű új állapotokat bevezetni
    - A kód könnyebben áttekinthetőbb, mivel nincsen annyi if-elseif-switchcase
    - Az állapot objektumokat meg lehet osztani ()
- Hátrányok: 
    - osztályok száma megnő

 

```csharp
// Állapot interfész a kapu különböző állapotaihoz
public interface GateState {
    void Enter();    // Belépési metódus
    void Pay();      // Fizetési metódus
    void PayOk();    // Sikeres fizetési metódus
    void PayFailed(); // Sikertelen fizetési metódus
}


```
---
```csharp
public class Gate {
    private GateState state; // Objektum-összetétel: a kapu aktuális állapotának tárolása

    public Gate() {
        this.state = new ClosedGateState(this); // Alapértelmezett állapot: zárt kapu
    }

    public void Enter() {
        this.state.Enter(); // Felelősség átadása a stratégiának, azaz delegáció
    }

    public void Pay() {
        this.state.Pay(); // Felelősség átadása a stratégiának, azaz delegáció
    }

    public void PayOk() {
        this.state.PayOk(); // Felelősség átadása a stratégiának, azaz delegáció
    }

    public void PayFailed() {
        this.state.PayFailed(); // Felelősség átadása a stratégiának, azaz delegáció
    }

    public void ChangeState(GateState state) {
        this.state = state; // Felelősség beinjektálása: állapot váltása
    }
}
```
---
```csharp
public class OpenGateState : GateState {
    private Gate gate; // Objektum-összetétel: hivatkozás a kapu objektumra

    public OpenGateState(Gate gate) {
        this.gate = gate; // Felelősség beinjektálása
    }

    public void Enter() {
        // Felhasználó beengedése
        Console.WriteLine("User entered. Gate is now closing.");
        this.gate.ChangeState(new ClosedGateState(this.gate)); // Felelősség átadása és állapotváltás
    }

    public void Pay() {
        Console.WriteLine("Gate is already open. No need to pay."); // Nyitott kapu esetén nincs fizetési szükség
    }

    public void PayOk() {
        Console.WriteLine("Payment already accepted. Gate is open."); // Fizetés már elfogadva
    }

    public void PayFailed() {
        Console.WriteLine("Payment failed but gate is already open."); // Sikertelen fizetés nyitott kapu esetén
    }
}

```
---
```csharp
public class ClosedGateState : GateState {
    private Gate gate; // Objektum-összetétel: hivatkozás a kapu objektumra

    public ClosedGateState(Gate gate) {
        this.gate = gate; // Felelősség beinjektálása
    }

    public void Enter() {
        Console.WriteLine("Gate is closed. Please pay to enter."); // Zárt kapu esetén üzenet
    }

    public void Pay() {
        Console.WriteLine("Processing payment...");
        // Fizetés feldolgozása
        this.gate.ChangeState(new OpenGateState(this.gate)); // Állapot váltása: nyitott kapu
        Console.WriteLine("Payment successful. Gate is now open.");
    }

    public void PayOk() {
        Console.WriteLine("Gate is closed. Please pay to open."); // Zárt kapu esetén fizetési kérés
    }

    public void PayFailed() {
        Console.WriteLine("Payment failed. Gate remains closed."); // Sikertelen fizetés zárt kapu esetén
    }
}

```
---
```csharp
public class Program {
    public static void Main(string[] args) {
        Gate gate = new Gate(); // Új kapu objektum létrehozása
        
        gate.Enter();         // "Gate is closed. Please pay to enter."
        gate.Pay();           // "Processing payment... Payment successful. Gate is now open."
        gate.Enter();         // "User entered. Gate is now closing."
        gate.PayOk();         // "Gate is closed. Please pay to open."
        gate.PayFailed();     // "Payment failed. Gate remains closed."
    }
}
```
![state]()

```