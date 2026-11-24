using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PonkratevMM.Sprint5.Task4.V9.Lib
{
    public class DataService : ISprint5Task4V9
    {
        public double LoadFromDataFile(string path)
        {
            string valueText = File.ReadAllText(path).Trim();
            double x = double.Parse(valueText, CultureInfo.InvariantCulture);

            double y = 1 / Math.Sin(x) + x * x;

            return Math.Round(y, 3);
        }
    }
}
