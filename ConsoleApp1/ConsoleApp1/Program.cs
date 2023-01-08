using System;

namespace ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            summIt s = new summIt(4);
            var res = s.summer();
            Console.WriteLine("Res=" + res );

            var str = Console.Read();
        }
    }

public class summIt {
    int item = 0;
    public  summIt( int x) {
        this.item = x;
    }

    public int summer() {
        return this.item + this.item;
    }

}
}