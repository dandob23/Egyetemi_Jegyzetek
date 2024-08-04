#instance method, class method, static method
class Auto:
    tank=50
    def __init__(self, kilometer_ora):
        self.kilometer_ora=kilometer_ora

    # instance
    def show(self):
        print("Az autó tank mérete: "+ str(Auto.tank)
              +" és " + "a kilométer óra állása "+str(self.kilometer_ora))

    @classmethod
    def tank_novelese(cls, tank):
        cls.tank=tank

    @staticmethod
    def van_index(marka):
        if marka == Auto:
            return "Nincs"
        else:
            return "Van"

auto1=Auto(120000)
auto1.show()
Auto.tank_novelese(100)
auto1.show()
print(Auto.van_index("Auto"))