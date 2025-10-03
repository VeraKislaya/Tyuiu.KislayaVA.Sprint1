using Tyuiu.KislayaVA.Sprint1.Task7.V12.Lib;
namespace Tyuiu.KislayaVA.Sprint1.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(45, ds.Calculate(2, 1));
        }
    }
}
