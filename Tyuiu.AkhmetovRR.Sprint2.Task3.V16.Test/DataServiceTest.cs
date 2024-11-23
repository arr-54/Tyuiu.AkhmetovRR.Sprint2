using Tyuiu.AkhmetovRR.Sprint2.Task3.V16.Lib;
namespace Tyuiu.AkhmetovRR.Sprint2.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConditons1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 5;
            Assert.AreEqual(res, wait);
        }

        [TestMethod]

        public void ValidConditons2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.75;
            Assert.AreEqual(res, wait);
        }

        [TestMethod]

        public void ValidConditons3()
        {
            DataService ds = new DataService();
            double x = -19;
            double res = ds.Calculate(x);
            double wait = 1.02;
            Assert.AreEqual(res, wait);
        }

        [TestMethod]

        public void ValidConditons4()
        {
            DataService ds = new DataService();
            double x = -28;
            double res = ds.Calculate(x);
            double wait = -307.964;
            Assert.AreEqual(res, wait);
        }
    }
}