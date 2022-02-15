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
            TVPage tvPage = new TVPage(Driver);

            tvPage.LabelList[0].Click();
            Assert.IsTrue(tvPage.InputList[0].Selected);
            tvPage.LabelList[1].Click();
            Assert.IsTrue(tvPage.InputList[1].Selected);

            ComparisonPage comparisonPage = new ComparisonPage(Driver);
            comparisonPage.Button_Compare.Click();
            comparisonPage.MoveToElement(comparisonPage.Span_Cell_ScreenВiagonal);
            Thread.Sleep(6000);
        }
    }
}
