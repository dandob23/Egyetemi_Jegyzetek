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


