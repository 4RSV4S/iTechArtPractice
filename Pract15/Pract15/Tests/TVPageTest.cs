using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Pract15.Tests
{
    [TestFixture]
    public class TVPageTest : BaseTest
    {
        [Test]
        public void Scenario1()
        {
            TVPage.OpenPage();
            TVPage.LabelList[0].Click();
            TVPage.LabelList[1].Click();

            Assert.IsTrue(TVPage.InputList[0].Selected);
            Assert.IsTrue(TVPage.InputList[1].Selected);

            TVPage.Button_Compare.Click();
            ComparisonPage.MoveTo(ComparisonPage.Td_Cell_ScreenDiagonal);

            var isSpanEnabled = Wait.Until(d => ComparisonPage.Span_Cell_ScreenDiagonal.Enabled);
            
            if (isSpanEnabled)
            {
                ComparisonPage.Span_Cell_ScreenDiagonal.Click();
            }
            
            var isTableTipDisplayed = Wait.Until(d => ComparisonPage.Div_TableTip.Displayed);
            
            if (isTableTipDisplayed)
            {
                ComparisonPage.Span_Cell_ScreenDiagonal.Click();
            }
            
            var isTableTipNotDisplayed = Wait.Until(d =>
            {
                if (ComparisonPage.Div_TableTip.Displayed)
                {
                    return false;
                }
                return true;
            });

            if (isTableTipNotDisplayed)
            {
                ComparisonPage.A_DeleteList[0].Click();
            }

            var isPageLoaded = Wait.Until(d =>
            {
                var result = ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState");
                return result.Equals("complete");
            });

            Assert.IsTrue(isPageLoaded);
        }

        [Test]
        public void Scenario2()
        {
            TVPage.OpenPage();

            TVPage.AppleStoreLink.Click();
            Wait.Until(d => d.WindowHandles.Count == 2);

            Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            TVPage.GooglePlayLink.Click();

            Wait.Until(d => d.WindowHandles.Count == 3);

            Driver.SwitchTo().Window(Driver.WindowHandles[2]);

            var isPageLoaded = Wait.Until(d =>
            {
                var result = ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState");
                return result.Equals("complete");
            });

            if (isPageLoaded)
            {
                GooglePlayPage.MoreLink.Click();
                //Log($"Amount of simular apps is {GooglePlayPage.SimularAppsList.Count}");
            }

            Driver.SwitchTo().Window(Driver.WindowHandles[1]);

            AppleStorePage.MoreLink.Click();

            Driver.Close();

            Driver.SwitchTo().Window(Driver.WindowHandles[0]);

            Driver.SwitchTo().Frame(TVPage.IFrame_GoogleAds);
            TVPage.AdLink.Click();
        }
    }
}
