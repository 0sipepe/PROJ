namespace praktika1
{
    partial class Form1
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
            this.table = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.populationMin = new System.Windows.Forms.NumericUpDown();
            this.populationMax = new System.Windows.Forms.NumericUpDown();
            this.HospMax = new System.Windows.Forms.NumericUpDown();
            this.HospMin = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospMin)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(12, 116);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(440, 322);
            this.table.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "<";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "<";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // populationMin
            // 
            this.populationMin.Location = new System.Drawing.Point(258, 63);
            this.populationMin.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.populationMin.Name = "populationMin";
            this.populationMin.Size = new System.Drawing.Size(57, 20);
            this.populationMin.TabIndex = 13;
            this.populationMin.ValueChanged += new System.EventHandler(this.population_ValueChanged);
            // 
            // populationMax
            // 
            this.populationMax.Location = new System.Drawing.Point(274, 90);
            this.populationMax.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.populationMax.Name = "populationMax";
            this.populationMax.Size = new System.Drawing.Size(57, 20);
            this.populationMax.TabIndex = 14;
            this.populationMax.ValueChanged += new System.EventHandler(this.population_ValueChanged);
            // 
            // HospMax
            // 
            this.HospMax.Location = new System.Drawing.Point(383, 90);
            this.HospMax.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.HospMax.Name = "HospMax";
            this.HospMax.Size = new System.Drawing.Size(57, 20);
            this.HospMax.TabIndex = 18;
            this.HospMax.ValueChanged += new System.EventHandler(this.Hosp_ValueChanged);
            // 
            // HospMin
            // 
            this.HospMin.Location = new System.Drawing.Point(367, 63);
            this.HospMin.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.HospMin.Name = "HospMin";
            this.HospMin.Size = new System.Drawing.Size(57, 20);
            this.HospMin.TabIndex = 17;
            this.HospMin.ValueChanged += new System.EventHandler(this.Hosp_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "<";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "<";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.HospMax);
            this.Controls.Add(this.HospMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.populationMax);
            this.Controls.Add(this.populationMin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.table);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown populationMin;
        private System.Windows.Forms.NumericUpDown populationMax;
        private System.Windows.Forms.NumericUpDown HospMax;
        private System.Windows.Forms.NumericUpDown HospMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

