module LazyEvaluation

open System.IO

let x = Lazy<int>.Create(fun () -> printfn "Evaluating x..."; 10) 
let y = lazy (printfn "Evaluating y..."; x.Value + x.Value);;
printfn "%d" y.Value
printfn "%d" y.Value


let seqOfNumbers = seq { 1 .. 5 }
seqOfNumbers |> Seq.iter (printfn "%d");; 

//let allIntsSeq = seq { for i = 0 to System.Int32.MaxValue do yield i }
//allIntsSeq |> Seq.iter (printfn "%d");;
//let allIntsList = [ for i = 0 to System.Int32.MaxValue do yield i ]

let alphabet = seq { for c in 'A' .. 'Z' -> c };

let rec allFilesUnder basePath =    
    seq {
        // Добавить все файлы из основной папки
        yield! Directory.GetFiles(basePath)        
        
        // Добавить все файлы из подпапок        
        for subdir in Directory.GetDirectories(basePath) do            
            yield! allFilesUnder subdir    
    }
