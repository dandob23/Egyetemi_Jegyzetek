class Savanyusag():
    def __init__(self, datum, nyitva, elemek):
        self.minoseget_megorzi = datum
        self.nyitva = nyitva
        self.elemek = elemek
        self.__tipus = ""
        if len(self.elemek) == 1:
            self.__tipus = self.elemek[0]
        else:
            self.__tipus = "csalamade"

    @property
    def tipus(self):
        return self.__tipus

    @tipus.setter
    def tipus(self, ertek):
        if ertek in self.elemek:
            self.__tipus = ertek
            print("Savanyúság sikeresen módosítva")
        else:
            print("A beállítani kívánt érték nem szerepel az elemek listában")

    def szavatos(self, ev, honap, nap):
        datum = (ev, honap, nap)
        if self.minoseget_megorzi >= datum:
            return True
        return False

        """Másik megoldás
        if self.minoseget_megorzi[0] > ev:
            return True
        elif self.minoseget_megorzi[0] == ev and self.minoseget_megorzi[1] > honap:
            return True
        elif self.minoseget_megorzi[0] == ev and self.minoseget_megorzi[1] == honap and self.minoseget_megorzi[2] >= nap:
            return True
        return False
        """

    def fedel_csavar(self):
        if self.nyitva:
            self.nyitva = False
        else:
            self.nyitva = True

    def __iadd__(self, masik_savanyusag):
        if isinstance(masik_savanyusag, Savanyusag):
            if self.nyitva and masik_savanyusag.nyitva:
                self.elemek += masik_savanyusag.elemek
                if self.minoseget_megorzi < masik_savanyusag.minoseget_megorzi:
                    self.minoseget_megorzi = masik_savanyusag.minoseget_megorzi
                return self
            elif not self.nyitva:
                raise Exception("A savanyusag fedele zarva van!")
            elif not masik_savanyusag.nyitva:
                raise Exception("A masik savanyusag fedele zarva van!")
        else:
            print("Másik savanyúságot kell megadni!")

    def __str__(self):
        return f"Savanyitott {self.__tipus}, aminek a fedele {'Nyitva' if self.nyitva else 'Zárva'}."

    def __imul__(self, szam):
        self.elemek *= szam
        return self

    def __eq__(self, masik_savanyusag):
        if self.minoseget_megorzi == masik_savanyusag.minoseget_megorzi:
            if sorted(self.elemek) == sorted(masik_savanyusag.elemek):
                if self.__tipus == masik_savanyusag.__tipus:
                    if self.nyitva == masik_savanyusag.nyitva:
                        return True
        return False


if __name__ == '__main__':
    savanyusag_1 = Savanyusag((2024, 10, 8), True, ["uborka", "káposzta"])
    print(savanyusag_1.szavatos(2024, 9, 10))

    savanyusag_2 = Savanyusag((2024, 12, 8), True, ["cekla", "hagyma"])

    savanyusag_1 += savanyusag_2
    print(savanyusag_1)
    print(savanyusag_1.elemek)
    print(savanyusag_1.minoseget_megorzi)

    savanyusag_3 = Savanyusag((1998, 1, 2), False, ["hagyma", "uborka", "paradicsom"])
    print(savanyusag_3)
    savanyusag_3.tipus = "paprika"
    print(savanyusag_3)
    savanyusag_3.tipus = "hagyma"
    print(savanyusag_3)

    savanyusag_4 = Savanyusag((1998, 9, 3), False, ["retek"])
    print(savanyusag_4)
    print(savanyusag_4.elemek)
    savanyusag_4 *= 4
    print(savanyusag_4.elemek)

    savanyusag_5 = Savanyusag((1998, 9, 3), False, ["répa", "cékla"])
    savanyusag_6 = Savanyusag((1998, 9, 3), False, ["cékla", "répa"])
    print(savanyusag_5 == savanyusag_6)
