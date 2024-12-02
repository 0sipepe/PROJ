namespace TsvetovoyKod
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
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMode = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.cdLine = new System.Windows.Forms.ColorDialog();
            this.cdFill = new System.Windows.Forms.ColorDialog();
            this.pbDrawing = new System.Windows.Forms.PictureBox();
            this.pbTask = new System.Windows.Forms.PictureBox();
            this.btnCheckResult = new System.Windows.Forms.Button();
            this.btnInstriction = new System.Windows.Forms.Button();
            this.btnLevelUp = new System.Windows.Forms.Button();
            this.btnBackFromDrawing = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelUserPlay = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelScorePlay = new System.Windows.Forms.Label();
            this.btnStepBack = new System.Windows.Forms.Button();
            this.btnLevelDown = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTask)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(10, 80);
            this.btnCircle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(111, 53);
            this.btnCircle.TabIndex = 0;
            this.btnCircle.Text = "круг";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(10, 427);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 53);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "удалить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMode
            // 
            this.btnMode.Location = new System.Drawing.Point(10, 369);
            this.btnMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(111, 53);
            this.btnMode.TabIndex = 3;
            this.btnMode.Text = "режим";
            this.btnMode.UseVisualStyleBackColor = true;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(10, 254);
            this.btnFill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(111, 53);
            this.btnFill.TabIndex = 4;
            this.btnFill.Text = "цвет линии";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(10, 311);
            this.btnLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(111, 53);
            this.btnLine.TabIndex = 5;
            this.btnLine.Text = "цвет заливки";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(10, 196);
            this.btnTriangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(111, 53);
            this.btnTriangle.TabIndex = 6;
            this.btnTriangle.Text = "треугольник";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(10, 138);
            this.btnRectangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(111, 53);
            this.btnRectangle.TabIndex = 7;
            this.btnRectangle.Text = "прямоугольник";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // pbDrawing
            // 
            this.pbDrawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDrawing.Location = new System.Drawing.Point(157, 80);
            this.pbDrawing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbDrawing.Name = "pbDrawing";
            this.pbDrawing.Size = new System.Drawing.Size(424, 407);
            this.pbDrawing.TabIndex = 8;
            this.pbDrawing.TabStop = false;
            this.pbDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.pbDrawing_Paint);
            this.pbDrawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbDrawing_MouseDown);
            this.pbDrawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbDrawing_MouseMove);
            this.pbDrawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbDrawing_MouseUp);
            // 
            // pbTask
            // 
            this.pbTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTask.Location = new System.Drawing.Point(608, 80);
            this.pbTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbTask.Name = "pbTask";
            this.pbTask.Size = this.pbDrawing.Size;
            this.pbTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTask.TabIndex = 9;
            this.pbTask.TabStop = false;
            this.pbTask.WaitOnLoad = true;
            this.pbTask.Click += new System.EventHandler(this.pbTask_Click);
            // 
            // btnCheckResult
            // 
            this.btnCheckResult.Location = new System.Drawing.Point(284, 502);
            this.btnCheckResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckResult.Name = "btnCheckResult";
            this.btnCheckResult.Size = new System.Drawing.Size(567, 41);
            this.btnCheckResult.TabIndex = 10;
            this.btnCheckResult.Text = "проверить результат";
            this.btnCheckResult.UseVisualStyleBackColor = true;
            this.btnCheckResult.Click += new System.EventHandler(this.btnCheckResult_Click);
            // 
            // btnInstriction
            // 
            this.btnInstriction.Location = new System.Drawing.Point(10, 520);
            this.btnInstriction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInstriction.Name = "btnInstriction";
            this.btnInstriction.Size = new System.Drawing.Size(39, 24);
            this.btnInstriction.TabIndex = 11;
            this.btnInstriction.Text = "?";
            this.btnInstriction.UseVisualStyleBackColor = true;
            this.btnInstriction.Click += new System.EventHandler(this.btnInstriction_Click);
            // 
            // btnLevelUp
            // 
            this.btnLevelUp.Location = new System.Drawing.Point(958, 503);
            this.btnLevelUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLevelUp.Name = "btnLevelUp";
            this.btnLevelUp.Size = new System.Drawing.Size(74, 41);
            this.btnLevelUp.TabIndex = 12;
            this.btnLevelUp.Text = "уровень вперед";
            this.btnLevelUp.UseVisualStyleBackColor = true;
            this.btnLevelUp.Click += new System.EventHandler(this.btnLevel_Click);
            // 
            // btnBackFromDrawing
            // 
            this.btnBackFromDrawing.Location = new System.Drawing.Point(157, 502);
            this.btnBackFromDrawing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackFromDrawing.Name = "btnBackFromDrawing";
            this.btnBackFromDrawing.Size = new System.Drawing.Size(111, 41);
            this.btnBackFromDrawing.TabIndex = 13;
            this.btnBackFromDrawing.Text = "к меню";
            this.btnBackFromDrawing.UseVisualStyleBackColor = true;
            this.btnBackFromDrawing.Click += new System.EventHandler(this.btnBackFromDrawing_Click);
            // 
            // labelUser
            // 
            this.labelUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUser.Location = new System.Drawing.Point(690, 21);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(173, 25);
            this.labelUser.TabIndex = 14;
            this.labelUser.Text = "пользователь:";
            // 
            // labelUserPlay
            // 
            this.labelUserPlay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUserPlay.Location = new System.Drawing.Point(877, 21);
            this.labelUserPlay.Name = "labelUserPlay";
            this.labelUserPlay.Size = new System.Drawing.Size(157, 25);
            this.labelUserPlay.TabIndex = 15;
            this.labelUserPlay.Text = "label1";
            // 
            // labelScore
            // 
            this.labelScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelScore.Location = new System.Drawing.Point(690, 46);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(103, 25);
            this.labelScore.TabIndex = 16;
            this.labelScore.Text = "счёт:";
            // 
            // labelScorePlay
            // 
            this.labelScorePlay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelScorePlay.Location = new System.Drawing.Point(877, 46);
            this.labelScorePlay.Name = "labelScorePlay";
            this.labelScorePlay.Size = new System.Drawing.Size(157, 25);
            this.labelScorePlay.TabIndex = 17;
            this.labelScorePlay.Text = "label1";
            // 
            // btnStepBack
            // 
            this.btnStepBack.Location = new System.Drawing.Point(157, 80);
            this.btnStepBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStepBack.Name = "btnStepBack";
            this.btnStepBack.Size = new System.Drawing.Size(87, 28);
            this.btnStepBack.TabIndex = 18;
            this.btnStepBack.Text = "назад";
            this.btnStepBack.UseVisualStyleBackColor = true;
            this.btnStepBack.Click += new System.EventHandler(this.btnStepBack_Click);
            // 
            // btnLevelDown
            // 
            this.btnLevelDown.Location = new System.Drawing.Point(871, 503);
            this.btnLevelDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLevelDown.Name = "btnLevelDown";
            this.btnLevelDown.Size = new System.Drawing.Size(77, 41);
            this.btnLevelDown.TabIndex = 19;
            this.btnLevelDown.Text = "уровень назад";
            this.btnLevelDown.UseVisualStyleBackColor = true;
            this.btnLevelDown.Click += new System.EventHandler(this.btnLevelDown_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitle.Location = new System.Drawing.Point(157, 21);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(237, 35);
            this.labelTitle.TabIndex = 20;
            this.labelTitle.Text = "Уровень: ";
            // 
            // labelLevel
            // 
            this.labelLevel.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLevel.Location = new System.Drawing.Point(400, 21);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(84, 35);
            this.labelLevel.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TsvetovoyKod.Properties.Resources.фон;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 550);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.btnLevelDown);
            this.Controls.Add(this.btnStepBack);
            this.Controls.Add(this.labelScorePlay);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelUserPlay);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.btnBackFromDrawing);
            this.Controls.Add(this.btnLevelUp);
            this.Controls.Add(this.btnInstriction);
            this.Controls.Add(this.btnCheckResult);
            this.Controls.Add(this.pbTask);
            this.Controls.Add(this.pbDrawing);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.btnTriangle);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCircle);
            this.Font = new System.Drawing.Font("MS Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Главный Экран Рисования";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.ColorDialog cdLine;
        private System.Windows.Forms.ColorDialog cdFill;
        private System.Windows.Forms.PictureBox pbDrawing;
        private System.Windows.Forms.PictureBox pbTask;
        private System.Windows.Forms.Button btnCheckResult;
        private System.Windows.Forms.Button btnInstriction;
        private System.Windows.Forms.Button btnLevelUp;
        private System.Windows.Forms.Button btnBackFromDrawing;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelUserPlay;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelScorePlay;
        private System.Windows.Forms.Button btnStepBack;
        private System.Windows.Forms.Button btnLevelDown;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelLevel;
    }
}

