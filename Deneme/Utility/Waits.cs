using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SwagLabs.Utility
{
    public class Waits
    {
        private static WebDriverWait _wait;

        // Wait For - Hard Wait
        public static void waitFor(int sec)
        {
            try
            {
                Thread.Sleep(sec * 1000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // Wait For Visibility
        public static IWebElement waitForVisibility(By locator, int timeout)
        {
            try
            {
                _wait = new WebDriverWait(Driver.getDriver(), TimeSpan.FromSeconds(timeout));
                IWebElement element = _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
                return element;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            

        }

        // Wait For Clickablility
        public static IWebElement waitForClickablility(IWebElement element, int timeout)
        {
            try
            {
                _wait = new WebDriverWait(Driver.getDriver(), TimeSpan.FromSeconds(timeout));
                IWebElement webElement = _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
                return webElement;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }


        }
    }
}
