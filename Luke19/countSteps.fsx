let rec count = function
    | n when n = 0 -> 1
    | n when n < 0 -> 0
    | n -> (count (n - 1)) + (count (n - 2)) + (count (n - 3)) 

printfn "%A" <| count 30
