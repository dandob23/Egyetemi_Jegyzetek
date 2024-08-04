import random as rnd
import time
arr=[1,3,4,6,2,8,5]
print(arr)
#------------------------------------------------------#
def maxKiv(arr):
    max=arr[0]
    maxPoz = 0
    for i in range(1,len(arr)):
        if arr[i]>max:
            max=arr[i]
            maxPoz=i
    return max,maxPoz
print(maxKiv(arr))
#------------------------------------------------------#
def linker1(arr,T,n):
    i=0
    while(i<n and arr[i]!=T):
        i=i+1
    if i!=n:
        return True
    else:
        return False
#------------------------------------------------------#
def linkerStrazsas(arr,T,n):
    arr.append(T)
    i=0
    while(arr[i]!=T):
        i=i+1
    if i!=n:
        return True
    else:
        return False
#------------------------------------------------------#        
def linker2(arr,T):
    i=0
    while(True):
       if (i<len(arr) and arr[i]!=T):
           i+=1
       else:
           return i
#------------------------------------------------------#
def linkerRendezett(arr,T,n):
    i=0
    while(i<n and arr[i]!=T and T<=arr[i]):
        i=i+1
    if i!=n or arr[i]==T:
        return True
    else:
        return False
#------------------------------------------------------#
def feltolt(n):
    arr=[]
    for i in range(0,n):
        arr.append(rnd.randint(0,100000))
    return arr
#------------------------------------------------------#
start=time.time()
arrTest = feltolt(10000000)
stop=time.time()
print("A feltöltés ideje: " +str(stop-start))
T=5     
n=len(arrTest)
start=time.time()
print(linker1(arrTest,T,n))
stop=time.time()
print("linker: " +str(stop-start))
start=time.time()
print(linkerStrazsas(arrTest,T,n))
stop=time.time()
print("strázsás ker: " +str(stop-start))

print("......")
print(len(arr))
if linker2(arr,T)==len(arr):
    print(False)
else:
    print(True)

arrTest.sort()
stop=time.time()
print("A rendezés ideje: " +str(stop-start))

start=time.time()
linkerRendezett(arrTest,T,n)
stop=time.time()
print("A keresés ideje rendezett sorozaton: "+str(stop-start))





