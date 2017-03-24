using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterThesis
{
    static class Calculate
    {
        public static double CalculatePolynom(List<double> list, double x)
        {
            double result = list[0] + list[1] * x + list[2] * Math.Pow(x, 2) + list[3] * Math.Pow(x, 3) + list[4] * Math.Pow(x, 4);

            return result;
        }

    }
}
