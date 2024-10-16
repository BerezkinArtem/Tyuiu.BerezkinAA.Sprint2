using Tyuiu.BerezkinAA.Sprint2.Task6.V11.Lib;

namespace Tyuiu.BerezkinAA.Sprint2.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds= new DataService();    
            int g = 2024;
            int m = 11;
            int n = 10;
            var res = ds.FindDateOfNextDay(g, m, n);
            string wait = "10.11.2024";
            Assert.AreEqual(wait, res);         
        }
    }
}