using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VolodinaAA.Sprint6.Task0.V24.Lib
{
    public class DataService : ISprint6Task0V24  
    {
        public double Calculate(int x)
        {
            double y = Math.Pow((x - 1), (3 * x + 1));
            return Math.Round(y, 3);
        }
    }
}
