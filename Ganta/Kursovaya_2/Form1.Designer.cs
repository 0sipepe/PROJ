namespace Kursovaya_2
{
    partial class fTasks
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
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.pnSettings = new System.Windows.Forms.Panel();
            this.gbPerson = new System.Windows.Forms.GroupBox();
            this.btnCurrentPerson = new System.Windows.Forms.Button();
            this.btnCreatePerson = new System.Windows.Forms.Button();
            this.tbPersonName = new System.Windows.Forms.TextBox();
            this.btnForward = new System.Windows.Forms.Button();
            this.tbTaskName = new System.Windows.Forms.TextBox();
            this.gbTask = new System.Windows.Forms.GroupBox();
            this.nudComplexity = new System.Windows.Forms.NumericUpDown();
            this.btnToPlan = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbDependentTask = new System.Windows.Forms.GroupBox();
            this.btnCurrentTask = new System.Windows.Forms.Button();
            this.gbPeriod = new System.Windows.Forms.GroupBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnSetPeriod = new System.Windows.Forms.Button();
            this.btnTree = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbPerson.SuspendLayout();
            this.gbTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudComplexity)).BeginInit();
            this.gbDependentTask.SuspendLayout();
            this.gbPeriod.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.Location = new System.Drawing.Point(292, 22);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(148, 50);
            this.btnCreateTask.TabIndex = 0;
            this.btnCreateTask.Text = "создать задачу";
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // pnSettings
            // 
            this.pnSettings.Location = new System.Drawing.Point(6, 7);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Size = new System.Drawing.Size(924, 465);
            this.pnSettings.TabIndex = 1;
            // 
            // gbPerson
            // 
            this.gbPerson.Controls.Add(this.label4);
            this.gbPerson.Controls.Add(this.btnCurrentPerson);
            this.gbPerson.Controls.Add(this.btnCreatePerson);
            this.gbPerson.Controls.Add(this.tbPersonName);
            this.gbPerson.Location = new System.Drawing.Point(603, 612);
            this.gbPerson.Name = "gbPerson";
            this.gbPerson.Size = new System.Drawing.Size(638, 78);
            this.gbPerson.TabIndex = 6;
            this.gbPerson.TabStop = false;
            // 
            // btnCurrentPerson
            // 
            this.btnCurrentPerson.Location = new System.Drawing.Point(487, 46);
            this.btnCurrentPerson.Name = "btnCurrentPerson";
            this.btnCurrentPerson.Size = new System.Drawing.Size(124, 26);
            this.btnCurrentPerson.TabIndex = 4;
            this.btnCurrentPerson.UseVisualStyleBackColor = true;
            // 
            // btnCreatePerson
            // 
            this.btnCreatePerson.Location = new System.Drawing.Point(292, 22);
            this.btnCreatePerson.Name = "btnCreatePerson";
            this.btnCreatePerson.Size = new System.Drawing.Size(148, 50);
            this.btnCreatePerson.TabIndex = 0;
            this.btnCreatePerson.Text = "создать исполнителя";
            this.btnCreatePerson.UseVisualStyleBackColor = true;
            this.btnCreatePerson.Click += new System.EventHandler(this.btnCreatePerson_Click);
            // 
            // tbPersonName
            // 
            this.tbPersonName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbPersonName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbPersonName.Location = new System.Drawing.Point(131, 22);
            this.tbPersonName.Name = "tbPersonName";
            this.tbPersonName.Size = new System.Drawing.Size(155, 22);
            this.tbPersonName.TabIndex = 3;
            this.tbPersonName.Text = "Обязательно";
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(855, 530);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(75, 23);
            this.btnForward.TabIndex = 2;
            this.btnForward.Text = "вперед";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnSwitchGB_Click);
            // 
            // tbTaskName
            // 
            this.tbTaskName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbTaskName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbTaskName.Location = new System.Drawing.Point(131, 22);
            this.tbTaskName.Name = "tbTaskName";
            this.tbTaskName.Size = new System.Drawing.Size(155, 22);
            this.tbTaskName.TabIndex = 3;
            this.tbTaskName.Text = "обязательно";
            // 
            // gbTask
            // 
            this.gbTask.Controls.Add(this.label2);
            this.gbTask.Controls.Add(this.label1);
            this.gbTask.Controls.Add(this.nudComplexity);
            this.gbTask.Controls.Add(this.btnCreateTask);
            this.gbTask.Controls.Add(this.tbTaskName);
            this.gbTask.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbTask.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbTask.Location = new System.Drawing.Point(213, 478);
            this.gbTask.Name = "gbTask";
            this.gbTask.Size = new System.Drawing.Size(446, 78);
            this.gbTask.TabIndex = 5;
            this.gbTask.TabStop = false;
            // 
            // nudComplexity
            // 
            this.nudComplexity.Location = new System.Drawing.Point(131, 48);
            this.nudComplexity.Name = "nudComplexity";
            this.nudComplexity.Size = new System.Drawing.Size(155, 22);
            this.nudComplexity.TabIndex = 4;
            // 
            // btnToPlan
            // 
            this.btnToPlan.Location = new System.Drawing.Point(855, 499);
            this.btnToPlan.Name = "btnToPlan";
            this.btnToPlan.Size = new System.Drawing.Size(75, 23);
            this.btnToPlan.TabIndex = 7;
            this.btnToPlan.Text = "график";
            this.btnToPlan.UseVisualStyleBackColor = true;
            this.btnToPlan.Click += new System.EventHandler(this.btnToPlan_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 530);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbDependentTask
            // 
            this.gbDependentTask.Controls.Add(this.label3);
            this.gbDependentTask.Controls.Add(this.btnCurrentTask);
            this.gbDependentTask.Location = new System.Drawing.Point(213, 566);
            this.gbDependentTask.Name = "gbDependentTask";
            this.gbDependentTask.Size = new System.Drawing.Size(446, 78);
            this.gbDependentTask.TabIndex = 7;
            this.gbDependentTask.TabStop = false;
            // 
            // btnCurrentTask
            // 
            this.btnCurrentTask.Location = new System.Drawing.Point(172, 46);
            this.btnCurrentTask.Name = "btnCurrentTask";
            this.btnCurrentTask.Size = new System.Drawing.Size(124, 26);
            this.btnCurrentTask.TabIndex = 4;
            this.btnCurrentTask.UseVisualStyleBackColor = true;
            // 
            // gbPeriod
            // 
            this.gbPeriod.Controls.Add(this.dtpEnd);
            this.gbPeriod.Controls.Add(this.dtpStart);
            this.gbPeriod.Controls.Add(this.btnSetPeriod);
            this.gbPeriod.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbPeriod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbPeriod.Location = new System.Drawing.Point(951, 93);
            this.gbPeriod.Name = "gbPeriod";
            this.gbPeriod.Size = new System.Drawing.Size(516, 81);
            this.gbPeriod.TabIndex = 6;
            this.gbPeriod.TabStop = false;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(76, 46);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 22);
            this.dtpEnd.TabIndex = 2;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(76, 18);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 22);
            this.dtpStart.TabIndex = 1;
            // 
            // btnSetPeriod
            // 
            this.btnSetPeriod.Location = new System.Drawing.Point(297, 18);
            this.btnSetPeriod.Name = "btnSetPeriod";
            this.btnSetPeriod.Size = new System.Drawing.Size(148, 50);
            this.btnSetPeriod.TabIndex = 0;
            this.btnSetPeriod.Text = "установить промежуток";
            this.btnSetPeriod.UseVisualStyleBackColor = true;
            this.btnSetPeriod.Click += new System.EventHandler(this.btnSetPeriod_Click);
            // 
            // btnTree
            // 
            this.btnTree.Location = new System.Drawing.Point(12, 501);
            this.btnTree.Name = "btnTree";
            this.btnTree.Size = new System.Drawing.Size(75, 23);
            this.btnTree.TabIndex = 9;
            this.btnTree.Text = "дерево";
            this.btnTree.UseVisualStyleBackColor = true;
            this.btnTree.Click += new System.EventHandler(this.btnTree_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "имя";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "сложность";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(188, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "в буфере";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(506, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "в буфере";
            // 
            // fTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 567);
            this.Controls.Add(this.btnTree);
            this.Controls.Add(this.gbPeriod);
            this.Controls.Add(this.gbDependentTask);
            this.Controls.Add(this.gbPerson);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnToPlan);
            this.Controls.Add(this.gbTask);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.pnSettings);
            this.Name = "fTasks";
            this.Text = "Создание задач";
            this.gbPerson.ResumeLayout(false);
            this.gbPerson.PerformLayout();
            this.gbTask.ResumeLayout(false);
            this.gbTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudComplexity)).EndInit();
            this.gbDependentTask.ResumeLayout(false);
            this.gbPeriod.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTask;
        private System.Windows.Forms.Panel pnSettings;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.TextBox tbTaskName;
        private System.Windows.Forms.GroupBox gbTask;
        private System.Windows.Forms.GroupBox gbPerson;
        private System.Windows.Forms.Button btnCreatePerson;
        private System.Windows.Forms.TextBox tbPersonName;
        private System.Windows.Forms.Button btnToPlan;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.NumericUpDown nudComplexity;
        private System.Windows.Forms.Button btnCurrentPerson;
        private System.Windows.Forms.GroupBox gbDependentTask;
        private System.Windows.Forms.Button btnCurrentTask;
        private System.Windows.Forms.GroupBox gbPeriod;
        private System.Windows.Forms.Button btnSetPeriod;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button btnTree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

