using Tyuiu.EgorovAD.Sprint2.Task1.V19.Lib;
namespace Tyuiu.EgorovAD.Sprint2.Task1.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 696;
            int b = 354;
            int c = 423;
            int d = 957;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] {true, false, true, false, true, false };

            CollectionAssert.AreEqual(wait, res);




        }
    }
}
