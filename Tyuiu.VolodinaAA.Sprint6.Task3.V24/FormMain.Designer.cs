
namespace Tyuiu.VolodinaAA.Sprint6.Task3.V24
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
            this.buttonDone_VAA = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonInfo_VAA = new System.Windows.Forms.Button();
            this.dataGridViewMatrix_VAA = new System.Windows.Forms.DataGridView();
            this.groupBoxResult_VAA = new System.Windows.Forms.GroupBox();
            this.groupBoxTask_VAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_VAA)).BeginInit();
            this.groupBoxResult_VAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_VAA
            // 
            this.groupBoxTask_VAA.Controls.Add(this.buttonDone_VAA);
            this.groupBoxTask_VAA.Controls.Add(this.textBox1);
            this.groupBoxTask_VAA.Controls.Add(this.buttonInfo_VAA);
            this.groupBoxTask_VAA.Location = new System.Drawing.Point(13, 35);
            this.groupBoxTask_VAA.Name = "groupBoxTask_VAA";
            this.groupBoxTask_VAA.Size = new System.Drawing.Size(321, 335);
            this.groupBoxTask_VAA.TabIndex = 0;
            this.groupBoxTask_VAA.TabStop = false;
            this.groupBoxTask_VAA.Text = "Условие";
            // 
            // buttonDone_VAA
            // 
            this.buttonDone_VAA.Location = new System.Drawing.Point(51, 196);
            this.buttonDone_VAA.Name = "buttonDone_VAA";
            this.buttonDone_VAA.Size = new System.Drawing.Size(116, 34);
            this.buttonDone_VAA.TabIndex = 4;
            this.buttonDone_VAA.Text = "Выполнить";
            this.buttonDone_VAA.UseVisualStyleBackColor = true;
            this.buttonDone_VAA.Click += new System.EventHandler(this.buttonDone_VAA_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(310, 168);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Дана матрица 5 на 5\r\n-17  -6  10   5   3\r\n -10 -14  10  -7  -3\r\n -19   9   8 -17 " +
    " -9\r\n -19  -5  -9 -18  14\r\n  17  12  11  12   2\r\nзаменить четные значения во вто" +
    "рой строке на 0";
            // 
            // buttonInfo_VAA
            // 
            this.buttonInfo_VAA.Location = new System.Drawing.Point(7, 196);
            this.buttonInfo_VAA.Name = "buttonInfo_VAA";
            this.buttonInfo_VAA.Size = new System.Drawing.Size(38, 34);
            this.buttonInfo_VAA.TabIndex = 3;
            this.buttonInfo_VAA.Text = "?";
            this.buttonInfo_VAA.UseVisualStyleBackColor = true;
            this.buttonInfo_VAA.Click += new System.EventHandler(this.buttonInfo_VAA_Click);
            // 
            // dataGridViewMatrix_VAA
            // 
            this.dataGridViewMatrix_VAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_VAA.Location = new System.Drawing.Point(6, 23);
            this.dataGridViewMatrix_VAA.Name = "dataGridViewMatrix_VAA";
            this.dataGridViewMatrix_VAA.ReadOnly = true;
            this.dataGridViewMatrix_VAA.RowHeadersVisible = false;
            this.dataGridViewMatrix_VAA.RowHeadersWidth = 51;
            this.dataGridViewMatrix_VAA.RowTemplate.Height = 24;
            this.dataGridViewMatrix_VAA.Size = new System.Drawing.Size(354, 190);
            this.dataGridViewMatrix_VAA.TabIndex = 1;
            this.dataGridViewMatrix_VAA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatrix_VAA_CellContentClick);
            // 
            // groupBoxResult_VAA
            // 
            this.groupBoxResult_VAA.Controls.Add(this.dataGridViewMatrix_VAA);
            this.groupBoxResult_VAA.Location = new System.Drawing.Point(336, 35);
            this.groupBoxResult_VAA.Name = "groupBoxResult_VAA";
            this.groupBoxResult_VAA.Size = new System.Drawing.Size(374, 223);
            this.groupBoxResult_VAA.TabIndex = 2;
            this.groupBoxResult_VAA.TabStop = false;
            this.groupBoxResult_VAA.Text = "Вывод данных";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 270);
            this.Controls.Add(this.groupBoxResult_VAA);
            this.Controls.Add(this.groupBoxTask_VAA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6|Таск 3|Вариант 24|Володина А.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_VAA.ResumeLayout(false);
            this.groupBoxTask_VAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_VAA)).EndInit();
            this.groupBoxResult_VAA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_VAA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_VAA;
        private System.Windows.Forms.GroupBox groupBoxResult_VAA;
        private System.Windows.Forms.Button buttonInfo_VAA;
        private System.Windows.Forms.Button buttonDone_VAA;
    }
}

