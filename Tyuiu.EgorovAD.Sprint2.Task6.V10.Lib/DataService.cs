using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.EgorovAD.Sprint2.Task6.V10.Lib
{
    public class DataService : ISprint2Task6V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            if (m < 1 || m > 12 || n < 1 || n > 31)
            {
                throw new ArgumentException("Неправильно указан год, месяц или день");
            }

            int day;
            int month;
            int year;
            string res;

            if (n > 1)
            {
                day = n - 1;
                month = m;
                year = g;
            }
            else
            {
                (day, month, year) = m switch
                {
                    1 => (31, 12, g - 1),
                    2 => (31, 1, g),
                    3 => (28, 2, g),
                    4 => (31, 3, g),
                    5 => (30, 4, g),
                    6 => (31, 5, g),
                    7 => (30, 6, g),
                    8 => (31, 7, g),
                    9 => (31, 8, g),
                    10 => (30, 9, g),
                    11 => (31, 10, g),
                    12 => (30, 11, g),
                    _ => throw new ArgumentException("Неправильно указан год, месяц или день")
                };
            }

            if ((month >= 10) && (day >= 10))
            {
                res = $"{day}.{month}.{year}";
            }
            else if ((month >= 10) && (day < 10))
            {
                res = $"0{day}.{month}.{year}";
            }
            else if ((month < 10) && (day >= 10))
            {
                res = $"{day}.0{month}.{year}";
            }
            else
            {
                res = $"0{day}.0{month}.{year}";
            }

            return res;
        }
    }
}
