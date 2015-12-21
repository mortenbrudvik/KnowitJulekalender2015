let data = "FJKAUNOJDCUTCRHBYDLXKEODVBWTYPTSHASQQFCPRMLDXIJMYPVOHBDUGSMBLMVUMMZYHULSUIZIMZTICQORLNTOVKVAMQTKHVRIFMNTSLYGHEHFAHWWATLYAPEXTHEPKJUGDVWUDDPRQLUZMSZOJPSIKAIHLTONYXAULECXXKWFQOIKELWOHRVRUCXIAASKHMWTMAJEWGEESLWRTQKVHRRCDYXNTLDSUPXMQTQDFAQAPYBGXPOLOCLFQNGNKPKOBHZWHRXAWAWJKMTJSLDLNHMUGVVOPSAMRUJEYUOBPFNEHPZZCLPNZKWMTCXERPZRFKSXVEZTYCXFRHRGEITWHRRYPWSVAYBUHCERJXDCYAVICPTNBGIODLYLMEYLISEYNXNMCDPJJRCTLYNFMJZQNCLAGHUDVLYIGASGXSZYPZKLAWQUDVNTWGFFYFFSMQWUNUPZRJMTHACFELGHDZEJWFDWVPYOZEVEJKQWHQAHOCIYWGVLPSHFESCGEUCJGYLGDWPIWIDWZZXRUFXERABQJOXZALQOCSAYBRHXQQGUDADYSORTYZQPWGMBLNAQOFODSNXSZFURUNPMZGHTAJUJROIGMRKIZHSFUSKIZJJTLGOEEPBMIXISDHOAIFNFEKKSLEXSJLSGLCYYFEQBKIZZTQQXBQZAPXAAIFQEIXELQEZGFEPCKFPGXULLAHXTSRXDEMKFKABUTAABSLNQBNMXNEPODPGAORYJXCHCGKECLJVRBPRLHORREEIZOBSHDSCETTTNFTSMQPQIJBLKNZDMXOTRBNMTKHHCZQQMSLOAXJQKRHDGZVGITHYGVDXRTVBJEAHYBYRYKJAVXPOKHFFMEPHAGFOOPFNKQAUGYLVPWUJUPCUGGIXGRAMELUTEPYILBIUOCKKUUBJROQFTXMZRLXBAMHSDTEKRRIKZUFNLGTQAEUINMBPYTWXULQNIIRXHHGQDPENXAJNWXULFBNKBRINUMTRBFWBYVNKNKDFR"
    let sequence = "ABCDA"

let getSegment (seq':char[]) (data:string) =

    let rec getPositions (c:char[]) (d:string) =
        seq{
            if c.Length > 0 then
                 let p = d.IndexOf(c.[0])
                 if seq'.Length = c.Length then yield p
                 elif p = -1 then yield p
                 else yield p+1
                 if p <> -1 then
                    yield! getPositions (c.[1..]) (d.Substring((p+1)))
        }

    let positions = getPositions seq' data
    if (positions.Contains -1) = false then
        let startIndex = (positions |> Seq.head)
        data.Substring( startIndex, (positions |> Seq.sum)-startIndex+1 )
     else
        ""

let getSmallest (seq':char[]) (data:string) =

    let rec getSegments (c:char[]) (d:string) =
        seq{
            let p = d.IndexOf(c.[0])
            if p <> -1 then
                yield getSegment c d
                yield! getSegments c (d.Substring(p+1))
        }
    getSegments seq' data
    |> Seq.filter(fun x -> x.Length > 0)
    |> Seq.sortBy(fun x -> x.Length)
    |> Seq.head

printfn "%A" <| getSmallest (sequence.ToCharArray()) data
