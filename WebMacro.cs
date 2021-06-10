using OpenQA.Selenium.Chrome;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

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
        }

        public void Run(string id, string password, bool isAttend)
        {
            driver = new ChromeDriver(driverService, options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Navigate().GoToUrl("http://gw.tektonspace.com/"); // 웹 사이트에 접속합니다.
            driver.SwitchTo().Frame(driver.FindElementByXPath("/html/frameset/frame"));

            IWebElement idTextBox = driver.FindElementByXPath("//*[@id=\"loginForm\"]/div/table/tbody/tr[1]/td[2]/input");
            idTextBox.SendKeys(id);

            IWebElement passwordTestBox = driver.FindElementByXPath("//*[@id=\"loginForm\"]/div/table/tbody/tr[2]/td[2]/input");
            passwordTestBox.SendKeys(password);

            IWebElement loginButton = driver.FindElementByXPath("//*[@id=\"loginFormSubmit\"]");
            loginButton.Click();

            if(isAttend)
            {
                IWebElement checkButton = driver.FindElementByXPath("//*[@id=\"contentsdivAttendanceInfo\"]/div/div[2]/p[2]/a");
                checkButton.Click();
            }
            else
            {
                IWebElement checkButton = driver.FindElementByXPath("//*[@id=\"contentsdivAttendanceInfo\"]/div/div[2]/p[3]/a");
                checkButton.Click();
            }
        }
    }
}
