using System.Data;
using Tyuiu.AkhmetovRR.Sprint2.Task4.V26.Lib;
namespace Tyuiu.AkhmetovRR.Sprint2.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 99.8;
            Assert.AreEqual(res, wait);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 15;
            double res = ds.Calculate(x, y);
            double wait = 99.933;
            Assert.AreEqual(res, wait);
        }
    }
}