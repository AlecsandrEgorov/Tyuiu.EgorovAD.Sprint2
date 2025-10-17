using Tyuiu.EgorovAD.Sprint2.Task7.V13.Lib;
namespace Tyuiu.EgorovAD.Sprint2.Task7.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение X:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (res)
            {
                Console.WriteLine("Точка находится в закрашенной области");
            }
            else
            {
                Console.WriteLine("Точка находится в не закрашенной области");
            }
            Console.ReadKey();
        }
    }
}
