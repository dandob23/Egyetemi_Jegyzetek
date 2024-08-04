class Szuperhos:
    def __init__(self, nev, szuperero=50):
        self.__nev=nev
        self.__szuperero=szuperero

    @property
    def szuperero(self):
        return  self.__szuperero

    @szuperero.setter
    def szuperero(self, ertek):
        self.__szuperero=ertek

    def udvozles(self):
        print("Az en nevem: "+self.__nev)

    def __str__(self):
        return "A nevem: "+self.__nev+" és a szupererőm értéke: "+str(self.__szuperero)

    def __eq__(self, masik_hos):
        return self.__nev==masik_hos and self.__szuperero==masik_hos.__


hos01=Szuperhos("Thor", 80)

hos01.szuperero=100
print(hos01.szuperero)
print(hos01)


hos02=Szuperhos("IronMan",60)
hos03=Szuperhos("IronMan",60)

print(hos02==hos03)

print(isinstance(42, int))
print(isinstance(42, int))
print(isinstance(hos01,Szuperhos))