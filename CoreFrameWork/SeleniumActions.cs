using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreFrameWork
{
    public class SeleniumActions
    {
        internal IWebDriver Driver = DriverFactory.Driver;

        public static void Click(string WebLocator)
        {
            IWebElement element = WaitManagement.WaitForElementToBeClickable(WebLocator);
            try
            {
                element.Click();
            }
            catch (StaleElementReferenceException e)
            {
                throw;
            }
        }

        public static void ClearAndTypeText(string webLocator, string text)
        {
            ClearText(webLocator);
            IWebElement element = WaitManagement.WaitForElementToBeClickable(webLocator);
            try
            {
                element.SendKeys(text);
            }
            catch (WebDriverException e)
            {
                throw;
            }
        }

        public static void ClearText(string webLocator)
        {
            IWebElement element = WaitManagement.WaitForElementToBeClickable(webLocator);
            try
            {
                element.Clear();
            }
            catch (WebDriverException e)
            {
                throw;
            }
        }

        public static bool IsVisible(string webLocation)
        {
            bool isVisible;
            try
            {
                WaitManagement.WaitForElementToBeVisible(webLocation);
                isVisible = true;
            }
            catch (WebDriverException)
            {
                isVisible = false;
            }
            return isVisible;
        }
    }
}
