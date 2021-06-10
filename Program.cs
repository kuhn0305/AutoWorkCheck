using OpenQA.Selenium.Chrome;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWorkCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            WebMacro webMacro = new WebMacro();
            webMacro.Run();

        }
    }
}
