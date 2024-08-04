"""
ertek = 5/0

raise Exception()
raise Exception("Hiba")

try:


except ExceptionType as e:

finally:
"""



def osztas(a, b):
    if isinstance(a, int) and isinstance(b, int):
        if b==0:
            raise ZeroDivisionError("0val ne osszunk")
        return a/b
    raise TypeError ("egesz parametereket adj meg")

#kivetelezes

try:
    print(osztas(1, 2))
    print(osztas(1, 0))
except ZeroDivisionError as zde:
    print(zde)
except TypeError as te:
    print(te)
except Exception:
    print("vmi hiba tortent")
finally:
    print("...kivetelezes vege...")


#sajat kivetelosztaly

class nincspisztaciaException(Exception):
    def __init__(self, uzenet):
        self.uzenet = uzenet
        #ősosztaly konstruktoranak meghivasa
        super().__init__(self.uzenet)

    try:
        fagyik=["csokoládé","vanília","málna","citrom","karamel"]
        if "pisztácia" not in fagyik:
            raise nincspisztaciaException("no pisztacia")
    except nincspisztaciaException as npe:
        print(npe)










