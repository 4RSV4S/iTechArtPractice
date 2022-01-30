using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Pract12
{
    class CalsTest1
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            CalcLaminatePage page = new CalcLaminatePage(driver);
            page.OpenCalcLaminatePage();
            Assert.AreEqual("https://calc.by/building-calculators/laminate.html", driver.Url);
            page.ChooseLayingMethod("с использованием отрезанного элемента");
            page.EnterRoomLength("500");
            page.EnterRoomWidth("400");
            page.EnterPanelLength("2000");
            page.EnterPanelWidth("200");
            page.ChooseLayingDirection("по ширине комнаты");
            page.ClickCalculateButton();
            Assert.AreEqual("53", page.GetRequiredBoardsNumber().Text);
            Assert.AreEqual("7", page.GetPackagesNumber().Text);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
