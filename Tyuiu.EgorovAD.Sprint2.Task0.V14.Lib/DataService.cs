using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.EgorovAD.Sprint2.Task0.V14.Lib
{
    public class DataService : ISprint2Task0V14
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = y + 321 == x;
            res[1] = x < y;
            res[2] = x > y;
            res[3] = x <= y;
            res[4] = x != y;
            res[5] = x - 1000 >= y;
            return res;
        }
    }
}
