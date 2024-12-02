namespace Kursovaya_2
{
    partial class form2
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
            this.pnGanta = new System.Windows.Forms.Panel();
            this.btnToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnGanta
            // 
            this.pnGanta.Location = new System.Drawing.Point(64, 54);
            this.pnGanta.Name = "pnGanta";
            this.pnGanta.Size = new System.Drawing.Size(891, 475);
            this.pnGanta.TabIndex = 0;
            this.pnGanta.Paint += new System.Windows.Forms.PaintEventHandler(this.pnGanta_Paint);
            // 
            // btnToMain
            // 
            this.btnToMain.Location = new System.Drawing.Point(12, 545);
            this.btnToMain.Name = "btnToMain";
            this.btnToMain.Size = new System.Drawing.Size(107, 23);
            this.btnToMain.TabIndex = 10;
            this.btnToMain.Text = "дерево";
            this.btnToMain.UseVisualStyleBackColor = true;
            this.btnToMain.Click += new System.EventHandler(this.btnToMain_Click);
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 580);
            this.Controls.Add(this.btnToMain);
            this.Controls.Add(this.pnGanta);
            this.Name = "form2";
            this.Text = "Диаграмма Ганта";
            this.Load += new System.EventHandler(this.form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form2_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnToMain;
        internal System.Windows.Forms.Panel pnGanta;
    }
}