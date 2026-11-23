using System.Globalization;
using System.IO;
using Tyuiu.PonkratevMM.Sprint5.Task1.V21.Lib;
namespace Tyuiu.PonkratevMM.Sprint5.Task1.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Title = "Спринт #5 | Вариант 21 | Таск 1 | Понкратев М.М.";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Работа с файлами                                                  *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Таск #1                                                                 *");
            Console.WriteLine("* Выполнил Понкратьев Матвей Максимович | ИИПб-26                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* F(x) = (2x - 3) / (cos(x) - 2x) + 5x - sin(x) Табулировать функцию      *");
            Console.WriteLine("* на диапазоне [-5; 5] с шагом 1. При делении на ноль вернуть 0.          *");
            Console.WriteLine("* Округлить до двух знаков после запятой.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine($"startValue = {startValue}");
            Console.WriteLine($"stopValue = {stopValue}");

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("    X     |    F(X)    ");
            Console.WriteLine("----------+------------");
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine($"{startValue + i,6:F0}  | {lines[i],10}");
            }

            Console.WriteLine();
            Console.WriteLine($"Файл сохранён: {path}");
            Console.ReadKey();
        }
    }
}