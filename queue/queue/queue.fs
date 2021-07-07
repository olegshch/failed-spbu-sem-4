
namespace queue
open System


type 'a BlockQueue()=
    let mutable elements = []
    let mutable count = 0
    let mutable locker = Object()

    member this.Enqueue(value: 'a)=
        lock locker (fun() -> 
        let list = [value]
        elements <- elements @ list
        count <- count+1)

    member this.Dequeue=
        lock locker (fun()->
        match elements with
        | [] -> None
        | h::t ->
            count <- count - 1
            elements <- t
            Some(h))    
