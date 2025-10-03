using Tyuiu.KislayaVA.Sprint1.Task2.V23.Lib;
namespace Tyuiu.KislayaVA.Sprint1.Task2.V23
{
    internal class Progran
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Кислая В. А. | РППб25-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                    *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                          *");
            Console.WriteLine("* Задание #2                                                                   *");
            Console.WriteLine("* Вариант #23                                                                  *");
            Console.WriteLine("* Выполнила: Кислая В. А. | РППб25-1                                           *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,      *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                  *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("*ИСКХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            int x;
            Console.WriteLine("Введите время в минутах: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                    *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Время в секундах = " + ds.ConvertMinutesToSeconds(x));
            Console.ReadLine();
        }
    }
}