using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestLab4
{
    public class Program
    {
        public static long calculateFactorial(int x)
        {
            return 0;
        }
        [TestClass]
        public class UnitTest1
        {
            int x;
            long Fact;
            Console.WriteLine("Enter an integer: ");
            x = int.Parse(Console.ReadLine());
            Fact = x;  //factorial equals the number we just parsed
            Fact = getFact(x, Fact);
            Console.ReadLine();
            [TestMethod]
            private static long getFact(int x, long Fact)
            {
                for (int i = x - 1; i >= 1; i--)  //for the numbers greater than one, decrement
                {
                    Fact = Fact * i;  //multiply the factorial by the decremented value
                }
                Console.WriteLine("\n Factorial of Given Number is: " + Fact);
                return Fact;
            }
        }
    }
}
