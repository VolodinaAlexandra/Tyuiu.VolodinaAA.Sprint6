using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VolodinaAA.Sprint6.Task5.V9.Lib;

namespace Tyuiu.VolodinaAA.Sprint6.Task5.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\Users\Александра\source\repos\Tyuiu.VolodinaAA.Sprint6\Tyuiu.VolodinaAA.Sprint6.Task5.V9\bin\Debug\InPutFileTask5V9.txt";

        private void buttonDone_VAA_Click(object sender, EventArgs e)
        {
            dataGridViewOutPutData_VAA.ColumnCount = 2;
            dataGridViewOutPutData_VAA.Columns[0].Width = 20;
            dataGridViewOutPutData_VAA.Columns[1].Width = 50;

            this.chartDiagram_VAA.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartDiagram_VAA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiagram_VAA.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewOutPutData_VAA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiagram_VAA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_VAA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_VAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ПКТб-23-1 Володина Александра Александровна", "Информация о разработчике", MessageBoxButtons.OK);
        }
    }
}
