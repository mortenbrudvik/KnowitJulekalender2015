module Utils

open System.Net
open System

let splitLines (s:string) = 
    List.ofSeq(s.Split([|Environment.NewLine|], StringSplitOptions.None) )

let downloadTextLines (url:string) =        
    let client = new WebClient()
    client.DownloadString(url) |> splitLines

