using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCshop
{
   public class Employee
    {
        protected string name;
        protected int id;
        protected double salary;
        public Employee(string name,int id,double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }
        public double calsalary()
        {
           return salary * 30;
        }


    }

    class salesperson : Employee
    {
        public salesperson(string name, int id, double salary) : base(name,id,salary)
        {

        }

        public void calBonus(int perDayselling)
        {
            if (perDayselling >= 100)
            {
                Console.WriteLine(name+" get 500 tk bonus today");
                salary = salary + 500;
                
                
            }
            else
            {
                Console.WriteLine("No bonus for today");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int id = Convert.ToInt32(Console.ReadLine());
            double ss = Convert.ToDouble(Console.ReadLine());
            salesperson s1 = new salesperson(name,id,ss);
            s1.calBonus(101);
            Console.WriteLine("Salary is"+s1.calsalary());
            Console.ReadKey();
            



        }
    }
}
