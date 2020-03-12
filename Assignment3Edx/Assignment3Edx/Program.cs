using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Edx
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PrintStudentDetails();
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
        static void PrintStudentDetails()
        {
            throw new NotImplementedException();
        }
        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's Birthday");
            string brithday = Console.ReadLine();
            Console.ReadKey();
        }
    }
}
