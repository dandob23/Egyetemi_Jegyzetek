"""
Téglalap
Írj egy osztályt, amely teglalapot reprezental annak oldalhosszait tarolja
keszits neki konstruktort amely az oldalakat inicializalja, lehessen negyzetet
is letrehozni
keszits metodusokat a kerulet es terulet kiszamitasara
keszits hozza main fuggvenyt
tarold a teglalapokat egy listaban
a listaban levo teglalapok teruletenek es keruletenek atlagat szamitsd ki
"""

class teglalap:
    def __init__(self,oldalak=4):
        self.__oldalak=oldalak
        print(oldalak)

    @oldalak
    def oldalak(self):
        return self.__oldalak

    @oldalak.setter
    def oldalszam(self, oldalszam):
        self.__oldalak=oldalszam

    def kiiras(self):
        print("Az oldalak száma: "+self.__oldalak)

sokszog=teglalap("Téglalap",4)
sokszog=negyzet("Négyzet",4)