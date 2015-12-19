[0L..7L..100000000L]
|> List.filter (fun n -> (n%5L<>0L)   )
|> List.sum
