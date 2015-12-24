    let data = "evdhtiqgfyvcytohqppcmdbultbnzevdbakvkcdpbatbtjlmzaolfqfqjifkoanqcznmbqbeswglgrzfroswgxoritbw"

    let countOperations (data:string) =
        Seq.zip (data.Take(data.Length/2)) (data.Skip(data.Length/2).Reverse())
        |> Seq.map( fun(c1, c2) -> Math.Abs((int c1)-(int c2)))
        |> Seq.sum

    printfn "%A" (countOperations data)
     
