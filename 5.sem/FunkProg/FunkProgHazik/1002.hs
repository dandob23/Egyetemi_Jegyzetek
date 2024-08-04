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