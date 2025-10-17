using Tyuiu.EgorovAD.Sprint2.Task5.V10.Lib;
namespace Tyuiu.EgorovAD.Sprint2.Task5.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidDaysname()
        {
            DataService ds = new DataService();
            Assert.AreEqual("15.1.2007", ds.FindDateOfPreviousDay(2007, 1, 16));
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfPreviousDay(2015, 5, 37);
            });

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfPreviousDay(2015, 16, 20);
            });

        }
    }
}
