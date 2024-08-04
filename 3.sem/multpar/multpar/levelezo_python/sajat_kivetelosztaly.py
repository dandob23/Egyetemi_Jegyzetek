class NincsPisztaciaException(Exception):
    def __init__(self, uzenet):
        self.uzenet = uzenet
        super().__init__(self.uzenet) # ősosztály konstruktorának meghívása

try:
    fagyik = ["csoki", "vanília", "eper"]
    if "pisztácia" not in fagyik:
        raise NincsPisztaciaException("Elfogyott a pisztácia! :(")

except NincsPisztaciaException as npe:
    print(npe)