using System;
using System.IO;
using System.Text;

namespace Tyuiu.PonkratevMM.Sprint5.Task7.V8.Lib
{
    public class DataService
    {
        public string ReadFile(string path)
        {
            return File.ReadAllText(path, Encoding.UTF8);
        }

        public string GetResult(string path)
        {
            string text = File.ReadAllText(path, Encoding.UTF8);
            char[] result = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if ((c >= 'А' && c <= 'Я') || c == 'Ё')
                {
                    result[i] = char.ToLower(c);
                }
                else
                {
                    result[i] = c;
                }
            }

            return new string(result);
        }

        public void WriteToFile(string path, string content)
        {
            File.WriteAllText(path, content, Encoding.UTF8);
        }
    }
}