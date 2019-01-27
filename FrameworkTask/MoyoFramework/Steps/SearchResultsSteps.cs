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
using OpenQA.Selenium.Support.UI;

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

        [Given(@"I add product to the cart")]
        [When(@"I add product to the cart")]
        public void WhenIAddProductToTheCart()
        {
            SearchResultsPageActions page = new SearchResultsPageActions();
            page.GetFirstSearchResult().Click();
            page.SwitchToTheLastTab();
            var itemId = page.GetItemId();
            page.WaitForElement("//img[@id='buy']");
            page.BuyItem();
            page.ProceedToTheCart();
            ScenarioContext.Current["AddedItem"] = itemId;
            //page.ClosePopup();
        }

        //[Then(@"product is added to the cart")]
        //public void ThenProductIsAddedToTheCart()
        //{
        //    //SearchResultsPageActions page = new SearchResultsPageActions();
        //    //string actualText = page.GetItemInCart();
        //    //string expectedText = "добавлен в корзину!";
        //    //Assert.IsTrue(actualText.Contains(expectedText));
        //}



        [Then(@"only items related to the '(.*)' product are present in search results")]
        public void ThenOnlyItemsRelatedToTheProductArePresentInSearchResults(string product)
        {
            SearchResultsPageActions page = new SearchResultsPageActions();
            var itemsList = page.GetSearchItems();
            Assert.IsTrue(itemsList.All(i => i.ToLower().Contains(product.ToLower())));
        }


        


    }
}
