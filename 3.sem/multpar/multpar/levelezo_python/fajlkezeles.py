# Fájlkezelő függvények
# open(path, mode): fájl megnyitása
    # path: a megnyitni kívánt fájl elérési útvonala (szöveg)
    # mode: fájlmegnyitás módja (szöveg)
        # "r": olvasásra (alalpértelmezett)
        # "w": írásra (felülírja a korábbi tartalmat)
        # "a": fájl végéhez való hozzáfűzés
        # "x": kizárólagos létrehozásra (ha már létezik a fájl, akkor hibát kapunk)
        # egy fájlt megnyithatunk szöveges ("t") vagy bináris ("b) módban (szöveges alapértelmezett)

# A megnyittot fájlon több műveletet használhatunk:
    # read(n): n darab karakter beolvasása (ahol éppen vagyunk a fájlban)
    # readline(): egy sor beolvasása (ahol éppen vagyunk a fájlban)
    # readlines(): az egész fájl beolvasása, soronként
    # write(szoveg): adott szöveg írása fájlba
    # close(): a megnyitott fájl lezárása

# a bemenet.txt fájl megnyitása olvasásra
file = open("bemenet.txt", "r")

# a teljes fájl tartalmának beolvasása
tartalom = file.readlines()

# a tartalom kiíratása soronként
for sor in tartalom:
    print(sor)

# a megnyitott fájl lezárása
file.close()

# Kontextuskezelő (context manager) használata: with
""" Példa
A bemenet.txt minden sora egy-egy egész számot tartalmaz. Olvassuk be a fájl tartalmát, majd számítsuk ki
a fájlban szereplő értékek átlagát! Ez írjuk ki egy kimenet.txt nevű állományba!
"""

atlag = 0
with open("bemenet.txt", "r") as f:     # bemenet.txt megnyitása olvasásra
    osszeg = 0
    darab = 0

    sor = f.readline()                  # első sor beolvasása
    while sor:                          # amíg van sor a fájlban...
        osszeg += int(sor)              # hozzáadjuk az adott számot az összeghez
        darab += 1                      # növeljük a beolvasott számok darabszámát
        sor = f.readline()              # beolvassuk a következő sort

atlag = osszeg / darab                  # az átlag az összeg és darabszám hányadosa

with open("kimenet.txt", "w") as f:     # kimenet.txt megnyitása írásra
    f.write("Az Átlag: " + str(atlag))  # az eredmény fájlba írása