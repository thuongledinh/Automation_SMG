using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using EC = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace CoreFrameWork
{
    public class WaitManagement
    {
        internal static WebDriverWait defaultWait;
        internal static WebDriverWait wait;
        internal static IWebDriver Driver = DriverFactory.Driver;
        internal static int defaultTimeout = 30;

        internal static WebDriverWait InitDefaultWait()
        {
            if (defaultWait == null)
            {
                defaultWait = new WebDriverWait(Driver, TimeSpan.FromSeconds(defaultTimeout));
                defaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException),
                                                 typeof(ElementNotVisibleException),
                                                 typeof(StaleElementReferenceException));
            }
            return defaultWait;
        }

        public static void WaitForPageLoadReady()
        {
            bool isJqueryDefined = (bool)((IJavaScriptExecutor)Driver).ExecuteScript("return (!!window.jQuery)");
            if (isJqueryDefined)
            {
                wait = InitDefaultWait();
                wait.IgnoreExceptionTypes(typeof(Exception));
                try
                {
                    wait.Until(webDriver =>
                    {
                        bool isAjaxAndJsFinished = (bool)((IJavaScriptExecutor)webDriver).
                            ExecuteScript("return ((document.readyState == 'complete') && (jQuery.active == 0))");
                        return isAjaxAndJsFinished;
                    });
                }
                catch (WebDriverException e)
                {
                    throw;
                }
            }
        }

        public static IWebElement WaitForElementToBeVisible(string WebLocation)
        {
            wait = wait = InitDefaultWait();
            try
            {
                return wait.Until(EC.ElementIsVisible(By.XPath(WebLocation)));
            }
            catch (WebDriverException e)
            {
                throw;
            }
        }

        public static IWebElement WaitForElementToBeClickable(string WebLocation)
        {
            wait = InitDefaultWait();
            try
            {
                return wait.Until(EC.ElementToBeClickable(By.XPath(WebLocation)));
            }
            catch (WebDriverException e)
            {
                throw;
            }
        }

      
        public static void StaticWait(int second)
        {
            Thread.Sleep(second*1000);
        }



    }
}
