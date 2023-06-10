using CoreFrameWork;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.PageObject.WikiSearch
{
    class SearchPage: SearchPageRepo
    {

        internal static void UserGoToMainPage()
        {
            driver.Url = mainPageUrl;
        }

        internal static void UserInputTheSearchTextToSearchBox(string text)
        {
            SeleniumActions.ClearAndTypeText(searchBox, text);
        }

        internal static void UserClickOnSearchForPageContainOptionFromTheResultList()
        {
            WaitManagement.StaticWait(2);
            SeleniumActions.Click(searchPageContainOpt);
        }

        internal static void VerifyTheSearchTextIsPrefilledByDefault(string expectedText)
        {
            string text = WaitManagement.WaitForElementToBeVisible(searchBoxOnSearchPageContain).GetAttribute("value");
            StringAssert.AreEqualIgnoringCase(expectedText, text);
        }

        internal static void UserIsRedirectedToSearchPageContain()
        {
            WaitManagement.WaitForPageLoadReady();
            WaitManagement.StaticWait(2);
            bool isDisplay = SeleniumActions.IsVisible(searchPageContainTitle);
            if (!isDisplay) { Assert.Fail(); }
        }
    }
}
