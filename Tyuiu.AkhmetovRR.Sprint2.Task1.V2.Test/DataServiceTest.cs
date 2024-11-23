using Tyuiu.AkhmetovRR.Sprint2.Task1.V2.Lib;

namespace Tyuiu.AkhmetovRR.Sprint2.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int a = 135;
            int b = 156;
            int c = 154;
            int d = 174;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, true, true, true, true, false };

            CollectionAssert.AreEqual(wait, res);

        }
    }
}