using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint6.Task0.V24.Lib;

namespace Tyuiu.VolodinaAA.Sprint6.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            DataService ds = new DataService();  
            double y = ds.Calculate(3);
            double wait = 1024;
            Assert.AreEqual(wait, y);
        }
    }
}
