using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SerializeAndDeseralize
{
    class Program
    {
        static void Main(string[] args)
        {
            //Serialization
            var p1 = new product {id=123,name="Anik",price=1234 };
            var jsonString = JsonConvert.SerializeObject(p1);
            Console.WriteLine(jsonString);

            //Deserialization
            var p2 = JsonConvert.DeserializeObject<product>(jsonString);
            Console.WriteLine($"The product id is:{p2.id}");


            Console.ReadKey();
        }
        
    }
    class product
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
    }
}
