﻿using System;
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

        public static void Merge(double[] arr, int left, int middle, int right, ref int comparisonCount, ref int swapCount)
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

        private void n_input_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(n_input.Text, out int number))
            {
                // Если введенное значение не является числом, очищаем поле ввода
                n_input.Text = "";
            }
            else if (number < 1 || number > 9000)
            {
                // Если число находится вне диапазона от 5000 до 9000, очищаем поле ввода
                n_input.Text = "";
            }

        }

        // n_input_MouseHover Подсказка для ввода чисел.
        private void n_input_MouseHover(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(n_input, "Введите число от 5000 до 9000");
        }

        // Нажатие на кнопку "Сортировка".
        private void button_sort_begin_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) // Проверка ввода
            {
                return;
            }

            double a = double.Parse(a_input.Text);
            double b = double.Parse(b_input.Text);
            int n = int.Parse(n_input.Text);

            double[] array = GenerateArray(a, b, n); // Генерация исходного массива
            DisplayOriginArray(array); // Отображение исходного массива

            double[] sortedArray = new double[n];
            Array.Copy(array, sortedArray, n);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int comparisonCount = 0;
            int swapCount = 0;
            MergeSortAlgorithm(sortedArray, 0, sortedArray.Length - 1, ref comparisonCount, ref swapCount);

            DisplaySortedArray(sortedArray); // Отображение отсортированного массива
            DisplayStatistics(comparisonCount, swapCount, stopwatch.Elapsed.TotalMilliseconds); // Отображение статистики
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(a_input.Text) || string.IsNullOrEmpty(n_input.Text) || string.IsNullOrEmpty(b_input.Text))
            {
                MessageBox.Show("Ошибка: одно или несколько полей пустые.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            double a, b;
            if (!double.TryParse(a_input.Text, out a) || !double.TryParse(b_input.Text, out b))
            {
                MessageBox.Show("Ошибка: в полях 'A' и 'B' должны быть только числа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int n;
            if (!int.TryParse(n_input.Text, out n) || n < 1 || n > 9000)
            {
                MessageBox.Show("Ошибка: в поле 'N' должно быть целое число от 1 до 9000.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // Создание и заполнение массива.
        private double[] GenerateArray(double a, double b, int n)
        {
            double[] array = new double[n];
            Random random = new Random();

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

            for (int i = 0; i < array.Length; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = (i + 1).ToString();
                item.SubItems.Add(array[i].ToString());
                list_origin_array.Items.Add(item);
            }
        }

        // Заполнеие списка для сортированного массива.
        private void DisplaySortedArray(double[] array)
        {
            list_sorted_array.Items.Clear();

            for (int i = 0; i < array.Length; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = (i + 1).ToString();
                item.SubItems.Add(array[i].ToString());
                list_sorted_array.Items.Add(item);
            }
        }

        // Заполнение элементов для статистики.
        private void DisplayStatistics(int comparisonCount, int swapCount, double elapsedTime)
        {
            text_box_comparison_count.Text = comparisonCount.ToString();
            text_box_swap_count.Text = swapCount.ToString();
            text_box_time.Text = elapsedTime.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list_origin_array.Items.Clear();
            list_sorted_array.Items.Clear();
            text_box_time.Text = "";
            text_box_comparison_count.Text = "";
            text_box_swap_count.Text = "";
        }

        private void call_calc_form_button_Click_1(object sender, EventArgs e)
        {
            CalcForm form = new CalcForm();

            form.ShowDialog();
        }
    }
}
