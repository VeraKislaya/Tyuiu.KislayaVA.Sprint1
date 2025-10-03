using System;
using Tyuiu.KislayaVA.Sprint1.Task3.V15.Lib;
namespace Tyuiu.KislayaVA.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double v1 = 30;
            double v2 = 30;
            double S0 = 0;
            double T = 2;
            double res = ds.DistanceOverTime(v1, v2, S0, T);
            Assert.AreEqual(120, res);

        }

    }
}