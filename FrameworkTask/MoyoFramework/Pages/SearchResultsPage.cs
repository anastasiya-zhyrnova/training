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
        //public string url = "https://www.moyo.ua/";

        public List<IWebElement> searchResultsItems => Driver.FindElements(By.CssSelector(".cci2_mdl a")).ToList();
        //public List<IWebElement> searchResultsItems => Driver.FindElements(By.CssSelector(".product-tile_title.ddd a")).ToList();
        
        public List<IWebElement> categories =>
            Driver.FindElements(By.XPath("//p[text() = 'Каталоги товаров']/following-sibling::ul/li/a")).ToList();
        public IWebElement buyButton => Driver.FindElement(By.XPath("//img[@id='buy']"));
        public IWebElement closePopup => Driver.FindElement(By.XPath("//div[@id = 'popup_content']/a[text()='Закрыть']"));
        public IWebElement cart => Driver.FindElement(By.XPath("//p[text() = 'Корзина заказов']"));
        public IWebElement itemInCart => Driver.FindElement(By.CssSelector("#popup_content td:nth-child(2)"));
        public IWebElement proceedButton => Driver.FindElement(By.CssSelector("#btn_order"));
        public IWebElement itemId => Driver.FindElement(By.CssSelector(".mg_code_new span"));




    }
}
