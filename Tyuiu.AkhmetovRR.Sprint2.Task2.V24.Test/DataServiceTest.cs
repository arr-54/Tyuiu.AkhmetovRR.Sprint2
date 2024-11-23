using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AkhmetovRR.Sprint2.Task2.V24.Lib;

namespace Tyuiu.AkhmetovRR.Sprint2.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 4;
            int y = 5;
            DataService ds = new DataService();
            bool result = ds.Calculate(x, y);
            Assert.IsTrue(result);
        }
    }
}