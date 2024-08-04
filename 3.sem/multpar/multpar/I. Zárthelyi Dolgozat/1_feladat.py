# === 1. feladat: Mocking Spongebob ===

import random


def mocking_spongebob():
    szoveg = input("Add meg a szöveget: ")
    eredmeny = ""

    for karakter in szoveg:
        if random.randint(0, 1) == 0:
            eredmeny += karakter.upper()
        else:
            eredmeny += karakter.lower()

    return eredmeny


print(mocking_spongebob())