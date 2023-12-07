using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VolodinaAA.Sprint6.Task4.V20.Lib;
using System.IO;

namespace Tyuiu.VolodinaAA.Sprint6.Task4.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_VAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_VAA.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_VAA.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartFunction_VAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_VAA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxOutPutData_VAA.Text = "";

                chartFunction_VAA.Series[0].Points.Clear();

                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_VAA.Series[0].Points.AddXY(startValue, valueArray[i]);
                    textBoxOutPutData_VAA.AppendText(valueArray[i] + Environment.NewLine);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Упс! Вы ввели неправильные данные, попробуйте снова!", "Что-то пошло не так...", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void buttonInfo_VAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы ПКТб-23-1 Володина Александра Александровна", "Вам пришло новое сообщение", MessageBoxButtons.OK);
        }

        private void buttonSave_VAA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V20.txt";
                File.WriteAllText(path, textBoxOutPutData_VAA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " успешно сохранён!\n Открыть его в блокноте?", "Вам пришло новой сообщение!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Произошёл сбой при сохранении файла:( Попробуйте снова!", "Неполадочка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chartFunction_VAA_Click(object sender, EventArgs e)
        {
            //
        }

        private void panelFunction_VAA_Paint(object sender, PaintEventArgs e)
        {
            //
        }
    }
}
