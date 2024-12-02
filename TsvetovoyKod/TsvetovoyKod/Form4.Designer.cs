namespace TsvetovoyKod
{
    partial class Form4
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnBackFromInstruct = new System.Windows.Forms.Button();
            this.rtbInstruction = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(237, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(310, 35);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "инструкция";
            // 
            // btnBackFromInstruct
            // 
            this.btnBackFromInstruct.Font = new System.Drawing.Font("MS Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackFromInstruct.Location = new System.Drawing.Point(272, 402);
            this.btnBackFromInstruct.Name = "btnBackFromInstruct";
            this.btnBackFromInstruct.Size = new System.Drawing.Size(220, 36);
            this.btnBackFromInstruct.TabIndex = 1;
            this.btnBackFromInstruct.Text = "понятно";
            this.btnBackFromInstruct.UseVisualStyleBackColor = true;
            this.btnBackFromInstruct.Click += new System.EventHandler(this.btnBackFromInstruct_Click);
            // 
            // rtbInstruction
            // 
            this.rtbInstruction.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInstruction.Location = new System.Drawing.Point(21, 59);
            this.rtbInstruction.Name = "rtbInstruction";
            this.rtbInstruction.Size = new System.Drawing.Size(753, 328);
            this.rtbInstruction.TabIndex = 3;
            this.rtbInstruction.Text = "";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TsvetovoyKod.Properties.Resources.фон;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbInstruction);
            this.Controls.Add(this.btnBackFromInstruct);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form4";
            this.Text = "Инструкция";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnBackFromInstruct;
        private System.Windows.Forms.RichTextBox rtbInstruction;
    }
}