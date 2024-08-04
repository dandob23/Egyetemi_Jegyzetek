daysInMonth :: [Int]
daysInMonth = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31]
year :: [(Int, Int)]
year = [(month, day) | (month, days) <- zip [1..12] daysInMonth, day <- [1..days]]