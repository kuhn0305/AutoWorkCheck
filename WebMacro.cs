using OpenQA.Selenium.Chrome;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;

namespace AutoWorkCheck
{
    public class WebMacro
    {
        protected ChromeDriverService driverService = null;
        protected ChromeOptions options = null;
        protected ChromeDriver driver = null;

        public WebMacro()
        {
            driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;

            options = new ChromeOptions();
            options.AddArgument("disable-gpu");
            options.AddArgument("--start-maximized");
        }

        ~WebMacro()
        {
            driver.Quit();
            driverService.Dispose();
            driver.Dispose();
        }

        public void Run(string id, string password, bool isAttend)
        {
            try
            {
                driver = new ChromeDriver(driverService, options);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                // 그룹웨어 사이트에 접속합니다.
                driver.Navigate().GoToUrl("http://gw.tektonspace.com/");
                // Frame으로 이동합니다.
                driver.SwitchTo().Frame(driver.FindElementByXPath("/html/frameset/frame"));

                // Id 텍스트 박스에 Id를 입력합니다.
                IWebElement idTextBox = driver.FindElementByXPath("//*[@id=\"loginForm\"]/div/table/tbody/tr[1]/td[2]/input");
                idTextBox.SendKeys(id);

                // 비밀번호 텍스트 박스에 비밀번호를 입력합니다.
                IWebElement passwordTestBox = driver.FindElementByXPath("//*[@id=\"loginForm\"]/div/table/tbody/tr[2]/td[2]/input");
                passwordTestBox.SendKeys(password);

                // 로그인 버튼을 클릭합니다.
                IWebElement loginButton = driver.FindElementByXPath("//*[@id=\"loginFormSubmit\"]");
                loginButton.Click();


                if(isAttend)
                {
                    // 출근시에는 출근 버튼을 클릭합니다.
                    IWebElement checkButton = driver.FindElementByXPath("//*[@id=\"contentsdivAttendanceInfo\"]/div/div[2]/p[2]/a");
                    checkButton.Click();
                }
                else
                {
                    // 퇴근시에는 퇴근 버튼을 클릭합니다.
                    IWebElement checkButton = driver.FindElementByXPath("//*[@id=\"contentsdivAttendanceInfo\"]/div/div[2]/p[3]/a");
                    checkButton.Click();
                }

                // 출퇴근 확인을 요청하는 알람창에서 확인을 누릅니다.
                driver.SwitchTo().Alert().Accept();

                // 출퇴근이 제대로 되었는지 확인하기 위해 3초간 대기합니다.
                Thread.Sleep(3000);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
