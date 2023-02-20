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
using OpenQA.Selenium.Interactions;

namespace SwagLabs.Pages
{
    public class LoginPage
    {
        private IWebDriver _driver;
        private IWebElement _usernameTextbox => _driver.FindElement(By.Name("user-name"));
        private IWebElement _passwordTextbox => _driver.FindElement(By.Id("password"));
        private IWebElement _loginButton => _driver.FindElement(By.Id("login-button"));
        private IWebElement _errorMessage => _driver.FindElement(By.XPath("//h3[contains(text(),'not match any user')]"));

        private IWebElement _lockedUserMessage => _driver.FindElement(By.XPath("//h3[contains(text(),'locked out')]"));

        private IWebElement _problemUserImages => _driver.FindElement(By.XPath("//img[@src='/static/media/sl-404.168b1cce.jpg']"));

        private IWebElement _productsTitle => _driver.FindElement(By.XPath("//span[text()='Products']"));
        public LoginPage()
        {
            _driver = Driver.getDriver();
        }

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
        }

        public void CheckValidLogin()
        {
            Asserts.assertTrue(_productsTitle.Displayed);
        }

        public void CheckInvalidLogin()
        {
            Asserts.assertTrue(_errorMessage.Displayed);
        }
        public void CheckInvalidLoginForLockedUser()
        {
            Asserts.assertTrue(_lockedUserMessage.Displayed);
        }

        public void CheckLoginForProblemUser()
        {
            Asserts.assertTrue(_problemUserImages.Displayed);
        }


    }
}
