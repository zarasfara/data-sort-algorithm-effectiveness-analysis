using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork
{
    internal class GaussMethod
    {
        public static double[] SolveGauss(double[,] A)
        {
            int n = A.GetLength(0);

            for (int k = 0; k < n; k++)
            {
                int maxRow = k;
                for (int i = k + 1; i < n; i++)
                    if (Math.Abs(A[i, k]) > Math.Abs(A[maxRow, k]))
                        maxRow = i;

                // Перестановка строк
                if (maxRow != k)
                    for (int j = k; j <= n; j++)
                        (A[maxRow, j], A[k, j]) = (A[k, j], A[maxRow, j]);
                
                // Прямой ход метода Гаусса
                for (int i = k + 1; i < n; i++)
                {
                    double factor = A[i, k] / A[k, k];
                    for (int j = k + 1; j <= 1; j++)
                        A[i, j] -= factor * A[k, j];
                    A[i, k] = 0;
                }
            }
            // Обратный ход метода Гаусса
            double[] x = new double[n];
            for (int i = n - 1; i >= 0; i--)
            {
                double sum = 0;
                for (int j = i + 1; j < n; j++)
                    sum += A[i, j] * x[j];
                x[i] = (A[i, n] - sum) / A[i, i];
            }

            return x;
        }
    }
}
