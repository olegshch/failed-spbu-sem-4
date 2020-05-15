namespace Task3

open System
    type 'a PriorityQueue()=
        let mutable elements = []

        //Add element wirh its priority
        member this.Enqueue value priority =
            let list = [(value, priority)]
            let rec add head tail =
                match tail with
                |[] -> list
                |(curval, prior)::t ->
                    if priority > prior then 
                        head @ list @ tail
                    else
                        add (head @ list) tail
            elements <- add [] elements 

        //Get the highest priority element
        member this.Dequeue =
            match elements with
            | [] -> raise (InvalidOperationException("queue is empty"))
            | h::t ->
                elements <- t
                fst h    