open System

let reverse number =
    String(Array.rev( number.ToString().ToCharArray() ))
    |> Int32.Parse

[0..1000]
|> List.filter (fun n -> n%7 = 0 && (reverse n)%7 = 0 )
|> List.reduce (fun acc n -> acc + n)
|> printfn "%i"
