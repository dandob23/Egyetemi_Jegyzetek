--(\<args> -> <expr>)
import Data.Char
 
map' :: (a -> b) -> [a] -> [b]
map' _ [] = []
map' f (a:as) = f a : map' f as

--map' (\y -> y + 5) [1,2,3]     
--[6,7,8]

---------------------------------------------------------------------------------
filter' :: (a -> Bool) -> [a] -> [a]
filter' _ [] = []
filter' f (a:as)
    |f a = a : filter' f as
    |otherwise = filter' f as

--filter' (\y -> y > 5) [1,2,3,4,5,6,7,8,9]
--[6,7,8,9]
---------------------------------------------------------------------------------

all' :: (a -> Bool) -> [a] -> Bool
all' _ [] = True
all' f (a:as) = f a && all' f as
---------------------------------------------------------------------------------
any' :: (a -> Bool) -> [a] -> Bool
any' _ [] = False
any' f (a:as) = f a || any' f as

---------------------------------------------------------------------------------
elem' :: Eq => a -> [a] -> Bool
elem' x l = any' (\y -> x == y) l
---------------------------------------------------------------------------------

--hf magasabb rendű függvények
--hasAny -> megvizsgálja hogy egy lista elemei közül valamelyik előfordul -e egy másik listában 
--takeWhile' -> olyan mint egy while, addig fut amig igaz a feltétel 