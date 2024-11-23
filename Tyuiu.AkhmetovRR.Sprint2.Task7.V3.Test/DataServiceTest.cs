using Tyuiu.AkhmetovRR.Sprint2.Task7.V3.Lib;

namespace Tyuiu.AkhmetovRR.Sprint2.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDoInShadedArea()
        {
            DataService ds = new DataService();

            double x = -0.7;
            double y = 0.7;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = false;

            Assert.AreEqual(wait, res);
        }
    }
}