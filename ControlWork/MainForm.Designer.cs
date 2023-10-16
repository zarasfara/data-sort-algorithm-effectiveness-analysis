using System.Windows.Forms;

namespace ControlWork
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.header_panel = new System.Windows.Forms.Panel();
            this.app_name_label = new System.Windows.Forms.Label();
            this.n_input = new System.Windows.Forms.TextBox();
            this.n_label = new System.Windows.Forms.Label();
            this.a_input = new System.Windows.Forms.TextBox();
            this.a_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.main_table = new System.Windows.Forms.TableLayoutPanel();
            this.list_origin_array = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnElement = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.text_box_swap_count = new System.Windows.Forms.TextBox();
            this.label_transpotion_count = new System.Windows.Forms.Label();
            this.text_box_comparison_count = new System.Windows.Forms.TextBox();
            this.label_comparison_count = new System.Windows.Forms.Label();
            this.text_box_time = new System.Windows.Forms.TextBox();
            this.label_time = new System.Windows.Forms.Label();
            this.list_sorted_array = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.b_input = new System.Windows.Forms.TextBox();
            this.b_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_sort_begin = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.header_panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.main_table.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // header_panel
            // 
            this.header_panel.Controls.Add(this.app_name_label);
            this.header_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_panel.Location = new System.Drawing.Point(0, 0);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(1092, 55);
            this.header_panel.TabIndex = 0;
            // 
            // app_name_label
            // 
            this.app_name_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.app_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.app_name_label.Location = new System.Drawing.Point(0, 0);
            this.app_name_label.Name = "app_name_label";
            this.app_name_label.Size = new System.Drawing.Size(1092, 55);
            this.app_name_label.TabIndex = 0;
            this.app_name_label.Text = "Сортировка данных";
            this.app_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // n_input
            // 
            this.n_input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.n_input.Location = new System.Drawing.Point(44, 67);
            this.n_input.MinimumSize = new System.Drawing.Size(100, 20);
            this.n_input.Name = "n_input";
            this.n_input.Size = new System.Drawing.Size(120, 20);
            this.n_input.TabIndex = 1;
            this.n_input.Text = "100";
            this.n_input.Leave += new System.EventHandler(this.n_input_Leave);
            this.n_input.MouseHover += new System.EventHandler(this.n_input_MouseHover);
            // 
            // n_label
            // 
            this.n_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.n_label.AutoSize = true;
            this.n_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n_label.Location = new System.Drawing.Point(3, 62);
            this.n_label.Name = "n_label";
            this.n_label.Size = new System.Drawing.Size(27, 29);
            this.n_label.TabIndex = 0;
            this.n_label.Text = "n";
            this.n_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // a_input
            // 
            this.a_input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.a_input.Location = new System.Drawing.Point(44, 67);
            this.a_input.Name = "a_input";
            this.a_input.Size = new System.Drawing.Size(120, 20);
            this.a_input.TabIndex = 1;
            this.a_input.Text = "0,85";
            // 
            // a_label
            // 
            this.a_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.a_label.AutoSize = true;
            this.a_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a_label.Location = new System.Drawing.Point(3, 62);
            this.a_label.Name = "a_label";
            this.a_label.Size = new System.Drawing.Size(30, 29);
            this.a_label.TabIndex = 0;
            this.a_label.Text = "A";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.main_table, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1092, 486);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // main_table
            // 
            this.main_table.ColumnCount = 2;
            this.main_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.6063F));
            this.main_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.3937F));
            this.main_table.Controls.Add(this.list_origin_array, 0, 1);
            this.main_table.Controls.Add(this.panel3, 0, 2);
            this.main_table.Controls.Add(this.list_sorted_array, 1, 1);
            this.main_table.Controls.Add(this.label1, 0, 0);
            this.main_table.Controls.Add(this.label2, 1, 0);
            this.main_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_table.Location = new System.Drawing.Point(221, 3);
            this.main_table.Name = "main_table";
            this.main_table.RowCount = 3;
            this.main_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.main_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.main_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.main_table.Size = new System.Drawing.Size(868, 480);
            this.main_table.TabIndex = 0;
            // 
            // list_origin_array
            // 
            this.list_origin_array.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnElement});
            this.list_origin_array.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_origin_array.HideSelection = false;
            this.list_origin_array.Location = new System.Drawing.Point(3, 43);
            this.list_origin_array.Name = "list_origin_array";
            this.list_origin_array.Size = new System.Drawing.Size(424, 284);
            this.list_origin_array.TabIndex = 2;
            this.list_origin_array.UseCompatibleStateImageBehavior = false;
            this.list_origin_array.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "Номер";
            this.columnId.Width = 85;
            // 
            // columnElement
            // 
            this.columnElement.Text = "Элемент";
            this.columnElement.Width = 180;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.text_box_swap_count);
            this.panel3.Controls.Add(this.label_transpotion_count);
            this.panel3.Controls.Add(this.text_box_comparison_count);
            this.panel3.Controls.Add(this.label_comparison_count);
            this.panel3.Controls.Add(this.text_box_time);
            this.panel3.Controls.Add(this.label_time);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 333);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 144);
            this.panel3.TabIndex = 6;
            // 
            // text_box_swap_count
            // 
            this.text_box_swap_count.Location = new System.Drawing.Point(148, 67);
            this.text_box_swap_count.Name = "text_box_swap_count";
            this.text_box_swap_count.Size = new System.Drawing.Size(100, 20);
            this.text_box_swap_count.TabIndex = 5;
            // 
            // label_transpotion_count
            // 
            this.label_transpotion_count.AutoSize = true;
            this.label_transpotion_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_transpotion_count.Location = new System.Drawing.Point(3, 63);
            this.label_transpotion_count.Name = "label_transpotion_count";
            this.label_transpotion_count.Size = new System.Drawing.Size(139, 24);
            this.label_transpotion_count.TabIndex = 4;
            this.label_transpotion_count.Text = "Перестановок";
            // 
            // text_box_comparison_count
            // 
            this.text_box_comparison_count.Location = new System.Drawing.Point(148, 41);
            this.text_box_comparison_count.Name = "text_box_comparison_count";
            this.text_box_comparison_count.Size = new System.Drawing.Size(100, 20);
            this.text_box_comparison_count.TabIndex = 3;
            // 
            // label_comparison_count
            // 
            this.label_comparison_count.AutoSize = true;
            this.label_comparison_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_comparison_count.Location = new System.Drawing.Point(3, 37);
            this.label_comparison_count.Name = "label_comparison_count";
            this.label_comparison_count.Size = new System.Drawing.Size(109, 24);
            this.label_comparison_count.TabIndex = 2;
            this.label_comparison_count.Text = "Сравнения";
            // 
            // text_box_time
            // 
            this.text_box_time.Location = new System.Drawing.Point(148, 15);
            this.text_box_time.Name = "text_box_time";
            this.text_box_time.Size = new System.Drawing.Size(100, 20);
            this.text_box_time.TabIndex = 1;
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_time.Location = new System.Drawing.Point(3, 11);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(67, 24);
            this.label_time.TabIndex = 0;
            this.label_time.Text = "Время";
            // 
            // list_sorted_array
            // 
            this.list_sorted_array.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.list_sorted_array.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_sorted_array.HideSelection = false;
            this.list_sorted_array.Location = new System.Drawing.Point(433, 43);
            this.list_sorted_array.Name = "list_sorted_array";
            this.list_sorted_array.Size = new System.Drawing.Size(432, 284);
            this.list_sorted_array.TabIndex = 5;
            this.list_sorted_array.UseCompatibleStateImageBehavior = false;
            this.list_sorted_array.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Номер";
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Элемент";
            this.columnHeader2.Width = 180;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Исходный массив";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(433, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Отсортированный массив";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(212, 480);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // b_input
            // 
            this.b_input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.b_input.Location = new System.Drawing.Point(44, 67);
            this.b_input.Name = "b_input";
            this.b_input.Size = new System.Drawing.Size(120, 20);
            this.b_input.TabIndex = 1;
            this.b_input.Text = "0,65";
            // 
            // b_label
            // 
            this.b_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.b_label.AutoSize = true;
            this.b_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_label.Location = new System.Drawing.Point(3, 62);
            this.b_label.Name = "b_label";
            this.b_label.Size = new System.Drawing.Size(30, 29);
            this.b_label.TabIndex = 0;
            this.b_label.Text = "B";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.button_sort_begin, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_clear, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1072, 69);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // button_sort_begin
            // 
            this.button_sort_begin.AutoSize = true;
            this.button_sort_begin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_sort_begin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_sort_begin.Location = new System.Drawing.Point(3, 3);
            this.button_sort_begin.Name = "button_sort_begin";
            this.button_sort_begin.Size = new System.Drawing.Size(351, 63);
            this.button_sort_begin.TabIndex = 5;
            this.button_sort_begin.Text = "Сортировка";
            this.button_sort_begin.UseVisualStyleBackColor = true;
            this.button_sort_begin.Click += new System.EventHandler(this.button_sort_begin_Click);
            // 
            // button_clear
            // 
            this.button_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.Location = new System.Drawing.Point(360, 3);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(351, 63);
            this.button_clear.TabIndex = 6;
            this.button_clear.Text = "Очистка";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 541);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1092, 89);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.Controls.Add(this.n_input, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.n_label, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(206, 154);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel5.Controls.Add(this.a_input, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.a_label, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 163);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(206, 154);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel6.Controls.Add(this.b_input, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.b_label, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 323);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(206, 154);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 630);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header_panel);
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курсовая работа АиСД";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.header_panel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.main_table.ResumeLayout(false);
            this.main_table.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Label app_name_label;
        private System.Windows.Forms.Label a_label;
        private System.Windows.Forms.TextBox a_input;
        private System.Windows.Forms.TextBox n_input;
        private System.Windows.Forms.Label n_label;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel main_table;
        private ListView list_origin_array;
        private ColumnHeader columnId;
        private ColumnHeader columnElement;
        private Panel panel3;
        private TextBox text_box_swap_count;
        private Label label_transpotion_count;
        private TextBox text_box_comparison_count;
        private Label label_comparison_count;
        private TextBox text_box_time;
        private Label label_time;
        private ListView list_sorted_array;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button_sort_begin;
        private Button button_clear;
        private Panel panel1;
        private TextBox b_input;
        private Label b_label;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
    }
}

