using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceOfTypeConvertion
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 12;
            double p = 12.3333;
            float f = 12.00f;
            bool b = true;
            int s = (int)p;
            Console.WriteLine(i.ToString());
            Console.WriteLine(p.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(b.ToString());
            Console.ReadLine();
        }
    }
}
