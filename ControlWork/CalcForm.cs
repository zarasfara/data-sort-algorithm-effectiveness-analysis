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

            // Заполнение списка - начало
            list_calculations.Items.Clear();

            if (!int.TryParse(sample_size_input.Text, out int numberArrays) || numberArrays <= 0)
            {
                // Вывод модального окна с сообщением об ошибке
                MessageBox.Show("Некорректный ввод количества массивов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double A = generateRandomNumber();
            double B = generateRandomNumber();

            List<ListViewItem> listItems = new List<ListViewItem>();

            Random random = new Random();

            for (int i = 0; i < numberArrays; i++)
            {
                int numberArguments = random.Next(9000, 50001); // Количество элементов в каждом массиве

                double[] arr = GenerateArray(A, B, numberArguments);

                Stopwatch stopwatch = Stopwatch.StartNew();

                MergeSortHelper.MergeSortAlgorithm(arr, 0, arr.Length - 1);

                stopwatch.Stop();

                uint elapsedTime = (uint)stopwatch.Elapsed.TotalMilliseconds;

                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(elapsedTime.ToString());
                item.SubItems.Add(arr.Length.ToString());
                item.SubItems.Add(((long)arr.Length * arr.Length).ToString());
                item.SubItems.Add((arr.Length * elapsedTime).ToString());

                listItems.Add(item);
            }

            list_calculations.Items.AddRange(listItems.ToArray());

            // Заполнение списка - конец

            // Расчёты - начало
            text_count_array_input.Text = sample_size_input.Text;

            long sumLengthArrays = 0;
            uint amountExecutionTime = 0;

            foreach (ListViewItem item in list_calculations.Items)
            {
                if (long.TryParse(item.SubItems[2].Text, out long value))
                {
                    sumLengthArrays += value;
                }

                if (uint.TryParse(item.SubItems[1].Text, out uint value1))
                {
                    amountExecutionTime += value1;
                }
            }

            text_length_sum_array_input.Text = sumLengthArrays.ToString();
            text_length_square_array_input_1.Text = sumLengthArrays.ToString();
            text_amount_time_input.Text = amountExecutionTime.ToString();
            text_length_square_array_input.Text = Math.Pow(sumLengthArrays, 2).ToString();
            text_length_plus_time_input.Text = (sumLengthArrays * amountExecutionTime).ToString();
            // Расчёты - конец
        }
    }
}
