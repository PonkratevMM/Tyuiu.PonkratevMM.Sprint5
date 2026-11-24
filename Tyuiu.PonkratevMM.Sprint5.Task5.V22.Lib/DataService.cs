using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PonkratevMM.Sprint5.Task5.V22.Lib
{
    public class DataService : ISprint5Task5V22
    {
        public double LoadFromDataFile(string path)
        {
            string[] parts = File.ReadAllText(path).Split(new[] { ' ', ';', '\t', '\n', '\r' },
                StringSplitOptions.RemoveEmptyEntries);

            double min = double.MaxValue;
            foreach (string part in parts)
            {
                double v = double.Parse(part, CultureInfo.InvariantCulture);
                bool isInteger = v == Math.Floor(v);
                if (isInteger && v % 4 == 0)
                {
                    if (v < min) min = v;
                }
            }

            return min;
        }
    }
}