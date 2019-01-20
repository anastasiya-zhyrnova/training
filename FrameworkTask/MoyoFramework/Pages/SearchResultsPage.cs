using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace MoyoFramework.Pages
{
    public class SearchResultsPage : BasePage
    {
        public string url = "https://www.moyo.ua/";

        public List<IWebElement> searchResultsItems => Driver.FindElements(By.CssSelector(".cci2_mdl a")).ToList();
        //public List<IWebElement> searchResultsItems => Driver.FindElements(By.CssSelector(".product-tile_title.ddd a")).ToList();




    }
}
