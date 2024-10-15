using Tyuiu.BerezkinAA.Sprint2.Task3.V14.Lib;

namespace Tyuiu.BerezkinAA.Sprint2.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = -25;
            Assert.AreEqual(res, wait);


        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.75;
            Assert.AreEqual(res, wait);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = 1.5;
            double res = ds.Calculate(x);
            double wait = -123.5;
            Assert.AreEqual(res, wait);
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -20;
            double res = ds.Calculate(x);
            double wait = -219.95;
            Assert.AreEqual(res, wait);


        }
    }
}