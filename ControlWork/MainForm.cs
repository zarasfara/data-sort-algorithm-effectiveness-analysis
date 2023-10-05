using System;
using System.Windows.Forms;

namespace ControlWork
{
    public partial class MainForm : Form
    {
        public const int RAND_MAX = 32768;

        private double[] array;

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

        public static double GetExponential(double A, double B)
        {
            Random random = new Random();
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

            int n = int.Parse(n_input.Text);

            this.array = new double[n]; // Инициализация массива

            list_origin_array.Items.Clear();

            for (int i = 1; i <= n; i++)
            {
                this.array[i - 1] = GetExponential(a, b); // Заполнение массива с помощью GetExponential(a, b)

                // Создаем новый элемент ListViewItem
                ListViewItem item = new ListViewItem();

                // Добавляем значения для каждого столбца
                item.Text = i.ToString();
                item.SubItems.Add(this.array[i - 1].ToString());

                // Добавляем элемент в ListView
                list_origin_array.Items.Add(item);
            }

            /*
                 Array.Sort(this.array); // Сортировка массива

                list_sorted_array.Items.Clear();

                for (int i = 0; i < this.array.Length; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = (i + 1).ToString();
                    item.SubItems.Add(this.array[i].ToString());
                    list_sorted_array.Items.Add(item);
                }
             */
        }

    }
}
