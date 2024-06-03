Rendben, itt van a „Tiszta kód” című könyv 5. fejezetének részletes összefoglalója. Ez a fejezet a kód formázásával foglalkozik, amely kulcsfontosságú az olvashatóság és a karbantarthatóság szempontjából.

### 5. Fejezet: Formázás

#### Bevezetés
- **Fontosság:** A kód formázása kulcsfontosságú a tiszta kód írásában. Egy jól formázott kód olvashatóbb és könnyebben karbantartható.
- **Cél:** Az olvashatóság és az átláthatóság növelése.

#### Függőleges formázás
- **Olvashatóság:** A kódot úgy kell formázni, hogy olvasása természetes legyen, mint egy könyv.
- **Függőleges távolság:** A kapcsolódó kódblokkok legyenek közel egymáshoz, míg a különböző blokkok között legyen nagyobb távolság.
  - **Példák:** A deklarációk egy helyen legyenek; a funkcionálisan összetartozó kódrészek legyenek egy blokkban.

#### Vízszintes formázás
- **Sorhossz:** A sorok ne legyenek túl hosszúak. Általában 80-120 karakter között legyen a maximális sorhossz.
- **Behúzás:** Használjunk egységes behúzást (általában 2-4 szóköz vagy egy tabulátor).
- **Szóközök:** Használjunk szóközöket a kód elemeinek elválasztására, például operátorok körül, de ne használjunk felesleges szóközöket.
  - **Példák:** Operátorok körüli szóközök (`a + b`), nincs szóköz függvénynevek után (`function()`).

#### Kódblokkok
- **Blokkok elválasztása:** Minden blokkot (például if, for, while stb.) el kell különíteni a környező kódtól egy üres sorral.
- **Blokk kezdete és vége:** Nyitó zárójel `{` és záró zárójel `}` ugyanazon a szinten legyen.

#### Kódelhelyezés
- **Deklarációk elhelyezése:** Deklarációkat a használat helyéhez közel tegyük. Ez növeli az olvashatóságot.
- **Metódusok sorrendje:** A metódusokat olyan sorrendben helyezzük el, hogy a magasabb szintű absztrakciókat tartalmazó metódusok legyenek felül, és az alacsonyabb szintű részletek lent.

#### Egységes formázási stílus
- **Stílus szabályzat:** Az egész csapatnak egységes formázási stílust kell követnie.
- **Automatizálás:** Használjunk kódformázó eszközöket, amelyek segítenek betartani a stílus szabályzatot.

#### Megjegyzések és megjegyzések formázása
- **Megjegyzések használata:** A megjegyzések legyenek rövidek és lényegre törők. Ne kommentáljuk túl a kódot.
- **Komment blokk:** A komment blokkok jól láthatóak legyenek, és külön sorban álljanak.

### Példák

```java
// Jó példa függőleges formázásra
public class Example {
    private int value;

    public Example(int value) {
        this.value = value;
    }

    public int getValue() {
        return value;
    }

    public void setValue(int value) {
        this.value = value;
    }
}

// Jó példa vízszintes formázásra
public void calculate(int a, int b) {
    int sum = a + b;
    System.out.println("Sum: " + sum);
}
```

#### Összefoglalás
- A jól formázott kód megkönnyíti a csapatmunkát és a kód karbantartását.
- Az egységes formázási szabályok és a kód formázására vonatkozó alapelvek betartása növeli a kód olvashatóságát és csökkenti a hibák lehetőségét.

Ez az összefoglaló segít áttekinteni a formázás legfontosabb alapelveit, amelyeket Robert C. Martin bemutat a "Tiszta kód" című könyvben. Ha további részletekre vagy konkrét példákra van szükséged, jelezd nyugodtan!