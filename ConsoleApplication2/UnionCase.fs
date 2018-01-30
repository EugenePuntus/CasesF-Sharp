module UnionCase

type Suit =    
    | Heart    
    | Diamond    
    | Spade    
    | Club

type PlayingCard =    
    | Ace   of Suit    
    | King  of Suit    
    | Queen of Suit    
    | Jack  of Suit    
    | ValueCard of int * Suit

let deckOfCards =    
    [        
        for suit in [ Spade; Club; Heart; Diamond ] do            
            yield Ace(suit)            
            yield King(suit)            
            yield Queen(suit)            
            yield Jack(suit)            
            for value in 2 .. 10 do                
                yield ValueCard(value, suit)    
    ]

List.iter (fun x -> printfn "%A" x) deckOfCards

let descriptionPokerCards = 
    function
    | [] | [_] -> "Too few card"
    | useCards when List.length useCards > 2 -> "Too many cards"
    | [t1; t2] when t1 = t2 -> "Cardsharper"
    | [Ace(_); Ace(_)] -> "Pocket Rockets"
    | [King(_); King(_)] -> "Cowboys"
    | [ValueCard(2,_); ValueCard(2,_)] -> "Ducks"
    | [Queen(_); Queen(_)] | [Jack(_); Jack(_)] -> "Pair of face card"
    | [ValueCard(x,_); ValueCard(y,_)] when x = y -> "A Pair"    
    | [first; second] -> sprintf "Two cards: %A and %A" first second

printfn "%s" (descriptionPokerCards [Ace(Diamond);Ace(Spade);Ace(Spade)])
printfn "%s" (descriptionPokerCards [Ace(Spade);Ace(Spade)])
printfn "%s" (descriptionPokerCards [Ace(Diamond);Ace(Spade)])
printfn "%s" (descriptionPokerCards [King(Diamond);King(Spade)])
printfn "%s" (descriptionPokerCards [Queen(Diamond);Jack(Heart)])
printfn "%s" (descriptionPokerCards [ValueCard(2,Diamond);ValueCard(2,Heart)])
printfn "%s" (descriptionPokerCards [Queen(Diamond);Queen(Heart)])
printfn "%s" (descriptionPokerCards [ValueCard(10,Diamond);ValueCard(10,Heart)])
