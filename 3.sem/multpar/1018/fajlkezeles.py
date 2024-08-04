#a be txt megnyitasa olvasasra
#elso parameter: megnyitni a kivant fajl eleresi utvonala
#masodik parameter: fajlmegynitas modja
#r: olvasas, w:iras, a:hozzafuzes
file = open("be.txt","r")


#teljes fajl tartalmanak olvasasa
#readline() egy sor beolvasasa
#readlines() egesz fajl beolvasasa

tartalom = file.readlines()
for sor in tartalom:
    print(sor)

file.close()







