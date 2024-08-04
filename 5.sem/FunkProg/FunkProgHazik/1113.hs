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