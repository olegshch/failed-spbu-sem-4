module NUnitTestProject2

open NUnit.Framework 
open FS

[<Test>]
let "Enque and Dequeue" () =
    let tque = queue.BlockQueue<int>()
    tque.Enqueue(1)
    tque.Dequeue |> should equal(Some(1))
