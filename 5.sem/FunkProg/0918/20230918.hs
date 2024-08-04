module Types where

inc :: Int -> Int
inc a = a + 1
--divide' :: a -> (a -> (a))
divide' x y = x / y
--inc = ~ # + 1

add :: Int -> Int -> Int
add a b = a + b

v1 :: Int
v1 = 10
--alapból Integer (több memóriát használ))

inc2 :: Int -> Int
inc2 a = inc (inc a)

inc' :: Int -> Int
inc' a = (+) a 1

--inc'' a = 

sho0, sho1 :: Int
sho0 = maxBound
sho1 = minBound

big :: Integer
big = 2*(2*(2*2))

{- shw :: n -> n
shw n = n -}

--Option ü = `

exi1 = True && False
exi2 = not (False || True)
exi3 = ('a' == 'a')
exi4 = (16 /= 3)
exi5 = (5 > 3) && ('p' <= 'q')

sumt :: Integer -> Integer
--sumt u = u
sumt n = n + sumt (n -1)

iseven' :: Int => Bool
iseven' r = r `mod` 2

isodd' :: Int => Bool
isodd' r = not (r `mod` 2)

--HF: Háromszög szerkeszthetősége, Pitagorasz, szökőév-e egy év
