using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject2 {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1() {
            summIt s = new summIt(4);
            Assert.AreEqual(8, s.summer());

        }
    }
}