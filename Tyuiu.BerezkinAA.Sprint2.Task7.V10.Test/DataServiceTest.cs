using Tyuiu.BerezkinAA.Sprint2.Task7.V10.Lib;

namespace Tyuiu.BerezkinAA.Sprint2.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 0.0;
            double y = -0.5;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}