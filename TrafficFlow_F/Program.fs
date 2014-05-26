namespace TrafficFlow
open Traffic 
open System   

module Program =

    [<EntryPoint>]
    let main argv = 
        
        let distance = 150        
        
        printf "0) time: %d\n" (int (time distance 30  [10; 10; 10]))
        printf "1) time: %d\n" (int (time distance 20  [10; 10; 10]))
        printf "2) time: %d\n" (int (time distance 20  [10; 20; 30]))
        printf "3) time: %d\n" (int (time distance 5  [10; 11; 12; 13; 14; 15]))
        printf "4) time: %d\n" (int (time distance 5  [60; 60; 60; 60; 60; 60; 60; 60; 60; 60]))
        printf "5) time: %d\n" (int (time distance 25  [55;29;26;12;19;39;18;20;23;28;56;20;59;48;33;40;30;60;19]))
        
        Console.ReadLine() |> ignore
                
        0 // return an integer exit code
