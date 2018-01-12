using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPackage;

namespace ConsoleApp
{
    public class ConsoleAppClass
    {
        public string Write()
        {
            new Class1().UseSystemNetHttp();
            Console.WriteLine("Foo");
            return "bar";
        }
    }
}
