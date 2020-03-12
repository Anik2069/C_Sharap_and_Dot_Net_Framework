using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodTestingEdx
{
    class Program
    {
        static void Main(string[] args)
        {
            sum(10,12);
            division(1,0);
            Console.ReadKey();

        }
        static void sum(int a,int b)
        {
            int c = a + b;
            Console.WriteLine($"Result is :{c}");
        }
        static void division(int a, int b)
        {
            try
            {
                int c = a / b;
                Console.WriteLine($"Result is :{c}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero, please provide a non-zero value for your second value");
            }

         }
    }
}
