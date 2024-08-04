# be.txt fájlnak minden sora egy-egy egész számot tartalmaz
# Olvassuk be a fájl tartamát, majd számítsuk ki a fájlban
# szereplő értékek átlagát.
# Ezt írjuk ki egy ki.txt nevű állományba.

atlag = 0           # változó az átlagnak
with open("be.txt", "r") as input:
    osszeg = 0
    darab = 0
    sor = input.readline()      # első sor beolvasása
    while sor:                  # amíg van sor a fájlban
        osszeg += int(sor)      # hozzáadjuk az adott számot az összeghez
        darab += 1              # növeljük a beolvasott számok darabszámát
        sor = input.readline() # beolvassuk a következő sort

atlag = osszeg / darab

with open("ki.txt", "w") as output:
    # fájlba írni a write függvénnyel lehet
    output.write("Az átlag " + str(atlag))






