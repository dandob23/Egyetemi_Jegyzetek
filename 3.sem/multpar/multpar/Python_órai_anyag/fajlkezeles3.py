# kontextuskezelő mechanizmus
# with kulcsszó
with open("be.txt", "r") as my_file:
    # a megnyitott fájlra my_file-ként tudunk hivatkozni
    tartalom = my_file.readlines()
    for sor in tartalom:
        print(sor)
