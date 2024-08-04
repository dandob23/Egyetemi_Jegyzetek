from datetime import date
class Ember:
    def __init__(self, nev, kor):
        self.nev = nev
        self.kor = kor

    # osztálymetódust
    @classmethod
    def szuletesi_ev(cls, nev, ev):
        return cls(nev, date.today().year - ev)

    # statikus metódust
    @staticmethod
    def felnott(kor):
        return kor > 18

ember1 = Ember("Ádám", 27)
ember2 = Ember.szuletesi_ev("Tamás", 1993)
print(ember1.kor)
print(ember2.kor)

print(Ember.felnott(30))
print(ember1.felnott(15))