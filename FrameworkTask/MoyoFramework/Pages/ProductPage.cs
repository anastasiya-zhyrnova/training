using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace MoyoFramework.Pages
{
    public class ProductPage : BasePage
    {
        public IWebElement buyButton => Driver.FindElement(By.Id("buy"));
    }
}
