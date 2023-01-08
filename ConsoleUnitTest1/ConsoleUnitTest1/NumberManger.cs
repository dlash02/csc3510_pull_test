using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUnitTest1 {
   
        public class NumberManger {
            // Implement a program to check if a number is a
            // triangular number:
            //
            // Write a program that prompts the user for a number
            // and then checks to see if it is a triangular number.
            //
            // A triangular number is a number that can be represented as
            // the sum of the integers from 1 to some positive integer n
            //.For example, 6 is a triangular number because it can be
            //represented as 1 + 2 + 3.
            //
            //The program should print "Triangular" if the number
            //    is a triangular number, and "Not triangular" otherwise.
            int inNumber;

            public NumberManger(int inNumber) {
                this.inNumber = inNumber;
            }
            public Boolean isTriangleNumber() {
                Boolean result = false;
                int sum = 0;
                for (int i = 1; i < inNumber; i++) {
                    sum += i;
                    Console.WriteLine(" i:{0} sum:{1} inNumber:{2}", i, sum, inNumber);
                    if (sum == inNumber) {
                        return true;
                    }
                }
                return result;
            }
        }
    }
