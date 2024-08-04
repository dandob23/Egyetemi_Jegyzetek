try:
    file = open("be.txt", "r")
    tartalom = file.readlines()

    for sor in tartalom:
        print(sor)

    file.close()

except FileNotFoundError as fnfe:
    print("A fájl nem található!")