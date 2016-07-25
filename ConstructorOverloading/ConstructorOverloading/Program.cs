using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloading
{
    class Sample
    {
        public string param1, param2;
        public Sample()
        {
            param1 = "Hi";
            param2 = "I am Default Constructor";
        }
        public Sample(string x, string y)
        {
            param1 = x;
            param2 = y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample();
            Sample obj1 = new Sample("Welcome", "Parameterized Constructor");
            Console.WriteLine(obj.param1 + " " + obj.param2);
            Console.WriteLine(obj1.param1 + " " + obj1.param2);
            Console.ReadKey();
        }
    }
}
