module ArrayFSharp
open System

let firstArray = [| for i in 1..10 -> i + 100 |]
let secondArray = [| 1;2;4;5;6;7 |]

// Алгоритм шифрования ROT13
let letEncrypt (letter:char) =
    if Char.IsLetter(letter) then
        let newLetter = 
            (int letter)
            |> (fun letterIdx -> letterIdx - (int 'A'))
            |> (fun letterIdx -> (letterIdx + 13)%26)
            |> (fun letterIdx -> letterIdx + (int 'A'))
            |> char
        newLetter
    else
        letter

let encryptText (text:char[]) = 
    for idx = 0 to text.Length-1 do
        text.[idx] <- letEncrypt text.[idx]

let text = Array.ofSeq "ASDF GHJK QWER ZXC"

printfn "Original: %s" <| new String(text)
encryptText text
printfn "Encrypt: %s" <| new String(text)
encryptText text
printfn "Decrypt: %s" <| new String(text)

//срезы в массивах
let daysOfWeek = Enum.GetNames( typeof<DayOfWeek> )
daysOfWeek.[2..4] |> Array.iter (printf " %s ")
printfn ""
daysOfWeek.[4..] |> Array.iter (printf " %s ")
printfn ""
daysOfWeek.[..3] |> Array.iter (printf " %s ")
printfn ""
daysOfWeek.[*] |> Array.iter (printf " %s ")
printfn ""


let division = 3.0
let twoPI = 2.0 * Math.PI;;

let ar = Array.init (int division) (fun i -> float i * twoPI / division)

ar |> Array.iter (printfn "%f")
