using Tyuiu.EgorovAD.Sprint2.Task2.V27.Lib;
namespace Tyuiu.EgorovAD.Sprint2.Task2.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 11;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);

        }
    }
}
