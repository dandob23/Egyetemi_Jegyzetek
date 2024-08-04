import random
import math
import np

n=100000
k=0
circlepoints=[]
squarepoints=[]
for _ in range(n):
    x = random.random()*2
    y=random.random()*2
    if (x-1)**2 + (y-1)**2 <= 1:
        k+=1
        circlepoints.append([x,y])
    else:
        squarepoints.append([x,y])
print(4*k/n)
circlepoints=np.array(circlepoints)
