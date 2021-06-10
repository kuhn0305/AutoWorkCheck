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

            _driver = new ChromeDriver(_driverService, _options);

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        public void Run()
        {

            _driver.Navigate().GoToUrl("https://www.naver.com"); // 웹 사이트에 접속합니다.

            IWebElement queryTextBox = _driver.FindElementByXPath("//*[@id=\"query\"]");
            queryTextBox.SendKeys("무엇이든 물어보세요.");

            IWebElement searchButton = _driver.FindElementByXPath("//*[@id=\"search_btn\"]");
            searchButton.Click();
        }
    }
}
