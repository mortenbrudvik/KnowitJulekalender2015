
#load "libs/Utils.fsx"
#load "libs/RomanNumerals.fsx"

open Utils
open RomanNumerals

open System
open System.IO
open System.Linq

let lines = downloadTextLines "http://pastebin.com/raw.php?i=p1eVAM5H"

let (|ParseInt|_|) x =
    let success, result = Int32.TryParse( x)
    if success then Some( result)
    else None

let (|ParseBin|_|) (x:string) =
    if x.StartsWith("0b") then Some(Convert.ToInt32(x.Substring(2),2))
    else None

let (|ParseRoman|_|) (x:string) =
    let romanValue = toRomanNumeral x
    if ( isValid romanValue) then Some(toInt romanValue)
    else None

let getNumber str =
    match str with
    | ParseInt i -> i
    | ParseBin i -> i
    | ParseRoman i -> i
    | _ -> 0

let getMedian numbers =
    numbers
    |> Seq.sortBy(fun x -> getNumber x)
    |> Seq.map(fun x -> String.Format("{0} {1}",x, getNumber x))
    |> (fun x -> Seq.nth ((Seq.length x)/2) x)

printfn "%A" (getMedian lines)
