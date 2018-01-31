module MutableValues
open System

//first test mutable
let mutable message = "World"

printfn "Hello, %s" message

message <- "Zhenia"

printfn "Hello, %s" message

//using 'ref'
let planets =
    ref [
        "Mercury"; "Venus"; "Earth";
        "Mars"; "Jupiter"; "Saturn";
        "Uranus"; "Neptune"; "Pluto"
        ];;
        
!planets |> List.iter (printf "%s,");;

planets := !planets |> List.filter (fun p -> p <> "Pluto");;
printfn ""
!planets |> List.iter (printf "%s,");;
printfn ""

// Mutable Record
type MutableCar = { Make:string; Model:string; mutable Miles:int }

let driveForASeason car = 
    let rand = new Random()
    car.Miles <- car.Miles + (rand.Next() % 10000)

let myCar = { Make = "Italy"; Model = "Lancia"; Miles = 0 }

driveForASeason myCar
driveForASeason myCar
driveForASeason myCar
driveForASeason myCar

printfn "%s %s %d" myCar.Make myCar.Model myCar.Miles

