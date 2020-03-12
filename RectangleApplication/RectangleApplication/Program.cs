using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace RectangleApplication
{
    class rectangleDefine
    {
        double w, h;
        public void acceptDetails(double q,double s)
        {
            w = q;
            h = s;
        }
        public double getArea()
        {
            return w * h;
        }
        public void display()
        {
            Console.WriteLine("Length:{0}", h);
            Console.WriteLine("Width : {0}", w);
            Console.WriteLine("Area : {0}", getArea());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            rectangleDefine r = new rectangleDefine();
            r.acceptDetails(12, 12);
            r.display();
            Console.WriteLine("Bal");
            Console.ReadLine();
        }
    }
}


