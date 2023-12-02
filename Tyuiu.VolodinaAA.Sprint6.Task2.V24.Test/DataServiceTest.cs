using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint6.Task2.V24.Lib;

namespace Tyuiu.VolodinaAA.Sprint6.Task2.V24.Test
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

            wait[0] = -8.86;
            wait[1] = -7.19;
            wait[2] = -6.14;
            wait[3] = -4.76;
            wait[4] = -2.33;
            wait[5] = 1.00;
            wait[6] = 4.38;
            wait[7] = 6.13;
            wait[8] = 7.07;
            wait[9] = 8.61;
            wait[10] = 0;

            CollectionAssert.AreEqual(wait, valueArray);
        }
    }
}
