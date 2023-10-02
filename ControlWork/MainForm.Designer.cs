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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.header_panel.SuspendLayout();
            this.left_panel.SuspendLayout();
            this.n_box.SuspendLayout();
            this.panel2.SuspendLayout();
            this.b_box.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 522);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 89);
            this.panel1.TabIndex = 3;
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
            this.n_box.Size = new System.Drawing.Size(185, 100);
            this.n_box.TabIndex = 2;
            // 
            // n_input
            // 
            this.n_input.Location = new System.Drawing.Point(44, 42);
            this.n_input.Name = "n_input";
            this.n_input.Size = new System.Drawing.Size(120, 20);
            this.n_input.TabIndex = 1;
            this.n_input.Leave += new System.EventHandler(this.n_input_Leave);
            this.n_input.MouseHover += new System.EventHandler(this.n_input_MouseHover);
            // 
            // n_label
            // 
            this.n_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.n_label.AutoSize = true;
            this.n_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n_label.Location = new System.Drawing.Point(7, 34);
            this.n_label.Name = "n_label";
            this.n_label.Size = new System.Drawing.Size(27, 29);
            this.n_label.TabIndex = 0;
            this.n_label.Text = "n";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.a_input);
            this.panel2.Controls.Add(this.a_label);
            this.panel2.Location = new System.Drawing.Point(5, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 100);
            this.panel2.TabIndex = 1;
            // 
            // a_input
            // 
            this.a_input.Location = new System.Drawing.Point(44, 42);
            this.a_input.Name = "a_input";
            this.a_input.Size = new System.Drawing.Size(120, 20);
            this.a_input.TabIndex = 1;
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
            this.b_box.Location = new System.Drawing.Point(5, 217);
            this.b_box.Name = "b_box";
            this.b_box.Size = new System.Drawing.Size(185, 100);
            this.b_box.TabIndex = 2;
            // 
            // b_input
            // 
            this.b_input.Location = new System.Drawing.Point(44, 42);
            this.b_input.Name = "b_input";
            this.b_input.Size = new System.Drawing.Size(120, 20);
            this.b_input.TabIndex = 1;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 611);
            this.Controls.Add(this.left_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header_panel);
            this.MinimumSize = new System.Drawing.Size(400, 450);
            this.Name = "MainForm";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Label app_name_label;
        private System.Windows.Forms.Panel panel1;
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
    }
}

