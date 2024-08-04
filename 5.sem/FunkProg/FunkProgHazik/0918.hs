-- Háromszög szerkeszthetősége
-- Pitagorasz
-- szökőév-e egy év

isTriangle :: Int -> Int -> Int -> Bool
isTriangle a b c = a + b > c && a + c > b && b + c > a

isPitagoryan :: Int -> Int -> Int -> Bool
isPitagoryan a b c = a^2 + b^2 == c^2

isLeapYear :: Int -> Bool
isLeapYear y
    | (y `mod` 4 == 0) && (y `mod` 100 /= 0) || (y `mod` 400 == 0) = True
    | otherwise = False