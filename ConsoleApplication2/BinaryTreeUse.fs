module BinaryTreeUse

type BinaryTree =
    | Node of int * BinaryTree * BinaryTree
    | Empty

let rec PrintTree =
    function
    | Node (data, left, right)
        -> PrintTree left
           printfn "Node is %d" data
           PrintTree right
    | Empty -> ()

let myTree =
    Node(2,
         Node(1, 
              Empty,
              Node(7, Empty, Empty)
         ),
         Node(4,
              Node(3, Empty,Empty),
              Node(5, 
                   Empty,
                   Node(8, Empty, Empty)
              )
         )
    )

PrintTree(myTree)