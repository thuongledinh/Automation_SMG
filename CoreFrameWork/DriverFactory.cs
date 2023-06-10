using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;

namespace CoreFrameWork
{
    public class DriverFactory
    {
        internal static IWebDriver Driver { get; set; }
        public static IDictionary<string, string> ChromeVersion = new Dictionary<string, string>(){
            {"114",""}
        };


        public static IWebDriver getWebDriver(string driverName, string driverPath) 
        {

            if (Driver == null)
            {
                {
                    switch (driverName.ToLower())
                    {
                        case "chrome":
                            Driver = new ChromeDriver(driverPath);                        
                            break;

                        case "firefox":
                            Driver = new FirefoxDriver(driverPath);
                            break;

                        case "Edge":
                            Driver = new EdgeDriver(driverPath);
                            break;
                        default:
                            throw new NotSupportedException("the web browser is not supported!");

                    }
                }
            }
            Driver.Manage().Window.Maximize();
            return Driver;      
        }

        public static void TerminateWebDriver()
        {
            Driver.Close();
            Driver = null;
        }


    }
}
