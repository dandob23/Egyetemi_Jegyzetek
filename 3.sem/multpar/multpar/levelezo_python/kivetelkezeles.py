""" Példa
Írjunk egy osztás függvényt, amely két egész paramétert vár (a és b), visszatéérési értéke pedig
az a/b hányados! Ha nem egész típusú paramétereket kapunk vagy ha nullával szeretnénk osztani,
dobjunk kivételt!
"""
def osztas(a, b):
    if isinstance(a, int) and isinstance(b, int):
        if b == 0:
            raise ZeroDivisionError("Nullával nem osztunk!!!")
        return a/b
    raise TypeError("Egész patamétereket adj meg!")

try: # a kód azon része, ahol a kivétel dobódhat
    print(osztas(10,5))
    print(osztas(5, 0))
    print(osztas(3, "alma"))
except ZeroDivisionError as zde: # kivétel elkapása
    print(zde)
except TypeError as te:
    print(te)
except Exception:
    print("Valami hiba történt.. :(")
finally:
    print("kivételkezelés vége")


