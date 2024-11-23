using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AkhmetovRR.Sprint2.Task6.V5.Lib__;

namespace Tyuiu.AkhmetovRR.Sprint2.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual("��������", ds.FindMonthName(6));
            Assert.AreEqual("�������", ds.FindMonthName(7));
            Assert.AreEqual("���������", ds.FindMonthName(8));
            Assert.AreEqual("�������", ds.FindMonthName(9));
            Assert.AreEqual("�������", ds.FindMonthName(10));
            Assert.AreEqual("�����", ds.FindMonthName(11));
            Assert.AreEqual("����", ds.FindMonthName(12));
            Assert.AreEqual("������", ds.FindMonthName(13));
            Assert.AreEqual("����", ds.FindMonthName(14));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthName(-1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMothhName(13);
            });
        }
    }
}