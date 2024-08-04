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