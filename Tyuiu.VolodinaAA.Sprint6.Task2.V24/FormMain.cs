using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VolodinaAA.Sprint6.Task2.V24.Lib;

namespace Tyuiu.VolodinaAA.Sprint6.Task2.V24
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


                this.chartFunction_VAA.Titles.Add("График функции sin(x)+(cos(x)+1)/(2-x)+2x");

                this.chartFunction_VAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_VAA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult_VAA.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));
                    this.chartFunction_VAA.Series[0].Points.AddXY(startValue, valueArray[i]);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Упс! Вы ввели неправильные данные, попробуйте снова!", "Что-то пошло не так...", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void buttonDone_VAA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_VAA.BackColor = Color.DeepPink;
        }

        private void buttonDone_VAA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_VAA.BackColor = Color.HotPink;
        }

        private void buttonDone_VAA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_VAA.BackColor = Color.LightPink;
        }

        private void buttonInfo_VAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выводила студентка группы ПКТб-23-1 Володина Александра Александровна", "Вам пришло новое сообщение",MessageBoxButtons.OK);
        }
    }
}
