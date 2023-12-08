using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint6.Task5.V9.Lib;
using System.IO;

namespace Tyuiu.VolodinaAA.Sprint6.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckLoadFromDataFileValid()
        {
            string path = @"C:\Users\Александра\source\repos\Tyuiu.VolodinaAA.Sprint6\Tyuiu.VolodinaAA.Sprint6.Task5.V9\bin\Debug\InPutFileTask5V9.txt";
            DataService ds = new DataService();
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait1 = true;
            Assert.AreEqual(wait1, fileExists);
        }
    }
}
