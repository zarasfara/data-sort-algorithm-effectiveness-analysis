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

        private void FillDataGrid(int numberArrays, double A, double B)
        {
            data_grid_calculations.Rows.Clear();
            List<DataGridViewRow> rows = new List<DataGridViewRow>();

            for (int i = 0; i < numberArrays; i++)
            {
                int numberArguments = random.Next(9000, 50001); // Количество элементов в каждом массиве

                double[] arr = GenerateArray(A, B, numberArguments);

                Stopwatch stopwatch = Stopwatch.StartNew();
                MergeSortHelper.MergeSortAlgorithm(arr, 0, arr.Length - 1);
                stopwatch.Stop();

                uint elapsedTime = (uint)stopwatch.Elapsed.TotalMilliseconds;

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(data_grid_calculations);
                row.Cells[0].Value = i.ToString();
                row.Cells[1].Value = elapsedTime.ToString();
                row.Cells[2].Value = arr.Length.ToString();
                row.Cells[3].Value = ((long)arr.Length * arr.Length).ToString();
                row.Cells[4].Value = (arr.Length * elapsedTime).ToString();

                rows.Add(row);
            }

            data_grid_calculations.Rows.AddRange(rows.ToArray());
        }

        private void PerformCalculations()
        {
            long sumLengthArrays = 0; // Сумма длин массивов - x
            uint amountExecutionTime = 0; // сумма время выполнения - y
            long sumOfProductsLengthsForTime = 0; // произведение времени выполнения и длины массив - x * y

            foreach (DataGridViewRow row in data_grid_calculations.Rows)
            {
                if (long.TryParse(row.Cells[2].Value.ToString(), out long value))
                {
                    sumLengthArrays += value;
                }

                if (uint.TryParse(row.Cells[1].Value.ToString(), out uint value1))
                {
                    amountExecutionTime += value1;
                }

                if (uint.TryParse(row.Cells[4].Value.ToString(), out uint value2))
                {
                    sumOfProductsLengthsForTime += value2;
                }
            }

            text_count_array_input.Text = sample_size_input.Text;
            text_length_sum_array_input.Text = sumLengthArrays.ToString();
            text_length_sum_array_input_1.Text = sumLengthArrays.ToString();
            text_amount_time_input.Text = amountExecutionTime.ToString();
            text_length_square_array_input.Text = Math.Pow(sumLengthArrays, 2).ToString();
            text_length_plus_time_input.Text = sumOfProductsLengthsForTime.ToString();

            double[,] inputData = {
                {
                    Convert.ToDouble(sample_size_input.Text),
                    Convert.ToDouble(text_length_sum_array_input.Text),
                    Convert.ToDouble(text_amount_time_input.Text)
                },
                {
                    Convert.ToDouble(text_length_sum_array_input_1.Text),
                    Convert.ToDouble(text_length_square_array_input.Text),
                    Convert.ToDouble(text_length_plus_time_input.Text)
                }
            };

            double[] res = GaussMethod.SolveGauss(inputData);

            textBox1.Text = Convert.ToString(res[0]); // a0
            textBox2.Text = Convert.ToString(res[1]); // a1

            double a1 = res[1];
            double averageX = Convert.ToDouble(text_length_sum_array_input.Text) / Convert.ToDouble(sample_size_input.Value);

            DataGridViewColumn timeColumn = data_grid_calculations.Columns["time"];
            DataGridViewColumn sizeColumn = data_grid_calculations.Columns["array_size"];
            int sumTime = 0;
            int length = Convert.ToInt32(sample_size_input.Text);
            int[] array_time = new int[length]; // Массив времени выполнения
            int[] array_size = new int[length]; // Массив размеров массивов

            int rowIndex = 0;
            foreach (DataGridViewRow row in data_grid_calculations.Rows)
            {
                sumTime += Convert.ToInt32(row.Cells[timeColumn.Index].Value);
                array_time[rowIndex] = Convert.ToInt32(row.Cells[timeColumn.Index].Value);
                array_size[rowIndex] = Convert.ToInt32(row.Cells[sizeColumn.Index].Value);
                rowIndex++;
            }

            double averageY = Convert.ToDouble(text_amount_time_input.Text) / Convert.ToDouble(sample_size_input.Value);
            text_box_elasticity.Text = Convert.ToString(СoefficientsHelper.CoefficientElasticity(a1, averageX, averageY));

            textBox_link_y.Text = Convert.ToString(res[0]);
            textBox_link_x.Text = Convert.ToString(res[1]);

            double coeff_corel = СoefficientsHelper.CoefficientCorelation(
                Convert.ToInt64(sample_size_input.Value),
                array_time,
                sumLengthArrays,
                amountExecutionTime,
                Convert.ToInt64(Math.Pow(sumLengthArrays, 2)),
                sumOfProductsLengthsForTime
            );

            text_box_correlation.Text = Convert.ToString(coeff_corel);

            double coeff_beta = СoefficientsHelper.BetaCoefficient(a1, Convert.ToInt64(sample_size_input.Value), sumLengthArrays, sumTime, array_size, array_time);
            this.text_box_beta_coefficient.Text = coeff_beta.ToString();

            // Коэффициент детерминации
            text_box_determination.Text = СoefficientsHelper.CoefficientDetermination(coeff_corel).ToString();
        }

        private void start_calculation_button_Click(object sender, EventArgs e)
        {

            // Заполнение списка - начало
            double A = generateRandomNumber();
            double B = generateRandomNumber();

            // Заполнение data grid view 
            FillDataGrid(Convert.ToInt32(sample_size_input.Text), A, B);
            // Заполнение списка - конец

            PerformCalculations();
        }
    }
}
