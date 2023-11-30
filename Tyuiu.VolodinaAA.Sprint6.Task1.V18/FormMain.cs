using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VolodinaAA.Sprint6.Task1.V18.Lib;

namespace Tyuiu.VolodinaAA.Sprint6.Task1.V18
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

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                textBoxOutputData_VAA.Text = "";
                textBoxOutputData_VAA.AppendText("+-----------+-----------+" + Environment.NewLine);
                textBoxOutputData_VAA.AppendText("|     X     |    f(x)   |" + Environment.NewLine);
                textBoxOutputData_VAA.AppendText("+-----------+-----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}      |  {1,7:f2}  |", startValue, valueArray[i]);
                    textBoxOutputData_VAA.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxOutputData_VAA.AppendText("+-----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Упс!Вы ввели неверные данные!Попробуйте снова:)", "Возникла ошибочка...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_VAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ПКТб-23-1 Володина Александра Александровна", "Информация о создателе");
        }
    }
}
