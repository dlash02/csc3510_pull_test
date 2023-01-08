// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace ConsoleApp2 {
    public class Program {
        static void Main(string[] args) {
            StringManager sm = new StringManager("Hello World");
            Console.WriteLine(sm.remVowels());
            Console.Read();
        }
    }
}