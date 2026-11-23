using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PonkratevMM.Sprint5.Task0.V27.Lib;

namespace Tyuiu.PonkratevMM.Sprint5.Task0.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckSaveToFileTextData()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(3);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.IsTrue(fileExists);

            string content = File.ReadAllText(path);
            Assert.AreEqual("1024,000", content);
        }
    }
}