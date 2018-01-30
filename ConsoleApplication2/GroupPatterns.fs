module GroupPatterns

let describeNumbers x y =
    match x, y with
    | 1,_
    | _,1
        -> "One of the numbers is one"
    | 2,2
        -> "Both of the numbers is two"
    | (3,_) & (_,4)
        -> "First number is three. Second - four"
    | _,_
        -> "Other"

printfn "%s" (describeNumbers 3 4)
printfn "%s" (describeNumbers 1 2)
printfn "%s" (describeNumbers 2 2)
printfn "%s" (describeNumbers 3 2)