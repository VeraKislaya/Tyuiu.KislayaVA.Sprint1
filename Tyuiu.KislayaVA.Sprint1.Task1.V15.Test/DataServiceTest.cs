﻿using Tyuiu.KislayaVA.Sprint1.Task1.V15.Lib;
namespace Tyuiu.KislayaVA.Sprint1.Task1.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.5;
            var res = ds.Calculate(x);
            Assert.AreEqual(1, res);
        }
    }
}
