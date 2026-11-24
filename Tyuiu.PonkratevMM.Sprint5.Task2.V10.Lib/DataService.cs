using System.Globalization;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PonkratevMM.Sprint5.Task2.V10.Lib
{
    public class DataService : ISprint5Task2V10
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            string fullPath = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            using (StreamWriter sw = new StreamWriter(fullPath, false, Encoding.UTF8))
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        int value = matrix[i, j] > 0 ? 1 : 0;
                        sw.Write(value.ToString(CultureInfo.InvariantCulture));
                        if (j < cols - 1)
                        {
                            sw.Write(";");
                        }
                    }
                    sw.WriteLine();
                }
            }

            return fullPath;
        }
    }
}