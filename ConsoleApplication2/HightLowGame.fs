module HightLowGame

open System;

let hightLowGame () =
    let rnd = new Random()
    let secretNumber = rnd.Next() % 100

    let rec hightLowGameTryIt () =
        printfn "Guess the secret number:"
        let youVariant = Console.ReadLine()
        let youNumber = Int32.Parse(youVariant)

        match youNumber with
        | _ when youNumber > secretNumber
            -> printfn "The secret number is lower";
               hightLowGameTryIt()
        | _ when youNumber = secretNumber
            -> printfn "You is right"
               ()
        | _ when youNumber < secretNumber
            -> printfn "The secret number is higher"
               hightLowGameTryIt()
        
    hightLowGameTryIt()

                

    



