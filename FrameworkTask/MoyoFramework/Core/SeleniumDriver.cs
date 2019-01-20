using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace MoyoFramework.Core
{
    public static class SeleniumDriver
    {
        private static IWebDriver _driver;

        public static IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                {
                    ChromeOptions ops = new ChromeOptions();
                    ops.AddArguments("disable-infobars", "--disable-notifications");
                    DesiredCapabilities dc = new DesiredCapabilities();
                    dc.SetCapability(ChromeOptions.Capability, ops);
                    _driver = new ChromeDriver(ops);
                    _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    _driver.Manage().Window.Maximize();
                    
                    
                }
                return _driver;
            }

        }
    }
}
