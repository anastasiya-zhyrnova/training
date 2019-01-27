using MoyoFramework.PageActions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MoyoFramework.Steps
{
    [Binding]
    class CartPageSteps
    {
        [When(@"I delete product from the cart")]
        public void WhenIDeleteProductFromTheCart()
        {
            CartPageActions cart = new CartPageActions();
            cart.DeleteItemFromCart();
        }

        [When(@"I proceed to the order")]
        public void WhenIProceedToTheOrder()
        {
            CartPageActions cart = new CartPageActions();
            cart.FillClientInfo();
            cart.ProceedTheOrder();
            cart.ChooseDeliveryOptions();
            cart.ProceedTheOrder();
        }

        [Then(@"I am on the second step of order placement process")]
        public void ThenIAmOnTheSecondStepOfOrderPlacementProcess()
        {
            CartPageActions cart = new CartPageActions();
            string actualText = cart.GetTextFromOrderPlaceLabel();
        }

        [Then(@"I first step of order placement process is completed successfully")]
        public void ThenIFirstStepOfOrderPlacementProcessIsCompletedSuccessfully()
        {
            CartPageActions cart = new CartPageActions();
            string actualText = cart.GetStatusOfFirstStepOfOrderPlacement();
            string expectedText = "Шаг 1 выполнен";
            Assert.AreEqual(expectedText, actualText);
        }





        [Then(@"product is added to the cart")]
        public void ThenProductIsAddedToTheCart()
        {
            CartPageActions cart = new CartPageActions();
            ScenarioContext.Current.TryGetValue("AddedItem", out string itemId);
            int actualId = cart.GetItemId();
            int expectedId;
            Int32.TryParse(itemId, out expectedId);
            Assert.AreEqual(expectedId, actualId);
        }

        [Then(@"product is no longer present in my cart")]
        public void ThenProductIsNoLongerPresentInMyCart()
        {
            CartPageActions cart = new CartPageActions();
            //ScenarioContext.Current.TryGetValue("AddedItem", out string itemId);
            string actualState = cart.GetTextFromEmptyCart();
            string expectedState = "В корзине нет товаров";
            Assert.AreEqual(expectedState, actualState);
        }

    }
}
