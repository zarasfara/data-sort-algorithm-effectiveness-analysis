using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlWork
{
    public partial class CalcForm : Form
    {

        private static readonly Random random = new Random();
        public CalcForm()
        {
            InitializeComponent();
        }

        private double generateRandomNumber()
        {
            return Math.Round(random.NextDouble() * (1.00 - 0.01) + 0.01, 2);
        }

        public static double GetExponential(double A, double B)
        {
            double rundomNumber = random.NextDouble();

            double u = rundomNumber / MainForm.RAND_MAX;

            double result = A - B * Math.Log(1 - u);

            return result;
        }

        private double[] GenerateArray(double a, double b, int n)
        {
            double[] array = new double[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = GetExponential(a, b);
            }

            return array;
        }

        private void start_calculation_button_Click(object sender, EventArgs e)
        {
            list_calculations.Items.Clear();

            int numberArrays; // Количество массивов
            int.TryParse(sample_size_input.Text, out numberArrays);

            // Это наверное нужно перенести в цикл, но пока и так сойдёт.
            double A = generateRandomNumber();
            double B = generateRandomNumber();

            List<ListViewItem> listItems = new List<ListViewItem>();

            for (int i = 0;i < numberArrays; i++)
            {
                // Random random = new Random();
                int numberArguments = random.Next(9000, 50001); // Количество элементов в каждом массиве

                double[] arr = new double[numberArguments];

                arr = GenerateArray(A, B, numberArguments);

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                MergeSortHelper.MergeSortAlgorithm(arr, 0, arr.Length - 1);

                stopwatch.Stop();

                double elapsedTime = stopwatch.Elapsed.TotalMilliseconds;

                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(elapsedTime.ToString());
                item.SubItems.Add(arr.Length.ToString());
                item.SubItems.Add(((long)arr.Length * arr.Length).ToString());
                item.SubItems.Add((arr.Length * elapsedTime).ToString());

                listItems.Add(item);
            }

            list_calculations.Items.AddRange(listItems.ToArray());
        }
    }
}
