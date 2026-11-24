using System.Globalization;
using System.IO;
using Tyuiu.PonkratevMM.Sprint5.Task5.V22.Lib;

namespace Tyuiu.PonkratevMM.Sprint5.Task5.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckLoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V22.txt";

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            Assert.AreEqual(16, result);
        }
    }
}