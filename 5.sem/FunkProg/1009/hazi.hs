
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