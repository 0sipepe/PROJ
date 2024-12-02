namespace Kursovaya_2
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
            this.pnTree = new System.Windows.Forms.Panel();
            this.btnToMain = new System.Windows.Forms.Button();
            this.btnToPlan = new System.Windows.Forms.Button();
            this.btnCriticalPath = new System.Windows.Forms.Button();
            this.btnAllTasks = new System.Windows.Forms.Button();
            this.btnAllWorkers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnTree
            // 
            this.pnTree.Location = new System.Drawing.Point(12, 7);
            this.pnTree.Name = "pnTree";
            this.pnTree.Size = new System.Drawing.Size(883, 500);
            this.pnTree.TabIndex = 1;
            // 
            // btnToMain
            // 
            this.btnToMain.Location = new System.Drawing.Point(12, 515);
            this.btnToMain.Name = "btnToMain";
            this.btnToMain.Size = new System.Drawing.Size(122, 23);
            this.btnToMain.TabIndex = 10;
            this.btnToMain.Text = "назад";
            this.btnToMain.UseVisualStyleBackColor = true;
            this.btnToMain.Click += new System.EventHandler(this.btnToMain_Click);
            // 
            // btnToPlan
            // 
            this.btnToPlan.Location = new System.Drawing.Point(820, 515);
            this.btnToPlan.Name = "btnToPlan";
            this.btnToPlan.Size = new System.Drawing.Size(75, 23);
            this.btnToPlan.TabIndex = 12;
            this.btnToPlan.Text = "график";
            this.btnToPlan.UseVisualStyleBackColor = true;
            this.btnToPlan.Click += new System.EventHandler(this.btnToPlan_Click);
            // 
            // btnCriticalPath
            // 
            this.btnCriticalPath.Location = new System.Drawing.Point(318, 510);
            this.btnCriticalPath.Name = "btnCriticalPath";
            this.btnCriticalPath.Size = new System.Drawing.Size(298, 32);
            this.btnCriticalPath.TabIndex = 13;
            this.btnCriticalPath.Text = "критический путь";
            this.btnCriticalPath.UseVisualStyleBackColor = true;
            this.btnCriticalPath.Click += new System.EventHandler(this.btnCriticalPath_Click);
            // 
            // btnAllTasks
            // 
            this.btnAllTasks.Location = new System.Drawing.Point(200, 510);
            this.btnAllTasks.Name = "btnAllTasks";
            this.btnAllTasks.Size = new System.Drawing.Size(112, 32);
            this.btnAllTasks.TabIndex = 14;
            this.btnAllTasks.Text = "задачи ";
            this.btnAllTasks.UseVisualStyleBackColor = true;
            this.btnAllTasks.Click += new System.EventHandler(this.btnAllTasks_Click);
            // 
            // btnAllWorkers
            // 
            this.btnAllWorkers.Location = new System.Drawing.Point(622, 510);
            this.btnAllWorkers.Name = "btnAllWorkers";
            this.btnAllWorkers.Size = new System.Drawing.Size(112, 32);
            this.btnAllWorkers.TabIndex = 15;
            this.btnAllWorkers.Text = "ребята";
            this.btnAllWorkers.UseVisualStyleBackColor = true;
            this.btnAllWorkers.Click += new System.EventHandler(this.btnAllWorkers_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 550);
            this.Controls.Add(this.btnAllWorkers);
            this.Controls.Add(this.btnAllTasks);
            this.Controls.Add(this.btnCriticalPath);
            this.Controls.Add(this.btnToPlan);
            this.Controls.Add(this.btnToMain);
            this.Controls.Add(this.pnTree);
            this.Name = "Form3";
            this.Text = "Топологическое дерево";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTree;
        private System.Windows.Forms.Button btnToMain;
        private System.Windows.Forms.Button btnToPlan;
        private System.Windows.Forms.Button btnCriticalPath;
        private System.Windows.Forms.Button btnAllTasks;
        private System.Windows.Forms.Button btnAllWorkers;
    }
}