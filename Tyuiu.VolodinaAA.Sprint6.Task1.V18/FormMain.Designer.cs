
namespace Tyuiu.VolodinaAA.Sprint6.Task1.V18
{
    partial class FormMain
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
            this.groupBoxTask_VAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_VAA = new System.Windows.Forms.TextBox();
            this.groupBoxOutputData_VAA = new System.Windows.Forms.GroupBox();
            this.labelResult_VAA = new System.Windows.Forms.Label();
            this.textBoxOutputData_VAA = new System.Windows.Forms.TextBox();
            this.groupBoxInputData_VAA = new System.Windows.Forms.GroupBox();
            this.labelStopValue_VAA = new System.Windows.Forms.Label();
            this.labelStartValue_VAA = new System.Windows.Forms.Label();
            this.textBoxStopValue_VAA = new System.Windows.Forms.TextBox();
            this.textBoxStartValue_VAA = new System.Windows.Forms.TextBox();
            this.buttonDone_VAA = new System.Windows.Forms.Button();
            this.buttonInfo_VAA = new System.Windows.Forms.Button();
            this.groupBoxTask_VAA.SuspendLayout();
            this.groupBoxOutputData_VAA.SuspendLayout();
            this.groupBoxInputData_VAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_VAA
            // 
            this.groupBoxTask_VAA.Controls.Add(this.textBoxTask_VAA);
            this.groupBoxTask_VAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_VAA.Name = "groupBoxTask_VAA";
            this.groupBoxTask_VAA.Size = new System.Drawing.Size(393, 257);
            this.groupBoxTask_VAA.TabIndex = 0;
            this.groupBoxTask_VAA.TabStop = false;
            this.groupBoxTask_VAA.Text = "Условие";
            // 
            // textBoxTask_VAA
            // 
            this.textBoxTask_VAA.Location = new System.Drawing.Point(6, 21);
            this.textBoxTask_VAA.Multiline = true;
            this.textBoxTask_VAA.Name = "textBoxTask_VAA";
            this.textBoxTask_VAA.ReadOnly = true;
            this.textBoxTask_VAA.Size = new System.Drawing.Size(384, 230);
            this.textBoxTask_VAA.TabIndex = 0;
            this.textBoxTask_VAA.Text = "Протабулировать функцию f(x)=2sin(x)/3x+1.2+cos(x)-7x*2 на заданном диапазоне.\r\nР" +
    "езультат вывести в виде таблицы";
            // 
            // groupBoxOutputData_VAA
            // 
            this.groupBoxOutputData_VAA.Controls.Add(this.labelResult_VAA);
            this.groupBoxOutputData_VAA.Controls.Add(this.textBoxOutputData_VAA);
            this.groupBoxOutputData_VAA.Location = new System.Drawing.Point(420, 12);
            this.groupBoxOutputData_VAA.Name = "groupBoxOutputData_VAA";
            this.groupBoxOutputData_VAA.Size = new System.Drawing.Size(368, 437);
            this.groupBoxOutputData_VAA.TabIndex = 1;
            this.groupBoxOutputData_VAA.TabStop = false;
            this.groupBoxOutputData_VAA.Text = "Вывод данных";
            // 
            // labelResult_VAA
            // 
            this.labelResult_VAA.AutoSize = true;
            this.labelResult_VAA.Location = new System.Drawing.Point(7, 22);
            this.labelResult_VAA.Name = "labelResult_VAA";
            this.labelResult_VAA.Size = new System.Drawing.Size(80, 17);
            this.labelResult_VAA.TabIndex = 1;
            this.labelResult_VAA.Text = "Результат:";
            // 
            // textBoxOutputData_VAA
            // 
            this.textBoxOutputData_VAA.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOutputData_VAA.Location = new System.Drawing.Point(6, 40);
            this.textBoxOutputData_VAA.Multiline = true;
            this.textBoxOutputData_VAA.Name = "textBoxOutputData_VAA";
            this.textBoxOutputData_VAA.ReadOnly = true;
            this.textBoxOutputData_VAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutputData_VAA.Size = new System.Drawing.Size(356, 391);
            this.textBoxOutputData_VAA.TabIndex = 0;
            // 
            // groupBoxInputData_VAA
            // 
            this.groupBoxInputData_VAA.Controls.Add(this.labelStopValue_VAA);
            this.groupBoxInputData_VAA.Controls.Add(this.labelStartValue_VAA);
            this.groupBoxInputData_VAA.Controls.Add(this.textBoxStopValue_VAA);
            this.groupBoxInputData_VAA.Controls.Add(this.textBoxStartValue_VAA);
            this.groupBoxInputData_VAA.Location = new System.Drawing.Point(12, 275);
            this.groupBoxInputData_VAA.Name = "groupBoxInputData_VAA";
            this.groupBoxInputData_VAA.Size = new System.Drawing.Size(189, 152);
            this.groupBoxInputData_VAA.TabIndex = 2;
            this.groupBoxInputData_VAA.TabStop = false;
            this.groupBoxInputData_VAA.Text = "Ввод данных";
            // 
            // labelStopValue_VAA
            // 
            this.labelStopValue_VAA.AutoSize = true;
            this.labelStopValue_VAA.Location = new System.Drawing.Point(7, 83);
            this.labelStopValue_VAA.Name = "labelStopValue_VAA";
            this.labelStopValue_VAA.Size = new System.Drawing.Size(106, 17);
            this.labelStopValue_VAA.TabIndex = 2;
            this.labelStopValue_VAA.Text = "Конец отрезка";
            // 
            // labelStartValue_VAA
            // 
            this.labelStartValue_VAA.AutoSize = true;
            this.labelStartValue_VAA.Location = new System.Drawing.Point(7, 20);
            this.labelStartValue_VAA.Name = "labelStartValue_VAA";
            this.labelStartValue_VAA.Size = new System.Drawing.Size(115, 17);
            this.labelStartValue_VAA.TabIndex = 1;
            this.labelStartValue_VAA.Text = "Начало отрезка";
            // 
            // textBoxStopValue_VAA
            // 
            this.textBoxStopValue_VAA.Location = new System.Drawing.Point(6, 106);
            this.textBoxStopValue_VAA.Name = "textBoxStopValue_VAA";
            this.textBoxStopValue_VAA.Size = new System.Drawing.Size(177, 22);
            this.textBoxStopValue_VAA.TabIndex = 0;
            // 
            // textBoxStartValue_VAA
            // 
            this.textBoxStartValue_VAA.Location = new System.Drawing.Point(7, 43);
            this.textBoxStartValue_VAA.Name = "textBoxStartValue_VAA";
            this.textBoxStartValue_VAA.Size = new System.Drawing.Size(176, 22);
            this.textBoxStartValue_VAA.TabIndex = 0;
            // 
            // buttonDone_VAA
            // 
            this.buttonDone_VAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonDone_VAA.Location = new System.Drawing.Point(220, 285);
            this.buttonDone_VAA.Name = "buttonDone_VAA";
            this.buttonDone_VAA.Size = new System.Drawing.Size(156, 37);
            this.buttonDone_VAA.TabIndex = 3;
            this.buttonDone_VAA.Text = "Выполнить";
            this.buttonDone_VAA.UseVisualStyleBackColor = false;
            this.buttonDone_VAA.Click += new System.EventHandler(this.buttonDone_VAA_Click);
            // 
            // buttonInfo_VAA
            // 
            this.buttonInfo_VAA.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonInfo_VAA.Location = new System.Drawing.Point(220, 328);
            this.buttonInfo_VAA.Name = "buttonInfo_VAA";
            this.buttonInfo_VAA.Size = new System.Drawing.Size(83, 37);
            this.buttonInfo_VAA.TabIndex = 4;
            this.buttonInfo_VAA.Text = "Справка";
            this.buttonInfo_VAA.UseVisualStyleBackColor = false;
            this.buttonInfo_VAA.Click += new System.EventHandler(this.buttonInfo_VAA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInfo_VAA);
            this.Controls.Add(this.buttonDone_VAA);
            this.Controls.Add(this.groupBoxInputData_VAA);
            this.Controls.Add(this.groupBoxOutputData_VAA);
            this.Controls.Add(this.groupBoxTask_VAA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6|Таск 1|Вариант 18|Володина А.А.";
            this.groupBoxTask_VAA.ResumeLayout(false);
            this.groupBoxTask_VAA.PerformLayout();
            this.groupBoxOutputData_VAA.ResumeLayout(false);
            this.groupBoxOutputData_VAA.PerformLayout();
            this.groupBoxInputData_VAA.ResumeLayout(false);
            this.groupBoxInputData_VAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_VAA;
        private System.Windows.Forms.TextBox textBoxTask_VAA;
        private System.Windows.Forms.GroupBox groupBoxOutputData_VAA;
        private System.Windows.Forms.Label labelResult_VAA;
        private System.Windows.Forms.TextBox textBoxOutputData_VAA;
        private System.Windows.Forms.GroupBox groupBoxInputData_VAA;
        private System.Windows.Forms.Label labelStopValue_VAA;
        private System.Windows.Forms.Label labelStartValue_VAA;
        private System.Windows.Forms.TextBox textBoxStopValue_VAA;
        private System.Windows.Forms.TextBox textBoxStartValue_VAA;
        private System.Windows.Forms.Button buttonDone_VAA;
        private System.Windows.Forms.Button buttonInfo_VAA;
    }
}

