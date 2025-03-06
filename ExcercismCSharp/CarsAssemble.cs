using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcercismCSharp
{
    public static class AssemblyLine
    {
        //public static double Succe
        public static double SuccessRate(int speed)
        {
            if(speed == 0) return 0;

            if (speed >= 1 && speed <= 4) return 1;

            if (speed >= 5 && speed <= 8) return 0.9;

            if (speed == 9) return 0.8;

            if (speed >= 10) return 0.77;

            return 0;
        }
    }
}
