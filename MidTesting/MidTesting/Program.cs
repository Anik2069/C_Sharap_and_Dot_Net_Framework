using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using first;
using first.second;

namespace first
{
    class namespace_c1
    {
        public void func()
        {
            Console.WriteLine("inside the first");
        }
    }
    //Nested namespace
    namespace second
    {
        class namespace_c
        {
            public void func()
            {
                Console.WriteLine("inside the Nested");
            }
        }
    }
}
/*Define namespace
namespace second
{
    class namespace_c1
    {
        public void func()
        {
            Console.WriteLine("inside the Second");
        }
    }
}
*/
namespace MidTesting
{


    class Program
    {
        enum Days {Sun,Mon,tue,wed,thu,Fri,Sat};
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello");
            //Type Conversition
            /*
            int a = 12;
            double d = (double)a;
            d = 12.3455;
            a = (int)d;
            int aa = 12;
            Console.WriteLine(aa.ToString());
            Console.WriteLine(a+" "+d);
            //Null Able
            int? s = null;
            int? s1 = 34;
            double? s2 = new double?();
            double? s3 = s ?? 5.36;
            double s4 = s3 ?? 3.14;
            bool? bal = new bool?();
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine("Null value is:{0},{1},{2},{3},{4}",s,s1,s2,s3,bal);
         
            //Array Declaration
            double[] balance;
            double[] balance = new double[10];
            balance[0] = 4500.0;
            double[] balance = {4500.0,233.3,444.4,4.44 };
            int[] marks = new int[] {12,12,23,45};
            /*Array Code
            int[] n = new int[10];
            for (int i=0;i<10;i++)
            {
                n[i] = i + 100;
            }
            foreach(int j in n)
            {
                int i = j - 100;
                Console.WriteLine("Element [{0}]:{1}",i,j);
            }
            
            //String Program
            string fname, lname;
            fname = "Rowan";
            lname = "Atkinson";
            char[] l = {'A','n','i','k' };
            string fullname = fname + lname;
            Console.WriteLine("Full name:{0}",fullname);
            string name = new string(l);
            Console.WriteLine(name);
            string[] sarray = {"Abc","dfg","wer" };
            string letter = String.Join(" ",sarray);
            Console.WriteLine(letter);
            //ENUMS
            
            int ws = (int)Days.Mon;
            int ls = (int)Days.Fri;
            Console.WriteLine("Monday: {0}",ws);
            Console.WriteLine("Monday: {0}",ls);
            
            //NameSpace
            first.namespace_c1 c = new first.namespace_c1();
            c.func();
            namespace_c d = new namespace_c();
            d.func();
            
            //try catch
            int a = 2;int b=0;
            int re = 0;
            try
            {
               
                re = a/b;



            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Exception found:{0}",e);
            }
            finally
            {
                Console.WriteLine("Result:{0}", re);
            }
            
            //class Object Interface
            b ab = new b();
            ab.ap(4);
            
            abc ab = new abc();
            ab.A = 124;
            Console.WriteLine(ab.A);
            int a = 0;
            a = Convert.ToInt32(Console.ReadLine());


            try
            {
                double b=Math.Sqrt(a);
                Console.WriteLine(b);
            }
            catch (ArithmeticException e)
            {

            }
            finally
            {
                Console.WriteLine("good bye");
            }
            */
            indexc ab = new indexc();
            ArrayList a1 = new ArrayList();
            Stack myStack = new Stack();

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            foreach (int i in myStack)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("C# is "+myStack.Peek());
        

        myStack.Push(50);
            myStack.Push(60);
            myStack.Pop();
            foreach (int i in myStack)
            {
                Console.WriteLine(i);
            }


            Queue qt = new Queue();
            qt.Enqueue(1);
            qt.Enqueue(2);
            qt.Enqueue(3);

            qt.Dequeue();

            foreach (Object obj in qt)
            {
                Console.WriteLine(obj);
            }



            Console.ReadKey();
        }
        class indexc
        {
            private string[] namelist = new string[10];
            public string this[int index]
            {
                get
                {
                    string tem;
                    if (index <  10)
                    {
                        tem = namelist[index];
                    }
                    else
                    {
                        tem = " ";
                    }
                    return tem;

                }
                set
                {
                    if (index <  10)
                    {
                        namelist[index] = value;
                    }
                }
            }


            [Obsolete ("Don not use old, use new instead", true)]
            void old()
            {

            }
            void newm()
            {


            }




        }




        sealed class abc
        {
            private int a;

            public int A
            {
                get
                {
                    return a;
                }
                set
                {
                    a = value;
                }
            }


            

        }
        class ab 
        {

        }


           public interface Iface
        {
            void printName(String name);
        }

        class a
        {
            public virtual void ap()
            {
                Console.WriteLine("Virtual");
            }

        }
        class b : a, Iface
        {

            public void ap()
            {
                Console.WriteLine("No Virtual");
            }
            public void ap(int a)
            {
                Console.WriteLine("Method: {0}",a);
            }
            public void printName(string a)
            {
                Console.WriteLine("Method: {0}", a);
            }

        }
    }
}
