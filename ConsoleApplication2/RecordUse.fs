module RecordUse

type Car =  { Make : string; Model : string; Year : int }
let thisYear's = { Make = "FSharp"; Model = "Luxury Sedan"; Year = 2010 } 
let nextYear's = { thisYear's with Year = 2011 } 
let thisYear2's = thisYear's 