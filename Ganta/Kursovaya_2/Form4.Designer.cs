namespace Kursovaya_2
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
            this.btnFromFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnToCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFromFile
            // 
            this.btnFromFile.Location = new System.Drawing.Point(310, 167);
            this.btnFromFile.Name = "btnFromFile";
            this.btnFromFile.Size = new System.Drawing.Size(221, 74);
            this.btnFromFile.TabIndex = 11;
            this.btnFromFile.Text = "загрузить проект";
            this.btnFromFile.UseVisualStyleBackColor = true;
            this.btnFromFile.Click += new System.EventHandler(this.btnFromFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnToCreate
            // 
            this.btnToCreate.Location = new System.Drawing.Point(310, 247);
            this.btnToCreate.Name = "btnToCreate";
            this.btnToCreate.Size = new System.Drawing.Size(221, 74);
            this.btnToCreate.TabIndex = 12;
            this.btnToCreate.Text = "создать проект";
            this.btnToCreate.UseVisualStyleBackColor = true;
            this.btnToCreate.Click += new System.EventHandler(this.btnToCreate_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 499);
            this.Controls.Add(this.btnToCreate);
            this.Controls.Add(this.btnFromFile);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFromFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnToCreate;
    }
}