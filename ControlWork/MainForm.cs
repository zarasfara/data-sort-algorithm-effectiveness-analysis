using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlWork
{
    public partial class MainForm : Form
    {
        public const int RAND_MAX = 32768;

        public MainForm()
        {
            InitializeComponent();
        }

        public static void MergeSortAlgorithm(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSortAlgorithm(arr, left, middle);
                MergeSortAlgorithm(arr, middle + 1, right);

                Merge(arr, left, middle, right);
            }
        }

        public static void Merge(int[] arr, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            Array.Copy(arr, left, leftArray, 0, n1);
            Array.Copy(arr, middle + 1, rightArray, 0, n2);

            int i = 0, j = 0;
            int k = left;

            while (i < n1 && j < n2)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = rightArray[j];
                j++;
                k++;
            }
        }

        public static double GetExponential(int A, int B)
        {
            Random random = new Random();
            double rundomNumber = random.NextDouble();

            double u = rundomNumber / RAND_MAX;

            double f = A - B * Math.Log(1 - u);

            return f;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void n_input_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(n_input.Text, out int number))
            {
                // Если введенное значение не является числом, очищаем поле ввода
                n_input.Text = "";
            }
            else if (number < 5000 || number > 9000)
            {
                // Если число находится вне диапазона от 5000 до 9000, очищаем поле ввода
                n_input.Text = "";
            }

        }

        private void n_input_MouseHover(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(n_input, "Введите число от 5000 до 9000");
        }
    }
}
