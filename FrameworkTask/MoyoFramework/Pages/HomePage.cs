using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace MoyoFramework.Pages
{
    public class HomePage : BasePage
    {
        //public string url = "https://www.moyo.ua/";
        public string url = "https://www.mobilluck.com.ua";
        public IWebElement searchField => Driver.FindElement(By.Id("searchsw"));
        public IWebElement submitButton => Driver.FindElement(By.Id("searchbut2"));
        //public IWebElement searchField => Driver.FindElement(By.XPath("//input[@class = 'header__search-input']/.."));
        //public IWebElement submitButton => Driver.FindElement(By.XPath("button[type='submit']"));
    }
}
