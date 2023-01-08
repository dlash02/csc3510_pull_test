using ConsoleApp2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace TestProject1 {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void Run_Hello_World() {
            var tok = "Hello World";
            StringManager sm = new StringManager( tok );
            Console.WriteLine( "A=>" + tok );
            Console.WriteLine( "B=>" + sm.remVowels() );
            Assert.AreEqual("Hll Wrld", sm.remVowels());
        }
        [TestMethod]
        public void LastCharIs_Y() {
            var tok = "Many";
            StringManager sm = new StringManager(tok);
            Console.WriteLine("A=>" + tok);
            Console.WriteLine("B=>" + sm.remVowels());
            Assert.AreEqual("Mn", sm.remVowels());
        }
        [TestMethod]
        public void Only_Y_As_Vowel() {
            var tok = "Gymn";
            StringManager sm = new StringManager(tok);
            Console.WriteLine("A=>" + tok);
            Console.WriteLine("B=>" + sm.remVowels());
            Assert.AreEqual("Gmn", sm.remVowels());
        }
        [TestMethod]
        public void Only_Y_As_Vowel2() {
            var tok = "pygmy";
            StringManager sm = new StringManager(tok);
            Console.WriteLine("A=>" + tok);
            Console.WriteLine("B=>" + sm.remVowels());
            Assert.AreEqual("pgm", sm.remVowels());
        }
        [TestMethod]
        public void Only_Y_As_Vowel3() {
            var tok = "BY";
            StringManager sm = new StringManager(tok);
            Console.WriteLine("A=>" + tok);
            Console.WriteLine("B=>" + sm.remVowels());
            Assert.AreEqual("B", sm.remVowels());
        }
        // Then read this: https://grammar.yourdictionary.com/style-usage/when-is-vowel-easy-guide-words
        [TestMethod]
        public void end_of_a_syllable() {
            var tok = "dynamic";
            StringManager sm = new StringManager(tok);
            Console.WriteLine("A=>" + tok);
            Console.WriteLine("B=>" + sm.remVowels());
            Assert.AreEqual("dnmc", sm.remVowels());
        }
        [TestMethod]
        public void begins_a_word() {
            var tok = "yard";
            StringManager sm = new StringManager(tok);
            Console.WriteLine("A=>" + tok);
            Console.WriteLine("B=>" + sm.remVowels());
            Assert.AreEqual("yrd", sm.remVowels());
        }
    }
}