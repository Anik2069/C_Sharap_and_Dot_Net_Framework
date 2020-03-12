using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACIcompany
{
    class Employee
    {
        string name;
        string id;
        string dt;
        double s;
        public Employee(string n,string i,string d)
        {
            name = n;
            id = i;
            dt = d;
            sets(d);
        }
        void sets(string d)
        {
            if (d.Equals("Manager") || d.Equals("manager"))
            {
                s = 20000;
                Console.WriteLine("hoise");
                Console.ReadKey();
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("","","manager");
        }
    }
}
