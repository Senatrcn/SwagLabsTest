using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SwagLabs.Utility
{
    public class JseHelper
    {
        private static IJavaScriptExecutor jse = (IJavaScriptExecutor)Driver.getDriver();

        // Clicks the Web Element with Javascript Executor
        public static void clickWithJse(WebElement element)
        {
           jse.ExecuteScript("arguments[0].click();", element);
        }

        // SendKeys with Javascript Executor
        public static void sendKeysWithJse(IWebElement element,String text)
        {
            jse.ExecuteScript("arguments[0].value =’"+text+"’;", element);
        }

        // Scroll Into View
        public static void scrollIntoView(By locator)
        {
            jse.ExecuteScript("arguments[0].scrollIntoView();", locator);
            Waits.waitForVisibility(locator, 3);
        }

       



    }
}
