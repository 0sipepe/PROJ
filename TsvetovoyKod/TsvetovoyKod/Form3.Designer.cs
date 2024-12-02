namespace TsvetovoyKod
{
    partial class Form3
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
            this.btnBackFromResults = new System.Windows.Forms.Button();
            this.gbWinners = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbWinners.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackFromResults
            // 
            this.btnBackFromResults.Font = new System.Drawing.Font("MS Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackFromResults.Location = new System.Drawing.Point(10, 434);
            this.btnBackFromResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackFromResults.Name = "btnBackFromResults";
            this.btnBackFromResults.Size = new System.Drawing.Size(111, 41);
            this.btnBackFromResults.TabIndex = 14;
            this.btnBackFromResults.Text = "к меню";
            this.btnBackFromResults.UseVisualStyleBackColor = true;
            this.btnBackFromResults.Click += new System.EventHandler(this.btnBackFromResults_Click);
            // 
            // gbWinners
            // 
            this.gbWinners.Controls.Add(this.label2);
            this.gbWinners.Controls.Add(this.label1);
            this.gbWinners.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWinners.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbWinners.Location = new System.Drawing.Point(137, 57);
            this.gbWinners.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbWinners.Name = "gbWinners";
            this.gbWinners.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbWinners.Size = new System.Drawing.Size(500, 354);
            this.gbWinners.TabIndex = 15;
            this.gbWinners.TabStop = false;
            this.gbWinners.Text = "Лидеры";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 292);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(408, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 292);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TsvetovoyKod.Properties.Resources.фон;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 479);
            this.Controls.Add(this.gbWinners);
            this.Controls.Add(this.btnBackFromResults);
            this.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Результаты";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.gbWinners.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackFromResults;
        private System.Windows.Forms.GroupBox gbWinners;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}