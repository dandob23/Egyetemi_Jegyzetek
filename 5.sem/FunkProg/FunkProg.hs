























































    module Types where

inc :: Int -> Int
inc a = a + 1
--divide' :: a -> (a -> (a))
divide' x y = x / y
--inc = ~ # + 1

add :: Int -> Int -> Int
add a b = a + b

v1 :: Int
v1 = 10
--alapból Integer (több memóriát használ))

inc2 :: Int -> Int
inc2 a = inc (inc a)

inc' :: Int -> Int
inc' a = (+) a 1

--inc'' a = 

sho0, sho1 :: Int
sho0 = maxBound
sho1 = minBound

big :: Integer
big = 2*(2*(2*2))

{- shw :: n -> n
shw n = n -}

--Option ü = `

exi1 = True && False
exi2 = not (False || True)
exi3 = ('a' == 'a')
exi4 = (16 /= 3)
exi5 = (5 > 3) && ('p' <= 'q')

sumt :: Integer -> Integer
--sumt u = u
sumt n = n + sumt (n -1)

iseven' :: Int => Bool
iseven' r = r `mod` 2

isodd' :: Int => Bool
isodd' r = not (r `mod` 2)

--HF: Háromszög szerkeszthetősége, Pitagorasz, szökőév-e egy év

-- Háromszög szerkeszthetősége
-- Pitagorasz
-- szökőév-e egy év

isTriangle :: Int -> Int -> Int -> Bool
isTriangle a b c = a + b > c && a + c > b && b + c > a

isPitagoryan :: Int -> Int -> Int -> Bool
isPitagoryan a b c = a^2 + b^2 == c^2

isLeapYear :: Int -> Bool
isLeapYear y
    | (y `mod` 4 == 0) && (y `mod` 100 /= 0) || (y `mod` 400 == 0) = True
    | otherwise = False

    --Harmadik gyakorlat feladatai.pdf



add:: Int-> Int -> Int --int és int megy intbe
add x y = x + y

in_r :: Int -> Int -> Int -> Bool
in_r min max x = x >= min && x <= max

f = (>) 5

in_r2 min max x = ilb && iub 
 where
    ilb = min <= x
    uib = max >= x

in_r3 min max x = 
    if ilb then iub else False
    where 


fac2 n
    | n <= 1 = 1
    | otherwise = n * fac2 (n-1)


fac3 n
    | n <= 1 = 1
    | True = n * fac2 (n-1)


---- Tail recursion

recf n acc
    | n <= 1 = acc
    | otherwise = recf (n-1) (n*acc)

----- egy paraméterrel ugyanez -----------------
factr n = f n 1
 where 
  f n acc
    | n <= 1 = acc
    | otherwise = f (n-1) (n*acc)

-- Fibonacci szamok n-ig (vegrekurzivan a legjobb)

fibonacci :: Int -> Int
fibonacci n 
| n == 0 = 0 
| n == 1 = 1 
| otherwise = fibonacci (n - 1) + fibonacci (n - 2)


fac3 n
    | n <= 1 = 1
    | True = n * fac3 (n-1)


---- Tail recursion

recf n acc
    | n <= 1 = acc
    | otherwise = recf (n-1) (n*acc)

----- egy paraméterrel ugyanez -----------------
factr n = f n 1
 where 
  f n acc
    | n <= 1 = acc
    | otherwise = f (n-1) (n*acc)

    -- add' :: Int -> Int -> Int
-- add' b = (+) b 
add' = (+)



and' :: Bool -> Bool -> Bool
and' True True = True
and' _ _ = False
-- and' True False = False
-- and' False True = False
-- and' False False = False



or' :: Bool -> Bool -> Bool
or' False False = False
or' _ _ = True
-- or' True False = True
-- or' False True = True
-- or' True True = True



xor :: Bool -> Bool -> Bool
xor True False = True
xor False True = True
xor _ _ = False



add2 :: Int -> Int -> (Int, Int)
add2 0 0 = (0, 0)
add2 0 1 = (1, 0)
add2 1 0 = (1, 0)
add2 1 1 = (0, 1)



pairs :: (Int, Int) -> (Int, Int) -> (Int, Int, Int, Int)
pairs (a, b) (c, d) = (a + b, c + d, a * b, c * d)




paren :: Char -> Char -> Bool
paren '(' ')' = True
paren '[' ']' = True
paren '{' '}' = True
paren _ _ = False



calc :: (Int, Char, Int) -> Int
calc (a, '+', b) = a + b
calc (a, '-', b) = a - b
calc (a, '*', b) = a * b
calc (a, '/', b) = div a b


---------------------------------------------------------------------------hf mindent megoldani őrjelekkel (vagy)

--sum' [1, 2, 3] == 6
sum' :: [Int] -> Int
sum' [] = 0
sum' (x:xs) = x + sum' xs
--eleje:vege

add' :: Int -> Int -> Int
add' a b
    | a == 0 && b == 0 = 0
    | otherwise = a + b



and' :: Bool -> Bool -> Bool
and' a b
    | a == True && b == True = True
    | otherwise = False



or' :: Bool -> Bool -> Bool
or' a b
    | a == False && b == False = False
    | otherwise = True



xor :: Bool -> Bool -> Bool
xor a b
    | a == True && b == False = True
    | a == False && b == True = True
    | otherwise = False



add2 :: Int -> Int -> (Int, Int)
add2 a b
    | a == 0 && b == 0 = (0, 0)
    | a == 0 && b == 1 = (1, 0)
    | a == 1 && b == 0 = (1, 0)
    | a == 1 && b == 1 = (0, 1)



paren :: Char -> Char -> Bool
paren a b
    |a == '(' && b == ')' = True
    |a == '[' && b == ']' = True
    |a == '{' && b == '}' = True
    |otherwise = False


-- + házi

insertIntToList :: [Int] -> Int -> [Int]
insertIntToList [] ujSzam = [ujSzam]
insertIntToList (x:xs) ujSzam
    | ujSzam <= x = ujSzam : x : xs
    | otherwise = x : insertIntToList xs ujSzam


-- ghci> let lista = [1,2,3]
-- ghci> let ujSzam = 4
-- ghci> let ujLista = insertIntToList lista ujSzam
-- ghci> print ujLista


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

module Test where
import Data.Char (toUpper)

headInt :: [Int] -> Int
headInt (x:_) = x


tailInt :: [Int] -> [Int]
tailInt (_:xs) = xs


nullInt :: [Int] -> Bool
nullInt [] = True
nullInt _ = False


isSingletonInt :: [Int] -> Bool
isSingletonInt (_ : []) = True
isSingletonInt _ = False


toUpperFirst :: [Char] -> [Char]
toUpperFirst (c:cs) = toUpper c : cs
toUpperFirst _ = ""


listgen :: Int -> Int -> [Int]
listgen n m
    |m < n = []
    |m == n = [m]
    |m > n = n : listgen (n + 1) m


isLetter :: Char -> Bool
isLetter c  = elem c ['a'..'z']


isDigit :: Char -> Bool
isDigit a = elem a ['0'..'9']


mountain :: Int -> [Int]
mountain n = [1..n] ++ [n - 1, n - 2 .. 1]


divisors :: Int -> [Int]
divisors n = [d | d <- [1..n], mod n d ==0] --halmazkifejezés


powerOfTwo :: [Int]
powerOfTwo = [2 ^ p | p <- [0..]]



--1 függvény kiszámolja az elemek átlaga
--2 powerOfTwo ugy hogy nem listagenerátor, hanem rekurzivan (2 6 -> 2^6)

--1
average :: [Double] -> Double
average xs
    | null xs = 0.0
    | otherwise = sum xs / fromIntegral (length xs)


--2
powerOfTwo :: Int -> Int -> Int
powerOfTwo _ 0 = 1
powerOfTwo x n = x * powerOfTwo x (n - 1)

-- HPC basic knowledge (HPC ALAPISMERETEK)
-- plusz pont a jegybe  oktober 30-ig

--lista, ami sorrendben tartalmazza az összes óra-perc párt
import Data.Char (toUpper)

--lenght time == 1440
time :: [(Int, Int)]
time = [(h, m) | h <- [0..23], m <- [0..59]]

amtime :: [(Int, Int)]
amtime = [(h, m) | h <- [0..23], m <- [0..59], h < 13]

{-
main :: IO ()
main = do
     print(lenght time == 1440)
     print(and [lenght time == 1440, lenght time == 1440])
-}

isPrimes :: Int -> Bool
isPrimes n = [k | k <- [1..n], mod n k == 0] == [1, n]

take' :: [Int]
take' = [p | p<-[1..], isPrimes p]

allPositive :: [Int] -> Bool
--allPositive k = [l | l <- [k], l < 0]
allPositive l = null [e | e <- l, e < 0]

domino :: [(Int, Int)]
domino = [(b, j) | b <- [0..6], j <- [b..6]]

--26
alphabet :: [(Int, Char)]
--alphabet = [(sz, b) | sz <- [0..26], b <- ['a'..'z']]
alphabet = zip [0..] ['a'..'z']


--hf gyujtsd ki minden 3. betut az angol abcbol listakifejezesekkel (cycle es zip fuggvenyekkel)
--lista ami sorrendben tartalmazza az osszes (honap nap) listat egy 365 napos évben
-- + ez itt alatta (range)

range :: Int -> Int -> [Int]
range a b 
     |a == b = [a]
     |a > b = [a, a-1..b]
     |otherwise = [a..b]

     import Data.Char (toUpper)
time :: [(Int, Int)]
time = [(h, m) | h <- [0..23], m <- [0..59]]

--sum függvény rekurzival
module Test where


sum' :: [Int] -> Int 
sum' [] = 0
sum' (x:xs) = x + sum' xs

last' :: [Int] -> Int
last' [n] = n
last' (x:xs) = last' xs

and' :: [Bool] -> Bool
and' [] = True
and' (x:xs) = x && and' xs

or' :: [Bool] -> Bool
or' [] = False
or' (x:xs) = x || or' xs

repeat' a = [a, a..]

replicate' a b
     |a > 0 = b : replicate'(a - 1) b
     |otherwise = []

format' :: Int -> String -> String
format' len s = replicate' (len - length s) ' ' ++ s

insert' :: Int -> [Int] -> [Int]
insert' n [] = [n]
insert' n (m:ms)
     |n < m = n : m : ms
     |otherwise = m : insert' n ms

sort' :: [Int] -> [Int]
sort' [] = []
sort' (n:ns) = insert' n (sort' ns)


--hf merge ami:
--fésülj össze két rendezett , egészekbol alló listat ugy hogy az eredmeny is rendezett maradjon
-- + mergesort

daysInMonth :: [Int]
daysInMonth = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31]
year :: [(Int, Int)]
year = [(month, day) | (month, days) <- zip [1..12] daysInMonth, day <- [1..days]]

--hf merge ami:
--fésülj össze két rendezett , egészekbol alló listat ugy hogy az eredmeny is rendezett maradjon
-- + mergesort

--1.
merge :: Ord a => [a] -> [a] -> [a]
merge [] ys = ys
merge xs [] = xs
merge (x:xs) (y:ys)
    |x <= y = x : merge xs (y:ys)
    |otherwise = y : merge (x:xs) ys

-- merge [1,2,3,4,5,6,7] [3,6,7,8,11]  -->  [1,2,3,3,4,5,6,6,7,7,8,11]



--2.
mergesort :: Ord a => [a] -> [a]
mergesort [] = []
mergesort [x] = [x]
mergesort xs = merge (mergesort firstHalf) (mergesort secondHalf)
    where
        (firstHalf, secondHalf) = splitAt (length xs `div` 2) xs

--mergesort [3,6,99,22,1]  -->  [1,3,6,22,99]