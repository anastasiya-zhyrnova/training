using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoyoFramework.Pages
{
    public class CartPage : BasePage
    {
        public IWebElement cartItemsNum => Driver.FindElement(By.XPath("//div[@id = 'head_step1']/h1/span"));
        public List <IWebElement> products => Driver.FindElements(By.CssSelector(".items .itemline")).ToList();
        public IWebElement itemId => Driver.FindElement(By.Name("item_id[]"));
        public IWebElement productQuantity => Driver.FindElement(By.CssSelector(".items .count_input"));
        public IWebElement deleteItemFromCart => Driver.FindElement(By.XPath("//span[@class = 'deleteitem']"));
        public IWebElement cartLabel => Driver.FindElement(By.XPath("//p[@class = 'part_cart_main']"));
        public IWebElement clientName => Driver.FindElement(By.Name("client_fio"));
        public IWebElement clientPhone => Driver.FindElement(By.Name("client_phone"));
        public IWebElement proceedButton => Driver.FindElement(By.XPath("//div[@class = 'next_step']"));
        public IWebElement deliveryOption => Driver.FindElement(By.XPath("//label[text() = 'Курьером Новой Почты']/../../td/input"));
        public IWebElement trigger => Driver.FindElement(By.XPath("//div[text() = 'Не выбрано']/../b"));
        public IWebElement deliverydetails => Driver.FindElement(By.XPath("//li[@title = 'Не нужен']")); //id = -1
        public IWebElement placeOrderLabel => Driver.FindElement(By.XPath("//div[@class = 'client_info']/p"));
        public IWebElement firstStepPlaceOrder => Driver.FindElement(By.XPath("//span[@class ='first green']"));
    }
}
