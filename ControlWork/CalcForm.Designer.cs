using System.Windows.Forms;

namespace ControlWork
{
    partial class CalcForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.calc_table_layout_panel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.sample_size_label = new System.Windows.Forms.Label();
            this.sample_size_input = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.start_calculation_button = new System.Windows.Forms.Button();
            this.list_calculations = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.text_length_plus_time_input = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.text_length_square_array_input = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.text_count_array_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.text_length_sum_array_input = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_amount_time_input = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.text_length_square_array_input_1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.calc_table_layout_panel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 55);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1052, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оценивание коэффициентов уравнения связи";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calc_table_layout_panel
            // 
            this.calc_table_layout_panel.ColumnCount = 2;
            this.calc_table_layout_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calc_table_layout_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calc_table_layout_panel.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.calc_table_layout_panel.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.calc_table_layout_panel.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.calc_table_layout_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calc_table_layout_panel.Location = new System.Drawing.Point(0, 55);
            this.calc_table_layout_panel.Name = "calc_table_layout_panel";
            this.calc_table_layout_panel.RowCount = 3;
            this.calc_table_layout_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.calc_table_layout_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calc_table_layout_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calc_table_layout_panel.Size = new System.Drawing.Size(1052, 617);
            this.calc_table_layout_panel.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.sample_size_label, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.sample_size_input, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(520, 34);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // sample_size_label
            // 
            this.sample_size_label.AutoSize = true;
            this.sample_size_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sample_size_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sample_size_label.Location = new System.Drawing.Point(3, 0);
            this.sample_size_label.Name = "sample_size_label";
            this.sample_size_label.Size = new System.Drawing.Size(254, 34);
            this.sample_size_label.TabIndex = 0;
            this.sample_size_label.Text = "Объем выборки";
            this.sample_size_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sample_size_input
            // 
            this.sample_size_input.Location = new System.Drawing.Point(263, 3);
            this.sample_size_input.Name = "sample_size_input";
            this.sample_size_input.Size = new System.Drawing.Size(215, 20);
            this.sample_size_input.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.start_calculation_button, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.list_calculations, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.81818F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(520, 282);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Исходные данные";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // start_calculation_button
            // 
            this.start_calculation_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.start_calculation_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_calculation_button.Location = new System.Drawing.Point(263, 3);
            this.start_calculation_button.Name = "start_calculation_button";
            this.start_calculation_button.Size = new System.Drawing.Size(254, 45);
            this.start_calculation_button.TabIndex = 2;
            this.start_calculation_button.Text = "Расчёт";
            this.start_calculation_button.UseVisualStyleBackColor = true;
            this.start_calculation_button.Click += new System.EventHandler(this.start_calculation_button_Click);
            // 
            // list_calculations
            // 
            this.list_calculations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.tableLayoutPanel1.SetColumnSpan(this.list_calculations, 2);
            this.list_calculations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_calculations.GridLines = true;
            this.list_calculations.HideSelection = false;
            this.list_calculations.Location = new System.Drawing.Point(3, 54);
            this.list_calculations.Name = "list_calculations";
            this.list_calculations.Size = new System.Drawing.Size(514, 225);
            this.list_calculations.TabIndex = 3;
            this.list_calculations.UseCompatibleStateImageBehavior = false;
            this.list_calculations.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Время, y";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Размер массива, x";
            this.columnHeader3.Width = 168;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "x*x";
            this.columnHeader4.Width = 111;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "x*y";
            this.columnHeader5.Width = 99;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 331);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(520, 283);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(514, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Система нормальных уравнений";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.37743F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.35408F));
            this.tableLayoutPanel4.Controls.Add(this.text_length_plus_time_input, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel8, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.text_amount_time_input, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 45);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(514, 235);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // text_length_plus_time_input
            // 
            this.text_length_plus_time_input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_length_plus_time_input.Location = new System.Drawing.Point(324, 42);
            this.text_length_plus_time_input.Name = "text_length_plus_time_input";
            this.text_length_plus_time_input.Size = new System.Drawing.Size(100, 20);
            this.text_length_plus_time_input.TabIndex = 5;
            this.text_length_plus_time_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.text_length_square_array_input, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(174, 38);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(144, 29);
            this.tableLayoutPanel8.TabIndex = 4;
            // 
            // text_length_square_array_input
            // 
            this.text_length_square_array_input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_length_square_array_input.Location = new System.Drawing.Point(3, 4);
            this.text_length_square_array_input.Name = "text_length_square_array_input";
            this.text_length_square_array_input.Size = new System.Drawing.Size(66, 20);
            this.text_length_square_array_input.TabIndex = 0;
            this.text_length_square_array_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(75, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "a1 =";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.text_count_array_input, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(165, 29);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // text_count_array_input
            // 
            this.text_count_array_input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_count_array_input.Location = new System.Drawing.Point(3, 4);
            this.text_count_array_input.Name = "text_count_array_input";
            this.text_count_array_input.Size = new System.Drawing.Size(76, 20);
            this.text_count_array_input.TabIndex = 0;
            this.text_count_array_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(85, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "a0 +";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.text_length_sum_array_input, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(174, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(144, 29);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // text_length_sum_array_input
            // 
            this.text_length_sum_array_input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_length_sum_array_input.Location = new System.Drawing.Point(3, 4);
            this.text_length_sum_array_input.Name = "text_length_sum_array_input";
            this.text_length_sum_array_input.Size = new System.Drawing.Size(66, 20);
            this.text_length_sum_array_input.TabIndex = 0;
            this.text_length_sum_array_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(75, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "a1 =";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_amount_time_input
            // 
            this.text_amount_time_input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text_amount_time_input.Location = new System.Drawing.Point(324, 7);
            this.text_amount_time_input.Name = "text_amount_time_input";
            this.text_amount_time_input.Size = new System.Drawing.Size(100, 20);
            this.text_amount_time_input.TabIndex = 2;
            this.text_amount_time_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.text_length_square_array_input_1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(165, 29);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // text_length_square_array_input_1
            // 
            this.text_length_square_array_input_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_length_square_array_input_1.Location = new System.Drawing.Point(3, 4);
            this.text_length_square_array_input_1.Name = "text_length_square_array_input_1";
            this.text_length_square_array_input_1.Size = new System.Drawing.Size(76, 20);
            this.text_length_square_array_input_1.TabIndex = 0;
            this.text_length_square_array_input_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(85, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "a0 +";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 672);
            this.Controls.Add(this.calc_table_layout_panel);
            this.Controls.Add(this.panel1);
            this.Name = "CalcForm";
            this.Text = "Курсовая работа АиСД";
            this.panel1.ResumeLayout(false);
            this.calc_table_layout_panel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel calc_table_layout_panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label sample_size_label;
        private System.Windows.Forms.TextBox sample_size_input;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button start_calculation_button;
        private System.Windows.Forms.ListView list_calculations;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox text_count_array_input;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel6;
        private TextBox text_length_sum_array_input;
        private Label label5;
        private TextBox text_amount_time_input;
        private TextBox text_length_plus_time_input;
        private TableLayoutPanel tableLayoutPanel8;
        private TextBox text_length_square_array_input;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel7;
        private TextBox text_length_square_array_input_1;
        private Label label6;
    }
}