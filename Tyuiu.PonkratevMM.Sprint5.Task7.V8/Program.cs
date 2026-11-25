using System;
using System.IO;
using System.Text;
using Tyuiu.PonkratevMM.Sprint5.Task7.V8.Lib;

namespace Tyuiu.PonkratevMM.Sprint5.Task7.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V8.txt");
            string outPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V8.txt");

            Console.Title = "Спринт #5 | Выполнил: Понкратев М. М. | ИИПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Понкратев М. М. | ИИПб-24-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл с набором символьных данных. Заменить все заглавные русские    *");
            Console.WriteLine("* буквы на строчные. Полученный результат сохранить в файл.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string input = File.ReadAllText(path, Encoding.UTF8);
            Console.WriteLine("Путь к файлу: " + path);
            Console.WriteLine("Содержимое входного файла:");
            Console.WriteLine(input);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.LoadDataAndSave(path);
            File.WriteAllText(outPath, res, Encoding.UTF8);

            Console.WriteLine("Файл сохранён: " + outPath);
            Console.WriteLine("Результат:");
            Console.WriteLine(res);
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}