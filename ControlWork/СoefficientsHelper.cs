using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork
{
    internal class СoefficientsHelper
    {
        public static double CoefficientElasticity(double a1, double averageX, double averageY)
        {
            return (a1 * averageX) / averageY;
        }
    }
}
