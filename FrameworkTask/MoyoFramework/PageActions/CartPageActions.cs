using MoyoFramework.Core;
using MoyoFramework.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace MoyoFramework.PageActions
{
    class CartPageActions
    {
        private CartPage cart;
        private IWebDriver _driver;

        public CartPageActions()
        {
            cart = new CartPage();
            _driver = SeleniumDriver.Driver;
        }

        public int GetNumberOfProductsInCart()
        {
            return cart.products.Count;            
        }

        public int GetItemId()
        {
            int itemId;
            var raw = cart.itemId.GetAttribute("value").ToString();
            try
            {
                Int32.TryParse(raw, out itemId);
                return itemId;
            } 
            catch (Exception exception)
            {
                Console.WriteLine("Exception when parsing id");
            }
            return -1;  
        }

        public void DeleteItemFromCart()
        {
            cart.deleteItemFromCart.Click();
        }

        public string GetTextFromEmptyCart()
        {
            return (cart.cartLabel).Text;
        }

        public void FillClientInfo()
        {
            cart.clientName.SendKeys("Ivan Ivanov");
            cart.clientPhone.SendKeys("999999999");
        }

        public void ChooseDeliveryOptions()
        {
            Actions action = new Actions(_driver);
            cart.deliveryOption.Click();
            action.MoveToElement(cart.trigger).Click();
            cart.trigger.Click();
            action.MoveToElement(cart.deliverydetails).Click();
        }

        public string GetTextFromOrderPlaceLabel()
        {
            return cart.placeOrderLabel.Text;
        }

        public string GetStatusOfFirstStepOfOrderPlacement()
        {
            return cart.firstStepPlaceOrder.Text;
        }

        public void ProceedTheOrder()
        {
            cart.proceedButton.Click();
        }

    }
}
