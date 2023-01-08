using ConsoleApp3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestPhone {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestValid_7_digit_with_dash() {
            string ph = "555-1212";
            PhoneManager pm = new PhoneManager(ph);
            bool ret = pm.IsPhone();
            Console.WriteLine("Ph:{0} ret:{1}", ph, ret);
            Assert.IsTrue(ret);

        }
        [TestMethod]
        public void TestValid_10_digit_with_dash() {
            string ph = "555-555-1212";
            PhoneManager pm = new PhoneManager(ph);
            bool ret = pm.IsPhone();
            Console.WriteLine("Ph:{0} ret:{1}", ph, ret);
            Assert.IsTrue(ret);

        }
    }
}