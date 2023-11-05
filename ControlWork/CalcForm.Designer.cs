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
            this.sample_size_input = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.start_calculation_button = new System.Windows.Forms.Button();
            this.data_grid_calculations = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_link_y = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.text_length_sum_array_input_1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_amount_time_input = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_link_x = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.text_box_correlation = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.text_box_determination = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.text_box_elasticity = new System.Windows.Forms.TextBox();
            this.text_box_beta_coefficient = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.array_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.calc_table_layout_panel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sample_size_input)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_calculations)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 55);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1054, 55);
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
            this.calc_table_layout_panel.Controls.Add(this.tableLayoutPanel11, 1, 2);
            this.calc_table_layout_panel.Controls.Add(this.label19, 1, 0);
            this.calc_table_layout_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calc_table_layout_panel.Location = new System.Drawing.Point(0, 55);
            this.calc_table_layout_panel.Name = "calc_table_layout_panel";
            this.calc_table_layout_panel.RowCount = 3;
            this.calc_table_layout_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.calc_table_layout_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calc_table_layout_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.calc_table_layout_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.calc_table_layout_panel.Size = new System.Drawing.Size(1054, 633);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(521, 34);
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
            this.sample_size_input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sample_size_input.Location = new System.Drawing.Point(330, 7);
            this.sample_size_input.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sample_size_input.Name = "sample_size_input";
            this.sample_size_input.Size = new System.Drawing.Size(120, 20);
            this.sample_size_input.TabIndex = 1;
            this.sample_size_input.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.start_calculation_button, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.data_grid_calculations, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.48148F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(521, 290);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 53);
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
            this.start_calculation_button.Size = new System.Drawing.Size(255, 47);
            this.start_calculation_button.TabIndex = 2;
            this.start_calculation_button.Text = "Расчёт";
            this.start_calculation_button.UseVisualStyleBackColor = true;
            this.start_calculation_button.Click += new System.EventHandler(this.start_calculation_button_Click);
            // 
            // data_grid_calculations
            // 
            this.data_grid_calculations.AllowUserToAddRows = false;
            this.data_grid_calculations.AllowUserToDeleteRows = false;
            this.data_grid_calculations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_calculations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.time,
            this.array_size,
            this.Column2,
            this.Column3});
            this.tableLayoutPanel1.SetColumnSpan(this.data_grid_calculations, 2);
            this.data_grid_calculations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_grid_calculations.Location = new System.Drawing.Point(3, 56);
            this.data_grid_calculations.Name = "data_grid_calculations";
            this.data_grid_calculations.ReadOnly = true;
            this.data_grid_calculations.RowHeadersVisible = false;
            this.data_grid_calculations.Size = new System.Drawing.Size(515, 231);
            this.data_grid_calculations.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 339);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(521, 291);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(515, 43);
            this.label3.TabIndex = 0;
            this.label3.Text = "Система нормальных уравнений";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.panel3, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel10, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.text_length_plus_time_input, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel8, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.text_amount_time_input, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel9, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label16, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.panel2, 2, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 46);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(515, 242);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.textBox_link_y);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(174, 183);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 56);
            this.panel3.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(123, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 24);
            this.label17.TabIndex = 1;
            this.label17.Text = "+";
            // 
            // textBox_link_y
            // 
            this.textBox_link_y.Location = new System.Drawing.Point(3, 17);
            this.textBox_link_y.Name = "textBox_link_y";
            this.textBox_link_y.ReadOnly = true;
            this.textBox_link_y.Size = new System.Drawing.Size(111, 20);
            this.textBox_link_y.TabIndex = 0;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel10.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.textBox2, 1, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(345, 123);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(167, 52);
            this.tableLayoutPanel10.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(3, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "a1 =";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox2.Location = new System.Drawing.Point(61, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(90, 20);
            this.textBox2.TabIndex = 1;
            // 
            // text_length_plus_time_input
            // 
            this.text_length_plus_time_input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_length_plus_time_input.Location = new System.Drawing.Point(362, 80);
            this.text_length_plus_time_input.Name = "text_length_plus_time_input";
            this.text_length_plus_time_input.ReadOnly = true;
            this.text_length_plus_time_input.Size = new System.Drawing.Size(132, 20);
            this.text_length_plus_time_input.TabIndex = 5;
            this.text_length_plus_time_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel8.Controls.Add(this.text_length_square_array_input, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(174, 63);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(165, 54);
            this.tableLayoutPanel8.TabIndex = 4;
            // 
            // text_length_square_array_input
            // 
            this.text_length_square_array_input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_length_square_array_input.Location = new System.Drawing.Point(3, 17);
            this.text_length_square_array_input.Name = "text_length_square_array_input";
            this.text_length_square_array_input.ReadOnly = true;
            this.text_length_square_array_input.Size = new System.Drawing.Size(101, 20);
            this.text_length_square_array_input.TabIndex = 0;
            this.text_length_square_array_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(110, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 54);
            this.label7.TabIndex = 1;
            this.label7.Text = "a1 =";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel5.Controls.Add(this.text_count_array_input, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(165, 54);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // text_count_array_input
            // 
            this.text_count_array_input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_count_array_input.Location = new System.Drawing.Point(3, 17);
            this.text_count_array_input.Name = "text_count_array_input";
            this.text_count_array_input.ReadOnly = true;
            this.text_count_array_input.Size = new System.Drawing.Size(101, 20);
            this.text_count_array_input.TabIndex = 0;
            this.text_count_array_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(110, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 54);
            this.label4.TabIndex = 1;
            this.label4.Text = "a0 +";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel6.Controls.Add(this.text_length_sum_array_input, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(174, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(165, 54);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // text_length_sum_array_input
            // 
            this.text_length_sum_array_input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_length_sum_array_input.Location = new System.Drawing.Point(3, 17);
            this.text_length_sum_array_input.Name = "text_length_sum_array_input";
            this.text_length_sum_array_input.ReadOnly = true;
            this.text_length_sum_array_input.Size = new System.Drawing.Size(100, 20);
            this.text_length_sum_array_input.TabIndex = 0;
            this.text_length_sum_array_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(110, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 54);
            this.label5.TabIndex = 1;
            this.label5.Text = "a1 =";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel7.Controls.Add(this.text_length_sum_array_input_1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(165, 54);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // text_length_sum_array_input_1
            // 
            this.text_length_sum_array_input_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_length_sum_array_input_1.Location = new System.Drawing.Point(3, 17);
            this.text_length_sum_array_input_1.Name = "text_length_sum_array_input_1";
            this.text_length_sum_array_input_1.ReadOnly = true;
            this.text_length_sum_array_input_1.Size = new System.Drawing.Size(101, 20);
            this.text_length_sum_array_input_1.TabIndex = 0;
            this.text_length_sum_array_input_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(110, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 54);
            this.label6.TabIndex = 1;
            this.label6.Text = "a0 +";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_amount_time_input
            // 
            this.text_amount_time_input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_amount_time_input.Location = new System.Drawing.Point(362, 20);
            this.text_amount_time_input.Name = "text_amount_time_input";
            this.text_amount_time_input.ReadOnly = true;
            this.text_amount_time_input.Size = new System.Drawing.Size(132, 20);
            this.text_amount_time_input.TabIndex = 2;
            this.text_amount_time_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 40);
            this.label8.TabIndex = 6;
            this.label8.Text = "Коэффициенты уравнения связи";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel9.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(174, 123);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(165, 54);
            this.tableLayoutPanel9.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "a0 =";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Location = new System.Drawing.Point(60, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(102, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(3, 180);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(165, 62);
            this.label16.TabIndex = 9;
            this.label16.Text = "Уравнение связи y =";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.textBox_link_x);
            this.panel2.Location = new System.Drawing.Point(345, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 56);
            this.panel2.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(131, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 24);
            this.label18.TabIndex = 3;
            this.label18.Text = "x";
            // 
            // textBox_link_x
            // 
            this.textBox_link_x.Location = new System.Drawing.Point(11, 18);
            this.textBox_link_x.Name = "textBox_link_x";
            this.textBox_link_x.ReadOnly = true;
            this.textBox_link_x.Size = new System.Drawing.Size(100, 20);
            this.textBox_link_x.TabIndex = 2;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel11.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.text_box_correlation, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.text_box_determination, 1, 1);
            this.tableLayoutPanel11.Controls.Add(this.label13, 0, 2);
            this.tableLayoutPanel11.Controls.Add(this.text_box_elasticity, 1, 2);
            this.tableLayoutPanel11.Controls.Add(this.text_box_beta_coefficient, 1, 3);
            this.tableLayoutPanel11.Controls.Add(this.label14, 0, 3);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(530, 339);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 4;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(521, 291);
            this.tableLayoutPanel11.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(58, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(247, 24);
            this.label11.TabIndex = 7;
            this.label11.Text = "Коэффициент корреляции";
            // 
            // text_box_correlation
            // 
            this.text_box_correlation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_box_correlation.Location = new System.Drawing.Point(377, 26);
            this.text_box_correlation.Name = "text_box_correlation";
            this.text_box_correlation.ReadOnly = true;
            this.text_box_correlation.Size = new System.Drawing.Size(130, 20);
            this.text_box_correlation.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(45, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(274, 24);
            this.label12.TabIndex = 9;
            this.label12.Text = "Коэффициент детерминации";
            // 
            // text_box_determination
            // 
            this.text_box_determination.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_box_determination.Location = new System.Drawing.Point(377, 98);
            this.text_box_determination.Name = "text_box_determination";
            this.text_box_determination.ReadOnly = true;
            this.text_box_determination.Size = new System.Drawing.Size(130, 20);
            this.text_box_determination.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(49, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(265, 24);
            this.label13.TabIndex = 11;
            this.label13.Text = "Коэффициент эластичности";
            // 
            // text_box_elasticity
            // 
            this.text_box_elasticity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_box_elasticity.Location = new System.Drawing.Point(377, 170);
            this.text_box_elasticity.Name = "text_box_elasticity";
            this.text_box_elasticity.ReadOnly = true;
            this.text_box_elasticity.Size = new System.Drawing.Size(130, 20);
            this.text_box_elasticity.TabIndex = 13;
            // 
            // text_box_beta_coefficient
            // 
            this.text_box_beta_coefficient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_box_beta_coefficient.Location = new System.Drawing.Point(377, 243);
            this.text_box_beta_coefficient.Name = "text_box_beta_coefficient";
            this.text_box_beta_coefficient.ReadOnly = true;
            this.text_box_beta_coefficient.Size = new System.Drawing.Size(130, 20);
            this.text_box_beta_coefficient.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(91, 241);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 24);
            this.label14.TabIndex = 12;
            this.label14.Text = "бета-коэффициент";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(530, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(521, 40);
            this.label19.TabIndex = 4;
            this.label19.Text = "Точечный график и график уравнения связи";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 50;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Width = 50;
            // 
            // time
            // 
            this.time.HeaderText = "Время, y";
            this.time.MinimumWidth = 60;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.time.Width = 60;
            // 
            // array_size
            // 
            this.array_size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.array_size.HeaderText = "Размер массива, x";
            this.array_size.Name = "array_size";
            this.array_size.ReadOnly = true;
            this.array_size.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "x*x";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "x*y";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 688);
            this.Controls.Add(this.calc_table_layout_panel);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1070, 39);
            this.Name = "CalcForm";
            this.Text = "Курсовая работа АиСД";
            this.panel1.ResumeLayout(false);
            this.calc_table_layout_panel.ResumeLayout(false);
            this.calc_table_layout_panel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sample_size_input)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_calculations)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel calc_table_layout_panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label sample_size_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button start_calculation_button;
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
        private TextBox text_length_sum_array_input_1;
        private Label label6;
        private DataGridView data_grid_calculations;
        private NumericUpDown sample_size_input;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel10;
        private Label label10;
        private TextBox textBox2;
        private TableLayoutPanel tableLayoutPanel9;
        private Label label9;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel11;
        private Label label11;
        private TextBox text_box_correlation;
        private Label label12;
        private TextBox text_box_determination;
        private Label label13;
        private TextBox text_box_elasticity;
        private TextBox text_box_beta_coefficient;
        private Label label14;
        private Label label16;
        private Panel panel3;
        private Label label17;
        private TextBox textBox_link_y;
        private Panel panel2;
        private Label label18;
        private TextBox textBox_link_x;
        private Label label19;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn time;
        private DataGridViewTextBoxColumn array_size;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}