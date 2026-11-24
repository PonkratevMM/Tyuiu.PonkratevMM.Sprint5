using Tyuiu.PonkratevMM.Sprint5.Task2.V10.Lib;

namespace Tyuiu.PonkratevMM.Sprint5.Task2.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckSaveToFileTextData()
        {
            int[,] matrix = new int[,] { { 4, 3, -3 }, { -5, -6, -3 }, { -7, -9, -9 } };

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(matrix);

            string[] lines = File.ReadAllLines(path);
            Assert.AreEqual("1;1;0", lines[0].Trim());
            Assert.AreEqual("0;0;0", lines[1].Trim());
            Assert.AreEqual("0;0;0", lines[2].Trim());

            FileInfo fi = new FileInfo(path);
            Assert.IsTrue(fi.Exists);
        }
    }
}