using OpenQA.Selenium.Chrome;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoWorkCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            // account.json 파일에서 사용자 계정 정보 획득.
            Account account = new Account("account.json");
            WebMacro webMacro = new WebMacro();

            // 인수가 On 이면 출근처리.
            if(args[0].Equals("on"))
            {
                webMacro.Run(account.id, account.password, true);
            }
            // 인수가 Off 면 퇴근처리.
            else if(args[0].Equals("off"))
            {
                webMacro.Run(account.id, account.password, false);
            }
        }
    }
}
