using Tyuiu.PonkratevMM.Sprint5.Task7.V8.Lib;

namespace Tyuiu.PonkratevMM.Sprint5.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string inputPath = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V8.txt");
            string content = "ПриВет МиР ёЛка 123";
            ds.WriteToFile(inputPath, content);

            string res = ds.GetResult(inputPath);
            string wait = "привет мир ёлка 123";

            Assert.AreEqual(wait, res);
        }
    }
}
