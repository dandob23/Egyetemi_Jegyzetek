def szamot_novel(szam):
    szam = szam + 1  # új objektum jön létre
    print("Belül:", szam)


def main():
    x = 3 # immutable
    print("Kívül:", x)  # 3
    szamot_novel(x)  # 4
    print("Kívül:", x)  # 3

def lista_bovit(lista):
    lista.append(4)
    print("Belül:", lista)

def main2():
    l = [1, 2, 3]
    print("Kívül:", l)   # [1,2,3]
    lista_bovit(l)       # [1,2,3,4]
    print("Kívül:", l)   # [1,2,3,4]

main2()
