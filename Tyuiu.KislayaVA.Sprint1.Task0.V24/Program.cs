﻿using Tyuiu.KislayaVA.Sprint1.Task0.V24.Lib;
namespace Tyuiu.KislayaVA.Sprint1.Task0.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #0 | Выполнила: Кислая В. А. | РППб25-1";
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* Спринт #1                                                           *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                    *");
            Console.WriteLine("* Задание #0                                                          *");
            Console.WriteLine("* Вариант #24                                                         *");
            Console.WriteLine("* Выполнила: Кислая В. А.  |  РППб25-1                                *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                            *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 2*4/4/2+1           *");
            Console.WriteLine("* и печатает результат на экране.                                     *");
            Console.WriteLine("*                                                                     *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*ИСКХОДНЫЕ ДАННЫЕ:                                                    *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* 2 * 4 / 4 / 2 + 1                                                   *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                          *");
            Console.WriteLine("***********************************************************************");

            Console.WriteLine(ds.Calculate());

            Console.ReadLine();

        }
    }
}
