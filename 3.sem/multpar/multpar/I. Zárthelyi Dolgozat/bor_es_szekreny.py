# === A Bor osztály ===

class Bor:
    # Konstruktor

    def __init__(self, fajta, evjarat, alkohol=12.5):  # Az `alkohol` paraméter megadását opcionálissá tesszük
        self.__fajta = fajta  # Az adattagokat a paraméterek alapján inicializáljuk
        self.__evjarat = evjarat
        self.alkoholtartalom = alkohol  # A setterrel ellenőrzött módon állítjuk be az adattag értékét

    # Get és set property-k

    @property
    def fajta(self):
        return self.__fajta

    @fajta.setter
    def fajta(self, ertek):
        self.__fajta = ertek

    @property
    def evjarat(self):
        return self.__evjarat

    @evjarat.setter
    def evjarat(self, ertek):
        self.__evjarat = ertek

    @property
    def alkoholtartalom(self):
        return self.__alkoholtartalom

    @alkoholtartalom.setter
    def alkoholtartalom(self, ertek):
        if isinstance(ertek, float) and 0 <= ertek <= 100:  # Ha a paraméter egy 0 és 100 közötti valós szám...
            self.__alkoholtartalom = ertek  # ...beállítjuk az adattag értékét a paraméterre...
        else:  # ...egyébként pedig a konzolra írunk
            print("Nem megfelelo alkoholtartalom!")

    # Az objektum szöveggé alakításáért felelő metódus

    def __str__(self):
        return f"{self.__fajta} (evjarat: {self.__evjarat}), melynek alkoholtartalma: {self.__alkoholtartalom}%"


# === A Szekreny osztály ===

class Szekreny:
    # Konstruktor

    def __init__(self):
        self.borok = []

    # Az objektum szöveggé alakításáért felelő metódus

    def __str__(self):
        if len(self.borok) == 0:  # Üres szekrény esetének lekezelése
            return "Ez egy ures szekreny."
        else:
            eredmeny = ""  # Ebben a változóban állítjuk elő a visszaadott szöveget
            stat = self.statisztika()  # Felhasználjuk a `statisztika` függvény által visszaadott dictionary-t

            for fajta, mennyiseg in stat.items():  # A statisztikákat tartalmazó dictionary bejárása...
                eredmeny += f"{mennyiseg} {fajta}, "

            eredmeny = eredmeny[:-2]  # Eltávolítjuk az eredmény szöveg végén lévő vesszőt és szóközt
            return eredmeny

    # Egyéb metódusok

    def get_bor(self, n):
        if n < 0 or n >= len(self.borok):  # Ha nem megfelelő az index értéke, a konzolra írunk...
            print("Nem letezo index!")
        else:
            return self.borok[n]  # ...egyébként visszaadjuk a `borok` lista adott indexű elemét

    def atlag_alkoholtartalom(self):
        if len(self.borok) == 0:  # Ha nincs egyetlen bor se a szekrényen, a konzolra írunk...
            print("Ures a szekreny!")

        # ...egyéb esetben visszaadjuk a szekrényen található borok alkoholtartalmának átlagát
        else:
            osszeg = 0
            darabszam = len(self.borok)

            for bor in self.borok:
                osszeg += bor.alkoholtartalom

            return osszeg / darabszam

    def statisztika(self):
        stat = {}  # Nem tudjuk előre, hogy milyen boraink vannak, ezért egy üres dictionary-ből indulunk ki

        for bor in self.borok:  # Végigmegyünk a szekrényen található borokon
            fajta = bor.fajta.lower()  # A bor fajtájának nevében a kis- és nagybetűket nem különböztetjük meg

            if fajta not in stat:  # Ha még nem láttuk korábban az adott fajtanevet...
                stat[fajta] = 1  # ...felvesszük 1-es előfordulási értékkel
            else:  # Ha pedig már láttuk korábban az adott fajtanevet...
                stat[fajta] += 1  # ...növeljük a hozzá tartozó előfordulási értéket

        return stat  # Visszatérünk a statisztikát tároló dictionary-vel

    def megisszak(self, bor):
        if not isinstance(bor, Bor):  # Nem Bor típusú paraméter esetén a konzolra írunk
            print("Nem bor!")
        elif bor not in self.borok:  # A szekrényen nem megtalálható borok esetén a konzolra írunk
            print("Bor nem talalhato!")
        else:
            self.borok.remove(bor)  # Töröljük a `borok` listából a paraméterben kapott bort


# === A főprogram ===

bor1 = Bor('Tokaji aszu', 2017, 13.5)
bor2 = Bor('Gyanus kinezetu kannasbor', 2010)
bor3 = Bor('ToKaJi AsZu', 2015, 13.8)
bor4 = Bor('Chardonnay', 2019, 13.0)

bor2.fajta = 'Egri bikaver'
bor2.evjarat = 2013
bor2.alkoholtartalom = 12.0
print(f'{bor2.fajta}, {bor2.evjarat}, {bor2.alkoholtartalom}')  # 'Egri bikaver, 2013, 12.0'

szekreny1 = Szekreny()
szekreny2 = Szekreny()

szekreny1.borok.append(bor1)
szekreny1.borok.append(bor2)
szekreny1.borok.append(bor3)
szekreny2.borok.append(bor4)

print(szekreny1.get_bor(0))  # 'Tokaji aszu (evjarat: 2017), melynek alkoholtartalma: 13.5%'
print(szekreny1.get_bor(2))  # 'ToKaJi AsZu (evjarat: 2015), melynek alkoholtartalma: 13.8%'
print(szekreny1.atlag_alkoholtartalom())  # 13.1

szekreny2.megisszak(bor4)
print(szekreny2.statisztika())  # {}
print(szekreny1.statisztika())  # {'tokaji aszu': 2, 'egri bikaver': 1}

print(szekreny1)  # '2 tokaji aszu, 1 egri bikaver'
print(szekreny2)  # 'Ez egy ures szekreny.'

print(szekreny1)
