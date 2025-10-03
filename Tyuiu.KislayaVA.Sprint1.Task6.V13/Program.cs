using Tyuiu.KislayaVA.Sprint1.Task6.V13.Lib;
namespace Tyuiu.KislayaVA.Sprint1.Task6.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Кислая В. А. | РППб25-1";
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* Спринт #1                                                           *");
            Console.WriteLine("* Тема: Работа со строками класс String                               *");
            Console.WriteLine("* Задание #6                                                          *");
            Console.WriteLine("* Вариант #13                                                         *");
            Console.WriteLine("* Выполнила: Кислая В. А.  |  РППб25-1                                *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                            *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что буквы *");
            Console.WriteLine("* строки упорядочены по алфавиту.                                     *");
            Console.WriteLine("*                                                                     *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                    *");
            Console.WriteLine("***********************************************************************");

            string lines;
            Console.WriteLine("Введите текст: ");
            lines = Console.ReadLine();

            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                          *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine(ds.CheckWordsAlphabet(lines));

        }
    }
}