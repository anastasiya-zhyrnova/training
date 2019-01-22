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

        public IWebElement GetCategory(string categoryName)
        {
            //IWebElement searchedCategoryItem = null;
            foreach (var item in searchResultsPage.searchResultsItems)
            {
                if (item.GetAttribute("text").Contains(categoryName))
                {
                    return item;
                }
                //return searchedCategoryItem;
            }

            return null;
        }

        public IWebElement GetFirstSearchResult()
        {
            var items = searchResultsPage.searchResultsItems;
            var res = (from i in items select i).First();
            return res;
        }

    }
}
