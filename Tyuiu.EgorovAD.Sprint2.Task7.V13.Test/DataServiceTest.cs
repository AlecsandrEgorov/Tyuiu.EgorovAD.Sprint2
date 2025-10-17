using Tyuiu.EgorovAD.Sprint2.Task7.V13.Lib;
namespace Tyuiu.EgorovAD.Sprint2.Task7.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheck()
        {
            DataService ds = new DataService();

            double x = 0.7;
            double y = 0.7;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
