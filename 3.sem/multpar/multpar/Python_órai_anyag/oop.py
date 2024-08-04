# NINCS PUBLIC PROTECTED PRIVATE
class Szuperhos():
    def __init__(self, nev, szuperero=50):
        self.__nev = nev
        self.__szuperero = szuperero
        # print("Szuperhős létrehozva!")

    """
    def get_szuperero(self):
        return self.__szuperero
    
    def set_szuperero(self, ertek):
        self.__szuperero = ertek
    """

    @property
    def szuperero(self):
        return self.__szuperero

    @szuperero.setter
    def szuperero(self, ertek):
        self.__szuperero = ertek

    def udvozles(self):
        print("Az én nevem: " + self.__nev)

    def __str__(self):
        return "A nevem: " + self.__nev + " és a szupererőm értéke: " + str(self.__szuperero)

    # két szuperhős, akkor lesz egyenlő, ha a nevük és a szupererejük megegyezik
    def __eq__(self, masik_hos):
        return self.__nev == masik_hos.__nev and self.__szuperero == masik_hos.__szuperero

hos01 = Szuperhos("Thor", 80)
# hos01.set_szuperero(100)
#hos01.szuperero = 100 # set property hívás
# print(hos01.szuperero) # get property hívás
#print(hos01)

hos01 = Szuperhos("Thor", 80)
hos02 = Szuperhos("Deep", 100)
hos03 = Szuperhos("Deep", 100)
# print(hos02 == hos03)

# isinstance() függvény
print(isinstance(42, int))
print(isinstance(42, str))
print(isinstance(hos01,Szuperhos))

# Házi feladat:
# A szuperhősöknek legyen egy kepessegek adattagja is, ami kezdetben egy üres lista!
# Definiáljuk felül a += operátort, ami a paraméterül kapott értéket beszúrja a kepessegek lista végére,
# amennyiben az szöveges típusú!

