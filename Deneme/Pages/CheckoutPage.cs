using OpenQA.Selenium;
using SwagLabs.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabs.Pages
{
    public class CheckoutPage
    {
        private IWebDriver _driver;
        private IWebElement _firstName => _driver.FindElement(By.Name("firstName"));
        private IWebElement _lastName => _driver.FindElement(By.Name("lastName"));
        private IWebElement _postalCode => _driver.FindElement(By.Name("postalCode"));
        private IWebElement _continueButton => _driver.FindElement(By.Id("continue"));
        private IWebElement _cancelButton => _driver.FindElement(By.Id("cancel"));
        private IWebElement _overviewTitle => _driver.FindElement(By.XPath("//span[text()='Checkout: Overview']"));
        private IWebElement _finishButton => _driver.FindElement(By.Id("finish"));
        private IWebElement _cartItem => _driver.FindElement(By.ClassName("cart_item"));
        public CheckoutPage()
        {
            _driver = Driver.getDriver();
        }

        public void verifyCheckoutPage()
        {
            Waits.waitForClickablility(_firstName, 5);
            Asserts.assertTrue(_firstName.Displayed);
        }
        public void verifyOverviewPage()
        {
            Waits.waitForClickablility(_overviewTitle, 5);
            Asserts.assertTrue(_overviewTitle.Displayed);
        }

        public void fillInformationForm(string firstname, string lastname, string postalcode)
        {
            _firstName.SendKeys(firstname);
            _lastName.SendKeys(lastname);
            _postalCode.SendKeys(postalcode);
        }
        public void clickContinueButton()
        {
            Waits.waitForClickablility(_continueButton, 3);
            _continueButton.Click();
        }
        public void clickCancelButton()
        {
            Waits.waitForClickablility(_cancelButton, 3);
            _cancelButton.Click();
        }
        public void clickFinishButton()
        {
            Waits.waitForClickablility(_finishButton, 3);
            _finishButton.Click();
        }
    }
}
