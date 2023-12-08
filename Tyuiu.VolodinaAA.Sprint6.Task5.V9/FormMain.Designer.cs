
namespace Tyuiu.VolodinaAA.Sprint6.Task5.V9
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_VAA = new System.Windows.Forms.Panel();
            this.buttonOpenFile_VAA = new System.Windows.Forms.Button();
            this.buttonDone_VAA = new System.Windows.Forms.Button();
            this.groupBoxTask_VAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_VAA = new System.Windows.Forms.TextBox();
            this.buttonInfo_VAA = new System.Windows.Forms.Button();
            this.panelOutPutData_VAA = new System.Windows.Forms.Panel();
            this.panelDiagram_VAA = new System.Windows.Forms.Panel();
            this.dataGridViewOutPutData_VAA = new System.Windows.Forms.DataGridView();
            this.labelOutPutData_VAA = new System.Windows.Forms.Label();
            this.chartDiagram_VAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop_VAA.SuspendLayout();
            this.groupBoxTask_VAA.SuspendLayout();
            this.panelOutPutData_VAA.SuspendLayout();
            this.panelDiagram_VAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutData_VAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagram_VAA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_VAA
            // 
            this.panelTop_VAA.Controls.Add(this.buttonInfo_VAA);
            this.panelTop_VAA.Controls.Add(this.buttonOpenFile_VAA);
            this.panelTop_VAA.Controls.Add(this.buttonDone_VAA);
            this.panelTop_VAA.Controls.Add(this.groupBoxTask_VAA);
            this.panelTop_VAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_VAA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_VAA.Name = "panelTop_VAA";
            this.panelTop_VAA.Size = new System.Drawing.Size(1077, 100);
            this.panelTop_VAA.TabIndex = 0;
            // 
            // buttonOpenFile_VAA
            // 
            this.buttonOpenFile_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFile_VAA.BackColor = System.Drawing.Color.IndianRed;
            this.buttonOpenFile_VAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile_VAA.Location = new System.Drawing.Point(807, 12);
            this.buttonOpenFile_VAA.Name = "buttonOpenFile_VAA";
            this.buttonOpenFile_VAA.Size = new System.Drawing.Size(107, 68);
            this.buttonOpenFile_VAA.TabIndex = 2;
            this.buttonOpenFile_VAA.Text = "Открыть файл";
            this.buttonOpenFile_VAA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_VAA.Click += new System.EventHandler(this.buttonOpenFile_VAA_Click);
            // 
            // buttonDone_VAA
            // 
            this.buttonDone_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone_VAA.BackColor = System.Drawing.Color.LightCoral;
            this.buttonDone_VAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_VAA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDone_VAA.Location = new System.Drawing.Point(682, 12);
            this.buttonDone_VAA.Name = "buttonDone_VAA";
            this.buttonDone_VAA.Size = new System.Drawing.Size(107, 68);
            this.buttonDone_VAA.TabIndex = 1;
            this.buttonDone_VAA.Text = "Выполнить";
            this.buttonDone_VAA.UseVisualStyleBackColor = false;
            this.buttonDone_VAA.Click += new System.EventHandler(this.buttonDone_VAA_Click);
            // 
            // groupBoxTask_VAA
            // 
            this.groupBoxTask_VAA.BackColor = System.Drawing.Color.LightCoral;
            this.groupBoxTask_VAA.Controls.Add(this.textBoxTask_VAA);
            this.groupBoxTask_VAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_VAA.Location = new System.Drawing.Point(4, 4);
            this.groupBoxTask_VAA.Name = "groupBoxTask_VAA";
            this.groupBoxTask_VAA.Size = new System.Drawing.Size(643, 93);
            this.groupBoxTask_VAA.TabIndex = 0;
            this.groupBoxTask_VAA.TabStop = false;
            this.groupBoxTask_VAA.Text = "Условие";
            // 
            // textBoxTask_VAA
            // 
            this.textBoxTask_VAA.Location = new System.Drawing.Point(9, 22);
            this.textBoxTask_VAA.Multiline = true;
            this.textBoxTask_VAA.Name = "textBoxTask_VAA";
            this.textBoxTask_VAA.ReadOnly = true;
            this.textBoxTask_VAA.Size = new System.Drawing.Size(628, 65);
            this.textBoxTask_VAA.TabIndex = 0;
            this.textBoxTask_VAA.Text = "Прочитать данные из файла InPutFileTask5V9.txt. Вывести в dataDridView элементы и" +
    "з файла, равные нулю. Построить диаграмму по этим значениям.";
            // 
            // buttonInfo_VAA
            // 
            this.buttonInfo_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_VAA.BackColor = System.Drawing.Color.Firebrick;
            this.buttonInfo_VAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo_VAA.Location = new System.Drawing.Point(929, 12);
            this.buttonInfo_VAA.Name = "buttonInfo_VAA";
            this.buttonInfo_VAA.Size = new System.Drawing.Size(105, 67);
            this.buttonInfo_VAA.TabIndex = 3;
            this.buttonInfo_VAA.Text = "Справка";
            this.buttonInfo_VAA.UseVisualStyleBackColor = false;
            this.buttonInfo_VAA.Click += new System.EventHandler(this.buttonInfo_VAA_Click);
            // 
            // panelOutPutData_VAA
            // 
            this.panelOutPutData_VAA.BackColor = System.Drawing.Color.LightCoral;
            this.panelOutPutData_VAA.Controls.Add(this.labelOutPutData_VAA);
            this.panelOutPutData_VAA.Controls.Add(this.dataGridViewOutPutData_VAA);
            this.panelOutPutData_VAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutPutData_VAA.Location = new System.Drawing.Point(0, 100);
            this.panelOutPutData_VAA.Name = "panelOutPutData_VAA";
            this.panelOutPutData_VAA.Size = new System.Drawing.Size(200, 413);
            this.panelOutPutData_VAA.TabIndex = 1;
            // 
            // panelDiagram_VAA
            // 
            this.panelDiagram_VAA.Controls.Add(this.chartDiagram_VAA);
            this.panelDiagram_VAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDiagram_VAA.Location = new System.Drawing.Point(200, 100);
            this.panelDiagram_VAA.Name = "panelDiagram_VAA";
            this.panelDiagram_VAA.Size = new System.Drawing.Size(877, 413);
            this.panelDiagram_VAA.TabIndex = 2;
            // 
            // dataGridViewOutPutData_VAA
            // 
            this.dataGridViewOutPutData_VAA.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewOutPutData_VAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPutData_VAA.ColumnHeadersVisible = false;
            this.dataGridViewOutPutData_VAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewOutPutData_VAA.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOutPutData_VAA.Name = "dataGridViewOutPutData_VAA";
            this.dataGridViewOutPutData_VAA.RowHeadersVisible = false;
            this.dataGridViewOutPutData_VAA.RowHeadersWidth = 51;
            this.dataGridViewOutPutData_VAA.RowTemplate.Height = 24;
            this.dataGridViewOutPutData_VAA.Size = new System.Drawing.Size(190, 413);
            this.dataGridViewOutPutData_VAA.TabIndex = 0;
            // 
            // labelOutPutData_VAA
            // 
            this.labelOutPutData_VAA.AutoSize = true;
            this.labelOutPutData_VAA.BackColor = System.Drawing.Color.Snow;
            this.labelOutPutData_VAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOutPutData_VAA.Location = new System.Drawing.Point(83, 0);
            this.labelOutPutData_VAA.Name = "labelOutPutData_VAA";
            this.labelOutPutData_VAA.Size = new System.Drawing.Size(114, 17);
            this.labelOutPutData_VAA.TabIndex = 1;
            this.labelOutPutData_VAA.Text = "Вывод данных";
            // 
            // chartDiagram_VAA
            // 
            chartArea8.Name = "ChartArea1";
            this.chartDiagram_VAA.ChartAreas.Add(chartArea8);
            this.chartDiagram_VAA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend8.Enabled = false;
            legend8.Name = "Legend1";
            this.chartDiagram_VAA.Legends.Add(legend8);
            this.chartDiagram_VAA.Location = new System.Drawing.Point(0, 0);
            this.chartDiagram_VAA.Name = "chartDiagram_VAA";
            this.chartDiagram_VAA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartDiagram_VAA.Series.Add(series8);
            this.chartDiagram_VAA.Size = new System.Drawing.Size(877, 413);
            this.chartDiagram_VAA.TabIndex = 0;
            this.chartDiagram_VAA.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1077, 513);
            this.Controls.Add(this.panelDiagram_VAA);
            this.Controls.Add(this.panelOutPutData_VAA);
            this.Controls.Add(this.panelTop_VAA);
            this.MinimumSize = new System.Drawing.Size(1095, 560);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6|Таск 5|Вариант 9|Володина А.А.";
            this.panelTop_VAA.ResumeLayout(false);
            this.groupBoxTask_VAA.ResumeLayout(false);
            this.groupBoxTask_VAA.PerformLayout();
            this.panelOutPutData_VAA.ResumeLayout(false);
            this.panelOutPutData_VAA.PerformLayout();
            this.panelDiagram_VAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutData_VAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagram_VAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_VAA;
        private System.Windows.Forms.Button buttonOpenFile_VAA;
        private System.Windows.Forms.Button buttonDone_VAA;
        private System.Windows.Forms.GroupBox groupBoxTask_VAA;
        private System.Windows.Forms.TextBox textBoxTask_VAA;
        private System.Windows.Forms.Button buttonInfo_VAA;
        private System.Windows.Forms.Panel panelOutPutData_VAA;
        private System.Windows.Forms.Label labelOutPutData_VAA;
        private System.Windows.Forms.DataGridView dataGridViewOutPutData_VAA;
        private System.Windows.Forms.Panel panelDiagram_VAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagram_VAA;
    }
}

