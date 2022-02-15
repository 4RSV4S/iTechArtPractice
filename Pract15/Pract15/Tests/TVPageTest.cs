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
            //Assert.AreEqual(tvPage.LabelList[0].GetAttribute("title"), "В сравнении");
            //tvPage.InputList[0].Click();
            tvPage.LabelList[1].Click();
            Assert.AreEqual(tvPage.LabelList[1].GetAttribute("title"), "В сравнении");

            ComparisonPage comparisonPage = new ComparisonPage(Driver);
            comparisonPage.Button_Compare.Click();
        }
    }
}
