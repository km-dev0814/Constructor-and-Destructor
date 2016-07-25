using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    class Demo
    {
        public string param1, param2;
        static Demo()
        {
            Console.WriteLine("Static Consturctor");
        }
        public Demo()
        {
            param1 = "Default";
            param2 = "Construcotr";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo obj = new Demo();
            Console.WriteLine(obj.param1 + " " + obj.param2);

            Demo obj1 = new Demo();
            Console.WriteLine(obj1.param1 + "" + obj1.param2);

            Demo obj2 = new Demo();
            Console.WriteLine(obj2.param1 + "" + obj2.param2);
            Console.ReadKey();



        }
    }
}
