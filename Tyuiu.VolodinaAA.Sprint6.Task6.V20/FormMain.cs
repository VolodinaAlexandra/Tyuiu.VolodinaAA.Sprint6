using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VolodinaAA.Sprint6.Task6.V20.Lib;
using System.IO;

namespace Tyuiu.VolodinaAA.Sprint6.Task6.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonDone_VAA_Click(object sender, EventArgs e)
        {
            textBoxResult_VAA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonOpenFile_VAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxLoadFromFile_VAA.Text = File.ReadAllText(openFilePath);
            groupBoxOutput_VAA.Text = groupBoxOutput_VAA.Text + " " + openFileDialogTask.FileName; ;
            buttonDone_VAA.Enabled = true;
        }

        private void buttonInfo_VAA_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }
    }
}
