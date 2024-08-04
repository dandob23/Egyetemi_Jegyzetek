# === 2. feladat: Leghosszabb szó ===

def leghosszabb_szo(szoveg):
    if szoveg == "":  # Ha a paraméter az üres string, akkor a "HIBA!" szöveggel térünk vissza
        return "HIBA!"

    szavak = szoveg.split()  # A szöveg szavait eltároljuk egy listában
    leghosszabb = ""  # Ebben a változóban fogjuk eltárolni a szöveg leghosszabb szavát

    for szo in szavak:  # Végigmegyünk a szöveg szavain
        if len(szo) > len(leghosszabb):  # Ha egy szó hosszabb, mint az eddig ismert leghosszabb szó, ...
            leghosszabb = szo  # ...akkor frissítjük a leghosszabb szót tároló változó értékét

    return leghosszabb


print(leghosszabb_szo("Szia uram! Jeles zárthelyi dolgozat érdekel?"))
