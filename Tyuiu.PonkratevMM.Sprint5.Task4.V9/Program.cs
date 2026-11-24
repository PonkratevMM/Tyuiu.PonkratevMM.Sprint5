using System.Globalization;
using System.IO;
using Tyuiu.PonkratevMM.Sprint5.Task4.V9.Lib;

namespace Tyuiu.PonkratevMM.Sprint5.Task4.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Title = "Спринт #5 | Вариант 9 | Таск 4 | Понкратев М.М.";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Работа с файлами                                                  *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Таск #4                                                                 *");
            Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение: y = 1/sin(x) + x^2. Прочитать значение x из файла      *");
            Console.WriteLine("* InPutDataFileTask4V9.txt, вычислить результат, округлить до трёх знаков *");
            Console.WriteLine("* после запятой и вывести на консоль.                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V9.txt";
            string valueText = File.ReadAllText(path).Trim();
            double x = double.Parse(valueText, CultureInfo.InvariantCulture);
            Console.WriteLine($"Считано из файла: x = {x}");

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"y = 1/sin({x}) + {x}^2 = {result:F3}");

            Console.ReadKey();
        }
    }
}