using System;
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

        public static void MergeSortAlgorithm(double[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSortAlgorithm(arr, left, middle);
                MergeSortAlgorithm(arr, middle + 1, right);

                Merge(arr, left, middle, right);
            }
        }

        public static void Merge(double[] arr, int left, int middle, int right)
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
            }

            while (m < n1)
            {
                arr[k] = leftArray[m];
                m++;
                k++;
            }

            while (n < n2)
            {
                arr[k] = rightArray[n];
                n++;
                k++;
            }
        }

        //public static double GetExponential(double a, double b)
        //{
        //    double u = random.NextDouble();

        //    double result = a - (1 / b) * Math.Log(u);

        //    return result;
        //}

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
            else if (number < 1 || number > 1000)
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

        // button_sort_begin_Click Нажатие на кнопку "Сортировка".
        private void button_sort_begin_Click(object sender, EventArgs e)
        {
            // проверки begin
            if (string.IsNullOrEmpty(a_input.Text) || string.IsNullOrEmpty(n_input.Text) || string.IsNullOrEmpty(b_input.Text))
            {
                MessageBox.Show("Ошибка: одно или несколько полей пустые.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double a, b;
            if (!double.TryParse(a_input.Text, out a) || !double.TryParse(b_input.Text, out b))
            {
                MessageBox.Show("Ошибка: в полях 'A' и 'B' должны быть только числа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // проверки end

            // Заполнение изначального массива
            int n = int.Parse(n_input.Text);

            double[] array = new double[n]; // Инициализация массива

            list_origin_array.Items.Clear();


            // Заполнение listview
            for (int i = 1; i <= n; i++)
            {
                array[i - 1] = GetExponential(a, b); // Заполнение массива с помощью GetExponential(a, b)

                // Создаем новый элемент ListViewItem
                ListViewItem item = new ListViewItem();

                // Добавляем значения для каждого столбца
                item.Text = i.ToString();
                item.SubItems.Add(array[i - 1].ToString());

                // Добавляем элемент в ListView
                list_origin_array.Items.Add(item);
            }

            // Создаём отсортированный массив
            double[] sortedArray = new double[n];
            Array.Copy(array, sortedArray, n);
            MergeSortAlgorithm(sortedArray, 0, sortedArray.Length - 1);

            list_sorted_array.BeginUpdate(); // Отключаем обновление ListView

            list_sorted_array.Items.Clear();
            ListViewItem[] sortedItems = new ListViewItem[n];

            for (int i = 0; i < sortedArray.Length; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = (i + 1).ToString();
                item.SubItems.Add(sortedArray[i].ToString());
                sortedItems[i] = item;
            }

            list_sorted_array.Items.AddRange(sortedItems); // Добавляем все элементы одним вызовом

            list_sorted_array.EndUpdate(); // Включаем обновление ListView
        }
    }
}
