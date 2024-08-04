#nincs public protected private
class Szuperhos:
    def __init__(self, nev, szuperero=50):
        self.__nev=nev
        self.__szuperero=szuperero


    """ 
    def get_szuperero(self):
        return self.__szuperero
    
    def set_szuperero(self,ertek):
        self.__szuperero=ertek
    """

    @property
    def szuperero(self):
        return self.__szuperero

    @szuperero.setter
    def szuperero(self, ertek):
        self.__szuperero=ertek

    def udvozles(self):
        print("Az én nevem: "+self.__nev)

    def __str__(self):
        return "A nevem: "+self.__nev+" és a szupererőm értéke"+str(self.__szuperero)

    #két szuperhos akkor egyenlo ha a nevuk es a szupererejuk megegyezik
    def __eq__(self, masik_hos):
        return self.__nev==masik_hos.__nev and self.__szuperero == masik_hos.__szuperero

hos01=Szuperhos("Thor", 80)
# hos01.set_szuperero(100)
hos01.szuperero=100  #set property hivas
print(hos01.szuperero) #get property hivas
print(hos01)

hos02 = Szuperhos("Deep",100)
hos03 = Szuperhos("Deep",100)
print(hos02==hos03)


# isinstance() függvény
print(isinstance(42, int))
print(isinstance(42, str))
print(isinstance(hos01,Szuperhos))

#házi feladat: A szuperhősöknek legyen egy képességek adattagha is, ami kezdetben egy üres lista
#definiáljuk felül a += operátort ami a paraméterül kapott értéket beszúrja a kepessegek lista végére
#amennyiben az szöveges típusú
