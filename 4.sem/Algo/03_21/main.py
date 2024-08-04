import math
# lineárisKeresés, strázsásKeresés

# linKer rendezett sorozaton

v=[1,5,6,2,3,9,10,11,20,45,14]
###v.sort()
print(v)
j=0
lepesSzam=0
while(j<len(v)):
    i=0
    while(i<len(v)-j-1):
        lepesSzam+=1
        if(v[i]>v[i+1]):
            temp=v[i]
            v[i]=v[i+1]
            v[i+1]=temp
        i+=1
    j+=1
print(lepesSzam)
print(v)
#--------------------------------------------------------------------------#
lepesLK=0
def linKer(v,t):
    i=0
    lepesLK=0
    while(i<len(v)):
        lepesLK+=1
        if(v[i]==t):
            return True,lepesLK
        i+=1
    return False,lepesLK
#--------------------------------------------------------------------------#
lepesLKR=0
def linKerRendezettSorozaton(v,t):
    i=0
    lepesLKR=0
    while(i<len(v) and v[i]<=t):
        lepesLKR+=1
        if(v[i]==t):
            return True,lepesLKR
        i+=1
    return False,lepesLKR
t=4
print(linKer(v,t))    
print(linKerRendezettSorozaton(v,t))
#--------------------------------------------------------------------------#
#becslés
h=0
for i in range(0,len(v)):
    h+=1/(float)(len(v))*math.log2(1/(float)(len(v))) 

print(-h)
#--------------------------------------------------------------------------#
lepesBK=0
def binarisKereses(s,t):
    lepesBK=0
    e=0
    v=len(s)
    while(e<v):
        k=(int)((e+v)/2)
        print("E: "+str(e))
        print("K: "+str(k))
        print("V: "+str(v))
        lepesBK+=1
        if(s[k]==t):
            return True, lepesBK
        if(s[k]>t):
            v=k-1
        else:
            e=k+1
    return False,lepesBK
    
print(binarisKereses(v,t))
    

#homework: 
"""
TANAR KODJA
'''

                            Online Python Compiler.
                Code, Compile, Run and Debug python program online.
Write your code in this editor and press "Run" button to execute it.

'''
import math

# linKeresés, strázsásKeresés

#linKer rendezettt sorozaton
V=[1,5,6,2,3,9,10,11,20,45,14]
print(V)
#V.sort()
j=0
lepesSzam=0
while(j<len(V)-1):
    i=0
    while(i<len(V)-j-1):
        lepesSzam+=1
        if(V[i]>V[i+1]):
            temp=V[i]
            V[i]=V[i+1]
            V[i+1]=temp
        i+=1
    j+=1
print(lepesSzam)
print(V)



def linKer(V,T):
    i=0
    lepesLK=0
    while(i<len(V)):
        lepesLK+=1
        if(V[i]==T):
            return True,lepesLK
        i+=1
    return False,lepesLK
    


def linKerRendezettSorozaton(V,T):
    i=0
    lepesLKR=0
    while(i<len(V) and V[i]<=T):
        lepesLKR+=1
        if(V[i]==T):
            return True,lepesLKR
        i+=1
    return False,lepesLKR
T=1
print(linKer(V,T))
print(linKerRendezettSorozaton(V,T))


#becslés
H=0
for i in range(0,len(V)):
    H+=1/(float)(len(V))*math.log2( 1/(float)(len(V)))

print(-H)
lepesBK=0
def binarisKereses(S,T):
    lepesBK=0
    E = 0
    V = len(S)
    while(E<=V):
        K = (int)((E+V) / 2)
        print("**************")
        print("E: " + str(E))
        print("K: " + str(K))
        print("V: " + str(V))
        print("**************")
        lepesBK+=1
        if(S[K]==T):
            return True, lepesBK
        if(S[K]>T):
            V=K-1
        else:
            E=K+1
        print("**************")
        print("E: " + str(E))
        print("K: " + str(K))
        print("V: " + str(V))
        print("**************")
    return False, lepesBK

print(binarisKereses(V,T))




#bináris keresés



"""