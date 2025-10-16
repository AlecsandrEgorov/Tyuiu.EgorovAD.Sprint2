using Tyuiu.EgorovAD.Sprint2.Task3.V6.Lib;
namespace Tyuiu.EgorovAD.Sprint2.Task3.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.75;
            Assert.AreEqual(wait, res);

        }
        
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 5;
            double res = ds.Calculate(x);
            double wait = 9;
            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -1;
            double res = ds.Calculate(x);
            double wait = 2;
            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -11;
            double res = ds.Calculate(x);
            double wait = -120.909;
            Assert.AreEqual(wait, res);

        }
    }
}
