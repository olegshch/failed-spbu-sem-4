module Task3Test

open NUnit.Framework
open Task3
open FsUnit

[<Test>]
let ``One element`` () =
    let queue = PriorityQueue()
    queue.Enqueue 0 0
    queue.Dequeue |> should equal 0 

[<Test>]
let ``Several elements`` () =
    let queue = PriorityQueue()
    queue.Enqueue 0 0
    queue.Enqueue -3 10
    queue.Dequeue |> should equal -3 
