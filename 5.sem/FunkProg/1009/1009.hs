nums, range, rrange :: [Integer]
nums = [1,2,3,4]
range = [1..100]
rrange = [1, 5..10] 

empty = []

ex18 = 1 : []
ex19 = 3 : (1 : [])
ex20 = 2 : 3 : 4 : []
ex21 = [2,3,4] == 2 : 3 : 4 : []

-- String, Char

hello1 :: [Char]
hello1 = ['H','e','L','L','o']
hello2 :: String
hello2 = "hello"
helloS = hello1 == hello2

-- LISTA FÜGGVÉNYNEK

import Data.list

head :: [a] -> a
head [1,2,3,4,5]


tail :: [a] -> [a]
tail [1,2,3,4,5]



lenght :: [a] -> Int
lenght [1,2,3,4,5]


init :: [a] -> [a]
init [1,2,3,4,5]


null :: [a] -> Bool
null []

null [1,2,3,4,5]

and::[Bool] -> Bool
and [True, False, True]

or:: [Bool] -> Bool
and [True,False,True]