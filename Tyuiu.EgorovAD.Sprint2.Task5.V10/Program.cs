using Tyuiu.EgorovAD.Sprint2.Task5.V10.Lib;
namespace Tyuiu.EgorovAD.Sprint2.Task5.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите день:");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц:");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите год:");
            int years = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((day < 1) || (day > 31))
            {
                res = "Введен неверный день";
            }
            else if ((month < 1) || (month > 12))
            {
                res = "Введен неверный месяц";
            }
            else
            {
                res = "Вчерашнее число: " + ds.FindDateOfPreviousDay(years, month, day);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
