using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint6.Task4.V20.Lib;

namespace Tyuiu.VolodinaAA.Sprint6.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassFunctionValid()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;

            double[] valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);
            double[] wait;
            wait = new double[len];

            wait[0] = 27.274;
            wait[1] = 22.083;
            wait[2] = 16.273;
            wait[3] = 10.649;
            wait[4] = 5.869;
            wait[5] = 2;
            wait[6] = -2.738;
            wait[7] = -7.709;
            wait[8] = -13.591;
            wait[9] = -19.553;
            wait[10] = -24.742;

            CollectionAssert.AreEqual(wait, valueArray);
        }
    }
}
