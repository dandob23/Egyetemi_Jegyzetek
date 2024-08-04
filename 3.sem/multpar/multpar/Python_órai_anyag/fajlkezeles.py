# a be.txt fájl megnyitása olvasásra
# első paraméter: a megnyitni kívánt fájl elérési
# útvonala
#a 2. paraméter: fájlmegnyitás módja
# r: olvasás, w: írás, a: hozzáfűzés
file = open("be.txt", "r")

# a teljes a fájl tartalmának beolvasása
# readline() egy sor beolvasása
# readlines() az egész fájl beolvasása
tartalom = file.readlines()

# a tartalom kiíratása soronként
for sor in tartalom:
    print(sor)

# a megnyitott fájl lezárása
file.close()