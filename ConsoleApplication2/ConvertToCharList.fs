module ConvertToCharList

open System

let ConvertToChar x =
    let toString x = x.ToString()
    let toInt number = Int32.Parse(number.ToString())
    let listChar = toString(x)
    let numbersChar = List.ofSeq listChar

    //if List.length numbersChar <> 3 then
    //    failwith "Error: number count != 3"

    List.map toInt numbersChar

let Sum x y = x + y

let numberOf3 = List.reduce Sum (ConvertToChar 910)
printfn "%d" numberOf3

let FirstLast x = [List.head x ; List.head (List.rev x)];;

let numberOfFrsLast = List.reduce Sum (FirstLast (ConvertToChar 1119))
printfn "%d" numberOfFrsLast

///a*x^2+b*x+c
let FindRoot (a:float) (b:float) (c:float) =
    if a = 0.0 then
        failwith("Error: a = 0")
    let discr = b * b - 4.0 * a * c
    
    if discr < 0.0 then
        failwith("Error: discr < 0")

    let root1 = (-b + sqrt(discr)) / 2.0 * a
    let root2 = (-b - sqrt(discr)) / 2.0 * a

    printfn "%A %A" root1 root2
