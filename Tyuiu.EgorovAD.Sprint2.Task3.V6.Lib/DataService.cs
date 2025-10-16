using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.EgorovAD.Sprint2.Task3.V6.Lib
{
    public class DataService : ISprint2Task3V6
    {
        public double Calculate(double x)
        {
            double y = 0;
            double g = 0;
            if (x > 0)
            {
                g = (x - 15) / (x - 10);
                y = x + Math.Pow(g, x - 3);

            }
            else if (x == 0)
            {
                y = (Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12);
            }
            else if (x < 0 && x > -10)
            {
                y = Math.Pow(x, 4) + 1 / Math.Pow(x, 2);

            }
            else if (x < -10)
            {
                y = x + 10 * x - (1 / x);
            }
                return Math.Round(y, 3); 
        }
    }
}
