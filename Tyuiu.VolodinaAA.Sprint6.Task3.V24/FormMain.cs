using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VolodinaAA.Sprint6.Task3.V24.Lib;

namespace Tyuiu.VolodinaAA.Sprint6.Task3.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] mtrx = new int[5, 5] { {-17, -6, 10, 5, 3},
                                      {-10, -14, 10, -7, -3},
                                      {-19, 9, 8, -17, -9},
                                      {-19, -5, -9, -18, 14},
                                      {17, 12, 11, 12, 2} };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.GetUpperBound(1) + 1;

            dataGridViewMatrix_VAA.ColumnCount = mtrx.GetLength(1);
            dataGridViewMatrix_VAA.RowCount = mtrx.GetLength(0);

            for (int i = 0;i < dataGridViewMatrix_VAA.ColumnCount; i++)
            {
                dataGridViewMatrix_VAA.Columns[i].Width = 52;
            }

            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    dataGridViewMatrix_VAA.Rows[i].Cells[j].Value = mtrx[i, j];
                }
            }
        }

        private void buttonDone_VAA_Click(object sender, EventArgs e)
        {
            mtrx = ds.Calculate(mtrx);

            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    dataGridViewMatrix_VAA.Rows[i].Cells[j].Value = mtrx[i, j];
                }
            }
        }
        private void buttonInfo_VAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выводила студентка группы ПКТб-23-1 Володина Александра Александровна", "Вам пришло новое сообщение", MessageBoxButtons.OK);
        }

        private void dataGridViewMatrix_VAA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }
    }
}
