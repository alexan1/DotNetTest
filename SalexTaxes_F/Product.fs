namespace SalexTaxes

module Product = 

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
    
    //type Taxes = Product.Price
    let Tax rate price = (price : decimal) * rate
    let BasicTax = Tax 0.1m
    let ImportDuty = Tax 0.05m 

    type ShoppingCartItem =
        {Item : Product;
        Quantity: int}
        member x.Taxes = 
            match x.Item.Type with
                | ProductType.food | ProductType.book | ProductType.medical -> BasicTax(x.Item.Price)
                | _ -> 0.0m

        //With Taxes = Product.Price

    
    
    module Order =
                 
        let PrintRecit recit = 
            recit |> List.iter (fun x -> printf "%s" x.Item.Name)
            recit |> List.iter (fun x -> printf "%M" x.Item.Price)

