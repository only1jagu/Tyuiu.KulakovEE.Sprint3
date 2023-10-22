using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KulakovEE.Sprint3.Task1.V5.Lib;

namespace Tyuiu.KulakovEE.Sprint3.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startvalue = 1;
            int stopvalue = 4;

            double wait = 2.905;
            double res = ds.GetMultiplySeries(startvalue, stopvalue);

            Assert.AreEqual(wait, res);
        }
    }
}

