using SwagLabs.Pages;
using SwagLabs.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SwagLabs.StepDefinitions
{
    [Binding]
    public class AddToCartSteps
    {
        private ProductsPage productsPage = new ProductsPage();
        private CartPage cartPage = new CartPage();

        [When(@"User clicks the add to cart button\t(.*) times")]
        public void WhenUserClicksTheAddToCartButtonTimes(int count)
        {
            productsPage.addToCart(count);

        }

        [When(@"User sees the correct number (.*) on the shopping cart item")]
        public void WhenUserSeesTheCorrectNumberOnTheShoppingCartItem(int count)
        {
            productsPage.checkNumOfCart(count);
        }


        [When(@"User goes to cart page")]
        public void WhenUserGoesToCartPage()
        {
            productsPage.goToCart();
            cartPage.verifyOwnCartPage();
        }

        [When(@"User clicks the remove button (.*) times in product page")]
        public void WhenUserClicksTheRemoveButtonTimesInProductPage(int count)
        {
            productsPage.removeFromCart(count);
        }

        [When(@"User clicks the remove button (.*) times in cart page")]
        public void WhenUserClicksTheRemoveButtonTimesInCartPage(int count)
        {
            cartPage.removeFromCart(count);
        }


        [Then(@"User sees the correct number (.*) on the shopping cart item")]
        public void ThenUserSeesTheCorrectNumberOnTheShoppingCartItem(int count)
        {
            productsPage.checkNumOfCart(count);
        }

        [Then(@"User sees the cart is empty")]
        public void ThenUserSeesTheCartIsEmpty()
        {
            cartPage.verifySelectProductRemoved();
        }


    }
}
