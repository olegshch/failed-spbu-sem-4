namespace SimpleFunctions

module Functions =

    //gets n!
    let Factorial n =
        let rec fact s a b =
            if a = b then s 
            else fact (s * (a + 1)) (a + 1) b
        fact 1 1 n 
    
    //gets n-th Fibonacci number
    let Fibonacci n =
        let rec fib a b i n =
            if i = n then a
            else fib b (a + b) (i + 1) n
        fib 1 1 1 n
    
    //reverses list
    let ReverseList llist =
        let rec rev oldlist newlist = 
            match oldlist with
            | [] -> newlist
            | head::tail -> rev tail (head::newlist)
        rev llist []

    //makes list of powers of 2
    let PowerTwo n m =
        let rec power n m list = 
            let makingpower n =
                let rec pow a b = 
                    if b = 0 then a
                    else pow (a * 2) (b - 1)
                pow 1 n
            if n = m then list
            else power (n+1) m (list @ [makingpower n])
        power n (n+m+1) []

    //gets first position of element otherwise -1
    let Find list n =
        let rec findd list i =
            match list with
            | [] -> -1
            | head::tail when head = n -> i
            | _ -> findd list.Tail (i + 1)
        findd list 0