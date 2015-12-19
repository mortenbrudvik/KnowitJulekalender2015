let treasureMap =   [|[|34;21;32;41;25|];
                      [|14;42;43;14;31|];
                      [|54;45;52;42;23|];
                      [|33;15;51;31;35|];
                      [|21;52;33;13;23|]|]

let rec treasureFinder (row,col) =
    seq{
        let currentPos = row*10+col
        let nextPos = treasureMap.[row-1].[col-1]

        yield currentPos

        if nextPos <> currentPos then yield! treasureFinder (nextPos/10, nextPos%10)
    }

treasureFinder (1, 1)
|> Seq.iter (fun x -> printf "%A," x)
