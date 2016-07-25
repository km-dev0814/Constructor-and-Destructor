using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    class Sample
    {
        public string param1, param2;
        public Sample(string x, string y)
        {
            param1 = x;
            param2 = y;
        }
        public Sample(Sample obj)
        {
            param1 = obj.param1;
            param2 = obj.param2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample("Welcome", "C#.net Class");
            Sample obj1 = new Sample(obj);
            Console.WriteLine(obj.param1 + " " + obj.param2);
            Console.ReadKey();
        }
    }
}
