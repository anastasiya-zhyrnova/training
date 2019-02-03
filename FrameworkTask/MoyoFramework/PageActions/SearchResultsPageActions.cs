using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoyoFramework.Core;
using MoyoFramework.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace MoyoFramework.PageActions
{
    class SearchResultsPageActions
    {
        private SearchResultsPage searchResultsPage;
        private IWebDriver _driver;

        public SearchResultsPageActions()
        {
            searchResultsPage = new SearchResultsPage();
            _driver = SeleniumDriver.Driver;
        }

        public List<string> GetSearchItems()
        {
            List<string> itemsDescrs = new List<string>();
                       
            foreach (var item in searchResultsPage.searchResultsItems)
            {
                itemsDescrs.Add(item.GetAttribute("text"));                
            }
            return itemsDescrs;
        }

        public IWebElement GetCategory(string categoryName)
        {
            return searchResultsPage.categories.
                Where(t=>t.GetAttribute("text").Contains(categoryName)).
                Select(t => t).First();          
        }

        public IWebElement GetFirstSearchResult()
        {
            return searchResultsPage.searchResultsItems[0];
        }

        public void BuyItem()
        {
            searchResultsPage.buyButton.Click();
        }

        public string GetItemId()
        {
            string raw = (((RemoteWebElement)(searchResultsPage.itemId)).Text);
            string delim = ": ";
            string id = raw.Substring(raw.IndexOf(delim) + delim.Length);
            return id;
        }

        public void ClosePopup()
        {
            searchResultsPage.closePopup.Click();
        }

        public void ProceedToTheCart()
        {
            searchResultsPage.proceedButton.Click();
        }

        public string GetItemInCart()
        {
            return searchResultsPage.itemInCart.GetAttribute("text").ToString();
        }

        public void WaitForElement(string locator)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath(locator)));
        }

        public void SwitchToTheLastTab()
        {
            var newTabHandle = _driver.WindowHandles.Last();
            var newTab = _driver.SwitchTo().Window(newTabHandle);
        }

    }
}
