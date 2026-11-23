using Tyuiu.PonkratevMM.Sprint5.Task1.V21.Lib;
namespace Tyuiu.PonkratevMM.Sprint5.Task1.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckSaveToFileTextData()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(-5, 5);

            FileInfo fi = new FileInfo(path);
            Assert.IsTrue(fi.Exists);
        }
    }
}
