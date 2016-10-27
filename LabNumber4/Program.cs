using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            long Fact;
            Console.WriteLine("Enter an integer: ");
            x = int.Parse(Console.ReadLine());
            Fact = x;  //factorial equals the number we just parsed
            Fact = getFact(x, Fact);
            Console.ReadLine();

        }

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
