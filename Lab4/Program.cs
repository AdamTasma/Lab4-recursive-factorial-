using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We're gonna fac your torial today kid!");
            Calculate();
        }
        public static void Calculate()
        {
            Console.WriteLine("Enter an integer from 1 to 25 please");
            int input = int.Parse(Console.ReadLine());
            long fact = input;
            Console.WriteLine("Number   Squared  Cubed");
            for (int i = 1; i < input; i++)
            {
                fact = Multiply(fact, i);
                //fact = fact * i; 
            }
            Console.WriteLine("The factorial of " + input + " is " + fact);

            //repeat
            Console.WriteLine("Would you like to continue? (y/n)");
            char repeat = char.Parse(Console.ReadLine().ToUpper());
            if (repeat.Equals(Char.Parse("Y")))
            {
                Calculate();
            }
            else
            {
                Console.WriteLine("Ok goodbye");
                Console.ReadLine();
            }
            
        }
        public static long Multiply(long fact, int i)
        {
            return fact * i;
        }
    }
}
