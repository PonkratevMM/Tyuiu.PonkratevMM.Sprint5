using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.PonkratevMM.Sprint5.Task1.V21.Lib
{
    public class DataService : ISprint5Task1V21
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            int count = Math.Abs(stopValue - startValue) + 1;
            double[] values = new double[count];
            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) - 2 * x;
                double f;
                if (Math.Abs(denominator) < 1e-10)
                {
                    f = 0;
                }
                else
                {
                    f = (2 * x - 3) / denominator + 5 * x - Math.Sin(x);
                }
                values[index] = Math.Round(f, 2);
                index++;
            }

            string fullPath = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            using (StreamWriter sw = new StreamWriter(fullPath))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    sw.WriteLine(values[x - startValue]);
                }
            }

            return fullPath;
        }
    }
}
