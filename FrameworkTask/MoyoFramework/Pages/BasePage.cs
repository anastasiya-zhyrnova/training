using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoyoFramework.Core;
using OpenQA.Selenium;

namespace MoyoFramework.Pages
{
    public class BasePage
    {
        protected readonly IWebDriver Driver;
        public BasePage()
        {
            Driver = SeleniumDriver.Driver;
        }

    }
}
