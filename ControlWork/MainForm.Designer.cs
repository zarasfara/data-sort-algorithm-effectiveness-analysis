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
            this.table_main_content = new System.Windows.Forms.TableLayoutPanel();
            this.table_sort_content = new System.Windows.Forms.TableLayoutPanel();
            this.list_origin_array = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnElement = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_counter = new System.Windows.Forms.Panel();
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
            this.table_layout_b = new System.Windows.Forms.TableLayoutPanel();
            this.b_input = new System.Windows.Forms.TextBox();
            this.b_label = new System.Windows.Forms.Label();
            this.table_layout_n = new System.Windows.Forms.TableLayoutPanel();
            this.table_layout_a = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_sort_begin = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.header_panel.SuspendLayout();
            this.table_main_content.SuspendLayout();
            this.table_sort_content.SuspendLayout();
            this.panel_counter.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.table_layout_b.SuspendLayout();
            this.table_layout_n.SuspendLayout();
            this.table_layout_a.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.n_input.Location = new System.Drawing.Point(36, 67);
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
            this.a_input.Location = new System.Drawing.Point(39, 67);
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
            // table_main_content
            // 
            this.table_main_content.ColumnCount = 2;
            this.table_main_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_main_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.table_main_content.Controls.Add(this.table_sort_content, 1, 0);
            this.table_main_content.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.table_main_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_main_content.Location = new System.Drawing.Point(0, 55);
            this.table_main_content.Name = "table_main_content";
            this.table_main_content.RowCount = 1;
            this.table_main_content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_main_content.Size = new System.Drawing.Size(1092, 486);
            this.table_main_content.TabIndex = 6;
            // 
            // table_sort_content
            // 
            this.table_sort_content.ColumnCount = 2;
            this.table_sort_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.6063F));
            this.table_sort_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.3937F));
            this.table_sort_content.Controls.Add(this.list_origin_array, 0, 1);
            this.table_sort_content.Controls.Add(this.panel_counter, 0, 2);
            this.table_sort_content.Controls.Add(this.list_sorted_array, 1, 1);
            this.table_sort_content.Controls.Add(this.label1, 0, 0);
            this.table_sort_content.Controls.Add(this.label2, 1, 0);
            this.table_sort_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_sort_content.Location = new System.Drawing.Point(221, 3);
            this.table_sort_content.Name = "table_sort_content";
            this.table_sort_content.RowCount = 3;
            this.table_sort_content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.table_sort_content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_sort_content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.table_sort_content.Size = new System.Drawing.Size(868, 480);
            this.table_sort_content.TabIndex = 0;
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
            // panel_counter
            // 
            this.panel_counter.Controls.Add(this.text_box_swap_count);
            this.panel_counter.Controls.Add(this.label_transpotion_count);
            this.panel_counter.Controls.Add(this.text_box_comparison_count);
            this.panel_counter.Controls.Add(this.label_comparison_count);
            this.panel_counter.Controls.Add(this.text_box_time);
            this.panel_counter.Controls.Add(this.label_time);
            this.panel_counter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_counter.Location = new System.Drawing.Point(3, 333);
            this.panel_counter.Name = "panel_counter";
            this.panel_counter.Size = new System.Drawing.Size(424, 144);
            this.panel_counter.TabIndex = 6;
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
            this.tableLayoutPanel3.Controls.Add(this.table_layout_b, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.table_layout_n, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.table_layout_a, 0, 1);
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
            // table_layout_b
            // 
            this.table_layout_b.ColumnCount = 2;
            this.table_layout_b.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table_layout_b.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_layout_b.Controls.Add(this.b_input, 1, 0);
            this.table_layout_b.Controls.Add(this.b_label, 0, 0);
            this.table_layout_b.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_layout_b.Location = new System.Drawing.Point(3, 323);
            this.table_layout_b.Name = "table_layout_b";
            this.table_layout_b.RowCount = 1;
            this.table_layout_b.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_layout_b.Size = new System.Drawing.Size(206, 154);
            this.table_layout_b.TabIndex = 5;
            // 
            // b_input
            // 
            this.b_input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.b_input.Location = new System.Drawing.Point(39, 67);
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
            // table_layout_n
            // 
            this.table_layout_n.ColumnCount = 2;
            this.table_layout_n.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table_layout_n.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_layout_n.Controls.Add(this.n_input, 1, 0);
            this.table_layout_n.Controls.Add(this.n_label, 0, 0);
            this.table_layout_n.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_layout_n.Location = new System.Drawing.Point(3, 3);
            this.table_layout_n.Name = "table_layout_n";
            this.table_layout_n.RowCount = 1;
            this.table_layout_n.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_layout_n.Size = new System.Drawing.Size(206, 154);
            this.table_layout_n.TabIndex = 3;
            // 
            // table_layout_a
            // 
            this.table_layout_a.ColumnCount = 2;
            this.table_layout_a.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table_layout_a.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_layout_a.Controls.Add(this.a_input, 1, 0);
            this.table_layout_a.Controls.Add(this.a_label, 0, 0);
            this.table_layout_a.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_layout_a.Location = new System.Drawing.Point(3, 163);
            this.table_layout_a.Name = "table_layout_a";
            this.table_layout_a.RowCount = 1;
            this.table_layout_a.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_layout_a.Size = new System.Drawing.Size(206, 154);
            this.table_layout_a.TabIndex = 4;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 630);
            this.Controls.Add(this.table_main_content);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header_panel);
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курсовая работа АиСД";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.header_panel.ResumeLayout(false);
            this.table_main_content.ResumeLayout(false);
            this.table_sort_content.ResumeLayout(false);
            this.table_sort_content.PerformLayout();
            this.panel_counter.ResumeLayout(false);
            this.panel_counter.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.table_layout_b.ResumeLayout(false);
            this.table_layout_b.PerformLayout();
            this.table_layout_n.ResumeLayout(false);
            this.table_layout_n.PerformLayout();
            this.table_layout_a.ResumeLayout(false);
            this.table_layout_a.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Label app_name_label;
        private System.Windows.Forms.Label a_label;
        private System.Windows.Forms.TextBox a_input;
        private System.Windows.Forms.TextBox n_input;
        private System.Windows.Forms.Label n_label;
        private TableLayoutPanel table_main_content;
        private TableLayoutPanel table_sort_content;
        private ListView list_origin_array;
        private ColumnHeader columnId;
        private ColumnHeader columnElement;
        private Panel panel_counter;
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
        private TableLayoutPanel table_layout_n;
        private TableLayoutPanel table_layout_a;
        private TableLayoutPanel table_layout_b;
    }
}

