namespace SalexTaxes    

    type ProductType = 
        |food = 1
        |book = 2
        |medical = 3
        |other = 4

    type Product =
        {Name : string;
        Type : ProductType;        
        Price : decimal;        
        IsImport: bool;
        IsExempt : bool}

    type ShoppingCart =
        {item : Product;
        Quantity: int;
        Taxes: decimal}

    type Recit = seq<ShoppingCart>
    
    module SalexTaxes =
        let PrintRecit recit = 
            Seq.iter (fun x -> printf "%s\r" x.Name) recit

        let prod1 = {Name = "book"; Type = ProductType.book; Price = 12.49m; IsImport = false; IsExempt = true} 
        let prod2 = {Name = "music CD"; Type = ProductType.other; Price = 14.99m; IsImport = false; IsExempt = false} 
        let prod3 = {Name = "chocolate bar"; Type = ProductType.food; Price = 0.85m; IsImport = false; IsExempt = true} 

        let prodSeq =  [prod1; prod2; prod3]

        PrintRecit prodSeq