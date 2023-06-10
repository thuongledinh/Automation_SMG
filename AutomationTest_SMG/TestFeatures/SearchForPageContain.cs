using CoreFrameWork;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject.PageObject.WikiSearch;

namespace TestProject.TestFeatures
{
    [TestFixture]
    class SearchForPageContain:MasterTest
    {
        [TestCase("Software", "Software")]
        [TestCase("Software testing", "Software testing")]
        [TestCase("!@#$%^&", "!@#$%^&")]
        public static void UserCanSearchForPageContainsASpecificText(string searchString, string defaultSearchStringOnSearchPage)
        {
            {
                SearchPage.UserGoToMainPage();
                SearchPage.UserInputTheSearchTextToSearchBox(searchString);
                SearchPage.UserClickOnSearchForPageContainOptionFromTheResultList();
                SearchPage.UserIsRedirectedToSearchPageContain();
                SearchPage.VerifyTheSearchTextIsPrefilledByDefault(defaultSearchStringOnSearchPage);
            }
        }
    }
}
