using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.EgorovAD.Sprint2.Task5.V10.Lib
{
    public class DataService : ISprint2Task5V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int day;
            int month;
            int year;
            string res;

            if (g < 1 || m < 1 || m > 12 || n < 1 || n > 31)
            {
                throw new ArgumentException($"Неправильно указан год, месяц или день");
            }

            if (n > 1)
            {
                day = n - 1;
                month = m;
                year = g;
                res = $"{day}.{month}.{year}";
            }
            else
            {
                switch (m)
                {
                    case 1:
                        day = 31;
                        month = 12;
                        year = g - 1;
                        break;
                    case 2:
                        day = 31;
                        month = 1;
                        year = g;
                        break;
                    case 3:
                        day = 28; 
                        month = 2;
                        year = g;
                        break;
                    case 4:
                        day = 31;
                        month = 3;
                        year = g;
                        break;
                    case 5:
                        day = 30;
                        month = 4;
                        year = g;
                        break;
                    case 6:
                        day = 31;
                        month = 5;
                        year = g;
                        break;
                    case 7:
                        day = 30;
                        month = 6;
                        year = g;
                        break;
                    case 8:
                        day = 31;
                        month = 7;
                        year = g;
                        break;
                    case 9:
                        day = 31;
                        month = 8;
                        year = g;
                        break;
                    case 10:
                        day = 30;
                        month = 9;
                        year = g;
                        break;
                    case 11:
                        day = 31;
                        month = 10;
                        year = g;
                        break;
                    case 12:
                        day = 30;
                        month = 11;
                        year = g;
                        break;
                    default:
                        throw new ArgumentException($"Неправильно указан год, месяц или день");
                }
                res = $"{day}.{month}.{year}";
            }

            return res; 
        }
    }
    
}
