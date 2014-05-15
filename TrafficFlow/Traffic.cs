using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficFlow
{
    class Traffic
    {
        public Car mycar;
        public IList<Light> LightList;
        public static double lengthbetweenLights { get; set; }

        public double getTravelTime()
        {
            double currenttime = lengthbetweenLights / mycar.Speed;            
            
            foreach (Light light in LightList)
            {               
                currenttime += lengthbetweenLights / mycar.Speed + light.TimeToWait(currenttime);                
            }
            
            return currenttime;
        }
    }
}
