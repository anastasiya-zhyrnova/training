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
    }
}
