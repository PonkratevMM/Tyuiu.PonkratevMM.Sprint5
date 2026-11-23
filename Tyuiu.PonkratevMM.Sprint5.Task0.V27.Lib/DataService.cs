using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.PonkratevMM.Sprint5.Task0.V27.Lib

{
    public class DataService : ISprint5Task0V27
    {
        public string SaveToFileTextData(int x)
        {
            double y = Math.Pow(x - 1, 3 * x + 1);
            double result = Math.Round(y, 3);

            string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "OutPutFileTask0.txt");

            File.WriteAllText(fullPath, result.ToString("F3"));
            return fullPath;
        }
    }
}
