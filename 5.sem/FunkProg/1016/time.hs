import Data.Char (toUpper)
time :: [(Int, Int)]
time = [(h, m) | h <- [0..23], m <- [0..59]]