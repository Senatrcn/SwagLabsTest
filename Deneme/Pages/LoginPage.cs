using SwagLabs.Utility;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabs.Pages
{
    public class LoginPage
    {
        public LoginPage() 
        {

        }
        private IWebDriver _driver => Driver.getDriver();
        private IWebElement _usernameTextbox => _driver.FindElement(By.Id("user-name"));
        private IWebElement _passwordTextbox => _driver.FindElement(By.Id("password"));
        private IWebElement _loginButton => _driver.FindElement(By.Id("login-button"));
        private IWebElement _errorMessage => _driver.FindElement(By.XPath("//h3[contains(text(),'not match any user')]"));

        private IWebElement _lockedUserMessage => _driver.FindElement(By.XPath("//h3[contains(text(),'locked out')]"));

        private IWebElement _problemUserImages => _driver.FindElement(By.XPath("//img[@src='/static/media/sl-404.168b1cce.jpg']"));

        private IWebElement _productsTitle => _driver.FindElement(By.XPath("//span[text()='Products']"));
       

        public void NavigatesToLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com");
           
        }
        public void enterCredentials(string username, string password)
        {
            _usernameTextbox.SendKeys(username);
            _passwordTextbox.SendKeys(password);
        }

        public void clickLoginButton()
        {
            _loginButton.Click();
            Waits.waitFor(1);
        }

        public void CheckValidLogin()
        {
            Asserts.assertTrue(_productsTitle.Displayed);
        }

        public void CheckInvalidLogin()
        {
            Waits.waitForClickablility(_errorMessage, 3);
            Asserts.assertTrue(_errorMessage.Displayed);
        }
        public void CheckInvalidLoginForLockedUser()
        {
            //ReusableMethods.waitForClickablility(_lockedUserMessage, 3);
            Asserts.assertTrue(_lockedUserMessage.Displayed);
        }

        public void CheckLoginForProblemUser()
        {
            Waits.waitForClickablility(_problemUserImages,5);
            Asserts.assertTrue(_problemUserImages.Displayed);
        }

        /*
                public void CheckItemsNamesWithFalseCondition()
                {
                    ReadOnlyCollection<IWebElement> displayedOptions = DriverControl.FindElements(By.XPath("//div[@class='inventory_item_name']"));
                    for (int i = 0; i < displayedOptions.Count; i++)
                    {
                        DriverControl.SwitchToDefaultContent();
                        var option = DriverControl.FindElement(By.XPath("(//div[@class='inventory_item_name'])[" + (i + 1) + "]"));
                        if (option.Displayed)
                        {
                            var firstProductTitle = option.Text;
                            option.Click();
                            System.Threading.Thread.Sleep(1000);
                            var ActualProductTitle = DriverControl.FindElement(By.XPath("//div[@class='inventory_details_name large_size']"));
                            Assert.False(firstProductTitle.Equals(ActualProductTitle.Text));
                            DriverControl.NavigateBack();
                            System.Threading.Thread.Sleep(2000);
                        }
                    }
                }
                public void CheckItemsImagesWithFalseCondition()
                {
                    ReadOnlyCollection<IWebElement> displayedOptions = DriverControl.FindElements(By.XPath("//img[@class='inventory_item_img']"));
                    for (int i = 0; i < displayedOptions.Count; i++)
                    {
                        DriverControl.SwitchToDefaultContent();
                        var option = DriverControl.FindElement(By.XPath("(//img[@class='inventory_item_img'])[" + (i + 1) + "]"));
                        if (option.Displayed)
                        {
                            var productImage = option.GetAttribute("src");
                            option.Click();

                            var ActualProductImage = DriverControl.FindElement(By.XPath("//img[@class='inventory_details_img']"));
                            Assert.False(productImage.Equals(ActualProductImage.GetAttribute("src")));
                            DriverControl.NavigateBack();

                        }
                    }
                }
                public void CheckItemsNamesWithTrueCondition()
                {
                    ReadOnlyCollection<IWebElement> displayedOptions = DriverControl.FindElements(By.XPath("//div[@class='inventory_item_name']"));
                    for (int i = 0; i < displayedOptions.Count; i++)
                    {
                        DriverControl.SwitchToDefaultContent();
                        var option = DriverControl.FindElement(By.XPath("(//div[@class='inventory_item_name'])[" + (i + 1) + "]"));
                        if (option.Displayed)
                        {
                            var firstProductTitle = option.Text;
                            option.Click();
                            System.Threading.Thread.Sleep(1000);
                            var ActualProductTitle = DriverControl.FindElement(By.XPath("//div[@class='inventory_details_name large_size']"));
                            Assert.True(firstProductTitle.Equals(ActualProductTitle.Text));
                            DriverControl.NavigateBack(); ;
                            System.Threading.Thread.Sleep(2000);
                        }
                    }
                }
                public void AddProduct()
                {
                    var product = DriverControl.FindElement(By.XPath("(//div[@class='inventory_item_name'])[2]"));
                    product.Click();
                    var addToCart = DriverControl.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));
                    addToCart.Click();

                }

                public string PurchaseProductSuccessfully()
                {
                    var shoppingBadge = DriverControl.FindElement(By.XPath("//span[@class='shopping_cart_badge']"));
                    shoppingBadge.Click();
                    var checkout = DriverControl.FindElement(By.Id("checkout"));
                    checkout.Click();
                    var firstName = DriverControl.FindElement(By.Id("first-name"));
                    firstName.SendKeys("Kadir");
                    var lastName = DriverControl.FindElement(By.Id("last-name"));
                    lastName.SendKeys("Yayla");
                    var zipCode = DriverControl.FindElement(By.Id("postal-code"));
                    zipCode.SendKeys("06930");
                    var continuePurchase = DriverControl.FindElement(By.Id("continue"));
                    continuePurchase.Click();
                    var finishTransaction = DriverControl.FindElement(By.Id("finish"));
                    finishTransaction.Click();
                    string completePurchase = DriverControl.FindElement(By.XPath("//h2[@class='complete-header']")).Text;
                    return completePurchase;

                }
        */

    }
}
