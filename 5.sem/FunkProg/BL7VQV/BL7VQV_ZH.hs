--FUNKCIONÁLIS PROGRAMOZÁS ZH
--Dobozy Dániel BL7VQV

--1.feladat
howMany :: Char -> String -> Int
howMany _ [] = 0
howMany a (x:xs)
    |a == x = 1 + howMany a xs
    |otherwise = howMany a xs


--2.feladat
insertAt :: Int -> a -> [a] -> [a]
insertAt n x xs
    |n <= 0 = x:xs
    |n >= len = xs ++ [x]
    |otherwise = take n xs ++ [x] ++ drop n xs
    where
        len = length xs


--3.feladat
merge :: [a] -> [a] -> [a]
merge [] ys = ys
merge xs [] = xs
merge (x:xs) (y:ys) = x : y : merge xs ys