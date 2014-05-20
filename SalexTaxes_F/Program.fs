namespace SalexTaxes
open System
open Product
open SalexTaxes

module Program = 

    [<EntryPoint>]
    let main (argv :string[]) = 
    
        let prod1 = {Name = "book"; Type = ProductType.book; Price = 12.49m; IsImport = false; IsExempt = true} 
        let item1 = {Item = prod1; Quantity = 1}
        let prod2 = {Name = "music CD"; Type = ProductType.other; Price = 14.99m; IsImport = false; IsExempt = false} 
        let item2 = {Item = prod2; Quantity = 1}
        let prod3 = {Name = "chocolate bar"; Type = ProductType.food; Price = 0.85m; IsImport = false; IsExempt = true} 
        let item3 = {Item = prod3; Quantity = 1}

        let order =  [item1; item2; item3]

        Order.PrintRecit order

        Console.ReadLine() |> ignore
   
        0

