
namespace Tyuiu.VolodinaAA.Sprint6.Task2.V24
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_VAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_VAA = new System.Windows.Forms.TextBox();
            this.groupBoxInputData_VAA = new System.Windows.Forms.GroupBox();
            this.labelStopValue_VAA = new System.Windows.Forms.Label();
            this.labelStartValue_VAA = new System.Windows.Forms.Label();
            this.textBoxStopValue_VAA = new System.Windows.Forms.TextBox();
            this.textBoxStartValue_VAA = new System.Windows.Forms.TextBox();
            this.buttonInfo_VAA = new System.Windows.Forms.Button();
            this.buttonDone_VAA = new System.Windows.Forms.Button();
            this.dataGridViewResult_VAA = new System.Windows.Forms.DataGridView();
            this.groupBoxResult_VAA = new System.Windows.Forms.GroupBox();
            this.chartFunction_VAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTask_VAA.SuspendLayout();
            this.groupBoxInputData_VAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_VAA)).BeginInit();
            this.groupBoxResult_VAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_VAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_VAA
            // 
            this.groupBoxTask_VAA.Controls.Add(this.textBoxTask_VAA);
            this.groupBoxTask_VAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_VAA.Name = "groupBoxTask_VAA";
            this.groupBoxTask_VAA.Size = new System.Drawing.Size(510, 296);
            this.groupBoxTask_VAA.TabIndex = 0;
            this.groupBoxTask_VAA.TabStop = false;
            this.groupBoxTask_VAA.Text = "Условие";
            // 
            // textBoxTask_VAA
            // 
            this.textBoxTask_VAA.BackColor = System.Drawing.Color.Pink;
            this.textBoxTask_VAA.Location = new System.Drawing.Point(7, 22);
            this.textBoxTask_VAA.Multiline = true;
            this.textBoxTask_VAA.Name = "textBoxTask_VAA";
            this.textBoxTask_VAA.Size = new System.Drawing.Size(497, 268);
            this.textBoxTask_VAA.TabIndex = 0;
            this.textBoxTask_VAA.Text = "Протабулировать функцию f(x)=sin(x)+(cos(x)+1)/(2-x)+2x на заданном диапазоне.\r\nР" +
    "езультат вывести в DataGridView и построить график функции\r\n";
            // 
            // groupBoxInputData_VAA
            // 
            this.groupBoxInputData_VAA.Controls.Add(this.labelStopValue_VAA);
            this.groupBoxInputData_VAA.Controls.Add(this.labelStartValue_VAA);
            this.groupBoxInputData_VAA.Controls.Add(this.textBoxStopValue_VAA);
            this.groupBoxInputData_VAA.Controls.Add(this.textBoxStartValue_VAA);
            this.groupBoxInputData_VAA.Location = new System.Drawing.Point(19, 314);
            this.groupBoxInputData_VAA.Name = "groupBoxInputData_VAA";
            this.groupBoxInputData_VAA.Size = new System.Drawing.Size(288, 100);
            this.groupBoxInputData_VAA.TabIndex = 1;
            this.groupBoxInputData_VAA.TabStop = false;
            this.groupBoxInputData_VAA.Text = "Ввод данных";
            // 
            // labelStopValue_VAA
            // 
            this.labelStopValue_VAA.AutoSize = true;
            this.labelStopValue_VAA.Location = new System.Drawing.Point(150, 36);
            this.labelStopValue_VAA.Name = "labelStopValue_VAA";
            this.labelStopValue_VAA.Size = new System.Drawing.Size(106, 17);
            this.labelStopValue_VAA.TabIndex = 3;
            this.labelStopValue_VAA.Text = "Конец отрезка";
            // 
            // labelStartValue_VAA
            // 
            this.labelStartValue_VAA.AutoSize = true;
            this.labelStartValue_VAA.Location = new System.Drawing.Point(14, 36);
            this.labelStartValue_VAA.Name = "labelStartValue_VAA";
            this.labelStartValue_VAA.Size = new System.Drawing.Size(115, 17);
            this.labelStartValue_VAA.TabIndex = 2;
            this.labelStartValue_VAA.Text = "Начало отрезка";
            // 
            // textBoxStopValue_VAA
            // 
            this.textBoxStopValue_VAA.Location = new System.Drawing.Point(153, 56);
            this.textBoxStopValue_VAA.Name = "textBoxStopValue_VAA";
            this.textBoxStopValue_VAA.Size = new System.Drawing.Size(106, 22);
            this.textBoxStopValue_VAA.TabIndex = 1;
            // 
            // textBoxStartValue_VAA
            // 
            this.textBoxStartValue_VAA.Location = new System.Drawing.Point(17, 56);
            this.textBoxStartValue_VAA.Name = "textBoxStartValue_VAA";
            this.textBoxStartValue_VAA.Size = new System.Drawing.Size(112, 22);
            this.textBoxStartValue_VAA.TabIndex = 0;
            // 
            // buttonInfo_VAA
            // 
            this.buttonInfo_VAA.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonInfo_VAA.Location = new System.Drawing.Point(328, 334);
            this.buttonInfo_VAA.Name = "buttonInfo_VAA";
            this.buttonInfo_VAA.Size = new System.Drawing.Size(74, 58);
            this.buttonInfo_VAA.TabIndex = 2;
            this.buttonInfo_VAA.Text = "Справка";
            this.buttonInfo_VAA.UseVisualStyleBackColor = false;
            this.buttonInfo_VAA.Click += new System.EventHandler(this.buttonInfo_VAA_Click);
            // 
            // buttonDone_VAA
            // 
            this.buttonDone_VAA.Location = new System.Drawing.Point(408, 334);
            this.buttonDone_VAA.Name = "buttonDone_VAA";
            this.buttonDone_VAA.Size = new System.Drawing.Size(114, 57);
            this.buttonDone_VAA.TabIndex = 3;
            this.buttonDone_VAA.Text = "Выполнить";
            this.buttonDone_VAA.UseVisualStyleBackColor = true;
            this.buttonDone_VAA.Click += new System.EventHandler(this.buttonDone_VAA_Click);
            this.buttonDone_VAA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_VAA_MouseDown);
            this.buttonDone_VAA.MouseEnter += new System.EventHandler(this.buttonDone_VAA_MouseEnter);
            this.buttonDone_VAA.MouseLeave += new System.EventHandler(this.buttonDone_VAA_MouseLeave);
            // 
            // dataGridViewResult_VAA
            // 
            this.dataGridViewResult_VAA.BackgroundColor = System.Drawing.Color.Pink;
            this.dataGridViewResult_VAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_VAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX,
            this.ColumnFX});
            this.dataGridViewResult_VAA.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewResult_VAA.Name = "dataGridViewResult_VAA";
            this.dataGridViewResult_VAA.RowHeadersVisible = false;
            this.dataGridViewResult_VAA.RowHeadersWidth = 51;
            this.dataGridViewResult_VAA.RowTemplate.Height = 24;
            this.dataGridViewResult_VAA.Size = new System.Drawing.Size(116, 375);
            this.dataGridViewResult_VAA.TabIndex = 4;
            // 
            // groupBoxResult_VAA
            // 
            this.groupBoxResult_VAA.Controls.Add(this.dataGridViewResult_VAA);
            this.groupBoxResult_VAA.Location = new System.Drawing.Point(528, 12);
            this.groupBoxResult_VAA.Name = "groupBoxResult_VAA";
            this.groupBoxResult_VAA.Size = new System.Drawing.Size(128, 402);
            this.groupBoxResult_VAA.TabIndex = 5;
            this.groupBoxResult_VAA.TabStop = false;
            this.groupBoxResult_VAA.Text = "Вывод данных";
            // 
            // chartFunction_VAA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_VAA.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartFunction_VAA.Legends.Add(legend2);
            this.chartFunction_VAA.Location = new System.Drawing.Point(662, 21);
            this.chartFunction_VAA.Name = "chartFunction_VAA";
            this.chartFunction_VAA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_VAA.Series.Add(series2);
            this.chartFunction_VAA.Size = new System.Drawing.Size(418, 393);
            this.chartFunction_VAA.TabIndex = 6;
            // 
            // ColumnX
            // 
            this.ColumnX.HeaderText = "X";
            this.ColumnX.MinimumWidth = 6;
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.Width = 30;
            // 
            // ColumnFX
            // 
            this.ColumnFX.HeaderText = "F(X)";
            this.ColumnFX.MinimumWidth = 6;
            this.ColumnFX.Name = "ColumnFX";
            this.ColumnFX.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1092, 426);
            this.Controls.Add(this.chartFunction_VAA);
            this.Controls.Add(this.groupBoxResult_VAA);
            this.Controls.Add(this.buttonDone_VAA);
            this.Controls.Add(this.buttonInfo_VAA);
            this.Controls.Add(this.groupBoxInputData_VAA);
            this.Controls.Add(this.groupBoxTask_VAA);
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6|Таск 2|Вариант 24|Володина.А.А.";
            this.groupBoxTask_VAA.ResumeLayout(false);
            this.groupBoxTask_VAA.PerformLayout();
            this.groupBoxInputData_VAA.ResumeLayout(false);
            this.groupBoxInputData_VAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_VAA)).EndInit();
            this.groupBoxResult_VAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_VAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_VAA;
        private System.Windows.Forms.TextBox textBoxTask_VAA;
        private System.Windows.Forms.GroupBox groupBoxInputData_VAA;
        private System.Windows.Forms.Label labelStopValue_VAA;
        private System.Windows.Forms.Label labelStartValue_VAA;
        private System.Windows.Forms.TextBox textBoxStopValue_VAA;
        private System.Windows.Forms.TextBox textBoxStartValue_VAA;
        private System.Windows.Forms.Button buttonInfo_VAA;
        private System.Windows.Forms.Button buttonDone_VAA;
        private System.Windows.Forms.DataGridView dataGridViewResult_VAA;
        private System.Windows.Forms.GroupBox groupBoxResult_VAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_VAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFX;
    }
}

