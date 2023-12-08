using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint6.Task6.V20.Lib;
using System.IO;

namespace Tyuiu.VolodinaAA.Sprint6.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCollectTextFromFileValid()
        {
            string path = @"C:\Users\Александра\source\repos\Tyuiu.VolodinaAA.Sprint6\Tyuiu.VolodinaAA.Sprint6.Task6.V20\bin\Debug\InPutFileTask6V20.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait1 = true;
            Assert.AreEqual(wait1, fileExists);
        }
    }
}
