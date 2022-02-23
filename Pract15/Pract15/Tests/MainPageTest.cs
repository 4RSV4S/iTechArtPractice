using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Pract15
{
    [TestFixture]
    public class MainPageTest : BaseTest
    {
        [Test]
        public void Scenario3()
        {
            MainPage.OpenPage();

            var isPageLoaded = Wait.Until(d =>
            {
                var result = ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState");
                return result.Equals("complete");
            });

            if (isPageLoaded)
            {
                MainPage.Input_Search.SendKeys("Смартфон");
            }
            else Assert.Fail();

            Wait.Until(d => MainPage.IFrame_Search);
            Driver.SwitchTo().Frame(MainPage.IFrame_Search);

            Wait.Until(d => MainPage.A_SearchResultTitleList.Count > 0);
            var firstElementTitle = MainPage.A_SearchResultTitleList[0].Text;

            MainPage.Input_IFrameSearch.Clear();
            MainPage.Input_IFrameSearch.SendKeys(firstElementTitle);

            Wait.Until(d => MainPage.A_SearchResultTitleList.Count > 0);
            MainPage.A_SearchResultTitleList[0].Click();

            Assert.AreEqual(MainPage.H1_CatalogTitle.Text, firstElementTitle);
        }

    }
}
