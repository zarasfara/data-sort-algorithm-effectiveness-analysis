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
using System.Windows.Forms.DataVisualization.Charting;

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
            int n = int.Parse(sample_size_input.Text); // n
            long sumLengthArrays = 0; // Сумма x (Длин массивов)
            uint amountExecutionTime = 0; // Сумма y (Времени выполнения)
            long sumOfProductsLengthsForTime = 0; // Суммма x * y

            foreach (DataGridViewRow row in data_grid_calculations.Rows)
            {
                // y
                if (uint.TryParse(row.Cells[1].Value.ToString(), out uint valueX))
                {
                    amountExecutionTime += valueX;
                }

                // x
                if (long.TryParse(row.Cells[2].Value.ToString(), out long valueY))
                {
                    sumLengthArrays += valueY;
                }

                // x * y
                if (uint.TryParse(row.Cells[4].Value.ToString(), out uint valueXY))
                {
                    sumOfProductsLengthsForTime += valueXY;
                }
            }

            text_count_array_input.Text = n.ToString();
            text_length_sum_array_input.Text = sumLengthArrays.ToString(); // сумма x
            text_length_sum_array_input_1.Text = sumLengthArrays.ToString();
            text_amount_time_input.Text = amountExecutionTime.ToString(); // сумма y
            text_length_square_array_input.Text = Math.Pow(sumLengthArrays, 2).ToString();
            text_length_plus_time_input.Text = sumOfProductsLengthsForTime.ToString();

            // Матрица
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

            textBox1.Text = res[0].ToString();
            textBox2.Text = res[1].ToString();

            double a1 = res[1];

            DataGridViewColumn timeColumn = data_grid_calculations.Columns["time"];
            DataGridViewColumn sizeColumn = data_grid_calculations.Columns["array_size"];
            int length = Convert.ToInt32(sample_size_input.Text);
            List<int> array_time = new List<int>(length);
            List<int> array_size = new List<int>(length);

            foreach (DataGridViewRow row in data_grid_calculations.Rows)
            {
                int timeValue = Convert.ToInt32(row.Cells[timeColumn.Index].Value);
                array_time.Add(timeValue);
                array_size.Add(Convert.ToInt32(row.Cells[sizeColumn.Index].Value));
            }

            text_box_elasticity.Text = СoefficientsHelper.CoefficientElasticity(a1, n, sumLengthArrays, amountExecutionTime).ToString();

            textBox_link_y.Text = res[0].ToString();
            textBox_link_x.Text = res[1].ToString();

            double coeff_corel = СoefficientsHelper.CoefficientCorelation(
                Convert.ToInt64(sample_size_input.Value),
                array_time.ToArray(),
                sumLengthArrays,
                amountExecutionTime,
                Convert.ToInt64(Math.Pow(sumLengthArrays, 2)),
                sumOfProductsLengthsForTime
            );

            text_box_correlation.Text = coeff_corel.ToString();

            double coeff_beta = СoefficientsHelper.BetaCoefficient(a1, n, sumLengthArrays, amountExecutionTime, array_size.ToArray(), array_time.ToArray());
            text_box_beta_coefficient.Text = coeff_beta.ToString();

            text_box_determination.Text = СoefficientsHelper.CoefficientDetermination(coeff_corel).ToString();

            chart_dots.Series.Clear();
            Series series = new Series("Точечный наблюденный график");
            series.ChartType = SeriesChartType.Point;

            chart_dots.Series.Add(series);
            for (int i = 0; i < array_time.Count; i++)
            {
                series.Points.AddXY(array_size[i], array_time[i]);
            }
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
