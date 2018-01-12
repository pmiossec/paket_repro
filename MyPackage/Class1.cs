using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPackage
{
    public class Class1
    {
        public void UseSystemNetHttp()
        {
            var httpVersion = new System.Net.HttpVersion();
            Console.WriteLine(httpVersion.GetType());
        }
    }
}
