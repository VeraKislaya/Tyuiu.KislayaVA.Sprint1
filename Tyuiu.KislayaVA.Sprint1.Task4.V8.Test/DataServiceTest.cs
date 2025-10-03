using Tyuiu.KislayaVA.Sprint1.Task4.V8.Lib;
namespace Tyuiu.KislayaVA.Sprint1.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(1, 1);
            Assert.AreEqual(0.75, res);
        }
    }
}
