using System.Text;
using System.IO;
using Tyuiu.PonkratevMM.Sprint5.Task7.V8.Lib;

namespace Tyuiu.PonkratevMM.Sprint5.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckLoadDataAndSave()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V8.txt");
            File.WriteAllText(path, "ПриВет МиР, ёЛка 123", Encoding.UTF8);

            string res = ds.LoadDataAndSave(path);
            string expected = "привет мир, ёлка 123";

            Assert.AreEqual(expected, res);
        }
    }
}
