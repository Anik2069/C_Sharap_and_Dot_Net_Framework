using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testofSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            int c, d=0;
            string s1 = Console.ReadLine();
            string[] strarr = s1.Split('+');

            foreach (var v in strarr)
            {
                Console.WriteLine(v);
                c = Convert.ToInt32(v);
                d = d + c;


            }
            Console.WriteLine("The sum is :"+d);
            Console.ReadKey();
        }
    }
}
