using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateConstructor
{
    public class Sample
    {
        public string param1, param2;
        public Sample(string a, string b)
        {
            param1 = a;
            param2 = b;
        }
        private Sample()
        {
            Console.WriteLine("Private Constructor with no parameters");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample("Welcome to ", "C#.net Constructor class");
            Console.WriteLine(obj.param1 + "" + obj.param2);
            Console.ReadKey();
        }
    }
}
