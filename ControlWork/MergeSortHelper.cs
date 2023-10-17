using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork
{
    internal class MergeSortHelper
    {
        public static void MergeSortAlgorithm(double[] arr, int left, int right, ref int comparisonCount, ref int swapCount)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSortAlgorithm(arr, left, middle, ref comparisonCount, ref swapCount);
                MergeSortAlgorithm(arr, middle + 1, right, ref comparisonCount, ref swapCount);

                Merge(arr, left, middle, right, ref comparisonCount, ref swapCount);
            }
        }

        private static void Merge(double[] arr, int left, int middle, int right, ref int comparisonCount, ref int swapCount)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            double[] leftArray = new double[n1];
            double[] rightArray = new double[n2];

            for (int i = 0; i < n1; ++i)
                leftArray[i] = arr[left + i];

            for (int j = 0; j < n2; ++j)
                rightArray[j] = arr[middle + 1 + j];

            int k = left;
            int m = 0;
            int n = 0;

            while (m < n1 && n < n2)
            {
                comparisonCount++; // Увеличиваем счетчик сравнений

                if (leftArray[m] <= rightArray[n])
                {
                    arr[k] = leftArray[m];
                    m++;
                }
                else
                {
                    arr[k] = rightArray[n];
                    n++;
                }
                k++;
                swapCount++; // Увеличиваем счетчик перестановок
            }

            while (m < n1)
            {
                arr[k] = leftArray[m];
                m++;
                k++;
                swapCount++; // Увеличиваем счетчик перестановок
            }

            while (n < n2)
            {
                arr[k] = rightArray[n];
                n++;
                k++;
                swapCount++; // Увеличиваем счетчик перестановок
            }
        }
    }
}
