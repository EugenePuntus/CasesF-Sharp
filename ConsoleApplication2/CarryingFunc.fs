module CarryingFunc

open System.IO;

let appendFile (fileName:string) (text:string) =
    use file = new StreamWriter(fileName, true)
    file.WriteLine(text)
    file.Close()

appendFile @"E:\log.txt" "My test write..."


let currriedAppendFile = appendFile @"E:\log.txt"

currriedAppendFile "My test write 2..."