(*
open System

let last x = x % 10

[<EntryPoint>]
let main args =
    printf "сколько чисел вводим? "
    let n = int (Console.ReadLine())

    let a =
        [ for i in 1 .. n do
            printf "Введите число %d: " i
            let num = int (Console.ReadLine())
            yield num ]

    let res = List.map last a

    printfn "результат: %A" res
    0
    
    *)

open System

let last x = x % 10

// сумма ласт чисел
let sumlast d acc x =
    if last x = d then acc + x
    else acc

[<EntryPoint>]
let main args =
    printf "Сколько чисел вы хотите ввести? "
    let n = int (Console.ReadLine())

    let a =
        [ for i in 1 .. n do
            printf "Введите число %d: " i
            let num = int (Console.ReadLine())
            yield num ]

    printf "Введите цифру для поиска: "
    let d = int(Console.ReadLine())

    let res = List.fold (sumlast d) 0 a

    printfn "Сумма чисел с последней цифрой %d = %d" d res
    0