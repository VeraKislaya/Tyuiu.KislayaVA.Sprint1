﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KislayaVA.Sprint1.Task5.V6.Lib
{
    public class DataServise : ISprint1Task5V6
    {
        public int Calculate(int k)
        {
            return (k - 1) % 7 + 1;
        }
    }
}