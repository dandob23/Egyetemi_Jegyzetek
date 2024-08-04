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