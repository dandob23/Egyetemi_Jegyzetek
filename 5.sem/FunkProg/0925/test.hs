
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