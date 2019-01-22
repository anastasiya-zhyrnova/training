using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoyoFramework.PageActions;
using MoyoFramework.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using MoyoFramework.PageActions;
using NUnit.Framework;

namespace MoyoFramework.Steps
{
    [Binding]
    public class SearchResultsSteps
    {
        //public IEnumerable<IWebElement> GetResultItems()
        //{
        //    SearchResultsPageActions page = new SearchResultsPageActions();
        //    return page.GetSearchItems();
        //}

        //public IEnumerable<string> GetResultItemsText()
        //{
        //    return _searchResPage.searchResultsItems.Select(i =>i.Text);
        //}
        [Given(@"I focus my search in '(.*)' category")]
        public void GivenIFocusMySearchInCategory(string categoryName)
        {
            SearchResultsPageActions page = new SearchResultsPageActions();
            page.GetCategory(categoryName).Click();
        }

        [When(@"I add product to the cart")]
        public void WhenIAddProductToTheCart()
        {
            SearchResultsPageActions page = new SearchResultsPageActions();
            page.GetFirstSearchResult().Click();
        }


        [Then(@"only items related to the '(.*)' product are present in search results")]
        public void ThenOnlyItemsRelatedToTheProductArePresentInSearchResults(string product)
        {
            SearchResultsPageActions page = new SearchResultsPageActions();
            var itemsList = page.GetSearchItems();
            Assert.IsTrue(itemsList.All(i => i.ToLower().Contains(product.ToLower())));
        }





    }
}
