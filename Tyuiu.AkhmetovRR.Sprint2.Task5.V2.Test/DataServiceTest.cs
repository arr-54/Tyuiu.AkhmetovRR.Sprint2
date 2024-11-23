using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AkhmetovRR.Sprint2.Task5.V2.Lib;

namespace Tyuiu.AkhmetovRR.Sprint2.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Зима", ds.FindMothhName(1));
            Assert.AreEqual("Зима", ds.FindMothhName(2));
            Assert.AreEqual("Весна", ds.FindMothhName(3));
            Assert.AreEqual("Весна", ds.FindMothhName(4));
            Assert.AreEqual("Весна", ds.FindMothhName(5));
            Assert.AreEqual("Лето", ds.FindMothhName(6));
            Assert.AreEqual("Лето", ds.FindMothhName(7));
            Assert.AreEqual("Лето", ds.FindMothhName(8));
            Assert.AreEqual("Осень", ds.FindMothhName(9));
            Assert.AreEqual("Осень", ds.FindMothhName(10));
            Assert.AreEqual("Осень", ds.FindMothhName(11));
            Assert.AreEqual("Зима", ds.FindMothhName(12));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMothhName(-1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMothhName(13);
            });
        }
    }
}
