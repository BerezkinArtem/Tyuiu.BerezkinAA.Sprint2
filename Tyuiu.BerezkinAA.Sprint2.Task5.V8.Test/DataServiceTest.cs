using Tyuiu.BerezkinAA.Sprint2.Task5.V8.Lib;

namespace Tyuiu.BerezkinAA.Sprint2.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            int m = 11;
            int n = 1;
            DataService ds = new DataService();
            Assert.AreEqual("31.10", ds.FindDateOfPreviousDay(m, n));
        }
    }
}