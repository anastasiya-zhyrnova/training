using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoyoFramework.Core;
using MoyoFramework.Pages;
using OpenQA.Selenium;

namespace MoyoFramework.PageActions
{
    class ProductPageActions
    {
        private ProductPage productPage;
        private IWebDriver _driver;

        public ProductPageActions()
        {
            productPage = new ProductPage();
            _driver = SeleniumDriver.Driver;
        }

        public void AddItemToCart()
        {
            productPage.buyButton.Click();
        }
    }
}
