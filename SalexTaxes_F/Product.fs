namespace SalexTaxes

module Product = 

    type ProductType = 
        |Food
        |Book
        |Medical
        |Other

    type Product =
        {Name : string;
        Type : ProductType;        
        Price : decimal;        
        IsImport: bool}
            
    let tax rate price = price * rate
    let basicTax = tax 0.1m
    let importDuty = tax 0.05m 

    type ShoppingCartItem =
        {Item : Product;
        Quantity: int}
        member x.BasicTaxes = 
            match x.Item.Type with
                | Food | Book | Medical -> 0M
                | _ -> basicTax x.Item.Price
        member x.importDuty =
            if x.Item.IsImport
            then importDuty(x.Item.Price + x.BasicTaxes)
            else 0M

                    
    module Order =
            
        let price (order : List<ShoppingCartItem>)  = 
            order |> List.sumBy (fun x -> x.Item.Price * (decimal)x.Quantity) 

        let taxes (order : List<ShoppingCartItem>)  = 
            order |> List.sumBy (fun x -> (x.BasicTaxes + x.importDuty) * (decimal)x.Quantity) 

        let Printorder order =             
            order |> List.iter (fun x -> printf "%s: %M\n" x.Item.Name (System.Math.Round((x.Item.Price + x.BasicTaxes + x.importDuty),2)))
            let totaltax = System.Math.Round((taxes order),2)
            let total1 = (price order) + (taxes order)
            let total = System.Math.Round(total1,2)
            printf "Total Taxes %M\n"  totaltax
            printf "Total %M\n"  total
            

                
            

