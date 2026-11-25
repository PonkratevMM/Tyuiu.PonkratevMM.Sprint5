using System;
using System.IO;
using Tyuiu.PonkratevMM.Sprint5.Task7.V8.Lib;

namespace Tyuiu.PonkratevMM.Sprint5.Task7.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask7V8.txt");
            string outPath = Path.Combine(@"C:\DataSprint5", "OutPutDataFileTask7V8.txt");

            Console.Title = "Спринт #5 | Выполнил: Понкратев М. М. | ИИПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Понкратев М. М. | ИИПб-24-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл с набором символьных данных. Заменить все заглавные русские     *");
            Console.WriteLine("* буквы на строчные. Полученный результат сохранить в файл.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Путь к файлу: " + path);
            Console.WriteLine("Содержимое файла:");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.ReadFile(path));
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.GetResult(path);
            ds.WriteToFile(outPath, res);

            Console.WriteLine("Файл сохранён: " + outPath);
            Console.WriteLine("Результат:");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}