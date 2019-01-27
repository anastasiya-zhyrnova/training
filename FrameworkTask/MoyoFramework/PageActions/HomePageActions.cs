using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoyoFramework.Core;
using MoyoFramework.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace MoyoFramework.PageActions
{
    class HomePageActions 
    {
        private HomePage homepage;
        private IWebDriver _driver;

        public HomePageActions()
        {
            homepage = new HomePage();
            _driver = SeleniumDriver.Driver;
        }

        public void GetPage()
        {
            _driver.Navigate().GoToUrl(homepage.url);
        }

        public void PerformSearch(string searchCriteria)
        {
            homepage.searchField.Click();
            homepage.searchField.SendKeys(searchCriteria);
            homepage.submitButton.Click();
        }

        public void SelectCategory(string categoryName)
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(homepage.productCatalog).Click();
            actions.MoveToElement(homepage.phonesMenuItem).Click();
            
        }
    }
}
