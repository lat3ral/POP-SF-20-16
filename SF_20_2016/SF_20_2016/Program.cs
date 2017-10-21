using SF_20_2016.tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_20_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new A();
            a.SetIme("Dejan");
            Console.WriteLine("zovem se"  + " " + a.GetIme());
            Console.ReadLine();
            
        }
    }
}
