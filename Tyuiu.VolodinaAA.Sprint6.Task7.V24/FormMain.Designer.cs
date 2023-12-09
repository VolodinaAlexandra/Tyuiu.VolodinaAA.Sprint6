
namespace Tyuiu.VolodinaAA.Sprint6.Task7.V24
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons_VAA = new System.Windows.Forms.Panel();
            this.buttonSaveFile_VAA = new System.Windows.Forms.Button();
            this.buttonHelp_VAA = new System.Windows.Forms.Button();
            this.buttonDone_VAA = new System.Windows.Forms.Button();
            this.buttonOpenFile_VAA = new System.Windows.Forms.Button();
            this.panelTask_VAA = new System.Windows.Forms.Panel();
            this.groupBoxTask_VAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_VAA = new System.Windows.Forms.TextBox();
            this.panelInPut_VAA = new System.Windows.Forms.Panel();
            this.groupBoxInPut_VAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_VAA = new System.Windows.Forms.DataGridView();
            this.panelOutPut_VAA = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_VAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_VAA = new System.Windows.Forms.DataGridView();
            this.toolTipButtons_VAA = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog_VAA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_VAA = new System.Windows.Forms.SaveFileDialog();
            this.panelButtons_VAA.SuspendLayout();
            this.panelTask_VAA.SuspendLayout();
            this.groupBoxTask_VAA.SuspendLayout();
            this.panelInPut_VAA.SuspendLayout();
            this.groupBoxInPut_VAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_VAA)).BeginInit();
            this.panelOutPut_VAA.SuspendLayout();
            this.groupBoxOutPut_VAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_VAA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons_VAA
            // 
            this.panelButtons_VAA.BackColor = System.Drawing.Color.PowderBlue;
            this.panelButtons_VAA.Controls.Add(this.buttonSaveFile_VAA);
            this.panelButtons_VAA.Controls.Add(this.buttonHelp_VAA);
            this.panelButtons_VAA.Controls.Add(this.buttonDone_VAA);
            this.panelButtons_VAA.Controls.Add(this.buttonOpenFile_VAA);
            this.panelButtons_VAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_VAA.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_VAA.Name = "panelButtons_VAA";
            this.panelButtons_VAA.Size = new System.Drawing.Size(1083, 73);
            this.panelButtons_VAA.TabIndex = 0;
            // 
            // buttonSaveFile_VAA
            // 
            this.buttonSaveFile_VAA.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSaveFile_VAA.Enabled = false;
            this.buttonSaveFile_VAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_VAA.Image")));
            this.buttonSaveFile_VAA.Location = new System.Drawing.Point(239, 3);
            this.buttonSaveFile_VAA.Name = "buttonSaveFile_VAA";
            this.buttonSaveFile_VAA.Size = new System.Drawing.Size(107, 63);
            this.buttonSaveFile_VAA.TabIndex = 0;
            this.toolTipButtons_VAA.SetToolTip(this.buttonSaveFile_VAA, "Нажмите, чтобы сохранить файл в указанную директорию\r\n");
            this.buttonSaveFile_VAA.UseVisualStyleBackColor = false;
            this.buttonSaveFile_VAA.Click += new System.EventHandler(this.buttonSaveFile_VAA_Click);
            this.buttonSaveFile_VAA.MouseEnter += new System.EventHandler(this.buttonSaveFile_VAA_MouseEnter);
            // 
            // buttonHelp_VAA
            // 
            this.buttonHelp_VAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_VAA.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonHelp_VAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_VAA.Image")));
            this.buttonHelp_VAA.Location = new System.Drawing.Point(964, 4);
            this.buttonHelp_VAA.Name = "buttonHelp_VAA";
            this.buttonHelp_VAA.Size = new System.Drawing.Size(107, 63);
            this.buttonHelp_VAA.TabIndex = 0;
            this.toolTipButtons_VAA.SetToolTip(this.buttonHelp_VAA, "Нажмите, чтобы узнать информацию о разработчике\r\n");
            this.buttonHelp_VAA.UseVisualStyleBackColor = false;
            this.buttonHelp_VAA.Click += new System.EventHandler(this.buttonHelp_VAA_Click);
            this.buttonHelp_VAA.MouseEnter += new System.EventHandler(this.buttonHelp_VAA_MouseEnter);
            // 
            // buttonDone_VAA
            // 
            this.buttonDone_VAA.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDone_VAA.Enabled = false;
            this.buttonDone_VAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_VAA.Image")));
            this.buttonDone_VAA.Location = new System.Drawing.Point(126, 3);
            this.buttonDone_VAA.Name = "buttonDone_VAA";
            this.buttonDone_VAA.Size = new System.Drawing.Size(107, 63);
            this.buttonDone_VAA.TabIndex = 0;
            this.toolTipButtons_VAA.SetToolTip(this.buttonDone_VAA, "Нажмите, чтобы изменить во второй строчке \r\n\r\nматрицы чётные элементы на 1");
            this.buttonDone_VAA.UseVisualStyleBackColor = false;
            this.buttonDone_VAA.Click += new System.EventHandler(this.buttonDone_VAA_Click);
            this.buttonDone_VAA.MouseEnter += new System.EventHandler(this.buttonDone_VAA_MouseEnter);
            // 
            // buttonOpenFile_VAA
            // 
            this.buttonOpenFile_VAA.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOpenFile_VAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_VAA.Image")));
            this.buttonOpenFile_VAA.Location = new System.Drawing.Point(13, 4);
            this.buttonOpenFile_VAA.Name = "buttonOpenFile_VAA";
            this.buttonOpenFile_VAA.Size = new System.Drawing.Size(107, 63);
            this.buttonOpenFile_VAA.TabIndex = 0;
            this.toolTipButtons_VAA.SetToolTip(this.buttonOpenFile_VAA, "Нажмите, чтобы выбрать путь к файлу\r\n");
            this.buttonOpenFile_VAA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_VAA.Click += new System.EventHandler(this.buttonOpenFile_VAA_Click);
            this.buttonOpenFile_VAA.MouseEnter += new System.EventHandler(this.buttonOpenFile_VAA_MouseEnter);
            // 
            // panelTask_VAA
            // 
            this.panelTask_VAA.Controls.Add(this.groupBoxTask_VAA);
            this.panelTask_VAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_VAA.Location = new System.Drawing.Point(0, 73);
            this.panelTask_VAA.Name = "panelTask_VAA";
            this.panelTask_VAA.Size = new System.Drawing.Size(1083, 100);
            this.panelTask_VAA.TabIndex = 1;
            // 
            // groupBoxTask_VAA
            // 
            this.groupBoxTask_VAA.Controls.Add(this.textBoxTask_VAA);
            this.groupBoxTask_VAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_VAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_VAA.Name = "groupBoxTask_VAA";
            this.groupBoxTask_VAA.Size = new System.Drawing.Size(1083, 100);
            this.groupBoxTask_VAA.TabIndex = 0;
            this.groupBoxTask_VAA.TabStop = false;
            this.groupBoxTask_VAA.Text = "Условие";
            // 
            // textBoxTask_VAA
            // 
            this.textBoxTask_VAA.BackColor = System.Drawing.Color.PowderBlue;
            this.textBoxTask_VAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_VAA.Location = new System.Drawing.Point(3, 18);
            this.textBoxTask_VAA.Multiline = true;
            this.textBoxTask_VAA.Name = "textBoxTask_VAA";
            this.textBoxTask_VAA.ReadOnly = true;
            this.textBoxTask_VAA.Size = new System.Drawing.Size(1077, 79);
            this.textBoxTask_VAA.TabIndex = 0;
            this.textBoxTask_VAA.Text = resources.GetString("textBoxTask_VAA.Text");
            // 
            // panelInPut_VAA
            // 
            this.panelInPut_VAA.Controls.Add(this.groupBoxInPut_VAA);
            this.panelInPut_VAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInPut_VAA.Location = new System.Drawing.Point(0, 173);
            this.panelInPut_VAA.Name = "panelInPut_VAA";
            this.panelInPut_VAA.Size = new System.Drawing.Size(531, 417);
            this.panelInPut_VAA.TabIndex = 2;
            // 
            // groupBoxInPut_VAA
            // 
            this.groupBoxInPut_VAA.Controls.Add(this.dataGridViewInPut_VAA);
            this.groupBoxInPut_VAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_VAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_VAA.Name = "groupBoxInPut_VAA";
            this.groupBoxInPut_VAA.Size = new System.Drawing.Size(531, 417);
            this.groupBoxInPut_VAA.TabIndex = 0;
            this.groupBoxInPut_VAA.TabStop = false;
            this.groupBoxInPut_VAA.Text = "Ввод";
            // 
            // dataGridViewInPut_VAA
            // 
            this.dataGridViewInPut_VAA.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dataGridViewInPut_VAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_VAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInPut_VAA.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewInPut_VAA.Name = "dataGridViewInPut_VAA";
            this.dataGridViewInPut_VAA.RowHeadersVisible = false;
            this.dataGridViewInPut_VAA.RowHeadersWidth = 51;
            this.dataGridViewInPut_VAA.RowTemplate.Height = 24;
            this.dataGridViewInPut_VAA.Size = new System.Drawing.Size(525, 396);
            this.dataGridViewInPut_VAA.TabIndex = 0;
            // 
            // panelOutPut_VAA
            // 
            this.panelOutPut_VAA.Controls.Add(this.groupBoxOutPut_VAA);
            this.panelOutPut_VAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutPut_VAA.Location = new System.Drawing.Point(531, 173);
            this.panelOutPut_VAA.Name = "panelOutPut_VAA";
            this.panelOutPut_VAA.Size = new System.Drawing.Size(552, 417);
            this.panelOutPut_VAA.TabIndex = 3;
            // 
            // groupBoxOutPut_VAA
            // 
            this.groupBoxOutPut_VAA.Controls.Add(this.dataGridViewOutPut_VAA);
            this.groupBoxOutPut_VAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_VAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_VAA.Name = "groupBoxOutPut_VAA";
            this.groupBoxOutPut_VAA.Size = new System.Drawing.Size(552, 417);
            this.groupBoxOutPut_VAA.TabIndex = 0;
            this.groupBoxOutPut_VAA.TabStop = false;
            this.groupBoxOutPut_VAA.Text = "Вывод";
            // 
            // dataGridViewOutPut_VAA
            // 
            this.dataGridViewOutPut_VAA.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dataGridViewOutPut_VAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_VAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutPut_VAA.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewOutPut_VAA.Name = "dataGridViewOutPut_VAA";
            this.dataGridViewOutPut_VAA.RowHeadersVisible = false;
            this.dataGridViewOutPut_VAA.RowHeadersWidth = 51;
            this.dataGridViewOutPut_VAA.RowTemplate.Height = 24;
            this.dataGridViewOutPut_VAA.Size = new System.Drawing.Size(546, 396);
            this.dataGridViewOutPut_VAA.TabIndex = 0;
            // 
            // toolTipButtons_VAA
            // 
            this.toolTipButtons_VAA.IsBalloon = true;
            this.toolTipButtons_VAA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // openFileDialog_VAA
            // 
            this.openFileDialog_VAA.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 590);
            this.Controls.Add(this.panelOutPut_VAA);
            this.Controls.Add(this.panelInPut_VAA);
            this.Controls.Add(this.panelTask_VAA);
            this.Controls.Add(this.panelButtons_VAA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6|Таск 7|Вариант 24|Володина А.А.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelButtons_VAA.ResumeLayout(false);
            this.panelTask_VAA.ResumeLayout(false);
            this.groupBoxTask_VAA.ResumeLayout(false);
            this.groupBoxTask_VAA.PerformLayout();
            this.panelInPut_VAA.ResumeLayout(false);
            this.groupBoxInPut_VAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_VAA)).EndInit();
            this.panelOutPut_VAA.ResumeLayout(false);
            this.groupBoxOutPut_VAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_VAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_VAA;
        private System.Windows.Forms.Button buttonSaveFile_VAA;
        private System.Windows.Forms.Button buttonHelp_VAA;
        private System.Windows.Forms.Button buttonDone_VAA;
        private System.Windows.Forms.Button buttonOpenFile_VAA;
        private System.Windows.Forms.Panel panelTask_VAA;
        private System.Windows.Forms.GroupBox groupBoxTask_VAA;
        private System.Windows.Forms.TextBox textBoxTask_VAA;
        private System.Windows.Forms.Panel panelInPut_VAA;
        private System.Windows.Forms.GroupBox groupBoxInPut_VAA;
        private System.Windows.Forms.DataGridView dataGridViewInPut_VAA;
        private System.Windows.Forms.Panel panelOutPut_VAA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_VAA;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_VAA;
        private System.Windows.Forms.ToolTip toolTipButtons_VAA;
        private System.Windows.Forms.OpenFileDialog openFileDialog_VAA;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_VAA;
    }
}

