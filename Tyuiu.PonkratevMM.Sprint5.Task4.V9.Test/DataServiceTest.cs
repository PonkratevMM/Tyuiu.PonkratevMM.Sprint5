using System.Globalization;
using System.IO;
using Tyuiu.PonkratevMM.Sprint5.Task4.V9.Lib;

namespace Tyuiu.PonkratevMM.Sprint5.Task4.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckLoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V9.txt";

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            Assert.AreEqual(7.572, result);
        }
    }
}