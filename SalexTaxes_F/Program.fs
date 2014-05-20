namespace SalexTaxes
open System
open Product
open SalexTaxes

module Program = 

    [<EntryPoint>]
    let main (argv :string[]) = 
    
        let order1 =  [
            {Item = {Name = "book"; Type = Book; Price = 12.49m; IsImport = false}; Quantity = 1};
            {Item = {Name = "music CD"; Type = Other; Price = 14.99m; IsImport = false}; Quantity = 1};
            {Item = {Name = "chocolate bar"; Type = Food; Price = 0.85m; IsImport = false}; Quantity = 1}
            ]

        Order.Printorder order1
        printf "\n"      

        let order2 =  [
            {Item = {Name = "imported box of chocolates"; Type = Food; Price = 10.00m; IsImport = true}; Quantity = 1};
            {Item = {Name = "imported bottle of perfume"; Type = Other; Price = 47.50m; IsImport = true}; Quantity = 1};            
            ]

        Order.Printorder order2 
        printf "\n"          

        let order3 =  [
            {Item = {Name = "imported bottle of perfume"; Type = Other; Price = 27.99m; IsImport = true}; Quantity = 1};
            {Item = {Name = "bottle of perfume"; Type = Other; Price = 18.99m; IsImport = false}; Quantity = 1};
            {Item = {Name = "packet of headache pills"; Type = Medical; Price = 9.75m; IsImport = false}; Quantity = 1};
            {Item = {Name = "box of imported chocolates"; Type = Food; Price = 11.25m; IsImport = true}; Quantity = 1}
            ]

        Order.Printorder order3
        Console.ReadLine() |> ignore
   
        0

