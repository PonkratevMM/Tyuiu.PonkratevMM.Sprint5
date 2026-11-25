using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PonkratevMM.Sprint5.Task7.V8.Lib
{
    public class DataService : ISprint5Task7V8
    {
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path, Encoding.UTF8);
            StringBuilder result = new StringBuilder();

            foreach (char c in text)
            {
                if ((c >= 'А' && c <= 'Я') || c == 'Ё')
                {
                    result.Append(char.ToLower(c));
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }
}

