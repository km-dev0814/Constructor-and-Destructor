using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    class Sample
    {
        //Constructor is same name with Class name
        public Sample()
        {
            Console.WriteLine("Constructor");
        }


        //Destructor is also same name with Class name but prefix with ~ and we cant use access specifers before the desctructors
        ~Sample()
        {
            Console.WriteLine("Destructor");
            Console.ReadKey();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample();
            Console.ReadKey();
        }
    }
}
