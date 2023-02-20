using SwagLabs.Utility;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabs.Pages
{
    public class CartPage {

        private IWebDriver _driver;
        private IWebElement _title => _driver.FindElement(By.XPath("//span[text()='Your Cart']"));
        private IList<IWebElement> _inventoryList => _driver.FindElements(By.ClassName("inventory_item_name"));
        private IList<IWebElement> _removeButtons => _driver.FindElements(By.XPath("//button[contains(@id,'remove')]"));
        private IWebElement _checkoutButton => _driver.FindElement(By.Id("checkout"));

        public CartPage()
        {
            _driver = Driver.getDriver();
        }

        public void verifyOwnCartPage()
        {
            Asserts.assertTrue(_title.Displayed);
        }

        public void clicksOnCheckOutButton()
        {
            _checkoutButton.Click();
        }

        public void removeFromCart(int count)
        {
            for (int i = 0; i < count; i++)
            {
                _removeButtons.ElementAt(i).Click();
            }
        }

        public void verifySelectProductRemoved()
        {
            Asserts.assertFalse(_removeButtons.ElementAt(0).Displayed);
        }
    }
}
