    let reverse number =
        String(Array.rev( number.ToString().ToCharArray() ))
        |> Int32.Parse

    let flip ciffer =
        match ciffer with 
        | '6' -> '9'
        | '9' -> '6'
        | '0'|'1'|'8' -> ciffer
        | _ -> 'x'

    let rotate180 number : string =
        reverse number |> string |> Seq.toArray        
        |> Array.map (fun x -> flip x)
        |> (fun x -> new System.String(x)) 

    [0..100000] 
    |> Seq.filter (fun n -> n.ToString() = (rotate180 n) )
    |> Seq.length
    |> printfn "%A"