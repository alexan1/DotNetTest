using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficFlow
{
    public class Light
    {        
        public int Number { get; set; }

        public double SwitchTime { get; set; }

        public bool IsGreen(double time)
        {
            double num = Math.Floor(time / SwitchTime);
           
                return num % 2 == 0;            
        }
        public double GetTimeToWait(double time)
        {
            if (!IsGreen(time))
            {
                return ((time % SwitchTime) < 0.01) ? SwitchTime : (time % SwitchTime);
            }
            else
            {
                return 0;
            }
        }

    }
}
