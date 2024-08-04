### Unit Teszt Példa az Alma Árszámításához

Az alábbi példa bemutatja, hogyan lehet unit teszteket írni egy metódushoz, amely az alma árát számolja kedvezményekkel. A metódus figyelembe veszi a vásárolt alma mennyiségét, és ennek megfelelően alkalmaz kedvezményeket.

#### AlmaÁrSzámító Osztály

```csharp
public class AlmaÁrSzámító
{
    public double GetAlmaÁr(double kg)
    {
        const double almaÁrPerKg = 400;
        double kedvezmény = 0;

        if (kg >= 20)
        {
            kedvezmény = 0.15;
        }
        else if (kg >= 5)
        {
            kedvezmény = 0.10;
        }

        double összÁr = kg * almaÁrPerKg;
        return összÁr * (1 - kedvezmény);
    }
}
```

#### Unit Test Osztály

```csharp
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class AlmaÁrSzámítóTests
    {
        [TestMethod]
        public void Test_GetAlmaÁr_NoDiscount()
        {
            AlmaÁrSzámító target = new AlmaÁrSzámító();
            double kg = 4;
            double expected = 1600;
            double actual = target.GetAlmaÁr(kg);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetAlmaÁr_10PercentDiscount()
        {
            AlmaÁrSzámító target = new AlmaÁrSzámító();
            double kg = 5;
            double expected = 1800;
            double actual = target.GetAlmaÁr(kg);
            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestMethod]
        public void Test_GetAlmaÁr_10PercentDiscount_Above5kg()
        {
            AlmaÁrSzámító target = new AlmaÁrSzámító();
            double kg = 10;
            double expected = 3600;
            double actual = target.GetAlmaÁr(kg);
            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestMethod]
        public void Test_GetAlmaÁr_15PercentDiscount()
        {
            AlmaÁrSzámító target = new AlmaÁrSzámító();
            double kg = 20;
            double expected = 6800;
            double actual = target.GetAlmaÁr(kg);
            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestMethod]
        public void Test_GetAlmaÁr_15PercentDiscount_Above20kg()
        {
            AlmaÁrSzámító target = new AlmaÁrSzámító();
            double kg = 25;
            double expected = 8500;
            double actual = target.GetAlmaÁr(kg);
            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestMethod]
        public void Test_GetAlmaÁr_ZeroKg()
        {
            AlmaÁrSzámító target = new AlmaÁrSzámító();
            double kg = 0;
            double expected = 0;
            double actual = target.GetAlmaÁr(kg);
            Assert.AreEqual(expected, actual);
        }
    }
}
```

### Magyarázat

- **AlmaÁrSzámító Osztály:** A `GetAlmaÁr` metódus kiszámítja az alma árát a vásárolt mennyiség és a kedvezmények alapján.
- **Unit Tesztek:**
  - `Test_GetAlmaÁr_NoDiscount`: Teszteli, hogy nincs kedvezmény 5 kg alatti vásárlás esetén.
  - `Test_GetAlmaÁr_10PercentDiscount`: Teszteli, hogy 10% kedvezmény van 5 kg alma vásárlása esetén.
  - `Test_GetAlmaÁr_10PercentDiscount_Above5kg`: Teszteli, hogy 10% kedvezmény van 5 kg fölött, de 20 kg alatt.
  - `Test_GetAlmaÁr_15PercentDiscount`: Teszteli, hogy 15% kedvezmény van 20 kg alma vásárlása esetén.
  - `Test_GetAlmaÁr_15PercentDiscount_Above20kg`: Teszteli, hogy 15% kedvezmény van 20 kg fölött.
  - `Test_GetAlmaÁr_ZeroKg`: Teszteli, hogy 0 kg esetén az ár 0 Ft.

Ez a megközelítés biztosítja, hogy a `GetAlmaÁr` metódus helyesen működik a különböző bemeneti értékek esetén és megfelelően alkalmazza a kedvezményeket.