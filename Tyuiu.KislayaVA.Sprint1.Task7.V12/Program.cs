using Tyuiu.KislayaVA.Sprint1.Task7.V12.Lib;
namespace Tyuiu.KislayaVA.Sprint1.Task7.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Кислая В. А. | РППб25-1";
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* Спринт #1                                                           *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту             *");
            Console.WriteLine("* Задание #7                                                          *");
            Console.WriteLine("* Вариант #12                                                         *");
            Console.WriteLine("* Выполнила: Кислая В. А.  |  РППб25-1                                *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                            *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение      *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.               *");
            Console.WriteLine("*                                                                     *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                    *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("Введите X:");
            var x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y:");
            var y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                          *");
            Console.WriteLine("***********************************************************************");
            var result = ds.Calculate(x, y);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}