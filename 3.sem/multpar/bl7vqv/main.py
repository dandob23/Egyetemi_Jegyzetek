##4 es feladat
class Butorlap:

    def __init__(self,hosszusag,szelesseg,tipus):
        self.hosszusag=hosszusag
        self.szelesseg=szelesseg
        self.tipus=tipus
        super().__init__(self,tipus,hosszusag*10000,szelesseg*10000)

    def _tartólap(self,ar=5000):
        self.__ar=ar

    def _hátlap(self,ar=500):
        self.__ar=ar

    @property
    def _tartólap(self):
        return self.__tartólap

    @_tartólap.setter
    def _tartólap(self, ar):
        self.__tartólap = ar

    @property
    def _hátlap(self):
        return self.__hátlap

    @_hátlap.setter
    def _hátlap(self, ar):
        self.__hátlap = ar

    @staticmethod
    def ar_szamol(self,ar,hosszusag,szelesseg):
        szamolthatlap = self.__hatlap*hosszusag + self.__hátlap*szelesseg
        szamolttarto = self.__tartólap*hosszusag + self.__tartólap*szelesseg
        ar = szamolthatlap+szamolttarto
        return ar


class Butor:
    def __init__(self,lapszam,lapadat):
        self.lapszam=lapszam
        self.lapadat=lapadat
    super().__init__(self=list)
        lapadat=[]
        lapszam = 0
        return list

    @classmethod
    def lap_hozzaad(self):
        butorlap = 4
        lap_hozzaad(butorlap)

    @classmethod
    def ar_szamol(self):
        butorlap = 4
    super().__init__(self=list)
    for butorlap in list
        vegar=butorlap * ar_szamol()

    print("Butor - lapok: "+ butorlap +" ar "+str(vegar)+" Ft")
##-----------------------------------------------------------------------------------------------
def szokoev(ev):
    nemszoko = "nem szökőév"
    szoko = "szökőév!!!"
    if ev/4:
        ev=szoko
    if ev == 100:
        ev = nemszoko
    if ev == 400:
        ev=szoko
##-----------------------------------------------------------------------------------------------
def tomorit(szoveg):
    szoveg = input("Adjon meg egy szöveget!: ")
    darabolas = szoveg.split()
    szamolas=0
    for i in range(len(szoveg)):
        if darabolas[i] == darabolas[i+1]:
            szamolas+=1
            output = str(szamolas) + darabolas[i]
            return output
        else:
            return darabolas[i]
    print(tomorit('Hahooooo! Van itt valaki???'))

    def tomorit(szoveg):
        darabolas = []
        for karakter in szoveg:
            darabolas.append(karakter)
        szamolas = 0
        output = ""
        for i in range(len(darabolas)):
            if darabolas[i] == darabolas[i + 1]:
                if i + 2 == len(darabolas):
                    break
                szamolas += 1
                output += str(szamolas) + darabolas[i]
            else:
                output += darabolas[i]
        return output

    print(tomorit('Hahooooo! Van itt valaki???'))
##-----------------------------------------------------------------------------------------------
def felvaltva(szoveg):
    szoveg = input("Adjon meg egy többszavas szöveget")
    tobbszo = szoveg.split(' ')
    print(szoveg)
    if tobbszo <= 1:
        raise Exception
    output=""

    for tobbszo in szoveg:
        if tobbszo(0, 1) == 0:
            output += tobbszo.upper()
        else:
            output += tobbszo.lower()

    print(output)
    return output

try:

except Exception:
    print("HIBA!")
##-----------------------------------------------------------------------------------------------






