using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car
            {
                Speed = 20
            };
            List<Light> lights1 = getLightList();

            var mytraffic = new Traffic
            {
                CurrentCar = car1,
                Lights = lights1

            };

            Traffic.lengthBetweenLights = 150; 

            var traveltime = mytraffic.GetTravelTime();

            Console.WriteLine(string.Format("Time for car: {0}", traveltime));
            Console.ReadLine();  
        }

        private static List<Light> getLightList()
        {
            List<Light> lstProducts = new List<Light>();
            //input 1
            lstProducts.Add(new Light { Number = 0, SwitchTime = 10 });
            lstProducts.Add(new Light { Number = 1, SwitchTime = 20 });
            lstProducts.Add(new Light { Number = 2, SwitchTime = 30 });
            return lstProducts;
        }        
    }
}
