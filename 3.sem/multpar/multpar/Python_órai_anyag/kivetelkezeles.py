"""
ertek = 5/0
print("Angry Négyesi noises..")

# Kivétel dobása
raise Exception() # Exception típusú kívétel dobása
raise Exception("Hiba")

# try, except, finally

try:
    # a kód azon része, ahol kivétel dobódhat
except ExectionType as e:
    # ExceptionType típusú kívétel elkapása
finally:
    # mindenképpen lefutó kódrész
"""

# Írjunk egy osztás függvényt, amely két egész szám paramétert vár(a és b),
# visszatérési értéke pedig az a/b hányados!
# Ha nem egész típusú paramétereket kapunk vagy ha nullával szeretnénk osztani,
# dobjunk kivételt!

# --> függvény <--: raise(kivétel)
"""
def osztas(a, b):
    if isinstance(a, int) and isinstance(b, int):
        if b == 0:
            raise ZeroDivisionError("Jaj nullával nem osztunk! :-( jujujuj")
        return a/b
    raise TypeError("Egész paramétereket adj meg!")

# --> kivételkezelés <--
try:
    print(osztas(1,2))
    print(osztas(1,0))
except ZeroDivisionError as zde:
    print(zde)
except TypeError as te:
    print(te)
except Exception:
    print("Valami hiba történt..")
finally:
    print("... kivételkezelés vége ... ")
"""

# Saját kivételosztály
class NincsPisztaciaException(Exception):
    def __init__(self, uzenet):
        self.uzenet = uzenet
        # ősosztály konstruktorának meghívása
        super().__init__(self.uzenet)

try:
    fagyik = ["csokoládé", "vanília", "málna", "citrom", "karamell"]
    if "pisztacia" not in fagyik:
        raise NincsPisztaciaException("No pisztacia")
except NincsPisztaciaException as npe:
    print(npe)






