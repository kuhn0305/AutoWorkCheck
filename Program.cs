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
            Account account = new Account("account.json");
            Console.WriteLine(account.id);
            Console.WriteLine(account.password);
            WebMacro webMacro = new WebMacro();
            webMacro.Run(account.id, account.password);

        }
    }
}
