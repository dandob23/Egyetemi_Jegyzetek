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

