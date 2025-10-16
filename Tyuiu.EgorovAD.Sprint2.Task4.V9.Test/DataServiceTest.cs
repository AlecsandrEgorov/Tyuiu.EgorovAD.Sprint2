using Tyuiu.EgorovAD.Sprint2.Task4.V9.Lib;
namespace Tyuiu.EgorovAD.Sprint2.Task4.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = -4;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 254.5;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 624.7;
            Assert.AreEqual(wait, res);

        }
    }
}
