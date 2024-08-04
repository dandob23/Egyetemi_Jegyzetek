# Instance Method, Class method, Static Method
class BMWX6:
    # class variable
    tank = 50
    def __init__(self, kilometer_ora):
        self.kilometer_ora = kilometer_ora

    # instance
    def show(self):
        print("Az autó tank mérete: " + str(BMWX6.tank) + " és" +
              " kilométer óra állása: " + str(self.kilometer_ora))

    @classmethod
    def tank_novelese(cls, tank):
        cls.tank = tank

    @staticmethod
    def van_index(marka):
        if marka == "BMW":
            return "Nincs"
        else:
            return "van"

auto1 = BMWX6(120000)
auto1.show()
BMWX6.tank_novelese(100)
auto1.tank_novelese(120)
auto1.show()
print(BMWX6.van_index("BMW"))
