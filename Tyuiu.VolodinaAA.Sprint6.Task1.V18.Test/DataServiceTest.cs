using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint6.Task1.V18.Lib;

namespace Tyuiu.VolodinaAA.Sprint6.Task1.V18.Test
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

            wait[0] = 70.14;
            wait[1] = 55.21;
            wait[2] = 41.05;
            wait[3] = 27.96;
            wait[4] = 15.48;
            wait[5] = 1.00;
            wait[6] = -13.06;
            wait[7] = -28.16;
            wait[8] = -42.96;
            wait[9] = -56.77;
            wait[10] = -69.83;

            CollectionAssert.AreEqual(wait, valueArray);
        }
    }
}
