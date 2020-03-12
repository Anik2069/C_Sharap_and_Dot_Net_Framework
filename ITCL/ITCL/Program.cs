using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ITCL
{
    public class salaryInfo
    {
        protected double salarypersalary;
        protected double monthlysalary;
        protected double yearsalary;
    

        public double Yearsalary { get => yearsalary; set => yearsalary = value; }
        public double Monthlysalary { get => monthlysalary; set => monthlysalary = value; }
        public double Salarypersalary { get => salarypersalary; set => salarypersalary = value; }
    }
   public interface Isalary
    {
        void monthlysalay();
        void yearlysalary();
    }

    abstract class officer:Isalary{
        protected string id;
        protected string name;
        protected salaryInfo salaryinfo= new salaryInfo();
        protected double totalWorkinghour;
        protected double paymentperhour;
        protected string performance;

        public string Name { get => name; set => name = value; }
        public salaryInfo Salaryinfo { get => salaryinfo; set => salaryinfo = value; }
        public double TotalWorkinghour { get => totalWorkinghour; set => totalWorkinghour = value; }
        public double Paymentperhour { get => paymentperhour; set => paymentperhour = value; }
        public string Performance { get => performance; set => performance = value; }
        public string Id { get => id; set => id = value; }

        public officer(string id,string name, double salaryinfo, double totalWorkinghour, double paymentperhour,string performance)
        {
            this.Id = id;
            this.name = name;
            Salaryinfo.Salarypersalary = salaryinfo;
            this.totalWorkinghour = totalWorkinghour;
            this.paymentperhour = paymentperhour;
            this.performance = performance;
        }
        



        abstract public void calTax();

        public virtual void monthlysalay()
        {
            salaryinfo.Monthlysalary = totalWorkinghour * salaryinfo.Salarypersalary;
            Console.WriteLine("Your monthly amount is:" + salaryinfo.Monthlysalary);
        }

        public virtual void yearlysalary()
        {
            salaryinfo.Yearsalary = salaryinfo.Monthlysalary*12;
            Console.WriteLine("Your Yearly amount is:" + salaryinfo.Yearsalary);
        }
    }



    class finicialofficer:officer
    {
        protected double festivalbonus;

        public finicialofficer(string id,string name,double salary,double totalWorkinghour, double paymentperhour,string performance,double festivalbonus) : base(id,name,salary,totalWorkinghour,paymentperhour,performance)
        {
            this.festivalbonus = festivalbonus;
        }

        public override void calTax()
        {
            if (salaryinfo.Yearsalary>=250000) {
               double b=salaryinfo.Yearsalary * 0.1;
                Console.WriteLine("Your tax amount is:"+b);
            }
            else {
                Console.WriteLine("Your tax amount is:" + 0.0);
            }
        }
        public override void yearlysalary()
        {
            salaryinfo.Yearsalary = salaryinfo.Monthlysalary * 12+(festivalbonus*2);
            Console.WriteLine("Your yearly salary is: "+salaryinfo.Yearsalary);
        }
    }
    class marketingofficer : officer
    {
        private double bonusamount;

        public marketingofficer(string id, string name, double salary, double totalWorkinghour, double paymentperhour, string performance, double bonusamount) : base(id, name, salary, totalWorkinghour, paymentperhour, performance)
        {
            this.bonusamount = bonusamount;
        }

        protected double Bonusamount { get => bonusamount; set => bonusamount = value; }

        public override void calTax()
        {
            if (salaryinfo.Yearsalary >= 300000)
            {
                double b = salaryinfo.Yearsalary * 0.15;
                Console.WriteLine("Your tax amount is:" + b);
            }
            else
            {
                Console.WriteLine("Your tax amount is:" + 0.0);
            }
        }
        public override void yearlysalary()
        {
            salaryinfo.Yearsalary = salaryinfo.Monthlysalary * 12 + bonusamount*2;
           
            Console.WriteLine("Your Yearly Salary:"+salaryinfo.Yearsalary);
        }
    }

        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tFinicial officer");
            List<finicialofficer> flist = new List<finicialofficer>(); 
            finicialofficer f = new finicialofficer("12","Al hasan",4600,4.5,4600,"Good",12000);
            finicialofficer f1 = new finicialofficer("13", "Ali hasan", 4600, 4.5, 4600, "Good", 12000);
            finicialofficer f2 = new finicialofficer("14", "Alu hasan", 4600, 4.5, 4600, "Good", 12000);
            finicialofficer f3 = new finicialofficer("15", "Alamgir hasan", 4600, 4.5, 4600, "Good", 12000);
            flist.Add(f);
            flist.Add(f1);
            flist.Add(f2);
            flist.Add(f3);
            foreach (var na in flist)
            {
                Console.WriteLine("Name of Employee:"+na.Name);
                na.monthlysalay();
                na.yearlysalary();
                na.calTax();
            }

            Console.WriteLine("\n\t\t\tMarketing officer\t\t\n");

            List<marketingofficer> mlist = new List<marketingofficer>();
            marketingofficer m = new marketingofficer("12", "DjMango hasan", 6500, 4.5, 6500, "Good", 12000);
            marketingofficer m1 = new marketingofficer("13", "Dot Vaiya hasan", 4800, 4.5, 4800, "Good", 12000);
            marketingofficer m2 = new marketingofficer("14", "Larvel", 4900, 4.5, 4900, "Good", 12000);
            marketingofficer m3 = new marketingofficer("15", "Alamgir hasan", 4900, 4.5, 4900, "Good", 12000);
            mlist.Add(m);
            mlist.Add(m1);
            mlist.Add(m2);
            mlist.Add(m3);
            foreach (var na in mlist)
            {
                Console.WriteLine("Name of Employee:" + na.Name);
                na.monthlysalay();
                na.yearlysalary();
                na.calTax();
            }
            Console.ReadKey();




        }
    }
}
