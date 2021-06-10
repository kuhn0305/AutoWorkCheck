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
        protected ChromeDriverService _driverService = null;
        protected ChromeOptions _options = null;
        protected ChromeDriver _driver = null;

        public WebMacro()
        {
            _driverService = ChromeDriverService.CreateDefaultService();
            _driverService.HideCommandPromptWindow = true;

            _options = new ChromeOptions();
            _options.AddArgument("disable-gpu");
        }

        public void Run(string id, string password)
        {
            _driver = new ChromeDriver(_driverService, _options);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
            _driver.Navigate().GoToUrl("http://gw.tektonspace.com/"); // 웹 사이트에 접속합니다.
            _driver.SwitchTo().Frame(_driver.FindElementByXPath("/html/frameset/frame"));

            IWebElement idTextBox = _driver.FindElementByXPath("//*[@id=\"loginForm\"]/div/table/tbody/tr[1]/td[2]/input");
            idTextBox.SendKeys(id);

            IWebElement passwordTestBox = _driver.FindElementByXPath("//*[@id=\"loginForm\"]/div/table/tbody/tr[2]/td[2]/input");
            passwordTestBox.SendKeys(password);

            IWebElement loginButton = _driver.FindElementByXPath("//*[@id=\"loginFormSubmit\"]");
            loginButton.Click();
        }
    }
}
