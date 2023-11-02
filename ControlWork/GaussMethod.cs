using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork
{
    internal class GaussMethod
    {
        public static double[] SolveGauss(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            double[] solution = new double[n];

            // Прямой ход метода Гаусса
            for (int k = 0; k < n - 1; k++)
            {
                for (int i = k + 1; i < n; i++)
                {
                    double factor = matrix[i, k] / matrix[k, k];
                    for (int j = k; j < n + 1; j++)
                    {
                        matrix[i, j] -= factor * matrix[k, j];
                    }
                }
            }

            // Обратный ход метода Гаусса
            for (int i = n - 1; i >= 0; i--)
            {
                double sum = 0;
                for (int j = i + 1; j < n; j++)
                {
                    sum += matrix[i, j] * solution[j];
                }
                solution[i] = ((matrix[i, n] - sum) / matrix[i, i]);
            }

            return solution;
        }
    }
}
