using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VolodinaAA.Sprint6.Task4.V20.Lib
{
    public class DataService : ISprint6Task4V20
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];

            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = (Math.Sin(x) - 2 * x) / (3 * x - 1) + Math.Sin(x) - stopValue * x + 2;
                y = Math.Round(y, 3);

                if (!double.IsNaN(y) && !double.IsInfinity(y))
                {
                    valueArray[count] = y;
                    count++;
                }
                else
                {
                    valueArray[count] = 0;
                }
            }
            return valueArray;
        }
    }
}
