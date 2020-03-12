using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri
{
    class house
    {
        protected double area;
        protected door Door=new door();

        public house(double area)
        {
            this.area = area;
        }
        public double Area
        {
            get
            {
                return this.area;
            }
            set
            {
                this.area = value;
            }
        }

        public door d1
        {
            
            get
            {
                return this.Door;
            }
            set
            {
                this.Door = value;
            }
        }

        public void showdata()
        {
            Console.WriteLine("I am a house, my area is"+Area+" m2");
        }
    }
    class door
    {
        private string color;
        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }
        public void showdata()
        {
            Console.WriteLine("I am a door, my color is " + color);
        }
    }
    class SmallApartment : house
    {
       
        
        public SmallApartment(double area) : base(area)
        {
           
        }
    }
    class person
    {
        private string name;
        private house hname;

        public person(string name, house hname)
        {
            this.name = name;
            this.hname = hname;
        }

        public string Name
        {


            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public house Hname
        {
            get
            {
                return this.hname;
            }
            set
            {
                this.hname = value;
            }
        }
        public void showdata()
        {
            Console.WriteLine("Owner Name:"+name);
            hname.showdata();
            hname.d1.showdata();

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            SmallApartment s = new SmallApartment(50);

            s.d1.Color = "brown";
             person p = new person("Anik",s);
            p.showdata();
            Console.ReadKey();

        }
    }
}
