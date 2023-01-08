// See https://aka.ms/new-console-template for more information
//using IntroCSharp1;
using System;
namespace IntroCSharp1 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");
            int inNumb = 15;
            NumberManager nm = new NumberManager(inNumb);

            if (nm.isTriangleNumber()) {
                Console.WriteLine("Yes, n:{0} ", inNumb);
            }
            else {
                Console.WriteLine("No, n:{0} ", inNumb);
            }
            string ret = Console.ReadLine();

        }

    }
}