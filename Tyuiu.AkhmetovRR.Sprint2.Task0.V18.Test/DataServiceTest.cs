using Tyuiu.AkhmetovRR.Sprint2.Task0.V18.Lib;
namespace Tyuiu.AkhmetovRR.Sprint2.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(5105, 475);
            bool[] bools = new bool[6] { false, true, true, true, true, false };
            bool[] wait = bools;
            CollectionAssert.AreEqual(wait, res);
        }
    }
}