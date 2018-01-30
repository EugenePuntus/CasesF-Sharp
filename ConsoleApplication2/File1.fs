module File1

open HightLowGame
open ConvertToCharList
open System

//[<EntryPoint>]
let main (args : string[]) = 
    let numbers = [1..10]
    let square x = x* x

    let squareNumbers = List.map square numbers

    printfn "SquaredNumbers = %A" squareNumbers
    
    FindRoot 1.0 3.0 -4.0

    printfn "(press any key to cntinue)"
    Console.ReadKey(true) |> ignore
    
    hightLowGame()

    0