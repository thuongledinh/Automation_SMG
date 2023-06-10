using CoreFrameWork;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.PageObject.WikiSearch
{
    class SearchPageRepo
    {
        public static IWebDriver driver = MasterTest.driver;
        public static string mainPageUrl = "https://wikipedia.org/wiki/Main_Page";

        public static string searchBox = "//input[@name='search']";
        public static string searchBtn = "//button[.='search']";
        public static string searchPageContainOpt = "//span[text()='Search for pages containing ']";
        public static string searchPageContainTitle = "//h1[.='Search results']";
        public static string searchBoxOnSearchPageContain = "//input[@title='Search Wikipedia']";
    }
}
