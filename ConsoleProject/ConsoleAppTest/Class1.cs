using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConsoleAppTest
{
    public class ClassTest
    {
        [Fact]
        public void MyTest()
        {
            var consoleAppClass = new ConsoleApp.ConsoleAppClass();
            Assert.Equal("bar", consoleAppClass.Write());
        }
    }
}
