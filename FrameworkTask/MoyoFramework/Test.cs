using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoyoFramework.Core;
using MoyoFramework.PageActions;
using MoyoFramework.Pages;
using MoyoFramework.Steps;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace MoyoFramework
{
    [TestFixture]
    public class Test
    {
        private IWebDriver _driver;
        private const string Url = "https://www.moyo.ua";

        private string SEARCH_ITEM = "iphone";

        [OneTimeSetUp]
        public void Setup()
        {
            _driver = SeleniumDriver.Driver;
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test_01_SomeTest()
        {
            //_driver.Url = Url;
            //var homepage = new HomePage();
            //homepage.searchField.SendKeys("iPhone 7");
            //homepage.searchField.Click();
            //var resultPage = new SearchResultsSteps(_driver);
            //var resultList = resultPage.GetResultItemsText();
            //Assert.IsTrue(resultList.All(i=>i.Contains("IPhone")));
            var HomePageActions = new HomePageActions();
            HomePageActions.GetPage();
            HomePageActions.PerformSearch(SEARCH_ITEM);
            var SearchResultsPageActions = new SearchResultsPageActions();
            var itemsList = SearchResultsPageActions.GetSearchItems();
            Assert.IsTrue(itemsList.All(i => i.ToLower().Contains(SEARCH_ITEM)));
            



        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

    }
}
