using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VolodinaAA.Sprint6.Task7.V24.Lib;
using System.IO;

namespace Tyuiu.VolodinaAA.Sprint6.Task7.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_VAA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_VAA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public int[,] LoadFromData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }
        private void buttonOpenFile_VAA_Click(object sender, EventArgs e)
        {
            openFileDialog_VAA.ShowDialog();
            openFilePath = openFileDialog_VAA.FileName;

            int[,] matrix = new int[rows, columns];
            matrix = LoadFromData(openFilePath);

            dataGridViewInPut_VAA.ColumnCount = columns;
            dataGridViewInPut_VAA.RowCount = rows;
            dataGridViewOutPut_VAA.ColumnCount = columns;
            dataGridViewOutPut_VAA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_VAA.Columns[i].Width = 50;
                dataGridViewOutPut_VAA.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPut_VAA.Rows[r].Cells[c].Value = matrix[r, c];
                }
            }

            matrix = ds.GetMatrix(openFilePath);
            buttonDone_VAA.Enabled = true;
        }

        private void buttonDone_VAA_Click(object sender, EventArgs e)
        {
            int[,] mtrx = new int[rows, columns];
            mtrx = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut_VAA.Rows[r].Cells[c].Value = mtrx[r, c];
                }
            }
            buttonSaveFile_VAA.Enabled = true;
        }

        private void buttonSaveFile_VAA_Click(object sender, EventArgs e)
        {
            saveFileDialog_VAA.FileName = "OutPutFileTask7V24.csv";
            saveFileDialog_VAA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_VAA.ShowDialog();

            string path = saveFileDialog_VAA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_VAA.RowCount;
            int columns = dataGridViewOutPut_VAA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_VAA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_VAA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInPut_VAA.ColumnCount = 50;
            dataGridViewOutPut_VAA.ColumnCount = 50;

            dataGridViewInPut_VAA.RowCount = 50;
            dataGridViewOutPut_VAA.RowCount = 50;

            panelInPut_VAA.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInPut_VAA.Columns[i].Width = 50;
                dataGridViewOutPut_VAA.Columns[i].Width = 50;
            }
        }
        private void buttonOpenFile_VAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_VAA.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_VAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_VAA.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_VAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_VAA.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_VAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_VAA.ToolTipTitle = "Сведения";
        }


        private void buttonHelp_VAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
