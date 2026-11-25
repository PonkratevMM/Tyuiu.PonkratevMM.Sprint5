using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PonkratevMM.Sprint5.Task6.V27.Lib
{
    public class DataService : ISprint5Task6V27
    {
        public int LoadFromDataFile(string path)
        {
            string data = File.ReadAllText(path);
            int count = 0;
            foreach (Match match in Regex.Matches(data, @"\d+"))
            {
                if (match.Value.Length == 3) count++;
            }
            return count;
        }
    }
}
