using Tyuiu.BerezkinAA.Sprint2.Task4.V4.Lib;

namespace Tyuiu.BerezkinAA.Sprint2.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 19.041;
            Assert.AreEqual(res, wait);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 100.284;
            Assert.AreEqual(res, wait);
        }
    }
}