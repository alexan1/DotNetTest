using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficFlow
{
    class Traffic
    {        
        public Car CurrentCar { get; set; }
        public IList<Light> Lights { get; set; }
        public static double lengthBetweenLights { get; set; }

        public double GetTravelTime()
        {
            double currenttime = lengthBetweenLights / CurrentCar.Speed;            
            
            foreach (Light light in Lights)
            {               
                currenttime += lengthBetweenLights / CurrentCar.Speed + light.GetTimeToWait(currenttime);                
            }
            
            return currenttime;
        }
    }
}
