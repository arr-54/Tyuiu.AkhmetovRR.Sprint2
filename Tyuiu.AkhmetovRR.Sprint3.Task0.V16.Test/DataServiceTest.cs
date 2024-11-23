using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AkhmetovRR.Sprint3.Task0.V16.Lib;

namespace Tyuiu.AkhmetovRR.Sprint3.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetProductSeries()
        {
            DataService ds = new DataService();

            double x = 5;
            int startValue = 2;
            int stopValue = 2;

            double res = ds.GetProductSeries(startValue, stopValue, x);

            double wait = Math.Pow(x / 2, 3);

            Assert.AreEqual(res, wait);

        }
        [TestMethod]
        public void ValidSetSumSeries()
        {
            DataService ds = new DataService();

            double x = 5;
            int startValue = 1;
            int stopValue = 3;

            double res = ds.GetProductSeries(startValue, stopValue, x);

            double wait = Math.Pow(x / 1, 3) * Math.Pow(x / 2, 3) * Math.Pow(x / 3, 3);

            Assert.AreEqual(res, wait);
        }
    }
}