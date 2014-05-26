namespace TrafficFlow

module Traffic = 

    let isGreen currentTime switchItme =
        let state = int currentTime / int switchItme
        state % 2 = 0

    let waitTime (currentTime : float) switchTime =  
        match (isGreen currentTime switchTime) with
            | false -> if (currentTime % switchTime) < 0.01 then switchTime else currentTime % switchTime
            | _ -> 0.0

            
    let time distanceBetween speed  (lights : seq<int>) =
        let timeBetween = float distanceBetween / float speed
        (lights |> Seq.fold (fun acc x -> float acc + timeBetween + waitTime acc (float x) ) timeBetween)

       



