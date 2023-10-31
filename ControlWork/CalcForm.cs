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
            this.data_grid_calculations.Rows.Clear();

            if (!int.TryParse(sample_size_input.Text, out int numberArrays) || numberArrays <= 0)
            {
                // Вывод модального окна с сообщением об ошибке
                MessageBox.Show("Некорректный ввод количества массивов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double A = generateRandomNumber();
            double B = generateRandomNumber();

            List<DataGridViewRow> rows = new List<DataGridViewRow>();

            Random random = new Random();

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

            this.data_grid_calculations.Rows.AddRange(rows.ToArray());

            // Заполнение списка - конец

            // Расчёты - начало
            this.text_count_array_input.Text = sample_size_input.Text;

            long sumLengthArrays = 0;
            uint amountExecutionTime = 0;

            long sumOfProductsLengthsForTime = 0;

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

            // Сумма размеров массивов (Сумма x)
            this.text_length_sum_array_input.Text = sumLengthArrays.ToString();

            this.text_length_sum_array_input_1.Text = sumLengthArrays.ToString();

            // Сумма времени выполнения (Сумма y)
            this.text_amount_time_input.Text = amountExecutionTime.ToString();

            // Сумма x * x
            this.text_length_square_array_input.Text = Math.Pow(sumLengthArrays, 2).ToString();

            // Сумма произведений x * y
            this.text_length_plus_time_input.Text = sumOfProductsLengthsForTime.ToString();

            double[,] inputData = { 
                { 
                    Convert.ToDouble(sample_size_input.Text), 
                    Convert.ToDouble(text_length_sum_array_input.Text), 
                    Convert.ToDouble(text_amount_time_input.Text) },
                { 
                    Convert.ToDouble(text_length_sum_array_input_1.Text), 
                    Convert.ToDouble(text_length_square_array_input.Text),
                    Convert.ToDouble(text_length_plus_time_input.Text) 
                }
            };

            double[] res = GaussMethod.SolveGauss(inputData);

            textBox1.Text = Convert.ToString(res[0]); // a0
            textBox2.Text = Convert.ToString(res[1]); // a1

            // коэффициент эластичности
            double a1 = Convert.ToDouble(textBox2.Text);
            double averageX = Convert.ToDouble(this.text_length_sum_array_input.Text) / Convert.ToDouble(sample_size_input.Value);

            DataGridViewColumn selectedColumn = this.data_grid_calculations.Columns["time"];
            // Переменная для хранения суммы
            int sum = 0;
            // Проходимся по каждой строке и добавляем значение ячейки в сумму
            foreach (DataGridViewRow row in this.data_grid_calculations.Rows)
            {
                sum += Convert.ToInt32(row.Cells[selectedColumn.Index].Value);
            }

            double averageY = Convert.ToDouble(this.text_amount_time_input.Text) / Convert.ToDouble(sample_size_input.Value);
            text_box_elasticity.Text = Convert.ToString(СoefficientsHelper.CoefficientElasticity(a1, averageX, averageY));

        }
    }
}
