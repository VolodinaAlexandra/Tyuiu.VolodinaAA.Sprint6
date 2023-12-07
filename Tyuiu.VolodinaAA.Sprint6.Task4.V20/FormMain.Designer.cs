
namespace Tyuiu.VolodinaAA.Sprint6.Task4.V20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxTask_VAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_VAA = new System.Windows.Forms.TextBox();
            this.groupBoxInputData_VAA = new System.Windows.Forms.GroupBox();
            this.textBoxStartValue_VAA = new System.Windows.Forms.TextBox();
            this.textBoxStopValue_VAA = new System.Windows.Forms.TextBox();
            this.labelStartValue_VAA = new System.Windows.Forms.Label();
            this.labelStopValue_VAA = new System.Windows.Forms.Label();
            this.buttonDone_VAA = new System.Windows.Forms.Button();
            this.buttonSave_VAA = new System.Windows.Forms.Button();
            this.buttonInfo_VAA = new System.Windows.Forms.Button();
            this.groupBoxOutPutData_VAA = new System.Windows.Forms.GroupBox();
            this.textBoxOutPutData_VAA = new System.Windows.Forms.TextBox();
            this.chartFunction_VAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop_VAA = new System.Windows.Forms.Panel();
            this.panelFunction_VAA = new System.Windows.Forms.Panel();
            this.panelResult_VAA = new System.Windows.Forms.Panel();
            this.groupBoxTask_VAA.SuspendLayout();
            this.groupBoxInputData_VAA.SuspendLayout();
            this.groupBoxOutPutData_VAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_VAA)).BeginInit();
            this.panelTop_VAA.SuspendLayout();
            this.panelResult_VAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_VAA
            // 
            this.groupBoxTask_VAA.Controls.Add(this.textBoxTask_VAA);
            this.groupBoxTask_VAA.Location = new System.Drawing.Point(7, 3);
            this.groupBoxTask_VAA.Name = "groupBoxTask_VAA";
            this.groupBoxTask_VAA.Size = new System.Drawing.Size(491, 92);
            this.groupBoxTask_VAA.TabIndex = 0;
            this.groupBoxTask_VAA.TabStop = false;
            this.groupBoxTask_VAA.Text = "Условие";
            // 
            // textBoxTask_VAA
            // 
            this.textBoxTask_VAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_VAA.Location = new System.Drawing.Point(3, 18);
            this.textBoxTask_VAA.Multiline = true;
            this.textBoxTask_VAA.Name = "textBoxTask_VAA";
            this.textBoxTask_VAA.ReadOnly = true;
            this.textBoxTask_VAA.Size = new System.Drawing.Size(485, 71);
            this.textBoxTask_VAA.TabIndex = 0;
            this.textBoxTask_VAA.Text = resources.GetString("textBoxTask_VAA.Text");
            // 
            // groupBoxInputData_VAA
            // 
            this.groupBoxInputData_VAA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxInputData_VAA.Controls.Add(this.labelStopValue_VAA);
            this.groupBoxInputData_VAA.Controls.Add(this.labelStartValue_VAA);
            this.groupBoxInputData_VAA.Controls.Add(this.textBoxStopValue_VAA);
            this.groupBoxInputData_VAA.Controls.Add(this.textBoxStartValue_VAA);
            this.groupBoxInputData_VAA.Location = new System.Drawing.Point(582, 6);
            this.groupBoxInputData_VAA.Name = "groupBoxInputData_VAA";
            this.groupBoxInputData_VAA.Size = new System.Drawing.Size(257, 87);
            this.groupBoxInputData_VAA.TabIndex = 1;
            this.groupBoxInputData_VAA.TabStop = false;
            this.groupBoxInputData_VAA.Text = "Ввод данных";
            // 
            // textBoxStartValue_VAA
            // 
            this.textBoxStartValue_VAA.Location = new System.Drawing.Point(10, 43);
            this.textBoxStartValue_VAA.Name = "textBoxStartValue_VAA";
            this.textBoxStartValue_VAA.Size = new System.Drawing.Size(112, 22);
            this.textBoxStartValue_VAA.TabIndex = 0;
            // 
            // textBoxStopValue_VAA
            // 
            this.textBoxStopValue_VAA.Location = new System.Drawing.Point(138, 42);
            this.textBoxStopValue_VAA.Name = "textBoxStopValue_VAA";
            this.textBoxStopValue_VAA.Size = new System.Drawing.Size(107, 22);
            this.textBoxStopValue_VAA.TabIndex = 1;
            // 
            // labelStartValue_VAA
            // 
            this.labelStartValue_VAA.AutoSize = true;
            this.labelStartValue_VAA.Location = new System.Drawing.Point(7, 22);
            this.labelStartValue_VAA.Name = "labelStartValue_VAA";
            this.labelStartValue_VAA.Size = new System.Drawing.Size(115, 17);
            this.labelStartValue_VAA.TabIndex = 2;
            this.labelStartValue_VAA.Text = "Начало отрезка";
            // 
            // labelStopValue_VAA
            // 
            this.labelStopValue_VAA.AutoSize = true;
            this.labelStopValue_VAA.Location = new System.Drawing.Point(139, 22);
            this.labelStopValue_VAA.Name = "labelStopValue_VAA";
            this.labelStopValue_VAA.Size = new System.Drawing.Size(106, 17);
            this.labelStopValue_VAA.TabIndex = 3;
            this.labelStopValue_VAA.Text = "Конец отрезка";
            // 
            // buttonDone_VAA
            // 
            this.buttonDone_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone_VAA.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonDone_VAA.Location = new System.Drawing.Point(926, 15);
            this.buttonDone_VAA.Name = "buttonDone_VAA";
            this.buttonDone_VAA.Size = new System.Drawing.Size(102, 77);
            this.buttonDone_VAA.TabIndex = 2;
            this.buttonDone_VAA.Text = "Выполнить";
            this.buttonDone_VAA.UseVisualStyleBackColor = false;
            this.buttonDone_VAA.Click += new System.EventHandler(this.buttonDone_VAA_Click);
            // 
            // buttonSave_VAA
            // 
            this.buttonSave_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave_VAA.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonSave_VAA.Location = new System.Drawing.Point(1034, 15);
            this.buttonSave_VAA.Name = "buttonSave_VAA";
            this.buttonSave_VAA.Size = new System.Drawing.Size(99, 77);
            this.buttonSave_VAA.TabIndex = 3;
            this.buttonSave_VAA.Text = "Сохранить";
            this.buttonSave_VAA.UseVisualStyleBackColor = false;
            this.buttonSave_VAA.Click += new System.EventHandler(this.buttonSave_VAA_Click);
            // 
            // buttonInfo_VAA
            // 
            this.buttonInfo_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_VAA.BackColor = System.Drawing.Color.Turquoise;
            this.buttonInfo_VAA.Location = new System.Drawing.Point(1139, 15);
            this.buttonInfo_VAA.Name = "buttonInfo_VAA";
            this.buttonInfo_VAA.Size = new System.Drawing.Size(96, 77);
            this.buttonInfo_VAA.TabIndex = 4;
            this.buttonInfo_VAA.Text = "Справка";
            this.buttonInfo_VAA.UseVisualStyleBackColor = false;
            this.buttonInfo_VAA.Click += new System.EventHandler(this.buttonInfo_VAA_Click);
            // 
            // groupBoxOutPutData_VAA
            // 
            this.groupBoxOutPutData_VAA.Controls.Add(this.textBoxOutPutData_VAA);
            this.groupBoxOutPutData_VAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxOutPutData_VAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPutData_VAA.Name = "groupBoxOutPutData_VAA";
            this.groupBoxOutPutData_VAA.Size = new System.Drawing.Size(290, 543);
            this.groupBoxOutPutData_VAA.TabIndex = 5;
            this.groupBoxOutPutData_VAA.TabStop = false;
            this.groupBoxOutPutData_VAA.Text = "Вывод данных";
            // 
            // textBoxOutPutData_VAA
            // 
            this.textBoxOutPutData_VAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutPutData_VAA.Location = new System.Drawing.Point(3, 18);
            this.textBoxOutPutData_VAA.Multiline = true;
            this.textBoxOutPutData_VAA.Name = "textBoxOutPutData_VAA";
            this.textBoxOutPutData_VAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPutData_VAA.Size = new System.Drawing.Size(284, 522);
            this.textBoxOutPutData_VAA.TabIndex = 0;
            // 
            // chartFunction_VAA
            // 
            chartArea1.Name = "График функции";
            this.chartFunction_VAA.ChartAreas.Add(chartArea1);
            this.chartFunction_VAA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartFunction_VAA.Legends.Add(legend1);
            this.chartFunction_VAA.Location = new System.Drawing.Point(296, 100);
            this.chartFunction_VAA.Name = "chartFunction_VAA";
            this.chartFunction_VAA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "График функции";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "График функции";
            this.chartFunction_VAA.Series.Add(series1);
            this.chartFunction_VAA.Size = new System.Drawing.Size(962, 543);
            this.chartFunction_VAA.TabIndex = 6;
            this.chartFunction_VAA.Text = "График функции";
            title1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "TitleFunction";
            title1.Text = "График функции";
            this.chartFunction_VAA.Titles.Add(title1);
            // 
            // panelTop_VAA
            // 
            this.panelTop_VAA.Controls.Add(this.groupBoxInputData_VAA);
            this.panelTop_VAA.Controls.Add(this.groupBoxTask_VAA);
            this.panelTop_VAA.Controls.Add(this.buttonDone_VAA);
            this.panelTop_VAA.Controls.Add(this.buttonInfo_VAA);
            this.panelTop_VAA.Controls.Add(this.buttonSave_VAA);
            this.panelTop_VAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_VAA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_VAA.Name = "panelTop_VAA";
            this.panelTop_VAA.Size = new System.Drawing.Size(1258, 100);
            this.panelTop_VAA.TabIndex = 7;
            // 
            // panelFunction_VAA
            // 
            this.panelFunction_VAA.AutoSize = true;
            this.panelFunction_VAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFunction_VAA.Location = new System.Drawing.Point(0, 100);
            this.panelFunction_VAA.Name = "panelFunction_VAA";
            this.panelFunction_VAA.Size = new System.Drawing.Size(1258, 543);
            this.panelFunction_VAA.TabIndex = 8;
            // 
            // panelResult_VAA
            // 
            this.panelResult_VAA.Controls.Add(this.groupBoxOutPutData_VAA);
            this.panelResult_VAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelResult_VAA.Location = new System.Drawing.Point(0, 100);
            this.panelResult_VAA.Name = "panelResult_VAA";
            this.panelResult_VAA.Size = new System.Drawing.Size(296, 543);
            this.panelResult_VAA.TabIndex = 9;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 643);
            this.Controls.Add(this.chartFunction_VAA);
            this.Controls.Add(this.panelResult_VAA);
            this.Controls.Add(this.panelFunction_VAA);
            this.Controls.Add(this.panelTop_VAA);
            this.MinimumSize = new System.Drawing.Size(1117, 592);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBoxTask_VAA.ResumeLayout(false);
            this.groupBoxTask_VAA.PerformLayout();
            this.groupBoxInputData_VAA.ResumeLayout(false);
            this.groupBoxInputData_VAA.PerformLayout();
            this.groupBoxOutPutData_VAA.ResumeLayout(false);
            this.groupBoxOutPutData_VAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_VAA)).EndInit();
            this.panelTop_VAA.ResumeLayout(false);
            this.panelResult_VAA.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_VAA;
        private System.Windows.Forms.TextBox textBoxTask_VAA;
        private System.Windows.Forms.GroupBox groupBoxInputData_VAA;
        private System.Windows.Forms.Label labelStopValue_VAA;
        private System.Windows.Forms.Label labelStartValue_VAA;
        private System.Windows.Forms.TextBox textBoxStopValue_VAA;
        private System.Windows.Forms.TextBox textBoxStartValue_VAA;
        private System.Windows.Forms.Button buttonDone_VAA;
        private System.Windows.Forms.Button buttonSave_VAA;
        private System.Windows.Forms.Button buttonInfo_VAA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_VAA;
        private System.Windows.Forms.TextBox textBoxOutPutData_VAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_VAA;
        private System.Windows.Forms.Panel panelTop_VAA;
        private System.Windows.Forms.Panel panelFunction_VAA;
        private System.Windows.Forms.Panel panelResult_VAA;
    }
}

