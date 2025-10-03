using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KislayaVA.Sprint1.Task7.V12.Lib
{
    public class DataService : ISprint1Task7V12
    {
        public double Calculate(double x, double y)
        {
            var z = Math.Pow((x + 1) / (x - 1), x) + 18 * x * y * y;
            return Math.Round(z, 3);
        }
    }
}
