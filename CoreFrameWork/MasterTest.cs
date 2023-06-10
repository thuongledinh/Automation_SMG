using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreFrameWork
{
    [TestFixture]
    public class MasterTest
    {
        public static IWebDriver driver = DriverFactory.getWebDriver("chrome", DriverFactory.ChromeVersion["114"]);
        
        [OneTimeSetUp]
        public static void Setup()
        {
            driver = DriverFactory.getWebDriver("chrome", DriverFactory.ChromeVersion["114"]);
        }


        [OneTimeTearDown]
        public static void TearDown()
        {
            DriverFactory.TerminateWebDriver();
        }

    }
}
