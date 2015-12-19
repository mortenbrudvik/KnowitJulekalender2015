
let countDigit k n =

    let mutable n' = n
    let mutable power = 1L
    let mutable counter = 0L
    let mutable i = 0L

    while n' > 0L do
        let d = n'%10L
        n' <- n'/10L

        counter <- counter + (d*(power*i)/10L)

        if d > k then
            counter <- counter + power;
        elif d = k then
            counter <- counter +  n%power + 1L

        power <- power * 10L

        i <- i + 1L

    counter

printfn "%A" <| countDigit 2L 12345678987654321L
