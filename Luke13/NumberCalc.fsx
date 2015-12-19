let createBangNumbers amount =
    let rec loop candidates =
        seq {
            let h = candidates |> Set.minElement
            yield h
            yield! candidates 
                |> Set.remove h 
                |> Set.add (h*2L) |> Set.add (h*3L) |> Set.add (h*5L) 
                |> loop
            }

    Set.empty<int64> |> Set.add 1L |> loop 
    |> Seq.truncate amount

createBangNumbers 10000
|> Seq.iter(fun x -> printfn "%A" x)
