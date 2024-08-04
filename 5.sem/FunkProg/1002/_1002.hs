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

