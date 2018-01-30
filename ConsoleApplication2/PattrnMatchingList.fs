module PattrnMatchingList

let rec listLength l =
    match l with
    | [] -> 0   
    | [_] -> 1
    | [_; _] -> 2   
    | [_; _; _] -> 3   
    | hd :: tail -> 1 + listLength tail


printfn "%d" (listLength [1;2;3;4;5])

let asd = [1;2;3;4]
let hd = 5 :: [1;2;7]

let zxc = 1 :: 2 :: 3 :: []

List.iter (fun x -> printfn "%d" x) asd
List.iter (fun x -> printfn "%d" x) hd
List.iter (fun x -> printfn "%d" x) zxc


let describeOption o =    
    match o with    
    | Some(42) -> "The answer was 42, but what was the question?"  
    | Some(x)  -> sprintf "The answer was %d" x    
    | None     -> "No answer found."

printfn "%s" (describeOption None)
printfn "%s" (describeOption (Some 42))
printfn "%s" (describeOption (Some 15))
