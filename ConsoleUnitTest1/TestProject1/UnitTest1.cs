using ConsoleUnitTest1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1 {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1() {
            NumberManger nm = new NumberManger(6);
            
            Boolean res = nm.isTriangleNumber();
            Console.WriteLine(res);
            Assert.IsTrue(res);
        }
    }
}