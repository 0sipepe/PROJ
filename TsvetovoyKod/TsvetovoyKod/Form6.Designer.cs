namespace TsvetovoyKod
{
    partial class Form6
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
            this.btnStartLevels = new System.Windows.Forms.Button();
            this.btnToResultsScreen = new System.Windows.Forms.Button();
            this.btnInstruction = new System.Windows.Forms.Button();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartLevels
            // 
            this.btnStartLevels.Location = new System.Drawing.Point(284, 153);
            this.btnStartLevels.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartLevels.Name = "btnStartLevels";
            this.btnStartLevels.Size = new System.Drawing.Size(242, 53);
            this.btnStartLevels.TabIndex = 0;
            this.btnStartLevels.Text = "начать";
            this.btnStartLevels.UseVisualStyleBackColor = true;
            this.btnStartLevels.Click += new System.EventHandler(this.btnStartLevels_Click);
            // 
            // btnToResultsScreen
            // 
            this.btnToResultsScreen.Location = new System.Drawing.Point(284, 210);
            this.btnToResultsScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToResultsScreen.Name = "btnToResultsScreen";
            this.btnToResultsScreen.Size = new System.Drawing.Size(242, 53);
            this.btnToResultsScreen.TabIndex = 1;
            this.btnToResultsScreen.Text = "результаты";
            this.btnToResultsScreen.UseVisualStyleBackColor = true;
            this.btnToResultsScreen.Click += new System.EventHandler(this.btnToResultsScreen_Click);
            // 
            // btnInstruction
            // 
            this.btnInstruction.Location = new System.Drawing.Point(284, 268);
            this.btnInstruction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInstruction.Name = "btnInstruction";
            this.btnInstruction.Size = new System.Drawing.Size(242, 53);
            this.btnInstruction.TabIndex = 2;
            this.btnInstruction.Text = "инструкция";
            this.btnInstruction.UseVisualStyleBackColor = true;
            this.btnInstruction.Click += new System.EventHandler(this.btnInstruction_Click);
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(284, 118);
            this.tbUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUser.Multiline = true;
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(243, 31);
            this.tbUser.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelName.Location = new System.Drawing.Point(281, 93);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(141, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "введите имя";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TsvetovoyKod.Properties.Resources.фон;
            this.ClientSize = new System.Drawing.Size(858, 424);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.btnInstruction);
            this.Controls.Add(this.btnToResultsScreen);
            this.Controls.Add(this.btnStartLevels);
            this.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form6";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartLevels;
        private System.Windows.Forms.Button btnToResultsScreen;
        private System.Windows.Forms.Button btnInstruction;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label labelName;
    }
}