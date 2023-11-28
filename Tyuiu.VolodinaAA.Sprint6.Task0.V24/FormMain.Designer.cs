
namespace Tyuiu.VolodinaAA.Sprint6.Task0.V24
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
            this.labelTask_VAA = new System.Windows.Forms.Label();
            this.groupBoxInputData_VAA = new System.Windows.Forms.GroupBox();
            this.textBoxVarX_VAA = new System.Windows.Forms.TextBox();
            this.labelVarX_VAA = new System.Windows.Forms.Label();
            this.groupBoxOutputData_VAA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_VAA = new System.Windows.Forms.TextBox();
            this.labelResult_VAA = new System.Windows.Forms.Label();
            this.pictureBoxFormula_VAA = new System.Windows.Forms.PictureBox();
            this.buttonDone_VAA = new System.Windows.Forms.Button();
            this.buttonInfo_VAA = new System.Windows.Forms.Button();
            this.textBoxTask_VAA = new System.Windows.Forms.TextBox();
            this.groupBoxInputData_VAA.SuspendLayout();
            this.groupBoxOutputData_VAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_VAA)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTask_VAA
            // 
            this.labelTask_VAA.AutoSize = true;
            this.labelTask_VAA.Location = new System.Drawing.Point(22, 18);
            this.labelTask_VAA.Name = "labelTask_VAA";
            this.labelTask_VAA.Size = new System.Drawing.Size(122, 17);
            this.labelTask_VAA.TabIndex = 1;
            this.labelTask_VAA.Text = "Условие задания";
            // 
            // groupBoxInputData_VAA
            // 
            this.groupBoxInputData_VAA.Controls.Add(this.labelVarX_VAA);
            this.groupBoxInputData_VAA.Controls.Add(this.textBoxVarX_VAA);
            this.groupBoxInputData_VAA.Location = new System.Drawing.Point(12, 220);
            this.groupBoxInputData_VAA.Name = "groupBoxInputData_VAA";
            this.groupBoxInputData_VAA.Size = new System.Drawing.Size(190, 89);
            this.groupBoxInputData_VAA.TabIndex = 2;
            this.groupBoxInputData_VAA.TabStop = false;
            this.groupBoxInputData_VAA.Text = "Ввод данных";
            // 
            // textBoxVarX_VAA
            // 
            this.textBoxVarX_VAA.Location = new System.Drawing.Point(9, 42);
            this.textBoxVarX_VAA.Name = "textBoxVarX_VAA";
            this.textBoxVarX_VAA.Size = new System.Drawing.Size(175, 22);
            this.textBoxVarX_VAA.TabIndex = 0;
            this.textBoxVarX_VAA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_VAA_KeyPress);
            // 
            // labelVarX_VAA
            // 
            this.labelVarX_VAA.AutoSize = true;
            this.labelVarX_VAA.Location = new System.Drawing.Point(6, 22);
            this.labelVarX_VAA.Name = "labelVarX_VAA";
            this.labelVarX_VAA.Size = new System.Drawing.Size(108, 17);
            this.labelVarX_VAA.TabIndex = 1;
            this.labelVarX_VAA.Text = "Переменная X:";
            // 
            // groupBoxOutputData_VAA
            // 
            this.groupBoxOutputData_VAA.Controls.Add(this.labelResult_VAA);
            this.groupBoxOutputData_VAA.Controls.Add(this.textBoxResult_VAA);
            this.groupBoxOutputData_VAA.Location = new System.Drawing.Point(208, 220);
            this.groupBoxOutputData_VAA.Name = "groupBoxOutputData_VAA";
            this.groupBoxOutputData_VAA.Size = new System.Drawing.Size(200, 89);
            this.groupBoxOutputData_VAA.TabIndex = 3;
            this.groupBoxOutputData_VAA.TabStop = false;
            this.groupBoxOutputData_VAA.Text = "Вывод данных";
            // 
            // textBoxResult_VAA
            // 
            this.textBoxResult_VAA.Location = new System.Drawing.Point(10, 41);
            this.textBoxResult_VAA.Name = "textBoxResult_VAA";
            this.textBoxResult_VAA.ReadOnly = true;
            this.textBoxResult_VAA.Size = new System.Drawing.Size(175, 22);
            this.textBoxResult_VAA.TabIndex = 0;
            // 
            // labelResult_VAA
            // 
            this.labelResult_VAA.AutoSize = true;
            this.labelResult_VAA.Location = new System.Drawing.Point(7, 21);
            this.labelResult_VAA.Name = "labelResult_VAA";
            this.labelResult_VAA.Size = new System.Drawing.Size(80, 17);
            this.labelResult_VAA.TabIndex = 1;
            this.labelResult_VAA.Text = "Результат:";
            // 
            // pictureBoxFormula_VAA
            // 
            this.pictureBoxFormula_VAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_VAA.Image")));
            this.pictureBoxFormula_VAA.Location = new System.Drawing.Point(428, 51);
            this.pictureBoxFormula_VAA.Name = "pictureBoxFormula_VAA";
            this.pictureBoxFormula_VAA.Size = new System.Drawing.Size(443, 163);
            this.pictureBoxFormula_VAA.TabIndex = 4;
            this.pictureBoxFormula_VAA.TabStop = false;
            // 
            // buttonDone_VAA
            // 
            this.buttonDone_VAA.Location = new System.Drawing.Point(428, 223);
            this.buttonDone_VAA.Name = "buttonDone_VAA";
            this.buttonDone_VAA.Size = new System.Drawing.Size(235, 60);
            this.buttonDone_VAA.TabIndex = 5;
            this.buttonDone_VAA.Text = "Выполнить";
            this.buttonDone_VAA.UseVisualStyleBackColor = true;
            this.buttonDone_VAA.Click += new System.EventHandler(this.buttonDone_VAA_Click);
            // 
            // buttonInfo_VAA
            // 
            this.buttonInfo_VAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_VAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo_VAA.Location = new System.Drawing.Point(692, 223);
            this.buttonInfo_VAA.Name = "buttonInfo_VAA";
            this.buttonInfo_VAA.Size = new System.Drawing.Size(84, 60);
            this.buttonInfo_VAA.TabIndex = 6;
            this.buttonInfo_VAA.Text = "?";
            this.buttonInfo_VAA.UseVisualStyleBackColor = true;
            this.buttonInfo_VAA.Click += new System.EventHandler(this.buttonInfo_VAA_Click);
            // 
            // textBoxTask_VAA
            // 
            this.textBoxTask_VAA.Location = new System.Drawing.Point(25, 51);
            this.textBoxTask_VAA.Multiline = true;
            this.textBoxTask_VAA.Name = "textBoxTask_VAA";
            this.textBoxTask_VAA.Size = new System.Drawing.Size(383, 163);
            this.textBoxTask_VAA.TabIndex = 7;
            this.textBoxTask_VAA.Text = "Вычислить выражение по формуле";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 319);
            this.Controls.Add(this.textBoxTask_VAA);
            this.Controls.Add(this.buttonInfo_VAA);
            this.Controls.Add(this.buttonDone_VAA);
            this.Controls.Add(this.pictureBoxFormula_VAA);
            this.Controls.Add(this.groupBoxOutputData_VAA);
            this.Controls.Add(this.groupBoxInputData_VAA);
            this.Controls.Add(this.labelTask_VAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6|Таск 0|Вариант 24|Володина А.А.";
            this.groupBoxInputData_VAA.ResumeLayout(false);
            this.groupBoxInputData_VAA.PerformLayout();
            this.groupBoxOutputData_VAA.ResumeLayout(false);
            this.groupBoxOutputData_VAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_VAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTask_VAA;
        private System.Windows.Forms.GroupBox groupBoxInputData_VAA;
        private System.Windows.Forms.Label labelVarX_VAA;
        private System.Windows.Forms.TextBox textBoxVarX_VAA;
        private System.Windows.Forms.GroupBox groupBoxOutputData_VAA;
        private System.Windows.Forms.Label labelResult_VAA;
        private System.Windows.Forms.TextBox textBoxResult_VAA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_VAA;
        private System.Windows.Forms.Button buttonDone_VAA;
        private System.Windows.Forms.Button buttonInfo_VAA;
        private System.Windows.Forms.TextBox textBoxTask_VAA;
    }
}

