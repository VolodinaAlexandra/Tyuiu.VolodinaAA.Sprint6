using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VolodinaAA.Sprint6.Task0.V24.Lib;

namespace Tyuiu.VolodinaAA.Sprint6.Task0.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_VAA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_VAA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_VAA.Text)));
            }
            catch
            {
                MessageBox.Show("Вы ввели неверные данные!", "Уведомление об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_VAA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58)&&(e.KeyChar != ',')&&(e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonInfo_VAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы ПКТб-23-1 Володина Александра Александровна", "Сообщение");
        }
    }
}
