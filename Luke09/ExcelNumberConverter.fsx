
let toChar n =
    65L + n |> char |> string

let rec getColumnTitle n =
    let c = (n-1L)%26L
    let d = (n-c)/26L

    if d > 0L then getColumnTitle d + toChar c else toChar c

printfn "%A" (getColumnTitle 142453146368L)
