# === 3. feladat: Boldogok a lelki szegények ===

# == 1. megoldás ==

def boldog_szamok(num):
    num = str(num)
    num_len = len(num)
    sum = 0
    for i in range(num_len):
        sum += int(num[i]) ** 2
    if sum == 1:
        print("Boldog szám! :)")
    elif sum == 4:
        print("Boldogtalan szám! :'(")
    else:
        boldog_szamok(sum)


boldog_szamok(486)


# == 2. megoldás ==

def boldog_szamok1(num):
    sum = 0
    while (num > 0):
        rem = num % 10;
        sum = sum + (rem * rem)
        num = num // 10;
    return sum


num = 82

while (num != 1 and num != 4):
    num = boldog_szamok1(num)

if (num == 1):
    print("Boldog szám! :)")
elif (num == 4):
    print("Boldogtalan szám! :'(")


# == 3. megoldás ==

def boldog_szamok2(n):
    past = set()
    while n != 1:
        for i in str(n):
            n = int(i) ** 2
        if n in past:
            return "Boldog szám! :)"
        past.add(n)
    return "Boldogtalan szám! :'("


print(boldog_szamok2(7))
print(boldog_szamok2(932))
print(boldog_szamok2(6))
