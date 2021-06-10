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
            WebMacro webMacro = new WebMacro();

            if(args[0].Equals("on"))
            {
                webMacro.Run(account.id, account.password, true);
            }
            else if(args[0].Equals("off"))
            {
                webMacro.Run(account.id, account.password, false);
            }
        }
    }
}
