using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace ControlWork
{
    public partial class MainForm : Form
    {
        public const int RAND_MAX = 32768;

        private static Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        public static double GetExponential(double A, double B)
        {
            double rundomNumber = random.NextDouble();

            double u = rundomNumber / RAND_MAX;

            double result = A - B * Math.Log(1 - u);

            return result;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // n_input_MouseHover Подсказка для ввода чисел.
        private void n_input_MouseHover(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(n_input, "Введите число от 9000 до 50000");
        }

        // Нажатие на кнопку "Сортировка".
        private void button_sort_begin_Click(object sender, EventArgs e)
        {
            double a = double.Parse(a_input.Text);
            double b = double.Parse(b_input.Text);
            int n = int.Parse(n_input.Text);

            double[] array = GenerateArray(a, b, n); // Генерация исходного массива
            DisplayOriginArray(array); // Отображение исходного массива

            double[] sortedArray = new double[n];
            Array.Copy(array, sortedArray, n);

            int comparisonCount = 0;
            int swapCount = 0;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); // Отсчёт таймер
            MergeSortHelper.MergeSortAlgorithm(sortedArray, 0, sortedArray.Length - 1, ref comparisonCount, ref swapCount);
            stopwatch.Stop(); // Остановка таймера после сортировки

            DisplaySortedArray(sortedArray); // Отображение отсортированного массива
            DisplayStatistics(comparisonCount, swapCount, stopwatch.ElapsedMilliseconds); // Отображение статистики
        }

        // Создание и заполнение массива.
        private double[] GenerateArray(double a, double b, int n)
        {
            double[] array = new double[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = GetExponential(a, b);
            }

            return array;
        }

        // Заполнеие списка для оригинального массива.
        private void DisplayOriginArray(double[] array)
        {
            list_origin_array.Items.Clear();
            List<ListViewItem> listItems = new List<ListViewItem>();

            for (int i = 0; i < array.Length; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = (i + 1).ToString();
                item.SubItems.Add(array[i].ToString());

                listItems.Add(item);
            }
            list_origin_array.Items.AddRange(listItems.ToArray());
        }

        // Заполнеие списка для сортированного массива.
        private void DisplaySortedArray(double[] array)
        {
            list_sorted_array.Items.Clear();
            List<ListViewItem> listItems = new List<ListViewItem>();

            for (int i = 0; i < array.Length; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = (i + 1).ToString();
                item.SubItems.Add(array[i].ToString());

                listItems.Add(item);
            }

            list_sorted_array.Items.AddRange(listItems.ToArray());
        }

        // Заполнение элементов для статистики.
        private void DisplayStatistics(int comparisonCount, int swapCount, double elapsedTime)
        {
            text_box_comparison_count.Text = comparisonCount.ToString();
            text_box_swap_count.Text = swapCount.ToString();
            text_box_time.Text = elapsedTime.ToString();
        }

        private void call_calc_form_button_Click_1(object sender, EventArgs e)
        {
            CalcForm form = new CalcForm();

            form.ShowDialog();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            list_origin_array.Items.Clear();
            list_sorted_array.Items.Clear();
            text_box_time.Clear();
            text_box_comparison_count.Clear();
            text_box_swap_count.Clear();
        }
    }
}
