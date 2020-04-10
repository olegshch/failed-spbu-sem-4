open System

[<EntryPoint>]
let main argv =
    let number = 
        Console.WriteLine("Enter the number for filling example list 1,5,6,3,number")
        Int32.Parse<<Console.ReadLine
    let list = [1;5;6;3;number()]
    let find = List.head(List.sort(list))
    printfn "%d" find 
    //System.Console.ReadKey() |> ignore
    0 // return an integer exit code
