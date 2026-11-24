using System.IO;
using Tyuiu.PonkratevMM.Sprint5.Task3.V9.Lib;

namespace Tyuiu.PonkratevMM.Sprint5.Task3.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckSaveToFileTextData()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(3);

            FileInfo fi = new FileInfo(path);
            Assert.IsTrue(fi.Exists);
        }
    }
}