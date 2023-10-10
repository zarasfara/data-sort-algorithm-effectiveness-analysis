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
            this.left_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.n_box = new System.Windows.Forms.Panel();
            this.n_input = new System.Windows.Forms.TextBox();
            this.n_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.a_input = new System.Windows.Forms.TextBox();
            this.a_label = new System.Windows.Forms.Label();
            this.b_box = new System.Windows.Forms.Panel();
            this.b_input = new System.Windows.Forms.TextBox();
            this.b_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_sort_begin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxSwapCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxСomparisonCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_box_time = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.list_sorted_array = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.list_origin_array = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnElement = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.header_panel.SuspendLayout();
            this.left_panel.SuspendLayout();
            this.n_box.SuspendLayout();
            this.panel2.SuspendLayout();
            this.b_box.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // header_panel
            // 
            this.header_panel.Controls.Add(this.app_name_label);
            this.header_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_panel.Location = new System.Drawing.Point(0, 0);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(962, 55);
            this.header_panel.TabIndex = 0;
            // 
            // app_name_label
            // 
            this.app_name_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.app_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.app_name_label.Location = new System.Drawing.Point(0, 0);
            this.app_name_label.Name = "app_name_label";
            this.app_name_label.Size = new System.Drawing.Size(962, 55);
            this.app_name_label.TabIndex = 0;
            this.app_name_label.Text = "Сортировка данных";
            this.app_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // left_panel
            // 
            this.left_panel.Controls.Add(this.n_box);
            this.left_panel.Controls.Add(this.panel2);
            this.left_panel.Controls.Add(this.b_box);
            this.left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_panel.Location = new System.Drawing.Point(0, 55);
            this.left_panel.Name = "left_panel";
            this.left_panel.Padding = new System.Windows.Forms.Padding(2);
            this.left_panel.Size = new System.Drawing.Size(200, 467);
            this.left_panel.TabIndex = 4;
            // 
            // n_box
            // 
            this.n_box.Controls.Add(this.n_input);
            this.n_box.Controls.Add(this.n_label);
            this.n_box.Location = new System.Drawing.Point(5, 5);
            this.n_box.Name = "n_box";
            this.n_box.Size = new System.Drawing.Size(185, 78);
            this.n_box.TabIndex = 2;
            // 
            // n_input
            // 
            this.n_input.Location = new System.Drawing.Point(44, 33);
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
            this.n_label.AutoSize = true;
            this.n_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n_label.Location = new System.Drawing.Point(7, 24);
            this.n_label.Name = "n_label";
            this.n_label.Size = new System.Drawing.Size(27, 29);
            this.n_label.TabIndex = 0;
            this.n_label.Text = "n";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.a_input);
            this.panel2.Controls.Add(this.a_label);
            this.panel2.Location = new System.Drawing.Point(5, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 100);
            this.panel2.TabIndex = 1;
            // 
            // a_input
            // 
            this.a_input.Location = new System.Drawing.Point(44, 38);
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
            this.a_label.Location = new System.Drawing.Point(7, 34);
            this.a_label.Name = "a_label";
            this.a_label.Size = new System.Drawing.Size(30, 29);
            this.a_label.TabIndex = 0;
            this.a_label.Text = "A";
            // 
            // b_box
            // 
            this.b_box.Controls.Add(this.b_input);
            this.b_box.Controls.Add(this.b_label);
            this.b_box.Location = new System.Drawing.Point(5, 195);
            this.b_box.Name = "b_box";
            this.b_box.Size = new System.Drawing.Size(185, 100);
            this.b_box.TabIndex = 2;
            // 
            // b_input
            // 
            this.b_input.Location = new System.Drawing.Point(43, 38);
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
            this.b_label.Location = new System.Drawing.Point(7, 34);
            this.b_label.Name = "b_label";
            this.b_label.Size = new System.Drawing.Size(30, 29);
            this.b_label.TabIndex = 0;
            this.b_label.Text = "B";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 522);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(962, 89);
            this.panel1.TabIndex = 3;
            // 
            // button_sort_begin
            // 
            this.button_sort_begin.AutoSize = true;
            this.button_sort_begin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_sort_begin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_sort_begin.Location = new System.Drawing.Point(3, 3);
            this.button_sort_begin.Name = "button_sort_begin";
            this.button_sort_begin.Size = new System.Drawing.Size(307, 63);
            this.button_sort_begin.TabIndex = 5;
            this.button_sort_begin.Text = "Сортировка";
            this.button_sort_begin.UseVisualStyleBackColor = true;
            this.button_sort_begin.Click += new System.EventHandler(this.button_sort_begin_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxSwapCount);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBoxСomparisonCount);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.text_box_time);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 320);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 144);
            this.panel3.TabIndex = 6;
            // 
            // textBoxSwapCount
            // 
            this.textBoxSwapCount.Location = new System.Drawing.Point(148, 67);
            this.textBoxSwapCount.Name = "textBoxSwapCount";
            this.textBoxSwapCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxSwapCount.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Перестановок";
            // 
            // textBoxСomparisonCount
            // 
            this.textBoxСomparisonCount.Location = new System.Drawing.Point(148, 41);
            this.textBoxСomparisonCount.Name = "textBoxСomparisonCount";
            this.textBoxСomparisonCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxСomparisonCount.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Сравнения";
            // 
            // text_box_time
            // 
            this.text_box_time.Location = new System.Drawing.Point(148, 15);
            this.text_box_time.Name = "text_box_time";
            this.text_box_time.Size = new System.Drawing.Size(100, 20);
            this.text_box_time.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Время";
            // 
            // list_sorted_array
            // 
            this.list_sorted_array.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.list_sorted_array.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_sorted_array.HideSelection = false;
            this.list_sorted_array.Location = new System.Drawing.Point(384, 43);
            this.list_sorted_array.Name = "list_sorted_array";
            this.list_sorted_array.Size = new System.Drawing.Size(375, 271);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(384, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Отсортированный массив";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.list_origin_array.Size = new System.Drawing.Size(375, 271);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Исходный массив";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.tableLayoutPanel1);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(200, 55);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(762, 467);
            this.main_panel.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.list_sorted_array, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.list_origin_array, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 467);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.button_sort_begin, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(942, 69);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(316, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 63);
            this.button1.TabIndex = 6;
            this.button1.Text = "Очистка";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 611);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.left_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header_panel);
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курсовая работа АиСД";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.header_panel.ResumeLayout(false);
            this.left_panel.ResumeLayout(false);
            this.n_box.ResumeLayout(false);
            this.n_box.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.b_box.ResumeLayout(false);
            this.b_box.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.main_panel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Label app_name_label;
        private System.Windows.Forms.FlowLayoutPanel left_panel;
        private System.Windows.Forms.Label a_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox a_input;
        private System.Windows.Forms.Panel n_box;
        private System.Windows.Forms.TextBox n_input;
        private System.Windows.Forms.Label n_label;
        private System.Windows.Forms.Panel b_box;
        private System.Windows.Forms.TextBox b_input;
        private System.Windows.Forms.Label b_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_sort_begin;
        private System.Windows.Forms.Label label1;
        private ListView list_origin_array;
        private ColumnHeader columnId;
        private ColumnHeader columnElement;
        private ListView list_sorted_array;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label label2;
        private Panel panel3;
        private TextBox text_box_time;
        private Label label3;
        private TextBox textBoxSwapCount;
        private Label label5;
        private TextBox textBoxСomparisonCount;
        private Label label4;
        private Panel main_panel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
    }
}

