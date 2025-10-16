using Tyuiu.EgorovAD.Sprint2.Task3.V6.Lib;
namespace Tyuiu.EgorovAD.Sprint2.Task3.V6
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
            double res = ds.Calculate(x);



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Значение функции =" + res);
            Console.ReadKey();
        }
    }
}
