using System.Globalization;
using System.IO;
using Tyuiu.PonkratevMM.Sprint5.Task6.V27.Lib;
namespace Tyuiu.PonkratevMM.Sprint5.Task6.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask6V27.txt");

            DataService ds = new DataService();
            int result = ds.LoadFromDataFile(path);

            Assert.AreEqual(2, result);
        }
    }
}
