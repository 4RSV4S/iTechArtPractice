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

            tvPage.CheckBoxList[0].Click();
            Assert.AreEqual(tvPage.CheckBoxList[0].GetAttribute("title"), "В сравнении");
            tvPage.CheckBoxList[1].Click();
            Assert.AreEqual(tvPage.CheckBoxList[1].GetAttribute("title"), "В сравнении");

            ComparisonPage comparisonPage = new ComparisonPage(Driver);
            comparisonPage.Button_Compare.Click();
        }
    }
}
