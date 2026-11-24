using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.PonkratevMM.Sprint5.Task3.V9.Lib
{
    public class DataService : ISprint5Task3V9
    {
        public string SaveToFileTextData(int x)
        {
            double y = Math.Round(Math.Pow(x, 3) / (Math.Pow(x, 2) - 1), 3);

            string fullPath = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            using (BinaryWriter bw = new BinaryWriter(File.Open(fullPath, FileMode.Create)))
            {
                bw.Write(y);
            }

            return fullPath;
        }
    }
}
