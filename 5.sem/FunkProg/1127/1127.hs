import Data.Char
import Data.List

all' :: (a -> Bool) -> [a] -> Bool
all' _ [] = True
all' f (a:as) = f a && all' f as

any' :: (a -> Bool) -> [a] -> Bool
any' _ [] = False
any' f (a:as) = f a || any' f as

--elem' :: Eq a => a -> [a] -> Bool
--elem' x l = any' (\y -> x == y) 

--hf elem'-mel
--hasAny :: Eq a => [a] -> [a] -> Bool
--hasAny

takeWhile' :: (a -> Bool) -> [a] -> [a]
takeWhile' _ [] = []
takeWhile' f (a:as)
    |f a = a: takeWhile' f as
    |otherwise = []

dropWhile' :: (a -> Bool) -> [a] -> [a]
dropWhile' _ [] = []
dropWhile' f (a:as)
    |f a = []
    |otherwise = a: dropWhile' f as

--dropSpaces :: String -> String
--dropSpaces s = dropSpaces (\c -> c == ' ') s

--trim:: String -> String
--trim s = reverse(dropSpaces (reverse (dropSpaces s)))

--trim' :: String -> String
--trim' s = (reverse . dropSpaces . reverse . dropSpaces) s

monogram :: String -> String
monogram s = unwords(map (\w -> head w: ".") (words s))

monogram' :: String -> String
monogram' s = (unwords . map (\words -> head words : ".") . words) s

uniq :: Ord a => [a] -> [a]
uniq l = map head (group (sort l))

uniq' "" = ""
uniq' (x:xs)
    |elem x xs = uniq' xs
    |otherwise = x : uniq' xs

uniq'' "" = ""
uniq'' (x:xs) = x : uniq'' (filter (=/ x) xs)

--hf repeated hasonló a uniqhoz de egy szűrésre szükség lesz.
--zipwith' hasonló a ziphez, azonban nem párokat készit hanem egy kétparaméteres fuggvényt alkalmaz