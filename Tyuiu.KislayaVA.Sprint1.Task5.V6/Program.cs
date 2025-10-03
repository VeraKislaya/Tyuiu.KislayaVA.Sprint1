using Tyuiu.KislayaVA.Sprint1.Task5.V6.Lib;
namespace Tyuiu.KislayaVA.Sprint1.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataServise ds = new DataServise();

            Console.Title = "Спринт #1 | Выполнила: Кислая В. А. | РППб25-1";
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* Спринт #1                                                           *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                          *");
            Console.WriteLine("* Задание #5                                                          *");
            Console.WriteLine("* Вариант #6                                                          *");
            Console.WriteLine("* Выполнила: Кислая В. А.  |  РППб25-1                                *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                            *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                *");
            Console.WriteLine("* Пусть k – целое от 1 до 365. Присвоить целой переменной n значение  *");
            Console.WriteLine("* 1,2,...,7 в зависимости от того, на какой день недели (понедельник, *");
            Console.WriteLine("* вторник,..., воскресенье) приходится k-й день невисокосного года в  *");
            Console.WriteLine("* котором 1 января – понедельник.                                     *");
            Console.WriteLine("*                                                                     *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                    *");
            Console.WriteLine("***********************************************************************");

            int x;

            Console.WriteLine("Введите день:");
            x = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                          *");
            Console.WriteLine("***********************************************************************");

            Console.WriteLine(ds.Calculate(x));

            Console.ReadLine();
        }
    }
}
