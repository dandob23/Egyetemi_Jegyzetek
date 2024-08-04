def szamot_novel(szam):
    szam+=1
    print("belul: ",szam)

def main():
    x=3
    print("kivul: ",x)      #3
    szamot_novel(x)         #4
    print("kivul: ",x)      #3


main()

def lista_bovit(lista):
    lista.append(4)
    print("belul: ",lista)

def main2():
    l=[1,2,3]
    print("kivul: ",l)      #[1,2,3]
    lista_bovit(l)          #[1,2,3,4]
    print("kivul: ",l)      #[1,2,3,4]   tinyurl.com/kadam_share

main2()