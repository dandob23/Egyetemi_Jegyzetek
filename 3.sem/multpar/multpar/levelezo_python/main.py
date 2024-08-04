# Fontos szabály: minden metódusnak van egy kötelező első paramétere: self
# Fontos, hogy Pythonban nincs function overload.
# Fontos, hogy a property és az adattag neve mindig eltérő legyen, mert különben végtelen rekurzióba futunk!

class Szuperhos:
    def __init__(self, nev, szuperero=50):
        self.__nev = nev
        self.__szuperero = szuperero
        print("--> Szuperhős létrehozva! <--")

    @property
    def nev(self):
        return self.__nev

    @nev.setter
    def nev(self, nev):
        self.__nev = nev

    @property
    def szuperero(self):
        return self.__szuperero

    @szuperero.setter
    def szuperero(self, ertek):
        self.__szuperero = ertek

    def __str__(self):
        return self.__nev + " egy szuperhős, akinek szuperereje " + str(self.__szuperero)

    # Operator overloading
    # két szuperhős akkor lesz egyenlő, ha a nevük és a szupererjük megegyezik
    def __eq__(self, masik_hos):
        return self.__nev == masik_hos.__nev and self.__szuperero == masik_hos.__szuperero

    # két szuperhős összeadása során a szupererjük összeadódik
    def __add__(self, masik_hos):
        if isinstance(masik_hos, Szuperhos): # típusellenőrzés
            uj_szuperero = self.__szuperero + masik_hos.__szuperero
            uj_szuperhos = Szuperhos("Megahős", uj_szuperero)
            return uj_szuperhos
        else:
            print("Egy szuperhőst csak egy másik szuperhőssel lehet összeadni!")

hos1 = Szuperhos("Thor", 80)
hos2 = Szuperhos("Hulk", 100)
hos3 = Szuperhos("Hulk", 100)
print(hos2 == hos3)
hos4 = hos1 + hos2
print(hos4)

# Feladat
"""
Szuperhősöknek legyen egy kepessegek adattagja is, ami kezdetben egy üres lista! Definiáljuk felül a += operátort,
ami a paraméterül kapott értéket beszúrja a kepessegek lista végére, amennyiben az szöveges típusú!
"""