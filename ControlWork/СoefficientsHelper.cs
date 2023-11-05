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

        public static double CoefficientCorelation(long n, int[] array_y, long sum_x, double sum_y, long sum_x_2, long sum_xy)
        {
            double sum_y_2 = 0;
            for (int i = 0; i < n; i++)
            {
                sum_y_2 += Math.Pow(array_y[i], 2);
            }

            double coeff_corel = (n * sum_xy - sum_x * sum_y) /
                Math.Sqrt((n * sum_x_2 - sum_x * sum_x) * (n * sum_y_2 - sum_y * sum_y));

            return coeff_corel;
        }

        public static double BetaCoefficient(double a1, long n, long sum_x, double sum_y, int[] array_x, int[] array_y)
        {
            double sum_Xi = 0;
            double sum_Yi = 0;

            double medium_value_x = sum_x / n;
            double medium_value_y = sum_y / n;

            for (int i = 0; i < n; i++)
            {
                sum_Xi += Math.Pow(array_x[i] - medium_value_x, 2);
                sum_Yi += Math.Pow(array_y[i] - medium_value_y, 2);
            }

            double S_x = Math.Sqrt(sum_Xi / n);
            double S_y = Math.Sqrt(sum_Yi / n);

            double beta_coeff = (a1 * S_x) / S_y;

            return beta_coeff;
        }
    }
}
