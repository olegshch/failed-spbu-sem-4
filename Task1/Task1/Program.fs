// Learn more about F# at http://fsharp.org

open System

//let rec printfunc number turn:int =
//    printf(number)
//    if (turn > 0) then printfunc number turn-1
let rec printfunc (number:int) turn:int =
    Console.Write("{0} ", number)
    if turn > 0 
        then printfunc number (turn - 1) 
        else 0

let rec func number:int = 
    printfunc number number
    func (number + 1)

[<EntryPoint>]
let main argv =
    func 1
    0 // return an integer exit code
