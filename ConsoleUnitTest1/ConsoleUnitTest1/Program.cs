// See https://aka.ms/new-console-template for more information
//

using System;

namespace ConsoleUnitTest1 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");
            int inNumb = 15;
            NumberManger nm = new NumberManger(inNumb);

            if (nm.isTriangleNumber()) {
                Console.WriteLine("Yes, n:{0} ", inNumb);
            } else {
                Console.WriteLine("No, n:{0} ", inNumb);
            }
            string ret = Console.ReadLine();
        }

    }
}
